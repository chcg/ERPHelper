﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ERPHelper.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("ERPHelper.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap CloudDownload_16x {
            get {
                object obj = ResourceManager.GetObject("CloudDownload_16x", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Icon similar to (Icon).
        /// </summary>
        internal static System.Drawing.Icon ERPHelperIcon {
            get {
                object obj = ResourceManager.GetObject("ERPHelperIcon", resourceCulture);
                return ((System.Drawing.Icon)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap Filter_16x {
            get {
                object obj = ResourceManager.GetObject("Filter_16x", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Call API
        ///Calls the Workday API using the current document.  
        ///A SOAP envelope and body will be automatically wrapped around the request.  
        ///If an envelope already exists, the wrapper will not be generated.
        ///
        ///Get SOAP Wrapper
        ///Generates a SOAP envelope and body for the current document and creates a new document.
        ///This feature will create a sample SOAP envelope, 
        ///but it is not required for the &apos;Call API&apos; feature..
        /// </summary>
        internal static string Instructions_CallAPI {
            get {
                return ResourceManager.GetString("Instructions.CallAPI", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Click to copy to clipboard.
        /// </summary>
        internal static string Instructions_Click2Copy2Clipboard {
            get {
                return ResourceManager.GetString("Instructions.Click2Copy2Clipboard", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Use the &apos;Save Password&apos; checkbox to save the encrypted
        ///password in the configuration file for this plugin. 
        ///The decryption method is restricted to your account on
        ///this machine.  
        ///The password will not be saved if the &apos;Save Password&apos;
        ///checkbox is not checked..
        /// </summary>
        internal static string Instructions_SavePassword {
            get {
                return ResourceManager.GetString("Instructions.SavePassword", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 1. Open the XML and XSLT documents.
        ///2. Position the tabs as shown (XML, XSLT).
        ///3. Select the XML document tab.
        ///4. Click the &apos;Transform&apos; button.
        ///
        ///- Tab order is important.
        ///- Tab names are not considered..
        /// </summary>
        internal static string Instructions_XForm {
            get {
                return ResourceManager.GetString("Instructions.XForm", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap Save_16x {
            get {
                object obj = ResourceManager.GetObject("Save_16x", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap star {
            get {
                object obj = ResourceManager.GetObject("star", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap star_bmp {
            get {
                object obj = ResourceManager.GetObject("star_bmp", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot;?&gt;
        ///&lt;envs&gt;
        ///  &lt;env name=&quot;Production (Ashburn)&quot; type=&quot;prod&quot;&gt;
        ///    &lt;e2-endpoint&gt;e2-enterprise-services1.myworkday.com&lt;/e2-endpoint&gt;
        ///    &lt;app-endpoint&gt;&lt;/app-endpoint&gt;
        ///  &lt;/env&gt;
        ///  &lt;env name=&quot;Production (Portland)&quot; type=&quot;prod&quot;&gt;
        ///    &lt;e2-endpoint&gt;wd5-e2.myworkday.com&lt;/e2-endpoint&gt;
        ///    &lt;app-endpoint&gt;&lt;/app-endpoint&gt;
        ///  &lt;/env&gt;
        ///  &lt;env name=&quot;Production (WD3)&quot; type=&quot;prod&quot;&gt;
        ///    &lt;e2-endpoint&gt;wd3-e2.myworkday.com&lt;/e2-endpoint&gt;
        ///    &lt;app-endpoint&gt;&lt;/app-endpoint&gt;
        ///  &lt;/env&gt;
        ///  &lt;env name=&quot;Production (W [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string WDEnvironments {
            get {
                return ResourceManager.GetString("WDEnvironments", resourceCulture);
            }
        }
    }
}
