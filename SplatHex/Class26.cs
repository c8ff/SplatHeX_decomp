using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace SplatHex;
public static class Class26 {
    public class ux {
        public class Tv {
            public readonly uint uS9;
            public readonly uint USc;
            public readonly uint SSy;
            public Tv(uint uint_0, uint uint_1, uint uint_2) {
                uS9 = uint_0;
                USc = uint_1;
                SSy = uint_2;
            }

            internal static bool kO() {
                return true;
            }
        }

        public object dpX;
        public readonly int Lpp;
        public readonly int UpS;
        public int gph;
        public int Spl;
        public int mpG;
        public int Qpb;
        public int Tpv;
        public int ypo;
        public int Npt;
        public int NpV;
        public int HpO;
        public int vpe;
        public int Fp8;
        public int Jpn;
        public int opQ;
        public int qpF;
        public bool RpL;
        public int GpJ;
        public int yp7;
        public int GpP;
        public int mpi;
        public int hpm;
        public int jp0;
        public int CpI;
        public int EpR;
        public int MpC;
        public int apK;
        public int MpU;
        public int lpT;
        public int Sp1;
        public int bpW;
        public int dpw;
        public int PpN;
        public int xpY;
        public int apB;
        public int cpA;
        public int vpf;
        public int xp6;
        public int epx;
        public int Np9;
        public int Qpc;
        public int upy;
        public int Ipr;
        public int Spq;
        public int Gpk;
        public int epM;
        public int Mpu;
        public int mpg;
        public int lp2;
        public int hp3;
        public int kpd;
        public int cpH;
        public int tp4;
        public int mp5;
        public int vps;
        public int MpZ;
        public int Gpa;
        public int ipj;
        public int Rpz;
        public int HSE;
        public int QSD;
        public int hSX;
        public uint ESp;
        public readonly Tv FSS;
        public readonly Tv vSh;
        public readonly Tv TSl;
        public readonly Tv mSG;
        public readonly float ISb;
        public readonly float SSv;
        public readonly float lSo;
        public readonly float USt;
        public readonly float CSV;
        public readonly float OSO;
        public readonly float mSe;
        public readonly float KS8;
        public readonly float USn;
        public readonly int WSQ;
        public readonly int GSF;
        public readonly int CSL;
        public readonly int USJ;
        public float oS7;
        public float ESP;
        public float pSi;
        public float pSm;
        public bool nS0;
        public bool mSI;
        public bool ESR;
        public bool iSC;
        public bool LSK;
        public bool BSU;
        public bool NST;
        public bool XS1;
        public Array fSW;
        public Array WSw;
        public Array wSN;
        public object MSY;
        public readonly uint uSB;
        public uint MSA;
        public uint HSf;
        public uint rS6;
        public uint pSx;
        public void aXz() {
            ProtectedMemory.Protect((byte[])dpX, MemoryProtectionScope.SameProcess);
        }

        public void kpE() {
            ProtectedMemory.Unprotect((byte[])dpX, MemoryProtectionScope.SameProcess);
        }

