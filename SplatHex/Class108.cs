using System;
using System.Collections.Generic;
using System.Text;

namespace SplatHex;
public static class Class108 {
    public class hrV {
        public object ztX;
        public int Otp;
        public int MtS;
        public int yth;
        public int btl;
        public int CtG;
        public int itb;
        public int ttv;
        public int Vto;
        public int ptt;
        public int BtV;
        public int ItO;
        public int ete;
        public int dt8;
        public int otn;
        public int CtQ;
        public int NtF;
        public int StL;
        public int PtJ;
        public int gt7;
        public decimal ytP;
        public int Tti;
        public int Qtm;
        public int Wt0;
        public int ytI;
        public int TtR;
        public int ftC;
        public int ntK;
        public int HtU;
        public int otT;
        public int Gt1;
        public int OtW;
        public int ztw;
        public int TtN;
        public int jtY;
        public int DtB;
        public int CtA;
        public hrV(byte[] byte_0) {
            ztX = byte_0;
            Otp = Class47.i4E(byte_0, 0);
            CtG = Class47.i4E(byte_0, 396);
            MtS = Class47.i4E(byte_0, 392);
            yth = Class47.i4E(byte_0, 384);
            btl = Class47.i4E(byte_0, 388);
            itb = Class47.i4E(byte_0, 36);
            ttv = Class47.i4E(byte_0, 45528);
            Vto = Class47.i4E(byte_0, 45532);
            ptt = Class47.i4E(byte_0, 64);
            BtV = Class47.i4E(byte_0, 68);
            ItO = Class47.i4E(byte_0, 72);
            ete = Class47.i4E(byte_0, 76);
            dt8 = Class47.i4E(byte_0, 400);
            CtQ = Class47.i4E(byte_0, 404);
            otn = Class47.i4E(byte_0, 408);
            NtF = ((byte[])ztX)[19];
            gt7 = ((byte[])ztX)[24];
            PtJ = ((byte[])ztX)[25];
            StL = ((byte[])ztX)[26];
            ytP = Class47.i4E(byte_0, 20);
            Tti = Class47.i4E(byte_0, 42408) + 1;
            Qtm = Class47.i4E(byte_0, 42404);
            Wt0 = Class47.i4E(byte_0, 42400);
            ytI = Class47.i4E(byte_0, 42420);
            TtR = Class47.i4E(byte_0, 42412);
            ftC = Class47.i4E(byte_0, 42416);
            ntK = Class47.i4E(byte_0, 43488);
            HtU = Class47.i4E(byte_0, 43464);
            otT = Class47.i4E(byte_0, 43468);
            Gt1 = Class47.i4E(byte_0, 43476);
            OtW = Class47.i4E(byte_0, 43480);
            ztw = Class47.i4E(byte_0, 43484);
            TtN = Class47.i4E(byte_0, 36);
            jtY = Class47.i4E(byte_0, 43452);
            DtB = Class47.i4E(byte_0, 43460);
            CtA = Class47.i4E(byte_0, 43472);
        }

