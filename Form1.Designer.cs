namespace LightMyRoom
{
    partial class LightMyRoom
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LightMyRoom));
            this.panel1 = new System.Windows.Forms.Panel();
            this.close = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chuj = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.com_status_lab = new System.Windows.Forms.Label();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.wifi_btn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.arduino_btn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.lighting_btn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.auth = new System.Windows.Forms.Label();
            this.vers = new System.Windows.Forms.Label();
            this.version = new System.Windows.Forms.Label();
            this.Logo = new Bunifu.Framework.UI.BunifuImageButton();
            this.lighting_pan = new System.Windows.Forms.Panel();
            this.mode_lab = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.staticPanel = new System.Windows.Forms.Panel();
            this.bunifuSlider1 = new Bunifu.Framework.UI.BunifuSlider();
            this.act_col = new Bunifu.Framework.UI.BunifuProgressBar();
            this.bunifuSlider2 = new Bunifu.Framework.UI.BunifuSlider();
            this.upload_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuSlider3 = new Bunifu.Framework.UI.BunifuSlider();
            this.b_val = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.g_val = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.r_val = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.modeDropdown = new Bunifu.Framework.UI.BunifuDropdown();
            this.light_title = new System.Windows.Forms.Label();
            this.rainbowPanel = new System.Windows.Forms.Panel();
            this.rainbow_btn = new Bunifu.Framework.UI.BunifuProgressBar();
            this.rainbow_apply = new Bunifu.Framework.UI.BunifuFlatButton();
            this.policePanel = new System.Windows.Forms.Panel();
            this.policebtn = new Bunifu.Framework.UI.BunifuProgressBar();
            this.policeApply = new Bunifu.Framework.UI.BunifuFlatButton();
            this.flashPanel = new System.Windows.Forms.Panel();
            this.flashbtn = new Bunifu.Framework.UI.BunifuProgressBar();
            this.flashapply = new Bunifu.Framework.UI.BunifuFlatButton();
            this.arduino_pan = new System.Windows.Forms.Panel();
            this.button19 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.arduino_title = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.themeSwitch = new Bunifu.Framework.UI.BunifuiOSSwitch();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.rainbowTimer = new System.Windows.Forms.Timer(this.components);
            this.flashTimer = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.policeTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.lighting_pan.SuspendLayout();
            this.staticPanel.SuspendLayout();
            this.rainbowPanel.SuspendLayout();
            this.policePanel.SuspendLayout();
            this.flashPanel.SuspendLayout();
            this.arduino_pan.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(44)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1104, 27);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // close
            // 
            this.close.Active = false;
            this.close.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(65)))), ((int)(((byte)(24)))));
            this.close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(65)))), ((int)(((byte)(24)))));
            this.close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.close.BorderRadius = 0;
            this.close.ButtonText = "";
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.DisabledColor = System.Drawing.Color.Gray;
            this.close.Font = new System.Drawing.Font("Microsoft Sans Serif", 3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.close.Iconcolor = System.Drawing.Color.Transparent;
            this.close.Iconimage = global::LightMyRoom.Properties.Resources.error_white;
            this.close.Iconimage_right = null;
            this.close.Iconimage_right_Selected = null;
            this.close.Iconimage_Selected = null;
            this.close.IconMarginLeft = 0;
            this.close.IconMarginRight = 0;
            this.close.IconRightVisible = true;
            this.close.IconRightZoom = 0D;
            this.close.IconVisible = true;
            this.close.IconZoom = 35D;
            this.close.IsTab = false;
            this.close.Location = new System.Drawing.Point(1076, 0);
            this.close.Margin = new System.Windows.Forms.Padding(5);
            this.close.Name = "close";
            this.close.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(65)))), ((int)(((byte)(24)))));
            this.close.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(54)))), ((int)(((byte)(22)))));
            this.close.OnHoverTextColor = System.Drawing.Color.White;
            this.close.selected = false;
            this.close.Size = new System.Drawing.Size(28, 27);
            this.close.TabIndex = 2;
            this.close.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.close.Textcolor = System.Drawing.Color.White;
            this.close.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.chuj);
            this.panel2.Controls.Add(this.com_status_lab);
            this.panel2.Controls.Add(this.bunifuCustomLabel1);
            this.panel2.Controls.Add(this.wifi_btn);
            this.panel2.Controls.Add(this.arduino_btn);
            this.panel2.Controls.Add(this.lighting_btn);
            this.panel2.Controls.Add(this.auth);
            this.panel2.Controls.Add(this.vers);
            this.panel2.Controls.Add(this.version);
            this.panel2.Controls.Add(this.Logo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(261, 565);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // chuj
            // 
            this.chuj.AutoSize = true;
            this.chuj.ForeColor = System.Drawing.Color.Gainsboro;
            this.chuj.Location = new System.Drawing.Point(73, 405);
            this.chuj.Name = "chuj";
            this.chuj.Size = new System.Drawing.Size(10, 13);
            this.chuj.TabIndex = 7;
            this.chuj.Text = " ";
            // 
            // com_status_lab
            // 
            this.com_status_lab.AutoSize = true;
            this.com_status_lab.Location = new System.Drawing.Point(91, 389);
            this.com_status_lab.Name = "com_status_lab";
            this.com_status_lab.Size = new System.Drawing.Size(10, 13);
            this.com_status_lab.TabIndex = 4;
            this.com_status_lab.Text = " ";
            this.com_status_lab.Click += new System.EventHandler(this.label1_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Gainsboro;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(12, 405);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(64, 13);
            this.bunifuCustomLabel1.TabIndex = 1;
            this.bunifuCustomLabel1.Text = "Connection:";
            this.bunifuCustomLabel1.Click += new System.EventHandler(this.bunifuCustomLabel1_Click);
            // 
            // wifi_btn
            // 
            this.wifi_btn.ActiveBorderThickness = 1;
            this.wifi_btn.ActiveCornerRadius = 20;
            this.wifi_btn.ActiveFillColor = System.Drawing.Color.Transparent;
            this.wifi_btn.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(42)))), ((int)(((byte)(86)))));
            this.wifi_btn.ActiveLineColor = System.Drawing.Color.Transparent;
            this.wifi_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.wifi_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("wifi_btn.BackgroundImage")));
            this.wifi_btn.ButtonText = "Settings";
            this.wifi_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.wifi_btn.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wifi_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.wifi_btn.IdleBorderThickness = 1;
            this.wifi_btn.IdleCornerRadius = 20;
            this.wifi_btn.IdleFillColor = System.Drawing.Color.Transparent;
            this.wifi_btn.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.wifi_btn.IdleLineColor = System.Drawing.Color.Transparent;
            this.wifi_btn.Location = new System.Drawing.Point(4, 263);
            this.wifi_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.wifi_btn.Name = "wifi_btn";
            this.wifi_btn.Size = new System.Drawing.Size(253, 39);
            this.wifi_btn.TabIndex = 6;
            this.wifi_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.wifi_btn.Click += new System.EventHandler(this.wifi_btn_Click);
            // 
            // arduino_btn
            // 
            this.arduino_btn.ActiveBorderThickness = 1;
            this.arduino_btn.ActiveCornerRadius = 20;
            this.arduino_btn.ActiveFillColor = System.Drawing.Color.Transparent;
            this.arduino_btn.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(54)))), ((int)(((byte)(22)))));
            this.arduino_btn.ActiveLineColor = System.Drawing.Color.Transparent;
            this.arduino_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.arduino_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("arduino_btn.BackgroundImage")));
            this.arduino_btn.ButtonText = "Arduino";
            this.arduino_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.arduino_btn.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arduino_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.arduino_btn.IdleBorderThickness = 1;
            this.arduino_btn.IdleCornerRadius = 20;
            this.arduino_btn.IdleFillColor = System.Drawing.Color.Transparent;
            this.arduino_btn.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.arduino_btn.IdleLineColor = System.Drawing.Color.Transparent;
            this.arduino_btn.Location = new System.Drawing.Point(4, 186);
            this.arduino_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.arduino_btn.Name = "arduino_btn";
            this.arduino_btn.Size = new System.Drawing.Size(253, 39);
            this.arduino_btn.TabIndex = 5;
            this.arduino_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.arduino_btn.Click += new System.EventHandler(this.arduino_btn_Click);
            // 
            // lighting_btn
            // 
            this.lighting_btn.ActiveBorderThickness = 1;
            this.lighting_btn.ActiveCornerRadius = 20;
            this.lighting_btn.ActiveFillColor = System.Drawing.Color.Transparent;
            this.lighting_btn.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.lighting_btn.ActiveLineColor = System.Drawing.Color.Transparent;
            this.lighting_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.lighting_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lighting_btn.BackgroundImage")));
            this.lighting_btn.ButtonText = "LED Controler";
            this.lighting_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lighting_btn.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lighting_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.lighting_btn.IdleBorderThickness = 1;
            this.lighting_btn.IdleCornerRadius = 20;
            this.lighting_btn.IdleFillColor = System.Drawing.Color.Transparent;
            this.lighting_btn.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.lighting_btn.IdleLineColor = System.Drawing.Color.Transparent;
            this.lighting_btn.Location = new System.Drawing.Point(4, 117);
            this.lighting_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lighting_btn.Name = "lighting_btn";
            this.lighting_btn.Size = new System.Drawing.Size(253, 39);
            this.lighting_btn.TabIndex = 2;
            this.lighting_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lighting_btn.Click += new System.EventHandler(this.lighting_btn_Click);
            // 
            // auth
            // 
            this.auth.AutoSize = true;
            this.auth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.auth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.auth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.auth.Location = new System.Drawing.Point(9, 543);
            this.auth.Name = "auth";
            this.auth.Size = new System.Drawing.Size(55, 16);
            this.auth.TabIndex = 3;
            this.auth.Text = "Author:  ";
            this.auth.Click += new System.EventHandler(this.auth_Click);
            // 
            // vers
            // 
            this.vers.AutoSize = true;
            this.vers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.vers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.vers.Location = new System.Drawing.Point(9, 516);
            this.vers.Name = "vers";
            this.vers.Size = new System.Drawing.Size(66, 16);
            this.vers.TabIndex = 2;
            this.vers.Text = "Version:   ";
            // 
            // version
            // 
            this.version.AutoSize = true;
            this.version.Location = new System.Drawing.Point(12, 543);
            this.version.Name = "version";
            this.version.Size = new System.Drawing.Size(0, 13);
            this.version.TabIndex = 1;
            // 
            // Logo
            // 
            this.Logo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Logo.Image = global::LightMyRoom.Properties.Resources.logo_dlugie;
            this.Logo.ImageActive = null;
            this.Logo.Location = new System.Drawing.Point(12, 22);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(235, 71);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 0;
            this.Logo.TabStop = false;
            this.Logo.Zoom = 3;
            this.Logo.Click += new System.EventHandler(this.Logo_Click);
            // 
            // lighting_pan
            // 
            this.lighting_pan.Controls.Add(this.mode_lab);
            this.lighting_pan.Controls.Add(this.modeDropdown);
            this.lighting_pan.Controls.Add(this.light_title);
            this.lighting_pan.Controls.Add(this.flashPanel);
            this.lighting_pan.Controls.Add(this.staticPanel);
            this.lighting_pan.Controls.Add(this.rainbowPanel);
            this.lighting_pan.Controls.Add(this.policePanel);
            this.lighting_pan.Location = new System.Drawing.Point(288, 49);
            this.lighting_pan.Name = "lighting_pan";
            this.lighting_pan.Size = new System.Drawing.Size(783, 518);
            this.lighting_pan.TabIndex = 2;
            // 
            // mode_lab
            // 
            this.mode_lab.AutoSize = true;
            this.mode_lab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mode_lab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.mode_lab.Location = new System.Drawing.Point(39, 77);
            this.mode_lab.Name = "mode_lab";
            this.mode_lab.Size = new System.Drawing.Size(58, 20);
            this.mode_lab.TabIndex = 15;
            this.mode_lab.Text = "Mode:";
            this.mode_lab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // staticPanel
            // 
            this.staticPanel.Controls.Add(this.bunifuSlider1);
            this.staticPanel.Controls.Add(this.act_col);
            this.staticPanel.Controls.Add(this.bunifuSlider2);
            this.staticPanel.Controls.Add(this.upload_btn);
            this.staticPanel.Controls.Add(this.bunifuSlider3);
            this.staticPanel.Controls.Add(this.b_val);
            this.staticPanel.Controls.Add(this.bunifuCustomLabel2);
            this.staticPanel.Controls.Add(this.g_val);
            this.staticPanel.Controls.Add(this.bunifuCustomLabel3);
            this.staticPanel.Controls.Add(this.r_val);
            this.staticPanel.Controls.Add(this.bunifuCustomLabel4);
            this.staticPanel.Location = new System.Drawing.Point(160, 115);
            this.staticPanel.Name = "staticPanel";
            this.staticPanel.Size = new System.Drawing.Size(545, 313);
            this.staticPanel.TabIndex = 15;
            // 
            // bunifuSlider1
            // 
            this.bunifuSlider1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSlider1.BackgroudColor = System.Drawing.Color.DarkGray;
            this.bunifuSlider1.BorderRadius = 5;
            this.bunifuSlider1.IndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.bunifuSlider1.Location = new System.Drawing.Point(83, 35);
            this.bunifuSlider1.MaximumValue = 255;
            this.bunifuSlider1.Name = "bunifuSlider1";
            this.bunifuSlider1.Size = new System.Drawing.Size(415, 28);
            this.bunifuSlider1.TabIndex = 4;
            this.bunifuSlider1.Value = 0;
            this.bunifuSlider1.ValueChanged += new System.EventHandler(this.bunifuSlider1_ValueChanged);
            // 
            // act_col
            // 
            this.act_col.BackColor = System.Drawing.Color.Silver;
            this.act_col.BorderRadius = 5;
            this.act_col.Location = new System.Drawing.Point(351, 248);
            this.act_col.MaximumValue = 100;
            this.act_col.Name = "act_col";
            this.act_col.ProgressColor = System.Drawing.Color.White;
            this.act_col.Size = new System.Drawing.Size(147, 30);
            this.act_col.TabIndex = 14;
            this.act_col.Value = 100;
            // 
            // bunifuSlider2
            // 
            this.bunifuSlider2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSlider2.BackgroudColor = System.Drawing.Color.DarkGray;
            this.bunifuSlider2.BorderRadius = 5;
            this.bunifuSlider2.IndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.bunifuSlider2.Location = new System.Drawing.Point(83, 104);
            this.bunifuSlider2.MaximumValue = 255;
            this.bunifuSlider2.Name = "bunifuSlider2";
            this.bunifuSlider2.Size = new System.Drawing.Size(415, 28);
            this.bunifuSlider2.TabIndex = 5;
            this.bunifuSlider2.Value = 0;
            this.bunifuSlider2.ValueChanged += new System.EventHandler(this.bunifuSlider2_ValueChanged);
            // 
            // upload_btn
            // 
            this.upload_btn.Active = false;
            this.upload_btn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.upload_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.upload_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.upload_btn.BorderRadius = 0;
            this.upload_btn.ButtonText = "Upload Changes";
            this.upload_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.upload_btn.DisabledColor = System.Drawing.Color.Gray;
            this.upload_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.upload_btn.Iconimage = ((System.Drawing.Image)(resources.GetObject("upload_btn.Iconimage")));
            this.upload_btn.Iconimage_right = null;
            this.upload_btn.Iconimage_right_Selected = null;
            this.upload_btn.Iconimage_Selected = null;
            this.upload_btn.IconMarginLeft = 0;
            this.upload_btn.IconMarginRight = 0;
            this.upload_btn.IconRightVisible = true;
            this.upload_btn.IconRightZoom = 0D;
            this.upload_btn.IconVisible = true;
            this.upload_btn.IconZoom = 90D;
            this.upload_btn.IsTab = false;
            this.upload_btn.Location = new System.Drawing.Point(39, 240);
            this.upload_btn.Name = "upload_btn";
            this.upload_btn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.upload_btn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.upload_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.upload_btn.selected = false;
            this.upload_btn.Size = new System.Drawing.Size(241, 48);
            this.upload_btn.TabIndex = 13;
            this.upload_btn.Text = "Upload Changes";
            this.upload_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.upload_btn.Textcolor = System.Drawing.Color.White;
            this.upload_btn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upload_btn.Click += new System.EventHandler(this.upload_btn_Click);
            // 
            // bunifuSlider3
            // 
            this.bunifuSlider3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSlider3.BackgroudColor = System.Drawing.Color.DarkGray;
            this.bunifuSlider3.BorderRadius = 5;
            this.bunifuSlider3.IndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.bunifuSlider3.Location = new System.Drawing.Point(83, 170);
            this.bunifuSlider3.MaximumValue = 255;
            this.bunifuSlider3.Name = "bunifuSlider3";
            this.bunifuSlider3.Size = new System.Drawing.Size(415, 28);
            this.bunifuSlider3.TabIndex = 6;
            this.bunifuSlider3.Value = 0;
            this.bunifuSlider3.ValueChanged += new System.EventHandler(this.bunifuSlider3_ValueChanged);
            // 
            // b_val
            // 
            this.b_val.AutoSize = true;
            this.b_val.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b_val.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.b_val.Location = new System.Drawing.Point(35, 170);
            this.b_val.Name = "b_val";
            this.b_val.Size = new System.Drawing.Size(42, 20);
            this.b_val.TabIndex = 12;
            this.b_val.Text = "Red";
            this.b_val.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(261, 12);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(42, 20);
            this.bunifuCustomLabel2.TabIndex = 7;
            this.bunifuCustomLabel2.Text = "Red";
            this.bunifuCustomLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // g_val
            // 
            this.g_val.AutoSize = true;
            this.g_val.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.g_val.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.g_val.Location = new System.Drawing.Point(35, 104);
            this.g_val.Name = "g_val";
            this.g_val.Size = new System.Drawing.Size(42, 20);
            this.g_val.TabIndex = 11;
            this.g_val.Text = "Red";
            this.g_val.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(250, 81);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(59, 20);
            this.bunifuCustomLabel3.TabIndex = 8;
            this.bunifuCustomLabel3.Text = "Green";
            this.bunifuCustomLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // r_val
            // 
            this.r_val.AutoSize = true;
            this.r_val.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.r_val.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.r_val.Location = new System.Drawing.Point(35, 35);
            this.r_val.Name = "r_val";
            this.r_val.Size = new System.Drawing.Size(42, 20);
            this.r_val.TabIndex = 10;
            this.r_val.Text = "Red";
            this.r_val.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(258, 147);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(45, 20);
            this.bunifuCustomLabel4.TabIndex = 9;
            this.bunifuCustomLabel4.Text = "Blue";
            this.bunifuCustomLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // modeDropdown
            // 
            this.modeDropdown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.modeDropdown.BorderRadius = 0;
            this.modeDropdown.DisabledColor = System.Drawing.Color.Gray;
            this.modeDropdown.ForeColor = System.Drawing.Color.White;
            this.modeDropdown.items = new string[] {
        "Static",
        "Rainbow",
        "Flash",
        "Police Lights"};
            this.modeDropdown.Location = new System.Drawing.Point(104, 76);
            this.modeDropdown.Name = "modeDropdown";
            this.modeDropdown.NomalColor = System.Drawing.Color.SeaGreen;
            this.modeDropdown.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.modeDropdown.selectedIndex = 0;
            this.modeDropdown.Size = new System.Drawing.Size(193, 23);
            this.modeDropdown.TabIndex = 16;
            this.modeDropdown.onItemSelected += new System.EventHandler(this.modeDropdown_onItemSelected);
            // 
            // light_title
            // 
            this.light_title.AutoSize = true;
            this.light_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.light_title.ForeColor = System.Drawing.Color.Gainsboro;
            this.light_title.Location = new System.Drawing.Point(216, 17);
            this.light_title.Name = "light_title";
            this.light_title.Size = new System.Drawing.Size(302, 37);
            this.light_title.TabIndex = 3;
            this.light_title.Text = "Change LED Color";
            // 
            // rainbowPanel
            // 
            this.rainbowPanel.Controls.Add(this.rainbow_btn);
            this.rainbowPanel.Controls.Add(this.rainbow_apply);
            this.rainbowPanel.Location = new System.Drawing.Point(160, 115);
            this.rainbowPanel.Name = "rainbowPanel";
            this.rainbowPanel.Size = new System.Drawing.Size(545, 313);
            this.rainbowPanel.TabIndex = 16;
            this.rainbowPanel.Visible = false;
            // 
            // rainbow_btn
            // 
            this.rainbow_btn.BackColor = System.Drawing.Color.Silver;
            this.rainbow_btn.BorderRadius = 5;
            this.rainbow_btn.Location = new System.Drawing.Point(209, 114);
            this.rainbow_btn.MaximumValue = 100;
            this.rainbow_btn.Name = "rainbow_btn";
            this.rainbow_btn.ProgressColor = System.Drawing.Color.Red;
            this.rainbow_btn.Size = new System.Drawing.Size(147, 30);
            this.rainbow_btn.TabIndex = 14;
            this.rainbow_btn.Value = 100;
            // 
            // rainbow_apply
            // 
            this.rainbow_apply.Active = false;
            this.rainbow_apply.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.rainbow_apply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.rainbow_apply.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rainbow_apply.BorderRadius = 0;
            this.rainbow_apply.ButtonText = "Upload Changes";
            this.rainbow_apply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rainbow_apply.DisabledColor = System.Drawing.Color.Gray;
            this.rainbow_apply.Iconcolor = System.Drawing.Color.Transparent;
            this.rainbow_apply.Iconimage = ((System.Drawing.Image)(resources.GetObject("rainbow_apply.Iconimage")));
            this.rainbow_apply.Iconimage_right = null;
            this.rainbow_apply.Iconimage_right_Selected = null;
            this.rainbow_apply.Iconimage_Selected = null;
            this.rainbow_apply.IconMarginLeft = 0;
            this.rainbow_apply.IconMarginRight = 0;
            this.rainbow_apply.IconRightVisible = true;
            this.rainbow_apply.IconRightZoom = 0D;
            this.rainbow_apply.IconVisible = true;
            this.rainbow_apply.IconZoom = 90D;
            this.rainbow_apply.IsTab = false;
            this.rainbow_apply.Location = new System.Drawing.Point(166, 233);
            this.rainbow_apply.Name = "rainbow_apply";
            this.rainbow_apply.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.rainbow_apply.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.rainbow_apply.OnHoverTextColor = System.Drawing.Color.White;
            this.rainbow_apply.selected = false;
            this.rainbow_apply.Size = new System.Drawing.Size(241, 48);
            this.rainbow_apply.TabIndex = 13;
            this.rainbow_apply.Text = "Upload Changes";
            this.rainbow_apply.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rainbow_apply.Textcolor = System.Drawing.Color.White;
            this.rainbow_apply.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rainbow_apply.Click += new System.EventHandler(this.rainbow_apply_Click);
            // 
            // policePanel
            // 
            this.policePanel.Controls.Add(this.policebtn);
            this.policePanel.Controls.Add(this.policeApply);
            this.policePanel.Location = new System.Drawing.Point(160, 115);
            this.policePanel.Name = "policePanel";
            this.policePanel.Size = new System.Drawing.Size(545, 313);
            this.policePanel.TabIndex = 18;
            this.policePanel.Visible = false;
            // 
            // policebtn
            // 
            this.policebtn.BackColor = System.Drawing.Color.Silver;
            this.policebtn.BorderRadius = 5;
            this.policebtn.Location = new System.Drawing.Point(209, 114);
            this.policebtn.MaximumValue = 100;
            this.policebtn.Name = "policebtn";
            this.policebtn.ProgressColor = System.Drawing.Color.Red;
            this.policebtn.Size = new System.Drawing.Size(147, 30);
            this.policebtn.TabIndex = 14;
            this.policebtn.Value = 100;
            // 
            // policeApply
            // 
            this.policeApply.Active = false;
            this.policeApply.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.policeApply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.policeApply.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.policeApply.BorderRadius = 0;
            this.policeApply.ButtonText = "Upload Changes";
            this.policeApply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.policeApply.DisabledColor = System.Drawing.Color.Gray;
            this.policeApply.Iconcolor = System.Drawing.Color.Transparent;
            this.policeApply.Iconimage = ((System.Drawing.Image)(resources.GetObject("policeApply.Iconimage")));
            this.policeApply.Iconimage_right = null;
            this.policeApply.Iconimage_right_Selected = null;
            this.policeApply.Iconimage_Selected = null;
            this.policeApply.IconMarginLeft = 0;
            this.policeApply.IconMarginRight = 0;
            this.policeApply.IconRightVisible = true;
            this.policeApply.IconRightZoom = 0D;
            this.policeApply.IconVisible = true;
            this.policeApply.IconZoom = 90D;
            this.policeApply.IsTab = false;
            this.policeApply.Location = new System.Drawing.Point(166, 233);
            this.policeApply.Name = "policeApply";
            this.policeApply.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.policeApply.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.policeApply.OnHoverTextColor = System.Drawing.Color.White;
            this.policeApply.selected = false;
            this.policeApply.Size = new System.Drawing.Size(241, 48);
            this.policeApply.TabIndex = 13;
            this.policeApply.Text = "Upload Changes";
            this.policeApply.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.policeApply.Textcolor = System.Drawing.Color.White;
            this.policeApply.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.policeApply.Click += new System.EventHandler(this.policeApply_Click);
            // 
            // flashPanel
            // 
            this.flashPanel.Controls.Add(this.flashbtn);
            this.flashPanel.Controls.Add(this.flashapply);
            this.flashPanel.Location = new System.Drawing.Point(160, 115);
            this.flashPanel.Name = "flashPanel";
            this.flashPanel.Size = new System.Drawing.Size(545, 313);
            this.flashPanel.TabIndex = 17;
            this.flashPanel.Visible = false;
            // 
            // flashbtn
            // 
            this.flashbtn.BackColor = System.Drawing.Color.Silver;
            this.flashbtn.BorderRadius = 5;
            this.flashbtn.Location = new System.Drawing.Point(209, 114);
            this.flashbtn.MaximumValue = 100;
            this.flashbtn.Name = "flashbtn";
            this.flashbtn.ProgressColor = System.Drawing.Color.Red;
            this.flashbtn.Size = new System.Drawing.Size(147, 30);
            this.flashbtn.TabIndex = 14;
            this.flashbtn.Value = 100;
            // 
            // flashapply
            // 
            this.flashapply.Active = false;
            this.flashapply.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.flashapply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.flashapply.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flashapply.BorderRadius = 0;
            this.flashapply.ButtonText = "Upload Changes";
            this.flashapply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flashapply.DisabledColor = System.Drawing.Color.Gray;
            this.flashapply.Iconcolor = System.Drawing.Color.Transparent;
            this.flashapply.Iconimage = ((System.Drawing.Image)(resources.GetObject("flashapply.Iconimage")));
            this.flashapply.Iconimage_right = null;
            this.flashapply.Iconimage_right_Selected = null;
            this.flashapply.Iconimage_Selected = null;
            this.flashapply.IconMarginLeft = 0;
            this.flashapply.IconMarginRight = 0;
            this.flashapply.IconRightVisible = true;
            this.flashapply.IconRightZoom = 0D;
            this.flashapply.IconVisible = true;
            this.flashapply.IconZoom = 90D;
            this.flashapply.IsTab = false;
            this.flashapply.Location = new System.Drawing.Point(166, 233);
            this.flashapply.Name = "flashapply";
            this.flashapply.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.flashapply.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.flashapply.OnHoverTextColor = System.Drawing.Color.White;
            this.flashapply.selected = false;
            this.flashapply.Size = new System.Drawing.Size(241, 48);
            this.flashapply.TabIndex = 13;
            this.flashapply.Text = "Upload Changes";
            this.flashapply.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.flashapply.Textcolor = System.Drawing.Color.White;
            this.flashapply.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flashapply.Click += new System.EventHandler(this.flashapply_Click);
            // 
            // arduino_pan
            // 
            this.arduino_pan.Controls.Add(this.button19);
            this.arduino_pan.Controls.Add(this.label1);
            this.arduino_pan.Controls.Add(this.comboBox1);
            this.arduino_pan.Controls.Add(this.arduino_title);
            this.arduino_pan.Location = new System.Drawing.Point(288, 49);
            this.arduino_pan.Name = "arduino_pan";
            this.arduino_pan.Size = new System.Drawing.Size(783, 518);
            this.arduino_pan.TabIndex = 3;
            this.arduino_pan.Visible = false;
            // 
            // button19
            // 
            this.button19.Active = false;
            this.button19.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.button19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.button19.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button19.BorderRadius = 0;
            this.button19.ButtonText = "Connect";
            this.button19.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button19.DisabledColor = System.Drawing.Color.Gray;
            this.button19.Iconcolor = System.Drawing.Color.Transparent;
            this.button19.Iconimage = ((System.Drawing.Image)(resources.GetObject("button19.Iconimage")));
            this.button19.Iconimage_right = null;
            this.button19.Iconimage_right_Selected = null;
            this.button19.Iconimage_Selected = null;
            this.button19.IconMarginLeft = 0;
            this.button19.IconMarginRight = 0;
            this.button19.IconRightVisible = true;
            this.button19.IconRightZoom = 0D;
            this.button19.IconVisible = true;
            this.button19.IconZoom = 90D;
            this.button19.IsTab = false;
            this.button19.Location = new System.Drawing.Point(229, 175);
            this.button19.Name = "button19";
            this.button19.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.button19.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.button19.OnHoverTextColor = System.Drawing.Color.White;
            this.button19.selected = false;
            this.button19.Size = new System.Drawing.Size(241, 48);
            this.button19.TabIndex = 1;
            this.button19.Text = "Connect";
            this.button19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button19.Textcolor = System.Drawing.Color.White;
            this.button19.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button19.Click += new System.EventHandler(this.button19_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(294, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Port:  ";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(297, 123);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 14;
            // 
            // arduino_title
            // 
            this.arduino_title.AutoSize = true;
            this.arduino_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.arduino_title.ForeColor = System.Drawing.SystemColors.Control;
            this.arduino_title.Location = new System.Drawing.Point(278, 59);
            this.arduino_title.Name = "arduino_title";
            this.arduino_title.Size = new System.Drawing.Size(154, 24);
            this.arduino_title.TabIndex = 0;
            this.arduino_title.Text = "Arduino Device";
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM4";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.bunifuFlatButton1);
            this.panel3.Controls.Add(this.themeSwitch);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.bunifuImageButton1);
            this.panel3.Location = new System.Drawing.Point(288, 46);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(825, 534);
            this.panel3.TabIndex = 15;
            this.panel3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(240, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Arduino Project:";
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Active = false;
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(123)))), ((int)(((byte)(236)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(123)))), ((int)(((byte)(236)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Show";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(370, 221);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(123)))), ((int)(((byte)(236)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(103)))), ((int)(((byte)(214)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(146, 32);
            this.bunifuFlatButton1.TabIndex = 13;
            this.bunifuFlatButton1.Text = "Show";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // themeSwitch
            // 
            this.themeSwitch.BackColor = System.Drawing.Color.Transparent;
            this.themeSwitch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("themeSwitch.BackgroundImage")));
            this.themeSwitch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.themeSwitch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.themeSwitch.Location = new System.Drawing.Point(370, 179);
            this.themeSwitch.Name = "themeSwitch";
            this.themeSwitch.OffColor = System.Drawing.Color.Gray;
            this.themeSwitch.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(202)))), ((int)(((byte)(94)))));
            this.themeSwitch.Size = new System.Drawing.Size(35, 20);
            this.themeSwitch.TabIndex = 12;
            this.themeSwitch.Value = false;
            this.themeSwitch.OnValueChange += new System.EventHandler(this.themeSwitch_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(241, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Light Theme:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(340, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 37);
            this.label2.TabIndex = 9;
            this.label2.Text = "Settings";
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuImageButton1.Image = global::LightMyRoom.Properties.Resources.logo_dlugie;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(299, 26);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(235, 71);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 8;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 3;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // rainbowTimer
            // 
            this.rainbowTimer.Tick += new System.EventHandler(this.rainbowTimer_Tick);
            // 
            // flashTimer
            // 
            this.flashTimer.Interval = 500;
            this.flashTimer.Tick += new System.EventHandler(this.flashTimer_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 500;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Enabled = true;
            this.timer3.Interval = 500;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // policeTimer
            // 
            this.policeTimer.Interval = 500;
            this.policeTimer.Tick += new System.EventHandler(this.policeTimer_Tick);
            // 
            // LightMyRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.ClientSize = new System.Drawing.Size(1104, 592);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lighting_pan);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.arduino_pan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LightMyRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LightMyRoom";
            this.Load += new System.EventHandler(this.LightMyRoom_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.lighting_pan.ResumeLayout(false);
            this.lighting_pan.PerformLayout();
            this.staticPanel.ResumeLayout(false);
            this.staticPanel.PerformLayout();
            this.rainbowPanel.ResumeLayout(false);
            this.policePanel.ResumeLayout(false);
            this.flashPanel.ResumeLayout(false);
            this.arduino_pan.ResumeLayout(false);
            this.arduino_pan.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuFlatButton close;
        private Bunifu.Framework.UI.BunifuImageButton Logo;
        private System.Windows.Forms.Label vers;
        private System.Windows.Forms.Label version;
        private System.Windows.Forms.Label auth;
        private Bunifu.Framework.UI.BunifuThinButton2 lighting_btn;
        private Bunifu.Framework.UI.BunifuThinButton2 wifi_btn;
        private Bunifu.Framework.UI.BunifuThinButton2 arduino_btn;
        private System.Windows.Forms.Panel lighting_pan;
        private System.Windows.Forms.Label light_title;
        private System.Windows.Forms.Panel arduino_pan;
        private System.Windows.Forms.Label com_status_lab;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.IO.Ports.SerialPort serialPort1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuSlider bunifuSlider3;
        private Bunifu.Framework.UI.BunifuSlider bunifuSlider2;
        private Bunifu.Framework.UI.BunifuSlider bunifuSlider1;
        private System.Windows.Forms.Label arduino_title;
        private Bunifu.Framework.UI.BunifuCustomLabel b_val;
        private Bunifu.Framework.UI.BunifuCustomLabel g_val;
        private Bunifu.Framework.UI.BunifuCustomLabel r_val;
        private Bunifu.Framework.UI.BunifuFlatButton upload_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private Bunifu.Framework.UI.BunifuFlatButton button19;
        private Bunifu.Framework.UI.BunifuCustomLabel chuj;
        private Bunifu.Framework.UI.BunifuProgressBar act_col;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuiOSSwitch themeSwitch;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private System.Windows.Forms.Panel staticPanel;
        private Bunifu.Framework.UI.BunifuCustomLabel mode_lab;
        private Bunifu.Framework.UI.BunifuDropdown modeDropdown;
        private System.Windows.Forms.Panel rainbowPanel;
        private Bunifu.Framework.UI.BunifuProgressBar rainbow_btn;
        private Bunifu.Framework.UI.BunifuFlatButton rainbow_apply;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer rainbowTimer;
        private System.Windows.Forms.Panel flashPanel;
        private Bunifu.Framework.UI.BunifuProgressBar flashbtn;
        private Bunifu.Framework.UI.BunifuFlatButton flashapply;
        private System.Windows.Forms.Timer flashTimer;
        public System.Windows.Forms.Timer timer2;
        public System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer policeTimer;
        private System.Windows.Forms.Panel policePanel;
        private Bunifu.Framework.UI.BunifuProgressBar policebtn;
        private Bunifu.Framework.UI.BunifuFlatButton policeApply;
    }
}

