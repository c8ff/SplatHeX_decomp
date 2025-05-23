using System.Text;

namespace SplatHex;
public class Class29 : H7m {
    private uint fD8H;
    public uint ED84;
    public string cD85;
    public uint vD8s;
    public object dD8Z;
    public byte[] Value {
        get {
            return ((H7m)dD8Z).Value;
        }

        set {
            ((H7m)dD8Z).Value = value;
        }
    }

    public uint Index {
        get {
            return fD8H;
        }

        set {
            fD8H = value;
        }
    }

    public override string ToString() {
        if (ED84 == 0) {
            return (fD8H + 1).ToString();
        }

        return cD85;
    }

    public string ToString(Encoding encoding_0) {
        if (ED84 == 0) {
            return (fD8H + 1).ToString();
        }

        return cD85;
    }

    internal static bool avT() {
        return true;
    }

    internal static bool Kv4() {
        return false;
    }
}