        public byte[] qtD() {
            Array.Copy(BitConverter.GetBytes(Class47.a4X(CtG)), 0, (Array)ztX, 396, 4);
            Array.Copy(BitConverter.GetBytes(Class47.a4X(MtS)), 0, (Array)ztX, 392, 4);
            Array.Copy(BitConverter.GetBytes(Class47.a4X(yth)), 0, (Array)ztX, 384, 4);
            Array.Copy(BitConverter.GetBytes(Class47.a4X(btl)), 0, (Array)ztX, 388, 4);
            Array.Copy(BitConverter.GetBytes(Class47.a4X(itb)), 0, (Array)ztX, 36, 4);
            Array.Copy(BitConverter.GetBytes(Class47.a4X(ttv)), 0, (Array)ztX, 45528, 4);
            Array.Copy(BitConverter.GetBytes(Class47.a4X(Vto)), 0, (Array)ztX, 45532, 4);
            Array.Copy(BitConverter.GetBytes(Class47.a4X(ptt)), 0, (Array)ztX, 64, 4);
            Array.Copy(BitConverter.GetBytes(Class47.a4X(BtV)), 0, (Array)ztX, 68, 4);
            Array.Copy(BitConverter.GetBytes(Class47.a4X(ItO)), 0, (Array)ztX, 72, 4);
            Array.Copy(BitConverter.GetBytes(Class47.a4X(ete)), 0, (Array)ztX, 76, 4);
            Array.Copy(BitConverter.GetBytes(Class47.a4X(dt8)), 0, (Array)ztX, 400, 4);
            Array.Copy(BitConverter.GetBytes(Class47.a4X(CtQ)), 0, (Array)ztX, 404, 4);
            Array.Copy(BitConverter.GetBytes(Class47.a4X(otn)), 0, (Array)ztX, 408, 4);
            ((sbyte[])ztX)[19] = (sbyte)(byte)NtF;
            ((sbyte[])ztX)[24] = (sbyte)(byte)gt7;
            ((sbyte[])ztX)[25] = (sbyte)(byte)PtJ;
            ((sbyte[])ztX)[26] = (sbyte)(byte)StL;
            Array.Copy(BitConverter.GetBytes(Class47.a4X((int)ytP)), 0, (Array)ztX, 20, 4);
            Array.Copy(BitConverter.GetBytes(Class47.a4X(Qtm)), 0, (Array)ztX, 42404, 4);
            Array.Copy(BitConverter.GetBytes(Class47.a4X(Tti - 1)), 0, (Array)ztX, 42408, 4);
            Array.Copy(BitConverter.GetBytes(Class47.a4X(Wt0)), 0, (Array)ztX, 42400, 4);
            Array.Copy(BitConverter.GetBytes(Class47.a4X(ytI)), 0, (Array)ztX, 42420, 4);
            Array.Copy(BitConverter.GetBytes(Class47.a4X(TtR)), 0, (Array)ztX, 42412, 4);
            Array.Copy(BitConverter.GetBytes(Class47.a4X(ftC)), 0, (Array)ztX, 42416, 4);
            Array.Copy(BitConverter.GetBytes(Class47.a4X(ntK)), 0, (Array)ztX, 43488, 4);
            Array.Copy(BitConverter.GetBytes(Class47.a4X(HtU)), 0, (Array)ztX, 43464, 4);
            Array.Copy(BitConverter.GetBytes(Class47.a4X(otT)), 0, (Array)ztX, 43468, 4);
            Array.Copy(BitConverter.GetBytes(Class47.a4X(Gt1)), 0, (Array)ztX, 43476, 4);
            Array.Copy(BitConverter.GetBytes(Class47.a4X(OtW)), 0, (Array)ztX, 43480, 4);
            Array.Copy(BitConverter.GetBytes(Class47.a4X(ztw)), 0, (Array)ztX, 43484, 4);
            Array.Copy(BitConverter.GetBytes(Class47.a4X(TtN)), 0, (Array)ztX, 36, 4);
            Array.Copy(BitConverter.GetBytes(Class47.a4X(jtY)), 0, (Array)ztX, 43452, 4);
            Array.Copy(BitConverter.GetBytes(Class47.a4X(DtB)), 0, (Array)ztX, 43460, 4);
            Array.Copy(BitConverter.GetBytes(Class47.a4X(CtA)), 0, (Array)ztX, 43472, 4);
            return (byte[])ztX;
        }
    }

    public class fr2 : Class33 {
        public fr2(byte[] byte_0) {
            zXJ = byte_0;
            hXP = Class47.i4E(byte_0, 0);
            RX7 = Class47.i4E(byte_0, 4);
            xXi = Class47.i4E(byte_0, 8);
            vX0 = Class47.i4E(byte_0, 12);
            wXI = Class47.i4E(byte_0, 16);
            GXR = Class47.i4E(byte_0, 20);
            iXC = Class47.i4E(byte_0, 24);
            UXK = Class47.i4E(byte_0, 36);
            CXU = ((byte[])zXJ)[40];
        }

