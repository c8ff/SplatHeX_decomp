using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace SplatHex;
public class Class99 : Form {
    public static int KIp;
    public int WIS;
    public int DIh;
    private IDisposable HIl;
    private GroupBox UIG;
    private Button zIb;
    private ListBox sIv;
    public PictureBox gIo;
    public PictureBox JIt;
    public CheckBox EIV;
    public PictureBox tIO;
    public CheckBox PIe;
    public CheckBox UI8;
    public PictureBox FIn;
    private TabControl zIQ;
    private TabPage cIF;
    private TabPage CIL;
    private TabPage WIJ;
    private TabPage zI7;
    private TabPage iIP;
    private GroupBox sIi;
    private GroupBox bIm;
    private CheckBox MI0;
    public PictureBox VII;
    private CheckBox sIR;
    public PictureBox tIC;
    private CheckBox dIK;
    public PictureBox LIU;
    private CheckBox AIT;
    public PictureBox kI1;
    private CheckBox TIW;
    public PictureBox rIw;
    private CheckBox WIN;
    public PictureBox EIY;
    private CheckBox pIB;
    public PictureBox QIA;
    private CheckBox rIf;
    public PictureBox vI6;
    private CheckBox mIx;
    public PictureBox eI9;
    public PictureBox WIc;
    public CheckBox qIy;
    public PictureBox VIr;
    public PictureBox DIq;
    private PictureBox XIk;
    public PictureBox LIM;
    public PictureBox dIu;
    public PictureBox pIg;
    public PictureBox wI2;
    public PictureBox iI3;
    public PictureBox XId;
    public PictureBox aIH;
    public PictureBox HI4;
    private GroupBox AI5;
    private PictureBox MIs;
    private PictureBox YIZ;
    private PictureBox fIa;
    private PictureBox DIj;
    private GroupBox FIz;
    private PictureBox NRE;
    private PictureBox ARD;
    private PictureBox XRX;
    private PictureBox KRp;
    private PictureBox CRS;
    private PictureBox IRh;
    private PictureBox IRl;
    private PictureBox aRG;
    private Button sRb;
    private Button IRv;
    private PictureBox sRo;
    private NumericUpDown oRt;
    private CheckBox DRV;
    private NumericUpDown zRO;
    private CheckBox hRe;
    private NumericUpDown VR8;
    private CheckBox CRn;
    private NumericUpDown PRQ;
    private CheckBox BRF;
    private NumericUpDown pRL;
    private CheckBox aRJ;
    private NumericUpDown jR7;
    private CheckBox kRP;
    private NumericUpDown uRi;
    private CheckBox ARm;
    private NumericUpDown oR0;
    private CheckBox jRI;
    private CheckBox pRR;
    private CheckBox DRC;
    private CheckBox MRK;
    private CheckBox eRU;
    private CheckBox VRT;
    private CheckBox eR1;
    private CheckBox MRW;
    private CheckBox JRw;
    private CheckBox nRN;
    private CheckBox VRY;
    private NumericUpDown gRB;
    private CheckBox aRA;
    private CheckBox CRf;
    private CheckBox qR6;
    private CheckBox SRx;
    private NumericUpDown lR9;
    private CheckBox YRc;
    private NumericUpDown eRy;
    private PictureBox uRr;
    private PictureBox ARq;
    private PictureBox jRk;
    private PictureBox CRM;
    private DateTimePicker VRu;
    private DateTimePicker VRg;
    private DateTimePicker VR2;
    private DateTimePicker LR3;
    private DateTimePicker ORd;
    private DateTimePicker lRH;
    private DateTimePicker LR4;
    private DateTimePicker OR5;
    private DateTimePicker HRs;
    private NumericUpDown dRZ;
    private PictureBox NRa;
    public Label eRj;
    public Label lRz;
    public Label rCE;
    public Label ACD;
    public Label OCX;
    public Label nCp;
    public Label fCS;
    public Label xCh;
    public Label rCl;
    public Label uCG;
    private TabControl CCb;
    private TabPage nCv;
    private TabPage OCo;
    private Button qCt;
    private NumericUpDown BCV;
    private NumericUpDown lCO;
    private Label dCe;
    private Label qC8;
    private NumericUpDown JCn;
    private Label bCQ;
    private Label JCF;
    private NumericUpDown mCL;
    public Class99() {
        eIX();
        b07();
    }

    private void b07() {
        sIv.SelectedIndex = 0;
        C0i();
        d0P();
    }

    private void d0P() {
        if (Class26.QXu.Lpp >= 3) {
            BCV.Value = Class26.QXu.MSA;
            mCL.Value = Class26.QXu.HSf;
            lCO.Value = Class26.QXu.rS6;
            JCn.Value = Class26.QXu.pSx;
        } else {
            CCb.TabPages.RemoveAt(1);
        }
    }

    private void C0i() {
        eRy.Value = Class26.QXu.MpC;
        dRZ.Value = Class26.QXu.apK;
        pRR.Checked = (Class26.QXu.mpg & 1) != 0;
        MRK.Checked = (Class26.QXu.lp2 & 1) != 0;
        VRT.Checked = (Class26.QXu.hp3 & 1) != 0;
        MRW.Checked = (Class26.QXu.kpd & 1) != 0;
        nRN.Checked = (Class26.QXu.cpH & 1) != 0;
        DRC.Checked = (Class26.QXu.Ipr & 1) != 0;
        eRU.Checked = (Class26.QXu.Spq & 1) != 0;
        eR1.Checked = (Class26.QXu.Gpk & 1) != 0;
        JRw.Checked = (Class26.QXu.epM & 1) != 0;
        VRY.Checked = (Class26.QXu.Mpu & 1) != 0;
        if (Class26.QXu.lpT == -1) {
            gRB.Value = 1m;
        } else {
            gRB.Value = Class26.QXu.lpT + 1;
            aRA.Checked = true;
        }

        if (Class26.QXu.MpU == -1) {
            lR9.Value = 1m;
        } else {
            lR9.Value = Class26.QXu.MpU + 1;
            YRc.Checked = true;
        }

        if (Class26.QXu.xp6 == -1) {
            SRx.Checked = false;
        } else {
            SRx.Checked = true;
        }

        if (Class26.QXu.epx == -1) {
            qR6.Checked = false;
        } else {
            qR6.Checked = true;
        }

        if (Class26.QXu.Np9 == -1) {
            CRf.Checked = false;
        } else {
            CRf.Checked = true;
        }

        if (Class26.QXu.Sp1 == -1) {
            oRt.Value = 1m;
            oRt.Enabled = false;
        } else {
            oRt.Value = Class26.QXu.Sp1 + 1;
            DRV.Checked = true;
        }

        if (Class26.QXu.bpW == -1) {
            oR0.Value = 1m;
            oR0.Enabled = false;
        } else {
            oR0.Value = Class26.QXu.bpW + 1;
            jRI.Checked = true;
        }

        if (Class26.QXu.dpw == -1) {
            uRi.Value = 1m;
            uRi.Enabled = false;
        } else {
            uRi.Value = Class26.QXu.dpw + 1;
            ARm.Checked = true;
        }

        if (Class26.QXu.PpN == -1) {
            jR7.Value = 1m;
            jR7.Enabled = false;
        } else {
            jR7.Value = Class26.QXu.PpN + 1;
            kRP.Checked = true;
        }

        if (Class26.QXu.xpY == -1) {
            pRL.Value = 1m;
            pRL.Enabled = false;
        } else {
            pRL.Value = Class26.QXu.xpY + 1;
            aRJ.Checked = true;
        }

        if (Class26.QXu.apB == -1) {
            PRQ.Value = 1m;
            PRQ.Enabled = false;
        } else {
            PRQ.Value = Class26.QXu.apB + 1;
            BRF.Checked = true;
        }

        if (Class26.QXu.cpA == -1) {
            VR8.Value = 1m;
            VR8.Enabled = false;
        } else {
            VR8.Value = Class26.QXu.cpA + 1;
            CRn.Checked = true;
        }

        if (Class26.QXu.vpf == -1) {
            zRO.Value = 1m;
            zRO.Enabled = false;
        } else {
            zRO.Value = Class26.QXu.vpf + 1;
            hRe.Checked = true;
        }

        switch (Class26.QXu.Qpc) {
            case 0:
                jRk.BackColor = Color.OrangeRed;
                WIS = 0;
                break;
            case 1:
                ARq.BackColor = Color.OrangeRed;
                WIS = 1;
                break;
            case 2:
                uRr.BackColor = Color.OrangeRed;
                WIS = 2;
                break;
        }
    }

    private void T0m(object sender, EventArgs e) {
        KIp = -1;
        if (sIv.SelectedItem.ToString().Contains("Boss")) {
            PIe.Enabled = false;
        } else {
            PIe.Enabled = true;
        }

        if (sIv.SelectedIndex == -1) {
            return;
        }

        sIi.Enabled = true;
        bIm.Enabled = true;
        JIt.Image = (Image)Resources.oKz.GetObject(sIv.SelectedItem.ToString().Replace(" ", "_") + "_Splat2");
        UI8.Checked = false;
        PIe.Checked = false;
        EIV.Checked = false;
        qIy.Checked = false;
        mIx.Checked = false;
        rIf.Checked = false;
        pIB.Checked = false;
        WIN.Checked = false;
        TIW.Checked = false;
        AIT.Checked = false;
        dIK.Checked = false;
        sIR.Checked = false;
        MI0.Checked = false;
        VRu.Value = C0I(0);
        HRs.Value = C0I(0);
        OR5.Value = C0I(0);
        LR4.Value = C0I(0);
        lRH.Value = C0I(0);
        ORd.Value = C0I(0);
        LR3.Value = C0I(0);
        VR2.Value = C0I(0);
        VRg.Value = C0I(0);
        for (int i = 0; i < Class26.UXH.Length; i++) {
            if (Class26.UXH[i].USs == Class26.pXj[sIv.SelectedIndex]) {
                KIp = i;
                break;
            }
        }

        if (KIp != -1) {
            UI8.Checked = true;
            EIV.Checked = (Class26.UXH[KIp].pSZ & 1) != 0;
            qIy.Checked = (Class26.UXH[KIp].RSa & 2) != 0;
            if (PIe.Enabled) {
                PIe.Checked = (Class26.UXH[KIp].RSa & 1) != 0;
            }

            VRu.Value = C0I(Class26.UXH[KIp].lSz);
            HRs.Value = C0I(Class26.UXH[KIp].ChE);
            OR5.Value = C0I(Class26.UXH[KIp].dhD);
            LR4.Value = C0I(Class26.UXH[KIp].OhX);
            lRH.Value = C0I(Class26.UXH[KIp].khp);
            ORd.Value = C0I(Class26.UXH[KIp].IhS);
            LR3.Value = C0I(Class26.UXH[KIp].rhh);
            VR2.Value = C0I(Class26.UXH[KIp].Xhl);
            VRg.Value = C0I(Class26.UXH[KIp].chG);
            mIx.Checked = (Class26.UXH[KIp].HSj & 1) != 0;
            rIf.Checked = (Class26.UXH[KIp].HSj & 2) != 0;
            pIB.Checked = (Class26.UXH[KIp].HSj & 4) != 0;
            WIN.Checked = (Class26.UXH[KIp].HSj & 8) != 0;
            TIW.Checked = (Class26.UXH[KIp].HSj & 0x10) != 0;
            AIT.Checked = (Class26.UXH[KIp].HSj & 0x20) != 0;
            dIK.Checked = (Class26.UXH[KIp].HSj & 0x40) != 0;
            sIR.Checked = (Class26.UXH[KIp].HSj & 0x80) != 0;
            MI0.Checked = (Class26.UXH[KIp].HSj & 0x100) != 0;
        } else {
            sIi.Enabled = false;
            bIm.Enabled = false;
        }
    }

