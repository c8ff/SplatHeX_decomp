namespace SplatHex;
public static class Class103 {
    public static bool KDiX;
    public static readonly Class76[] cDip;
    public static mOr PDPs(uint uint_0) {
        //IL_000d: Expected O, but got I4
        int num = rDPZ(uint_0);
        if (num == -1) {
            return (mOr)4;
        }

        return cDip[num].method_0();
    }

    public static int rDPZ(uint uint_0) {
        int num = 0;
        while (true) {
            if (num < cDip.Length) {
                Class76 vOB = cDip[num];
                if (uint_0 >= vOB.method_2() && uint_0 < vOB.method_3()) {
                    break;
                }

                num++;
                continue;
            }

            return -1;
        }

        return num;
    }

    public static bool EDPa(uint uint_0, bool bool_0) {
        if (bool_0) {
            return true;
        }

        return rDPZ(uint_0) >= 0;
    }

    public static bool xDPj(uint uint_0) {
        return EDPa(uint_0, KDiX);
    }

    public static bool SDPz(uint uint_0, uint uint_1, bool bool_0) {
        if (bool_0) {
            return true;
        }

        return rDPZ(uint_0) == rDPZ(uint_1 - 1);
    }

    public static bool eDiE(uint uint_0, uint uint_1) {
        return SDPz(uint_0, uint_1, KDiX);
    }

    public static void oDiD(Class128 mbz_0) {
        //IL_00af: Expected O, but got I4
        //IL_00c3: Expected O, but got I4
        //IL_00d7: Expected O, but got I4
        uint num = mbz_0.qD75();
        if (num <= (uint)Class13.SD24) {
            if (num == (uint)Class13.aD25 || num == (uint)Class13.FD2s) {
                uint num2 = mbz_0.HD7d((uint)Class13.fD2j);
                uint num3 = mbz_0.HD7d(num2 + 4);
                uint num4 = mbz_0.HD7d(num3 + (uint)Class13.rD2z);
                uint num5 = mbz_0.HD7d(num4);
                uint num6 = mbz_0.HD7d(num4 + 4);
                uint num7 = mbz_0.HD7d(num4 + (uint)Class13.ED3E);
                uint num8 = mbz_0.HD7d(num4 + 4 + (uint)Class13.DD3D);
                uint num9 = mbz_0.HD7d(num4 + (uint)Class13.qD3X);
                uint num10 = mbz_0.HD7d(num4 + 4 + (uint)Class13.TD3p);
                cDip[0] = new Class76((mOr)2, num5, num5 + num6);
                cDip[1] = new Class76((mOr)2, num7, num7 + num8);
                cDip[2] = new Class76((mOr)0, num9, num9 + num10);
            }
        } else if (num == (uint)Class13.nD2Z) {
        }
    }

    static Class103() {
        //IL_0023: Expected O, but got I4
        //IL_0036: Expected O, but got I4
        //IL_0049: Expected O, but got I4
        //IL_005c: Expected O, but got I4
        //IL_006f: Expected O, but got I4
        //IL_0082: Expected O, but got I4
        //IL_0095: Expected O, but got I4
        //IL_00a8: Expected O, but got I4
        //IL_00bb: Expected O, but got I4
        //IL_00ce: Expected O, but got I4
        KDiX = false;
        Class76[] array = new Class76[Class13.eD3S];
        array[0] = new Class76((mOr)2, (uint)Class13.lD3h, (uint)Class13.ND3l);
        array[1] = new Class76((mOr)2, (uint)Class13.dD3G, (uint)Class13.bD3b);
        array[2] = new Class76((mOr)0, (uint)Class13.ID3v, (uint)Class13.BD3o);
        array[3] = new Class76((mOr)1, (uint)Class13.sD3t, (uint)Class13.ED3V);
        array[4] = new Class76((mOr)1, (uint)Class13.QD3O, (uint)Class13.cD3e);
        array[5] = new Class76((mOr)1, (uint)Class13.PD38, (uint)Class13.LD3n);
        array[6] = new Class76((mOr)1, (uint)Class13.BD3Q, (uint)Class13.ED3F);
        array[7] = new Class76((mOr)1, (uint)Class13.fD3L, (uint)Class13.VD3J);
        array[8] = new Class76((mOr)1, (uint)Class13.FD37, (uint)Class13.qD3P);
        array[Class13.bD3i] = new Class76((mOr)0, (uint)Class13.SD3m, uint.MaxValue);
        cDip = array;
    }
}