        public ux(byte[] byte_0) {
            dpX = byte_0;
            Lpp = BitConverter.ToInt32(byte_0, 0);
            switch (Lpp) {
                case 0:
                    UpS = 0;
                    break;
                case 1:
                    UpS = 3;
                    break;
                case 2:
                    UpS = 4;
                    break;
                case 3:
                    UpS = 7;
                    break;
                case 4:
                    UpS = 9;
                    break;
                case 5:
                    UpS = 11;
                    break;
                default:
                    UpS = 0;
                    break;
                case 7:
                    UpS = 12;
                    break;
                case 8:
                    UpS = 15;
                    break;
            }

            gph = BitConverter.ToInt32(byte_0, 77888);
            Spl = BitConverter.ToInt32(byte_0, 77884);
            mpG = BitConverter.ToInt32(byte_0, 77880);
            Qpb = BitConverter.ToInt32(byte_0, 36);
            Tpv = BitConverter.ToInt32(byte_0, 16);
            ypo = BitConverter.ToInt32(byte_0, 20);
            Npt = BitConverter.ToInt32(byte_0, 28);
            NpV = BitConverter.ToInt32(byte_0, 32);
            HpO = BitConverter.ToInt32(byte_0, 24);
            if (Lpp >= 3) {
                vpe = BitConverter.ToInt32(byte_0, 165088);
                Fp8 = BitConverter.ToInt32(byte_0, 165092);
                Jpn = BitConverter.ToInt32(byte_0, 165100);
                opQ = BitConverter.ToInt32(byte_0, 165104);
                qpF = BitConverter.ToInt32(byte_0, 165096);
            }

            RpL = BitConverter.ToBoolean(byte_0, 165108);
            GpJ = BitConverter.ToInt32(byte_0, 176672) + 1;
            yp7 = BitConverter.ToInt32(byte_0, 176676);
            GpP = BitConverter.ToInt32(byte_0, 176680);
            hpm = BitConverter.ToInt32(byte_0, 176692);
            jp0 = BitConverter.ToInt32(byte_0, 176684);
            mpi = BitConverter.ToInt32(byte_0, 176688);
            CpI = BitConverter.ToInt32(byte_0, 153480);
            EpR = BitConverter.ToInt32(byte_0, 153484);
            MpC = BitConverter.ToInt32(byte_0, 248772);
            apK = BitConverter.ToInt32(byte_0, 248776);
            MpU = BitConverter.ToInt32(byte_0, 248720);
            lpT = BitConverter.ToInt32(byte_0, 248668);
            Sp1 = BitConverter.ToInt32(byte_0, 248672);
            bpW = BitConverter.ToInt32(byte_0, 248676);
            dpw = BitConverter.ToInt32(byte_0, 248680);
            PpN = BitConverter.ToInt32(byte_0, 248684);
            xpY = BitConverter.ToInt32(byte_0, 248688);
            apB = BitConverter.ToInt32(byte_0, 248692);
            cpA = BitConverter.ToInt32(byte_0, 248696);
            vpf = BitConverter.ToInt32(byte_0, 248700);
            xp6 = BitConverter.ToInt32(byte_0, 248708);
            epx = BitConverter.ToInt32(byte_0, 248712);
            Np9 = BitConverter.ToInt32(byte_0, 248716);
            upy = BitConverter.ToInt32(byte_0, 248664);
            Qpc = BitConverter.ToInt32(byte_0, 248704);
            Ipr = ((byte[])dpX)[248748];
            Spq = ((byte[])dpX)[248749];
            Gpk = ((byte[])dpX)[248750];
            epM = ((byte[])dpX)[248751];
            Mpu = ((byte[])dpX)[248752];
            mpg = ((byte[])dpX)[248753];
            lp2 = ((byte[])dpX)[248754];
            hp3 = ((byte[])dpX)[248755];
            kpd = ((byte[])dpX)[248756];
            cpH = ((byte[])dpX)[248757];
            vps = BitConverter.ToInt32(byte_0, 276688);
            MpZ = BitConverter.ToInt32(byte_0, 276692);
            Gpa = BitConverter.ToInt32(byte_0, 276696);
            ipj = BitConverter.ToInt32(byte_0, 276704);
            HSE = BitConverter.ToInt32(byte_0, 276708);
            Rpz = BitConverter.ToInt32(byte_0, 276712);
            QSD = BitConverter.ToInt32(byte_0, 276716);
            hSX = BitConverter.ToInt32(byte_0, 276720);
            tp4 = BitConverter.ToInt32(byte_0, 276724);
            mp5 = BitConverter.ToInt32(byte_0, 276728);
            ESp = BitConverter.ToUInt32(byte_0, 153352);
            TSl = new Tv(BitConverter.ToUInt32(byte_0, 176696), BitConverter.ToUInt32(byte_0, 176700), BitConverter.ToUInt32(byte_0, 176704));
            FSS = new Tv(BitConverter.ToUInt32(byte_0, 176708), BitConverter.ToUInt32(byte_0, 176712), BitConverter.ToUInt32(byte_0, 176716));
            vSh = new Tv(BitConverter.ToUInt32(byte_0, 176720), BitConverter.ToUInt32(byte_0, 176724), BitConverter.ToUInt32(byte_0, 176728));
            mSG = new Tv(BitConverter.ToUInt32(byte_0, 176732), BitConverter.ToUInt32(byte_0, 176736), BitConverter.ToUInt32(byte_0, 176740));
            ISb = BitConverter.ToSingle(byte_0, 176768);
            USt = BitConverter.ToSingle(byte_0, 176784);
            SSv = BitConverter.ToSingle(byte_0, 176800);
            lSo = BitConverter.ToSingle(byte_0, 176816);
            CSV = BitConverter.ToSingle(byte_0, 176832);
            if (Lpp >= 3) {
                KS8 = BitConverter.ToSingle(byte_0, 211336);
                OSO = BitConverter.ToSingle(byte_0, 211408);
                mSe = BitConverter.ToSingle(byte_0, 211480);
                USn = BitConverter.ToSingle(byte_0, 211552);
            }

            CSL = BitConverter.ToInt32(byte_0, 211368);
            WSQ = BitConverter.ToInt32(byte_0, 211440);
            GSF = BitConverter.ToInt32(byte_0, 211512);
            USJ = BitConverter.ToInt32(byte_0, 211584);
            pSm = BitConverter.ToSingle(byte_0, 152908);
            ESP = BitConverter.ToSingle(byte_0, 152912);
            BSU = BitConverter.ToBoolean(byte_0, 152916);
            mSI = BitConverter.ToBoolean(byte_0, 152917);
            iSC = BitConverter.ToBoolean(byte_0, 152918);
            pSi = BitConverter.ToSingle(byte_0, 152984);
            oS7 = BitConverter.ToSingle(byte_0, 152988);
            LSK = BitConverter.ToBoolean(byte_0, 152992);
            nS0 = BitConverter.ToBoolean(byte_0, 152993);
            ESR = BitConverter.ToBoolean(byte_0, 152994);
            NST = BitConverter.ToBoolean(byte_0, 153844);
            XS1 = BitConverter.ToBoolean(byte_0, 153845);
            fSW = ((IEnumerable<byte>)dpX).Skip(227696).Take(288).ToArray();
            MSY = ((IEnumerable<byte>)dpX).Skip(160288).Take(4800).ToArray();
            WSw = ((IEnumerable<byte>)dpX).Skip(265168).Take(3072).ToArray();
            wSN = ((IEnumerable<byte>)dpX).Skip(268464).Take(32).ToArray();
            uSB = BitConverter.ToUInt32(byte_0, 153080);
            if (Lpp >= 3) {
                MSA = BitConverter.ToUInt32(byte_0, 556068);
                HSf = BitConverter.ToUInt32(byte_0, 556076);
                rS6 = BitConverter.ToUInt32(byte_0, 556080);
                pSx = BitConverter.ToUInt32(byte_0, 556084);
            }

            aXz();
        }

