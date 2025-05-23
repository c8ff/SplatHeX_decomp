using System;
using System.Collections.Generic;

namespace SplatHex;
internal static class Class21 {
    public static void blp() {
        Class26.pX3 = new Class26.P4[512];
        for (int i = 0; i < Class26.pX3.Length; i++) {
            Class26.pX3[i] = new Class26.P4(((IEnumerable<byte>)Class26.QXu.dpX).Skip(77896 + i * 48).Take(48).ToArray());
        }
    }

    public static void wlS() {
        Class26.rX2 = new Class26.P4[512];
        for (int i = 0; i < Class26.rX2.Length; i++) {
            Class26.rX2[i] = new Class26.P4(((IEnumerable<byte>)Class26.QXu.dpX).Skip(102472 + i * 48).Take(48).ToArray());
        }
    }

    public static void jlh() {
        Class26.iXg = new Class26.P4[512];
        for (int i = 0; i < Class26.iXg.Length; i++) {
            Class26.iXg[i] = new Class26.P4(((IEnumerable<byte>)Class26.QXu.dpX).Skip(127048 + i * 48).Take(48).ToArray());
        }
    }

    public static void zll() {
        for (int i = 0; i < Class26.pX3.Length; i++) {
            Array.Copy(Class26.pX3[i].Write(), 0, (Array)Class26.QXu.dpX, 77896 + i * 48, 48);
        }
    }

    public static void zlG() {
        for (int i = 0; i < Class26.rX2.Length; i++) {
            Array.Copy(Class26.rX2[i].Write(), 0, (Array)Class26.QXu.dpX, 102472 + i * 48, 48);
        }
    }

    public static void Ulb() {
        for (int i = 0; i < Class26.iXg.Length; i++) {
            Array.Copy(Class26.iXg[i].Write(), 0, (Array)Class26.QXu.dpX, 127048 + i * 48, 48);
        }
    }

    public static void ylv() {
        Class26.RXd = new Class26.AP[256];
        for (int i = 0; i < Class26.RXd.Length; i++) {
            Class26.RXd[i] = new Class26.AP(((IEnumerable<byte>)Class26.QXu.dpX).Skip(56 + i * 304).Take(304).ToArray());
        }
    }

    public static void Klo() {
        for (int i = 0; i < Class26.RXd.Length; i++) {
            Array.Copy(Class26.RXd[i].iSr(), 0, (Array)Class26.QXu.dpX, 56 + i * 304, 304);
        }
    }

    public static void Elt() {
        Class26.UXH = new Class26.oD[80];
        for (int i = 0; i < Class26.UXH.Length; i++) {
            Class26.UXH[i] = new Class26.oD(((IEnumerable<byte>)Class26.QXu.dpX).Skip(240984 + i * 60).Take(60).ToArray());
        }
    }

    public static void IlV() {
        for (int i = 0; i < Class26.UXH.Length; i++) {
            Array.Copy(Class26.UXH[i].rS4(), 0, (Array)Class26.QXu.dpX, 240984 + i * 60, 60);
        }
    }

    public static void BlO() {
        Class26.MX4 = new Class26.B9[64];
        for (int i = 0; i < Class26.MX4.Length; i++) {
            Class26.MX4[i] = new Class26.B9(((IEnumerable<byte>)Class26.QXu.dpX).Skip(152136 + i * 12).Take(12).ToArray());
        }
    }

    public static void Ole() {
        for (int i = 0; i < Class26.MX4.Length; i++) {
            Array.Copy(Class26.MX4[i].Rhb(), 0, (Array)Class26.QXu.dpX, 152136 + i * 12, 12);
        }
    }

    public static void il8() {
        Class26.jX5 = new Class26.Ep[64];
        for (int i = 0; i < Class26.jX5.Length; i++) {
            Class26.jX5[i] = new Class26.Ep(((IEnumerable<byte>)Class26.QXu.dpX).Skip(151624 + i * 8).Take(8).ToArray());
        }
    }

    public static void Mln() {
        for (int i = 0; i < Class26.jX5.Length; i++) {
            Array.Copy(Class26.jX5[i].uhO(), 0, (Array)Class26.QXu.dpX, 151624 + i * 8, 8);
        }
    }

    public static void ClQ() {
        int num = Class26.QXu.mp5;
        Class26.TXs = new Class26.Od[99];
        for (int i = 0; i < Class26.TXs.Length; i++) {
            Class26.TXs[i] = new Class26.Od(((IEnumerable<byte>)Class26.QXu.dpX).Skip(276732 + num * 12).Take(12).ToArray());
            num++;
            num %= 99;
        }
    }

    public static void YlF() {
        Class26.QXu.mp5 = 0;
        for (int i = 0; i < Class26.TXs.Length; i++) {
            Array.Copy(Class26.TXs[i].xhQ(), 0, (Array)Class26.QXu.dpX, 276732 + i * 12, 12);
        }
    }

    public static void YlL() {
        Class26.TXZ = new Class26.AL[3];
        for (int i = 0; i < 3; i++) {
            Class26.TXZ[i] = new Class26.AL(((IEnumerable<byte>)Class26.QXu.dpX).Skip(268240 + i * 72).Take(72).ToArray());
        }
    }

    public static void blJ() {
        for (int i = 0; i < 3; i++) {
            Array.Copy(Class26.TXZ[i].jhm(), 0, (Array)Class26.QXu.dpX, 268240 + i * 72, 72);
        }
    }

    public static void sl7() {
        Class26.lXa = new Class26.HH[80];
        for (int i = 0; i < 80; i++) {
            Class26.lXa[i] = new Class26.HH(((IEnumerable<byte>)Class26.QXu.dpX).Skip(550932 + i * 20).Take(20).ToArray());
        }
    }

    public static void nlP() {
        for (int i = 0; i < 80; i++) {
            Array.Copy(Class26.lXa[i].Ghk(), 0, (Array)Class26.QXu.dpX, 550932 + i * 20, 20);
        }
    }

    public static void cli() {
        Class26.QXu.kpE();
        blp();
        wlS();
        jlh();
        ylv();
        Elt();
        BlO();
        il8();
        ClQ();
        YlL();
        if (Class26.QXu.Lpp >= 3) {
            sl7();
        }

        Class26.QXu.aXz();
    }

    public static void ulm() {
        Class26.QXu.kpE();
        zll();
        zlG();
        Ulb();
        Klo();
        IlV();
        Ole();
        Mln();
        YlF();
        blJ();
        if (Class26.QXu.Lpp >= 3) {
            nlP();
        }

        Class26.QXu.aXz();
    }
}