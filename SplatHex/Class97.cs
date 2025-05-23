using System;
using System.Collections.Generic;

namespace SplatHex;
internal static class Class97 {
    public static void UXT() {
        Class108.YoH = new Class108.fr2[Class32.SVf];
        for (int i = 0; i < Class108.YoH.Length; i++) {
            Class108.YoH[i] = new Class108.fr2(((IEnumerable<byte>)Class108.io2.ztX).Skip(Class32.YVR + i * Class32.uVB).Take(Class32.uVB).ToArray());
            if (Class117.toq.ContainsKey(Class108.YoH[i].hXP)) {
                Class108.YoH[i].HXm = Class117.toq[Class108.YoH[i].hXP].YDA;
            }
        }
    }

    public static void DX1() {
        Class108.Yod = new Class108.fr2[Class32.SVf];
        for (int i = 0; i < Class108.Yod.Length; i++) {
            Class108.Yod[i] = new Class108.fr2(((IEnumerable<byte>)Class108.io2.ztX).Skip(Class32.nVC + i * Class32.uVB).Take(Class32.uVB).ToArray());
            if (Class117.toq.ContainsKey(Class108.Yod[i].hXP)) {
                Class108.Yod[i].HXm = Class117.qor[Class108.Yod[i].hXP].YDA;
            }
        }
    }

    public static void VXW() {
        Class108.Jo3 = new Class108.fr2[Class32.SVf];
        for (int i = 0; i < Class108.Jo3.Length; i++) {
            Class108.Jo3[i] = new Class108.fr2(((IEnumerable<byte>)Class108.io2.ztX).Skip(Class32.fVK + i * Class32.uVB).Take(Class32.uVB).ToArray());
            if (Class117.toq.ContainsKey(Class108.Jo3[i].hXP)) {
                Class108.Jo3[i].HXm = Class117.eoy[Class108.Jo3[i].hXP].YDA;
            }
        }
    }

    public static void FXw() {
        for (int i = 0; i < Class108.YoH.Length; i++) {
            Array.Copy(Class108.YoH[i].Write(), 0, (Array)Class108.io2.ztX, Class32.YVR + i * Class32.uVB, Class32.uVB);
        }
    }

    public static void OXN() {
        for (int i = 0; i < Class108.Yod.Length; i++) {
            Array.Copy(Class108.Yod[i].Write(), 0, (Array)Class108.io2.ztX, Class32.nVC + i * Class32.uVB, Class32.uVB);
        }
    }

    public static void qXY() {
        for (int i = 0; i < Class108.Jo3.Length; i++) {
            Array.Copy(Class108.Jo3[i].Write(), 0, (Array)Class108.io2.ztX, Class32.fVK + i * Class32.uVB, Class32.uVB);
        }
    }

    public static void AXB() {
        Class108.Vo4 = new Class108.UrT[Class32.jV6];
        for (int i = 0; i < Class108.Vo4.Length; i++) {
            Class108.Vo4[i] = new Class108.UrT(((IEnumerable<byte>)Class108.io2.ztX).Skip(Class32.jVU + i * Class32.TVA).Take(Class32.TVA).ToArray());
        }
    }

    public static void UXA() {
        for (int i = 0; i < Class108.Vo4.Length; i++) {
            Array.Copy(Class108.Vo4[i].Gtf(), 0, (Array)Class108.io2.ztX, Class32.jVU + i * Class32.TVA, Class32.TVA);
        }
    }

    public static void OXf() {
        Class108.bo5 = new Class108.Trf[20];
        for (int i = 0; i < Class108.bo5.Length; i++) {
            Class108.bo5[i] = new Class108.Trf(((IEnumerable<byte>)Class108.io2.ztX).Skip(Class32.YVT + i * 4).Take(4).ToArray());
        }

        Class108.kos = new Class108.Trf[20];
        for (int j = 0; j < Class108.kos.Length; j++) {
            Class108.kos[j] = new Class108.Trf(((IEnumerable<byte>)Class108.io2.ztX).Skip(Class32.OV1 + j * 4).Take(4).ToArray());
        }

        Class108.yoZ = new Class108.Trf[20];
        for (int k = 0; k < Class108.yoZ.Length; k++) {
            Class108.yoZ[k] = new Class108.Trf(((IEnumerable<byte>)Class108.io2.ztX).Skip(Class32.MVW + k * 4).Take(4).ToArray());
        }
    }

    public static void VX6() {
        for (int i = 0; i < Class108.bo5.Length; i++) {
            Array.Copy(Class108.bo5[i].AtM(), 0, (Array)Class108.io2.ztX, Class32.YVT + i * 4, 4);
        }

        for (int j = 0; j < Class108.kos.Length; j++) {
            Array.Copy(Class108.kos[j].AtM(), 0, (Array)Class108.io2.ztX, Class32.OV1 + j * 4, 4);
        }

        for (int k = 0; k < Class108.yoZ.Length; k++) {
            Array.Copy(Class108.yoZ[k].AtM(), 0, (Array)Class108.io2.ztX, Class32.MVW + k * 4, 4);
        }
    }

    public static void UXx() {
        Class108.Foa = new Class108.irN[Class32.IV9];
        for (int i = 0; i < Class108.Foa.Length; i++) {
            Class108.Foa[i] = new Class108.irN(((IEnumerable<byte>)Class108.io2.ztX).Skip(Class32.xVw + i * Class32.vVx).Take(Class32.vVx).ToArray());
        }
    }

    public static void cX9() {
        for (int i = 0; i < Class108.Foa.Length; i++) {
            Array.Copy(Class108.Foa[i].It2(), 0, (Array)Class108.io2.ztX, Class32.xVw + i * Class32.vVx, Class32.vVx);
        }
    }

    public static void lXc() {
        Class108.Voj = new Class108.Uru[Class32.cVy];
        for (int i = 0; i < Class108.Voj.Length; i++) {
            Class108.Voj[i] = new Class108.Uru(((IEnumerable<byte>)Class108.io2.ztX).Skip(Class32.LVN + i * Class32.AVc).Take(Class32.AVc).ToArray());
        }
    }

    public static void lXy() {
        for (int i = 0; i < Class108.Voj.Length; i++) {
            Array.Copy(Class108.Voj[i].wVl(), 0, (Array)Class108.io2.ztX, Class32.LVN + i * Class32.AVc, Class32.AVc);
        }
    }

    public static void iXr() {
        Class108.Ioz = new Class108.Fra[Class32.gVq];
        for (int i = 0; i < Class108.Ioz.Length; i++) {
            Class108.Ioz[i] = new Class108.Fra(((IEnumerable<byte>)Class108.io2.ztX).Skip(Class32.QVY + i * Class32.KVr).Take(Class32.KVr).ToArray());
        }
    }

    public static void qXq() {
        for (int i = 0; i < Class108.Ioz.Length; i++) {
            Array.Copy(Class108.Ioz[i].qVF(), 0, (Array)Class108.io2.ztX, Class32.QVY + i * Class32.KVr, Class32.KVr);
        }
    }

    public static void pXk() {
        UXT();
        DX1();
        VXW();
        AXB();
        iXr();
        OXf();
        lXc();
        UXx();
    }

    public static void GXM() {
        Class4.DD5(Class108.Jo3);
        Class4.DD5(Class108.Yod);
        Class4.DD5(Class108.YoH);
        Class22.nXF();
        FXw();
        OXN();
        qXY();
        UXA();
        qXq();
        VX6();
        lXy();
        cX9();
    }
}