using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CTR_V
{
    
    public partial class CTRV : Form
    {
        
        public CTRV()
        {
            //Start all Components;
            InitializeComponent();
        }

        public string host;
        public int port;
        public TcpClient tcp;
        public NetworkStream netStream;
        public Thread packetRecvThread;
        private object syncLock = new object();
        int heartbeatSendable;

        uint currentSeq;
        uint lastReadMemSeq;
        string lastReadMemFileName = null;
        public volatile int progress = -1;
        private bool MemPatch;

        int readNetworkStream(NetworkStream stream, byte[] buf, int length)
        {
            int index = 0;
            bool useProgress = false;

            if (length > 100000)
            {
                useProgress = true;
            }
            do
            {
                if (useProgress)
                {
                    progress = (int)(((double)(index) / length) * 100);
                }
                int len = stream.Read(buf, index, length - index);
                if (len == 0)
                {
                    return 0;
                }
                index += len;
            } while (index < length);
            progress = -1;
            return length;
        }

        void packetRecvThreadStart()
        {
            byte[] buf = new byte[84];
            uint[] args = new uint[16];
            int ret;
            NetworkStream stream = netStream;

            while (true)
            {
                try
                {
                    ret = readNetworkStream(stream, buf, buf.Length);
                    if (ret == 0)
                    {
                        break;
                    }
                    int t = 0;
                    uint magic = BitConverter.ToUInt32(buf, t);
                    t += 4;
                    uint seq = BitConverter.ToUInt32(buf, t);
                    t += 4;
                    uint type = BitConverter.ToUInt32(buf, t);
                    t += 4;
                    uint cmd = BitConverter.ToUInt32(buf, t);
                    for (int i = 0; i < args.Length; i++)
                    {
                        t += 4;
                        args[i] = BitConverter.ToUInt32(buf, t);
                    }
                    t += 4;
                    uint dataLen = BitConverter.ToUInt32(buf, t);
                    if (cmd != 0)
                    {
                        log(String.Format("packet: cmd = {0}, dataLen = {1}", cmd, dataLen));
                    }

                    if (magic != 0x12345678)
                    {
                        log(String.Format("broken protocol: magic = {0}, seq = {1}", magic, seq));
                        break;
                    }

                    if (cmd == 0)
                    {
                        if (dataLen != 0)
                        {
                            byte[] dataBuf = new byte[dataLen];
                            readNetworkStream(stream, dataBuf, dataBuf.Length);
                            string logMsg = Encoding.UTF8.GetString(dataBuf);
                            log(logMsg);
                        }
                        lock (syncLock)
                        {
                            heartbeatSendable = 1;
                        }
                        continue;
                    }
                    if (dataLen != 0)
                    {
                        byte[] dataBuf = new byte[dataLen];
                        readNetworkStream(stream, dataBuf, dataBuf.Length);
                        handlePacket(cmd, seq, dataBuf);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    break;
                }
            }
            
            disconnect(false,false);
        }

        string byteToHex(byte[] datBuf, int type)
        {
            string r = "";
            for (int i = 0; i < datBuf.Length; i++)
            {
                r += datBuf[i].ToString("X2") + " ";
            }
            return r;
        }

        void handleReadMem(uint seq, byte[] dataBuf)
        {
            if (seq != lastReadMemSeq)
            {
                log("seq != lastReadMemSeq, ignored");
                return;
            }
            lastReadMemSeq = 0;
            string fileName = lastReadMemFileName;
            if (fileName != null)
            {
                FileStream fs = new FileStream(fileName, FileMode.Create);
                fs.Write(dataBuf, 0, dataBuf.Length);
                fs.Close();
                log("dump saved into " + fileName + " successfully");
                return;
            }
            log(byteToHex(dataBuf, 0));

        }

        void handlePacket(uint cmd, uint seq, byte[] dataBuf)
        {
            if (cmd == 9)
            {
                handleReadMem(seq, dataBuf);
            }
        }

        public void setServer(String serverHost, int serverPort)
        {
            host = serverHost;
            port = serverPort;
        }

        public void connectToServer()
        {
            log("Connecting to System...");

            BackgroundWorker bw = new BackgroundWorker();
            bw.WorkerSupportsCancellation = true;
            bw.WorkerReportsProgress = true;

            bw.DoWork += Bw_DoWork;
            bw.ProgressChanged += Bw_ProgressChanged;
            bw.RunWorkerCompleted += Bw_RunWorkerCompleted;

            bw.RunWorkerAsync();

        }

        private void Bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled == false && e.Error == null)
            {
                currentSeq = 0;
                netStream = tcp.GetStream();
                heartbeatSendable = 1;
                packetRecvThread = new Thread(new ThreadStart(packetRecvThreadStart));
                packetRecvThread.Start();
                log("[Connected!]");
                StartViewer();
            }
        }

        private void Bw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            log(e.UserState.ToString());
        }

        private void Bw_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker bw = (BackgroundWorker)sender;
            try
            {
                if (tcp != null)
                {
                    bw.ReportProgress(10, "OK: Creating new connection");
                    disconnect();
                }
                tcp = new TcpClient();
                tcp.NoDelay = true;
                tcp.Connect(host, port);
            }
            catch (Exception ex)
            {
                bw.ReportProgress(0, "ERR: " + ex.Message.ToString());
                e.Cancel = true;
            }
        }

        public void disconnect(bool waitPacketThread = false,bool uselog = true)
        {
            if (uselog == true) { log("Disconnecting Debugger in 2 Seconds..."); }
            try
            {
                if (tcp != null)
                {
                    tcp.Close();
                }
                if (waitPacketThread)
                {
                    if (packetRecvThread != null)
                    {
                        packetRecvThread.Join();
                    }
                }
            }
            catch (Exception ex)
            {
                log(ex.Message);
            }
            tcp = null;
            if (uselog == true) { log("[Disconnected!]"); }
        }

        public void sendPacket(uint type, uint cmd, uint[] args, uint dataLen)
        {
            int t = 0;
            currentSeq += 1000;
            byte[] buf = new byte[84];
            BitConverter.GetBytes(0x12345678).CopyTo(buf, t);
            t += 4;
            BitConverter.GetBytes(currentSeq).CopyTo(buf, t);
            t += 4;
            BitConverter.GetBytes(type).CopyTo(buf, t);
            t += 4;
            BitConverter.GetBytes(cmd).CopyTo(buf, t);
            for (int i = 0; i < 16; i++)
            {
                t += 4;
                uint arg = 0;
                if (args != null)
                {
                    arg = args[i];
                }
                BitConverter.GetBytes(arg).CopyTo(buf, t);
            }
            t += 4;
            BitConverter.GetBytes(dataLen).CopyTo(buf, t);
            netStream.Write(buf, 0, buf.Length);
        }

        public void sendReadMemPacket(uint addr, uint size, uint pid, string fileName)
        {
            sendEmptyPacket(9, pid, addr, size);
            lastReadMemSeq = currentSeq;
            lastReadMemFileName = fileName;
        }

        public void sendWriteMemPacket(uint addr, uint pid, byte[] buf)
        {
            uint[] args = new uint[16];
            args[0] = pid;
            args[1] = addr;
            args[2] = (uint)buf.Length;
            sendPacket(1, 10, args, args[2]);
            netStream.Write(buf, 0, buf.Length);
        }

        public void sendHeartbeatPacket()
        {
            if (tcp != null)
            {
                lock (syncLock)
                {
                    if (heartbeatSendable == 1)
                    {
                        heartbeatSendable = 0;
                        sendPacket(0, 0, null, 0);
                    }
                }
            }

        }

        public void sendHelloPacket()
        {
            sendPacket(0, 3, null, 0);
        }

        public void sendReloadPacket()
        {
            sendPacket(0, 4, null, 0);
        }

        public void sendEmptyPacket(uint cmd, uint arg0 = 0, uint arg1 = 0, uint arg2 = 0)
        {
            uint[] args = new uint[16];

            args[0] = arg0;
            args[1] = arg1;
            args[2] = arg2;
            sendPacket(0, cmd, args, 0);
        }



        public void sendSaveFilePacket(string fileName, byte[] fileData)
        {
            byte[] fileNameBuf = new byte[0x200];
            Encoding.UTF8.GetBytes(fileName).CopyTo(fileNameBuf, 0);
            sendPacket(1, 1, null, (uint)(fileNameBuf.Length + fileData.Length));
            netStream.Write(fileNameBuf, 0, fileNameBuf.Length);
            netStream.Write(fileData, 0, fileData.Length);
        }






        
        public void StartViewer()
        {
            if (MemPatch)
            {
                log("Writing Memory Patch...");
                byte[] bytes = { 0x70, 0x47 };
                _WriteToDeviceMemory(0x0105AE4, bytes, 0x1a);
                MemPatch = false;
                log("[Written Memory Patch!]");
            }
            else
            {
                remoteplay((uint)Properties.Settings.Default.ScreenPriority, (uint)Properties.Settings.Default.PriorityFactor, (uint)Properties.Settings.Default.Quality, (uint)Properties.Settings.Default.QOSValue);
                DisconnectTimeout.Enabled = true;
                DisconnectTimeout.Start();
                if (File.Exists(Path.Combine(Path.GetTempPath(), "NTRViewer.exe")))
                {
                    StringBuilder args = new StringBuilder();

                    args.Append("-l " + Properties.Settings.Default.ViewMode.ToString() + " ");
                    args.Append("-t " + Properties.Settings.Default.TopScale.ToString() + " ");
                    args.Append("-b " + Properties.Settings.Default.BottomScale.ToString());

                    ProcessStartInfo p = new ProcessStartInfo(Path.Combine(Path.GetTempPath(), "NTRViewer.exe"));
                    p.Verb = "runas";
                    p.Arguments = args.ToString().Replace(',', '.');
                    Process.Start(p);
                    log("NTRViewer Started");
                }
                else {
                    log("NTRViewer failed to load, try running CTR-V as an Administrator.");
                }
            }
        }

        public void log(String msg)
        {
            Invoke(new MethodInvoker(() =>
            {
                logger.AppendText(msg + System.Environment.NewLine);
            }));
        }

        private void _WriteToDeviceMemory(uint addr, byte[] buf, int pid = -1)
        {
            sendWriteMemPacket(addr, (uint)pid, buf);
        }
        
        public void Connect(string host)
        {
            setServer(host, 8000);
            connectToServer();
        }

        public void remoteplay(uint priorityMode = 0, uint priorityFactor = 5, uint quality = 90, double qosValue = 15)
        {
            uint num = 1;
            if (priorityMode == 1)
            {
                num = 0;
            }
            uint qosval = (uint)(qosValue * 1024 * 1024 / 8);
            sendEmptyPacket(901, num << 8 | priorityFactor, quality, qosval);
            log("[RemotePlay Activated!]");
        }




        
        
        private void DisconnectTimeout_Tick(object sender, EventArgs e)
        {
            disconnect();
            DisconnectTimeout.Stop();
        }

        #region Drag Function

        //Variables;
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        //Function;
        private void FormDrag(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                IntPtr myHandle = Handle;
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        #endregion
        #region Dropshadow

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        [DllImport("dwmapi.dll")]
        public static extern int DwmExtendFrameIntoClientArea(IntPtr hWnd, ref MARGINS pMarInset);

        [DllImport("dwmapi.dll")]
        public static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);

        [DllImport("dwmapi.dll")]
        public static extern int DwmIsCompositionEnabled(ref int pfEnabled);

        private bool m_aeroEnabled;
        private const int CS_DROPSHADOW = 0x00020000;
        private const int WM_NCPAINT = 0x0085;
        private const int WM_ACTIVATEAPP = 0x001C;

        public struct MARGINS
        {
            public int leftWidth;
            public int rightWidth;
            public int topHeight;
            public int bottomHeight;
        }

        protected override CreateParams CreateParams
        {
            get
            {
                m_aeroEnabled = CheckAeroEnabled();

                CreateParams cp = base.CreateParams;
                if (!m_aeroEnabled)
                    cp.ClassStyle |= CS_DROPSHADOW;

                return cp;
            }
        }

        private bool CheckAeroEnabled()
        {
            if (Environment.OSVersion.Version.Major >= 6)
            {
                int enabled = 0;
                DwmIsCompositionEnabled(ref enabled);
                return (enabled == 1) ? true : false;
            }
            return false;
        }

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCPAINT:
                    if (m_aeroEnabled)
                    {
                        var v = 2;
                        DwmSetWindowAttribute(Handle, 2, ref v, 4);
                        MARGINS margins = new MARGINS()
                        {
                            bottomHeight = 1,
                            leftWidth = 0,
                            rightWidth = 0,
                            topHeight = 0
                        };
                        DwmExtendFrameIntoClientArea(Handle, ref margins);

                    }
                    break;
                default:
                    break;
            }
            base.WndProc(ref m);

        }

        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {

            #region Extract NTRViewer.exe
            File.WriteAllBytes(Path.Combine(Path.GetTempPath(), "NTRViewer.exe"), Properties.Resources.NTRViewer);
            File.WriteAllBytes(Path.Combine(Path.GetTempPath(), "SDL2.dll"), Properties.Resources.SDL2);
            File.WriteAllBytes(Path.Combine(Path.GetTempPath(), "turbojpeg.dll"), Properties.Resources.turbojpeg);
            #endregion
            #region Load Settings

            ipaddress.Text = Properties.Settings.Default.IPAddress;
            TopScale.Value = Properties.Settings.Default.TopScale;
            BotScale.Value = Properties.Settings.Default.BottomScale;
            ViewMode.Value = Properties.Settings.Default.ViewMode;
            PriorityFactor.Value = Properties.Settings.Default.PriorityFactor;
            QOSValue.Value = Properties.Settings.Default.QOSValue;
            ScreenPriority.Value = Properties.Settings.Default.ScreenPriority;
            Quality.Value = Properties.Settings.Default.Quality;

            NetSSID.Text = Properties.Settings.Default.NetSSID;
            NetPass.Text = Properties.Settings.Default.NetPass;

            #endregion
            RestartNetwork();

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            #region Shut down NTRViewer
            foreach (Process p in Process.GetProcessesByName("NTRViewer"))
            {
                p.Kill();
                p.WaitForExit();
            }
            #endregion
            #region Remove Extracted NTRViewer.exe
            File.Delete(Path.Combine(Path.GetTempPath(), "NTRViewer.exe"));
            File.Delete(Path.Combine(Path.GetTempPath(), "SDL2.dll"));
            File.Delete(Path.Combine(Path.GetTempPath(), "turbojpeg.dll"));
            #endregion
            #region Close HostedNetwork
            Process cmd = new Process();
            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.CreateNoWindow = true;
            cmd.StartInfo.UseShellExecute = false;
            cmd.Start();
            cmd.StandardInput.WriteLine("netsh wlan stop hostednetwork");
            cmd.StandardInput.Flush();
            cmd.StandardInput.Close();
            cmd.WaitForExit();
            #endregion

        }

        #region Update Settings
        private void TopScale_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default["TopScale"] = TopScale.Value;
            Properties.Settings.Default.Save();
        }

        private void BotScale_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default["BottomScale"] = BotScale.Value;
            Properties.Settings.Default.Save();
        }

        private void ViewMode_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default["ViewMode"] = (int)ViewMode.Value;
            Properties.Settings.Default.Save();
        }

        private void PriorityFactor_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default["PriorityFactor"] = (int)PriorityFactor.Value;
            Properties.Settings.Default.Save();
        }

        private void QOSValue_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default["QOSValue"] = (int)QOSValue.Value;
            Properties.Settings.Default.Save();
        }

        private void ScreenPriority_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default["ScreenPriority"] = (int)ScreenPriority.Value;
            Properties.Settings.Default.Save();
        }

        private void Quality_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default["Quality"] = (int)Quality.Value;
            Properties.Settings.Default.Save();
        }

        private void ipaddress_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default["IPAddress"] = ipaddress.Text;
            Properties.Settings.Default.Save();
        }

        private void NetSSID_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default["NetSSID"] = NetSSID.Text;
            Properties.Settings.Default.Save();
        }
        private void NetPass_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default["NetPass"] = NetPass.Text;
            Properties.Settings.Default.Save();
        }
        #endregion

        private void materialButton1_Click(object sender, EventArgs e)
        {
            Connect(Properties.Settings.Default.IPAddress);
            MemPatch = false;
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            Connect(Properties.Settings.Default.IPAddress);
            MemPatch = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Process.Start("https://twitter.com/initPRAGMA");
        }

        private void RestartNetwork()
        {
            Process cmd = new Process();
            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.CreateNoWindow = true;
            cmd.StartInfo.UseShellExecute = false;
            cmd.Start();
            cmd.StandardInput.WriteLine("netsh wlan stop hostednetwork && netsh wlan set hostednetwork mode=allow ssid=" + NetSSID.Text + " key=" + NetPass.Text + " && netsh wlan start hostednetwork");
            cmd.StandardInput.Flush();
            cmd.StandardInput.Close();
            cmd.WaitForExit();
        }

        private void materialButton3_Click(object sender, EventArgs e)
        {
            if(NetPass.Text.Length < 8) {
                MessageBox.Show("The Password '" + NetPass.Text + "' is less than 8 characters! Please correct it to continue.");
            } else
            {
                RestartNetwork();
            }
        }

    }

}
