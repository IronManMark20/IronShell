﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MerulaShellUi.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("#FFFFFFFF")]
        public global::System.Windows.Media.Color UIColor {
            get {
                return ((global::System.Windows.Media.Color)(this["UIColor"]));
            }
            set {
                this["UIColor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("#FF000000")]
        public global::System.Windows.Media.Color UIColorFore {
            get {
                return ((global::System.Windows.Media.Color)(this["UIColorFore"]));
            }
            set {
                this["UIColorFore"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool TaskbarAlwaysVisible {
            get {
                return ((bool)(this["TaskbarAlwaysVisible"]));
            }
            set {
                this["TaskbarAlwaysVisible"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("40")]
        public int TaskbarHeight {
            get {
                return ((int)(this["TaskbarHeight"]));
            }
            set {
                this["TaskbarHeight"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("250")]
        public int Glass {
            get {
                return ((int)(this["Glass"]));
            }
            set {
                this["Glass"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("pack://application:,,,/MerulaShellUi;component/images/merulashell.png")]
        public string DesktopImage {
            get {
                return ((string)(this["DesktopImage"]));
            }
            set {
                this["DesktopImage"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::System.Collections.Specialized.ListDictionary Tiles {
            get {
                return ((global::System.Collections.Specialized.ListDictionary)(this["Tiles"]));
            }
            set {
                this["Tiles"] = value;
            }
        }
    }
}
