﻿namespace ERPHelper
{
    partial class WDMainForm
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

       

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WDMainForm));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabXForm = new System.Windows.Forms.TabPage();
            this.lnkXFormInst = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTransform = new System.Windows.Forms.Button();
            this.lblWarning = new System.Windows.Forms.Label();
            this.tabWDStudioFiles = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.btnFilter = new System.Windows.Forms.Button();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.btnFolderSelect = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtWDStudioFolder = new System.Windows.Forms.TextBox();
            this.treeView1 = new CTreeView();
            this.label3 = new System.Windows.Forms.Label();
            this.tabWebSvcs = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblWWS = new System.Windows.Forms.Label();
            this.cboWWS1 = new System.Windows.Forms.ComboBox();
            this.lblOperation = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.cboXSD = new System.Windows.Forms.ComboBox();
            this.chkXSDLinkShow = new System.Windows.Forms.CheckBox();
            this.txtXSD = new System.Windows.Forms.TextBox();
            this.btnGenXML = new System.Windows.Forms.Button();
            this.lnkWWS = new System.Windows.Forms.LinkLabel();
            this.label7 = new System.Windows.Forms.Label();
            this.tabAPICalls = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel9 = new System.Windows.Forms.FlowLayoutPanel();
            this.lnkCallAPIInst = new System.Windows.Forms.LinkLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel7 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel8 = new System.Windows.Forms.FlowLayoutPanel();
            this.cboConnections = new System.Windows.Forms.ComboBox();
            this.btnConns = new System.Windows.Forms.Button();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTenant = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.label13 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.cboWWS2 = new CComboBox();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.label11 = new System.Windows.Forms.Label();
            this.txtVersion = new System.Windows.Forms.TextBox();
            this.lnkApiUrl = new System.Windows.Forms.LinkLabel();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnGetSOAP = new System.Windows.Forms.Button();
            this.btnCallAPI = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl.SuspendLayout();
            this.tabXForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabWDStudioFiles.SuspendLayout();
            this.tabWebSvcs.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.tabAPICalls.SuspendLayout();
            this.flowLayoutPanel9.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.flowLayoutPanel7.SuspendLayout();
            this.flowLayoutPanel8.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel6.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl.Controls.Add(this.tabXForm);
            this.tabControl.Controls.Add(this.tabWDStudioFiles);
            this.tabControl.Controls.Add(this.tabWebSvcs);
            this.tabControl.Controls.Add(this.tabAPICalls);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl.ItemSize = new System.Drawing.Size(25, 110);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(528, 444);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl.TabIndex = 4;
            this.tabControl.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl_Selected);
            // 
            // tabXForm
            // 
            this.tabXForm.AutoScroll = true;
            this.tabXForm.BackColor = System.Drawing.SystemColors.Info;
            this.tabXForm.Controls.Add(this.lnkXFormInst);
            this.tabXForm.Controls.Add(this.pictureBox1);
            this.tabXForm.Controls.Add(this.label2);
            this.tabXForm.Controls.Add(this.btnTransform);
            this.tabXForm.Controls.Add(this.lblWarning);
            this.tabXForm.Location = new System.Drawing.Point(114, 4);
            this.tabXForm.Name = "tabXForm";
            this.tabXForm.Padding = new System.Windows.Forms.Padding(3);
            this.tabXForm.Size = new System.Drawing.Size(410, 436);
            this.tabXForm.TabIndex = 0;
            this.tabXForm.Text = "XSLT";
            // 
            // lnkXFormInst
            // 
            this.lnkXFormInst.AutoSize = true;
            this.lnkXFormInst.Location = new System.Drawing.Point(11, 263);
            this.lnkXFormInst.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lnkXFormInst.Name = "lnkXFormInst";
            this.lnkXFormInst.Size = new System.Drawing.Size(92, 20);
            this.lnkXFormInst.TabIndex = 6;
            this.lnkXFormInst.TabStop = true;
            this.lnkXFormInst.Text = "Instructions";
            this.lnkXFormInst.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkInstructions_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 102);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(282, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Transform an XML file using XSLT";
            // 
            // btnTransform
            // 
            this.btnTransform.Location = new System.Drawing.Point(15, 192);
            this.btnTransform.Name = "btnTransform";
            this.btnTransform.Size = new System.Drawing.Size(122, 38);
            this.btnTransform.TabIndex = 0;
            this.btnTransform.Text = "Transform";
            this.btnTransform.UseVisualStyleBackColor = true;
            this.btnTransform.Click += new System.EventHandler(this.btnTransform_Click);
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.Location = new System.Drawing.Point(20, 233);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(0, 20);
            this.lblWarning.TabIndex = 1;
            // 
            // tabWDStudioFiles
            // 
            this.tabWDStudioFiles.AutoScroll = true;
            this.tabWDStudioFiles.BackColor = System.Drawing.SystemColors.Info;
            this.tabWDStudioFiles.Controls.Add(this.label5);
            this.tabWDStudioFiles.Controls.Add(this.btnFilter);
            this.tabWDStudioFiles.Controls.Add(this.txtFilter);
            this.tabWDStudioFiles.Controls.Add(this.btnFolderSelect);
            this.tabWDStudioFiles.Controls.Add(this.label4);
            this.tabWDStudioFiles.Controls.Add(this.txtWDStudioFolder);
            this.tabWDStudioFiles.Controls.Add(this.treeView1);
            this.tabWDStudioFiles.Controls.Add(this.label3);
            this.tabWDStudioFiles.Location = new System.Drawing.Point(114, 4);
            this.tabWDStudioFiles.Name = "tabWDStudioFiles";
            this.tabWDStudioFiles.Padding = new System.Windows.Forms.Padding(3);
            this.tabWDStudioFiles.Size = new System.Drawing.Size(410, 436);
            this.tabWDStudioFiles.TabIndex = 1;
            this.tabWDStudioFiles.Text = "Studio Files";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "File Filter";
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnFilter.BackgroundImage = global::ERPHelper.Properties.Resources.Filter_16x;
            this.btnFilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFilter.Location = new System.Drawing.Point(310, 158);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(32, 32);
            this.btnFilter.TabIndex = 3;
            this.btnFilter.Text = "...";
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(16, 161);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(288, 26);
            this.txtFilter.TabIndex = 2;
            this.txtFilter.Text = "*.xslt, *.xml, *.xsl";
            // 
            // btnFolderSelect
            // 
            this.btnFolderSelect.Location = new System.Drawing.Point(310, 77);
            this.btnFolderSelect.Name = "btnFolderSelect";
            this.btnFolderSelect.Size = new System.Drawing.Size(32, 32);
            this.btnFolderSelect.TabIndex = 1;
            this.btnFolderSelect.Text = "...";
            this.btnFolderSelect.UseVisualStyleBackColor = true;
            this.btnFolderSelect.Click += new System.EventHandler(this.btnFolderSelect_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(205, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Workday Studio Workspace";
            // 
            // txtWDStudioFolder
            // 
            this.txtWDStudioFolder.Location = new System.Drawing.Point(16, 83);
            this.txtWDStudioFolder.Name = "txtWDStudioFolder";
            this.txtWDStudioFolder.Size = new System.Drawing.Size(288, 26);
            this.txtWDStudioFolder.TabIndex = 0;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(16, 196);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(326, 600);
            this.treeView1.TabIndex = 4;
            this.treeView1.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseDoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Workday Studio Files";
            // 
            // tabWebSvcs
            // 
            this.tabWebSvcs.AutoScroll = true;
            this.tabWebSvcs.BackColor = System.Drawing.SystemColors.Info;
            this.tabWebSvcs.Controls.Add(this.flowLayoutPanel1);
            this.tabWebSvcs.Controls.Add(this.label7);
            this.tabWebSvcs.Location = new System.Drawing.Point(114, 4);
            this.tabWebSvcs.Name = "tabWebSvcs";
            this.tabWebSvcs.Size = new System.Drawing.Size(410, 436);
            this.tabWebSvcs.TabIndex = 2;
            this.tabWebSvcs.Text = "Web Services";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.lblWWS);
            this.flowLayoutPanel1.Controls.Add(this.cboWWS1);
            this.flowLayoutPanel1.Controls.Add(this.lblOperation);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel1.Controls.Add(this.chkXSDLinkShow);
            this.flowLayoutPanel1.Controls.Add(this.txtXSD);
            this.flowLayoutPanel1.Controls.Add(this.btnGenXML);
            this.flowLayoutPanel1.Controls.Add(this.lnkWWS);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(7, 52);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(395, 418);
            this.flowLayoutPanel1.TabIndex = 13;
            // 
            // lblWWS
            // 
            this.lblWWS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblWWS.AutoSize = true;
            this.lblWWS.Location = new System.Drawing.Point(3, 0);
            this.lblWWS.Name = "lblWWS";
            this.lblWWS.Size = new System.Drawing.Size(61, 20);
            this.lblWWS.TabIndex = 22;
            this.lblWWS.Text = "Service";
            this.lblWWS.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // cboWWS1
            // 
            this.cboWWS1.FormattingEnabled = true;
            this.cboWWS1.Location = new System.Drawing.Point(3, 23);
            this.cboWWS1.Name = "cboWWS1";
            this.cboWWS1.Size = new System.Drawing.Size(343, 28);
            this.cboWWS1.TabIndex = 0;
            this.cboWWS1.SelectedIndexChanged += new System.EventHandler(this.cboWWS1_SelectedIndexChanged);
            // 
            // lblOperation
            // 
            this.lblOperation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblOperation.AutoSize = true;
            this.lblOperation.Location = new System.Drawing.Point(3, 74);
            this.lblOperation.Margin = new System.Windows.Forms.Padding(3, 20, 3, 0);
            this.lblOperation.Name = "lblOperation";
            this.lblOperation.Size = new System.Drawing.Size(79, 20);
            this.lblOperation.TabIndex = 14;
            this.lblOperation.Text = "Operation";
            this.lblOperation.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.cboXSD);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 97);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(387, 40);
            this.flowLayoutPanel2.TabIndex = 20;
            // 
            // cboXSD
            // 
            this.cboXSD.FormattingEnabled = true;
            this.cboXSD.Location = new System.Drawing.Point(3, 3);
            this.cboXSD.Name = "cboXSD";
            this.cboXSD.Size = new System.Drawing.Size(343, 28);
            this.cboXSD.TabIndex = 1;
            this.cboXSD.SelectedIndexChanged += new System.EventHandler(this.cboXSD_SelectedIndexChanged);
            // 
            // chkXSDLinkShow
            // 
            this.chkXSDLinkShow.AutoSize = true;
            this.chkXSDLinkShow.Location = new System.Drawing.Point(3, 143);
            this.chkXSDLinkShow.Name = "chkXSDLinkShow";
            this.chkXSDLinkShow.Size = new System.Drawing.Size(131, 24);
            this.chkXSDLinkShow.TabIndex = 2;
            this.chkXSDLinkShow.Text = "Override URL";
            this.chkXSDLinkShow.UseVisualStyleBackColor = true;
            this.chkXSDLinkShow.CheckedChanged += new System.EventHandler(this.chkXSDLinkShow_CheckedChanged);
            // 
            // txtXSD
            // 
            this.txtXSD.Location = new System.Drawing.Point(3, 173);
            this.txtXSD.Name = "txtXSD";
            this.txtXSD.Size = new System.Drawing.Size(380, 26);
            this.txtXSD.TabIndex = 3;
            this.txtXSD.Visible = false;
            this.txtXSD.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtXSD_KeyUp);
            // 
            // btnGenXML
            // 
            this.btnGenXML.Location = new System.Drawing.Point(3, 227);
            this.btnGenXML.Margin = new System.Windows.Forms.Padding(3, 25, 3, 3);
            this.btnGenXML.Name = "btnGenXML";
            this.btnGenXML.Size = new System.Drawing.Size(208, 38);
            this.btnGenXML.TabIndex = 4;
            this.btnGenXML.Text = "Generate Sample XML";
            this.btnGenXML.UseVisualStyleBackColor = true;
            this.btnGenXML.Click += new System.EventHandler(this.btnGenXML_Click);
            // 
            // lnkWWS
            // 
            this.lnkWWS.AutoSize = true;
            this.lnkWWS.Location = new System.Drawing.Point(3, 288);
            this.lnkWWS.Margin = new System.Windows.Forms.Padding(3, 20, 3, 0);
            this.lnkWWS.Name = "lnkWWS";
            this.lnkWWS.Size = new System.Drawing.Size(294, 20);
            this.lnkWWS.TabIndex = 23;
            this.lnkWWS.TabStop = true;
            this.lnkWWS.Text = "Workday Web Services (WWS) Directory";
            this.lnkWWS.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkWWS_LinkClicked);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "Web Services";
            // 
            // tabAPICalls
            // 
            this.tabAPICalls.AutoScroll = true;
            this.tabAPICalls.BackColor = System.Drawing.SystemColors.Info;
            this.tabAPICalls.Controls.Add(this.flowLayoutPanel9);
            this.tabAPICalls.Controls.Add(this.groupBox2);
            this.tabAPICalls.Controls.Add(this.groupBox1);
            this.tabAPICalls.Controls.Add(this.lblPassword);
            this.tabAPICalls.Controls.Add(this.btnGetSOAP);
            this.tabAPICalls.Controls.Add(this.btnCallAPI);
            this.tabAPICalls.Controls.Add(this.label9);
            this.tabAPICalls.Location = new System.Drawing.Point(114, 4);
            this.tabAPICalls.Name = "tabAPICalls";
            this.tabAPICalls.Size = new System.Drawing.Size(410, 436);
            this.tabAPICalls.TabIndex = 3;
            this.tabAPICalls.Text = "API Calls";
            // 
            // flowLayoutPanel9
            // 
            this.flowLayoutPanel9.Controls.Add(this.lnkCallAPIInst);
            this.flowLayoutPanel9.Location = new System.Drawing.Point(15, 514);
            this.flowLayoutPanel9.Name = "flowLayoutPanel9";
            this.flowLayoutPanel9.Size = new System.Drawing.Size(369, 74);
            this.flowLayoutPanel9.TabIndex = 22;
            // 
            // lnkCallAPIInst
            // 
            this.lnkCallAPIInst.AutoSize = true;
            this.lnkCallAPIInst.Location = new System.Drawing.Point(3, 10);
            this.lnkCallAPIInst.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lnkCallAPIInst.Name = "lnkCallAPIInst";
            this.lnkCallAPIInst.Size = new System.Drawing.Size(92, 20);
            this.lnkCallAPIInst.TabIndex = 23;
            this.lnkCallAPIInst.TabStop = true;
            this.lnkCallAPIInst.Text = "Instructions";
            this.lnkCallAPIInst.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkCallAPIInst_LinkClicked);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.flowLayoutPanel7);
            this.groupBox2.Location = new System.Drawing.Point(9, 51);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(385, 168);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Connection";
            // 
            // flowLayoutPanel7
            // 
            this.flowLayoutPanel7.Controls.Add(this.flowLayoutPanel8);
            this.flowLayoutPanel7.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanel7.Controls.Add(this.flowLayoutPanel6);
            this.flowLayoutPanel7.Location = new System.Drawing.Point(6, 25);
            this.flowLayoutPanel7.Name = "flowLayoutPanel7";
            this.flowLayoutPanel7.Size = new System.Drawing.Size(373, 137);
            this.flowLayoutPanel7.TabIndex = 31;
            // 
            // flowLayoutPanel8
            // 
            this.flowLayoutPanel8.Controls.Add(this.cboConnections);
            this.flowLayoutPanel8.Controls.Add(this.btnConns);
            this.flowLayoutPanel8.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel8.Name = "flowLayoutPanel8";
            this.flowLayoutPanel8.Size = new System.Drawing.Size(366, 42);
            this.flowLayoutPanel8.TabIndex = 35;
            this.flowLayoutPanel8.WrapContents = false;
            // 
            // cboConnections
            // 
            this.cboConnections.FormattingEnabled = true;
            this.cboConnections.Location = new System.Drawing.Point(3, 3);
            this.cboConnections.Name = "cboConnections";
            this.cboConnections.Size = new System.Drawing.Size(309, 28);
            this.cboConnections.TabIndex = 33;
            this.cboConnections.SelectedIndexChanged += new System.EventHandler(this.cboConnections_SelectedIndexChanged);
            // 
            // btnConns
            // 
            this.btnConns.Location = new System.Drawing.Point(318, 0);
            this.btnConns.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.btnConns.Name = "btnConns";
            this.btnConns.Size = new System.Drawing.Size(32, 32);
            this.btnConns.TabIndex = 32;
            this.btnConns.Text = "...";
            this.btnConns.UseVisualStyleBackColor = true;
            this.btnConns.Click += new System.EventHandler(this.btnConns_Click);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.label12);
            this.flowLayoutPanel3.Controls.Add(this.txtTenant);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 51);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(366, 38);
            this.flowLayoutPanel3.TabIndex = 33;
            this.flowLayoutPanel3.WrapContents = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 3);
            this.label12.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 20);
            this.label12.TabIndex = 0;
            this.label12.Text = "Tenant";
            // 
            // txtTenant
            // 
            this.txtTenant.Location = new System.Drawing.Point(92, 3);
            this.txtTenant.Margin = new System.Windows.Forms.Padding(27, 3, 3, 3);
            this.txtTenant.MaximumSize = new System.Drawing.Size(250, 25);
            this.txtTenant.MinimumSize = new System.Drawing.Size(250, 25);
            this.txtTenant.Name = "txtTenant";
            this.txtTenant.ReadOnly = true;
            this.txtTenant.Size = new System.Drawing.Size(250, 26);
            this.txtTenant.TabIndex = 19;
            // 
            // flowLayoutPanel6
            // 
            this.flowLayoutPanel6.Controls.Add(this.label13);
            this.flowLayoutPanel6.Controls.Add(this.txtUsername);
            this.flowLayoutPanel6.Location = new System.Drawing.Point(3, 95);
            this.flowLayoutPanel6.Name = "flowLayoutPanel6";
            this.flowLayoutPanel6.Size = new System.Drawing.Size(366, 36);
            this.flowLayoutPanel6.TabIndex = 34;
            this.flowLayoutPanel6.WrapContents = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 3);
            this.label13.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 20);
            this.label13.TabIndex = 0;
            this.label13.Text = "Username";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(92, 3);
            this.txtUsername.MaximumSize = new System.Drawing.Size(250, 25);
            this.txtUsername.MinimumSize = new System.Drawing.Size(250, 25);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.ReadOnly = true;
            this.txtUsername.Size = new System.Drawing.Size(250, 26);
            this.txtUsername.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.flowLayoutPanel4);
            this.groupBox1.Location = new System.Drawing.Point(9, 242);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(385, 200);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Service";
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.AutoSize = true;
            this.flowLayoutPanel4.Controls.Add(this.cboWWS2);
            this.flowLayoutPanel4.Controls.Add(this.flowLayoutPanel5);
            this.flowLayoutPanel4.Controls.Add(this.lnkApiUrl);
            this.flowLayoutPanel4.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(6, 25);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(369, 154);
            this.flowLayoutPanel4.TabIndex = 22;
            this.flowLayoutPanel4.WrapContents = false;
            // 
            // cboWWS2
            // 
            this.cboWWS2.FormattingEnabled = true;
            this.cboWWS2.Location = new System.Drawing.Point(3, 3);
            this.cboWWS2.Name = "cboWWS2";
            this.cboWWS2.Size = new System.Drawing.Size(343, 28);
            this.cboWWS2.TabIndex = 22;
            this.cboWWS2.SelectedIndexChanged += new System.EventHandler(this.cboWWS2_SelectedIndexChanged);
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.Controls.Add(this.label11);
            this.flowLayoutPanel5.Controls.Add(this.txtVersion);
            this.flowLayoutPanel5.Location = new System.Drawing.Point(3, 37);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(200, 39);
            this.flowLayoutPanel5.TabIndex = 25;
            this.flowLayoutPanel5.WrapContents = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 3);
            this.label11.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 20);
            this.label11.TabIndex = 26;
            this.label11.Text = "Version";
            // 
            // txtVersion
            // 
            this.txtVersion.Location = new System.Drawing.Point(72, 3);
            this.txtVersion.Name = "txtVersion";
            this.txtVersion.Size = new System.Drawing.Size(79, 26);
            this.txtVersion.TabIndex = 24;
            this.txtVersion.TextChanged += new System.EventHandler(this.txtVersion_TextChanged);
            // 
            // lnkApiUrl
            // 
            this.lnkApiUrl.AutoSize = true;
            this.lnkApiUrl.Location = new System.Drawing.Point(3, 79);
            this.lnkApiUrl.MaximumSize = new System.Drawing.Size(350, 75);
            this.lnkApiUrl.MinimumSize = new System.Drawing.Size(350, 75);
            this.lnkApiUrl.Name = "lnkApiUrl";
            this.lnkApiUrl.Size = new System.Drawing.Size(350, 75);
            this.lnkApiUrl.TabIndex = 27;
            this.lnkApiUrl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkURL_LinkClicked);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(106, 219);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(87, 20);
            this.lblPassword.TabIndex = 8;
            this.lblPassword.Text = "";
            this.lblPassword.Visible = false;
            // 
            // btnGetSOAP
            // 
            this.btnGetSOAP.Location = new System.Drawing.Point(199, 452);
            this.btnGetSOAP.Name = "btnGetSOAP";
            this.btnGetSOAP.Size = new System.Drawing.Size(185, 38);
            this.btnGetSOAP.TabIndex = 10;
            this.btnGetSOAP.Text = "Get SOAP Wrapper";
            this.btnGetSOAP.UseVisualStyleBackColor = true;
            this.btnGetSOAP.Click += new System.EventHandler(this.btnGetSOAP_Click);
            // 
            // btnCallAPI
            // 
            this.btnCallAPI.Location = new System.Drawing.Point(15, 452);
            this.btnCallAPI.Name = "btnCallAPI";
            this.btnCallAPI.Size = new System.Drawing.Size(146, 38);
            this.btnCallAPI.TabIndex = 9;
            this.btnCallAPI.Text = "Call API";
            this.btnCallAPI.UseVisualStyleBackColor = true;
            this.btnCallAPI.Click += new System.EventHandler(this.btnCallAPI_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(15, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "API Calls";
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 20000;
            this.toolTip1.InitialDelay = 500;
            this.toolTip1.ReshowDelay = 100;
            // 
            // WDMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 444);
            this.Controls.Add(this.tabControl);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "WDMainForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "ERP Helper - Workday";
            this.tabControl.ResumeLayout(false);
            this.tabXForm.ResumeLayout(false);
            this.tabXForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabWDStudioFiles.ResumeLayout(false);
            this.tabWDStudioFiles.PerformLayout();
            this.tabWebSvcs.ResumeLayout(false);
            this.tabWebSvcs.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.tabAPICalls.ResumeLayout(false);
            this.tabAPICalls.PerformLayout();
            this.flowLayoutPanel9.ResumeLayout(false);
            this.flowLayoutPanel9.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.flowLayoutPanel7.ResumeLayout(false);
            this.flowLayoutPanel8.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.flowLayoutPanel6.ResumeLayout(false);
            this.flowLayoutPanel6.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel5.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabXForm;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTransform;
        private System.Windows.Forms.Label lblWarning;
        private System.Windows.Forms.TabPage tabWDStudioFiles;
        private CTreeView treeView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnFolderSelect;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtWDStudioFolder;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabWebSvcs;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage tabAPICalls;
        private System.Windows.Forms.Button btnCallAPI;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnGetSOAP;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lblOperation;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.ComboBox cboXSD;
        private System.Windows.Forms.CheckBox chkXSDLinkShow;
        private System.Windows.Forms.TextBox txtXSD;
        private System.Windows.Forms.Button btnGenXML;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private CComboBox cboWWS2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtVersion;
        private System.Windows.Forms.LinkLabel lnkApiUrl;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel7;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel8;
        private System.Windows.Forms.ComboBox cboConnections;
        private System.Windows.Forms.Button btnConns;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtTenant;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblWWS;
        private System.Windows.Forms.ComboBox cboWWS1;
        private System.Windows.Forms.LinkLabel lnkWWS;
        private System.Windows.Forms.LinkLabel lnkXFormInst;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel9;
        private System.Windows.Forms.LinkLabel lnkCallAPIInst;
    }
}