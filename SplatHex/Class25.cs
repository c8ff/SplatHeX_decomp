using System.Drawing;

namespace SplatHex;
public abstract class Class25 {
    public readonly int CDw;
    public readonly int YDN;
    public readonly string rDY;
    public readonly object eDB;
    public readonly int YDA;
    public readonly Class83 sDf;
    public readonly int tD6;
    public readonly bool kDx;
    public readonly int WD9;
    public Class25(int int_0, int int_1, string string_0, Bitmap bitmap_0, int int_2, Class83 tn_0, int int_3, int int_4 = 0, bool bool_0 = false) {
        CDw = int_0;
        YDN = int_1;
        rDY = string_0;
        eDB = bitmap_0;
        YDA = int_2;
        sDf = tn_0;
        tD6 = int_3;
        kDx = bool_0;
        WD9 = int_4;
    }

    public abstract bool AjTy();
    public abstract bool wjTh();
    public abstract bool CjTP();
    public abstract int VjTo(int int_0);
    public abstract int tjTc(int int_0);
    public abstract int YjT9(int int_0);
    public abstract int bjTe(int int_0);
    public abstract bool mjTM(int int_0);
    internal static bool bi() {
        return false;
    }
}