    private void o00(object sender, EventArgs e) {
        if (UI8.Checked) {
            if (KIp == -1) {
                KIp = p0C();
                Class26.UXH[KIp].USs = Class26.pXj[sIv.SelectedIndex];
            }

            uint uint_ = 0u;
            uint uint_2 = 0u;
            uint uint_3 = 0u;
            Class115.cH2(ref uint_, 2u, bool_0: true);
            Class115.cH2(ref uint_, 1u, EIV.Checked);
            Class26.UXH[KIp].pSZ = (int)uint_;
            Class115.cH2(ref uint_2, 2u, qIy.Checked);
            Class115.cH2(ref uint_2, 1u, PIe.Checked);
            Class26.UXH[KIp].RSa = (int)uint_2;
            Class26.UXH[KIp].RSa = (int)uint_2;
            Class26.UXH[KIp].RSa = (int)uint_2;
            Class115.cH2(ref uint_3, 1u, mIx.Checked);
            Class115.cH2(ref uint_3, 2u, rIf.Checked);
            Class115.cH2(ref uint_3, 4u, pIB.Checked);
            Class115.cH2(ref uint_3, 8u, WIN.Checked);
            Class115.cH2(ref uint_3, 16u, TIW.Checked);
            Class115.cH2(ref uint_3, 32u, AIT.Checked);
            Class115.cH2(ref uint_3, 64u, dIK.Checked);
            Class115.cH2(ref uint_3, 128u, sIR.Checked);
            Class115.cH2(ref uint_3, 256u, MI0.Checked);
            Class26.UXH[KIp].HSj = (int)uint_3;
            if (mIx.Checked) {
                Class26.UXH[KIp].lSz = h0R(VRu.Value.Minute, VRu.Value.Second);
            } else {
                Class26.UXH[KIp].lSz = -1;
            }

            if (rIf.Checked) {
                Class26.UXH[KIp].ChE = h0R(HRs.Value.Minute, HRs.Value.Second);
            } else {
                Class26.UXH[KIp].ChE = -1;
            }

            if (pIB.Checked) {
                Class26.UXH[KIp].dhD = h0R(OR5.Value.Minute, OR5.Value.Second);
            } else {
                Class26.UXH[KIp].dhD = -1;
            }

            if (WIN.Checked) {
                Class26.UXH[KIp].OhX = h0R(LR4.Value.Minute, LR4.Value.Second);
            } else {
                Class26.UXH[KIp].OhX = -1;
            }

            if (TIW.Checked) {
                Class26.UXH[KIp].khp = h0R(lRH.Value.Minute, lRH.Value.Second);
            } else {
                Class26.UXH[KIp].khp = -1;
            }

            if (AIT.Checked) {
                Class26.UXH[KIp].IhS = h0R(ORd.Value.Minute, ORd.Value.Second);
            } else {
                Class26.UXH[KIp].IhS = -1;
            }

            if (dIK.Checked) {
                Class26.UXH[KIp].rhh = h0R(LR3.Value.Minute, LR3.Value.Second);
            } else {
                Class26.UXH[KIp].rhh = -1;
            }

            if (sIR.Checked) {
                Class26.UXH[KIp].Xhl = h0R(VR2.Value.Minute, VR2.Value.Second);
            } else {
                Class26.UXH[KIp].Xhl = -1;
            }

            if (MI0.Checked) {
                Class26.UXH[KIp].chG = h0R(VRg.Value.Minute, VRg.Value.Second);
            } else {
                Class26.UXH[KIp].chG = -1;
            }
        } else if (KIp != -1) {
            for (int i = KIp; i < Class26.UXH.Length - 1; i++) {
                Class26.UXH[i] = Class26.UXH[i + 1];
            }
        }
    }

    private DateTime C0I(int int_0) {
        int minute = int_0 / 3600;
        int second = int_0 / 60 % 60;
        return new DateTime(2018, 1, 1, 0, minute, second);
    }

    private int h0R(int int_0, int int_1) {
        if (int_0 == 0 && int_1 == 0) {
            return -1;
        }

        return (int_0 * 60 + int_1) * 60;
    }

    private int p0C() {
        int num = 0;
        while (true) {
            if (num < Class26.UXH.Length) {
                if (Class26.UXH[num].USs == -1) {
                    break;
                }

                num++;
                continue;
            }

            return 500;
        }

        return num;
    }

    private void y0K(object sender, EventArgs e) {
        Class26.QXu.MpC = (int)eRy.Value;
        Class26.QXu.apK = (int)dRZ.Value;
        Class26.QXu.Qpc = WIS;
        if (pRR.Checked) {
            Class26.QXu.mpg = 1;
        } else {
            Class26.QXu.mpg = 0;
        }

        if (MRK.Checked) {
            Class26.QXu.lp2 = 1;
        } else {
            Class26.QXu.lp2 = 0;
        }

        if (VRT.Checked) {
            Class26.QXu.hp3 = 1;
        } else {
            Class26.QXu.hp3 = 0;
        }

        if (MRW.Checked) {
            Class26.QXu.kpd = 1;
        } else {
            Class26.QXu.kpd = 0;
        }

        if (nRN.Checked) {
            Class26.QXu.cpH = 1;
        } else {
            Class26.QXu.cpH = 0;
        }

        if (DRC.Checked) {
            Class26.QXu.Ipr = 1;
        } else {
            Class26.QXu.Ipr = 0;
        }

        if (eRU.Checked) {
            Class26.QXu.Spq = 1;
        } else {
            Class26.QXu.Spq = 0;
        }

        if (eR1.Checked) {
            Class26.QXu.Gpk = 1;
        } else {
            Class26.QXu.Gpk = 0;
        }

        if (JRw.Checked) {
            Class26.QXu.epM = 1;
        } else {
            Class26.QXu.epM = 0;
        }

        if (VRY.Checked) {
            Class26.QXu.Mpu = 1;
        } else {
            Class26.QXu.Mpu = 0;
        }

        Class26.QXu.lpT = (int)gRB.Value - 1;
        Class26.QXu.MpU = (int)lR9.Value - 1;
        Class26.QXu.xp6 = 0;
        if (qR6.Checked) {
            Class26.QXu.epx = 0;
        } else {
            Class26.QXu.epx = -1;
        }

        if (CRf.Checked) {
            Class26.QXu.Np9 = 0;
        } else {
            Class26.QXu.Np9 = -1;
        }

        if (DRV.Checked) {
            Class26.QXu.Sp1 = (int)oRt.Value - 1;
        } else {
            Class26.QXu.Sp1 = -1;
        }

        if (jRI.Checked) {
            Class26.QXu.bpW = (int)oR0.Value - 1;
        } else {
            Class26.QXu.bpW = -1;
        }

        if (ARm.Checked) {
            Class26.QXu.dpw = (int)uRi.Value - 1;
        } else {
            Class26.QXu.dpw = -1;
        }

        if (kRP.Checked) {
            Class26.QXu.PpN = (int)jR7.Value - 1;
        } else {
            Class26.QXu.PpN = -1;
        }

        if (aRJ.Checked) {
            Class26.QXu.xpY = (int)pRL.Value - 1;
        } else {
            Class26.QXu.xpY = -1;
        }

        if (BRF.Checked) {
            Class26.QXu.apB = (int)PRQ.Value - 1;
        } else {
            Class26.QXu.apB = -1;
        }

        if (CRn.Checked) {
            Class26.QXu.cpA = (int)VR8.Value - 1;
        } else {
            Class26.QXu.cpA = -1;
        }

        if (hRe.Checked) {
            Class26.QXu.vpf = (int)zRO.Value - 1;
        } else {
            Class26.QXu.vpf = -1;
        }

        Close();
    }

    private void A0U(object sender, EventArgs e) {
        Close();
    }

    private void Y0T(object sender, EventArgs e) {
        jRk.BackColor = Color.OrangeRed;
        ARq.BackColor = Color.Gray;
        uRr.BackColor = Color.Gray;
        WIS = 0;
    }

    private void m01(object sender, EventArgs e) {
        jRk.BackColor = Color.Gray;
        ARq.BackColor = Color.OrangeRed;
        uRr.BackColor = Color.Gray;
        WIS = 1;
    }

    private void b0W(object sender, EventArgs e) {
        jRk.BackColor = Color.Gray;
        ARq.BackColor = Color.Gray;
        uRr.BackColor = Color.OrangeRed;
        WIS = 2;
    }

    private void t0w(object sender, EventArgs e) {
        decimal value = ((NumericUpDown)sender).Value;
        if (!1m.Equals(value)) {
            if (2m.Equals(value)) {
                XIk.Image = Resources.Wst_Shooter_MissionNormalLv1_Splat2;
            } else if (3m.Equals(value)) {
                XIk.Image = Resources.Wst_Shooter_MissionNormalLv2_Splat2;
            }
        } else {
            XIk.Image = Resources.Wst_Shooter_MissionNormalLv0_Splat2;
        }
    }

    private void H0N(object sender, EventArgs e) {
        decimal value = ((NumericUpDown)sender).Value;
        if (!1m.Equals(value)) {
            if (!2m.Equals(value)) {
                if (3m.Equals(value)) {
                    DIj.Image = Resources.Tnk_Msn0Lv2_Splat2;
                }
            } else {
                DIj.Image = Resources.Tnk_Msn0Lv1_Splat2;
            }
        } else {
            DIj.Image = Resources.Tnk_Msn0Lv0_Splat2;
        }
    }

    private void P0Y(object sender, EventArgs e) {
        decimal value = ((NumericUpDown)sender).Value;
        if (!1m.Equals(value)) {
            if (2m.Equals(value)) {
                NRE.Image = Resources.Wst_Roller_MissionNormalLv1_Splat2;
            }
        } else {
            NRE.Image = Resources.Wst_Roller_MissionNormalLv0_Splat2;
        }
    }

    private void e0B(object sender, EventArgs e) {
        decimal value = ((NumericUpDown)sender).Value;
        if (!1m.Equals(value)) {
            if (2m.Equals(value)) {
                aRG.Image = Resources.Wst_Charger_MissionNormalLv1_Splat2;
            }
        } else {
            aRG.Image = Resources.Wst_Charger_MissionNormalLv0_Splat2;
        }
    }

    private void r0A(object sender, EventArgs e) {
        decimal value = ((NumericUpDown)sender).Value;
        if (!1m.Equals(value)) {
            if (2m.Equals(value)) {
                IRl.Image = Resources.Wst_Twins_MissionNormalLv1_Splat2;
            }
        } else {
            IRl.Image = Resources.Wst_Twins_MissionNormalLv0_Splat2;
        }
    }

    private void e0f(object sender, EventArgs e) {
        decimal value = ((NumericUpDown)sender).Value;
        if (!1m.Equals(value)) {
            if (2m.Equals(value)) {
                IRh.Image = Resources.Wst_Umbrella_MissionNormalLv1_Splat2;
            }
        } else {
            IRh.Image = Resources.Wst_Umbrella_MissionNormalLv0_Splat2;
        }
    }

    private void k06(object sender, EventArgs e) {
        decimal value = ((NumericUpDown)sender).Value;
        if (!1m.Equals(value)) {
            if (2m.Equals(value)) {
                CRS.Image = Resources.Wst_Spinner_MissionStandardLv1_Splat2;
            }
        } else {
            CRS.Image = Resources.Wst_Spinner_MissionStandardLv0_Splat2;
        }
    }

    private void R0x(object sender, EventArgs e) {
        decimal value = ((NumericUpDown)sender).Value;
        if (!1m.Equals(value)) {
            if (2m.Equals(value)) {
                KRp.Image = Resources.Wst_Shooter_BlasterMissionMiddleLv1_Splat2;
            }
        } else {
            KRp.Image = Resources.Wst_Shooter_BlasterMissionMiddleLv0_Splat2;
        }
    }

    private void A09(object sender, EventArgs e) {
        decimal value = ((NumericUpDown)sender).Value;
        if (1m.Equals(value)) {
            XRX.Image = Resources.Wst_Slosher_MissionStrongLv0_Splat2;
        } else if (2m.Equals(value)) {
            XRX.Image = Resources.Wst_Slosher_MissionStrongLv1_Splat2;
        }
    }

    private void A0c(object sender, EventArgs e) {
        decimal value = ((NumericUpDown)sender).Value;
        if (!1m.Equals(value)) {
            if (2m.Equals(value)) {
                ARD.Image = Resources.Wst_Roller_MissionBrushNormalLv1_Splat2;
            }
        } else {
            ARD.Image = Resources.Wst_Roller_MissionBrushNormalLv0_Splat2;
        }
    }

