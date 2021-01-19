﻿using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Kbg.NppPluginNET.PluginInfrastructure;

namespace ERPHelper
{
    class Main
    {
        public static string PluginName = "ERP Helper";
        static WDMainForm WDMainForm = null;
        static AboutBox aboutBox = null;
        static int idWDForm = -1;
        static Icon tbIcon = Properties.Resources.ERPHelperIcon;

        public static void OnNotification(ScNotification notification)
        {
        }

        internal static void CommandMenuInit()
        {
            Settings.Init(PluginName.Replace(" ", ""));
            PluginBase.SetCommand(0, "Workday", WDMainFormShow);
            PluginBase.SetCommand(1, "About", AboutBoxShow, new ShortcutKey(false, false, false, Keys.None));

            idWDForm = 0;
        }

        internal static void SetToolBarIcon()
        {
        }

        internal static void PluginCleanUp()
        {
            Settings.Cleanup();
        }

        internal static void WDMainFormShow()
        {
            if (WDMainForm == null)
            {
                WDMainForm = new WDMainForm();

                NppTbData _nppTbData = new NppTbData();
                _nppTbData.hClient = WDMainForm.Handle;
                _nppTbData.pszName = "ERP Helper - Workday";
                _nppTbData.dlgID = idWDForm;
                _nppTbData.uMask = NppTbMsg.DWS_DF_CONT_RIGHT;
                 _nppTbData.pszModuleName = PluginName;
                IntPtr _ptrNppTbData = Marshal.AllocHGlobal(Marshal.SizeOf(_nppTbData));
                Marshal.StructureToPtr(_nppTbData, _ptrNppTbData, false);

                Win32.SendMessage(PluginBase.nppData._nppHandle, (uint)NppMsg.NPPM_DMMREGASDCKDLG, 0, _ptrNppTbData);
            }
            else
            {
                Win32.SendMessage(PluginBase.nppData._nppHandle, (uint)NppMsg.NPPM_DMMSHOW, 0, WDMainForm.Handle);
            }
        }

        internal static void AboutBoxShow()
        {
            aboutBox = new AboutBox();
            aboutBox.ShowDialog();
        }
    }
}