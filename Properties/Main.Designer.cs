﻿//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン:4.0.30319.1
//
//     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
//     コードが再生成されるときに損失したりします。
// </auto-generated>
//------------------------------------------------------------------------------

namespace mitto.DisplayPowerOff.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
    internal sealed partial class Main : global::System.Configuration.ApplicationSettingsBase {
        
        private static Main defaultInstance = ((Main)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Main())));
        
        public static Main Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("5")]
        public int countdownTime {
            get {
                return ((int)(this["countdownTime"]));
            }
            set {
                this["countdownTime"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("300, 300")]
        public global::System.Drawing.Size formSize {
            get {
                return ((global::System.Drawing.Size)(this["formSize"]));
            }
            set {
                this["formSize"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool isTopMost {
            get {
                return ((bool)(this["isTopMost"]));
            }
            set {
                this["isTopMost"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool isButtonOnly {
            get {
                return ((bool)(this["isButtonOnly"]));
            }
            set {
                this["isButtonOnly"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool isCountdownTopMost {
            get {
                return ((bool)(this["isCountdownTopMost"]));
            }
            set {
                this["isCountdownTopMost"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool isForceRun {
            get {
                return ((bool)(this["isForceRun"]));
            }
            set {
                this["isForceRun"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool isShowInTaskbar {
            get {
                return ((bool)(this["isShowInTaskbar"]));
            }
            set {
                this["isShowInTaskbar"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool isSaveWindowPosition {
            get {
                return ((bool)(this["isSaveWindowPosition"]));
            }
            set {
                this["isSaveWindowPosition"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("100, 100")]
        public global::System.Drawing.Point WindowPosition {
            get {
                return ((global::System.Drawing.Point)(this["WindowPosition"]));
            }
            set {
                this["WindowPosition"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Georgia, 14.25pt, style=Bold")]
        public global::System.Drawing.Font buttonFont {
            get {
                return ((global::System.Drawing.Font)(this["buttonFont"]));
            }
            set {
                this["buttonFont"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool isGlobalHotKeyEnabled {
            get {
                return ((bool)(this["isGlobalHotKeyEnabled"]));
            }
            set {
                this["isGlobalHotKeyEnabled"] = value;
            }
        }
    }
}