        public override byte[] Write() {
            Array.Copy(BitConverter.GetBytes(Class47.a4X(hXP)), 0, (Array)zXJ, 0, 4);
            Array.Copy(BitConverter.GetBytes(Class47.a4X(RX7)), 0, (Array)zXJ, 4, 4);
            Array.Copy(BitConverter.GetBytes(Class47.a4X(xXi)), 0, (Array)zXJ, 8, 4);
            Array.Copy(BitConverter.GetBytes(Class47.a4X(vX0)), 0, (Array)zXJ, 12, 4);
            Array.Copy(BitConverter.GetBytes(Class47.a4X(wXI)), 0, (Array)zXJ, 16, 4);
            Array.Copy(BitConverter.GetBytes(Class47.a4X(GXR)), 0, (Array)zXJ, 20, 4);
            Array.Copy(BitConverter.GetBytes(Class47.a4X(iXC)), 0, (Array)zXJ, 24, 4);
            Array.Copy(BitConverter.GetBytes(Class47.a4X(UXK)), 0, (Array)zXJ, 36, 4);
            ((sbyte[])zXJ)[40] = (sbyte)(byte)CXU;
            return (byte[])zXJ;
        }
    }

    public class UrT {
        public object ot6;
        public int btx;
        public int Bt9;
        public int gtc;
        public int pty;
        public int Ttr;
        public int atq;
        public int itk;
        public UrT(byte[] byte_0) {
            ot6 = byte_0;
            btx = Class47.i4E(byte_0, 0);
            Bt9 = Class47.i4E(byte_0, 4);
            gtc = Class47.i4E(byte_0, 8);
            pty = Class47.i4E(byte_0, 12);
            Ttr = Class47.i4E(byte_0, 16);
            atq = Class47.i4E(byte_0, 28);
            itk = ((byte[])ot6)[32];
        }

        public byte[] Gtf() {
            Array.Copy(BitConverter.GetBytes(Class47.a4X(btx)), 0, (Array)ot6, 0, 4);
            Array.Copy(BitConverter.GetBytes(Class47.a4X(Bt9)), 0, (Array)ot6, 4, 4);
            Array.Copy(BitConverter.GetBytes(Class47.a4X(gtc)), 0, (Array)ot6, 8, 4);
            Array.Copy(BitConverter.GetBytes(Class47.a4X(pty)), 0, (Array)ot6, 12, 4);
            Array.Copy(BitConverter.GetBytes(Class47.a4X(Ttr)), 0, (Array)ot6, 16, 4);
            Array.Copy(BitConverter.GetBytes(Class47.a4X(atq)), 0, (Array)ot6, 28, 4);
            ((sbyte[])ot6)[32] = (sbyte)(byte)itk;
            return (byte[])ot6;
        }
    }

    public class Trf {
        public readonly object Vtu;
        public int ftg;
        public Trf(byte[] byte_0) {
            Vtu = byte_0;
            ftg = Class47.i4E(byte_0, 0);
        }

        public byte[] AtM() {
            Array.Copy(BitConverter.GetBytes(Class47.a4X(ftg)), 0, (Array)Vtu, 0, 4);
            return (byte[])Vtu;
        }

        internal static bool CN9() {
            return true;
        }
    }

    public class irN {
        public object ft3;
        public string Btd;
        public int XtH;
        public int ut4;
        public int Gt5;
        public int Jts;
        public int AtZ;
        public int wta;
        public int xtj;
        public int btz;
        public int HVE;
        public int SVD;
        public int vVX;
        public int BVp;
        public int aVS;
        public int HVh;
        public irN(byte[] byte_0) {
            ft3 = byte_0;
            XtH = Class47.i4E(byte_0, 0);
            Btd = Encoding.Unicode.GetString(((IEnumerable<byte>)ft3).Skip(7).Take(16).ToArray());
            ut4 = Class47.i4E(byte_0, 172) + 1;
            Gt5 = Class47.i4E(byte_0, 176);
            wta = Class47.i4E(byte_0, 52);
            Jts = Class47.i4E(byte_0, 56);
            AtZ = Class47.i4E(byte_0, 60);
            xtj = Class47.i4E(byte_0, 80);
            btz = Class47.i4E(byte_0, 64);
            HVE = Class47.i4E(byte_0, 140);
            SVD = Class47.i4E(byte_0, 112);
            vVX = Class47.i4E(byte_0, 84);
            BVp = Class47.i4E(byte_0, 220);
            aVS = Class47.i4E(byte_0, 224);
            HVh = Class47.i4E(byte_0, 228);
        }

