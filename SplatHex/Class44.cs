using System.Text;

namespace SplatHex;
public class Class44 : H7m {
    private byte[] cDnh;
    private uint IDnl;
    public byte[] Value {
        get {
            return cDnh;
        }

        set {
            cDnh = value;
        }
    }

    public uint Index {
        get {
            return IDnl;
        }

        set {
            IDnl = value;
        }
    }

    public override string ToString() {
        return (IDnl + 1).ToString();
    }

    public string ToString(Encoding encoding_0) {
        return encoding_0.GetString(cDnh);
    }

    internal static bool Nvt() {
        return true;
    }

    internal static bool wvD() {
        return false;
    }
}