    private void F0y(object sender, EventArgs e) {
        bool flag;
        if (!(flag = ((CheckBox)sender).Checked)) {
            oRt.Enabled = false;
        } else if (flag) {
            oRt.Enabled = true;
        }
    }

    private void u0r(object sender, EventArgs e) {
        bool flag;
        if (!(flag = ((CheckBox)sender).Checked)) {
            oR0.Enabled = false;
        } else if (flag) {
            oR0.Enabled = true;
        }
    }

    private void w0q(object sender, EventArgs e) {
        bool flag;
        if (flag = ((CheckBox)sender).Checked) {
            if (flag) {
                uRi.Enabled = true;
            }
        } else {
            uRi.Enabled = false;
        }
    }

    private void X0k(object sender, EventArgs e) {
        bool flag;
        if (flag = ((CheckBox)sender).Checked) {
            if (flag) {
                jR7.Enabled = true;
            }
        } else {
            jR7.Enabled = false;
        }
    }

    private void v0M(object sender, EventArgs e) {
        bool flag;
        if (flag = ((CheckBox)sender).Checked) {
            if (flag) {
                pRL.Enabled = true;
            }
        } else {
            pRL.Enabled = false;
        }
    }

    private void o0u(object sender, EventArgs e) {
        bool flag;
        if (!(flag = ((CheckBox)sender).Checked)) {
            PRQ.Enabled = false;
        } else if (flag) {
            PRQ.Enabled = true;
        }
    }

    private void K0g(object sender, EventArgs e) {
        bool flag;
        if (flag = ((CheckBox)sender).Checked) {
            if (flag) {
                VR8.Enabled = true;
            }
        } else {
            VR8.Enabled = false;
        }
    }

    private void w02(object sender, EventArgs e) {
        bool flag;
        if (!(flag = ((CheckBox)sender).Checked)) {
            zRO.Enabled = false;
        } else if (flag) {
            zRO.Enabled = true;
        }
    }

    private void O03(object sender, EventArgs e) {
        if (!sIi.Enabled && UI8.Checked) {
            sIi.Enabled = true;
            bIm.Enabled = true;
        } else if (sIi.Enabled && !UI8.Checked) {
            sIi.Enabled = false;
            bIm.Enabled = false;
        }
    }

    private void Q0d() {
        DIh = 0;
        for (int i = 0; i < Class26.UXH.Length; i++) {
            if ((Class26.UXH[i].RSa & 2) != 0) {
                DIh++;
            }
        }

        if (Class26.QXu.mpg == 1) {
            DIh++;
        }

        if (Class26.QXu.lp2 == 1) {
            DIh++;
        }

        if (Class26.QXu.hp3 == 1) {
            DIh++;
        }

        if (Class26.QXu.kpd == 1) {
            DIh++;
        }

        if (Class26.QXu.cpH == 1) {
            DIh++;
        }

        if (Class26.QXu.Sp1 == 1) {
            DIh -= 3;
        }

        if (Class26.QXu.bpW == 1) {
            DIh -= 3;
        }

        if (Class26.QXu.dpw == 1) {
            DIh -= 3;
        }

        if (Class26.QXu.PpN == 1) {
            DIh -= 3;
        }

        if (Class26.QXu.xpY == 1) {
            DIh -= 3;
        }

        if (Class26.QXu.apB == 1) {
            DIh -= 3;
        }

        if (Class26.QXu.cpA == 1) {
            DIh -= 3;
        }

        if (Class26.QXu.vpf == 1) {
            DIh -= 3;
        }

        if (Class26.QXu.epx == 0) {
            DIh -= 2;
        }

        if (Class26.QXu.Np9 == 0) {
            DIh -= 2;
        }

        if (Class26.QXu.lpT == 1) {
            DIh -= 2;
        } else if (Class26.QXu.lpT == 2) {
            DIh -= 5;
        }

        if (Class26.QXu.MpU == 1) {
            DIh -= 2;
        } else if (Class26.QXu.MpU == 2) {
            DIh -= 5;
        }
    }

    private void m0H(object sender, EventArgs e) {
        if (((CheckBox)sender).Checked && VRu.Value == C0I(0)) {
            VRu.Value = C0I(Class115.nHs(20000, 30000));
        }
    }

    private void u04(object sender, EventArgs e) {
        if (((CheckBox)sender).Checked && HRs.Value == C0I(0)) {
            HRs.Value = C0I(Class115.nHs(20000, 30000));
        }
    }

    private void m05(object sender, EventArgs e) {
        if (((CheckBox)sender).Checked && OR5.Value == C0I(0)) {
            OR5.Value = C0I(Class115.nHs(20000, 30000));
        }
    }

    private void h0s(object sender, EventArgs e) {
        if (((CheckBox)sender).Checked && LR4.Value == C0I(0)) {
            LR4.Value = C0I(Class115.nHs(20000, 30000));
        }
    }

    private void h0Z(object sender, EventArgs e) {
        if (((CheckBox)sender).Checked && lRH.Value == C0I(0)) {
            lRH.Value = C0I(Class115.nHs(20000, 30000));
        }
    }

    private void e0a(object sender, EventArgs e) {
        if (((CheckBox)sender).Checked && ORd.Value == C0I(0)) {
            ORd.Value = C0I(Class115.nHs(20000, 30000));
        }
    }

    private void u0j(object sender, EventArgs e) {
        if (((CheckBox)sender).Checked && LR3.Value == C0I(0)) {
            LR3.Value = C0I(Class115.nHs(20000, 30000));
        }
    }

    private void b0z(object sender, EventArgs e) {
        if (((CheckBox)sender).Checked && VR2.Value == C0I(0)) {
            VR2.Value = C0I(Class115.nHs(20000, 30000));
        }
    }

    private void KIE(object sender, EventArgs e) {
        if (((CheckBox)sender).Checked && VRg.Value == C0I(0)) {
            VRg.Value = C0I(Class115.nHs(20000, 30000));
        }
    }

    private void CID(object sender, EventArgs e) {
        Class26.QXu.MSA = (uint)BCV.Value;
        Class26.QXu.HSf = (uint)mCL.Value;
        Class26.QXu.rS6 = (uint)lCO.Value;
        Class26.QXu.pSx = (uint)JCn.Value;
        if (Class26.QXu.rS6 + Class26.QXu.pSx > 10) {
            Class26.QXu.pSx = 10 - Class26.QXu.rS6;
        }

        Close();
    }

    protected override void Dispose(bool disposing) {
        if (disposing && HIl != null) {
            HIl.Dispose();
        }

        base.Dispose(disposing);
    }