        public byte[] It2() {
            Array.Copy(Encoding.Unicode.GetBytes(Btd.PadRight(9, '\0')), 0, (Array)ft3, 7, 16);
            Array.Copy(BitConverter.GetBytes(Class47.a4X(ut4 - 1)), 0, (Array)ft3, 172, 4);
            Array.Copy(BitConverter.GetBytes(Class47.a4X(Gt5)), 0, (Array)ft3, 176, 4);
            Array.Copy(BitConverter.GetBytes(Class47.a4X(wta)), 0, (Array)ft3, 52, 4);
            Array.Copy(BitConverter.GetBytes(Class47.a4X(Jts)), 0, (Array)ft3, 56, 4);
            Array.Copy(BitConverter.GetBytes(Class47.a4X(AtZ)), 0, (Array)ft3, 60, 4);
            Array.Copy(BitConverter.GetBytes(Class47.a4X(xtj)), 0, (Array)ft3, 80, 4);
            Array.Copy(BitConverter.GetBytes(Class47.a4X(btz)), 0, (Array)ft3, 64, 4);
            Array.Copy(BitConverter.GetBytes(Class47.a4X(HVE)), 0, (Array)ft3, 140, 4);
            Array.Copy(BitConverter.GetBytes(Class47.a4X(SVD)), 0, (Array)ft3, 112, 4);
            Array.Copy(BitConverter.GetBytes(Class47.a4X(vVX)), 0, (Array)ft3, 84, 4);
            Array.Copy(BitConverter.GetBytes(Class47.a4X(BVp)), 0, (Array)ft3, 220, 4);
            Array.Copy(BitConverter.GetBytes(Class47.a4X(aVS)), 0, (Array)ft3, 224, 4);
            Array.Copy(BitConverter.GetBytes(Class47.a4X(HVh)), 0, (Array)ft3, 228, 4);
            return (byte[])ft3;
        }
    }

    public class Uru {
        public object BVG;
        public int mVb;
        public int zVv;
        public int qVo;
        public int AVt;
        public int FVV;
        public int iVO;
        public int IVe;
        public int jV8;
        public int HVn;
        public int iVQ;
        public Uru(byte[] byte_0) {
            BVG = byte_0;
            mVb = Class47.i4E(byte_0, 0);
            zVv = Class47.i4E(byte_0, 4);
            qVo = Class47.i4E(byte_0, 8);
            AVt = Class47.i4E(byte_0, 12);
            FVV = Class47.i4E(byte_0, 16);
            iVO = Class47.i4E(byte_0, 20);
            IVe = Class47.i4E(byte_0, 24);
            jV8 = Class47.i4E(byte_0, 36);
            HVn = Class47.i4E(byte_0, 44);
            iVQ = Class47.i4E(byte_0, 56);
        }

        public byte[] wVl() {
            Array.Copy(BitConverter.GetBytes(Class47.a4X(mVb)), 0, (Array)BVG, 0, 4);
            Array.Copy(BitConverter.GetBytes(Class47.a4X(zVv)), 0, (Array)BVG, 4, 4);
            Array.Copy(BitConverter.GetBytes(Class47.a4X(qVo)), 0, (Array)BVG, 8, 4);
            Array.Copy(BitConverter.GetBytes(Class47.a4X(AVt)), 0, (Array)BVG, 12, 4);
            Array.Copy(BitConverter.GetBytes(Class47.a4X(FVV)), 0, (Array)BVG, 16, 4);
            Array.Copy(BitConverter.GetBytes(Class47.a4X(iVO)), 0, (Array)BVG, 20, 4);
            Array.Copy(BitConverter.GetBytes(Class47.a4X(IVe)), 0, (Array)BVG, 24, 4);
            Array.Copy(BitConverter.GetBytes(Class47.a4X(jV8)), 0, (Array)BVG, 36, 4);
            Array.Copy(BitConverter.GetBytes(Class47.a4X(HVn)), 0, (Array)BVG, 44, 4);
            Array.Copy(BitConverter.GetBytes(Class47.a4X(iVQ)), 0, (Array)BVG, 56, 4);
            return (byte[])BVG;
        }
    }

