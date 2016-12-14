namespace CTR_V
{
    partial class CTRV
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CTRV));
            this.DisconnectTimeout = new System.Windows.Forms.Timer(this.components);
            this.AppTitle = new System.Windows.Forms.Label();
            this.TabFixer = new System.Windows.Forms.Panel();
            this.controlBox1 = new CTR_V.ControlBox();
            this.customTabControl1 = new CTR_V.CustomTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.logger = new System.Windows.Forms.RichTextBox();
            this.materialButton2 = new CTR_V.MaterialButton();
            this.materialButton1 = new CTR_V.MaterialButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.NetPass = new System.Windows.Forms.TextBox();
            this.materialButton3 = new CTR_V.MaterialButton();
            this.separator4 = new CTR_V.Separator();
            this.NetSSID = new System.Windows.Forms.TextBox();
            this.Hidden2 = new System.Windows.Forms.TabPage();
            this.Hidden3 = new System.Windows.Forms.TabPage();
            this.Hidden4 = new System.Windows.Forms.TabPage();
            this.Hidden5 = new System.Windows.Forms.TabPage();
            this.Hidden6 = new System.Windows.Forms.TabPage();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.separator3 = new CTR_V.Separator();
            this.separator2 = new CTR_V.Separator();
            this.separator1 = new CTR_V.Separator();
            this.label1 = new System.Windows.Forms.Label();
            this.TopScale = new System.Windows.Forms.NumericUpDown();
            this.ViewMode = new System.Windows.Forms.NumericUpDown();
            this.ipaddress = new System.Windows.Forms.TextBox();
            this.ScreenPriority = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.QOSValue = new System.Windows.Forms.NumericUpDown();
            this.BotScale = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.PriorityFactor = new System.Windows.Forms.NumericUpDown();
            this.Quality = new System.Windows.Forms.NumericUpDown();
            this.customTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopScale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViewMode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScreenPriority)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QOSValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BotScale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PriorityFactor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Quality)).BeginInit();
            this.SuspendLayout();
            // 
            // DisconnectTimeout
            // 
            this.DisconnectTimeout.Interval = 2000;
            this.DisconnectTimeout.Tick += new System.EventHandler(this.DisconnectTimeout_Tick);
            // 
            // AppTitle
            // 
            this.AppTitle.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppTitle.ForeColor = System.Drawing.Color.White;
            this.AppTitle.Location = new System.Drawing.Point(0, 0);
            this.AppTitle.Name = "AppTitle";
            this.AppTitle.Size = new System.Drawing.Size(51, 28);
            this.AppTitle.TabIndex = 19;
            this.AppTitle.Text = "CTR-V";
            this.AppTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TabFixer
            // 
            this.TabFixer.Location = new System.Drawing.Point(0, 27);
            this.TabFixer.Name = "TabFixer";
            this.TabFixer.Size = new System.Drawing.Size(690, 2);
            this.TabFixer.TabIndex = 21;
            // 
            // controlBox1
            // 
            this.controlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.controlBox1.Font = new System.Drawing.Font("Verdana", 8F);
            this.controlBox1.Location = new System.Drawing.Point(622, 0);
            this.controlBox1.Name = "controlBox1";
            this.controlBox1.Size = new System.Drawing.Size(68, 29);
            this.controlBox1.TabIndex = 18;
            this.controlBox1.Text = "controlBox1";
            // 
            // customTabControl1
            // 
            this.customTabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.customTabControl1.Controls.Add(this.tabPage1);
            this.customTabControl1.Controls.Add(this.tabPage2);
            this.customTabControl1.Controls.Add(this.Hidden2);
            this.customTabControl1.Controls.Add(this.Hidden3);
            this.customTabControl1.Controls.Add(this.Hidden4);
            this.customTabControl1.Controls.Add(this.Hidden5);
            this.customTabControl1.Controls.Add(this.Hidden6);
            this.customTabControl1.Controls.Add(this.tabPage8);
            this.customTabControl1.ItemSize = new System.Drawing.Size(36, 38);
            this.customTabControl1.Location = new System.Drawing.Point(-2, 27);
            this.customTabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.customTabControl1.Multiline = true;
            this.customTabControl1.Name = "customTabControl1";
            this.customTabControl1.SelectedIndex = 0;
            this.customTabControl1.Size = new System.Drawing.Size(692, 293);
            this.customTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.customTabControl1.TabIndex = 20;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.tabPage1.Controls.Add(this.logger);
            this.tabPage1.Controls.Add(this.materialButton2);
            this.tabPage1.Controls.Add(this.materialButton1);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tabPage1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tabPage1.Location = new System.Drawing.Point(38, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(654, 291);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // logger
            // 
            this.logger.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.logger.Location = new System.Drawing.Point(2, 38);
            this.logger.Name = "logger";
            this.logger.Size = new System.Drawing.Size(650, 248);
            this.logger.TabIndex = 6;
            this.logger.Text = "";
            // 
            // materialButton2
            // 
            this.materialButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(202)))), ((int)(((byte)(249)))));
            this.materialButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButton2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.materialButton2.ForeColor = System.Drawing.Color.White;
            this.materialButton2.Location = new System.Drawing.Point(328, 2);
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.Size = new System.Drawing.Size(324, 34);
            this.materialButton2.TabIndex = 5;
            this.materialButton2.Text = "Send Memory Patch";
            this.materialButton2.UseVisualStyleBackColor = false;
            this.materialButton2.Click += new System.EventHandler(this.materialButton2_Click);
            // 
            // materialButton1
            // 
            this.materialButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(202)))), ((int)(((byte)(249)))));
            this.materialButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButton1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialButton1.ForeColor = System.Drawing.Color.White;
            this.materialButton1.Location = new System.Drawing.Point(2, 2);
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.Size = new System.Drawing.Size(324, 34);
            this.materialButton1.TabIndex = 4;
            this.materialButton1.Text = "Connect";
            this.materialButton1.UseVisualStyleBackColor = false;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.tabPage2.Controls.Add(this.NetPass);
            this.tabPage2.Controls.Add(this.materialButton3);
            this.tabPage2.Controls.Add(this.separator4);
            this.tabPage2.Controls.Add(this.NetSSID);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tabPage2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tabPage2.Location = new System.Drawing.Point(38, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(654, 291);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Tag = "";
            this.tabPage2.Text = "tabPage2";
            // 
            // NetPass
            // 
            this.NetPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.NetPass.Location = new System.Drawing.Point(6, 84);
            this.NetPass.Name = "NetPass";
            this.NetPass.Size = new System.Drawing.Size(642, 26);
            this.NetPass.TabIndex = 24;
            this.NetPass.Text = "Hosted Network Key (Password)";
            this.NetPass.TextChanged += new System.EventHandler(this.NetPass_TextChanged);
            // 
            // materialButton3
            // 
            this.materialButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(202)))), ((int)(((byte)(249)))));
            this.materialButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButton3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialButton3.ForeColor = System.Drawing.Color.White;
            this.materialButton3.Location = new System.Drawing.Point(2, 2);
            this.materialButton3.Name = "materialButton3";
            this.materialButton3.Size = new System.Drawing.Size(650, 34);
            this.materialButton3.TabIndex = 22;
            this.materialButton3.Text = "Restart HostedNetwork";
            this.materialButton3.UseVisualStyleBackColor = false;
            this.materialButton3.Click += new System.EventHandler(this.materialButton3_Click);
            // 
            // separator4
            // 
            this.separator4.BackColor = System.Drawing.Color.Gainsboro;
            this.separator4.Location = new System.Drawing.Point(6, 75);
            this.separator4.Name = "separator4";
            this.separator4.Size = new System.Drawing.Size(642, 2);
            this.separator4.TabIndex = 20;
            this.separator4.Text = "separator4";
            // 
            // NetSSID
            // 
            this.NetSSID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.NetSSID.Location = new System.Drawing.Point(6, 42);
            this.NetSSID.Name = "NetSSID";
            this.NetSSID.Size = new System.Drawing.Size(642, 26);
            this.NetSSID.TabIndex = 19;
            this.NetSSID.Text = "Hosted Network SSID (Name)";
            this.NetSSID.TextChanged += new System.EventHandler(this.NetSSID_TextChanged);
            // 
            // Hidden2
            // 
            this.Hidden2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.Hidden2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Hidden2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Hidden2.Location = new System.Drawing.Point(38, 2);
            this.Hidden2.Name = "Hidden2";
            this.Hidden2.Padding = new System.Windows.Forms.Padding(3);
            this.Hidden2.Size = new System.Drawing.Size(654, 291);
            this.Hidden2.TabIndex = 2;
            this.Hidden2.Tag = "Hidden";
            this.Hidden2.Text = "tabPage3";
            // 
            // Hidden3
            // 
            this.Hidden3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.Hidden3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Hidden3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Hidden3.Location = new System.Drawing.Point(38, 2);
            this.Hidden3.Name = "Hidden3";
            this.Hidden3.Padding = new System.Windows.Forms.Padding(3);
            this.Hidden3.Size = new System.Drawing.Size(654, 291);
            this.Hidden3.TabIndex = 3;
            this.Hidden3.Tag = "Hidden";
            this.Hidden3.Text = "tabPage4";
            // 
            // Hidden4
            // 
            this.Hidden4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.Hidden4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Hidden4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Hidden4.Location = new System.Drawing.Point(38, 2);
            this.Hidden4.Name = "Hidden4";
            this.Hidden4.Padding = new System.Windows.Forms.Padding(3);
            this.Hidden4.Size = new System.Drawing.Size(654, 291);
            this.Hidden4.TabIndex = 4;
            this.Hidden4.Tag = "Hidden";
            this.Hidden4.Text = "tabPage5";
            // 
            // Hidden5
            // 
            this.Hidden5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.Hidden5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Hidden5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Hidden5.Location = new System.Drawing.Point(38, 2);
            this.Hidden5.Name = "Hidden5";
            this.Hidden5.Padding = new System.Windows.Forms.Padding(3);
            this.Hidden5.Size = new System.Drawing.Size(654, 291);
            this.Hidden5.TabIndex = 5;
            this.Hidden5.Tag = "Hidden";
            this.Hidden5.Text = "tabPage6";
            // 
            // Hidden6
            // 
            this.Hidden6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.Hidden6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Hidden6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Hidden6.Location = new System.Drawing.Point(38, 2);
            this.Hidden6.Name = "Hidden6";
            this.Hidden6.Padding = new System.Windows.Forms.Padding(3);
            this.Hidden6.Size = new System.Drawing.Size(654, 291);
            this.Hidden6.TabIndex = 6;
            this.Hidden6.Tag = "Hidden";
            this.Hidden6.Text = "tabPage7";
            // 
            // tabPage8
            // 
            this.tabPage8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.tabPage8.Controls.Add(this.pictureBox1);
            this.tabPage8.Controls.Add(this.label8);
            this.tabPage8.Controls.Add(this.separator3);
            this.tabPage8.Controls.Add(this.separator2);
            this.tabPage8.Controls.Add(this.separator1);
            this.tabPage8.Controls.Add(this.label1);
            this.tabPage8.Controls.Add(this.TopScale);
            this.tabPage8.Controls.Add(this.ViewMode);
            this.tabPage8.Controls.Add(this.ipaddress);
            this.tabPage8.Controls.Add(this.ScreenPriority);
            this.tabPage8.Controls.Add(this.label2);
            this.tabPage8.Controls.Add(this.label7);
            this.tabPage8.Controls.Add(this.label4);
            this.tabPage8.Controls.Add(this.label3);
            this.tabPage8.Controls.Add(this.QOSValue);
            this.tabPage8.Controls.Add(this.BotScale);
            this.tabPage8.Controls.Add(this.label5);
            this.tabPage8.Controls.Add(this.label6);
            this.tabPage8.Controls.Add(this.PriorityFactor);
            this.tabPage8.Controls.Add(this.Quality);
            this.tabPage8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tabPage8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tabPage8.Location = new System.Drawing.Point(38, 2);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(654, 291);
            this.tabPage8.TabIndex = 7;
            this.tabPage8.Tag = "";
            this.tabPage8.Text = "tabPage8";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::CTR_V.Properties.Resources.Twitter;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(608, 241);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(118)))), ((int)(((byte)(138)))));
            this.label8.Location = new System.Drawing.Point(11, 227);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(578, 61);
            this.label8.TabIndex = 22;
            this.label8.Text = "Created by PRAGMA";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // separator3
            // 
            this.separator3.BackColor = System.Drawing.Color.Gainsboro;
            this.separator3.Location = new System.Drawing.Point(6, 223);
            this.separator3.Name = "separator3";
            this.separator3.Size = new System.Drawing.Size(642, 2);
            this.separator3.TabIndex = 20;
            this.separator3.Text = "separator3";
            // 
            // separator2
            // 
            this.separator2.BackColor = System.Drawing.Color.Gainsboro;
            this.separator2.Location = new System.Drawing.Point(6, 144);
            this.separator2.Name = "separator2";
            this.separator2.Size = new System.Drawing.Size(642, 2);
            this.separator2.TabIndex = 19;
            this.separator2.Text = "separator2";
            // 
            // separator1
            // 
            this.separator1.BackColor = System.Drawing.Color.Gainsboro;
            this.separator1.Location = new System.Drawing.Point(6, 39);
            this.separator1.Name = "separator1";
            this.separator1.Size = new System.Drawing.Size(642, 2);
            this.separator1.TabIndex = 18;
            this.separator1.Text = "separator1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(7, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Top Screen Scale (0 = Disabled)";
            // 
            // TopScale
            // 
            this.TopScale.Location = new System.Drawing.Point(598, 48);
            this.TopScale.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.TopScale.Name = "TopScale";
            this.TopScale.Size = new System.Drawing.Size(48, 21);
            this.TopScale.TabIndex = 4;
            this.TopScale.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.TopScale.ValueChanged += new System.EventHandler(this.TopScale_ValueChanged);
            // 
            // ViewMode
            // 
            this.ViewMode.Location = new System.Drawing.Point(598, 95);
            this.ViewMode.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ViewMode.Name = "ViewMode";
            this.ViewMode.Size = new System.Drawing.Size(48, 21);
            this.ViewMode.TabIndex = 9;
            this.ViewMode.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ViewMode.ValueChanged += new System.EventHandler(this.ViewMode_ValueChanged);
            // 
            // ipaddress
            // 
            this.ipaddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ipaddress.Location = new System.Drawing.Point(6, 6);
            this.ipaddress.Name = "ipaddress";
            this.ipaddress.Size = new System.Drawing.Size(642, 26);
            this.ipaddress.TabIndex = 3;
            this.ipaddress.Text = "3DS IP Address";
            this.ipaddress.TextChanged += new System.EventHandler(this.ipaddress_TextChanged);
            // 
            // ScreenPriority
            // 
            this.ScreenPriority.Location = new System.Drawing.Point(598, 198);
            this.ScreenPriority.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ScreenPriority.Name = "ScreenPriority";
            this.ScreenPriority.Size = new System.Drawing.Size(48, 21);
            this.ScreenPriority.TabIndex = 15;
            this.ScreenPriority.ValueChanged += new System.EventHandler(this.ScreenPriority_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(7, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Bottom Screen Scale (0 = Disabled)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(7, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 15);
            this.label7.TabIndex = 16;
            this.label7.Text = "Quality";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(6, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Priority Factor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(7, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(221, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "View Mode (1 = Vertical, 0 = Horizontal)";
            // 
            // QOSValue
            // 
            this.QOSValue.Location = new System.Drawing.Point(598, 174);
            this.QOSValue.Maximum = new decimal(new int[] {
            101,
            0,
            0,
            0});
            this.QOSValue.Name = "QOSValue";
            this.QOSValue.Size = new System.Drawing.Size(48, 21);
            this.QOSValue.TabIndex = 14;
            this.QOSValue.Value = new decimal(new int[] {
            101,
            0,
            0,
            0});
            this.QOSValue.ValueChanged += new System.EventHandler(this.QOSValue_ValueChanged);
            // 
            // BotScale
            // 
            this.BotScale.Location = new System.Drawing.Point(598, 72);
            this.BotScale.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.BotScale.Name = "BotScale";
            this.BotScale.Size = new System.Drawing.Size(48, 21);
            this.BotScale.TabIndex = 8;
            this.BotScale.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.BotScale.ValueChanged += new System.EventHandler(this.BotScale_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(6, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Quality of Service Value";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(7, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(203, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Screen Priority (0 = Top, 1 = Bottom)";
            // 
            // PriorityFactor
            // 
            this.PriorityFactor.Location = new System.Drawing.Point(598, 150);
            this.PriorityFactor.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.PriorityFactor.Name = "PriorityFactor";
            this.PriorityFactor.Size = new System.Drawing.Size(48, 21);
            this.PriorityFactor.TabIndex = 13;
            this.PriorityFactor.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.PriorityFactor.ValueChanged += new System.EventHandler(this.PriorityFactor_ValueChanged);
            // 
            // Quality
            // 
            this.Quality.Location = new System.Drawing.Point(598, 119);
            this.Quality.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Quality.Name = "Quality";
            this.Quality.Size = new System.Drawing.Size(48, 21);
            this.Quality.TabIndex = 17;
            this.Quality.Value = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.Quality.ValueChanged += new System.EventHandler(this.Quality_ValueChanged);
            // 
            // CTRV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(118)))), ((int)(((byte)(138)))));
            this.ClientSize = new System.Drawing.Size(690, 317);
            this.Controls.Add(this.controlBox1);
            this.Controls.Add(this.TabFixer);
            this.Controls.Add(this.customTabControl1);
            this.Controls.Add(this.AppTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(690, 317);
            this.MinimumSize = new System.Drawing.Size(690, 317);
            this.Name = "CTRV";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CTR-V";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormDrag);
            this.customTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage8.ResumeLayout(false);
            this.tabPage8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopScale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViewMode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScreenPriority)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QOSValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BotScale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PriorityFactor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Quality)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox ipaddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown TopScale;
        private System.Windows.Forms.NumericUpDown BotScale;
        private System.Windows.Forms.NumericUpDown ViewMode;
        private System.Windows.Forms.Timer DisconnectTimeout;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown PriorityFactor;
        private System.Windows.Forms.NumericUpDown QOSValue;
        private System.Windows.Forms.NumericUpDown ScreenPriority;
        private System.Windows.Forms.NumericUpDown Quality;
        private System.Windows.Forms.Label label7;
        private ControlBox controlBox1;
        public System.Windows.Forms.Label AppTitle;
        private CustomTabControl customTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel TabFixer;
        private System.Windows.Forms.TabPage Hidden2;
        private System.Windows.Forms.TabPage Hidden3;
        private System.Windows.Forms.TabPage Hidden4;
        private System.Windows.Forms.TabPage Hidden5;
        private System.Windows.Forms.TabPage Hidden6;
        private System.Windows.Forms.TabPage tabPage8;
        private MaterialButton materialButton1;
        private MaterialButton materialButton2;
        private System.Windows.Forms.RichTextBox logger;
        private Separator separator1;
        private Separator separator2;
        public System.Windows.Forms.Label label8;
        private Separator separator3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Separator separator4;
        private System.Windows.Forms.TextBox NetSSID;
        private MaterialButton materialButton3;
        private System.Windows.Forms.TextBox NetPass;
    }
}