        public void fpD() {
            kpE();
            Array.Copy(BitConverter.GetBytes(Lpp), 0, (Array)dpX, 0, 4);
            Array.Copy(BitConverter.GetBytes(gph), 0, (Array)dpX, 77888, 4);
            Array.Copy(BitConverter.GetBytes(Spl), 0, (Array)dpX, 77884, 4);
            Array.Copy(BitConverter.GetBytes(mpG), 0, (Array)dpX, 77880, 4);
            Array.Copy(BitConverter.GetBytes(Qpb), 0, (Array)dpX, 36, 4);
            Array.Copy(BitConverter.GetBytes(Tpv), 0, (Array)dpX, 16, 4);
            Array.Copy(BitConverter.GetBytes(ypo), 0, (Array)dpX, 20, 4);
            Array.Copy(BitConverter.GetBytes(Npt), 0, (Array)dpX, 28, 4);
            Array.Copy(BitConverter.GetBytes(NpV), 0, (Array)dpX, 32, 4);
            Array.Copy(BitConverter.GetBytes(HpO), 0, (Array)dpX, 24, 4);
            if (Lpp >= 3) {
                Array.Copy(BitConverter.GetBytes(vpe), 0, (Array)dpX, 165088, 4);
                Array.Copy(BitConverter.GetBytes(Fp8), 0, (Array)dpX, 165092, 4);
                Array.Copy(BitConverter.GetBytes(qpF), 0, (Array)dpX, 165096, 4);
                Array.Copy(BitConverter.GetBytes(Jpn), 0, (Array)dpX, 165100, 4);
                Array.Copy(BitConverter.GetBytes(opQ), 0, (Array)dpX, 165104, 4);
                Array.Copy(BitConverter.GetBytes(RpL), 0, (Array)dpX, 165108, 1);
            }

            Array.Copy(BitConverter.GetBytes(GpJ - 1), 0, (Array)dpX, 176672, 4);
            Array.Copy(BitConverter.GetBytes(yp7), 0, (Array)dpX, 176676, 4);
            Array.Copy(BitConverter.GetBytes(GpP), 0, (Array)dpX, 176680, 4);
            Array.Copy(BitConverter.GetBytes(hpm), 0, (Array)dpX, 176692, 4);
            Array.Copy(BitConverter.GetBytes(jp0), 0, (Array)dpX, 176684, 4);
            Array.Copy(BitConverter.GetBytes(CpI), 0, (Array)dpX, 153480, 4);
            Array.Copy(BitConverter.GetBytes(EpR), 0, (Array)dpX, 153484, 4);
            Array.Copy(BitConverter.GetBytes(MpC), 0, (Array)dpX, 248772, 4);
            Array.Copy(BitConverter.GetBytes(apK), 0, (Array)dpX, 248776, 4);
            Array.Copy(BitConverter.GetBytes(MpU), 0, (Array)dpX, 248720, 4);
            Array.Copy(BitConverter.GetBytes(lpT), 0, (Array)dpX, 248668, 4);
            Array.Copy(BitConverter.GetBytes(Sp1), 0, (Array)dpX, 248672, 4);
            Array.Copy(BitConverter.GetBytes(bpW), 0, (Array)dpX, 248676, 4);
            Array.Copy(BitConverter.GetBytes(dpw), 0, (Array)dpX, 248680, 4);
            Array.Copy(BitConverter.GetBytes(PpN), 0, (Array)dpX, 248684, 4);
            Array.Copy(BitConverter.GetBytes(xpY), 0, (Array)dpX, 248688, 4);
            Array.Copy(BitConverter.GetBytes(apB), 0, (Array)dpX, 248692, 4);
            Array.Copy(BitConverter.GetBytes(cpA), 0, (Array)dpX, 248696, 4);
            Array.Copy(BitConverter.GetBytes(vpf), 0, (Array)dpX, 248700, 4);
            Array.Copy(BitConverter.GetBytes(xp6), 0, (Array)dpX, 248708, 4);
            Array.Copy(BitConverter.GetBytes(epx), 0, (Array)dpX, 248712, 4);
            Array.Copy(BitConverter.GetBytes(Np9), 0, (Array)dpX, 248716, 4);
            Array.Copy(BitConverter.GetBytes(upy), 0, (Array)dpX, 248664, 4);
            Array.Copy(BitConverter.GetBytes(Qpc), 0, (Array)dpX, 248704, 4);
            ((sbyte[])dpX)[248748] = (sbyte)(byte)Ipr;
            ((sbyte[])dpX)[248749] = (sbyte)(byte)Spq;
            ((sbyte[])dpX)[248750] = (sbyte)(byte)Gpk;
            ((sbyte[])dpX)[248751] = (sbyte)(byte)epM;
            ((sbyte[])dpX)[248752] = (sbyte)(byte)Mpu;
            ((sbyte[])dpX)[248753] = (sbyte)(byte)mpg;
            ((sbyte[])dpX)[248754] = (sbyte)(byte)lp2;
            ((sbyte[])dpX)[248755] = (sbyte)(byte)hp3;
            ((sbyte[])dpX)[248756] = (sbyte)(byte)kpd;
            ((sbyte[])dpX)[248757] = (sbyte)(byte)cpH;
            Array.Copy(BitConverter.GetBytes(tp4), 0, (Array)dpX, 276724, 4);
            Array.Copy(BitConverter.GetBytes(vps), 0, (Array)dpX, 276688, 4);
            Array.Copy(BitConverter.GetBytes(MpZ), 0, (Array)dpX, 276692, 4);
            Array.Copy(BitConverter.GetBytes(Gpa), 0, (Array)dpX, 276696, 4);
            Array.Copy(BitConverter.GetBytes(ipj), 0, (Array)dpX, 276704, 4);
            Array.Copy(BitConverter.GetBytes(Rpz), 0, (Array)dpX, 276712, 4);
            Array.Copy(BitConverter.GetBytes(HSE), 0, (Array)dpX, 276708, 4);
            Array.Copy(BitConverter.GetBytes(QSD), 0, (Array)dpX, 276716, 4);
            Array.Copy(BitConverter.GetBytes(hSX), 0, (Array)dpX, 276720, 4);
            Array.Copy(BitConverter.GetBytes(ESp), 0, (Array)dpX, 153352, 4);
            Array.Copy(fSW, 0, (Array)dpX, 227696, fSW.Length);
            Array.Copy(WSw, 0, (Array)dpX, 265168, WSw.Length);
            Array.Copy(wSN, 0, (Array)dpX, 268464, wSN.Length);
            Array.Copy((Array)MSY, 0, (Array)dpX, 160288, ((Array)MSY).Length);
            if (Lpp >= 3) {
                Array.Copy(BitConverter.GetBytes(MSA), 0, (Array)dpX, 556068, 4);
                Array.Copy(BitConverter.GetBytes(HSf), 0, (Array)dpX, 556076, 4);
                Array.Copy(BitConverter.GetBytes(rS6), 0, (Array)dpX, 556080, 4);
                Array.Copy(BitConverter.GetBytes(pSx), 0, (Array)dpX, 556084, 4);
            }

            aXz();
        }
    }

