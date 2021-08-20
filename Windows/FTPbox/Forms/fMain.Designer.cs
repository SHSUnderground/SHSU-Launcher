namespace FTPbox.Forms
{
    partial class fMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMain));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.totalSizeLabel = new System.Windows.Forms.Label();
            this.tabGeneral = new System.Windows.Forms.TabPage();
            this.gLanguage = new System.Windows.Forms.GroupBox();
            this.bTranslate = new System.Windows.Forms.Button();
            this.cLanguages = new System.Windows.Forms.ComboBox();
            this.gLinks = new System.Windows.Forms.GroupBox();
            this.rOpenLocal = new System.Windows.Forms.RadioButton();
            this.labLinkClicked = new System.Windows.Forms.Label();
            this.rCopy2Clipboard = new System.Windows.Forms.RadioButton();
            this.rOpenInBrowser = new System.Windows.Forms.RadioButton();
            this.gApp = new System.Windows.Forms.GroupBox();
            this.chkShellMenus = new System.Windows.Forms.CheckBox();
            this.bBrowseLogs = new System.Windows.Forms.Button();
            this.chkEnableLogging = new System.Windows.Forms.CheckBox();
            this.chkShowNots = new System.Windows.Forms.CheckBox();
            this.chkStartUp = new System.Windows.Forms.CheckBox();
            this.tabAccount = new System.Windows.Forms.TabPage();
            this.bRemoveAccount = new System.Windows.Forms.Button();
            this.bAddAccount = new System.Windows.Forms.Button();
            this.cProfiles = new System.Windows.Forms.ComboBox();
            this.gAccount = new System.Windows.Forms.GroupBox();
            this.tTempPrefix = new System.Windows.Forms.TextBox();
            this.labTempPrefix = new System.Windows.Forms.Label();
            this.rBothWaySync = new System.Windows.Forms.RadioButton();
            this.labWayOfSync = new System.Windows.Forms.Label();
            this.rRemoteToLocalOnly = new System.Windows.Forms.RadioButton();
            this.rLocalToRemoteOnly = new System.Windows.Forms.RadioButton();
            this.labViewInBrowser = new System.Windows.Forms.LinkLabel();
            this.chkWebInt = new System.Windows.Forms.CheckBox();
            this.bConfigureAccount = new System.Windows.Forms.Button();
            this.labAccount = new System.Windows.Forms.Label();
            this.tabFilters = new System.Windows.Forms.TabPage();
            this.gFileFilters = new System.Windows.Forms.GroupBox();
            this.bConfigureSelectiveSync = new System.Windows.Forms.Button();
            this.bConfigureExtensions = new System.Windows.Forms.Button();
            this.labSelectiveSync = new System.Windows.Forms.Label();
            this.labAlsoIgnore = new System.Windows.Forms.Label();
            this.cIgnoreOldFiles = new System.Windows.Forms.CheckBox();
            this.dtpLastModTime = new System.Windows.Forms.DateTimePicker();
            this.labSelectExtensions = new System.Windows.Forms.Label();
            this.cIgnoreTempFiles = new System.Windows.Forms.CheckBox();
            this.cIgnoreDotfiles = new System.Windows.Forms.CheckBox();
            this.tabBandwidth = new System.Windows.Forms.TabPage();
            this.gSyncing = new System.Windows.Forms.GroupBox();
            this.labSeconds = new System.Windows.Forms.Label();
            this.labSyncWhen = new System.Windows.Forms.Label();
            this.nSyncFrequency = new System.Windows.Forms.NumericUpDown();
            this.cAuto = new System.Windows.Forms.RadioButton();
            this.cManually = new System.Windows.Forms.RadioButton();
            this.gLimits = new System.Windows.Forms.GroupBox();
            this.labNoLimits = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nUpLimit = new System.Windows.Forms.NumericUpDown();
            this.nDownLimit = new System.Windows.Forms.NumericUpDown();
            this.labUpSpeed = new System.Windows.Forms.Label();
            this.labDownSpeed = new System.Windows.Forms.Label();
            this.tabAbout = new System.Windows.Forms.TabPage();
            this.labSupportMail = new System.Windows.Forms.Label();
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.label19 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.lVersion = new System.Windows.Forms.Label();
            this.labLangUsed = new System.Windows.Forms.Label();
            this.labContact = new System.Windows.Forms.Label();
            this.labSite = new System.Windows.Forms.Label();
            this.labTeam = new System.Windows.Forms.Label();
            this.labCurVersion = new System.Windows.Forms.Label();
            this.gContribute = new System.Windows.Forms.GroupBox();
            this.labDonate = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.gNotes = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.labContactMe = new System.Windows.Forms.Label();
            this.labFree = new System.Windows.Forms.Label();
            this.tray = new System.Windows.Forms.NotifyIcon(this.components);
            this.trayMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.SyncToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabGeneral.SuspendLayout();
            this.gLanguage.SuspendLayout();
            this.gLinks.SuspendLayout();
            this.gApp.SuspendLayout();
            this.tabAccount.SuspendLayout();
            this.gAccount.SuspendLayout();
            this.tabFilters.SuspendLayout();
            this.gFileFilters.SuspendLayout();
            this.tabBandwidth.SuspendLayout();
            this.gSyncing.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nSyncFrequency)).BeginInit();
            this.gLimits.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUpLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nDownLimit)).BeginInit();
            this.tabAbout.SuspendLayout();
            this.gContribute.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gNotes.SuspendLayout();
            this.trayMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.AccessibleDescription = "";
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabGeneral);
            this.tabControl1.Controls.Add(this.tabAccount);
            this.tabControl1.Controls.Add(this.tabFilters);
            this.tabControl1.Controls.Add(this.tabBandwidth);
            this.tabControl1.Controls.Add(this.tabAbout);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(629, 482);
            this.tabControl1.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.progressBar1);
            this.tabPage1.Controls.Add(this.pictureBox2);
            this.tabPage1.Controls.Add(this.totalSizeLabel);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(621, 453);
            this.tabPage1.TabIndex = 6;
            this.tabPage1.Text = "Status";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(316, 7);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(289, 267);
            this.panel1.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(100, 15);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "CREDITS";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(59, 238);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(140, 16);
            this.label10.TabIndex = 13;
            this.label10.Text = "Assets: BoocerSmash";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 54);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Project Lead/Dev: CrabFu";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(85, 193);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 16);
            this.label9.TabIndex = 10;
            this.label9.Text = "Assets: Remy";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(72, 95);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "Dev: FireAndIce";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(47, 146);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 16);
            this.label8.TabIndex = 9;
            this.label8.Text = "Dev: A The Bad Doggo";
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(4, 318);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(255, 113);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(432, 367);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "0%";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(267, 337);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(345, 76);
            this.progressBar1.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(4, 7);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(304, 268);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // totalSizeLabel
            // 
            this.totalSizeLabel.AutoSize = true;
            this.totalSizeLabel.ForeColor = System.Drawing.Color.Maroon;
            this.totalSizeLabel.Location = new System.Drawing.Point(328, 300);
            this.totalSizeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalSizeLabel.Name = "totalSizeLabel";
            this.totalSizeLabel.Size = new System.Drawing.Size(231, 16);
            this.totalSizeLabel.TabIndex = 0;
            this.totalSizeLabel.Text = "Getting Remote FIle Info...Please Wait";
            this.totalSizeLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // tabGeneral
            // 
            this.tabGeneral.AccessibleDescription = "";
            this.tabGeneral.Controls.Add(this.gLanguage);
            this.tabGeneral.Controls.Add(this.gLinks);
            this.tabGeneral.Controls.Add(this.gApp);
            this.tabGeneral.Location = new System.Drawing.Point(4, 25);
            this.tabGeneral.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabGeneral.Size = new System.Drawing.Size(621, 453);
            this.tabGeneral.TabIndex = 0;
            this.tabGeneral.Text = "General";
            this.tabGeneral.UseVisualStyleBackColor = true;
            // 
            // gLanguage
            // 
            this.gLanguage.Controls.Add(this.bTranslate);
            this.gLanguage.Controls.Add(this.cLanguages);
            this.gLanguage.Location = new System.Drawing.Point(11, 298);
            this.gLanguage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gLanguage.Name = "gLanguage";
            this.gLanguage.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gLanguage.Size = new System.Drawing.Size(599, 66);
            this.gLanguage.TabIndex = 13;
            this.gLanguage.TabStop = false;
            this.gLanguage.Text = "Language";
            // 
            // bTranslate
            // 
            this.bTranslate.Location = new System.Drawing.Point(255, 21);
            this.bTranslate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bTranslate.Name = "bTranslate";
            this.bTranslate.Size = new System.Drawing.Size(119, 28);
            this.bTranslate.TabIndex = 11;
            this.bTranslate.Text = "Translate";
            this.bTranslate.UseVisualStyleBackColor = true;
            this.bTranslate.Click += new System.EventHandler(this.bTranslate_Click);
            // 
            // cLanguages
            // 
            this.cLanguages.AccessibleDescription = "select the language of the application";
            this.cLanguages.AccessibleName = "Language";
            this.cLanguages.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cLanguages.FormattingEnabled = true;
            this.cLanguages.Items.AddRange(new object[] {
            "None",
            "require explicit FTP over TLS",
            "require implicit FTP over TLS"});
            this.cLanguages.Location = new System.Drawing.Point(12, 23);
            this.cLanguages.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cLanguages.Name = "cLanguages";
            this.cLanguages.Size = new System.Drawing.Size(233, 24);
            this.cLanguages.TabIndex = 1;
            // 
            // gLinks
            // 
            this.gLinks.AccessibleDescription = "";
            this.gLinks.Controls.Add(this.rOpenLocal);
            this.gLinks.Controls.Add(this.labLinkClicked);
            this.gLinks.Controls.Add(this.rCopy2Clipboard);
            this.gLinks.Controls.Add(this.rOpenInBrowser);
            this.gLinks.Location = new System.Drawing.Point(11, 7);
            this.gLinks.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gLinks.Name = "gLinks";
            this.gLinks.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gLinks.Size = new System.Drawing.Size(599, 137);
            this.gLinks.TabIndex = 12;
            this.gLinks.TabStop = false;
            this.gLinks.Text = "Links";
            // 
            // rOpenLocal
            // 
            this.rOpenLocal.AccessibleDescription = "";
            this.rOpenLocal.AccessibleName = "open the local file";
            this.rOpenLocal.Location = new System.Drawing.Point(29, 106);
            this.rOpenLocal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rOpenLocal.Name = "rOpenLocal";
            this.rOpenLocal.Size = new System.Drawing.Size(544, 21);
            this.rOpenLocal.TabIndex = 3;
            this.rOpenLocal.Text = "open the local file";
            this.rOpenLocal.UseVisualStyleBackColor = true;
            this.rOpenLocal.CheckedChanged += new System.EventHandler(this.rOpenLocal_CheckedChanged);
            // 
            // labLinkClicked
            // 
            this.labLinkClicked.AccessibleDescription = "";
            this.labLinkClicked.Location = new System.Drawing.Point(12, 23);
            this.labLinkClicked.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labLinkClicked.Name = "labLinkClicked";
            this.labLinkClicked.Size = new System.Drawing.Size(583, 16);
            this.labLinkClicked.TabIndex = 18;
            this.labLinkClicked.Text = "When tray notification or recent file is clicked:";
            // 
            // rCopy2Clipboard
            // 
            this.rCopy2Clipboard.AccessibleDescription = "";
            this.rCopy2Clipboard.AccessibleName = "copy link to clipboard";
            this.rCopy2Clipboard.Location = new System.Drawing.Point(29, 78);
            this.rCopy2Clipboard.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rCopy2Clipboard.Name = "rCopy2Clipboard";
            this.rCopy2Clipboard.Size = new System.Drawing.Size(544, 21);
            this.rCopy2Clipboard.TabIndex = 2;
            this.rCopy2Clipboard.Text = "copy link to clipboard";
            this.rCopy2Clipboard.UseVisualStyleBackColor = true;
            this.rCopy2Clipboard.CheckedChanged += new System.EventHandler(this.rCopy2Clipboard_CheckedChanged);
            // 
            // rOpenInBrowser
            // 
            this.rOpenInBrowser.AccessibleDescription = "";
            this.rOpenInBrowser.AccessibleName = "open link in default browser";
            this.rOpenInBrowser.Checked = true;
            this.rOpenInBrowser.Location = new System.Drawing.Point(29, 49);
            this.rOpenInBrowser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rOpenInBrowser.Name = "rOpenInBrowser";
            this.rOpenInBrowser.Size = new System.Drawing.Size(544, 21);
            this.rOpenInBrowser.TabIndex = 1;
            this.rOpenInBrowser.TabStop = true;
            this.rOpenInBrowser.Text = "Open link in default browser";
            this.rOpenInBrowser.UseVisualStyleBackColor = true;
            this.rOpenInBrowser.CheckedChanged += new System.EventHandler(this.rOpenInBrowser_CheckedChanged);
            // 
            // gApp
            // 
            this.gApp.AccessibleDescription = "";
            this.gApp.Controls.Add(this.chkShellMenus);
            this.gApp.Controls.Add(this.bBrowseLogs);
            this.gApp.Controls.Add(this.chkEnableLogging);
            this.gApp.Controls.Add(this.chkShowNots);
            this.gApp.Controls.Add(this.chkStartUp);
            this.gApp.Location = new System.Drawing.Point(11, 151);
            this.gApp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gApp.Name = "gApp";
            this.gApp.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gApp.Size = new System.Drawing.Size(599, 139);
            this.gApp.TabIndex = 3;
            this.gApp.TabStop = false;
            this.gApp.Text = "Application";
            // 
            // chkShellMenus
            // 
            this.chkShellMenus.AccessibleName = "add program to windows right click menu";
            this.chkShellMenus.Location = new System.Drawing.Point(12, 108);
            this.chkShellMenus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkShellMenus.Name = "chkShellMenus";
            this.chkShellMenus.Size = new System.Drawing.Size(579, 21);
            this.chkShellMenus.TabIndex = 11;
            this.chkShellMenus.Text = "Add to context menu";
            this.chkShellMenus.UseVisualStyleBackColor = true;
            this.chkShellMenus.CheckedChanged += new System.EventHandler(this.chkShellMenus_CheckedChanged);
            // 
            // bBrowseLogs
            // 
            this.bBrowseLogs.AccessibleDescription = "opens the debug log file";
            this.bBrowseLogs.Location = new System.Drawing.Point(255, 75);
            this.bBrowseLogs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bBrowseLogs.Name = "bBrowseLogs";
            this.bBrowseLogs.Size = new System.Drawing.Size(119, 28);
            this.bBrowseLogs.TabIndex = 10;
            this.bBrowseLogs.Text = "View Log";
            this.bBrowseLogs.UseVisualStyleBackColor = true;
            this.bBrowseLogs.Click += new System.EventHandler(this.bBrowseLogs_Click);
            // 
            // chkEnableLogging
            // 
            this.chkEnableLogging.AccessibleName = "enable logging";
            this.chkEnableLogging.Location = new System.Drawing.Point(12, 80);
            this.chkEnableLogging.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkEnableLogging.Name = "chkEnableLogging";
            this.chkEnableLogging.Size = new System.Drawing.Size(579, 21);
            this.chkEnableLogging.TabIndex = 9;
            this.chkEnableLogging.Text = "Enable logging";
            this.chkEnableLogging.UseVisualStyleBackColor = true;
            this.chkEnableLogging.CheckedChanged += new System.EventHandler(this.chkEnableLogging_CheckedChanged);
            // 
            // chkShowNots
            // 
            this.chkShowNots.AccessibleDescription = "";
            this.chkShowNots.AccessibleName = "show notifications";
            this.chkShowNots.Checked = true;
            this.chkShowNots.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkShowNots.Location = new System.Drawing.Point(12, 52);
            this.chkShowNots.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkShowNots.Name = "chkShowNots";
            this.chkShowNots.Size = new System.Drawing.Size(579, 21);
            this.chkShowNots.TabIndex = 7;
            this.chkShowNots.Text = "Show notifications";
            this.chkShowNots.UseVisualStyleBackColor = true;
            this.chkShowNots.CheckedChanged += new System.EventHandler(this.chkShowNots_CheckedChanged);
            // 
            // chkStartUp
            // 
            this.chkStartUp.AccessibleDescription = "";
            this.chkStartUp.AccessibleName = "start on system startup";
            this.chkStartUp.Location = new System.Drawing.Point(12, 23);
            this.chkStartUp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkStartUp.Name = "chkStartUp";
            this.chkStartUp.Size = new System.Drawing.Size(579, 21);
            this.chkStartUp.TabIndex = 6;
            this.chkStartUp.Text = "Start on system start up";
            this.chkStartUp.UseVisualStyleBackColor = true;
            this.chkStartUp.CheckedChanged += new System.EventHandler(this.chkStartUp_CheckedChanged);
            // 
            // tabAccount
            // 
            this.tabAccount.AccessibleDescription = "";
            this.tabAccount.Controls.Add(this.bRemoveAccount);
            this.tabAccount.Controls.Add(this.bAddAccount);
            this.tabAccount.Controls.Add(this.cProfiles);
            this.tabAccount.Controls.Add(this.gAccount);
            this.tabAccount.Location = new System.Drawing.Point(4, 25);
            this.tabAccount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabAccount.Name = "tabAccount";
            this.tabAccount.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabAccount.Size = new System.Drawing.Size(621, 453);
            this.tabAccount.TabIndex = 1;
            this.tabAccount.Text = "Account";
            this.tabAccount.UseVisualStyleBackColor = true;
            // 
            // bRemoveAccount
            // 
            this.bRemoveAccount.AccessibleName = "Remove this account";
            this.bRemoveAccount.Location = new System.Drawing.Point(507, 12);
            this.bRemoveAccount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bRemoveAccount.Name = "bRemoveAccount";
            this.bRemoveAccount.Size = new System.Drawing.Size(100, 28);
            this.bRemoveAccount.TabIndex = 17;
            this.bRemoveAccount.Text = "Remove";
            this.bRemoveAccount.UseVisualStyleBackColor = true;
            this.bRemoveAccount.Click += new System.EventHandler(this.bRemoveAccount_Click);
            // 
            // bAddAccount
            // 
            this.bAddAccount.AccessibleName = "Add a new account";
            this.bAddAccount.Location = new System.Drawing.Point(399, 12);
            this.bAddAccount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bAddAccount.Name = "bAddAccount";
            this.bAddAccount.Size = new System.Drawing.Size(100, 28);
            this.bAddAccount.TabIndex = 16;
            this.bAddAccount.Text = "Add New";
            this.bAddAccount.UseVisualStyleBackColor = true;
            this.bAddAccount.Click += new System.EventHandler(this.bAddAccount_Click);
            // 
            // cProfiles
            // 
            this.cProfiles.AccessibleDescription = "Select the current account";
            this.cProfiles.AccessibleName = "Profiles";
            this.cProfiles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cProfiles.FormattingEnabled = true;
            this.cProfiles.Location = new System.Drawing.Point(11, 14);
            this.cProfiles.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cProfiles.Name = "cProfiles";
            this.cProfiles.Size = new System.Drawing.Size(379, 24);
            this.cProfiles.TabIndex = 15;
            this.cProfiles.SelectedIndexChanged += new System.EventHandler(this.cProfiles_SelectedIndexChanged);
            // 
            // gAccount
            // 
            this.gAccount.AccessibleDescription = "";
            this.gAccount.AccessibleName = "";
            this.gAccount.Controls.Add(this.tTempPrefix);
            this.gAccount.Controls.Add(this.labTempPrefix);
            this.gAccount.Controls.Add(this.rBothWaySync);
            this.gAccount.Controls.Add(this.labWayOfSync);
            this.gAccount.Controls.Add(this.rRemoteToLocalOnly);
            this.gAccount.Controls.Add(this.rLocalToRemoteOnly);
            this.gAccount.Controls.Add(this.labViewInBrowser);
            this.gAccount.Controls.Add(this.chkWebInt);
            this.gAccount.Controls.Add(this.bConfigureAccount);
            this.gAccount.Controls.Add(this.labAccount);
            this.gAccount.Location = new System.Drawing.Point(11, 62);
            this.gAccount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gAccount.Name = "gAccount";
            this.gAccount.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gAccount.Size = new System.Drawing.Size(596, 262);
            this.gAccount.TabIndex = 3;
            this.gAccount.TabStop = false;
            this.gAccount.Text = "Profile";
            // 
            // tTempPrefix
            // 
            this.tTempPrefix.AccessibleDescription = "the prefix added to temporary files created by the application";
            this.tTempPrefix.Location = new System.Drawing.Point(28, 223);
            this.tTempPrefix.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tTempPrefix.Name = "tTempPrefix";
            this.tTempPrefix.Size = new System.Drawing.Size(543, 22);
            this.tTempPrefix.TabIndex = 24;
            this.tTempPrefix.TextChanged += new System.EventHandler(this.tTempPrefix_TextChanged);
            this.tTempPrefix.Leave += new System.EventHandler(this.tTempPrefix_Leave);
            // 
            // labTempPrefix
            // 
            this.labTempPrefix.AccessibleDescription = "";
            this.labTempPrefix.Location = new System.Drawing.Point(11, 197);
            this.labTempPrefix.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labTempPrefix.Name = "labTempPrefix";
            this.labTempPrefix.Size = new System.Drawing.Size(583, 16);
            this.labTempPrefix.TabIndex = 23;
            this.labTempPrefix.Text = "Temporary file prefix:";
            // 
            // rBothWaySync
            // 
            this.rBothWaySync.AccessibleDescription = "both upload and download";
            this.rBothWaySync.AccessibleName = "";
            this.rBothWaySync.Checked = true;
            this.rBothWaySync.Location = new System.Drawing.Point(28, 167);
            this.rBothWaySync.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rBothWaySync.Name = "rBothWaySync";
            this.rBothWaySync.Size = new System.Drawing.Size(544, 21);
            this.rBothWaySync.TabIndex = 21;
            this.rBothWaySync.TabStop = true;
            this.rBothWaySync.Text = "Both ways";
            this.rBothWaySync.UseVisualStyleBackColor = true;
            this.rBothWaySync.CheckedChanged += new System.EventHandler(this.rWayOfSync_CheckedChanged);
            // 
            // labWayOfSync
            // 
            this.labWayOfSync.AccessibleDescription = "";
            this.labWayOfSync.Location = new System.Drawing.Point(11, 85);
            this.labWayOfSync.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labWayOfSync.Name = "labWayOfSync";
            this.labWayOfSync.Size = new System.Drawing.Size(583, 16);
            this.labWayOfSync.TabIndex = 22;
            this.labWayOfSync.Text = "Way of synchronization:";
            // 
            // rRemoteToLocalOnly
            // 
            this.rRemoteToLocalOnly.AccessibleDescription = "only download files to local machine";
            this.rRemoteToLocalOnly.AccessibleName = "";
            this.rRemoteToLocalOnly.Location = new System.Drawing.Point(28, 139);
            this.rRemoteToLocalOnly.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rRemoteToLocalOnly.Name = "rRemoteToLocalOnly";
            this.rRemoteToLocalOnly.Size = new System.Drawing.Size(544, 21);
            this.rRemoteToLocalOnly.TabIndex = 20;
            this.rRemoteToLocalOnly.Text = "Remote to local only";
            this.rRemoteToLocalOnly.UseVisualStyleBackColor = true;
            this.rRemoteToLocalOnly.CheckedChanged += new System.EventHandler(this.rWayOfSync_CheckedChanged);
            // 
            // rLocalToRemoteOnly
            // 
            this.rLocalToRemoteOnly.AccessibleDescription = "only upload files to server";
            this.rLocalToRemoteOnly.AccessibleName = "";
            this.rLocalToRemoteOnly.Location = new System.Drawing.Point(28, 111);
            this.rLocalToRemoteOnly.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rLocalToRemoteOnly.Name = "rLocalToRemoteOnly";
            this.rLocalToRemoteOnly.Size = new System.Drawing.Size(544, 21);
            this.rLocalToRemoteOnly.TabIndex = 19;
            this.rLocalToRemoteOnly.Text = "Local to remote only";
            this.rLocalToRemoteOnly.UseVisualStyleBackColor = true;
            this.rLocalToRemoteOnly.CheckedChanged += new System.EventHandler(this.rWayOfSync_CheckedChanged);
            // 
            // labViewInBrowser
            // 
            this.labViewInBrowser.AccessibleDescription = "opens the web interface in browser";
            this.labViewInBrowser.AccessibleName = "View in browser";
            this.labViewInBrowser.AutoSize = true;
            this.labViewInBrowser.Location = new System.Drawing.Point(248, 57);
            this.labViewInBrowser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labViewInBrowser.Name = "labViewInBrowser";
            this.labViewInBrowser.Size = new System.Drawing.Size(108, 16);
            this.labViewInBrowser.TabIndex = 16;
            this.labViewInBrowser.TabStop = true;
            this.labViewInBrowser.Text = "(View in browser)";
            this.labViewInBrowser.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.labViewInBrowser_LinkClicked);
            // 
            // chkWebInt
            // 
            this.chkWebInt.AccessibleDescription = "";
            this.chkWebInt.AccessibleName = "use the web interface?";
            this.chkWebInt.Location = new System.Drawing.Point(11, 55);
            this.chkWebInt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkWebInt.Name = "chkWebInt";
            this.chkWebInt.Size = new System.Drawing.Size(577, 21);
            this.chkWebInt.TabIndex = 15;
            this.chkWebInt.Text = "Use the web interface";
            this.chkWebInt.UseVisualStyleBackColor = true;
            this.chkWebInt.CheckedChanged += new System.EventHandler(this.chkWebInt_CheckedChanged);
            // 
            // bConfigureAccount
            // 
            this.bConfigureAccount.AccessibleDescription = "opens a form with details of this account";
            this.bConfigureAccount.AccessibleName = "Account details";
            this.bConfigureAccount.Location = new System.Drawing.Point(433, 20);
            this.bConfigureAccount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bConfigureAccount.Name = "bConfigureAccount";
            this.bConfigureAccount.Size = new System.Drawing.Size(143, 28);
            this.bConfigureAccount.TabIndex = 14;
            this.bConfigureAccount.Text = "Details";
            this.bConfigureAccount.UseVisualStyleBackColor = true;
            this.bConfigureAccount.Click += new System.EventHandler(this.bConfigureAccount_Click);
            // 
            // labAccount
            // 
            this.labAccount.AccessibleDescription = "";
            this.labAccount.Location = new System.Drawing.Point(8, 26);
            this.labAccount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labAccount.Name = "labAccount";
            this.labAccount.Size = new System.Drawing.Size(580, 16);
            this.labAccount.TabIndex = 4;
            this.labAccount.Text = "Account:";
            // 
            // tabFilters
            // 
            this.tabFilters.Controls.Add(this.gFileFilters);
            this.tabFilters.Location = new System.Drawing.Point(4, 25);
            this.tabFilters.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabFilters.Name = "tabFilters";
            this.tabFilters.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabFilters.Size = new System.Drawing.Size(621, 453);
            this.tabFilters.TabIndex = 5;
            this.tabFilters.Text = "Filters";
            this.tabFilters.UseVisualStyleBackColor = true;
            // 
            // gFileFilters
            // 
            this.gFileFilters.Controls.Add(this.bConfigureSelectiveSync);
            this.gFileFilters.Controls.Add(this.bConfigureExtensions);
            this.gFileFilters.Controls.Add(this.labSelectiveSync);
            this.gFileFilters.Controls.Add(this.labAlsoIgnore);
            this.gFileFilters.Controls.Add(this.cIgnoreOldFiles);
            this.gFileFilters.Controls.Add(this.dtpLastModTime);
            this.gFileFilters.Controls.Add(this.labSelectExtensions);
            this.gFileFilters.Controls.Add(this.cIgnoreTempFiles);
            this.gFileFilters.Controls.Add(this.cIgnoreDotfiles);
            this.gFileFilters.Location = new System.Drawing.Point(11, 7);
            this.gFileFilters.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gFileFilters.Name = "gFileFilters";
            this.gFileFilters.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gFileFilters.Size = new System.Drawing.Size(596, 244);
            this.gFileFilters.TabIndex = 5;
            this.gFileFilters.TabStop = false;
            this.gFileFilters.Text = "File Filters";
            // 
            // bConfigureSelectiveSync
            // 
            this.bConfigureSelectiveSync.AccessibleDescription = "Open form to configure selective sync";
            this.bConfigureSelectiveSync.Location = new System.Drawing.Point(433, 23);
            this.bConfigureSelectiveSync.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bConfigureSelectiveSync.Name = "bConfigureSelectiveSync";
            this.bConfigureSelectiveSync.Size = new System.Drawing.Size(143, 28);
            this.bConfigureSelectiveSync.TabIndex = 13;
            this.bConfigureSelectiveSync.Text = "Configure";
            this.bConfigureSelectiveSync.UseVisualStyleBackColor = true;
            this.bConfigureSelectiveSync.Click += new System.EventHandler(this.bConfigureSelectiveSync_Click);
            // 
            // bConfigureExtensions
            // 
            this.bConfigureExtensions.AccessibleDescription = "Open form to configure ignored extensions";
            this.bConfigureExtensions.Location = new System.Drawing.Point(433, 59);
            this.bConfigureExtensions.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bConfigureExtensions.Name = "bConfigureExtensions";
            this.bConfigureExtensions.Size = new System.Drawing.Size(143, 28);
            this.bConfigureExtensions.TabIndex = 12;
            this.bConfigureExtensions.Text = "Configure";
            this.bConfigureExtensions.UseVisualStyleBackColor = true;
            this.bConfigureExtensions.Click += new System.EventHandler(this.bConfigureExtensions_Click);
            // 
            // labSelectiveSync
            // 
            this.labSelectiveSync.Location = new System.Drawing.Point(8, 30);
            this.labSelectiveSync.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labSelectiveSync.Name = "labSelectiveSync";
            this.labSelectiveSync.Size = new System.Drawing.Size(580, 16);
            this.labSelectiveSync.TabIndex = 11;
            this.labSelectiveSync.Text = "Selective Sync";
            // 
            // labAlsoIgnore
            // 
            this.labAlsoIgnore.Location = new System.Drawing.Point(8, 101);
            this.labAlsoIgnore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labAlsoIgnore.Name = "labAlsoIgnore";
            this.labAlsoIgnore.Size = new System.Drawing.Size(580, 16);
            this.labAlsoIgnore.TabIndex = 10;
            this.labAlsoIgnore.Text = "Also Ignore:";
            // 
            // cIgnoreOldFiles
            // 
            this.cIgnoreOldFiles.Location = new System.Drawing.Point(29, 177);
            this.cIgnoreOldFiles.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cIgnoreOldFiles.Name = "cIgnoreOldFiles";
            this.cIgnoreOldFiles.Size = new System.Drawing.Size(544, 21);
            this.cIgnoreOldFiles.TabIndex = 9;
            this.cIgnoreOldFiles.Text = "Files modified before:";
            this.cIgnoreOldFiles.UseVisualStyleBackColor = true;
            this.cIgnoreOldFiles.CheckedChanged += new System.EventHandler(this.cIgnoreOldFiles_CheckedChanged);
            // 
            // dtpLastModTime
            // 
            this.dtpLastModTime.CustomFormat = "d MMMM yyyy - HH:mm";
            this.dtpLastModTime.Enabled = false;
            this.dtpLastModTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpLastModTime.Location = new System.Drawing.Point(53, 206);
            this.dtpLastModTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpLastModTime.Name = "dtpLastModTime";
            this.dtpLastModTime.Size = new System.Drawing.Size(307, 22);
            this.dtpLastModTime.TabIndex = 8;
            this.dtpLastModTime.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtpLastModTime.ValueChanged += new System.EventHandler(this.dtpLastModTime_ValueChanged);
            // 
            // labSelectExtensions
            // 
            this.labSelectExtensions.Location = new System.Drawing.Point(8, 65);
            this.labSelectExtensions.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labSelectExtensions.Name = "labSelectExtensions";
            this.labSelectExtensions.Size = new System.Drawing.Size(580, 16);
            this.labSelectExtensions.TabIndex = 5;
            this.labSelectExtensions.Text = "Ignored Extensions";
            // 
            // cIgnoreTempFiles
            // 
            this.cIgnoreTempFiles.AccessibleDescription = "Check to ignore temporary files";
            this.cIgnoreTempFiles.Location = new System.Drawing.Point(29, 121);
            this.cIgnoreTempFiles.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cIgnoreTempFiles.Name = "cIgnoreTempFiles";
            this.cIgnoreTempFiles.Size = new System.Drawing.Size(544, 21);
            this.cIgnoreTempFiles.TabIndex = 0;
            this.cIgnoreTempFiles.Text = "Temporary files";
            this.cIgnoreTempFiles.UseVisualStyleBackColor = true;
            this.cIgnoreTempFiles.CheckedChanged += new System.EventHandler(this.cIgnoreTempFiles_CheckedChanged);
            // 
            // cIgnoreDotfiles
            // 
            this.cIgnoreDotfiles.AccessibleDescription = "Check to ignore dotfiles";
            this.cIgnoreDotfiles.Location = new System.Drawing.Point(29, 149);
            this.cIgnoreDotfiles.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cIgnoreDotfiles.Name = "cIgnoreDotfiles";
            this.cIgnoreDotfiles.Size = new System.Drawing.Size(544, 21);
            this.cIgnoreDotfiles.TabIndex = 1;
            this.cIgnoreDotfiles.Text = "Dotfiles";
            this.cIgnoreDotfiles.UseVisualStyleBackColor = true;
            this.cIgnoreDotfiles.CheckedChanged += new System.EventHandler(this.cIgnoreDotfiles_CheckedChanged);
            // 
            // tabBandwidth
            // 
            this.tabBandwidth.Controls.Add(this.gSyncing);
            this.tabBandwidth.Controls.Add(this.gLimits);
            this.tabBandwidth.Location = new System.Drawing.Point(4, 25);
            this.tabBandwidth.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabBandwidth.Name = "tabBandwidth";
            this.tabBandwidth.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabBandwidth.Size = new System.Drawing.Size(621, 453);
            this.tabBandwidth.TabIndex = 3;
            this.tabBandwidth.Text = "Bandwidth";
            this.tabBandwidth.UseVisualStyleBackColor = true;
            // 
            // gSyncing
            // 
            this.gSyncing.Controls.Add(this.labSeconds);
            this.gSyncing.Controls.Add(this.labSyncWhen);
            this.gSyncing.Controls.Add(this.nSyncFrequency);
            this.gSyncing.Controls.Add(this.cAuto);
            this.gSyncing.Controls.Add(this.cManually);
            this.gSyncing.Location = new System.Drawing.Point(11, 7);
            this.gSyncing.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gSyncing.Name = "gSyncing";
            this.gSyncing.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gSyncing.Size = new System.Drawing.Size(596, 153);
            this.gSyncing.TabIndex = 2;
            this.gSyncing.TabStop = false;
            this.gSyncing.Text = "Syncing";
            // 
            // labSeconds
            // 
            this.labSeconds.Location = new System.Drawing.Point(155, 112);
            this.labSeconds.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labSeconds.Name = "labSeconds";
            this.labSeconds.Size = new System.Drawing.Size(296, 16);
            this.labSeconds.TabIndex = 5;
            this.labSeconds.Text = "seconds";
            // 
            // labSyncWhen
            // 
            this.labSyncWhen.Location = new System.Drawing.Point(8, 27);
            this.labSyncWhen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labSyncWhen.Name = "labSyncWhen";
            this.labSyncWhen.Size = new System.Drawing.Size(580, 16);
            this.labSyncWhen.TabIndex = 4;
            this.labSyncWhen.Text = "Synchronize remote files:";
            // 
            // nSyncFrequency
            // 
            this.nSyncFrequency.AccessibleName = "synchronization interval in seconds";
            this.nSyncFrequency.Location = new System.Drawing.Point(47, 110);
            this.nSyncFrequency.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nSyncFrequency.Maximum = new decimal(new int[] {
            79228,
            0,
            0,
            0});
            this.nSyncFrequency.Name = "nSyncFrequency";
            this.nSyncFrequency.Size = new System.Drawing.Size(100, 22);
            this.nSyncFrequency.TabIndex = 2;
            this.nSyncFrequency.ValueChanged += new System.EventHandler(this.nSyncFrequency_ValueChanged);
            // 
            // cAuto
            // 
            this.cAuto.AccessibleName = "synchronize automatically";
            this.cAuto.Location = new System.Drawing.Point(29, 81);
            this.cAuto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cAuto.Name = "cAuto";
            this.cAuto.Size = new System.Drawing.Size(548, 21);
            this.cAuto.TabIndex = 1;
            this.cAuto.TabStop = true;
            this.cAuto.Text = "automatically every";
            this.cAuto.UseVisualStyleBackColor = true;
            // 
            // cManually
            // 
            this.cManually.AccessibleName = "synchronize manually";
            this.cManually.Location = new System.Drawing.Point(29, 53);
            this.cManually.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cManually.Name = "cManually";
            this.cManually.Size = new System.Drawing.Size(548, 21);
            this.cManually.TabIndex = 0;
            this.cManually.TabStop = true;
            this.cManually.Text = "manually";
            this.cManually.UseVisualStyleBackColor = true;
            this.cManually.CheckedChanged += new System.EventHandler(this.cManually_CheckedChanged);
            // 
            // gLimits
            // 
            this.gLimits.Controls.Add(this.labNoLimits);
            this.gLimits.Controls.Add(this.label4);
            this.gLimits.Controls.Add(this.label3);
            this.gLimits.Controls.Add(this.nUpLimit);
            this.gLimits.Controls.Add(this.nDownLimit);
            this.gLimits.Controls.Add(this.labUpSpeed);
            this.gLimits.Controls.Add(this.labDownSpeed);
            this.gLimits.Location = new System.Drawing.Point(11, 167);
            this.gLimits.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gLimits.Name = "gLimits";
            this.gLimits.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gLimits.Size = new System.Drawing.Size(596, 194);
            this.gLimits.TabIndex = 1;
            this.gLimits.TabStop = false;
            this.gLimits.Text = "Speed Limits";
            // 
            // labNoLimits
            // 
            this.labNoLimits.Location = new System.Drawing.Point(29, 162);
            this.labNoLimits.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labNoLimits.Name = "labNoLimits";
            this.labNoLimits.Size = new System.Drawing.Size(548, 16);
            this.labNoLimits.TabIndex = 14;
            this.labNoLimits.Text = "( set to 0 for no limits )";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(159, 126);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(292, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "KB/s";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(159, 59);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(292, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "KB/s";
            // 
            // nUpLimit
            // 
            this.nUpLimit.AccessibleName = "upload speed limit";
            this.nUpLimit.Location = new System.Drawing.Point(47, 123);
            this.nUpLimit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nUpLimit.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nUpLimit.Name = "nUpLimit";
            this.nUpLimit.Size = new System.Drawing.Size(100, 22);
            this.nUpLimit.TabIndex = 9;
            this.nUpLimit.ValueChanged += new System.EventHandler(this.nUpLimit_ValueChanged);
            // 
            // nDownLimit
            // 
            this.nDownLimit.AccessibleName = "download speed limit";
            this.nDownLimit.Location = new System.Drawing.Point(47, 55);
            this.nDownLimit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nDownLimit.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nDownLimit.Name = "nDownLimit";
            this.nDownLimit.Size = new System.Drawing.Size(100, 22);
            this.nDownLimit.TabIndex = 6;
            this.nDownLimit.ValueChanged += new System.EventHandler(this.nDownLimit_ValueChanged);
            // 
            // labUpSpeed
            // 
            this.labUpSpeed.Location = new System.Drawing.Point(12, 95);
            this.labUpSpeed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labUpSpeed.Name = "labUpSpeed";
            this.labUpSpeed.Size = new System.Drawing.Size(576, 16);
            this.labUpSpeed.TabIndex = 6;
            this.labUpSpeed.Text = "Limit Upload Speed:";
            // 
            // labDownSpeed
            // 
            this.labDownSpeed.Location = new System.Drawing.Point(8, 27);
            this.labDownSpeed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labDownSpeed.Name = "labDownSpeed";
            this.labDownSpeed.Size = new System.Drawing.Size(580, 16);
            this.labDownSpeed.TabIndex = 3;
            this.labDownSpeed.Text = "Limit Download Speed:";
            // 
            // tabAbout
            // 
            this.tabAbout.AccessibleDescription = "";
            this.tabAbout.Controls.Add(this.labSupportMail);
            this.tabAbout.Controls.Add(this.linkLabel4);
            this.tabAbout.Controls.Add(this.linkLabel3);
            this.tabAbout.Controls.Add(this.label19);
            this.tabAbout.Controls.Add(this.label21);
            this.tabAbout.Controls.Add(this.lVersion);
            this.tabAbout.Controls.Add(this.labLangUsed);
            this.tabAbout.Controls.Add(this.labContact);
            this.tabAbout.Controls.Add(this.labSite);
            this.tabAbout.Controls.Add(this.labTeam);
            this.tabAbout.Controls.Add(this.labCurVersion);
            this.tabAbout.Controls.Add(this.gContribute);
            this.tabAbout.Controls.Add(this.gNotes);
            this.tabAbout.Location = new System.Drawing.Point(4, 25);
            this.tabAbout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabAbout.Name = "tabAbout";
            this.tabAbout.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabAbout.Size = new System.Drawing.Size(621, 453);
            this.tabAbout.TabIndex = 2;
            this.tabAbout.Text = "About";
            this.tabAbout.UseVisualStyleBackColor = true;
            // 
            // labSupportMail
            // 
            this.labSupportMail.AccessibleDescription = "";
            this.labSupportMail.Location = new System.Drawing.Point(363, 139);
            this.labSupportMail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labSupportMail.Name = "labSupportMail";
            this.labSupportMail.Size = new System.Drawing.Size(172, 16);
            this.labSupportMail.TabIndex = 14;
            this.labSupportMail.Text = "support@ftpbox.org";
            // 
            // linkLabel4
            // 
            this.linkLabel4.AccessibleDescription = "";
            this.linkLabel4.Location = new System.Drawing.Point(363, 82);
            this.linkLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new System.Drawing.Size(172, 16);
            this.linkLabel4.TabIndex = 9;
            this.linkLabel4.TabStop = true;
            this.linkLabel4.Text = "ftpbox.org";
            this.linkLabel4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel4_LinkClicked);
            // 
            // linkLabel3
            // 
            this.linkLabel3.AccessibleDescription = "";
            this.linkLabel3.Location = new System.Drawing.Point(363, 54);
            this.linkLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(172, 16);
            this.linkLabel3.TabIndex = 8;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "FTPbox team";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // label19
            // 
            this.label19.AccessibleDescription = "";
            this.label19.Location = new System.Drawing.Point(363, 167);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(172, 16);
            this.label19.TabIndex = 13;
            this.label19.Text = "C# / .NET";
            // 
            // label21
            // 
            this.label21.AccessibleDescription = "";
            this.label21.Location = new System.Drawing.Point(363, 111);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(172, 16);
            this.label21.TabIndex = 11;
            this.label21.Text = "admin@ftpbox.org";
            // 
            // lVersion
            // 
            this.lVersion.AccessibleDescription = "";
            this.lVersion.Location = new System.Drawing.Point(363, 26);
            this.lVersion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lVersion.Name = "lVersion";
            this.lVersion.Size = new System.Drawing.Size(172, 16);
            this.lVersion.TabIndex = 8;
            this.lVersion.Text = "X.X.X (build X)";
            // 
            // labLangUsed
            // 
            this.labLangUsed.AccessibleDescription = "";
            this.labLangUsed.AutoSize = true;
            this.labLangUsed.Location = new System.Drawing.Point(136, 167);
            this.labLangUsed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labLangUsed.Name = "labLangUsed";
            this.labLangUsed.Size = new System.Drawing.Size(104, 16);
            this.labLangUsed.TabIndex = 7;
            this.labLangUsed.Text = "Language used:";
            // 
            // labContact
            // 
            this.labContact.AccessibleDescription = "";
            this.labContact.AutoSize = true;
            this.labContact.Location = new System.Drawing.Point(136, 111);
            this.labContact.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labContact.Name = "labContact";
            this.labContact.Size = new System.Drawing.Size(55, 16);
            this.labContact.TabIndex = 5;
            this.labContact.Text = "Contact:";
            // 
            // labSite
            // 
            this.labSite.AccessibleDescription = "";
            this.labSite.AutoSize = true;
            this.labSite.Location = new System.Drawing.Point(136, 82);
            this.labSite.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labSite.Name = "labSite";
            this.labSite.Size = new System.Drawing.Size(103, 16);
            this.labSite.TabIndex = 4;
            this.labSite.Text = "Official Website:";
            // 
            // labTeam
            // 
            this.labTeam.AccessibleDescription = "";
            this.labTeam.AutoSize = true;
            this.labTeam.Location = new System.Drawing.Point(136, 54);
            this.labTeam.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labTeam.Name = "labTeam";
            this.labTeam.Size = new System.Drawing.Size(73, 16);
            this.labTeam.TabIndex = 3;
            this.labTeam.Text = "The Team:";
            // 
            // labCurVersion
            // 
            this.labCurVersion.AccessibleDescription = "";
            this.labCurVersion.AutoSize = true;
            this.labCurVersion.Location = new System.Drawing.Point(136, 26);
            this.labCurVersion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labCurVersion.Name = "labCurVersion";
            this.labCurVersion.Size = new System.Drawing.Size(101, 16);
            this.labCurVersion.TabIndex = 2;
            this.labCurVersion.Text = "Current Version:";
            // 
            // gContribute
            // 
            this.gContribute.AccessibleDescription = "";
            this.gContribute.Controls.Add(this.labDonate);
            this.gContribute.Controls.Add(this.pictureBox1);
            this.gContribute.Controls.Add(this.linkLabel2);
            this.gContribute.Controls.Add(this.linkLabel1);
            this.gContribute.Location = new System.Drawing.Point(11, 236);
            this.gContribute.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gContribute.Name = "gContribute";
            this.gContribute.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gContribute.Size = new System.Drawing.Size(596, 59);
            this.gContribute.TabIndex = 1;
            this.gContribute.TabStop = false;
            this.gContribute.Text = "Contribute";
            // 
            // labDonate
            // 
            this.labDonate.AutoSize = true;
            this.labDonate.Location = new System.Drawing.Point(8, 66);
            this.labDonate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labDonate.Name = "labDonate";
            this.labDonate.Size = new System.Drawing.Size(54, 16);
            this.labDonate.TabIndex = 4;
            this.labDonate.Text = "Donate:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.AccessibleDescription = "opens donate page";
            this.pictureBox1.AccessibleName = "Donate button";
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::FTPbox.Properties.Resources.donate;
            this.pictureBox1.Location = new System.Drawing.Point(489, 23);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(74, 21);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AccessibleDescription = "";
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(236, 23);
            this.linkLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(113, 16);
            this.linkLabel2.TabIndex = 12;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Request a feature";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AccessibleDescription = "";
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(8, 23);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(85, 16);
            this.linkLabel1.TabIndex = 11;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Report a bug";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // gNotes
            // 
            this.gNotes.AccessibleDescription = "";
            this.gNotes.Controls.Add(this.label11);
            this.gNotes.Controls.Add(this.labContactMe);
            this.gNotes.Controls.Add(this.labFree);
            this.gNotes.Location = new System.Drawing.Point(11, 303);
            this.gNotes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gNotes.Name = "gNotes";
            this.gNotes.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gNotes.Size = new System.Drawing.Size(596, 85);
            this.gNotes.TabIndex = 0;
            this.gNotes.TabStop = false;
            this.gNotes.Text = "Notes";
            // 
            // label11
            // 
            this.label11.AccessibleDescription = "";
            this.label11.Location = new System.Drawing.Point(8, 62);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(580, 16);
            this.label11.TabIndex = 3;
            this.label11.Text = "Copyright © 2015 - ftpbox.org";
            // 
            // labContactMe
            // 
            this.labContactMe.AccessibleDescription = "";
            this.labContactMe.Location = new System.Drawing.Point(8, 43);
            this.labContactMe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labContactMe.Name = "labContactMe";
            this.labContactMe.Size = new System.Drawing.Size(580, 16);
            this.labContactMe.TabIndex = 2;
            this.labContactMe.Text = "- Feel free to contact me for anything.";
            // 
            // labFree
            // 
            this.labFree.AccessibleDescription = "";
            this.labFree.Location = new System.Drawing.Point(8, 23);
            this.labFree.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labFree.Name = "labFree";
            this.labFree.Size = new System.Drawing.Size(580, 16);
            this.labFree.TabIndex = 0;
            this.labFree.Text = "- FTPbox is free and open-source";
            // 
            // tray
            // 
            this.tray.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.tray.ContextMenuStrip = this.trayMenu;
            this.tray.Icon = ((System.Drawing.Icon)(resources.GetObject("tray.Icon")));
            this.tray.Text = "FTPbox";
            this.tray.Visible = true;
            this.tray.BalloonTipClicked += new System.EventHandler(this.tray_BalloonTipClicked);
            this.tray.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tray_MouseClick);
            this.tray.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tray_MouseDoubleClick);
            // 
            // trayMenu
            // 
            this.trayMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.trayMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem,
            this.toolStripSeparator2,
            this.SyncToolStripMenuItem,
            this.toolStripSeparator1,
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.trayMenu.Name = "trayMenu";
            this.trayMenu.Size = new System.Drawing.Size(163, 112);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(162, 24);
            this.optionsToolStripMenuItem.Text = "Options";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(159, 6);
            // 
            // SyncToolStripMenuItem
            // 
            this.SyncToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.SyncToolStripMenuItem.Name = "SyncToolStripMenuItem";
            this.SyncToolStripMenuItem.Size = new System.Drawing.Size(162, 24);
            this.SyncToolStripMenuItem.Text = "Start syncing";
            this.SyncToolStripMenuItem.Click += new System.EventHandler(this.SyncToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(159, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(162, 24);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(162, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 473);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SHSO Launcher";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fMain_FormClosing);
            this.Load += new System.EventHandler(this.fMain_Load);
            this.RightToLeftLayoutChanged += new System.EventHandler(this.fMain_RightToLeftLayoutChanged);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabGeneral.ResumeLayout(false);
            this.gLanguage.ResumeLayout(false);
            this.gLinks.ResumeLayout(false);
            this.gApp.ResumeLayout(false);
            this.tabAccount.ResumeLayout(false);
            this.gAccount.ResumeLayout(false);
            this.gAccount.PerformLayout();
            this.tabFilters.ResumeLayout(false);
            this.gFileFilters.ResumeLayout(false);
            this.tabBandwidth.ResumeLayout(false);
            this.gSyncing.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nSyncFrequency)).EndInit();
            this.gLimits.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nUpLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nDownLimit)).EndInit();
            this.tabAbout.ResumeLayout(false);
            this.tabAbout.PerformLayout();
            this.gContribute.ResumeLayout(false);
            this.gContribute.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gNotes.ResumeLayout(false);
            this.trayMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabGeneral;
        private System.Windows.Forms.GroupBox gApp;
        private System.Windows.Forms.CheckBox chkShowNots;
        private System.Windows.Forms.CheckBox chkStartUp;
        private System.Windows.Forms.TabPage tabAccount;
        private System.Windows.Forms.TabPage tabAbout;
        private System.Windows.Forms.Label labSupportMail;
        private System.Windows.Forms.LinkLabel linkLabel4;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label lVersion;
        private System.Windows.Forms.Label labLangUsed;
        private System.Windows.Forms.Label labContact;
        private System.Windows.Forms.Label labSite;
        private System.Windows.Forms.Label labTeam;
        private System.Windows.Forms.Label labCurVersion;
        private System.Windows.Forms.GroupBox gContribute;
        private System.Windows.Forms.Label labDonate;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.GroupBox gNotes;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label labContactMe;
        private System.Windows.Forms.Label labFree;
        private System.Windows.Forms.NotifyIcon tray;
        private System.Windows.Forms.ContextMenuStrip trayMenu;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TabPage tabBandwidth;
        private System.Windows.Forms.GroupBox gLinks;
        private System.Windows.Forms.RadioButton rCopy2Clipboard;
        private System.Windows.Forms.RadioButton rOpenInBrowser;
        private System.Windows.Forms.GroupBox gAccount;
        private System.Windows.Forms.Label labAccount;
        private System.Windows.Forms.GroupBox gLimits;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nUpLimit;
        private System.Windows.Forms.NumericUpDown nDownLimit;
        private System.Windows.Forms.Label labUpSpeed;
        private System.Windows.Forms.Label labDownSpeed;
        private System.Windows.Forms.RadioButton rOpenLocal;
        private System.Windows.Forms.GroupBox gSyncing;
        private System.Windows.Forms.NumericUpDown nSyncFrequency;
        private System.Windows.Forms.RadioButton cAuto;
        private System.Windows.Forms.RadioButton cManually;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem SyncToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Label labSyncWhen;
        private System.Windows.Forms.Label labSeconds;
        private System.Windows.Forms.Label labNoLimits;
        private System.Windows.Forms.TabPage tabFilters;
        private System.Windows.Forms.GroupBox gFileFilters;
        private System.Windows.Forms.Label labSelectExtensions;
        private System.Windows.Forms.CheckBox cIgnoreTempFiles;
        private System.Windows.Forms.CheckBox cIgnoreDotfiles;
        private System.Windows.Forms.Label labAlsoIgnore;
        private System.Windows.Forms.CheckBox cIgnoreOldFiles;
        private System.Windows.Forms.DateTimePicker dtpLastModTime;
        private System.Windows.Forms.Label labLinkClicked;
        private System.Windows.Forms.ComboBox cProfiles;
        private System.Windows.Forms.CheckBox chkEnableLogging;
        private System.Windows.Forms.Button bBrowseLogs;
        private System.Windows.Forms.Button bAddAccount;
        private System.Windows.Forms.Button bRemoveAccount;
        private System.Windows.Forms.GroupBox gLanguage;
        private System.Windows.Forms.ComboBox cLanguages;
        private System.Windows.Forms.Button bTranslate;
        private System.Windows.Forms.Button bConfigureExtensions;
        private System.Windows.Forms.Label labSelectiveSync;
        private System.Windows.Forms.Button bConfigureSelectiveSync;
        private System.Windows.Forms.Button bConfigureAccount;
        private System.Windows.Forms.LinkLabel labViewInBrowser;
        private System.Windows.Forms.CheckBox chkWebInt;
        private System.Windows.Forms.RadioButton rBothWaySync;
        private System.Windows.Forms.Label labWayOfSync;
        private System.Windows.Forms.RadioButton rRemoteToLocalOnly;
        private System.Windows.Forms.RadioButton rLocalToRemoteOnly;
        private System.Windows.Forms.TextBox tTempPrefix;
        private System.Windows.Forms.Label labTempPrefix;
        private System.Windows.Forms.CheckBox chkShellMenus;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label totalSizeLabel;
    }
}