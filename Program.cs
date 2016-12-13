using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CTR_V
{
    
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CTRV());


            #region Check for an Update

            //If the user is Connected to the Internet;
            if (TestInternetConnection())
            {

                try
                {

                    //Using WebClient, get the Newest File Version;
                    using (System.Net.WebClient wc = new System.Net.WebClient())
                    {

                        //Latest Version;
                        string LatestVersion = wc.DownloadString("https://raw.githubusercontent.com/initPRAGMA/CTR-V/master/version.txt");
                        string ExecutableLocation = typeof(Program).Assembly.CodeBase.Replace("file:///", "");
                        string CurrentVersion = FileVersionInfo.GetVersionInfo(ExecutableLocation).ProductVersion;
                        string CurrentExecutableName = typeof(Program).Assembly.GetName().Name + "-" + LatestVersion + ".exe";

                        //If the Latest Version is Newer then the Current Version;
                        if (LatestVersion != CurrentVersion)
                        {
                            MessageBox.Show(CurrentExecutableName);
                            //Download the Latest Version of the EXE file;
                            wc.DownloadFile("https://github.com/ImReallyShiny/CTR-V/raw/master/CTR-V.exe", CurrentExecutableName);

                            //Show a MessageBox asking to open Explorer to the file;
                            DialogResult mb = MessageBox.Show("Continue usage on the new update. Open Explorer and go to the Directory containing the updated .exe located at: " + ExecutableLocation.Replace("CTR-V.EXE", CurrentExecutableName + " ?\""), "New Update Downloaded!", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                            if (mb == DialogResult.Yes)
                            {
                                //Go to where SAIO is and select the New Update.exe;
                                Process.Start("explorer.exe", "/select,\"" + ExecutableLocation.Replace("/", "\\").Replace("CTR-V.EXE", CurrentExecutableName) + "\"");
                            }

                        }
                        else
                        {

                            Application.EnableVisualStyles();
                            Application.SetCompatibleTextRenderingDefault(false);
                            Application.Run(new CTRV());

                        }

                    }

                }
                catch (Exception ex)
                {

                    //Updating had an Unexpected Error;
                    MessageBox.Show("Please re-download CTR-V manually as an Update Bug Occured! Error: " + ex.ToString(), "Update Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            else
            {

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new CTRV());

            }

            #endregion

        }

        private static bool TestInternetConnection()
        {
            try
            {
                System.Net.NetworkInformation.Ping ping = new System.Net.NetworkInformation.Ping();
                ping.Send("google.com");
                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}