    public class P4 : Class33 {
        public P4(byte[] byte_0) {
            zXJ = byte_0;
            hXP = BitConverter.ToInt32(byte_0, 0);
            RX7 = BitConverter.ToInt32(byte_0, 4);
            xXi = BitConverter.ToInt32(byte_0, 8);
            HXm = BitConverter.ToInt32(byte_0, 12);
            vX0 = BitConverter.ToInt32(byte_0, 16);
            wXI = BitConverter.ToInt32(byte_0, 20);
            GXR = BitConverter.ToInt32(byte_0, 24);
            iXC = BitConverter.ToInt32(byte_0, 28);
            UXK = BitConverter.ToInt32(byte_0, 32);
            CXU = ((byte[])zXJ)[40];
        }

        public override byte[] Write() {
            Array.Copy(BitConverter.GetBytes(hXP), 0, (Array)zXJ, 0, 4);
            Array.Copy(BitConverter.GetBytes(RX7), 0, (Array)zXJ, 4, 4);
            Array.Copy(BitConverter.GetBytes(xXi), 0, (Array)zXJ, 8, 4);
            Array.Copy(BitConverter.GetBytes(HXm), 0, (Array)zXJ, 12, 4);
            Array.Copy(BitConverter.GetBytes(vX0), 0, (Array)zXJ, 16, 4);
            Array.Copy(BitConverter.GetBytes(wXI), 0, (Array)zXJ, 20, 4);
            Array.Copy(BitConverter.GetBytes(GXR), 0, (Array)zXJ, 24, 4);
            Array.Copy(BitConverter.GetBytes(iXC), 0, (Array)zXJ, 28, 4);
            Array.Copy(BitConverter.GetBytes(UXK), 0, (Array)zXJ, 32, 4);
            ((sbyte[])zXJ)[40] = (sbyte)(byte)CXU;
            return (byte[])zXJ;
        }
    }

