﻿using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using Kbg.NppPluginNET.PluginInfrastructure;
using System.Threading;
using System.Net;
using System.Collections.Generic;
using System.Xml;
using System.Text;
using System.Xml.Linq;
using System.Text.Json;

namespace ERPHelper
{
    public partial class WDMainForm : Form
    {
        static INotepadPPGateway notepad = new NotepadPPGateway();
        static IScintillaGateway editor = new ScintillaGateway(PluginBase.GetCurrentScintilla());
        static Dictionary<string, string> wdWebServices = new Dictionary<string, string>();
        const string WWSURL = "https://community.workday.com/sites/default/files/file-hosting/productionapi/index.html";
        const string WWSFILE = "ERPHelperWebServices.txt";

        public WDMainForm()
        {
            InitializeComponent();
            try
            {
                Cursor = Cursors.WaitCursor;
                // Tool Tips
                toolTip1.SetToolTip(lnkXFormInst, Properties.Resources.Instructions_XForm);
                toolTip1.SetToolTip(lnkCallAPIInst, Properties.Resources.Instructions_CallAPI);
                toolTip1.SetToolTip(lnkApiUrl, Properties.Resources.Instructions_Click2Copy2Clipboard);
                tabControl.DrawItem += new DrawItemEventHandler(tabControl_DrawItem);
                // Web Services Download
                string wdWebServicesURL = Settings.Get(IniSection.WDWebServices, IniKey.URL);
                string iniFolder = Path.GetDirectoryName(Settings.iniFilePath);

                if (String.IsNullOrEmpty(wdWebServicesURL))
                {
                    Settings.Set(IniSection.WDWebServices, IniKey.URL, WWSURL);
                    wdWebServices = WDWebService.Download(WWSURL);
                    File.WriteAllText(iniFolder + "\\" + WWSFILE, JsonSerializer.Serialize(wdWebServices));
                }
                else
                {
                    wdWebServices = WDWebService.Load(File.ReadAllText(iniFolder + "\\" + WWSFILE));
                }

                // Turn Off Event Handling During Init
                this.cboWWS1.SelectedIndexChanged -= new System.EventHandler(this.cboWWS1_SelectedIndexChanged);
                this.cboWWS2.SelectedIndexChanged -= new System.EventHandler(this.cboWWS2_SelectedIndexChanged);
                this.cboXSD.SelectedIndexChanged -= new System.EventHandler(this.cboXSD_SelectedIndexChanged);
                this.txtVersion.TextChanged -= new System.EventHandler(this.txtVersion_TextChanged);

                // Web Services
                cboWWS1.DisplayMember = "Value";
                cboWWS1.ValueMember = "Key";
                cboWWS1.DataSource = new BindingSource(wdWebServices, null);

                cboWWS2.DisplayMember = "Value";
                cboWWS2.ValueMember = "Key";
                cboWWS2.DataSource = new BindingSource(wdWebServices, null);

                // Connections
                ConnectionsLoad();

                // Init
                // Workday Studio Files
                string dir = Settings.Get(IniSection.WDStudio, IniKey.Workspace);
                if (!String.IsNullOrEmpty(dir) && Directory.Exists(dir))
                {
                    txtWDStudioFolder.Text = dir;
                    string filter = Settings.Get(IniSection.WDStudio, IniKey.WorkspaceFilter);
                    if (!String.IsNullOrEmpty(filter))
                    {
                        txtFilter.Text = filter;
                        TreeViewUpdate(txtWDStudioFolder.Text, txtFilter.Text);
                    }
                }

                // Web Services
                cboWWS1.SelectedIndex = cboWWS1.FindStringExact(Settings.Get(IniSection.State, cboWWS1.Name));
                string xsd = Settings.Get(IniSection.WDWebServices, IniKey.XSD);
                if (!String.IsNullOrEmpty(xsd))
                {
                    txtXSD.Text = xsd;
                }
                cboXSD_Load(txtXSD.Text);
                cboXSD.SelectedIndex = cboXSD.FindStringExact(Settings.Get(IniSection.State, cboXSD.Name));

                // API
                cboConnections.SelectedIndex = cboConnections.FindStringExact(Settings.Get(IniSection.State, cboConnections.Name));
                cboWWS2.SelectedIndex = cboWWS2.FindStringExact(Settings.Get(IniSection.State, cboWWS2.Name));
                txtVersion.Text = Settings.Get(IniSection.WDWebServices, IniKey.Version);
                if (cboConnections.SelectedIndex != ListBox.NoMatches && cboWWS2.SelectedIndex != ListBox.NoMatches)
                {
                    string conn = cboConnections.SelectedItem.ToString();
                    string service = cboWWS2.ReturnValue();
                    lnkApiUrl.Text = WDWebService.BuildApiUrl(conn, service, txtVersion.Text);
                }

                // Initial Tab
                string tab = Settings.Get(IniSection.State, tabControl.Name);
                if (!String.IsNullOrEmpty(tab))
                {
                    tabControl.SelectTab(tab);
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "ERP Helper Start", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Turn On Event Handling
                this.cboWWS1.SelectedIndexChanged += new System.EventHandler(this.cboWWS1_SelectedIndexChanged);
                this.cboWWS2.SelectedIndexChanged += new System.EventHandler(this.cboWWS2_SelectedIndexChanged);
                this.cboXSD.SelectedIndexChanged += new System.EventHandler(this.cboXSD_SelectedIndexChanged);
                this.txtVersion.TextChanged += new System.EventHandler(this.txtVersion_TextChanged);
                Cursor = Cursors.Default;
            }
        }

        private void ConnectionsLoad()
        {
            cboConnections.Items.Clear();
            string connNames = Settings.Get(IniSection.Connections, IniKey.Names);
            if (!String.IsNullOrEmpty(connNames))
            {
                string[] conns = connNames.Split(',');
                foreach (string conn in conns)
                {
                    cboConnections.Items.Add(conn);
                }
            }
        }

        private void tabControl_DrawItem(object sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush _textBrush;

            // Get the item from the collection.
            TabPage _tabPage = tabControl.TabPages[e.Index];

            // Get the real bounds for the tab rectangle.
            Rectangle _tabBounds = tabControl.GetTabRect(e.Index);

            if (e.State == DrawItemState.Selected)
            {
                _textBrush = SystemBrushes.ControlText;
                g.FillRectangle(SystemBrushes.Control, e.Bounds);

            }
            else
            {
                _textBrush = SystemBrushes.InactiveCaptionText;
                g.FillRectangle(SystemBrushes.InactiveCaption, e.Bounds);

            }

            Font _tabFont = new Font(new FontFamily(SystemFonts.MenuFont.Name), 16.0f, FontStyle.Regular, GraphicsUnit.Pixel);

            // Draw string. Center the text.
            StringFormat _stringFlags = new StringFormat();
            _stringFlags.Alignment = StringAlignment.Center;
            _stringFlags.LineAlignment = StringAlignment.Center;
            g.DrawString(_tabPage.Text, _tabFont, _textBrush, _tabBounds, new StringFormat(_stringFlags));
        }

        private void btnTransform_Click(object sender, EventArgs e)
        {
            string xmlFileName = "";
            string xmlData = "";
            string xslData = "";
            string working = "Working...";

            // Check each file to the right of the XML file.
            bool foundXML = false;
            bool foundXSLT = false;
            bool foundXForm = false;

            try
            {
                Cursor = Cursors.WaitCursor;
                // Get the current doctype
                LangType docType = LangType.L_TEXT;
                Win32.SendMessage(PluginBase.nppData._nppHandle, (uint)NppMsg.NPPM_GETCURRENTLANGTYPE, 0, ref docType);
                bool isDocTypeXML = docType == LangType.L_XML;

                // Return if doctype is not XML
                if (!isDocTypeXML)
                {
                    lblWarning.Text = "Please select an XML file to transform.";
                    Utils.TimerWarning(lblWarning);
                    return;
                }

                // Get XML text
                xmlFileName = notepad.GetCurrentFilePath();
                int chars = editor.GetTextLength();
                xmlData = editor.GetText(chars + 1);

                // **************************************************
                // Find the XSLT document
                // **************************************************
                // Count of opened files
                int fileCnt = (int)Win32.SendMessage(PluginBase.nppData._nppHandle, (uint)NppMsg.NPPM_GETNBOPENFILES, 0, 0);

                using (ClikeStringArray cStrArray = new ClikeStringArray(fileCnt, Win32.MAX_PATH))
                {
                    if (Win32.SendMessage(PluginBase.nppData._nppHandle, (uint)NppMsg.NPPM_GETNBOPENFILES, cStrArray.NativePointer, fileCnt) != IntPtr.Zero)
                        // Search for the XSLT file
                        foreach (string file in cStrArray.ManagedStringsUnicode)
                        {
                            if (foundXML)
                            {
                                // Check for an XML document
                                Win32.SendMessage(PluginBase.nppData._nppHandle, (uint)NppMsg.NPPM_SWITCHTOFILE, 0, file);
                                Win32.SendMessage(PluginBase.nppData._nppHandle, (uint)NppMsg.NPPM_GETCURRENTLANGTYPE, 0, ref docType);
                                isDocTypeXML = docType == LangType.L_XML;
                                if (isDocTypeXML && !foundXSLT)
                                {
                                    foundXSLT = true;
                                    chars = editor.GetTextLength();
                                    xslData = editor.GetText(chars + 1);
                                }
                                if (foundXSLT)
                                {
                                    if (file.ToLower().IndexOf(".xform") > 0)
                                    {
                                        Win32.SendMessage(PluginBase.nppData._nppHandle, (uint)NppMsg.NPPM_SWITCHTOFILE, 0, file);
                                        foundXForm = true;
                                        break;
                                    }
                                }
                            }
                            if (file == xmlFileName)
                            {
                                foundXML = true;
                            }
                        }
                    if (foundXML && foundXSLT)
                    {
                        if (!foundXForm)
                        {
                            notepad.FileNew();
                            Win32.SendMessage(PluginBase.nppData._nppHandle, (uint)NppMsg.NPPM_SAVECURRENTFILEAS, 0, Path.GetTempFileName() + ".xform");
                            foundXForm = true;
                        }
                        editor.SetText(working);
                        working = "";
                        Application.DoEvents();
                        var data = SaxonXForm.TransformXml(xmlData, xslData);
                        editor.SetText(data + Environment.NewLine);
                    }
                    else
                    {
                        MessageBox.Show("The XML and XSLT documents could not be identified.", "ERP Helper", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                string message = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                MessageBox.Show(message, "ERP Helper", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (foundXForm)
                {
                    if(working.Length == 0)
                    {
                        try
                        {
                            editor.SetText(working + Environment.NewLine);
                        }
                        catch
                        {
                            // ignore exception
                        }
                    }                        
                }
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void btnFolderSelect_Click(object sender, EventArgs e)
        {
            try
            {
                folderBrowserDialog1.SelectedPath = txtWDStudioFolder.Text;
                DialogResult result = folderBrowserDialog1.ShowDialog();
                Cursor = Cursors.WaitCursor;
                if (result == DialogResult.OK)
                {
                    txtWDStudioFolder.Text = folderBrowserDialog1.SelectedPath;
                    folderBrowserDialog1.Dispose();
                    Application.DoEvents();
                    Thread.Sleep(250);                    
                    Settings.Set(IniSection.WDStudio, IniKey.Workspace, txtWDStudioFolder.Text);
                    TreeViewUpdate(txtWDStudioFolder.Text, txtFilter.Text);
                }
                             
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            try
            {
                // Look for a file extension.
                if (e.Node.Text.Contains("."))
                {
                    Win32.SendMessage(PluginBase.nppData._nppHandle, (uint)NppMsg.NPPM_DOOPEN, 0, e.Node.Tag.ToString());
                }
            }
            // If the file is not found, handle the exception and inform the user.
            catch (System.ComponentModel.Win32Exception)
            {
                MessageBox.Show("File not found.", "WD Studio File", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                TreeViewUpdate(txtWDStudioFolder.Text, txtFilter.Text);
                Settings.Set(IniSection.WDStudio, IniKey.WorkspaceFilter, txtFilter.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred.", "File Filter", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void TreeViewUpdate(string dir, string filter)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                DirectoryInfo d = new DirectoryInfo(dir);
                if (d.Parent == null && MessageBox.Show("The root folder has been selected. " +
                    "This may take some time.\n\nContinue?", "Root Folder",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }
                treeView1.Update(dir, filter, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred.", "File List Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void tabControl_Selected(object sender, TabControlEventArgs e)
        {
            try
            {
                Settings.Set(IniSection.State, tabControl.Name, e.TabPage.Name);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred.", "Save State for Tabs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGenXML_Click(object sender, EventArgs e)
        {
            string xml;

            try
            {
                using (var webClient = new WebClient())
                {
                    xml = webClient.DownloadString(txtXSD.Text);
                }

                KeyValuePair<string, string> item = (KeyValuePair<string, string>)cboXSD.SelectedItem;

                string sample = WDXMLSample.Generate(xml, item.Key);

                if (sample.Length > 0)
                {
                    notepad.FileNew();
                    editor.SetText(sample + Environment.NewLine);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Generate XML Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboWWS1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboWWS1.SelectedIndex != ListBox.NoMatches)
            {
                try
                {
                    KeyValuePair<string, string> item = (KeyValuePair<string, string>)cboWWS1.SelectedItem;
                    Settings.Set(IniSection.State, cboWWS1.Name, item.Value);
                    txtXSD.Text = item.Key;
                    Settings.Set(IniSection.WDWebServices, IniKey.XSD, txtXSD.Text);
                    cboXSD_Load(txtXSD.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "WWS Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cboXSD_Load(string url)
        {
            string xml;
            XmlDocument xmlDoc = new XmlDocument();

            if (Uri.IsWellFormedUriString(url, UriKind.Absolute))
            {
                using (var webClient = new WebClient())
                {
                    xml = webClient.DownloadString(url);
                }
                xmlDoc.LoadXml(xml);
                XmlNamespaceManager ns = new XmlNamespaceManager(xmlDoc.NameTable);
                ns.AddNamespace("xsd", "http://www.w3.org/2001/XMLSchema");
                XmlNodeList nodes = xmlDoc.SelectNodes("xsd:schema/xsd:element", ns);

                Dictionary<string, string> items = new Dictionary<string, string>();

                foreach (XmlNode node in nodes)
                {
                    string key = node.Attributes["name"].Value;
                    string value = key;
                    items.Add(key, value);
                }
                cboXSD.DataSource = null;
                cboXSD.DataSource = new BindingSource(items, null);
                cboXSD.DisplayMember = "Value";
                cboXSD.ValueMember = "Key";
            }
        }

        private void btnCallAPI_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(lblPassword.Text))
                {
                    using (PasswordForm passwordForm = new PasswordForm())
                    {
                        if (passwordForm.ShowDialog() == DialogResult.OK)
                        {
                            lblPassword.Text = Crypto.Protect(passwordForm.Password);
                        }
                        else
                        {
                            return;
                        }
                    }
                }
                string tenant = txtTenant.Text;
                string username = txtUsername.Text + "@" + tenant;
                string password = Crypto.Unprotect(lblPassword.Text);
                string serviceURL = lnkApiUrl.Text;

                int chars = editor.GetTextLength();
                string xmlData = editor.GetText(chars + 1);

                try
                {
                    using (var webClient = new WebClient())
                    {
                        webClient.Headers.Add("Content-Type", "text/xml; charset=utf-8");
                        ServicePointManager.Expect100Continue = true;
                        ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                        ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };
                        webClient.Credentials = new NetworkCredential(username, password);
                        byte[] data = Encoding.UTF8.GetBytes(WDWebService.WrapSOAP(username, password, xmlData));
                        byte[] rData = webClient.UploadData(lnkApiUrl.Text, data);

                        notepad.FileNew();
                        editor.SetText(new XDeclaration("1.0", "UTF-8", null).ToString() + Environment.NewLine + XDocument.Parse(Encoding.UTF8.GetString(rData)).ToString() + Environment.NewLine);
                    }
                }
                catch (WebException webEx)
                {
                    String responseFromServer = webEx.Message.ToString() + " ";
                    if (webEx.Response != null)
                    {
                        using (WebResponse response = webEx.Response)
                        {
                            Stream dataRs = response.GetResponseStream();
                            using (StreamReader reader = new StreamReader(dataRs))
                            {
                                responseFromServer += reader.ReadToEnd();
                            }
                        }
                    }
                    MessageBox.Show(responseFromServer, "Web API Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch (Exception ex)
            {
                string message = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                MessageBox.Show(message, "Web API Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnGetSOAP_Click(object sender, EventArgs e)
        {
            try
            {
                int chars = editor.GetTextLength();
                string xmlData = editor.GetText(chars + 1);

                notepad.FileNew();
                editor.SetText(WDWebService.WrapSOAP("username", "password", xmlData) + Environment.NewLine);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "SOAP Generator", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConns_Click(object sender, EventArgs e)
        {
            using (Forms.WDConnForm frmConnection = new Forms.WDConnForm())
            {
                try
                {
                    if (cboConnections.SelectedIndex != ListBox.NoMatches)
                    {
                        frmConnection.SelectedConnection = cboConnections.SelectedItem.ToString();
                    }
                    frmConnection.ShowDialog(this);
                    ConnectionsLoad();
                    cboConnections.SelectedIndex = cboConnections.FindStringExact(frmConnection.SelectedConnection);
                    lblPassword.Text = frmConnection.Password;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Connections Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cboConnections_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboConnections.SelectedIndex != ListBox.NoMatches)
            {
                try
                {
                    string conn = cboConnections.SelectedItem.ToString();
                    string tenant = Settings.Get(IniSection.Connection, conn, IniKey.Tenant);
                    string service = cboWWS2.ReturnValue();
                    string version = Settings.Get(IniSection.WDWebServices, IniKey.Version);
                    txtTenant.Text = tenant;
                    txtUsername.Text = Settings.Get(IniSection.Connection, conn, IniKey.Username);
                    lblPassword.Text = Settings.Get(IniSection.Connection, conn, IniKey.Password);
                    lnkApiUrl.Text = WDWebService.BuildApiUrl(conn, service, version);
                    Settings.Set(IniSection.State, cboConnections.Name, conn);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error selecting a connection. " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void chkXSDLinkShow_CheckedChanged(object sender, EventArgs e)
        {
            txtXSD.Visible = chkXSDLinkShow.Checked;
        }

        private void txtVersion_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Settings.Set(IniSection.WDWebServices, IniKey.Version, txtVersion.Text);
                if (cboConnections.SelectedIndex != ListBox.NoMatches)
                {
                    string conn = cboConnections.SelectedItem.ToString();
                    string service = cboWWS2.ReturnValue();
                    lnkApiUrl.Text = WDWebService.BuildApiUrl(conn, service, txtVersion.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving version. " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboWWS2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboWWS2.SelectedIndex != ListBox.NoMatches && cboConnections.SelectedIndex != ListBox.NoMatches)
            {
                try
                {
                    KeyValuePair<string, string> item = (KeyValuePair<string, string>)cboWWS2.SelectedItem;
                    Settings.Set(IniSection.State, cboWWS2.Name, item.Value);
                    string conn = cboConnections.SelectedItem.ToString();
                    string service = item.Value;
                    lnkApiUrl.Text = WDWebService.BuildApiUrl(conn, service, txtVersion.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Web Service Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cboXSD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboXSD.SelectedIndex != ListBox.NoMatches)
            {
                try
                {
                    Settings.Set(IniSection.State, cboXSD.Name, ((KeyValuePair<string, string>)cboXSD.SelectedItem).Value);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error selecting an operation. " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void lnkURL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Clipboard.SetText(lnkApiUrl.Text);
                lnkApiUrl.LinkVisited = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving to clipboard. " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lnkWWS_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lnkWWS.LinkVisited = true;
            System.Diagnostics.Process.Start("https://community.workday.com/sites/default/files/file-hosting/productionapi/index.html");
        }

        private void lnkInstructions_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            toolTip1.SetToolTip(lnkXFormInst, Properties.Resources.Instructions_XForm);
        }

        private void lnkCallAPIInst_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            toolTip1.SetToolTip(lnkCallAPIInst, Properties.Resources.Instructions_CallAPI);
        }

        private void txtXSD_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab || e.KeyCode == Keys.Enter)
            {
                try
                {
                    Settings.Set(IniSection.WDWebServices, IniKey.XSD, txtXSD.Text);
                    cboXSD_Load(txtXSD.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving the XSD link. " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}