﻿namespace SADXModManager
{
    partial class MainForm
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
			System.Windows.Forms.GroupBox groupBox2;
			System.Windows.Forms.Label label3;
			System.Windows.Forms.Label label1;
			System.Windows.Forms.Label label2;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.pauseWhenInactiveCheckBox = new System.Windows.Forms.CheckBox();
			this.disableCDCheckCheckBox = new System.Windows.Forms.CheckBox();
			this.screenNumComboBox = new System.Windows.Forms.ComboBox();
			this.stretchFullscreenCheckBox = new System.Windows.Forms.CheckBox();
			this.nativeResolutionButton = new System.Windows.Forms.Button();
			this.forceAspectRatioCheckBox = new System.Windows.Forms.CheckBox();
			this.windowedFullscreenCheckBox = new System.Windows.Forms.CheckBox();
			this.fileCheckBox = new System.Windows.Forms.CheckBox();
			this.screenCheckBox = new System.Windows.Forms.CheckBox();
			this.verticalResolution = new System.Windows.Forms.NumericUpDown();
			this.horizontalResolution = new System.Windows.Forms.NumericUpDown();
			this.useCustomResolutionCheckBox = new System.Windows.Forms.CheckBox();
			this.consoleCheckBox = new System.Windows.Forms.CheckBox();
			this.buttonModsFolder = new System.Windows.Forms.Button();
			this.buttonRefreshModList = new System.Windows.Forms.Button();
			this.modDescription = new System.Windows.Forms.Label();
			this.modListView = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.saveButton = new System.Windows.Forms.Button();
			this.saveAndPlayButton = new System.Windows.Forms.Button();
			this.installButton = new System.Windows.Forms.Button();
			this.configEditorButton = new System.Windows.Forms.Button();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.buttonNewMod = new System.Windows.Forms.Button();
			this.modDownButton = new System.Windows.Forms.Button();
			this.modUpButton = new System.Windows.Forms.Button();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.codesCheckedListBox = new System.Windows.Forms.CheckedListBox();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.checkVsync = new System.Windows.Forms.CheckBox();
			this.maintainWindowAspectRatioCheckBox = new System.Windows.Forms.CheckBox();
			this.windowWidth = new System.Windows.Forms.NumericUpDown();
			this.windowHeight = new System.Windows.Forms.NumericUpDown();
			this.customWindowSizeCheckBox = new System.Windows.Forms.CheckBox();
			this.forceTextureFilterCheckBox = new System.Windows.Forms.CheckBox();
			this.forceMipmappingCheckBox = new System.Windows.Forms.CheckBox();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.checkScaleHud = new System.Windows.Forms.CheckBox();
			groupBox2 = new System.Windows.Forms.GroupBox();
			label3 = new System.Windows.Forms.Label();
			label1 = new System.Windows.Forms.Label();
			label2 = new System.Windows.Forms.Label();
			groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.verticalResolution)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.horizontalResolution)).BeginInit();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.tabPage3.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.windowWidth)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.windowHeight)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox2
			// 
			groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			groupBox2.Controls.Add(this.pauseWhenInactiveCheckBox);
			groupBox2.Controls.Add(this.disableCDCheckCheckBox);
			groupBox2.Location = new System.Drawing.Point(6, 198);
			groupBox2.Name = "groupBox2";
			groupBox2.Size = new System.Drawing.Size(366, 42);
			groupBox2.TabIndex = 1;
			groupBox2.TabStop = false;
			groupBox2.Text = "Misc.";
			// 
			// pauseWhenInactiveCheckBox
			// 
			this.pauseWhenInactiveCheckBox.AutoSize = true;
			this.pauseWhenInactiveCheckBox.Location = new System.Drawing.Point(125, 19);
			this.pauseWhenInactiveCheckBox.Name = "pauseWhenInactiveCheckBox";
			this.pauseWhenInactiveCheckBox.Size = new System.Drawing.Size(129, 17);
			this.pauseWhenInactiveCheckBox.TabIndex = 1;
			this.pauseWhenInactiveCheckBox.Text = "Pause When Inactive";
			this.toolTip1.SetToolTip(this.pauseWhenInactiveCheckBox, "Uncheck to allow the game to run in the background.");
			this.pauseWhenInactiveCheckBox.UseVisualStyleBackColor = true;
			// 
			// disableCDCheckCheckBox
			// 
			this.disableCDCheckCheckBox.AutoSize = true;
			this.disableCDCheckCheckBox.Location = new System.Drawing.Point(6, 19);
			this.disableCDCheckCheckBox.Name = "disableCDCheckCheckBox";
			this.disableCDCheckCheckBox.Size = new System.Drawing.Size(113, 17);
			this.disableCDCheckCheckBox.TabIndex = 0;
			this.disableCDCheckCheckBox.Text = "Disable CD Check";
			this.toolTip1.SetToolTip(this.disableCDCheckCheckBox, "Allows you to run the game without the disc.");
			this.disableCDCheckCheckBox.UseVisualStyleBackColor = true;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new System.Drawing.Point(6, 22);
			label3.Name = "label3";
			label3.Size = new System.Drawing.Size(44, 13);
			label3.TabIndex = 0;
			label3.Text = "Screen:";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new System.Drawing.Point(219, 73);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(12, 13);
			label1.TabIndex = 7;
			label1.Text = "x";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new System.Drawing.Point(219, 118);
			label2.Name = "label2";
			label2.Size = new System.Drawing.Size(12, 13);
			label2.TabIndex = 13;
			label2.Text = "x";
			// 
			// screenNumComboBox
			// 
			this.screenNumComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.screenNumComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.screenNumComboBox.FormattingEnabled = true;
			this.screenNumComboBox.Items.AddRange(new object[] {
            "All Screens"});
			this.screenNumComboBox.Location = new System.Drawing.Point(56, 19);
			this.screenNumComboBox.Name = "screenNumComboBox";
			this.screenNumComboBox.Size = new System.Drawing.Size(304, 21);
			this.screenNumComboBox.TabIndex = 1;
			this.toolTip1.SetToolTip(this.screenNumComboBox, "The screen to put the game on.");
			// 
			// stretchFullscreenCheckBox
			// 
			this.stretchFullscreenCheckBox.AutoSize = true;
			this.stretchFullscreenCheckBox.Location = new System.Drawing.Point(151, 46);
			this.stretchFullscreenCheckBox.Name = "stretchFullscreenCheckBox";
			this.stretchFullscreenCheckBox.Size = new System.Drawing.Size(102, 17);
			this.stretchFullscreenCheckBox.TabIndex = 3;
			this.stretchFullscreenCheckBox.Text = "Scale to Screen";
			this.toolTip1.SetToolTip(this.stretchFullscreenCheckBox, "Coupled with Windowed Fullscreen, you can downsample the game from resolutions hi" +
        "gher than your screen supports.");
			this.stretchFullscreenCheckBox.UseVisualStyleBackColor = true;
			// 
			// nativeResolutionButton
			// 
			this.nativeResolutionButton.AutoSize = true;
			this.nativeResolutionButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.nativeResolutionButton.Location = new System.Drawing.Point(305, 67);
			this.nativeResolutionButton.Name = "nativeResolutionButton";
			this.nativeResolutionButton.Size = new System.Drawing.Size(48, 23);
			this.nativeResolutionButton.TabIndex = 9;
			this.nativeResolutionButton.Text = "Native";
			this.toolTip1.SetToolTip(this.nativeResolutionButton, "Sets resolution to the selected screen\'s native resolution.");
			this.nativeResolutionButton.UseVisualStyleBackColor = true;
			this.nativeResolutionButton.Click += new System.EventHandler(this.nativeResolutionButton_Click);
			// 
			// forceAspectRatioCheckBox
			// 
			this.forceAspectRatioCheckBox.AutoSize = true;
			this.forceAspectRatioCheckBox.Location = new System.Drawing.Point(6, 92);
			this.forceAspectRatioCheckBox.Name = "forceAspectRatioCheckBox";
			this.forceAspectRatioCheckBox.Size = new System.Drawing.Size(135, 17);
			this.forceAspectRatioCheckBox.TabIndex = 10;
			this.forceAspectRatioCheckBox.Text = "Force 4:3 Aspect Ratio";
			this.forceAspectRatioCheckBox.UseVisualStyleBackColor = true;
			this.forceAspectRatioCheckBox.CheckedChanged += new System.EventHandler(this.forceAspectRatioCheckBox_CheckedChanged);
			// 
			// windowedFullscreenCheckBox
			// 
			this.windowedFullscreenCheckBox.AutoSize = true;
			this.windowedFullscreenCheckBox.Location = new System.Drawing.Point(6, 46);
			this.windowedFullscreenCheckBox.Name = "windowedFullscreenCheckBox";
			this.windowedFullscreenCheckBox.Size = new System.Drawing.Size(128, 17);
			this.windowedFullscreenCheckBox.TabIndex = 2;
			this.windowedFullscreenCheckBox.Text = "Windowed Fullscreen";
			this.toolTip1.SetToolTip(this.windowedFullscreenCheckBox, "Enables borderless fullscreen mode.\r\nYou have to enable fullscreen in the config " +
        "editor for it to work.");
			this.windowedFullscreenCheckBox.UseVisualStyleBackColor = true;
			// 
			// fileCheckBox
			// 
			this.fileCheckBox.AutoSize = true;
			this.fileCheckBox.Location = new System.Drawing.Point(142, 19);
			this.fileCheckBox.Name = "fileCheckBox";
			this.fileCheckBox.Size = new System.Drawing.Size(42, 17);
			this.fileCheckBox.TabIndex = 2;
			this.fileCheckBox.Text = "File";
			this.toolTip1.SetToolTip(this.fileCheckBox, "Logs debug messages to mods/SADXModLoader.log");
			this.fileCheckBox.UseVisualStyleBackColor = true;
			// 
			// screenCheckBox
			// 
			this.screenCheckBox.AutoSize = true;
			this.screenCheckBox.Location = new System.Drawing.Point(76, 19);
			this.screenCheckBox.Name = "screenCheckBox";
			this.screenCheckBox.Size = new System.Drawing.Size(60, 17);
			this.screenCheckBox.TabIndex = 1;
			this.screenCheckBox.Text = "Screen";
			this.toolTip1.SetToolTip(this.screenCheckBox, "Displays debug messages ingame.");
			this.screenCheckBox.UseVisualStyleBackColor = true;
			// 
			// verticalResolution
			// 
			this.verticalResolution.Location = new System.Drawing.Point(237, 69);
			this.verticalResolution.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
			this.verticalResolution.Minimum = new decimal(new int[] {
            480,
            0,
            0,
            0});
			this.verticalResolution.Name = "verticalResolution";
			this.verticalResolution.Size = new System.Drawing.Size(62, 20);
			this.verticalResolution.TabIndex = 8;
			this.verticalResolution.Value = new decimal(new int[] {
            480,
            0,
            0,
            0});
			this.verticalResolution.ValueChanged += new System.EventHandler(this.verticalResolution_ValueChanged);
			// 
			// horizontalResolution
			// 
			this.horizontalResolution.Location = new System.Drawing.Point(151, 69);
			this.horizontalResolution.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
			this.horizontalResolution.Minimum = new decimal(new int[] {
            640,
            0,
            0,
            0});
			this.horizontalResolution.Name = "horizontalResolution";
			this.horizontalResolution.Size = new System.Drawing.Size(62, 20);
			this.horizontalResolution.TabIndex = 6;
			this.horizontalResolution.Value = new decimal(new int[] {
            640,
            0,
            0,
            0});
			// 
			// useCustomResolutionCheckBox
			// 
			this.useCustomResolutionCheckBox.AutoSize = true;
			this.useCustomResolutionCheckBox.Location = new System.Drawing.Point(6, 71);
			this.useCustomResolutionCheckBox.Name = "useCustomResolutionCheckBox";
			this.useCustomResolutionCheckBox.Size = new System.Drawing.Size(139, 17);
			this.useCustomResolutionCheckBox.TabIndex = 5;
			this.useCustomResolutionCheckBox.Text = "Use Custom Resolution:";
			this.toolTip1.SetToolTip(this.useCustomResolutionCheckBox, "Overrides resolution preset with custom resolution.");
			this.useCustomResolutionCheckBox.UseVisualStyleBackColor = true;
			this.useCustomResolutionCheckBox.CheckedChanged += new System.EventHandler(this.useCustomResolutionCheckBox_CheckedChanged);
			// 
			// consoleCheckBox
			// 
			this.consoleCheckBox.AutoSize = true;
			this.consoleCheckBox.Location = new System.Drawing.Point(6, 19);
			this.consoleCheckBox.Name = "consoleCheckBox";
			this.consoleCheckBox.Size = new System.Drawing.Size(64, 17);
			this.consoleCheckBox.TabIndex = 0;
			this.consoleCheckBox.Text = "Console";
			this.toolTip1.SetToolTip(this.consoleCheckBox, "Shows a console and displays debug messages.");
			this.consoleCheckBox.UseVisualStyleBackColor = true;
			// 
			// buttonModsFolder
			// 
			this.buttonModsFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonModsFolder.Location = new System.Drawing.Point(87, 223);
			this.buttonModsFolder.Name = "buttonModsFolder";
			this.buttonModsFolder.Size = new System.Drawing.Size(105, 23);
			this.buttonModsFolder.TabIndex = 4;
			this.buttonModsFolder.Text = "&Open Mods folder";
			this.buttonModsFolder.UseVisualStyleBackColor = true;
			this.buttonModsFolder.Click += new System.EventHandler(this.buttonModsFolder_Click);
			// 
			// buttonRefreshModList
			// 
			this.buttonRefreshModList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonRefreshModList.Location = new System.Drawing.Point(6, 223);
			this.buttonRefreshModList.Name = "buttonRefreshModList";
			this.buttonRefreshModList.Size = new System.Drawing.Size(75, 23);
			this.buttonRefreshModList.TabIndex = 3;
			this.buttonRefreshModList.Text = "&Refresh";
			this.buttonRefreshModList.UseVisualStyleBackColor = true;
			this.buttonRefreshModList.Click += new System.EventHandler(this.buttonRefreshModList_Click);
			// 
			// modDescription
			// 
			this.modDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.modDescription.Location = new System.Drawing.Point(6, 252);
			this.modDescription.Name = "modDescription";
			this.modDescription.Size = new System.Drawing.Size(366, 36);
			this.modDescription.TabIndex = 6;
			this.modDescription.Text = "Description: No mod selected.";
			// 
			// modListView
			// 
			this.modListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.modListView.CheckBoxes = true;
			this.modListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
			this.modListView.FullRowSelect = true;
			this.modListView.HideSelection = false;
			this.modListView.Location = new System.Drawing.Point(6, 6);
			this.modListView.Name = "modListView";
			this.modListView.Size = new System.Drawing.Size(331, 211);
			this.modListView.TabIndex = 0;
			this.modListView.UseCompatibleStateImageBehavior = false;
			this.modListView.View = System.Windows.Forms.View.Details;
			this.modListView.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.modListView_ItemCheck);
			this.modListView.SelectedIndexChanged += new System.EventHandler(this.modListView_SelectedIndexChanged);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Name";
			this.columnHeader1.Width = 154;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Author";
			this.columnHeader2.Width = 113;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Version";
			// 
			// saveButton
			// 
			this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.saveButton.Location = new System.Drawing.Point(92, 323);
			this.saveButton.Name = "saveButton";
			this.saveButton.Size = new System.Drawing.Size(75, 23);
			this.saveButton.TabIndex = 102;
			this.saveButton.Text = "&Save";
			this.saveButton.UseVisualStyleBackColor = true;
			this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
			// 
			// saveAndPlayButton
			// 
			this.saveAndPlayButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.saveAndPlayButton.AutoSize = true;
			this.saveAndPlayButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.saveAndPlayButton.Location = new System.Drawing.Point(12, 323);
			this.saveAndPlayButton.Name = "saveAndPlayButton";
			this.saveAndPlayButton.Size = new System.Drawing.Size(74, 23);
			this.saveAndPlayButton.TabIndex = 101;
			this.saveAndPlayButton.Text = "Save && &Play";
			this.saveAndPlayButton.UseVisualStyleBackColor = true;
			this.saveAndPlayButton.Click += new System.EventHandler(this.saveAndPlayButton_Click);
			// 
			// installButton
			// 
			this.installButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.installButton.AutoSize = true;
			this.installButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.installButton.Location = new System.Drawing.Point(173, 323);
			this.installButton.Name = "installButton";
			this.installButton.Size = new System.Drawing.Size(76, 23);
			this.installButton.TabIndex = 103;
			this.installButton.Text = "Install loader";
			this.installButton.UseVisualStyleBackColor = true;
			this.installButton.Click += new System.EventHandler(this.installButton_Click);
			// 
			// configEditorButton
			// 
			this.configEditorButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.configEditorButton.AutoSize = true;
			this.configEditorButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.configEditorButton.Location = new System.Drawing.Point(295, 323);
			this.configEditorButton.Name = "configEditorButton";
			this.configEditorButton.Size = new System.Drawing.Size(77, 23);
			this.configEditorButton.TabIndex = 104;
			this.configEditorButton.Text = "&Config Editor";
			this.configEditorButton.UseVisualStyleBackColor = true;
			this.configEditorButton.Click += new System.EventHandler(this.configEditorButton_Click);
			// 
			// tabControl1
			// 
			this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(386, 317);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.buttonNewMod);
			this.tabPage1.Controls.Add(this.buttonModsFolder);
			this.tabPage1.Controls.Add(this.buttonRefreshModList);
			this.tabPage1.Controls.Add(this.modDescription);
			this.tabPage1.Controls.Add(this.modDownButton);
			this.tabPage1.Controls.Add(this.modUpButton);
			this.tabPage1.Controls.Add(this.modListView);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(378, 291);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Mods";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// buttonNewMod
			// 
			this.buttonNewMod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonNewMod.Location = new System.Drawing.Point(269, 223);
			this.buttonNewMod.Name = "buttonNewMod";
			this.buttonNewMod.Size = new System.Drawing.Size(75, 23);
			this.buttonNewMod.TabIndex = 5;
			this.buttonNewMod.Text = "&New Mod";
			this.buttonNewMod.UseVisualStyleBackColor = true;
			this.buttonNewMod.Click += new System.EventHandler(this.buttonNewMod_Click);
			// 
			// modDownButton
			// 
			this.modDownButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.modDownButton.AutoSize = true;
			this.modDownButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.modDownButton.Enabled = false;
			this.modDownButton.Location = new System.Drawing.Point(349, 35);
			this.modDownButton.Name = "modDownButton";
			this.modDownButton.Size = new System.Drawing.Size(23, 23);
			this.modDownButton.TabIndex = 2;
			this.modDownButton.Text = "↓";
			this.modDownButton.UseVisualStyleBackColor = true;
			this.modDownButton.Click += new System.EventHandler(this.modDownButton_Click);
			// 
			// modUpButton
			// 
			this.modUpButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.modUpButton.AutoSize = true;
			this.modUpButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.modUpButton.Enabled = false;
			this.modUpButton.Location = new System.Drawing.Point(349, 6);
			this.modUpButton.Name = "modUpButton";
			this.modUpButton.Size = new System.Drawing.Size(23, 23);
			this.modUpButton.TabIndex = 1;
			this.modUpButton.Text = "↑";
			this.modUpButton.UseVisualStyleBackColor = true;
			this.modUpButton.Click += new System.EventHandler(this.modUpButton_Click);
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.codesCheckedListBox);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Size = new System.Drawing.Size(378, 291);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Codes";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// codesCheckedListBox
			// 
			this.codesCheckedListBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.codesCheckedListBox.FormattingEnabled = true;
			this.codesCheckedListBox.Location = new System.Drawing.Point(0, 0);
			this.codesCheckedListBox.Name = "codesCheckedListBox";
			this.codesCheckedListBox.Size = new System.Drawing.Size(378, 291);
			this.codesCheckedListBox.TabIndex = 0;
			this.codesCheckedListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.codesCheckedListBox_ItemCheck);
			// 
			// tabPage3
			// 
			this.tabPage3.AutoScroll = true;
			this.tabPage3.Controls.Add(this.groupBox1);
			this.tabPage3.Controls.Add(this.groupBox3);
			this.tabPage3.Controls.Add(groupBox2);
			this.tabPage3.Location = new System.Drawing.Point(4, 22);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage3.Size = new System.Drawing.Size(378, 291);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Options";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.consoleCheckBox);
			this.groupBox1.Controls.Add(this.screenCheckBox);
			this.groupBox1.Controls.Add(this.fileCheckBox);
			this.groupBox1.Location = new System.Drawing.Point(6, 246);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(366, 42);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Debug Messages";
			// 
			// groupBox3
			// 
			this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox3.Controls.Add(this.checkScaleHud);
			this.groupBox3.Controls.Add(this.checkVsync);
			this.groupBox3.Controls.Add(this.maintainWindowAspectRatioCheckBox);
			this.groupBox3.Controls.Add(this.windowWidth);
			this.groupBox3.Controls.Add(label2);
			this.groupBox3.Controls.Add(this.windowHeight);
			this.groupBox3.Controls.Add(this.customWindowSizeCheckBox);
			this.groupBox3.Controls.Add(this.forceTextureFilterCheckBox);
			this.groupBox3.Controls.Add(this.forceMipmappingCheckBox);
			this.groupBox3.Controls.Add(this.stretchFullscreenCheckBox);
			this.groupBox3.Controls.Add(label3);
			this.groupBox3.Controls.Add(this.screenNumComboBox);
			this.groupBox3.Controls.Add(this.forceAspectRatioCheckBox);
			this.groupBox3.Controls.Add(this.nativeResolutionButton);
			this.groupBox3.Controls.Add(this.useCustomResolutionCheckBox);
			this.groupBox3.Controls.Add(this.horizontalResolution);
			this.groupBox3.Controls.Add(this.windowedFullscreenCheckBox);
			this.groupBox3.Controls.Add(label1);
			this.groupBox3.Controls.Add(this.verticalResolution);
			this.groupBox3.Location = new System.Drawing.Point(6, 6);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(366, 186);
			this.groupBox3.TabIndex = 0;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Graphics";
			// 
			// checkVsync
			// 
			this.checkVsync.AutoSize = true;
			this.checkVsync.Location = new System.Drawing.Point(266, 46);
			this.checkVsync.Name = "checkVsync";
			this.checkVsync.Size = new System.Drawing.Size(94, 17);
			this.checkVsync.TabIndex = 4;
			this.checkVsync.Text = "Enable V-sync";
			this.checkVsync.UseVisualStyleBackColor = true;
			// 
			// maintainWindowAspectRatioCheckBox
			// 
			this.maintainWindowAspectRatioCheckBox.AutoSize = true;
			this.maintainWindowAspectRatioCheckBox.Location = new System.Drawing.Point(6, 140);
			this.maintainWindowAspectRatioCheckBox.Name = "maintainWindowAspectRatioCheckBox";
			this.maintainWindowAspectRatioCheckBox.Size = new System.Drawing.Size(130, 17);
			this.maintainWindowAspectRatioCheckBox.TabIndex = 15;
			this.maintainWindowAspectRatioCheckBox.Text = "Maintain Aspect Ratio";
			this.toolTip1.SetToolTip(this.maintainWindowAspectRatioCheckBox, "Forces the window\'s aspect ratio to match the current custom resolution\'s.");
			this.maintainWindowAspectRatioCheckBox.UseVisualStyleBackColor = true;
			this.maintainWindowAspectRatioCheckBox.CheckedChanged += new System.EventHandler(this.maintainWindowAspectRatioCheckBox_CheckedChanged);
			// 
			// windowWidth
			// 
			this.windowWidth.Location = new System.Drawing.Point(151, 114);
			this.windowWidth.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
			this.windowWidth.Minimum = new decimal(new int[] {
            320,
            0,
            0,
            0});
			this.windowWidth.Name = "windowWidth";
			this.windowWidth.Size = new System.Drawing.Size(62, 20);
			this.windowWidth.TabIndex = 12;
			this.windowWidth.Value = new decimal(new int[] {
            640,
            0,
            0,
            0});
			// 
			// windowHeight
			// 
			this.windowHeight.Location = new System.Drawing.Point(237, 114);
			this.windowHeight.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
			this.windowHeight.Minimum = new decimal(new int[] {
            240,
            0,
            0,
            0});
			this.windowHeight.Name = "windowHeight";
			this.windowHeight.Size = new System.Drawing.Size(62, 20);
			this.windowHeight.TabIndex = 14;
			this.windowHeight.Value = new decimal(new int[] {
            480,
            0,
            0,
            0});
			this.windowHeight.ValueChanged += new System.EventHandler(this.windowHeight_ValueChanged);
			// 
			// customWindowSizeCheckBox
			// 
			this.customWindowSizeCheckBox.AutoSize = true;
			this.customWindowSizeCheckBox.Location = new System.Drawing.Point(6, 115);
			this.customWindowSizeCheckBox.Name = "customWindowSizeCheckBox";
			this.customWindowSizeCheckBox.Size = new System.Drawing.Size(129, 17);
			this.customWindowSizeCheckBox.TabIndex = 11;
			this.customWindowSizeCheckBox.Text = "Custom Window Size:";
			this.toolTip1.SetToolTip(this.customWindowSizeCheckBox, "Allows you to specify a fixed size for the window in windowed mode.");
			this.customWindowSizeCheckBox.UseVisualStyleBackColor = true;
			this.customWindowSizeCheckBox.CheckedChanged += new System.EventHandler(this.customWindowSizeCheckBox_CheckedChanged);
			// 
			// forceTextureFilterCheckBox
			// 
			this.forceTextureFilterCheckBox.AutoSize = true;
			this.forceTextureFilterCheckBox.Location = new System.Drawing.Point(6, 163);
			this.forceTextureFilterCheckBox.Name = "forceTextureFilterCheckBox";
			this.forceTextureFilterCheckBox.Size = new System.Drawing.Size(131, 17);
			this.forceTextureFilterCheckBox.TabIndex = 17;
			this.forceTextureFilterCheckBox.Text = "Force Texture Filtering";
			this.toolTip1.SetToolTip(this.forceTextureFilterCheckBox, "Smooths scaled UI textures by changing the filter method from Point to Linear.");
			this.forceTextureFilterCheckBox.UseVisualStyleBackColor = true;
			// 
			// forceMipmappingCheckBox
			// 
			this.forceMipmappingCheckBox.AutoSize = true;
			this.forceMipmappingCheckBox.Location = new System.Drawing.Point(151, 163);
			this.forceMipmappingCheckBox.Name = "forceMipmappingCheckBox";
			this.forceMipmappingCheckBox.Size = new System.Drawing.Size(113, 17);
			this.forceMipmappingCheckBox.TabIndex = 18;
			this.forceMipmappingCheckBox.Text = "Force Mipmapping";
			this.toolTip1.SetToolTip(this.forceMipmappingCheckBox, "Generates mipmaps for all textures that don\'t have them.");
			this.forceMipmappingCheckBox.UseVisualStyleBackColor = true;
			// 
			// checkScaleHud
			// 
			this.checkScaleHud.AutoSize = true;
			this.checkScaleHud.Location = new System.Drawing.Point(151, 140);
			this.checkScaleHud.Name = "checkScaleHud";
			this.checkScaleHud.Size = new System.Drawing.Size(148, 17);
			this.checkScaleHud.TabIndex = 16;
			this.checkScaleHud.Text = "Scale HUD (experimental)";
			this.checkScaleHud.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(384, 361);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.configEditorButton);
			this.Controls.Add(this.installButton);
			this.Controls.Add(this.saveAndPlayButton);
			this.Controls.Add(this.saveButton);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(400, 400);
			this.Name = "MainForm";
			this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
			this.Text = "SADX Mod Manager";
			this.Load += new System.EventHandler(this.MainForm_Load);
			groupBox2.ResumeLayout(false);
			groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.verticalResolution)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.horizontalResolution)).EndInit();
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.tabPage3.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.windowWidth)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.windowHeight)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView modListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.CheckBox consoleCheckBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button saveAndPlayButton;
		private System.Windows.Forms.Button installButton;
		private System.Windows.Forms.CheckBox disableCDCheckCheckBox;
        private System.Windows.Forms.CheckBox useCustomResolutionCheckBox;
        private System.Windows.Forms.NumericUpDown horizontalResolution;
        private System.Windows.Forms.NumericUpDown verticalResolution;
        private System.Windows.Forms.Button configEditorButton;
        private System.Windows.Forms.Label modDescription;
		private System.Windows.Forms.Button buttonRefreshModList;
		private System.Windows.Forms.Button buttonModsFolder;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.CheckedListBox codesCheckedListBox;
		private System.Windows.Forms.CheckBox fileCheckBox;
		private System.Windows.Forms.CheckBox screenCheckBox;
		private System.Windows.Forms.CheckBox windowedFullscreenCheckBox;
		private System.Windows.Forms.Button buttonNewMod;
		private System.Windows.Forms.Button nativeResolutionButton;
		private System.Windows.Forms.CheckBox forceAspectRatioCheckBox;
		private System.Windows.Forms.CheckBox pauseWhenInactiveCheckBox;
		private System.Windows.Forms.CheckBox stretchFullscreenCheckBox;
		private System.Windows.Forms.ComboBox screenNumComboBox;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.CheckBox forceMipmappingCheckBox;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.CheckBox forceTextureFilterCheckBox;
		private System.Windows.Forms.CheckBox customWindowSizeCheckBox;
		private System.Windows.Forms.NumericUpDown windowWidth;
		private System.Windows.Forms.NumericUpDown windowHeight;
		private System.Windows.Forms.CheckBox maintainWindowAspectRatioCheckBox;
		private System.Windows.Forms.Button modDownButton;
		private System.Windows.Forms.Button modUpButton;
		private System.Windows.Forms.CheckBox checkVsync;
		private System.Windows.Forms.CheckBox checkScaleHud;
	}
}