    public class AP {
        public object LSq;
        public int ISk;
        public int nSM;
        public int kSu;
        public int ISg;
        public int wS2;
        public int oS3;
        public int iSd;
        public int NSH;
        public AP(byte[] byte_0) {
            LSq = byte_0;
            ISk = BitConverter.ToInt32(byte_0, 0);
            nSM = BitConverter.ToInt32(byte_0, 4);
            kSu = BitConverter.ToInt32(byte_0, 8);
            ISg = BitConverter.ToInt32(byte_0, 12);
            wS2 = BitConverter.ToInt32(byte_0, 16);
            oS3 = BitConverter.ToInt32(byte_0, 24);
            iSd = BitConverter.ToInt32(byte_0, 28);
            NSH = ((byte[])LSq)[296];
        }

        public byte[] iSr() {
            Array.Copy(BitConverter.GetBytes(ISk), 0, (Array)LSq, 0, 4);
            Array.Copy(BitConverter.GetBytes(nSM), 0, (Array)LSq, 4, 4);
            Array.Copy(BitConverter.GetBytes(kSu), 0, (Array)LSq, 8, 4);
            Array.Copy(BitConverter.GetBytes(ISg), 0, (Array)LSq, 12, 4);
            Array.Copy(BitConverter.GetBytes(wS2), 0, (Array)LSq, 16, 4);
            Array.Copy(BitConverter.GetBytes(oS3), 0, (Array)LSq, 24, 4);
            Array.Copy(BitConverter.GetBytes(iSd), 0, (Array)LSq, 28, 4);
            ((sbyte[])LSq)[296] = (sbyte)(byte)NSH;
            return (byte[])LSq;
        }
    }

