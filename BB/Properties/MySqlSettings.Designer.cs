﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.9164
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BB.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "9.0.0.0")]
    internal sealed partial class MySqlSettings : global::System.Configuration.ApplicationSettingsBase {
        
        private static MySqlSettings defaultInstance = ((MySqlSettings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new MySqlSettings())));
        
        public static MySqlSettings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("[BB].[dbo].[BBCallDetails]")]
        public string BBCallDetails {
            get {
                return ((string)(this["BBCallDetails"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=Serveraddress;Initial Catalog=BB;User ID=userid;Password=password")]
        public string SQLCONN {
            get {
                return ((string)(this["SQLCONN"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("[BB].[dbo].[BBComponent]")]
        public string BB_Component {
            get {
                return ((string)(this["BB_Component"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("[BB].[dbo].[PatientDetails Master]")]
        public string Patient_Master {
            get {
                return ((string)(this["Patient_Master"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("[BB].[dbo].[ComponentsDetails]")]
        public string Component_Details {
            get {
                return ((string)(this["Component_Details"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("[BB].[dbo].[BagIssueHeader]")]
        public string BagIssue_Header {
            get {
                return ((string)(this["BagIssue_Header"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("[BB].[dbo].[BagIssueDetails]")]
        public string BagIssue_Details {
            get {
                return ((string)(this["BagIssue_Details"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("[BB].[dbo].[StaffLogin]")]
        public string Staff_Login {
            get {
                return ((string)(this["Staff_Login"]));
            }
        }
    }
}