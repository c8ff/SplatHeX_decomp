using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace SplatHex;
[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.6.0.0")]
internal sealed class Settings : ApplicationSettingsBase {
    private static Settings defaultInstance;
    public static Settings Default => defaultInstance;

    [UserScopedSetting]
    [DebuggerNonUserCode]
    [DefaultSettingValue("True")]
    public bool LegalCheck {
        get {
            return (bool)this["LegalCheck"];
        }

        set {
            this["LegalCheck"] = value;
        }
    }

    [UserScopedSetting]
    [DefaultSettingValue("192.168.147.10")]
    [DebuggerNonUserCode]
    public string WiiUIP {
        get {
            return (string)this["WiiUIP"];
        }

        set {
            this["WiiUIP"] = value;
        }
    }

    [DefaultSettingValue("False")]
    [DebuggerNonUserCode]
    [UserScopedSetting]
    public bool FlagMessage1 {
        get {
            return (bool)this["FlagMessage1"];
        }

        set {
            this["FlagMessage1"] = value;
        }
    }

    [DefaultSettingValue("False")]
    [UserScopedSetting]
    [DebuggerNonUserCode]
    public bool FlagMessage2 {
        get {
            return (bool)this["FlagMessage2"];
        }

        set {
            this["FlagMessage2"] = value;
        }
    }

    static Settings() {
        defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());
    }

    internal static bool hZ7() {
        return true;
    }

    internal static bool hZQ() {
        return false;
    }
}