    public class oD {
        public object qS5;
        public int USs;
        public int pSZ;
        public int RSa;
        public int HSj;
        public int lSz;
        public int ChE;
        public int dhD;
        public int OhX;
        public int khp;
        public int IhS;
        public int rhh;
        public int Xhl;
        public int chG;
        public oD(byte[] byte_0) {
            qS5 = byte_0;
            USs = BitConverter.ToInt32(byte_0, 0);
            pSZ = BitConverter.ToInt32(byte_0, 4);
            RSa = BitConverter.ToInt32(byte_0, 8);
            HSj = BitConverter.ToInt32(byte_0, 16);
            lSz = BitConverter.ToInt32(byte_0, 24);
            ChE = BitConverter.ToInt32(byte_0, 28);
            dhD = BitConverter.ToInt32(byte_0, 32);
            OhX = BitConverter.ToInt32(byte_0, 36);
            khp = BitConverter.ToInt32(byte_0, 40);
            IhS = BitConverter.ToInt32(byte_0, 44);
            rhh = BitConverter.ToInt32(byte_0, 48);
            Xhl = BitConverter.ToInt32(byte_0, 52);
            chG = BitConverter.ToInt32(byte_0, 56);
        }

        public byte[] rS4() {
            Array.Copy(BitConverter.GetBytes(USs), 0, (Array)qS5, 0, 4);
            Array.Copy(BitConverter.GetBytes(pSZ), 0, (Array)qS5, 4, 4);
            Array.Copy(BitConverter.GetBytes(RSa), 0, (Array)qS5, 8, 4);
            Array.Copy(BitConverter.GetBytes(HSj), 0, (Array)qS5, 16, 4);
            Array.Copy(BitConverter.GetBytes(lSz), 0, (Array)qS5, 24, 4);
            Array.Copy(BitConverter.GetBytes(ChE), 0, (Array)qS5, 28, 4);
            Array.Copy(BitConverter.GetBytes(dhD), 0, (Array)qS5, 32, 4);
            Array.Copy(BitConverter.GetBytes(OhX), 0, (Array)qS5, 36, 4);
            Array.Copy(BitConverter.GetBytes(khp), 0, (Array)qS5, 40, 4);
            Array.Copy(BitConverter.GetBytes(IhS), 0, (Array)qS5, 44, 4);
            Array.Copy(BitConverter.GetBytes(rhh), 0, (Array)qS5, 48, 4);
            Array.Copy(BitConverter.GetBytes(Xhl), 0, (Array)qS5, 52, 4);
            Array.Copy(BitConverter.GetBytes(chG), 0, (Array)qS5, 56, 4);
            return (byte[])qS5;
        }
    }

