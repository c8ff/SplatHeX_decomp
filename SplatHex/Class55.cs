namespace SplatHex;
public class Class55 {
    private static readonly int eDMt;
    private static readonly int EDMV;
    private static readonly int qDMO;
    private static readonly int mDMe;
    private static readonly int WDM8;
    private static readonly int UDMn;
    private static readonly int TDMQ;
    private readonly uint oDMF;
    private readonly byte[] JDML;
    public Class55(byte[] byte_0, uint uint_0) {
        JDML = byte_0;
        oDMF = uint_0;
    }

    public int zDMD() {
        return xDMv(EDMV);
    }

    public int ADMX() {
        return xDMv(qDMO);
    }

    public int DDMp() {
        return xDMv(mDMe);
    }

    public int JDMS() {
        return xDMv(WDM8);
    }

    public int eDMh() {
        return xDMv(UDMn);
    }

    public bool wDMl() {
        return xDMv(TDMQ) == 0;
    }

    public void yDMG(int int_0) {
        if (int_0 >= 0 && int_0 <= Class13.eSDo) {
            int num = int_0;
            for (int num2 = 3; num2 >= 0; num2--) {
                JDML[WDM8 + num2] = (byte)(num & Class13.HSDt);
                num >>= 8;
            }
        }
    }

    public void fDMb(bool bool_0) {
        if (bool_0) {
            JDML[TDMQ + 1] = 1;
        } else {
            JDML[TDMQ + 1] = 0;
        }
    }

    private int xDMv(int int_0) {
        return (JDML[int_0] << (int)Class13.WSDV) | (JDML[int_0 + 1] << (int)Class13.gSDO) | (JDML[int_0 + 2] << 8) | JDML[int_0 + 3];
    }

    public void VDMo(Class128 mbz_0) {
        mbz_0.hDPD(oDMF, JDML);
    }

    static Class55() {
        eDMt = 0;
        EDMV = eDMt + 4;
        qDMO = EDMV + 4;
        mDMe = qDMO + 4;
        WDM8 = mDMe + 4;
        UDMn = WDM8 + Class13.xSDe;
        TDMQ = UDMn + 4;
    }
}