    private void eIX() {
        UIG = new GroupBox();
        bIm = new GroupBox();
        VRg = new DateTimePicker();
        VR2 = new DateTimePicker();
        LR3 = new DateTimePicker();
        ORd = new DateTimePicker();
        lRH = new DateTimePicker();
        LR4 = new DateTimePicker();
        OR5 = new DateTimePicker();
        HRs = new DateTimePicker();
        VRu = new DateTimePicker();
        MI0 = new CheckBox();
        VII = new PictureBox();
        sIR = new CheckBox();
        tIC = new PictureBox();
        dIK = new CheckBox();
        LIU = new PictureBox();
        AIT = new CheckBox();
        kI1 = new PictureBox();
        TIW = new CheckBox();
        rIw = new PictureBox();
        WIN = new CheckBox();
        EIY = new PictureBox();
        pIB = new CheckBox();
        QIA = new PictureBox();
        rIf = new CheckBox();
        vI6 = new PictureBox();
        mIx = new CheckBox();
        eI9 = new PictureBox();
        sIi = new GroupBox();
        WIc = new PictureBox();
        qIy = new CheckBox();
        gIo = new PictureBox();
        PIe = new CheckBox();
        FIn = new PictureBox();
        EIV = new CheckBox();
        zIb = new Button();
        sIv = new ListBox();
        JIt = new PictureBox();
        tIO = new PictureBox();
        UI8 = new CheckBox();
        zIQ = new TabControl();
        cIF = new TabPage();
        VIr = new PictureBox();
        pRR = new CheckBox();
        DIq = new PictureBox();
        DRC = new CheckBox();
        CIL = new TabPage();
        LIM = new PictureBox();
        MRK = new CheckBox();
        dIu = new PictureBox();
        eRU = new CheckBox();
        WIJ = new TabPage();
        pIg = new PictureBox();
        VRT = new CheckBox();
        wI2 = new PictureBox();
        eR1 = new CheckBox();
        zI7 = new TabPage();
        iI3 = new PictureBox();
        MRW = new CheckBox();
        XId = new PictureBox();
        JRw = new CheckBox();
        iIP = new TabPage();
        aIH = new PictureBox();
        nRN = new CheckBox();
        HI4 = new PictureBox();
        VRY = new CheckBox();
        XIk = new PictureBox();
        gRB = new NumericUpDown();
        aRA = new CheckBox();
        AI5 = new GroupBox();
        eRj = new Label();
        lRz = new Label();
        MIs = new PictureBox();
        CRf = new CheckBox();
        YIZ = new PictureBox();
        qR6 = new CheckBox();
        fIa = new PictureBox();
        SRx = new CheckBox();
        DIj = new PictureBox();
        lR9 = new NumericUpDown();
        YRc = new CheckBox();
        FIz = new GroupBox();
        rCE = new Label();
        ACD = new Label();
        OCX = new Label();
        nCp = new Label();
        fCS = new Label();
        xCh = new Label();
        rCl = new Label();
        uCG = new Label();
        zRO = new NumericUpDown();
        hRe = new CheckBox();
        ARD = new PictureBox();
        VR8 = new NumericUpDown();
        CRn = new CheckBox();
        XRX = new PictureBox();
        PRQ = new NumericUpDown();
        BRF = new CheckBox();
        KRp = new PictureBox();
        pRL = new NumericUpDown();
        aRJ = new CheckBox();
        CRS = new PictureBox();
        jR7 = new NumericUpDown();
        kRP = new CheckBox();
        IRh = new PictureBox();
        uRi = new NumericUpDown();
        ARm = new CheckBox();
        IRl = new PictureBox();
        oR0 = new NumericUpDown();
        jRI = new CheckBox();
        aRG = new PictureBox();
        oRt = new NumericUpDown();
        DRV = new CheckBox();
        NRE = new PictureBox();
        sRb = new Button();
        IRv = new Button();
        eRy = new NumericUpDown();
        uRr = new PictureBox();
        ARq = new PictureBox();
        jRk = new PictureBox();
        sRo = new PictureBox();
        CRM = new PictureBox();
        dRZ = new NumericUpDown();
        NRa = new PictureBox();
        CCb = new TabControl();
        nCv = new TabPage();
        OCo = new TabPage();
        qC8 = new Label();
        JCn = new NumericUpDown();
        bCQ = new Label();
        JCF = new Label();
        mCL = new NumericUpDown();
        lCO = new NumericUpDown();
        dCe = new Label();
        qCt = new Button();
        BCV = new NumericUpDown();
        UIG.SuspendLayout();
        bIm.SuspendLayout();
        ((ISupportInitialize)VII).BeginInit();
        ((ISupportInitialize)tIC).BeginInit();
        ((ISupportInitialize)LIU).BeginInit();
        ((ISupportInitialize)kI1).BeginInit();
        ((ISupportInitialize)rIw).BeginInit();
        ((ISupportInitialize)EIY).BeginInit();
        ((ISupportInitialize)QIA).BeginInit();
        ((ISupportInitialize)vI6).BeginInit();
        ((ISupportInitialize)eI9).BeginInit();
        sIi.SuspendLayout();
        ((ISupportInitialize)WIc).BeginInit();
        ((ISupportInitialize)gIo).BeginInit();
        ((ISupportInitialize)FIn).BeginInit();
        ((ISupportInitialize)JIt).BeginInit();
        ((ISupportInitialize)tIO).BeginInit();
        zIQ.SuspendLayout();
        cIF.SuspendLayout();
        ((ISupportInitialize)VIr).BeginInit();
        ((ISupportInitialize)DIq).BeginInit();
        CIL.SuspendLayout();
        ((ISupportInitialize)LIM).BeginInit();
        ((ISupportInitialize)dIu).BeginInit();
        WIJ.SuspendLayout();
        ((ISupportInitialize)pIg).BeginInit();
        ((ISupportInitialize)wI2).BeginInit();
        zI7.SuspendLayout();
        ((ISupportInitialize)iI3).BeginInit();
        ((ISupportInitialize)XId).BeginInit();
        iIP.SuspendLayout();
        ((ISupportInitialize)aIH).BeginInit();
        ((ISupportInitialize)HI4).BeginInit();
        ((ISupportInitialize)XIk).BeginInit();
        ((ISupportInitialize)gRB).BeginInit();
        AI5.SuspendLayout();
        ((ISupportInitialize)MIs).BeginInit();
        ((ISupportInitialize)YIZ).BeginInit();
        ((ISupportInitialize)fIa).BeginInit();
        ((ISupportInitialize)DIj).BeginInit();
        ((ISupportInitialize)lR9).BeginInit();
        FIz.SuspendLayout();
        ((ISupportInitialize)zRO).BeginInit();
        ((ISupportInitialize)ARD).BeginInit();
        ((ISupportInitialize)VR8).BeginInit();
        ((ISupportInitialize)XRX).BeginInit();
        ((ISupportInitialize)PRQ).BeginInit();
        ((ISupportInitialize)KRp).BeginInit();
        ((ISupportInitialize)pRL).BeginInit();
        ((ISupportInitialize)CRS).BeginInit();
        ((ISupportInitialize)jR7).BeginInit();
        ((ISupportInitialize)IRh).BeginInit();
        ((ISupportInitialize)uRi).BeginInit();
        ((ISupportInitialize)IRl).BeginInit();
        ((ISupportInitialize)oR0).BeginInit();
        ((ISupportInitialize)aRG).BeginInit();
        ((ISupportInitialize)oRt).BeginInit();
        ((ISupportInitialize)NRE).BeginInit();
        ((ISupportInitialize)eRy).BeginInit();
        ((ISupportInitialize)uRr).BeginInit();
        ((ISupportInitialize)ARq).BeginInit();
        ((ISupportInitialize)jRk).BeginInit();
        ((ISupportInitialize)sRo).BeginInit();
        ((ISupportInitialize)CRM).BeginInit();
        ((ISupportInitialize)dRZ).BeginInit();
        ((ISupportInitialize)NRa).BeginInit();
        CCb.SuspendLayout();
        nCv.SuspendLayout();
        OCo.SuspendLayout();
        ((ISupportInitialize)JCn).BeginInit();
        ((ISupportInitialize)mCL).BeginInit();
        ((ISupportInitialize)lCO).BeginInit();
        ((ISupportInitialize)BCV).BeginInit();
        SuspendLayout();
        UIG.Controls.Add(bIm);
        UIG.Controls.Add(sIi);
        UIG.Controls.Add(zIb);
        UIG.Controls.Add(sIv);
        UIG.Controls.Add(JIt);
        UIG.Controls.Add(tIO);
        UIG.Controls.Add(UI8);
        UIG.Location = new Point(6, 6);
        UIG.Name = "groupBox8";
        UIG.Size = new Size(325, 515);
        UIG.TabIndex = 74;
        UIG.TabStop = false;
        UIG.Text = "Stages";
        bIm.Controls.Add(VRg);
        bIm.Controls.Add(VR2);
        bIm.Controls.Add(LR3);
        bIm.Controls.Add(ORd);
        bIm.Controls.Add(lRH);
        bIm.Controls.Add(LR4);
        bIm.Controls.Add(OR5);
        bIm.Controls.Add(HRs);
        bIm.Controls.Add(VRu);
        bIm.Controls.Add(MI0);
        bIm.Controls.Add(VII);
        bIm.Controls.Add(sIR);
        bIm.Controls.Add(tIC);
        bIm.Controls.Add(dIK);
        bIm.Controls.Add(LIU);
        bIm.Controls.Add(AIT);
        bIm.Controls.Add(kI1);
        bIm.Controls.Add(TIW);
        bIm.Controls.Add(rIw);
        bIm.Controls.Add(WIN);
        bIm.Controls.Add(EIY);
        bIm.Controls.Add(pIB);
        bIm.Controls.Add(QIA);
        bIm.Controls.Add(rIf);
        bIm.Controls.Add(vI6);
        bIm.Controls.Add(mIx);
        bIm.Controls.Add(eI9);
        bIm.Location = new Point(6, 236);
        bIm.Name = "groupBox2";
        bIm.Size = new Size(313, 244);
        bIm.TabIndex = 77;
        bIm.TabStop = false;
        bIm.Text = "Finished with :";
        VRg.CustomFormat = "mm:ss";
        VRg.Format = DateTimePickerFormat.Custom;
        VRg.Location = new Point(253, 216);
        VRg.Name = "DTP_Weapon8";
        VRg.ShowUpDown = true;
        VRg.Size = new Size(49, 20);
        VRg.TabIndex = 92;
        VRg.Value = new DateTime(2018, 3, 17, 0, 0, 0, 0);
        VR2.CustomFormat = "mm:ss";
        VR2.Format = DateTimePickerFormat.Custom;
        VR2.Location = new Point(132, 216);
        VR2.Name = "DTP_Weapon7";
        VR2.ShowUpDown = true;
        VR2.Size = new Size(49, 20);
        VR2.TabIndex = 91;
        VR2.Value = new DateTime(2018, 3, 17, 0, 0, 0, 0);
        LR3.CustomFormat = "mm:ss";
        LR3.Format = DateTimePickerFormat.Custom;
        LR3.Location = new Point(22, 216);
        LR3.Name = "DTP_Weapon6";
        LR3.ShowUpDown = true;
        LR3.Size = new Size(49, 20);
        LR3.TabIndex = 90;
        LR3.Value = new DateTime(2018, 3, 17, 0, 0, 0, 0);
        ORd.CustomFormat = "mm:ss";
        ORd.Format = DateTimePickerFormat.Custom;
        ORd.Location = new Point(253, 140);
        ORd.Name = "DTP_Weapon5";
        ORd.ShowUpDown = true;
        ORd.Size = new Size(49, 20);
        ORd.TabIndex = 89;
        ORd.Value = new DateTime(2018, 3, 17, 0, 0, 0, 0);
        lRH.CustomFormat = "mm:ss";
        lRH.Format = DateTimePickerFormat.Custom;
        lRH.Location = new Point(132, 140);
        lRH.Name = "DTP_Weapon4";
        lRH.ShowUpDown = true;
        lRH.Size = new Size(49, 20);
        lRH.TabIndex = 88;
        lRH.Value = new DateTime(2018, 3, 17, 0, 0, 0, 0);
        LR4.CustomFormat = "mm:ss";
        LR4.Format = DateTimePickerFormat.Custom;
        LR4.Location = new Point(22, 140);
        LR4.Name = "DTP_Weapon3";
        LR4.ShowUpDown = true;
        LR4.Size = new Size(49, 20);
        LR4.TabIndex = 87;
        LR4.Value = new DateTime(2018, 3, 17, 0, 0, 0, 0);
        OR5.CustomFormat = "mm:ss";
        OR5.Format = DateTimePickerFormat.Custom;
        OR5.Location = new Point(253, 65);
        OR5.Name = "DTP_Weapon2";
        OR5.ShowUpDown = true;
        OR5.Size = new Size(49, 20);
        OR5.TabIndex = 86;
        OR5.Value = new DateTime(2018, 3, 17, 0, 0, 0, 0);
        HRs.CustomFormat = "mm:ss";
        HRs.Format = DateTimePickerFormat.Custom;
        HRs.Location = new Point(132, 65);
        HRs.Name = "DTP_Weapon1";
        HRs.ShowUpDown = true;
        HRs.Size = new Size(49, 20);
        HRs.TabIndex = 85;
        HRs.Value = new DateTime(2018, 3, 17, 0, 0, 0, 0);
        VRu.CustomFormat = "mm:ss";
        VRu.Format = DateTimePickerFormat.Custom;
        VRu.Location = new Point(22, 65);
        VRu.Name = "DTP_Weapon0";
        VRu.ShowUpDown = true;
        VRu.Size = new Size(49, 20);
        VRu.TabIndex = 84;
        VRu.Value = new DateTime(2018, 3, 17, 0, 0, 0, 0);
        MI0.AutoSize = true;
        MI0.Location = new Point(235, 183);
        MI0.Name = "CB_Weapon8";
        MI0.Size = new Size(15, 14);
        MI0.TabIndex = 26;
        MI0.UseVisualStyleBackColor = true;
        MI0.CheckedChanged += KIE;
        VII.BackColor = Color.Transparent;
        VII.Enabled = false;
        VII.Image = Resources.Wst_Roller_MissionBrushNormalLv0_Splat2;
        VII.Location = new Point(256, 170);
        VII.Name = "PB_WeaponStage8";
        VII.Size = new Size(40, 40);
        VII.SizeMode = PictureBoxSizeMode.Zoom;
        VII.TabIndex = 25;
        VII.TabStop = false;
        VII.Tag = "UBo.YBl";
        sIR.AutoSize = true;
        sIR.Location = new Point(115, 183);
        sIR.Name = "CB_Weapon7";
        sIR.Size = new Size(15, 14);
        sIR.TabIndex = 24;
        sIR.UseVisualStyleBackColor = true;
        sIR.CheckedChanged += b0z;
        tIC.BackColor = Color.Transparent;
        tIC.Enabled = false;
        tIC.Image = Resources.Wst_Slosher_MissionStrongLv0_Splat2;
        tIC.Location = new Point(136, 170);
        tIC.Name = "PB_WeaponStage7";
        tIC.Size = new Size(40, 40);
        tIC.SizeMode = PictureBoxSizeMode.Zoom;
        tIC.TabIndex = 23;
        tIC.TabStop = false;
        tIC.Tag = "UBo.YBl";
        dIK.AutoSize = true;
        dIK.Location = new Point(4, 183);
        dIK.Name = "CB_Weapon6";
        dIK.Size = new Size(15, 14);
        dIK.TabIndex = 22;
        dIK.UseVisualStyleBackColor = true;
        dIK.CheckedChanged += u0j;
        LIU.BackColor = Color.Transparent;
        LIU.Enabled = false;
        LIU.Image = Resources.Wst_Shooter_BlasterMissionMiddleLv0_Splat2;
        LIU.Location = new Point(25, 170);
        LIU.Name = "PB_WeaponStage6";
        LIU.Size = new Size(40, 40);
        LIU.SizeMode = PictureBoxSizeMode.Zoom;
        LIU.TabIndex = 21;
        LIU.TabStop = false;
        LIU.Tag = "UBo.YBl";
        AIT.AutoSize = true;
        AIT.Location = new Point(235, 107);
        AIT.Name = "CB_Weapon5";
        AIT.Size = new Size(15, 14);
        AIT.TabIndex = 20;
        AIT.UseVisualStyleBackColor = true;
        AIT.CheckedChanged += e0a;
        kI1.BackColor = Color.Transparent;
        kI1.Enabled = false;
        kI1.Image = Resources.Wst_Spinner_MissionStandardLv0_Splat2;
        kI1.Location = new Point(256, 94);
        kI1.Name = "PB_WeaponStage5";
        kI1.Size = new Size(40, 40);
        kI1.SizeMode = PictureBoxSizeMode.Zoom;
        kI1.TabIndex = 19;
        kI1.TabStop = false;
        kI1.Tag = "UBo.YBl";
        TIW.AutoSize = true;
        TIW.Location = new Point(115, 107);
        TIW.Name = "CB_Weapon4";
        TIW.Size = new Size(15, 14);
        TIW.TabIndex = 18;
        TIW.UseVisualStyleBackColor = true;
        TIW.CheckedChanged += h0Z;
        rIw.BackColor = Color.Transparent;
        rIw.Enabled = false;
        rIw.Image = Resources.Wst_Umbrella_MissionNormalLv0_Splat2;
        rIw.Location = new Point(136, 94);
        rIw.Name = "PB_WeaponStage4";
        rIw.Size = new Size(40, 40);
        rIw.SizeMode = PictureBoxSizeMode.Zoom;
        rIw.TabIndex = 17;
        rIw.TabStop = false;
        rIw.Tag = "UBo.YBl";
        WIN.AutoSize = true;
        WIN.Location = new Point(4, 107);
        WIN.Name = "CB_Weapon3";
        WIN.Size = new Size(15, 14);
        WIN.TabIndex = 16;
        WIN.UseVisualStyleBackColor = true;
        WIN.CheckedChanged += h0s;
        EIY.BackColor = Color.Transparent;
        EIY.Enabled = false;
        EIY.Image = Resources.Wst_Twins_MissionNormalLv0_Splat2;
        EIY.Location = new Point(25, 94);
        EIY.Name = "PB_WeaponStage3";
        EIY.Size = new Size(40, 40);
        EIY.SizeMode = PictureBoxSizeMode.Zoom;
        EIY.TabIndex = 15;
        EIY.TabStop = false;
        EIY.Tag = "UBo.YBl";
        pIB.AutoSize = true;
        pIB.Location = new Point(235, 34);
        pIB.Name = "CB_Weapon2";
        pIB.Size = new Size(15, 14);
        pIB.TabIndex = 14;
        pIB.UseVisualStyleBackColor = true;
        pIB.CheckedChanged += m05;
        QIA.BackColor = Color.Transparent;
        QIA.Enabled = false;
        QIA.Image = Resources.Wst_Charger_MissionNormalLv0_Splat2;
        QIA.Location = new Point(256, 19);
        QIA.Name = "PB_WeaponStage2";
        QIA.Size = new Size(40, 40);
        QIA.SizeMode = PictureBoxSizeMode.Zoom;
        QIA.TabIndex = 13;
        QIA.TabStop = false;
        QIA.Tag = "UBo.YBl";
        rIf.AutoSize = true;
        rIf.Location = new Point(115, 34);
        rIf.Name = "CB_Weapon1";
        rIf.Size = new Size(15, 14);
        rIf.TabIndex = 12;
        rIf.UseVisualStyleBackColor = true;
        rIf.CheckedChanged += u04;
        vI6.BackColor = Color.Transparent;
        vI6.Enabled = false;
        vI6.Image = Resources.Wst_Roller_MissionNormalLv0_Splat2;
        vI6.Location = new Point(136, 19);
        vI6.Name = "PB_WeaponStage1";
        vI6.Size = new Size(40, 40);
        vI6.SizeMode = PictureBoxSizeMode.Zoom;
        vI6.TabIndex = 11;
        vI6.TabStop = false;
        vI6.Tag = "UBo.YBl";
        mIx.AutoSize = true;
        mIx.Location = new Point(4, 34);
        mIx.Name = "CB_Weapon0";
        mIx.Size = new Size(15, 14);
        mIx.TabIndex = 10;
        mIx.UseVisualStyleBackColor = true;
        mIx.CheckedChanged += m0H;
        eI9.BackColor = Color.Transparent;
        eI9.Enabled = false;
        eI9.Image = Resources.Wst_Shooter_MissionNormalLv2_Splat2;
        eI9.Location = new Point(25, 19);
        eI9.Name = "PB_WeaponStage0";
        eI9.Size = new Size(40, 40);
        eI9.SizeMode = PictureBoxSizeMode.Zoom;
        eI9.TabIndex = 9;
        eI9.TabStop = false;
        eI9.Tag = "UBo.YBl";
        sIi.Controls.Add(WIc);
        sIi.Controls.Add(qIy);
        sIi.Controls.Add(gIo);
        sIi.Controls.Add(PIe);
        sIi.Controls.Add(FIn);
        sIi.Controls.Add(EIV);
        sIi.Location = new Point(117, 151);
        sIi.Name = "groupBox1";
        sIi.Size = new Size(200, 65);
        sIi.TabIndex = 76;
        sIi.TabStop = false;
        WIc.BackColor = Color.Transparent;
        WIc.Enabled = false;
        WIc.Image = Resources.CourseIcon_02_Splat2;
        WIc.Location = new Point(150, 18);
        WIc.Name = "pic_metalFish";
        WIc.Size = new Size(35, 35);
        WIc.SizeMode = PictureBoxSizeMode.Zoom;
        WIc.TabIndex = 9;
        WIc.TabStop = false;
        WIc.Tag = "UBo.YBl";
        qIy.AutoSize = true;
        qIy.Location = new Point(130, 30);
        qIy.Name = "CB_MetalFish";
        qIy.Size = new Size(15, 14);
        qIy.TabIndex = 10;
        qIy.UseVisualStyleBackColor = true;
        gIo.BackColor = Color.Transparent;
        gIo.Enabled = false;
        gIo.Image = Resources.CourseIcon_04_Splat2;
        gIo.Location = new Point(86, 18);
        gIo.Name = "pic_sunkenRoll";
        gIo.Size = new Size(35, 35);
        gIo.SizeMode = PictureBoxSizeMode.Zoom;
        gIo.TabIndex = 4;
        gIo.TabStop = false;
        gIo.Tag = "UBo.YBl";
        PIe.AutoSize = true;
        PIe.Location = new Point(66, 30);
        PIe.Name = "CB_Scroll";
        PIe.Size = new Size(15, 14);
        PIe.TabIndex = 5;
        PIe.UseVisualStyleBackColor = true;
        FIn.BackColor = Color.Transparent;
        FIn.Enabled = false;
        FIn.Image = Resources.DenchiNamazu_00_Splat2;
        FIn.Location = new Point(25, 18);
        FIn.Name = "pic_zapfish";
        FIn.Size = new Size(35, 35);
        FIn.SizeMode = PictureBoxSizeMode.Zoom;
        FIn.TabIndex = 8;
        FIn.TabStop = false;
        FIn.Tag = "UBo.YBl";
        EIV.AutoSize = true;
        EIV.Location = new Point(10, 30);
        EIV.Name = "CB_Zapfish";
        EIV.Size = new Size(15, 14);
        EIV.TabIndex = 7;
        EIV.UseVisualStyleBackColor = true;
        zIb.Location = new Point(247, 486);
        zIb.Name = "B_SaveStage";
        zIb.Size = new Size(72, 23);
        zIb.TabIndex = 13;
        zIb.Text = "Save Stage";
        zIb.UseVisualStyleBackColor = true;
        zIb.Click += o00;
        sIv.FormattingEnabled = true;
        sIv.Items.AddRange(new object[32] { "Stage 01", "Stage 02", "Stage 03", "Boss 01", "Stage 04", "Stage 05", "Stage 06", "Stage 07", "Stage 08", "Stage 09", "Boss 02", "Stage 10", "Stage 11", "Stage 12", "Stage 13", "Stage 14", "Stage 15", "Boss 03", "Stage 16", "Stage 17", "Stage 18", "Stage 19", "Stage 20", "Stage 21", "Boss 04", "Stage 22", "Stage 23", "Stage 24", "Stage 25", "Stage 26", "Stage 27", "Boss 05" });
        sIv.Location = new Point(6, 18);
        sIv.Name = "LB_Stages";
        sIv.Size = new Size(105, 212);
        sIv.TabIndex = 11;
        sIv.SelectedIndexChanged += T0m;
        JIt.BorderStyle = BorderStyle.FixedSingle;
        JIt.Enabled = false;
        JIt.Image = Resources.Stage_01_Splat2;
        JIt.Location = new Point(179, 17);
        JIt.Name = "PB_StagePic";
        JIt.Size = new Size(70, 70);
        JIt.SizeMode = PictureBoxSizeMode.Zoom;
        JIt.TabIndex = 0;
        JIt.TabStop = false;
        JIt.Tag = "";
        tIO.BackColor = Color.Transparent;
        tIO.Enabled = false;
        tIO.Image = Resources.pot;
        tIO.Location = new Point(199, 96);
        tIO.Name = "PB_Pot";
        tIO.Size = new Size(35, 35);
        tIO.SizeMode = PictureBoxSizeMode.Zoom;
        tIO.TabIndex = 9;
        tIO.TabStop = false;
        tIO.Tag = "UBo.YBl";
        UI8.AutoSize = true;
        UI8.Location = new Point(183, 106);
        UI8.Name = "CB_Pot";
        UI8.Size = new Size(15, 14);
        UI8.TabIndex = 10;
        UI8.UseVisualStyleBackColor = true;
        UI8.CheckedChanged += O03;
        zIQ.Controls.Add(cIF);
        zIQ.Controls.Add(CIL);
        zIQ.Controls.Add(WIJ);
        zIQ.Controls.Add(zI7);
        zIQ.Controls.Add(iIP);
        zIQ.Location = new Point(337, 12);
        zIQ.Name = "PB_Sector3Metal";
        zIQ.SelectedIndex = 0;
        zIQ.Size = new Size(263, 81);
        zIQ.TabIndex = 75;
        cIF.Controls.Add(VIr);
        cIF.Controls.Add(pRR);
        cIF.Controls.Add(DIq);
        cIF.Controls.Add(DRC);
        cIF.Location = new Point(4, 22);
        cIF.Name = "tabPage1";
        cIF.Padding = new Padding(3);
        cIF.Size = new Size(255, 55);
        cIF.TabIndex = 0;
        cIF.Text = "Sector 1";
        cIF.UseVisualStyleBackColor = true;
        VIr.BackColor = Color.Transparent;
        VIr.Enabled = false;
        VIr.Image = Resources.CourseIcon_02_Splat2;
        VIr.Location = new Point(160, 10);
        VIr.Name = "PB_Sector1Metal";
        VIr.Size = new Size(35, 35);
        VIr.SizeMode = PictureBoxSizeMode.Zoom;
        VIr.TabIndex = 13;
        VIr.TabStop = false;
        VIr.Tag = "UBo.YBl";
        pRR.AutoSize = true;
        pRR.Location = new Point(140, 22);
        pRR.Name = "CB_Sector1Metal";
        pRR.Size = new Size(15, 14);
        pRR.TabIndex = 14;
        pRR.UseVisualStyleBackColor = true;
        DIq.BackColor = Color.Transparent;
        DIq.Enabled = false;
        DIq.Image = Resources.CourseIcon_04_Splat2;
        DIq.Location = new Point(79, 10);
        DIq.Name = "PB_Sector1Scroll";
        DIq.Size = new Size(35, 35);
        DIq.SizeMode = PictureBoxSizeMode.Zoom;
        DIq.TabIndex = 11;
        DIq.TabStop = false;
        DIq.Tag = "UBo.YBl";
        DRC.AutoSize = true;
        DRC.Location = new Point(59, 22);
        DRC.Name = "CB_Sector1Scroll";
        DRC.Size = new Size(15, 14);
        DRC.TabIndex = 12;
        DRC.UseVisualStyleBackColor = true;
        CIL.Controls.Add(LIM);
        CIL.Controls.Add(MRK);
        CIL.Controls.Add(dIu);
        CIL.Controls.Add(eRU);
        CIL.Location = new Point(4, 22);
        CIL.Name = "tabPage2";
        CIL.Padding = new Padding(3);
        CIL.Size = new Size(255, 55);
        CIL.TabIndex = 1;
        CIL.Text = "Sector 2";
        CIL.UseVisualStyleBackColor = true;
        LIM.BackColor = Color.Transparent;
        LIM.Enabled = false;
        LIM.Image = Resources.CourseIcon_02_Splat2;
        LIM.Location = new Point(160, 10);
        LIM.Name = "PB_Sector2Metal";
        LIM.Size = new Size(35, 35);
        LIM.SizeMode = PictureBoxSizeMode.Zoom;
        LIM.TabIndex = 17;
        LIM.TabStop = false;
        LIM.Tag = "UBo.YBl";
        MRK.AutoSize = true;
        MRK.Location = new Point(140, 22);
        MRK.Name = "CB_Sector2Metal";
        MRK.Size = new Size(15, 14);
        MRK.TabIndex = 18;
        MRK.UseVisualStyleBackColor = true;
        dIu.BackColor = Color.Transparent;
        dIu.Enabled = false;
        dIu.Image = Resources.CourseIcon_04_Splat2;
        dIu.Location = new Point(79, 10);
        dIu.Name = "PB_Sector2Scroll";
        dIu.Size = new Size(35, 35);
        dIu.SizeMode = PictureBoxSizeMode.Zoom;
        dIu.TabIndex = 15;
        dIu.TabStop = false;
        dIu.Tag = "UBo.YBl";
        eRU.AutoSize = true;
        eRU.Location = new Point(59, 22);
        eRU.Name = "CB_Sector2Scroll";
        eRU.Size = new Size(15, 14);
        eRU.TabIndex = 16;
        eRU.UseVisualStyleBackColor = true;
        WIJ.Controls.Add(pIg);
        WIJ.Controls.Add(VRT);
        WIJ.Controls.Add(wI2);
        WIJ.Controls.Add(eR1);
        WIJ.Location = new Point(4, 22);
        WIJ.Name = "tabPage3";
        WIJ.Size = new Size(255, 55);
        WIJ.TabIndex = 2;
        WIJ.Text = "Sector 3";
        WIJ.UseVisualStyleBackColor = true;
        pIg.BackColor = Color.Transparent;
        pIg.Enabled = false;
        pIg.Image = Resources.CourseIcon_02_Splat2;
        pIg.Location = new Point(160, 10);
        pIg.Name = "pictureBox16";
        pIg.Size = new Size(35, 35);
        pIg.SizeMode = PictureBoxSizeMode.Zoom;
        pIg.TabIndex = 17;
        pIg.TabStop = false;
        pIg.Tag = "UBo.YBl";
        VRT.AutoSize = true;
        VRT.Location = new Point(140, 22);
        VRT.Name = "CB_Sector3Metal";
        VRT.Size = new Size(15, 14);
        VRT.TabIndex = 18;
        VRT.UseVisualStyleBackColor = true;
        wI2.BackColor = Color.Transparent;
        wI2.Enabled = false;
        wI2.Image = Resources.CourseIcon_04_Splat2;
        wI2.Location = new Point(79, 10);
        wI2.Name = "PB_Sector3Scroll";
        wI2.Size = new Size(35, 35);
        wI2.SizeMode = PictureBoxSizeMode.Zoom;
        wI2.TabIndex = 15;
        wI2.TabStop = false;
        wI2.Tag = "UBo.YBl";
        eR1.AutoSize = true;
        eR1.Location = new Point(59, 22);
        eR1.Name = "CB_Sector3Scroll";
        eR1.Size = new Size(15, 14);
        eR1.TabIndex = 16;
        eR1.UseVisualStyleBackColor = true;
        zI7.Controls.Add(iI3);
        zI7.Controls.Add(MRW);
        zI7.Controls.Add(XId);
        zI7.Controls.Add(JRw);
        zI7.Location = new Point(4, 22);
        zI7.Name = "tabPage4";
        zI7.Size = new Size(255, 55);
        zI7.TabIndex = 3;
        zI7.Text = "Sector 4";
        zI7.UseVisualStyleBackColor = true;
        iI3.BackColor = Color.Transparent;
        iI3.Enabled = false;
        iI3.Image = Resources.CourseIcon_02_Splat2;
        iI3.Location = new Point(160, 10);
        iI3.Name = "PB_Sector4Metal";
        iI3.Size = new Size(35, 35);
        iI3.SizeMode = PictureBoxSizeMode.Zoom;
        iI3.TabIndex = 17;
        iI3.TabStop = false;
        iI3.Tag = "UBo.YBl";
        MRW.AutoSize = true;
        MRW.Location = new Point(140, 22);
        MRW.Name = "CB_Sector4Metal";
        MRW.Size = new Size(15, 14);
        MRW.TabIndex = 18;
        MRW.UseVisualStyleBackColor = true;
        XId.BackColor = Color.Transparent;
        XId.Enabled = false;
        XId.Image = Resources.CourseIcon_04_Splat2;
        XId.Location = new Point(79, 10);
        XId.Name = "PB_Sector4Scroll";
        XId.Size = new Size(35, 35);
        XId.SizeMode = PictureBoxSizeMode.Zoom;
        XId.TabIndex = 15;
        XId.TabStop = false;
        XId.Tag = "UBo.YBl";
        JRw.AutoSize = true;
        JRw.Location = new Point(59, 22);
        JRw.Name = "CB_Sector4Scroll";
        JRw.Size = new Size(15, 14);
        JRw.TabIndex = 16;
        JRw.UseVisualStyleBackColor = true;
        iIP.Controls.Add(aIH);
        iIP.Controls.Add(nRN);
        iIP.Controls.Add(HI4);
        iIP.Controls.Add(VRY);
        iIP.Location = new Point(4, 22);
        iIP.Name = "tabPage5";
        iIP.Size = new Size(255, 55);
        iIP.TabIndex = 4;
        iIP.Text = "Sector 5";
        iIP.UseVisualStyleBackColor = true;
        aIH.BackColor = Color.Transparent;
        aIH.Enabled = false;
        aIH.Image = Resources.CourseIcon_02_Splat2;
        aIH.Location = new Point(160, 10);
        aIH.Name = "PB_Sector5Metal";
        aIH.Size = new Size(35, 35);
        aIH.SizeMode = PictureBoxSizeMode.Zoom;
        aIH.TabIndex = 17;
        aIH.TabStop = false;
        aIH.Tag = "UBo.YBl";
        nRN.AutoSize = true;
        nRN.Location = new Point(140, 22);
        nRN.Name = "CB_Sector5Metal";
        nRN.Size = new Size(15, 14);
        nRN.TabIndex = 18;
        nRN.UseVisualStyleBackColor = true;
        HI4.BackColor = Color.Transparent;
        HI4.Enabled = false;
        HI4.Image = Resources.CourseIcon_04_Splat2;
        HI4.Location = new Point(79, 10);
        HI4.Name = "PB_Sector5Scroll";
        HI4.Size = new Size(35, 35);
        HI4.SizeMode = PictureBoxSizeMode.Zoom;
        HI4.TabIndex = 15;
        HI4.TabStop = false;
        HI4.Tag = "UBo.YBl";
        VRY.AutoSize = true;
        VRY.Location = new Point(59, 22);
        VRY.Name = "CB_Sector5Scroll";
        VRY.Size = new Size(15, 14);
        VRY.TabIndex = 16;
        VRY.UseVisualStyleBackColor = true;
        XIk.Image = Resources.Wst_Shooter_MissionNormalLv0_Splat2;
        XIk.Location = new Point(6, 19);
        XIk.Name = "PB_H0";
        XIk.Size = new Size(60, 60);
        XIk.SizeMode = PictureBoxSizeMode.Zoom;
        XIk.TabIndex = 76;
        XIk.TabStop = false;
        gRB.Location = new Point(30, 102);
        gRB.Maximum = new decimal(new int[4] { 3, 0, 0, 0 });
        gRB.Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
        gRB.Name = "NUD_lvlShot";
        gRB.Size = new Size(30, 20);
        gRB.TabIndex = 77;
        gRB.Value = new decimal(new int[4] { 1, 0, 0, 0 });
        gRB.ValueChanged += t0w;
        aRA.AutoSize = true;
        aRA.Checked = true;
        aRA.CheckState = CheckState.Checked;
        aRA.Enabled = false;
        aRA.Location = new Point(3, 84);
        aRA.Name = "CB_unlockShot";
        aRA.Size = new Size(72, 17);
        aRA.TabIndex = 78;
        aRA.Text = "Unlocked";
        aRA.UseVisualStyleBackColor = true;
        AI5.Controls.Add(eRj);
        AI5.Controls.Add(lRz);
        AI5.Controls.Add(MIs);
        AI5.Controls.Add(CRf);
        AI5.Controls.Add(YIZ);
        AI5.Controls.Add(qR6);
        AI5.Controls.Add(fIa);
        AI5.Controls.Add(SRx);
        AI5.Controls.Add(DIj);
        AI5.Controls.Add(lR9);
        AI5.Controls.Add(YRc);
        AI5.Controls.Add(XIk);
        AI5.Controls.Add(gRB);
        AI5.Controls.Add(aRA);
        AI5.Location = new Point(337, 95);
        AI5.Name = "groupBox3";
        AI5.Size = new Size(440, 127);
        AI5.TabIndex = 79;
        AI5.TabStop = false;
        AI5.Text = "Hero Set";
        eRj.AutoSize = true;
        eRj.Location = new Point(95, 106);
        eRj.Name = "label2";
        eRj.Size = new Size(22, 13);
        eRj.TabIndex = 92;
        eRj.Text = "Lv.";
        lRz.AutoSize = true;
        lRz.Location = new Point(6, 106);
        lRz.Name = "label1";
        lRz.Size = new Size(22, 13);
        lRz.TabIndex = 91;
        lRz.Text = "Lv.";
        MIs.Image = Resources.Wsb_Bomb_Robo_Splat2;
        MIs.Location = new Point(364, 19);
        MIs.Name = "PB_H4";
        MIs.Size = new Size(60, 60);
        MIs.SizeMode = PictureBoxSizeMode.Zoom;
        MIs.TabIndex = 88;
        MIs.TabStop = false;
        CRf.AutoSize = true;
        CRf.Location = new Point(359, 85);
        CRf.Name = "CB_unlockB2";
        CRf.Size = new Size(72, 17);
        CRf.TabIndex = 90;
        CRf.Text = "Unlocked";
        CRf.UseVisualStyleBackColor = true;
        YIZ.Image = Resources.Wsb_Bomb_CurlingLv0_Splat2;
        YIZ.Location = new Point(274, 19);
        YIZ.Name = "PB_H3";
        YIZ.Size = new Size(60, 60);
        YIZ.SizeMode = PictureBoxSizeMode.Zoom;
        YIZ.TabIndex = 85;
        YIZ.TabStop = false;
        qR6.AutoSize = true;
        qR6.Location = new Point(270, 85);
        qR6.Name = "CB_unlockB1";
        qR6.Size = new Size(72, 17);
        qR6.TabIndex = 87;
        qR6.Text = "Unlocked";
        qR6.UseVisualStyleBackColor = true;
        fIa.Image = Resources.Wsb_Bomb_Msn0Lv0_Splat2;
        fIa.Location = new Point(185, 19);
        fIa.Name = "PB_H2";
        fIa.Size = new Size(60, 60);
        fIa.SizeMode = PictureBoxSizeMode.Zoom;
        fIa.TabIndex = 82;
        fIa.TabStop = false;
        SRx.AutoSize = true;
        SRx.Checked = true;
        SRx.CheckState = CheckState.Checked;
        SRx.Enabled = false;
        SRx.Location = new Point(180, 85);
        SRx.Name = "CB_unlockB0";
        SRx.Size = new Size(72, 17);
        SRx.TabIndex = 84;
        SRx.Text = "Unlocked";
        SRx.UseVisualStyleBackColor = true;
        DIj.Image = Resources.Tnk_Msn0Lv0_Splat2;
        DIj.Location = new Point(96, 19);
        DIj.Name = "PB_H1";
        DIj.Size = new Size(60, 60);
        DIj.SizeMode = PictureBoxSizeMode.Zoom;
        DIj.TabIndex = 79;
        DIj.TabStop = false;
        lR9.Location = new Point(120, 102);
        lR9.Maximum = new decimal(new int[4] { 3, 0, 0, 0 });
        lR9.Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
        lR9.Name = "NUD_lvlTnk";
        lR9.Size = new Size(30, 20);
        lR9.TabIndex = 80;
        lR9.Value = new decimal(new int[4] { 1, 0, 0, 0 });
        lR9.ValueChanged += H0N;
        YRc.AutoSize = true;
        YRc.Checked = true;
        YRc.CheckState = CheckState.Checked;
        YRc.Enabled = false;
        YRc.Location = new Point(92, 85);
        YRc.Name = "CB_unlockTnk";
        YRc.Size = new Size(72, 17);
        YRc.TabIndex = 81;
        YRc.Text = "Unlocked";
        YRc.UseVisualStyleBackColor = true;
        FIz.Controls.Add(rCE);
        FIz.Controls.Add(ACD);
        FIz.Controls.Add(OCX);
        FIz.Controls.Add(nCp);
        FIz.Controls.Add(fCS);
        FIz.Controls.Add(xCh);
        FIz.Controls.Add(rCl);
        FIz.Controls.Add(uCG);
        FIz.Controls.Add(zRO);
        FIz.Controls.Add(hRe);
        FIz.Controls.Add(ARD);
        FIz.Controls.Add(VR8);
        FIz.Controls.Add(CRn);
        FIz.Controls.Add(XRX);
        FIz.Controls.Add(PRQ);
        FIz.Controls.Add(BRF);
        FIz.Controls.Add(KRp);
        FIz.Controls.Add(pRL);
        FIz.Controls.Add(aRJ);
        FIz.Controls.Add(CRS);
        FIz.Controls.Add(jR7);
        FIz.Controls.Add(kRP);
        FIz.Controls.Add(IRh);
        FIz.Controls.Add(uRi);
        FIz.Controls.Add(ARm);
        FIz.Controls.Add(IRl);
        FIz.Controls.Add(oR0);
        FIz.Controls.Add(jRI);
        FIz.Controls.Add(aRG);
        FIz.Controls.Add(oRt);
        FIz.Controls.Add(DRV);
        FIz.Controls.Add(NRE);
        FIz.Location = new Point(337, 228);
        FIz.Name = "groupBox4";
        FIz.Size = new Size(440, 202);
        FIz.TabIndex = 80;
        FIz.TabStop = false;
        FIz.Text = "Other Weapons";
        rCE.AutoSize = true;
        rCE.Location = new Point(405, 138);
        rCE.Name = "label7";
        rCE.Size = new Size(22, 13);
        rCE.TabIndex = 109;
        rCE.Text = "Lv.";
        ACD.AutoSize = true;
        ACD.Location = new Point(296, 137);
        ACD.Name = "label8";
        ACD.Size = new Size(22, 13);
        ACD.TabIndex = 108;
        ACD.Text = "Lv.";
        OCX.AutoSize = true;
        OCX.Location = new Point(182, 137);
        OCX.Name = "label9";
        OCX.Size = new Size(22, 13);
        OCX.TabIndex = 107;
        OCX.Text = "Lv.";
        nCp.AutoSize = true;
        nCp.Location = new Point(73, 137);
        nCp.Name = "label10";
        nCp.Size = new Size(22, 13);
        nCp.TabIndex = 106;
        nCp.Text = "Lv.";
        fCS.AutoSize = true;
        fCS.Location = new Point(405, 48);
        fCS.Name = "label6";
        fCS.Size = new Size(22, 13);
        fCS.TabIndex = 105;
        fCS.Text = "Lv.";
        xCh.AutoSize = true;
        xCh.Location = new Point(296, 47);
        xCh.Name = "label5";
        xCh.Size = new Size(22, 13);
        xCh.TabIndex = 104;
        xCh.Text = "Lv.";
        rCl.AutoSize = true;
        rCl.Location = new Point(182, 47);
        rCl.Name = "label4";
        rCl.Size = new Size(22, 13);
        rCl.TabIndex = 103;
        rCl.Text = "Lv.";
        uCG.AutoSize = true;
        uCG.Location = new Point(73, 47);
        uCG.Name = "label3";
        uCG.Size = new Size(22, 13);
        uCG.TabIndex = 102;
        uCG.Text = "Lv.";
        zRO.Location = new Point(404, 114);
        zRO.Maximum = new decimal(new int[4] { 2, 0, 0, 0 });
        zRO.Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
        zRO.Name = "NUD_WeaponH7";
        zRO.Size = new Size(26, 20);
        zRO.TabIndex = 100;
        zRO.Value = new decimal(new int[4] { 1, 0, 0, 0 });
        zRO.ValueChanged += A0c;
        hRe.AutoSize = true;
        hRe.Location = new Point(338, 180);
        hRe.Name = "CB_WeaponH7";
        hRe.Size = new Size(72, 17);
        hRe.TabIndex = 101;
        hRe.Text = "Unlocked";
        hRe.UseVisualStyleBackColor = true;
        hRe.CheckedChanged += w02;
        ARD.Image = Resources.Wst_Roller_MissionBrushNormalLv0_Splat2;
        ARD.Location = new Point(338, 114);
        ARD.Name = "PB_WeaponH7";
        ARD.Size = new Size(60, 60);
        ARD.SizeMode = PictureBoxSizeMode.Zoom;
        ARD.TabIndex = 99;
        ARD.TabStop = false;
        VR8.Location = new Point(295, 114);
        VR8.Maximum = new decimal(new int[4] { 2, 0, 0, 0 });
        VR8.Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
        VR8.Name = "NUD_WeaponH6";
        VR8.Size = new Size(26, 20);
        VR8.TabIndex = 97;
        VR8.Value = new decimal(new int[4] { 1, 0, 0, 0 });
        VR8.ValueChanged += A09;
        CRn.AutoSize = true;
        CRn.Location = new Point(229, 180);
        CRn.Name = "CB_WeaponH6";
        CRn.Size = new Size(72, 17);
        CRn.TabIndex = 98;
        CRn.Text = "Unlocked";
        CRn.UseVisualStyleBackColor = true;
        CRn.CheckedChanged += K0g;
        XRX.Image = Resources.Wst_Slosher_MissionStrongLv0_Splat2;
        XRX.Location = new Point(229, 114);
        XRX.Name = "PB_WeaponH6";
        XRX.Size = new Size(60, 60);
        XRX.SizeMode = PictureBoxSizeMode.Zoom;
        XRX.TabIndex = 96;
        XRX.TabStop = false;
        PRQ.Location = new Point(181, 114);
        PRQ.Maximum = new decimal(new int[4] { 2, 0, 0, 0 });
        PRQ.Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
        PRQ.Name = "NUD_WeaponH5";
        PRQ.Size = new Size(26, 20);
        PRQ.TabIndex = 94;
        PRQ.Value = new decimal(new int[4] { 1, 0, 0, 0 });
        PRQ.ValueChanged += R0x;
        BRF.AutoSize = true;
        BRF.Location = new Point(115, 180);
        BRF.Name = "CB_WeaponH5";
        BRF.Size = new Size(72, 17);
        BRF.TabIndex = 95;
        BRF.Text = "Unlocked";
        BRF.UseVisualStyleBackColor = true;
        BRF.CheckedChanged += o0u;
        KRp.Image = Resources.Wst_Shooter_BlasterMissionMiddleLv0_Splat2;
        KRp.Location = new Point(115, 114);
        KRp.Name = "PB_WeaponH5";
        KRp.Size = new Size(60, 60);
        KRp.SizeMode = PictureBoxSizeMode.Zoom;
        KRp.TabIndex = 93;
        KRp.TabStop = false;
        pRL.Location = new Point(72, 114);
        pRL.Maximum = new decimal(new int[4] { 2, 0, 0, 0 });
        pRL.Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
        pRL.Name = "NUD_WeaponH4";
        pRL.Size = new Size(26, 20);
        pRL.TabIndex = 91;
        pRL.Value = new decimal(new int[4] { 1, 0, 0, 0 });
        pRL.ValueChanged += k06;
        aRJ.AutoSize = true;
        aRJ.Location = new Point(6, 180);
        aRJ.Name = "CB_WeaponH4";
        aRJ.Size = new Size(72, 17);
        aRJ.TabIndex = 92;
        aRJ.Text = "Unlocked";
        aRJ.UseVisualStyleBackColor = true;
        aRJ.CheckedChanged += v0M;
        CRS.Image = Resources.Wst_Spinner_MissionStandardLv0_Splat2;
        CRS.Location = new Point(6, 114);
        CRS.Name = "PB_WeaponH4";
        CRS.Size = new Size(60, 60);
        CRS.SizeMode = PictureBoxSizeMode.Zoom;
        CRS.TabIndex = 90;
        CRS.TabStop = false;
        jR7.Location = new Point(404, 24);
        jR7.Maximum = new decimal(new int[4] { 2, 0, 0, 0 });
        jR7.Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
        jR7.Name = "NUD_WeaponH3";
        jR7.Size = new Size(26, 20);
        jR7.TabIndex = 88;
        jR7.Value = new decimal(new int[4] { 1, 0, 0, 0 });
        jR7.ValueChanged += e0f;
        kRP.AutoSize = true;
        kRP.Location = new Point(338, 90);
        kRP.Name = "CB_WeaponH3";
        kRP.Size = new Size(72, 17);
        kRP.TabIndex = 89;
        kRP.Text = "Unlocked";
        kRP.UseVisualStyleBackColor = true;
        kRP.CheckedChanged += X0k;
        IRh.Image = Resources.Wst_Umbrella_MissionNormalLv0_Splat2;
        IRh.Location = new Point(338, 24);
        IRh.Name = "PB_WeaponH3";
        IRh.Size = new Size(60, 60);
        IRh.SizeMode = PictureBoxSizeMode.Zoom;
        IRh.TabIndex = 87;
        IRh.TabStop = false;
        uRi.Location = new Point(295, 24);
        uRi.Maximum = new decimal(new int[4] { 2, 0, 0, 0 });
        uRi.Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
        uRi.Name = "NUD_WeaponH2";
        uRi.Size = new Size(26, 20);
        uRi.TabIndex = 85;
        uRi.Value = new decimal(new int[4] { 1, 0, 0, 0 });
        uRi.ValueChanged += r0A;
        ARm.AutoSize = true;
        ARm.Location = new Point(229, 90);
        ARm.Name = "CB_WeaponH2";
        ARm.Size = new Size(72, 17);
        ARm.TabIndex = 86;
        ARm.Text = "Unlocked";
        ARm.UseVisualStyleBackColor = true;
        ARm.CheckedChanged += w0q;
        IRl.Image = Resources.Wst_Twins_MissionNormalLv0_Splat2;
        IRl.Location = new Point(229, 24);
        IRl.Name = "PB_WeaponH2";
        IRl.Size = new Size(60, 60);
        IRl.SizeMode = PictureBoxSizeMode.Zoom;
        IRl.TabIndex = 84;
        IRl.TabStop = false;
        oR0.Location = new Point(181, 24);
        oR0.Maximum = new decimal(new int[4] { 2, 0, 0, 0 });
        oR0.Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
        oR0.Name = "NUD_WeaponH1";
        oR0.Size = new Size(26, 20);
        oR0.TabIndex = 82;
        oR0.Value = new decimal(new int[4] { 1, 0, 0, 0 });
        oR0.ValueChanged += e0B;
        jRI.AutoSize = true;
        jRI.Location = new Point(115, 90);
        jRI.Name = "CB_WeaponH1";
        jRI.Size = new Size(72, 17);
        jRI.TabIndex = 83;
        jRI.Text = "Unlocked";
        jRI.UseVisualStyleBackColor = true;
        jRI.CheckedChanged += u0r;
        aRG.Image = Resources.Wst_Charger_MissionNormalLv0_Splat2;
        aRG.Location = new Point(115, 24);
        aRG.Name = "PB_WeaponH1";
        aRG.Size = new Size(60, 60);
        aRG.SizeMode = PictureBoxSizeMode.Zoom;
        aRG.TabIndex = 81;
        aRG.TabStop = false;
        oRt.Location = new Point(72, 24);
        oRt.Maximum = new decimal(new int[4] { 2, 0, 0, 0 });
        oRt.Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
        oRt.Name = "NUD_WeaponH0";
        oRt.Size = new Size(26, 20);
        oRt.TabIndex = 79;
        oRt.Value = new decimal(new int[4] { 1, 0, 0, 0 });
        oRt.ValueChanged += P0Y;
        DRV.AutoSize = true;
        DRV.Location = new Point(6, 90);
        DRV.Name = "CB_WeaponH0";
        DRV.Size = new Size(72, 17);
        DRV.TabIndex = 80;
        DRV.Text = "Unlocked";
        DRV.UseVisualStyleBackColor = true;
        DRV.CheckedChanged += F0y;
        NRE.Image = Resources.Wst_Roller_MissionNormalLv0_Splat2;
        NRE.Location = new Point(6, 24);
        NRE.Name = "PB_WeaponH0";
        NRE.Size = new Size(60, 60);
        NRE.SizeMode = PictureBoxSizeMode.Zoom;
        NRE.TabIndex = 77;
        NRE.TabStop = false;
        sRb.Location = new Point(733, 506);
        sRb.Name = "B_Close";
        sRb.Size = new Size(43, 23);
        sRb.TabIndex = 81;
        sRb.Text = "Close";
        sRb.UseVisualStyleBackColor = true;
        sRb.Click += A0U;
        IRv.Location = new Point(684, 506);
        IRv.Name = "B_Save";
        IRv.Size = new Size(43, 23);
        IRv.TabIndex = 82;
        IRv.Text = "Save";
        IRv.UseVisualStyleBackColor = true;
        IRv.Click += y0K;
        eRy.Location = new Point(635, 21);
        eRy.Maximum = new decimal(new int[4] { 9999, 0, 0, 0 });
        eRy.Name = "NUD_PowerEggs";
        eRy.Size = new Size(44, 20);
        eRy.TabIndex = 83;
        uRr.BackColor = Color.Gray;
        uRr.BorderStyle = BorderStyle.FixedSingle;
        uRr.Image = Resources.Wsb_Bomb_Robo_Splat2;
        uRr.Location = new Point(409, 475);
        uRr.Name = "PB_changeBom2";
        uRr.Size = new Size(30, 30);
        uRr.SizeMode = PictureBoxSizeMode.Zoom;
        uRr.TabIndex = 87;
        uRr.TabStop = false;
        uRr.Click += b0W;
        ARq.BackColor = Color.Gray;
        ARq.BorderStyle = BorderStyle.FixedSingle;
        ARq.Image = Resources.Wsb_Bomb_CurlingLv0_Splat2;
        ARq.Location = new Point(373, 439);
        ARq.Name = "PB_changeBom1";
        ARq.Size = new Size(30, 30);
        ARq.SizeMode = PictureBoxSizeMode.Zoom;
        ARq.TabIndex = 86;
        ARq.TabStop = false;
        ARq.Click += m01;
        jRk.BackColor = Color.Gray;
        jRk.BorderStyle = BorderStyle.FixedSingle;
        jRk.Image = Resources.Wsb_Bomb_Msn0Lv0_Splat2;
        jRk.Location = new Point(337, 475);
        jRk.Name = "PB_changeBom0";
        jRk.Size = new Size(30, 30);
        jRk.SizeMode = PictureBoxSizeMode.Zoom;
        jRk.TabIndex = 85;
        jRk.TabStop = false;
        jRk.Click += Y0T;
        sRo.Image = Resources.CoopIkuraIcon_01_Splat2;
        sRo.Location = new Point(602, 16);
        sRo.Name = "PB_Eggs";
        sRo.Size = new Size(30, 30);
        sRo.SizeMode = PictureBoxSizeMode.Zoom;
        sRo.TabIndex = 84;
        sRo.TabStop = false;
        CRM.Image = Resources.d_pad;
        CRM.Location = new Point(362, 465);
        CRM.Name = "pic_changeBomCroix";
        CRM.Size = new Size(50, 50);
        CRM.SizeMode = PictureBoxSizeMode.Zoom;
        CRM.TabIndex = 88;
        CRM.TabStop = false;
        dRZ.Location = new Point(635, 57);
        dRZ.Maximum = new decimal(new int[4] { 99, 0, 0, 0 });
        dRZ.Name = "NUD_MetalFish";
        dRZ.Size = new Size(32, 20);
        dRZ.TabIndex = 89;
        NRa.Image = Resources.CourseIcon_02_Splat2;
        NRa.Location = new Point(602, 52);
        NRa.Name = "pictureBox1";
        NRa.Size = new Size(30, 30);
        NRa.SizeMode = PictureBoxSizeMode.Zoom;
        NRa.TabIndex = 90;
        NRa.TabStop = false;
        CCb.Controls.Add(nCv);
        CCb.Controls.Add(OCo);
        CCb.Location = new Point(12, 12);
        CCb.Name = "tabControl1";
        CCb.SelectedIndex = 0;
        CCb.Size = new Size(795, 559);
        CCb.TabIndex = 91;
        nCv.Controls.Add(UIG);
        nCv.Controls.Add(dRZ);
        nCv.Controls.Add(zIQ);
        nCv.Controls.Add(NRa);
        nCv.Controls.Add(AI5);
        nCv.Controls.Add(eRy);
        nCv.Controls.Add(FIz);
        nCv.Controls.Add(uRr);
        nCv.Controls.Add(sRb);
        nCv.Controls.Add(ARq);
        nCv.Controls.Add(IRv);
        nCv.Controls.Add(jRk);
        nCv.Controls.Add(CRM);
        nCv.Controls.Add(sRo);
        nCv.Location = new Point(4, 22);
        nCv.Name = "heromode";
        nCv.Padding = new Padding(3);
        nCv.Size = new Size(787, 533);
        nCv.TabIndex = 0;
        nCv.Text = "Hero Mode";
        nCv.UseVisualStyleBackColor = true;
        OCo.Controls.Add(qC8);
        OCo.Controls.Add(JCn);
        OCo.Controls.Add(bCQ);
        OCo.Controls.Add(JCF);
        OCo.Controls.Add(mCL);
        OCo.Controls.Add(lCO);
        OCo.Controls.Add(dCe);
        OCo.Controls.Add(qCt);
        OCo.Controls.Add(BCV);
        OCo.Location = new Point(4, 22);
        OCo.Name = "octoeditor";
        OCo.Padding = new Padding(3);
        OCo.Size = new Size(787, 533);
        OCo.TabIndex = 1;
        OCo.Text = "Octo Expansion";
        OCo.UseVisualStyleBackColor = true;
        qC8.AutoSize = true;
        qC8.Location = new Point(379, 164);
        qC8.Name = "label14";
        qC8.Size = new Size(103, 13);
        qC8.TabIndex = 8;
        qC8.Text = "Used OE Blue Coins";
        JCn.Location = new Point(382, 180);
        JCn.Maximum = new decimal(new int[4] { 10, 0, 0, 0 });
        JCn.Name = "NUD_OE_UsedBlueCoin";
        JCn.Size = new Size(120, 20);
        JCn.TabIndex = 7;
        bCQ.AutoSize = true;
        bCQ.Location = new Point(379, 124);
        bCQ.Name = "label13";
        bCQ.Size = new Size(75, 13);
        bCQ.TabIndex = 6;
        bCQ.Text = "OE Blue Coins";
        JCF.AutoSize = true;
        JCF.Location = new Point(240, 164);
        JCF.Name = "label12";
        JCF.Size = new Size(48, 13);
        JCF.TabIndex = 5;
        JCF.Text = "OE Debt";
        mCL.Location = new Point(243, 180);
        mCL.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
        mCL.Name = "NUD_OE_Debt";
        mCL.Size = new Size(120, 20);
        mCL.TabIndex = 4;
        lCO.Location = new Point(382, 140);
        lCO.Maximum = new decimal(new int[4] { 10, 0, 0, 0 });
        lCO.Name = "NUD_OE_BlueCoin";
        lCO.Size = new Size(120, 20);
        lCO.TabIndex = 3;
        dCe.AutoSize = true;
        dCe.Location = new Point(240, 124);
        dCe.Name = "label11";
        dCe.Size = new Size(57, 13);
        dCe.TabIndex = 2;
        dCe.Text = "OE Money";
        qCt.Location = new Point(331, 224);
        qCt.Name = "BTN_SaveOE";
        qCt.Size = new Size(75, 23);
        qCt.TabIndex = 1;
        qCt.Text = "Save";
        qCt.UseVisualStyleBackColor = true;
        qCt.Click += CID;
        BCV.Location = new Point(243, 140);
        BCV.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
        BCV.Name = "NUD_OE_Money";
        BCV.Size = new Size(120, 20);
        BCV.TabIndex = 0;
        base.AutoScaleDimensions = new SizeF(6f, 13f);
        base.AutoScaleMode = AutoScaleMode.Font;
        base.ClientSize = new Size(813, 576);
        base.Controls.Add(CCb);
        base.Name = "StorySplat2";
        base.ShowIcon = false;
        base.StartPosition = FormStartPosition.CenterScreen;
        Text = "SplatHeX - Splatoon 2 - Hero Mode Editor";
        UIG.ResumeLayout(performLayout: false);
        UIG.PerformLayout();
        bIm.ResumeLayout(performLayout: false);
        bIm.PerformLayout();
        ((ISupportInitialize)VII).EndInit();
        ((ISupportInitialize)tIC).EndInit();
        ((ISupportInitialize)LIU).EndInit();
        ((ISupportInitialize)kI1).EndInit();
        ((ISupportInitialize)rIw).EndInit();
        ((ISupportInitialize)EIY).EndInit();
        ((ISupportInitialize)QIA).EndInit();
        ((ISupportInitialize)vI6).EndInit();
        ((ISupportInitialize)eI9).EndInit();
        sIi.ResumeLayout(performLayout: false);
        sIi.PerformLayout();
        ((ISupportInitialize)WIc).EndInit();
        ((ISupportInitialize)gIo).EndInit();
        ((ISupportInitialize)FIn).EndInit();
        ((ISupportInitialize)JIt).EndInit();
        ((ISupportInitialize)tIO).EndInit();
        zIQ.ResumeLayout(performLayout: false);
        cIF.ResumeLayout(performLayout: false);
        cIF.PerformLayout();
        ((ISupportInitialize)VIr).EndInit();
        ((ISupportInitialize)DIq).EndInit();
        CIL.ResumeLayout(performLayout: false);
        CIL.PerformLayout();
        ((ISupportInitialize)LIM).EndInit();
        ((ISupportInitialize)dIu).EndInit();
        WIJ.ResumeLayout(performLayout: false);
        WIJ.PerformLayout();
        ((ISupportInitialize)pIg).EndInit();
        ((ISupportInitialize)wI2).EndInit();
        zI7.ResumeLayout(performLayout: false);
        zI7.PerformLayout();
        ((ISupportInitialize)iI3).EndInit();
        ((ISupportInitialize)XId).EndInit();
        iIP.ResumeLayout(performLayout: false);
        iIP.PerformLayout();
        ((ISupportInitialize)aIH).EndInit();
        ((ISupportInitialize)HI4).EndInit();
        ((ISupportInitialize)XIk).EndInit();
        ((ISupportInitialize)gRB).EndInit();
        AI5.ResumeLayout(performLayout: false);
        AI5.PerformLayout();
        ((ISupportInitialize)MIs).EndInit();
        ((ISupportInitialize)YIZ).EndInit();
        ((ISupportInitialize)fIa).EndInit();
        ((ISupportInitialize)DIj).EndInit();
        ((ISupportInitialize)lR9).EndInit();
        FIz.ResumeLayout(performLayout: false);
        FIz.PerformLayout();
        ((ISupportInitialize)zRO).EndInit();
        ((ISupportInitialize)ARD).EndInit();
        ((ISupportInitialize)VR8).EndInit();
        ((ISupportInitialize)XRX).EndInit();
        ((ISupportInitialize)PRQ).EndInit();
        ((ISupportInitialize)KRp).EndInit();
        ((ISupportInitialize)pRL).EndInit();
        ((ISupportInitialize)CRS).EndInit();
        ((ISupportInitialize)jR7).EndInit();
        ((ISupportInitialize)IRh).EndInit();
        ((ISupportInitialize)uRi).EndInit();
        ((ISupportInitialize)IRl).EndInit();
        ((ISupportInitialize)oR0).EndInit();
        ((ISupportInitialize)aRG).EndInit();
        ((ISupportInitialize)oRt).EndInit();
        ((ISupportInitialize)NRE).EndInit();
        ((ISupportInitialize)eRy).EndInit();
        ((ISupportInitialize)uRr).EndInit();
        ((ISupportInitialize)ARq).EndInit();
        ((ISupportInitialize)jRk).EndInit();
        ((ISupportInitialize)sRo).EndInit();
        ((ISupportInitialize)CRM).EndInit();
        ((ISupportInitialize)dRZ).EndInit();
        ((ISupportInitialize)NRa).EndInit();
        CCb.ResumeLayout(performLayout: false);
        nCv.ResumeLayout(performLayout: false);
        OCo.ResumeLayout(performLayout: false);
        OCo.PerformLayout();
        ((ISupportInitialize)JCn).EndInit();
        ((ISupportInitialize)mCL).EndInit();
        ((ISupportInitialize)lCO).EndInit();
        ((ISupportInitialize)BCV).EndInit();
        ResumeLayout(performLayout: false);
    }

    static Qrz() {
        KIp = -1;
    }
}