    public class B9 {
        public object qhv;
        public int uho;
        public int qht;
        public int ChV;
        public B9(byte[] byte_0) {
            qhv = byte_0;
            uho = BitConverter.ToInt32(byte_0, 0);
            qht = BitConverter.ToInt32(byte_0, 4);
            ChV = BitConverter.ToInt32(byte_0, 8);
        }

        public byte[] Rhb() {
            Array.Copy(BitConverter.GetBytes(uho), 0, (Array)qhv, 0, 4);
            Array.Copy(BitConverter.GetBytes(qht), 0, (Array)qhv, 4, 4);
            Array.Copy(BitConverter.GetBytes(ChV), 0, (Array)qhv, 8, 4);
            return (byte[])qhv;
        }

        internal static bool u1() {
            return true;
        }
    }

    public class Ep {
        public object xhe;
        public int eh8;
        public int Dhn;
        public Ep(byte[] byte_0) {
            xhe = byte_0;
            eh8 = BitConverter.ToInt32(byte_0, 0);
            Dhn = BitConverter.ToInt32(byte_0, 4);
        }

        public byte[] uhO() {
            Array.Copy(BitConverter.GetBytes(eh8), 0, (Array)xhe, 0, 4);
            Array.Copy(BitConverter.GetBytes(Dhn), 0, (Array)xhe, 4, 4);
            return (byte[])xhe;
        }
    }

    public class Od {
        public object xhF;
        public int yhL;
        public int YhJ;
        public int Wh7;
        public int BhP;
        public int Ahi;
        public Od(byte[] byte_0) {
            xhF = byte_0;
            yhL = ((byte[])xhF)[0];
            YhJ = ((byte[])xhF)[1];
            Wh7 = BitConverter.ToInt16(byte_0, 2);
            BhP = BitConverter.ToInt32(byte_0, 4);
            Ahi = BitConverter.ToInt32(byte_0, 8);
        }

        public byte[] xhQ() {
            ((sbyte[])xhF)[0] = (sbyte)(byte)yhL;
            ((sbyte[])xhF)[1] = (sbyte)(byte)YhJ;
            Array.Copy(BitConverter.GetBytes(Wh7), 0, (Array)xhF, 2, 2);
            Array.Copy(BitConverter.GetBytes(BhP), 0, (Array)xhF, 4, 4);
            Array.Copy(BitConverter.GetBytes(Ahi), 0, (Array)xhF, 8, 4);
            return (byte[])xhF;
        }
    }

