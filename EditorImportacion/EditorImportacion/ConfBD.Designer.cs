﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EditorImportacion {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0")]
    internal sealed partial class ConfBD : global::System.Configuration.ApplicationSettingsBase {
        
        private static ConfBD defaultInstance = ((ConfBD)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new ConfBD())));
        
        public static ConfBD Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("prog")]
        public string Usuario {
            get {
                return ((string)(this["Usuario"]));
            }
            set {
                this["Usuario"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("prog")]
        public string Contraseña {
            get {
                return ((string)(this["Contraseña"]));
            }
            set {
                this["Contraseña"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("vdes-neo\\sql2012_lg")]
        public string Instancia {
            get {
                return ((string)(this["Instancia"]));
            }
            set {
                this["Instancia"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("UnoEE")]
        public string BaseDeDatos {
            get {
                return ((string)(this["BaseDeDatos"]));
            }
            set {
                this["BaseDeDatos"] = value;
            }
        }
    }
}