namespace SplatHex;
public class Class40 {
    private static readonly int ADqu;
    private static readonly int yDqg;
    private static readonly int rDq2;
    private static readonly int YDq3;
    private static readonly int hDqd;
    private static readonly int JDqH;
    private static readonly int dDq4;
    private static readonly int TDq5;
    private static readonly int TDqs;
    private readonly uint yDqZ;
    private readonly byte[] VDqa;
    public readonly int WDqj;
    public Class40(byte[] byte_0, uint uint_0, int int_0) {
        VDqa = byte_0;
        WDqj = int_0;
        yDqZ = uint_0;
    }

    public int gDqN() {
        return MDqk(ADqu);
    }

    public int[] aDqY() {
        return new int[3]
        {
            MDqk(YDq3),
            MDqk(hDqd),
            MDqk(JDqH)
        };
    }

    public int bDqB() {
        return MDqk(yDqg);
    }

    public int vDqA() {
        return MDqk(rDq2);
    }

    public int XDqf() {
        return MDqk(dDq4);
    }

    public int hDq6() {
        return MDqk(TDq5);
    }

    public bool LDqx() {
        return MDqk(TDqs) == 0;
    }

    public void DDq9(int[] int_0) {
        VDqa[YDq3 + 3] = (byte)int_0[0];
        VDqa[hDqd + 3] = (byte)int_0[1];
        VDqa[JDqH + 3] = (byte)int_0[2];
    }

    public void wDqc(int int_0) {
        if (int_0 > 0 && int_0 <= 4 && int_0 <= vDqA()) {
            if (int_0 == vDqA()) {
                VDqr(0);
            }

            VDqa[yDqg + 3] = (byte)int_0;
        }
    }

    public void ODqy(int int_0) {
        if (int_0 > 0 && int_0 <= 4) {
            VDqa[rDq2 + 3] = (byte)int_0;
            if (bDqB() > vDqA()) {
                wDqc(vDqA());
            }
        }
    }

    public void VDqr(int int_0) {
        MDqk(dDq4);
    }

    public void sDqq(bool bool_0) {
        if (bool_0) {
            VDqa[TDqs + 1] = 1;
        } else {
            VDqa[TDqs + 1] = 0;
        }
    }

    private int MDqk(int int_0) {
        return (VDqa[int_0] << (int)Class13.Epjn) | (VDqa[int_0 + 1] << (int)Class13.OpjQ) | (VDqa[int_0 + 2] << 8) | VDqa[int_0 + 3];
    }

    public void PDqM(Class128 mbz_0) {
        mbz_0.hDPD(yDqZ, VDqa);
    }

    static Class40() {
        ADqu = 0;
        yDqg = ADqu + 4;
        rDq2 = yDqg + 4;
        YDq3 = rDq2 + 4;
        hDqd = YDq3 + 4;
        JDqH = hDqd + 4;
        dDq4 = JDqH + 4;
        TDq5 = dDq4 + Class13.OpjF;
        TDqs = TDq5 + 4;
    }
}