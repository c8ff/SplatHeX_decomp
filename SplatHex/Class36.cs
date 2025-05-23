using System;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace SplatHex;
public class Class36 {
    [Serializable]
    [CompilerGenerated]
    private sealed class Class0 {
        public static readonly Class0 class0_0;
        public static Func<char, bool> func_0;
        static Class0() {
            class0_0 = new Class0();
        }

        internal bool method_0(char char_0) {
            return char_0 == Class13.IDMu;
        }

        internal static bool HU5() {
            return true;
        }

        internal static bool dUi() {
            return false;
        }
    }

    private uint fDQb;
    private int[] wDQv;
    private uint zDQo;
    public string BDQt;
    public static int ADQV;
    public Class36(uint uint_0, int[] int_0) {
        fDQb = uint_0;
        wDQv = int_0;
    }

    public Class36(string string_0) {
        BDQt = string_0;
        string_0 = string_0.Replace(Class13.GDM1, Class13.wDMW);
        int num = string_0.Count((char char_0) => char_0 == Class13.IDMu);
        if (num == 0) {
            if (string_0.StartsWith(Class13.cDMw)) {
                string_0 = string_0.Substring(2);
            }

            fDQb = uint.Parse(string_0, (NumberStyles)Class13.nDMN);
            wDQv = new int[0];
            return;
        }

        wDQv = new int[num];
        int num2 = string_0.LastIndexOf(Class13.wDMY);
        int num3 = string_0.IndexOf(Class13.wDMB);
        string text = string_0.Substring(num2 + 1, num3 - num2 - 1);
        if (text.StartsWith(Class13.EDMA)) {
            text = text.Substring(2);
        }

        fDQb = uint.Parse(text, (NumberStyles)Class13.NDMf);
        string_0 = string_0.Substring(num3 + 1);
        for (int num4 = 0; num4 < num; num4++) {
            int num5 = string_0.IndexOf(Class13.oDM6);
            string text2;
            if (num5 == -1) {
                int num6 = string_0.IndexOf(Class13.KDMx);
                if (num6 != -1) {
                    text2 = string_0.Substring(0, num6);
                    string_0 = string_0.Substring(num6);
                } else {
                    text2 = string_0;
                }
            } else {
                text2 = string_0.Substring(0, num5);
            }

            bool num7 = text2[0] == Class13.sDM9;
            text2 = text2.Substring(1);
            if (text2.StartsWith(Class13.sDMc)) {
                text2 = text2.Substring(2);
            }

            int num8 = Class70.DDnZ(text2);
            if (num7) {
                num8 *= -1;
            }

            wDQv[num4] = num8;
            if (string_0.StartsWith(Class13.dDMy)) {
                string_0 = string_0.Substring(1);
                if (string_0.StartsWith(Class13.bDMr)) {
                    string_0 = string_0.Substring(2);
                }

                zDQo = uint.Parse(string_0, (NumberStyles)Class13.RDMq);
            }

            string_0 = string_0.Substring(num5 + 1);
        }
    }

    public override string ToString() {
        return BDQt;
    }

    public uint GDQS() {
        return fDQb;
    }

    public uint nDQh() {
        return zDQo;
    }

    public int[] EDQl() {
        return wDQv;
    }

    public uint cDQG(Class128 mbz_0) {
        uint num = fDQb;
        int[] array = wDQv;
        foreach (int num2 in array) {
            if (num >= (uint)Class13.wDMk && num <= (uint)Class13.hDMM) {
                num = mbz_0.cjJt(num);
                num = ((num2 < 0) ? (num - (uint)(-num2)) : (num + (uint)num2));
            }
        }

        return num;
    }

    static Class36() {
        ADQV = -1;
    }
}