    public class AL {
        public object Nh0;
        public int PhI;
        public int EhR;
        public int FhC;
        public int VhK;
        public int fhU;
        public int UhT;
        public int oh1;
        public int ahW;
        public int ahw;
        public int hhN;
        public int ahY;
        public int IhB;
        public int QhA;
        public int Qhf;
        public int Ch6;
        public int zhx;
        public int bh9;
        public int Whc;
        public int rhy;
        public int Nhr;
        public bool lhq;
        public AL(byte[] byte_0) {
            Nh0 = byte_0;
            PhI = BitConverter.ToInt32(byte_0, 0);
            EhR = BitConverter.ToInt32(byte_0, 4);
            FhC = BitConverter.ToInt32(byte_0, 8);
            VhK = BitConverter.ToInt32(byte_0, 12);
            fhU = BitConverter.ToInt32(byte_0, 16);
            UhT = BitConverter.ToInt32(byte_0, 20);
            oh1 = BitConverter.ToInt32(byte_0, 24);
            ahW = BitConverter.ToInt32(byte_0, 28);
            ahY = BitConverter.ToInt32(byte_0, 40);
            QhA = BitConverter.ToInt32(byte_0, 48);
            lhq = BitConverter.ToBoolean(byte_0, 68);
        }

        public byte[] jhm() {
            Array.Copy(BitConverter.GetBytes(PhI), 0, (Array)Nh0, 0, 4);
            Array.Copy(BitConverter.GetBytes(EhR), 0, (Array)Nh0, 4, 4);
            Array.Copy(BitConverter.GetBytes(FhC), 0, (Array)Nh0, 8, 4);
            Array.Copy(BitConverter.GetBytes(VhK), 0, (Array)Nh0, 12, 4);
            Array.Copy(BitConverter.GetBytes(fhU), 0, (Array)Nh0, 16, 4);
            Array.Copy(BitConverter.GetBytes(UhT), 0, (Array)Nh0, 20, 4);
            Array.Copy(BitConverter.GetBytes(oh1), 0, (Array)Nh0, 24, 4);
            Array.Copy(BitConverter.GetBytes(ahW), 0, (Array)Nh0, 28, 4);
            Array.Copy(BitConverter.GetBytes(ahY), 0, (Array)Nh0, 40, 4);
            Array.Copy(BitConverter.GetBytes(QhA), 0, (Array)Nh0, 48, 4);
            return (byte[])Nh0;
        }
    }

    public class HH {
        public object DhM;
        public int Ahu;
        public int Whg;
        public int Sh2;
        public int uh3;
        public HH(byte[] byte_0) {
            DhM = byte_0;
            Ahu = BitConverter.ToInt32(byte_0, 0);
            Whg = BitConverter.ToInt32(byte_0, 4);
            Sh2 = BitConverter.ToInt32(byte_0, 8);
            uh3 = ((byte[])DhM)[10];
        }

        public byte[] Ghk() {
            Array.Copy(BitConverter.GetBytes(Ahu), 0, (Array)DhM, 0, 4);
            Array.Copy(BitConverter.GetBytes(Whg), 0, (Array)DhM, 4, 4);
            Array.Copy(BitConverter.GetBytes(Sh2), 0, (Array)DhM, 8, 4);
            ((sbyte[])DhM)[10] = (sbyte)(byte)uh3;
            return (byte[])DhM;
        }

        internal static bool DNv() {
            return true;
        }

        internal static bool oNU() {
            return false;
        }
    }

    public static ux QXu;
    public static P4[] iXg;
    public static P4[] rX2;
    public static P4[] pX3;
    public static AP[] RXd;
    public static oD[] UXH;
    public static B9[] MX4;
    public static Ep[] jX5;
    public static Od[] TXs;
    public static AL[] TXZ;
    public static HH[] lXa;
    public static int[] pXj;
    static Class26() {
        pXj = new int[32]
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
    }

    internal static bool L9() {
        return true;
    }

    internal static bool cC() {
        return false;
    }
}