    public class Fra {
        public readonly object YVL;
        public int fVJ;
        public int rV7;
        public int uVP;
        public Fra(byte[] byte_0) {
            YVL = byte_0;
            fVJ = Class47.i4E(byte_0, 0);
            rV7 = Class47.i4E(byte_0, 4);
            uVP = Class47.i4E(byte_0, 8);
        }

        public byte[] qVF() {
            Array.Copy(BitConverter.GetBytes(Class47.a4X(fVJ)), 0, (Array)YVL, 0, 4);
            Array.Copy(BitConverter.GetBytes(Class47.a4X(rV7)), 0, (Array)YVL, 4, 4);
            Array.Copy(BitConverter.GetBytes(Class47.a4X(uVP)), 0, (Array)YVL, 8, 4);
            return (byte[])YVL;
        }
    }

    public static Dictionary<int, int> wog;
    public static hrV io2;
    public static fr2[] Jo3;
    public static fr2[] Yod;
    public static fr2[] YoH;
    public static UrT[] Vo4;
    public static Trf[] bo5;
    public static Trf[] kos;
    public static Trf[] yoZ;
    public static irN[] Foa;
    public static Uru[] Voj;
    public static Fra[] Ioz;
    public static int[] RtE;
    static Class108() {
        RtE = new int[32]
        {
            1,
            2,
            3,
            101,
            4,
            5,
            6,
            7,
            8,
            9,
            102,
            10,
            11,
            12,
            13,
            14,
            15,
            103,
            16,
            17,
            18,
            19,
            20,
            21,
            104,
            22,
            23,
            24,
            25,
            26,
            27,
            105
        };
        wog = new Dictionary<int, int>();
        wog.Add(1, 700);
        wog.Add(2, 1600);
        wog.Add(3, 2600);
        wog.Add(4, 3700);
        wog.Add(5, 4800);
        wog.Add(6, 6000);
        wog.Add(7, 7200);
        wog.Add(8, 8600);
        wog.Add(9, 10000);
        wog.Add(10, 11500);
        wog.Add(11, 13100);
        wog.Add(12, 14800);
        wog.Add(13, 16600);
        wog.Add(14, 18600);
        wog.Add(15, 20600);
        wog.Add(16, 22700);
        wog.Add(17, 25000);
        wog.Add(18, 27400);
        wog.Add(19, 30000);
        wog.Add(20, 24);
        wog.Add(21, 48);
        wog.Add(22, 72);
        wog.Add(23, 96);
        wog.Add(24, 120);
        wog.Add(25, 144);
        wog.Add(26, 168);
        wog.Add(27, 192);
        wog.Add(28, 216);
        wog.Add(29, 240);
        wog.Add(30, 264);
        wog.Add(31, 288);
        wog.Add(32, 321);
        wog.Add(33, 336);
        wog.Add(34, 360);
        wog.Add(35, 384);
        wog.Add(36, 408);
        wog.Add(37, 432);
        wog.Add(38, 456);
        wog.Add(39, 480);
        wog.Add(40, 504);
        wog.Add(41, 528);
        wog.Add(42, 552);
        wog.Add(43, 576);
        wog.Add(44, 600);
        wog.Add(45, 624);
        wog.Add(46, 648);
        wog.Add(47, 672);
        wog.Add(48, 696);
        wog.Add(49, 720);
        wog.Add(50, 0);
    }
}