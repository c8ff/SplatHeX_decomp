using System.Runtime.CompilerServices;

namespace SplatHex;
public class Class76 {
    private mOr bDPd;
    private byte iDPH;
    private uint cDP4;
    private uint GDP5;
    [SpecialName]
    public mOr method_0() {
        return bDPd;
    }

    [SpecialName]
    public byte method_1() {
        return iDPH;
    }

    [SpecialName]
    public uint method_2() {
        return cDP4;
    }

    [SpecialName]
    public uint method_3() {
        return GDP5;
    }

    public Class76(mOr mOr_0, byte byte_0, uint uint_0, uint uint_1) {
        iDPH = byte_0;
        bDPd = mOr_0;
        cDP4 = uint_0;
        GDP5 = uint_1;
    }

    public Class76(mOr mOr_0, uint uint_0, uint uint_1) : this(mOr_0, (byte)(uint_0 >> (int)Class13.SD2H), uint_0, uint_1) {
    }

    internal static bool i8q() {
        return true;
    }

    internal static bool X8I() {
        return false;
    }
}