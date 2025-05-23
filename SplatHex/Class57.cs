using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace SplatHex;
public class Class57 : Form {
    public static int oPW;
    public int tPw;
    private IDisposable ePN;
    private Button fPY;
    private Button gPB;
    private Button VPA;
    private TabControl bPf;
    private TabPage sP6;
    public PictureBox tPx;
    public CheckBox mP9;
    private CheckBox nPc;
    private TabPage bPy;
    public PictureBox ePr;
    public CheckBox hPq;
    private TabPage pPk;
    private TabPage uPM;
    private TabPage iPu;
    private GroupBox EPg;
    private Button LP2;
    private ListBox EP3;
    public PictureBox YPd;
    public PictureBox BPH;
    public CheckBox uP4;
    public PictureBox PP5;
    public CheckBox jPs;
    public CheckBox JPZ;
    public PictureBox EPa;
    public NumericUpDown aPj;
    public NumericUpDown uPz;
    public CheckBox eiE;
    public NumericUpDown oiD;
    public Label NiX;
    public CheckBox fip;
    public NumericUpDown eiS;
    public PictureBox jih;
    public PictureBox lil;
    public PictureBox siG;
    private PictureBox Iib;
    public Label piv;
    public CheckBox nio;
    public NumericUpDown eit;
    public Label NiV;
    public CheckBox OiO;
    public NumericUpDown yie;
    public Label si8;
    public CheckBox Ain;
    public PictureBox JiQ;
    public PictureBox HiF;
    public PictureBox LiL;
    public PictureBox QiJ;
    public PictureBox si7;
    public PictureBox fiP;
    public PictureBox sii;
    public CheckBox yim;
    public PictureBox ci0;
    public CheckBox viI;
    public PictureBox MiR;
    public CheckBox KiC;
    public PictureBox qiK;
    public CheckBox QiU;
    public PictureBox HiT;
    public CheckBox ji1;
    public PictureBox LiW;
    public CheckBox Aiw;
    public PictureBox WiN;
    public CheckBox wiY;
    public PictureBox kiB;
    public CheckBox oiA;
    public PictureBox Fif;
    public CheckBox zi6;
    public PictureBox xix;
    public CheckBox ai9;
    public PictureBox Kic;
    public CheckBox Uiy;
    public PictureBox kir;
    public CheckBox Riq;
    public PictureBox Uik;
    public CheckBox niM;
    public PictureBox ciu;
    public CheckBox cig;
    public PictureBox Li2;
    public CheckBox Xi3;
    public PictureBox qid;
    public CheckBox biH;
    public PictureBox Qi4;
    public CheckBox ki5;
    public PictureBox ris;
    public CheckBox FiZ;
    private CheckBox Mia;
    private CheckBox pij;
    private CheckBox Uiz;
    private CheckBox PmE;
    public PictureBox QmD;
    public CheckBox ymX;
    private CheckBox ymp;
    private CheckBox ImS;
    private CheckBox Omh;
    private CheckBox vml;
    private CheckBox xmG;
    private CheckBox imb;
    private CheckBox Dmv;
    private CheckBox Tmo;
    private Button pmt;
    private CheckBox NmV;
    private CheckBox cmO;
    private GroupBox qme;
    private GroupBox jm8;
    public Label Rmn;
    public Class57() {
        fP1();
        fPh();
    }

    private void fPh() {
        EP3.SelectedIndex = 0;
        UPb();
        CPl();
    }

    private void CPl() {
        uint jtY = (uint)Class108.io2.jtY;
        mP9.Checked = (jtY & 4) != 0;
        hPq.Checked = (jtY & 8) != 0;
        QiU.Checked = (jtY & 0x20) != 0;
        KiC.Checked = (jtY & 0x10) != 0;
        viI.Checked = (jtY & 0x100000) != 0;
        yim.Checked = (jtY & 1) != 0;
        FiZ.Checked = (jtY & 2) != 0;
        Riq.Checked = (jtY & 0x1000) != 0;
        Uiy.Checked = (jtY & 0x400) != 0;
        ai9.Checked = (jtY & 0x40) != 0;
        zi6.Checked = (jtY & 0x800) != 0;
        oiA.Checked = (jtY & 0x100) != 0;
        wiY.Checked = (jtY & 0x200) != 0;
        Aiw.Checked = (jtY & 0x2000) != 0;
        ji1.Checked = (jtY & 0x80) != 0;
        ki5.Checked = (jtY & 0x4000) != 0;
        biH.Checked = (jtY & 0x8000) != 0;
        Xi3.Checked = (jtY & 0x40000) != 0;
        cig.Checked = (jtY & 0x10000) != 0;
        niM.Checked = (jtY & 0x20000) != 0;
        ymX.Checked = (jtY & 0x80000) != 0;
        uint dtB = (uint)Class108.io2.DtB;
        nPc.Checked = (dtB & 2) != 0;
        Mia.Checked = (dtB & 0x100) != 0;
        cmO.Checked = (dtB & 0x2000) != 0;
        NmV.Checked = (dtB & 0x80) != 0;
        PmE.Checked = (dtB & 4) != 0;
        Uiz.Checked = (dtB & 0x200) != 0;
        pij.Checked = (dtB & 0x4000) != 0;
        Omh.Checked = (dtB & 8) != 0;
        ImS.Checked = (dtB & 0x400) != 0;
        ymp.Checked = (dtB & 0x8000) != 0;
        imb.Checked = (dtB & 0x10) != 0;
        xmG.Checked = (dtB & 0x800) != 0;
        vml.Checked = (dtB & 0x10000) != 0;
        Tmo.Checked = (dtB & 0x20) != 0;
        Dmv.Checked = (dtB & 0x20000) != 0;
    }

    private void zPG() {
        uint uint_ = 0u;
        Class115.cH2(ref uint_, 4u, mP9.Checked);
        Class115.cH2(ref uint_, 8u, hPq.Checked);
        Class115.cH2(ref uint_, 32u, QiU.Checked);
        Class115.cH2(ref uint_, 16u, KiC.Checked);
        Class115.cH2(ref uint_, 1048576u, viI.Checked);
        Class115.cH2(ref uint_, 1u, yim.Checked);
        Class115.cH2(ref uint_, 2u, FiZ.Checked);
        Class115.cH2(ref uint_, 4096u, Riq.Checked);
        Class115.cH2(ref uint_, 1024u, Uiy.Checked);
        Class115.cH2(ref uint_, 64u, ai9.Checked);
        Class115.cH2(ref uint_, 2048u, zi6.Checked);
        Class115.cH2(ref uint_, 256u, oiA.Checked);
        Class115.cH2(ref uint_, 512u, wiY.Checked);
        Class115.cH2(ref uint_, 8192u, Aiw.Checked);
        Class115.cH2(ref uint_, 128u, ji1.Checked);
        Class115.cH2(ref uint_, 16384u, ki5.Checked);
        Class115.cH2(ref uint_, 32768u, biH.Checked);
        Class115.cH2(ref uint_, 262144u, Xi3.Checked);
        Class115.cH2(ref uint_, 131072u, cig.Checked);
        Class115.cH2(ref uint_, 65536u, niM.Checked);
        Class115.cH2(ref uint_, 524288u, ymX.Checked);
        Class108.io2.jtY = (int)uint_;
        uint uint_2 = 0u;
        Class115.cH2(ref uint_2, 2u, nPc.Checked);
        Class115.cH2(ref uint_2, 256u, Mia.Checked);
        Class115.cH2(ref uint_2, 8192u, cmO.Checked);
        Class115.cH2(ref uint_2, 128u, NmV.Checked);
        Class115.cH2(ref uint_2, 4u, PmE.Checked);
        Class115.cH2(ref uint_2, 512u, Uiz.Checked);
        Class115.cH2(ref uint_2, 16384u, pij.Checked);
        Class115.cH2(ref uint_2, 8u, Omh.Checked);
        Class115.cH2(ref uint_2, 1024u, ImS.Checked);
        Class115.cH2(ref uint_2, 32768u, ymp.Checked);
        Class115.cH2(ref uint_2, 16u, imb.Checked);
        Class115.cH2(ref uint_2, 2048u, xmG.Checked);
        Class115.cH2(ref uint_2, 65536u, vml.Checked);
        Class115.cH2(ref uint_2, 32u, Tmo.Checked);
        Class115.cH2(ref uint_2, 131072u, Dmv.Checked);
        Class108.io2.DtB = (int)uint_2;
    }

    private void UPb() {
        uPz.Value = Class108.io2.ntK;
        if (Class108.io2.HtU == -1) {
            aPj.Value = 1m;
        } else {
            aPj.Value = Class108.io2.HtU + 1;
            Ain.Checked = true;
        }

        if (Class108.io2.otT == -1) {
            yie.Value = 1m;
        } else {
            yie.Value = Class108.io2.otT + 1;
            OiO.Checked = true;
        }

        if (Class108.io2.Gt1 == -1) {
            eit.Value = 1m;
        } else {
            eit.Value = Class108.io2.Gt1 + 1;
            nio.Checked = true;
        }

        if (Class108.io2.OtW == -1) {
            eiS.Value = 1m;
        } else {
            eiS.Value = Class108.io2.OtW + 1;
            fip.Checked = true;
        }

        if (Class108.io2.ztw == -1) {
            oiD.Value = 1m;
        } else {
            oiD.Value = Class108.io2.ztw + 1;
            eiE.Checked = true;
        }

        switch (Class108.io2.CtA) {
            case 0:
                siG.BackColor = Color.OrangeRed;
                tPw = 0;
                break;
            case 1:
                lil.BackColor = Color.OrangeRed;
                tPw = 1;
                break;
            case 2:
                jih.BackColor = Color.OrangeRed;
                tPw = 2;
                break;
        }
    }

    private void LPv() {
        Class108.io2.ntK = (int)uPz.Value;
        Class108.io2.CtA = tPw;
        if (!Ain.Checked) {
            Class108.io2.HtU = -1;
        } else {
            Class108.io2.HtU = (int)aPj.Value - 1;
        }

        if (!OiO.Checked) {
            Class108.io2.otT = -1;
        } else {
            Class108.io2.otT = (int)yie.Value - 1;
        }

        if (!nio.Checked) {
            Class108.io2.Gt1 = -1;
        } else {
            Class108.io2.Gt1 = (int)eit.Value - 1;
        }

        if (!fip.Checked) {
            Class108.io2.OtW = -1;
        } else {
            Class108.io2.OtW = (int)eiS.Value - 1;
        }

        if (!eiE.Checked) {
            Class108.io2.ztw = -1;
        } else {
            Class108.io2.ztw = (int)oiD.Value - 1;
        }
    }

    private void ePo(object sender, EventArgs e) {
        EP3.SelectedIndex = 0;
        for (int i = 0; i < EP3.Items.Count; i++) {
            EP3.SelectedIndex = i;
            JPZ.Checked = false;
            uP4.Checked = false;
            jPs.Checked = false;
            LP2.PerformClick();
        }

        EP3.SelectedIndex = 0;
        Class97.qXq();
        Class108.io2.ntK = 0;
        Class108.io2.HtU = 0;
        Class108.io2.otT = 0;
        Class108.io2.Gt1 = 0;
        Class108.io2.OtW = -1;
        Class108.io2.ztw = -1;
        Class108.io2.CtA = 0;
        uint uint_ = (uint)Class108.io2.TtN;
        Class115.cH2(ref uint_, 16u, bool_0: false);
        Class115.cH2(ref uint_, 128u, bool_0: false);
        Class115.cH2(ref uint_, 256u, bool_0: false);
        Class108.io2.TtN = (int)uint_;
        Class108.io2.DtB = 0;
        Class108.io2.jtY = 0;
        MessageBox.Show("Octo Valley reseted.");
        Close();
    }

    private void aPt(object sender, EventArgs e) {
        WPO();
        Close();
    }

    private void tPV(object sender, EventArgs e) {
        Close();
    }

    private void WPO() {
        LPv();
        zPG();
    }

    private void uPe(object sender, EventArgs e) {
        oPW = -1;
        if (EP3.SelectedIndex != -1) {
            YPd.Enabled = true;
            jPs.Enabled = true;
            EPa.Enabled = true;
            uP4.Enabled = true;
            PP5.Enabled = true;
            JPZ.Enabled = true;
            BPH.Enabled = true;
            LP2.Enabled = true;
            BPH.Image = (Image)Resources.oKz.GetObject(EP3.SelectedItem.ToString().Replace(" ", "_") + "_Splat1");
            JPZ.Checked = false;
            jPs.Checked = false;
            uP4.Checked = false;
            for (int i = 0; i < Class108.Ioz.Length; i++) {
                if (Class108.Ioz[i].fVJ == Class108.RtE[EP3.SelectedIndex]) {
                    oPW = i;
                    break;
                }
            }

            if (oPW != -1) {
                JPZ.Checked = true;
                if (Class108.Ioz[oPW].uVP == 1) {
                    jPs.Checked = true;
                }

                if (Class108.Ioz[oPW].rV7 == 3) {
                    uP4.Checked = true;
                }
            }
        } else {
            YPd.Enabled = false;
            jPs.Enabled = false;
            EPa.Enabled = false;
            uP4.Enabled = false;
            PP5.Enabled = false;
            JPZ.Enabled = false;
            BPH.Enabled = false;
            LP2.Enabled = false;
        }
    }

    private void GP8(object sender, EventArgs e) {
        if (JPZ.Checked) {
            if (oPW == -1) {
                oPW = DPn();
                Class108.Ioz[oPW].fVJ = Class108.RtE[EP3.SelectedIndex];
            }

            if (uP4.Checked) {
                Class108.Ioz[oPW].rV7 = 3;
                if (jPs.Checked) {
                    Class108.Ioz[oPW].uVP = 1;
                } else {
                    Class108.Ioz[oPW].uVP = 0;
                }
            } else {
                Class108.Ioz[oPW].rV7 = 2;
                Class108.Ioz[oPW].uVP = 0;
            }

            return;
        }

        if (oPW != -1) {
            for (int i = oPW; i < Class108.Ioz.Length - 1; i++) {
                Class108.Ioz[i] = Class108.Ioz[i + 1];
            }
        }

        jPs.Checked = false;
        uP4.Checked = false;
    }

    private int DPn() {
        int num = 0;
        while (true) {
            if (num < Class108.Ioz.Length) {
                if (Class108.Ioz[num].fVJ == -1) {
                    break;
                }

                num++;
                continue;
            }

            return 500;
        }

        return num;
    }

    private void mPQ(object sender, EventArgs e) {
        EP3.SelectedIndex = 0;
        for (int i = 0; i < EP3.Items.Count; i++) {
            EP3.SelectedIndex = i;
            JPZ.Checked = true;
            uP4.Checked = true;
            jPs.Checked = true;
            LP2.PerformClick();
        }

        EP3.SelectedIndex = 0;
    }

    private void XPF(object sender, EventArgs e) {
        decimal value = aPj.Value;
        if (!1m.Equals(value)) {
            if (!2m.Equals(value)) {
                if (!3m.Equals(value)) {
                    if (4m.Equals(value)) {
                        JiQ.Image = Resources.Shot3;
                    }
                } else {
                    JiQ.Image = Resources.Shot2;
                }
            } else {
                JiQ.Image = Resources.Shot1;
            }
        } else {
            JiQ.Image = Resources.Shot0;
        }
    }

    private void gPL(object sender, EventArgs e) {
        decimal value = yie.Value;
        if (!1m.Equals(value)) {
            if (!2m.Equals(value)) {
                if (3m.Equals(value)) {
                    HiF.Image = Resources.Tnk2;
                } else if (4m.Equals(value)) {
                    HiF.Image = Resources.Tnk3;
                }
            } else {
                HiF.Image = Resources.Tnk1;
            }
        } else {
            HiF.Image = Resources.Tnk0;
        }
    }

    private void aPJ(object sender, EventArgs e) {
        decimal value = eit.Value;
        if (!1m.Equals(value)) {
            if (!2m.Equals(value)) {
                if (!3m.Equals(value)) {
                    if (4m.Equals(value)) {
                        LiL.Image = Resources.Bomb0_3;
                    }
                } else {
                    LiL.Image = Resources.Bomb0_2;
                }
            } else {
                LiL.Image = Resources.Bomb0_1;
            }
        } else {
            LiL.Image = Resources.Bomb0_0;
        }
    }

    private void IP7(object sender, EventArgs e) {
        decimal value = eiS.Value;
        if (!1m.Equals(value)) {
            if (!2m.Equals(value)) {
                if (!3m.Equals(value)) {
                    if (4m.Equals(value)) {
                        QiJ.Image = Resources.Bomb1_3;
                    }
                } else {
                    QiJ.Image = Resources.Bomb1_2;
                }
            } else {
                QiJ.Image = Resources.Bomb1_1;
            }
        } else {
            QiJ.Image = Resources.Bomb1_0;
        }
    }

    private void FPP(object sender, EventArgs e) {
        decimal value = oiD.Value;
        if (!1m.Equals(value)) {
            if (!2m.Equals(value)) {
                if (!3m.Equals(value)) {
                    if (4m.Equals(value)) {
                        si7.Image = Resources.Bomb2_3;
                    }
                } else {
                    si7.Image = Resources.Bomb2_2;
                }
            } else {
                si7.Image = Resources.Bomb2_1;
            }
        } else {
            si7.Image = Resources.Bomb2_0;
        }
    }

    private void PPi(object sender, EventArgs e) {
        if (Ain.Checked) {
            aPj.Enabled = true;
        } else {
            aPj.Enabled = false;
        }
    }

    private void wPm(object sender, EventArgs e) {
        if (OiO.Checked) {
            yie.Enabled = true;
        } else {
            yie.Enabled = false;
        }
    }

    private void KP0(object sender, EventArgs e) {
        if (!nio.Checked) {
            eit.Enabled = false;
        } else {
            eit.Enabled = true;
        }
    }

    private void dPI(object sender, EventArgs e) {
        if (fip.Checked) {
            eiS.Enabled = true;
        } else {
            eiS.Enabled = false;
        }
    }

    private void OPR(object sender, EventArgs e) {
        if (!eiE.Checked) {
            oiD.Enabled = false;
        } else {
            oiD.Enabled = true;
        }
    }

    private void GPC(object sender, EventArgs e) {
        siG.BackColor = Color.OrangeRed;
        lil.BackColor = Color.Gray;
        jih.BackColor = Color.Gray;
        tPw = 0;
    }

    private void rPK(object sender, EventArgs e) {
        siG.BackColor = Color.Gray;
        lil.BackColor = Color.OrangeRed;
        jih.BackColor = Color.Gray;
        tPw = 1;
    }

    private void VPU(object sender, EventArgs e) {
        siG.BackColor = Color.Gray;
        lil.BackColor = Color.Gray;
        jih.BackColor = Color.OrangeRed;
        tPw = 2;
    }

    private void BPT(object sender, EventArgs e) {
        string name = ((CheckBox)sender).Name;
        name = name.Remove(0, 7);
        name = name.Remove(1, 9);
        int num = int.Parse(name);
        string name2 = ((CheckBox)sender).Name;
        name2 = name2.Remove(0, 16);
        int num2 = int.Parse(name2);
        string key = "pic_w" + num + "_inkrail" + num2;
        PictureBox pictureBox = base.Controls.Find(key, searchAllChildren: true).FirstOrDefault() as PictureBox;
        if (((CheckBox)sender).Checked) {
            pictureBox.Image = Resources.inkrail_on;
        } else {
            pictureBox.Image = Resources.inkrail;
        }
    }

    protected override void Dispose(bool disposing) {
        if (disposing && ePN != null) {
            ePN.Dispose();
        }

        base.Dispose(disposing);
    }

    private void fP1() {
        ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Class57));
        fPY = new Button();
        gPB = new Button();
        VPA = new Button();
        bPf = new TabControl();
        sP6 = new TabPage();
        NmV = new CheckBox();
        cmO = new CheckBox();
        Mia = new CheckBox();
        tPx = new PictureBox();
        mP9 = new CheckBox();
        nPc = new CheckBox();
        bPy = new TabPage();
        pij = new CheckBox();
        Uiz = new CheckBox();
        PmE = new CheckBox();
        ePr = new PictureBox();
        hPq = new CheckBox();
        pPk = new TabPage();
        ymp = new CheckBox();
        ImS = new CheckBox();
        Omh = new CheckBox();
        ris = new PictureBox();
        FiZ = new CheckBox();
        sii = new PictureBox();
        yim = new CheckBox();
        ci0 = new PictureBox();
        viI = new CheckBox();
        MiR = new PictureBox();
        KiC = new CheckBox();
        qiK = new PictureBox();
        QiU = new CheckBox();
        uPM = new TabPage();
        vml = new CheckBox();
        xmG = new CheckBox();
        imb = new CheckBox();
        HiT = new PictureBox();
        ji1 = new CheckBox();
        LiW = new PictureBox();
        Aiw = new CheckBox();
        WiN = new PictureBox();
        wiY = new CheckBox();
        kiB = new PictureBox();
        oiA = new CheckBox();
        Fif = new PictureBox();
        zi6 = new CheckBox();
        xix = new PictureBox();
        ai9 = new CheckBox();
        Kic = new PictureBox();
        Uiy = new CheckBox();
        kir = new PictureBox();
        Riq = new CheckBox();
        iPu = new TabPage();
        Dmv = new CheckBox();
        Tmo = new CheckBox();
        QmD = new PictureBox();
        ymX = new CheckBox();
        Uik = new PictureBox();
        niM = new CheckBox();
        ciu = new PictureBox();
        cig = new CheckBox();
        Li2 = new PictureBox();
        Xi3 = new CheckBox();
        qid = new PictureBox();
        biH = new CheckBox();
        Qi4 = new PictureBox();
        ki5 = new CheckBox();
        EPg = new GroupBox();
        LP2 = new Button();
        EP3 = new ListBox();
        YPd = new PictureBox();
        BPH = new PictureBox();
        uP4 = new CheckBox();
        PP5 = new PictureBox();
        jPs = new CheckBox();
        JPZ = new CheckBox();
        EPa = new PictureBox();
        aPj = new NumericUpDown();
        uPz = new NumericUpDown();
        eiE = new CheckBox();
        oiD = new NumericUpDown();
        NiX = new Label();
        fip = new CheckBox();
        eiS = new NumericUpDown();
        piv = new Label();
        nio = new CheckBox();
        eit = new NumericUpDown();
        NiV = new Label();
        OiO = new CheckBox();
        yie = new NumericUpDown();
        si8 = new Label();
        Ain = new CheckBox();
        jih = new PictureBox();
        lil = new PictureBox();
        siG = new PictureBox();
        Iib = new PictureBox();
        JiQ = new PictureBox();
        HiF = new PictureBox();
        LiL = new PictureBox();
        QiJ = new PictureBox();
        si7 = new PictureBox();
        fiP = new PictureBox();
        pmt = new Button();
        qme = new GroupBox();
        jm8 = new GroupBox();
        Rmn = new Label();
        bPf.SuspendLayout();
        sP6.SuspendLayout();
        ((ISupportInitialize)tPx).BeginInit();
        bPy.SuspendLayout();
        ((ISupportInitialize)ePr).BeginInit();
        pPk.SuspendLayout();
        ((ISupportInitialize)ris).BeginInit();
        ((ISupportInitialize)sii).BeginInit();
        ((ISupportInitialize)ci0).BeginInit();
        ((ISupportInitialize)MiR).BeginInit();
        ((ISupportInitialize)qiK).BeginInit();
        uPM.SuspendLayout();
        ((ISupportInitialize)HiT).BeginInit();
        ((ISupportInitialize)LiW).BeginInit();
        ((ISupportInitialize)WiN).BeginInit();
        ((ISupportInitialize)kiB).BeginInit();
        ((ISupportInitialize)Fif).BeginInit();
        ((ISupportInitialize)xix).BeginInit();
        ((ISupportInitialize)Kic).BeginInit();
        ((ISupportInitialize)kir).BeginInit();
        iPu.SuspendLayout();
        ((ISupportInitialize)QmD).BeginInit();
        ((ISupportInitialize)Uik).BeginInit();
        ((ISupportInitialize)ciu).BeginInit();
        ((ISupportInitialize)Li2).BeginInit();
        ((ISupportInitialize)qid).BeginInit();
        ((ISupportInitialize)Qi4).BeginInit();
        EPg.SuspendLayout();
        ((ISupportInitialize)YPd).BeginInit();
        ((ISupportInitialize)BPH).BeginInit();
        ((ISupportInitialize)PP5).BeginInit();
        ((ISupportInitialize)EPa).BeginInit();
        ((ISupportInitialize)aPj).BeginInit();
        ((ISupportInitialize)uPz).BeginInit();
        ((ISupportInitialize)oiD).BeginInit();
        ((ISupportInitialize)eiS).BeginInit();
        ((ISupportInitialize)eit).BeginInit();
        ((ISupportInitialize)yie).BeginInit();
        ((ISupportInitialize)jih).BeginInit();
        ((ISupportInitialize)lil).BeginInit();
        ((ISupportInitialize)siG).BeginInit();
        ((ISupportInitialize)Iib).BeginInit();
        ((ISupportInitialize)JiQ).BeginInit();
        ((ISupportInitialize)HiF).BeginInit();
        ((ISupportInitialize)LiL).BeginInit();
        ((ISupportInitialize)QiJ).BeginInit();
        ((ISupportInitialize)si7).BeginInit();
        ((ISupportInitialize)fiP).BeginInit();
        qme.SuspendLayout();
        jm8.SuspendLayout();
        SuspendLayout();
        fPY.Location = new Point(408, 459);
        fPY.Name = "BTN_Save";
        fPY.Size = new Size(52, 23);
        fPY.TabIndex = 2;
        fPY.Text = "Save";
        fPY.UseVisualStyleBackColor = true;
        fPY.Click += aPt;
        gPB.Location = new Point(466, 459);
        gPB.Name = "BTN_Close";
        gPB.Size = new Size(52, 23);
        gPB.TabIndex = 3;
        gPB.Text = "Cancel";
        gPB.UseVisualStyleBackColor = true;
        gPB.Click += tPV;
        VPA.ImeMode = ImeMode.NoControl;
        VPA.Location = new Point(6, 48);
        VPA.Name = "resetAllButton";
        VPA.Size = new Size(148, 23);
        VPA.TabIndex = 23;
        VPA.Text = "Reset Octo Valley";
        VPA.UseVisualStyleBackColor = true;
        VPA.Click += ePo;
        bPf.Controls.Add(sP6);
        bPf.Controls.Add(bPy);
        bPf.Controls.Add(pPk);
        bPf.Controls.Add(uPM);
        bPf.Controls.Add(iPu);
        bPf.Location = new Point(239, 19);
        bPf.Name = "tab_world";
        bPf.SelectedIndex = 0;
        bPf.Size = new Size(259, 212);
        bPf.TabIndex = 50;
        sP6.Controls.Add(NmV);
        sP6.Controls.Add(cmO);
        sP6.Controls.Add(Mia);
        sP6.Controls.Add(tPx);
        sP6.Controls.Add(mP9);
        sP6.Controls.Add(nPc);
        sP6.Location = new Point(4, 22);
        sP6.Name = "tabPage1";
        sP6.Padding = new Padding(3);
        sP6.Size = new Size(251, 186);
        sP6.TabIndex = 0;
        sP6.Text = "World 1";
        sP6.UseVisualStyleBackColor = true;
        NmV.AutoSize = true;
        NmV.Location = new Point(6, 75);
        NmV.Name = "check_w1Event4";
        NmV.Size = new Size(44, 17);
        NmV.TabIndex = 18;
        NmV.Text = "???";
        NmV.UseVisualStyleBackColor = true;
        cmO.AutoSize = true;
        cmO.Location = new Point(6, 52);
        cmO.Name = "check_w1Event3";
        cmO.Size = new Size(162, 17);
        cmO.TabIndex = 17;
        cmO.Text = "World Discovered (no effect)";
        cmO.UseVisualStyleBackColor = true;
        Mia.AutoSize = true;
        Mia.Location = new Point(6, 29);
        Mia.Name = "check_w1Event2";
        Mia.Size = new Size(184, 17);
        Mia.TabIndex = 16;
        Mia.Text = "Played animation after boss battle";
        Mia.UseVisualStyleBackColor = true;
        tPx.BackColor = Color.Transparent;
        tPx.Image = Resources.inkrail;
        tPx.Location = new Point(24, 120);
        tPx.Name = "pic_w1_inkrail1";
        tPx.Size = new Size(30, 30);
        tPx.SizeMode = PictureBoxSizeMode.Zoom;
        tPx.TabIndex = 14;
        tPx.TabStop = false;
        tPx.Tag = "UBo.YBl";
        mP9.AutoSize = true;
        mP9.Location = new Point(11, 129);
        mP9.Name = "check_w1_inkrail1";
        mP9.Size = new Size(15, 14);
        mP9.TabIndex = 15;
        mP9.UseVisualStyleBackColor = true;
        mP9.CheckedChanged += BPT;
        nPc.AutoSize = true;
        nPc.Location = new Point(6, 6);
        nPc.Name = "check_w1Event1";
        nPc.Size = new Size(164, 17);
        nPc.TabIndex = 0;
        nPc.Text = "Played animation before boss";
        nPc.UseVisualStyleBackColor = true;
        bPy.Controls.Add(pij);
        bPy.Controls.Add(Uiz);
        bPy.Controls.Add(PmE);
        bPy.Controls.Add(ePr);
        bPy.Controls.Add(hPq);
        bPy.Location = new Point(4, 22);
        bPy.Name = "tabPage2";
        bPy.Padding = new Padding(3);
        bPy.Size = new Size(251, 186);
        bPy.TabIndex = 1;
        bPy.Text = "World 2";
        bPy.UseVisualStyleBackColor = true;
        pij.AutoSize = true;
        pij.Location = new Point(6, 52);
        pij.Name = "check_w2Event3";
        pij.Size = new Size(111, 17);
        pij.TabIndex = 20;
        pij.Text = "World Discovered";
        pij.UseVisualStyleBackColor = true;
        Uiz.AutoSize = true;
        Uiz.Location = new Point(6, 29);
        Uiz.Name = "check_w2Event2";
        Uiz.Size = new Size(184, 17);
        Uiz.TabIndex = 19;
        Uiz.Text = "Played animation after boss battle";
        Uiz.UseVisualStyleBackColor = true;
        PmE.AutoSize = true;
        PmE.Location = new Point(6, 6);
        PmE.Name = "check_w2Event1";
        PmE.Size = new Size(164, 17);
        PmE.TabIndex = 18;
        PmE.Text = "Played animation before boss";
        PmE.UseVisualStyleBackColor = true;
        ePr.BackColor = Color.Transparent;
        ePr.Image = Resources.inkrail;
        ePr.Location = new Point(24, 120);
        ePr.Name = "pic_w2_inkrail1";
        ePr.Size = new Size(30, 30);
        ePr.SizeMode = PictureBoxSizeMode.Zoom;
        ePr.TabIndex = 16;
        ePr.TabStop = false;
        ePr.Tag = "UBo.YBl";
        hPq.AutoSize = true;
        hPq.Location = new Point(11, 129);
        hPq.Name = "check_w2_inkrail1";
        hPq.Size = new Size(15, 14);
        hPq.TabIndex = 17;
        hPq.UseVisualStyleBackColor = true;
        hPq.CheckedChanged += BPT;
        pPk.Controls.Add(ymp);
        pPk.Controls.Add(ImS);
        pPk.Controls.Add(Omh);
        pPk.Controls.Add(ris);
        pPk.Controls.Add(FiZ);
        pPk.Controls.Add(sii);
        pPk.Controls.Add(yim);
        pPk.Controls.Add(ci0);
        pPk.Controls.Add(viI);
        pPk.Controls.Add(MiR);
        pPk.Controls.Add(KiC);
        pPk.Controls.Add(qiK);
        pPk.Controls.Add(QiU);
        pPk.Location = new Point(4, 22);
        pPk.Name = "tabPage3";
        pPk.Size = new Size(251, 186);
        pPk.TabIndex = 2;
        pPk.Text = "World 3";
        pPk.UseVisualStyleBackColor = true;
        ymp.AutoSize = true;
        ymp.Location = new Point(6, 52);
        ymp.Name = "check_w3Event3";
        ymp.Size = new Size(111, 17);
        ymp.TabIndex = 54;
        ymp.Text = "World Discovered";
        ymp.UseVisualStyleBackColor = true;
        ImS.AutoSize = true;
        ImS.Location = new Point(6, 29);
        ImS.Name = "check_w3Event2";
        ImS.Size = new Size(184, 17);
        ImS.TabIndex = 53;
        ImS.Text = "Played animation after boss battle";
        ImS.UseVisualStyleBackColor = true;
        Omh.AutoSize = true;
        Omh.Location = new Point(6, 6);
        Omh.Name = "check_w3Event1";
        Omh.Size = new Size(164, 17);
        Omh.TabIndex = 52;
        Omh.Text = "Played animation before boss";
        Omh.UseVisualStyleBackColor = true;
        ris.BackColor = Color.Transparent;
        ris.Image = (Image)componentResourceManager.GetObject("pic_w3_inkrail5.Image");
        ris.Location = new Point(139, 120);
        ris.Name = "pic_w3_inkrail5";
        ris.Size = new Size(30, 30);
        ris.SizeMode = PictureBoxSizeMode.Zoom;
        ris.TabIndex = 50;
        ris.TabStop = false;
        ris.Tag = "UBo.YBl";
        FiZ.AutoSize = true;
        FiZ.Location = new Point(126, 128);
        FiZ.Name = "check_w3_inkrail5";
        FiZ.Size = new Size(56, 17);
        FiZ.TabIndex = 51;
        FiZ.Text = "        5";
        FiZ.UseVisualStyleBackColor = true;
        FiZ.CheckedChanged += BPT;
        sii.BackColor = Color.Transparent;
        sii.Image = (Image)componentResourceManager.GetObject("pic_w3_inkrail4.Image");
        sii.Location = new Point(82, 150);
        sii.Name = "pic_w3_inkrail4";
        sii.Size = new Size(30, 30);
        sii.SizeMode = PictureBoxSizeMode.Zoom;
        sii.TabIndex = 30;
        sii.TabStop = false;
        sii.Tag = "UBo.YBl";
        yim.AutoSize = true;
        yim.Location = new Point(69, 158);
        yim.Name = "check_w3_inkrail4";
        yim.Size = new Size(56, 17);
        yim.TabIndex = 31;
        yim.Text = "        4";
        yim.UseVisualStyleBackColor = true;
        yim.CheckedChanged += BPT;
        ci0.BackColor = Color.Transparent;
        ci0.Image = (Image)componentResourceManager.GetObject("pic_w3_inkrail3.Image");
        ci0.Location = new Point(82, 120);
        ci0.Name = "pic_w3_inkrail3";
        ci0.Size = new Size(30, 30);
        ci0.SizeMode = PictureBoxSizeMode.Zoom;
        ci0.TabIndex = 28;
        ci0.TabStop = false;
        ci0.Tag = "UBo.YBl";
        viI.AutoSize = true;
        viI.Location = new Point(69, 128);
        viI.Name = "check_w3_inkrail3";
        viI.Size = new Size(56, 17);
        viI.TabIndex = 29;
        viI.Text = "        3";
        viI.UseVisualStyleBackColor = true;
        viI.CheckedChanged += BPT;
        MiR.BackColor = Color.Transparent;
        MiR.Image = (Image)componentResourceManager.GetObject("pic_w3_inkrail2.Image");
        MiR.Location = new Point(24, 150);
        MiR.Name = "pic_w3_inkrail2";
        MiR.Size = new Size(30, 30);
        MiR.SizeMode = PictureBoxSizeMode.Zoom;
        MiR.TabIndex = 26;
        MiR.TabStop = false;
        MiR.Tag = "UBo.YBl";
        KiC.AutoSize = true;
        KiC.Location = new Point(11, 158);
        KiC.Name = "check_w3_inkrail2";
        KiC.Size = new Size(56, 17);
        KiC.TabIndex = 27;
        KiC.Text = "        2";
        KiC.UseVisualStyleBackColor = true;
        KiC.CheckedChanged += BPT;
        qiK.BackColor = Color.Transparent;
        qiK.Image = Resources.inkrail;
        qiK.Location = new Point(24, 120);
        qiK.Name = "pic_w3_inkrail1";
        qiK.Size = new Size(30, 30);
        qiK.SizeMode = PictureBoxSizeMode.Zoom;
        qiK.TabIndex = 24;
        qiK.TabStop = false;
        qiK.Tag = "UBo.YBl";
        QiU.AutoSize = true;
        QiU.Location = new Point(11, 128);
        QiU.Name = "check_w3_inkrail1";
        QiU.Size = new Size(56, 17);
        QiU.TabIndex = 25;
        QiU.Text = "        1";
        QiU.UseVisualStyleBackColor = true;
        QiU.CheckedChanged += BPT;
        uPM.Controls.Add(vml);
        uPM.Controls.Add(xmG);
        uPM.Controls.Add(imb);
        uPM.Controls.Add(HiT);
        uPM.Controls.Add(ji1);
        uPM.Controls.Add(LiW);
        uPM.Controls.Add(Aiw);
        uPM.Controls.Add(WiN);
        uPM.Controls.Add(wiY);
        uPM.Controls.Add(kiB);
        uPM.Controls.Add(oiA);
        uPM.Controls.Add(Fif);
        uPM.Controls.Add(zi6);
        uPM.Controls.Add(xix);
        uPM.Controls.Add(ai9);
        uPM.Controls.Add(Kic);
        uPM.Controls.Add(Uiy);
        uPM.Controls.Add(kir);
        uPM.Controls.Add(Riq);
        uPM.Location = new Point(4, 22);
        uPM.Name = "tabPage4";
        uPM.Size = new Size(251, 186);
        uPM.TabIndex = 3;
        uPM.Text = "World 4";
        uPM.UseVisualStyleBackColor = true;
        vml.AutoSize = true;
        vml.Location = new Point(6, 52);
        vml.Name = "check_w4Event3";
        vml.Size = new Size(111, 17);
        vml.TabIndex = 58;
        vml.Text = "World Discovered";
        vml.UseVisualStyleBackColor = true;
        xmG.AutoSize = true;
        xmG.Location = new Point(6, 29);
        xmG.Name = "check_w4Event2";
        xmG.Size = new Size(184, 17);
        xmG.TabIndex = 57;
        xmG.Text = "Played animation after boss battle";
        xmG.UseVisualStyleBackColor = true;
        imb.AutoSize = true;
        imb.Location = new Point(6, 6);
        imb.Name = "check_w4Event1";
        imb.Size = new Size(164, 17);
        imb.TabIndex = 56;
        imb.Text = "Played animation before boss";
        imb.UseVisualStyleBackColor = true;
        HiT.BackColor = Color.Transparent;
        HiT.Image = (Image)componentResourceManager.GetObject("pic_w4_inkrail8.Image");
        HiT.Location = new Point(197, 150);
        HiT.Name = "pic_w4_inkrail8";
        HiT.Size = new Size(30, 30);
        HiT.SizeMode = PictureBoxSizeMode.Zoom;
        HiT.TabIndex = 54;
        HiT.TabStop = false;
        HiT.Tag = "UBo.YBl";
        ji1.AutoSize = true;
        ji1.Location = new Point(184, 158);
        ji1.Name = "check_w4_inkrail8";
        ji1.Size = new Size(56, 17);
        ji1.TabIndex = 55;
        ji1.Text = "        8";
        ji1.UseVisualStyleBackColor = true;
        ji1.CheckedChanged += BPT;
        LiW.BackColor = Color.Transparent;
        LiW.Image = (Image)componentResourceManager.GetObject("pic_w4_inkrail7.Image");
        LiW.Location = new Point(197, 120);
        LiW.Name = "pic_w4_inkrail7";
        LiW.Size = new Size(30, 30);
        LiW.SizeMode = PictureBoxSizeMode.Zoom;
        LiW.TabIndex = 52;
        LiW.TabStop = false;
        LiW.Tag = "UBo.YBl";
        Aiw.AutoSize = true;
        Aiw.Location = new Point(184, 128);
        Aiw.Name = "check_w4_inkrail7";
        Aiw.Size = new Size(56, 17);
        Aiw.TabIndex = 53;
        Aiw.Text = "        7";
        Aiw.UseVisualStyleBackColor = true;
        Aiw.CheckedChanged += BPT;
        WiN.BackColor = Color.Transparent;
        WiN.Image = (Image)componentResourceManager.GetObject("pic_w4_inkrail6.Image");
        WiN.Location = new Point(139, 150);
        WiN.Name = "pic_w4_inkrail6";
        WiN.Size = new Size(30, 30);
        WiN.SizeMode = PictureBoxSizeMode.Zoom;
        WiN.TabIndex = 50;
        WiN.TabStop = false;
        WiN.Tag = "UBo.YBl";
        wiY.AutoSize = true;
        wiY.Location = new Point(126, 158);
        wiY.Name = "check_w4_inkrail6";
        wiY.Size = new Size(56, 17);
        wiY.TabIndex = 51;
        wiY.Text = "        6";
        wiY.UseVisualStyleBackColor = true;
        wiY.CheckedChanged += BPT;
        kiB.BackColor = Color.Transparent;
        kiB.Image = (Image)componentResourceManager.GetObject("pic_w4_inkrail5.Image");
        kiB.Location = new Point(139, 120);
        kiB.Name = "pic_w4_inkrail5";
        kiB.Size = new Size(30, 30);
        kiB.SizeMode = PictureBoxSizeMode.Zoom;
        kiB.TabIndex = 48;
        kiB.TabStop = false;
        kiB.Tag = "UBo.YBl";
        oiA.AutoSize = true;
        oiA.Location = new Point(126, 128);
        oiA.Name = "check_w4_inkrail5";
        oiA.Size = new Size(56, 17);
        oiA.TabIndex = 49;
        oiA.Text = "        5";
        oiA.UseVisualStyleBackColor = true;
        oiA.CheckedChanged += BPT;
        Fif.BackColor = Color.Transparent;
        Fif.Image = (Image)componentResourceManager.GetObject("pic_w4_inkrail4.Image");
        Fif.Location = new Point(82, 150);
        Fif.Name = "pic_w4_inkrail4";
        Fif.Size = new Size(30, 30);
        Fif.SizeMode = PictureBoxSizeMode.Zoom;
        Fif.TabIndex = 46;
        Fif.TabStop = false;
        Fif.Tag = "UBo.YBl";
        zi6.AutoSize = true;
        zi6.Location = new Point(69, 158);
        zi6.Name = "check_w4_inkrail4";
        zi6.Size = new Size(56, 17);
        zi6.TabIndex = 47;
        zi6.Text = "        4";
        zi6.UseVisualStyleBackColor = true;
        zi6.CheckedChanged += BPT;
        xix.BackColor = Color.Transparent;
        xix.Image = (Image)componentResourceManager.GetObject("pic_w4_inkrail3.Image");
        xix.Location = new Point(82, 120);
        xix.Name = "pic_w4_inkrail3";
        xix.Size = new Size(30, 30);
        xix.SizeMode = PictureBoxSizeMode.Zoom;
        xix.TabIndex = 44;
        xix.TabStop = false;
        xix.Tag = "UBo.YBl";
        ai9.AutoSize = true;
        ai9.Location = new Point(69, 128);
        ai9.Name = "check_w4_inkrail3";
        ai9.Size = new Size(56, 17);
        ai9.TabIndex = 45;
        ai9.Text = "        3";
        ai9.UseVisualStyleBackColor = true;
        ai9.CheckedChanged += BPT;
        Kic.BackColor = Color.Transparent;
        Kic.Image = (Image)componentResourceManager.GetObject("pic_w4_inkrail2.Image");
        Kic.Location = new Point(24, 150);
        Kic.Name = "pic_w4_inkrail2";
        Kic.Size = new Size(30, 30);
        Kic.SizeMode = PictureBoxSizeMode.Zoom;
        Kic.TabIndex = 42;
        Kic.TabStop = false;
        Kic.Tag = "UBo.YBl";
        Uiy.AutoSize = true;
        Uiy.Location = new Point(11, 158);
        Uiy.Name = "check_w4_inkrail2";
        Uiy.Size = new Size(56, 17);
        Uiy.TabIndex = 43;
        Uiy.Text = "        2";
        Uiy.UseVisualStyleBackColor = true;
        Uiy.CheckedChanged += BPT;
        kir.BackColor = Color.Transparent;
        kir.Image = (Image)componentResourceManager.GetObject("pic_w4_inkrail1.Image");
        kir.Location = new Point(24, 120);
        kir.Name = "pic_w4_inkrail1";
        kir.Size = new Size(30, 30);
        kir.SizeMode = PictureBoxSizeMode.Zoom;
        kir.TabIndex = 40;
        kir.TabStop = false;
        kir.Tag = "UBo.YBl";
        Riq.AutoSize = true;
        Riq.Location = new Point(11, 128);
        Riq.Name = "check_w4_inkrail1";
        Riq.Size = new Size(56, 17);
        Riq.TabIndex = 41;
        Riq.Text = "        1";
        Riq.UseVisualStyleBackColor = true;
        Riq.CheckedChanged += BPT;
        iPu.Controls.Add(Dmv);
        iPu.Controls.Add(Tmo);
        iPu.Controls.Add(QmD);
        iPu.Controls.Add(ymX);
        iPu.Controls.Add(Uik);
        iPu.Controls.Add(niM);
        iPu.Controls.Add(ciu);
        iPu.Controls.Add(cig);
        iPu.Controls.Add(Li2);
        iPu.Controls.Add(Xi3);
        iPu.Controls.Add(qid);
        iPu.Controls.Add(biH);
        iPu.Controls.Add(Qi4);
        iPu.Controls.Add(ki5);
        iPu.Location = new Point(4, 22);
        iPu.Name = "tabPage5";
        iPu.Size = new Size(251, 186);
        iPu.TabIndex = 4;
        iPu.Text = "World 5";
        iPu.UseVisualStyleBackColor = true;
        Dmv.AutoSize = true;
        Dmv.Location = new Point(6, 29);
        Dmv.Name = "check_w5Event2";
        Dmv.Size = new Size(111, 17);
        Dmv.TabIndex = 61;
        Dmv.Text = "World Discovered";
        Dmv.UseVisualStyleBackColor = true;
        Tmo.AutoSize = true;
        Tmo.Location = new Point(6, 6);
        Tmo.Name = "check_w5Event1";
        Tmo.Size = new Size(164, 17);
        Tmo.TabIndex = 59;
        Tmo.Text = "Played animation before boss";
        Tmo.UseVisualStyleBackColor = true;
        QmD.BackColor = Color.Transparent;
        QmD.Image = (Image)componentResourceManager.GetObject("pic_w5_inkrail6.Image");
        QmD.Location = new Point(139, 150);
        QmD.Name = "pic_w5_inkrail6";
        QmD.Size = new Size(30, 30);
        QmD.SizeMode = PictureBoxSizeMode.Zoom;
        QmD.TabIndex = 54;
        QmD.TabStop = false;
        QmD.Tag = "UBo.YBl";
        ymX.AutoSize = true;
        ymX.Location = new Point(126, 158);
        ymX.Name = "check_w5_inkrail6";
        ymX.Size = new Size(56, 17);
        ymX.TabIndex = 55;
        ymX.Text = "        6";
        ymX.UseVisualStyleBackColor = true;
        ymX.CheckedChanged += BPT;
        Uik.BackColor = Color.Transparent;
        Uik.Image = (Image)componentResourceManager.GetObject("pic_w5_inkrail5.Image");
        Uik.Location = new Point(139, 120);
        Uik.Name = "pic_w5_inkrail5";
        Uik.Size = new Size(30, 30);
        Uik.SizeMode = PictureBoxSizeMode.Zoom;
        Uik.TabIndex = 52;
        Uik.TabStop = false;
        Uik.Tag = "UBo.YBl";
        niM.AutoSize = true;
        niM.Location = new Point(126, 128);
        niM.Name = "check_w5_inkrail5";
        niM.Size = new Size(56, 17);
        niM.TabIndex = 53;
        niM.Text = "        5";
        niM.UseVisualStyleBackColor = true;
        niM.CheckedChanged += BPT;
        ciu.BackColor = Color.Transparent;
        ciu.Image = (Image)componentResourceManager.GetObject("pic_w5_inkrail4.Image");
        ciu.Location = new Point(82, 150);
        ciu.Name = "pic_w5_inkrail4";
        ciu.Size = new Size(30, 30);
        ciu.SizeMode = PictureBoxSizeMode.Zoom;
        ciu.TabIndex = 50;
        ciu.TabStop = false;
        ciu.Tag = "UBo.YBl";
        cig.AutoSize = true;
        cig.Location = new Point(69, 158);
        cig.Name = "check_w5_inkrail4";
        cig.Size = new Size(56, 17);
        cig.TabIndex = 51;
        cig.Text = "        4";
        cig.UseVisualStyleBackColor = true;
        cig.CheckedChanged += BPT;
        Li2.BackColor = Color.Transparent;
        Li2.Image = (Image)componentResourceManager.GetObject("pic_w5_inkrail3.Image");
        Li2.Location = new Point(82, 120);
        Li2.Name = "pic_w5_inkrail3";
        Li2.Size = new Size(30, 30);
        Li2.SizeMode = PictureBoxSizeMode.Zoom;
        Li2.TabIndex = 48;
        Li2.TabStop = false;
        Li2.Tag = "UBo.YBl";
        Xi3.AutoSize = true;
        Xi3.Location = new Point(69, 128);
        Xi3.Name = "check_w5_inkrail3";
        Xi3.Size = new Size(56, 17);
        Xi3.TabIndex = 49;
        Xi3.Text = "        3";
        Xi3.UseVisualStyleBackColor = true;
        Xi3.CheckedChanged += BPT;
        qid.BackColor = Color.Transparent;
        qid.Image = (Image)componentResourceManager.GetObject("pic_w5_inkrail2.Image");
        qid.Location = new Point(24, 150);
        qid.Name = "pic_w5_inkrail2";
        qid.Size = new Size(30, 30);
        qid.SizeMode = PictureBoxSizeMode.Zoom;
        qid.TabIndex = 46;
        qid.TabStop = false;
        qid.Tag = "UBo.YBl";
        biH.AutoSize = true;
        biH.Location = new Point(11, 158);
        biH.Name = "check_w5_inkrail2";
        biH.Size = new Size(56, 17);
        biH.TabIndex = 47;
        biH.Text = "        2";
        biH.UseVisualStyleBackColor = true;
        biH.CheckedChanged += BPT;
        Qi4.BackColor = Color.Transparent;
        Qi4.Image = (Image)componentResourceManager.GetObject("pic_w5_inkrail1.Image");
        Qi4.Location = new Point(24, 120);
        Qi4.Name = "pic_w5_inkrail1";
        Qi4.Size = new Size(30, 30);
        Qi4.SizeMode = PictureBoxSizeMode.Zoom;
        Qi4.TabIndex = 44;
        Qi4.TabStop = false;
        Qi4.Tag = "UBo.YBl";
        ki5.AutoSize = true;
        ki5.Location = new Point(11, 128);
        ki5.Name = "check_w5_inkrail1";
        ki5.Size = new Size(56, 17);
        ki5.TabIndex = 45;
        ki5.Text = "        1";
        ki5.UseVisualStyleBackColor = true;
        ki5.CheckedChanged += BPT;
        EPg.Controls.Add(LP2);
        EPg.Controls.Add(EP3);
        EPg.Controls.Add(YPd);
        EPg.Controls.Add(BPH);
        EPg.Controls.Add(uP4);
        EPg.Controls.Add(PP5);
        EPg.Controls.Add(jPs);
        EPg.Controls.Add(JPZ);
        EPg.Controls.Add(EPa);
        EPg.Location = new Point(6, 19);
        EPg.Name = "groupBox8";
        EPg.Size = new Size(227, 236);
        EPg.TabIndex = 73;
        EPg.TabStop = false;
        EPg.Text = "Stages";
        LP2.Enabled = false;
        LP2.Location = new Point(130, 199);
        LP2.Name = "BTN_SaveStage";
        LP2.Size = new Size(75, 23);
        LP2.TabIndex = 13;
        LP2.Text = "Save";
        LP2.UseVisualStyleBackColor = true;
        LP2.Click += GP8;
        EP3.FormattingEnabled = true;
        EP3.Items.AddRange(new object[32] { "Stage 01", "Stage 02", "Stage 03", "Boss 01", "Stage 04", "Stage 05", "Stage 06", "Stage 07", "Stage 08", "Stage 09", "Boss 02", "Stage 10", "Stage 11", "Stage 12", "Stage 13", "Stage 14", "Stage 15", "Boss 03", "Stage 16", "Stage 17", "Stage 18", "Stage 19", "Stage 20", "Stage 21", "Boss 04", "Stage 22", "Stage 23", "Stage 24", "Stage 25", "Stage 26", "Stage 27", "Boss 05" });
        EP3.Location = new Point(6, 18);
        EP3.Name = "LB_Stages";
        EP3.Size = new Size(105, 212);
        EP3.TabIndex = 11;
        EP3.SelectedIndexChanged += uPe;
        YPd.BackColor = Color.Transparent;
        YPd.Enabled = false;
        YPd.Image = Resources.scroll;
        YPd.Location = new Point(135, 148);
        YPd.Name = "PB_sunkenRoll";
        YPd.Size = new Size(30, 30);
        YPd.SizeMode = PictureBoxSizeMode.Zoom;
        YPd.TabIndex = 4;
        YPd.TabStop = false;
        YPd.Tag = "UBo.YBl";
        BPH.BorderStyle = BorderStyle.FixedSingle;
        BPH.Enabled = false;
        BPH.Location = new Point(122, 18);
        BPH.Name = "PB_StagePic";
        BPH.Size = new Size(70, 70);
        BPH.SizeMode = PictureBoxSizeMode.Zoom;
        BPH.TabIndex = 0;
        BPH.TabStop = false;
        BPH.Tag = "";
        uP4.AutoSize = true;
        uP4.Enabled = false;
        uP4.Location = new Point(122, 126);
        uP4.Name = "CB_zapfish";
        uP4.Size = new Size(15, 14);
        uP4.TabIndex = 7;
        uP4.UseVisualStyleBackColor = true;
        PP5.BackColor = Color.Transparent;
        PP5.Enabled = false;
        PP5.Image = Resources.pot;
        PP5.Location = new Point(135, 88);
        PP5.Name = "PB_Pot";
        PP5.Size = new Size(30, 30);
        PP5.SizeMode = PictureBoxSizeMode.Zoom;
        PP5.TabIndex = 9;
        PP5.TabStop = false;
        PP5.Tag = "UBo.YBl";
        jPs.AutoSize = true;
        jPs.Enabled = false;
        jPs.Location = new Point(122, 156);
        jPs.Name = "CB_sunkenRoll";
        jPs.Size = new Size(15, 14);
        jPs.TabIndex = 5;
        jPs.UseVisualStyleBackColor = true;
        JPZ.AutoSize = true;
        JPZ.Enabled = false;
        JPZ.Location = new Point(122, 96);
        JPZ.Name = "CB_Pot";
        JPZ.Size = new Size(15, 14);
        JPZ.TabIndex = 10;
        JPZ.UseVisualStyleBackColor = true;
        EPa.BackColor = Color.Transparent;
        EPa.Enabled = false;
        EPa.Image = Resources.zapfish;
        EPa.Location = new Point(135, 118);
        EPa.Name = "PB_zapfish";
        EPa.Size = new Size(30, 30);
        EPa.SizeMode = PictureBoxSizeMode.Zoom;
        EPa.TabIndex = 8;
        EPa.TabStop = false;
        EPa.Tag = "UBo.YBl";
        aPj.Location = new Point(28, 331);
        aPj.Maximum = new decimal(new int[4] { 4, 0, 0, 0 });
        aPj.Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
        aPj.Name = "NUD_lvlShot";
        aPj.Size = new Size(30, 20);
        aPj.TabIndex = 55;
        aPj.Value = new decimal(new int[4] { 1, 0, 0, 0 });
        aPj.ValueChanged += XPF;
        uPz.Location = new Point(50, 395);
        uPz.Maximum = new decimal(new int[4] { 9999, 0, 0, 0 });
        uPz.Name = "NUD_PowerEggs";
        uPz.Size = new Size(44, 20);
        uPz.TabIndex = 46;
        eiE.AutoSize = true;
        eiE.Location = new Point(270, 314);
        eiE.Name = "CB_unlockBomb2";
        eiE.Size = new Size(60, 17);
        eiE.TabIndex = 68;
        eiE.Text = "Unlock";
        eiE.UseVisualStyleBackColor = true;
        eiE.CheckedChanged += OPR;
        oiD.Enabled = false;
        oiD.Location = new Point(294, 331);
        oiD.Maximum = new decimal(new int[4] { 4, 0, 0, 0 });
        oiD.Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
        oiD.Name = "NUD_lvlBomb2";
        oiD.Size = new Size(30, 20);
        oiD.TabIndex = 66;
        oiD.Value = new decimal(new int[4] { 1, 0, 0, 0 });
        oiD.ValueChanged += FPP;
        NiX.AutoSize = true;
        NiX.Location = new Point(275, 334);
        NiX.Name = "label5";
        NiX.Size = new Size(22, 13);
        NiX.TabIndex = 67;
        NiX.Text = "Lv.";
        fip.AutoSize = true;
        fip.Location = new Point(203, 314);
        fip.Name = "CB_unlockBomb1";
        fip.Size = new Size(60, 17);
        fip.TabIndex = 65;
        fip.Text = "Unlock";
        fip.UseVisualStyleBackColor = true;
        fip.CheckedChanged += dPI;
        eiS.Enabled = false;
        eiS.Location = new Point(227, 331);
        eiS.Maximum = new decimal(new int[4] { 4, 0, 0, 0 });
        eiS.Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
        eiS.Name = "NUD_lvlBomb1";
        eiS.Size = new Size(30, 20);
        eiS.TabIndex = 63;
        eiS.Value = new decimal(new int[4] { 1, 0, 0, 0 });
        eiS.ValueChanged += IP7;
        piv.AutoSize = true;
        piv.Location = new Point(208, 334);
        piv.Name = "label4";
        piv.Size = new Size(22, 13);
        piv.TabIndex = 64;
        piv.Text = "Lv.";
        nio.AutoSize = true;
        nio.Checked = true;
        nio.CheckState = CheckState.Checked;
        nio.Location = new Point(136, 314);
        nio.Name = "CB_unlockBomb0";
        nio.Size = new Size(60, 17);
        nio.TabIndex = 62;
        nio.Text = "Unlock";
        nio.UseVisualStyleBackColor = true;
        nio.CheckedChanged += KP0;
        eit.Location = new Point(160, 331);
        eit.Maximum = new decimal(new int[4] { 4, 0, 0, 0 });
        eit.Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
        eit.Name = "NUD_lvlBomb0";
        eit.Size = new Size(30, 20);
        eit.TabIndex = 60;
        eit.Value = new decimal(new int[4] { 1, 0, 0, 0 });
        eit.ValueChanged += aPJ;
        NiV.AutoSize = true;
        NiV.Location = new Point(137, 334);
        NiV.Name = "label2";
        NiV.Size = new Size(22, 13);
        NiV.TabIndex = 61;
        NiV.Text = "Lv.";
        OiO.AutoSize = true;
        OiO.Checked = true;
        OiO.CheckState = CheckState.Checked;
        OiO.Location = new Point(71, 314);
        OiO.Name = "CB_unlockTnk";
        OiO.Size = new Size(60, 17);
        OiO.TabIndex = 59;
        OiO.Text = "Unlock";
        OiO.UseVisualStyleBackColor = true;
        OiO.CheckedChanged += wPm;
        yie.Location = new Point(95, 331);
        yie.Maximum = new decimal(new int[4] { 4, 0, 0, 0 });
        yie.Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
        yie.Name = "NUD_lvlTnk";
        yie.Size = new Size(30, 20);
        yie.TabIndex = 57;
        yie.Value = new decimal(new int[4] { 1, 0, 0, 0 });
        yie.ValueChanged += gPL;
        si8.AutoSize = true;
        si8.Location = new Point(73, 334);
        si8.Name = "label1";
        si8.Size = new Size(22, 13);
        si8.TabIndex = 58;
        si8.Text = "Lv.";
        Ain.AutoSize = true;
        Ain.Checked = true;
        Ain.CheckState = CheckState.Checked;
        Ain.Location = new Point(4, 314);
        Ain.Name = "CB_unlockShot";
        Ain.Size = new Size(60, 17);
        Ain.TabIndex = 56;
        Ain.Text = "Unlock";
        Ain.UseVisualStyleBackColor = true;
        Ain.CheckedChanged += PPi;
        jih.BackColor = Color.Gray;
        jih.BorderStyle = BorderStyle.FixedSingle;
        jih.Image = Resources.Bomb2_0;
        jih.Location = new Point(193, 393);
        jih.Name = "PB_changeBom2";
        jih.Size = new Size(30, 30);
        jih.SizeMode = PictureBoxSizeMode.Zoom;
        jih.TabIndex = 71;
        jih.TabStop = false;
        jih.Click += VPU;
        lil.BackColor = Color.Gray;
        lil.BorderStyle = BorderStyle.FixedSingle;
        lil.Image = Resources.Bomb1_0;
        lil.Location = new Point(157, 357);
        lil.Name = "PB_changeBom1";
        lil.Size = new Size(30, 30);
        lil.SizeMode = PictureBoxSizeMode.Zoom;
        lil.TabIndex = 70;
        lil.TabStop = false;
        lil.Click += rPK;
        siG.BackColor = Color.Gray;
        siG.BorderStyle = BorderStyle.FixedSingle;
        siG.Image = Resources.Bomb0_0;
        siG.Location = new Point(121, 393);
        siG.Name = "PB_changeBom0";
        siG.Size = new Size(30, 30);
        siG.SizeMode = PictureBoxSizeMode.Zoom;
        siG.TabIndex = 69;
        siG.TabStop = false;
        siG.Click += GPC;
        Iib.Image = Resources.icon_poweregg;
        Iib.Location = new Point(17, 390);
        Iib.Name = "pictureBox1";
        Iib.Size = new Size(30, 30);
        Iib.SizeMode = PictureBoxSizeMode.Zoom;
        Iib.TabIndex = 48;
        Iib.TabStop = false;
        JiQ.BackColor = Color.LightGray;
        JiQ.BorderStyle = BorderStyle.FixedSingle;
        JiQ.Image = Resources.Shot0;
        JiQ.Location = new Point(6, 261);
        JiQ.Name = "pic_shot";
        JiQ.Size = new Size(50, 50);
        JiQ.SizeMode = PictureBoxSizeMode.Zoom;
        JiQ.TabIndex = 49;
        JiQ.TabStop = false;
        HiF.BackColor = Color.LightGray;
        HiF.BorderStyle = BorderStyle.FixedSingle;
        HiF.Image = Resources.Tnk0;
        HiF.Location = new Point(75, 261);
        HiF.Name = "pic_tnk";
        HiF.Size = new Size(50, 50);
        HiF.SizeMode = PictureBoxSizeMode.Zoom;
        HiF.TabIndex = 51;
        HiF.TabStop = false;
        LiL.BackColor = Color.LightGray;
        LiL.BorderStyle = BorderStyle.FixedSingle;
        LiL.Image = Resources.Bomb0_0;
        LiL.Location = new Point(141, 261);
        LiL.Name = "pic_bomb0";
        LiL.Size = new Size(50, 50);
        LiL.SizeMode = PictureBoxSizeMode.Zoom;
        LiL.TabIndex = 52;
        LiL.TabStop = false;
        QiJ.BackColor = Color.LightGray;
        QiJ.BorderStyle = BorderStyle.FixedSingle;
        QiJ.Image = Resources.Bomb1_0;
        QiJ.Location = new Point(207, 261);
        QiJ.Name = "pic_bomb1";
        QiJ.Size = new Size(50, 50);
        QiJ.SizeMode = PictureBoxSizeMode.Zoom;
        QiJ.TabIndex = 53;
        QiJ.TabStop = false;
        si7.BackColor = Color.LightGray;
        si7.BorderStyle = BorderStyle.FixedSingle;
        si7.Image = Resources.Bomb2_0;
        si7.Location = new Point(273, 261);
        si7.Name = "pic_bomb2";
        si7.Size = new Size(50, 50);
        si7.SizeMode = PictureBoxSizeMode.Zoom;
        si7.TabIndex = 54;
        si7.TabStop = false;
        fiP.Image = Resources.d_pad;
        fiP.Location = new Point(146, 383);
        fiP.Name = "pic_changeBomCroix";
        fiP.Size = new Size(50, 50);
        fiP.SizeMode = PictureBoxSizeMode.Zoom;
        fiP.TabIndex = 72;
        fiP.TabStop = false;
        pmt.ImeMode = ImeMode.NoControl;
        pmt.Location = new Point(6, 19);
        pmt.Name = "BTN_completeAllStages";
        pmt.Size = new Size(148, 23);
        pmt.TabIndex = 74;
        pmt.Text = "Complete All Stage";
        pmt.UseVisualStyleBackColor = true;
        pmt.Click += mPQ;
        qme.Controls.Add(pmt);
        qme.Controls.Add(VPA);
        qme.Location = new Point(336, 357);
        qme.Name = "groupBox1";
        qme.Size = new Size(162, 76);
        qme.TabIndex = 75;
        qme.TabStop = false;
        qme.Text = "Actions";
        jm8.Controls.Add(Rmn);
        jm8.Controls.Add(EPg);
        jm8.Controls.Add(qme);
        jm8.Controls.Add(fiP);
        jm8.Controls.Add(bPf);
        jm8.Controls.Add(si7);
        jm8.Controls.Add(QiJ);
        jm8.Controls.Add(aPj);
        jm8.Controls.Add(LiL);
        jm8.Controls.Add(uPz);
        jm8.Controls.Add(HiF);
        jm8.Controls.Add(eiE);
        jm8.Controls.Add(JiQ);
        jm8.Controls.Add(oiD);
        jm8.Controls.Add(Ain);
        jm8.Controls.Add(NiX);
        jm8.Controls.Add(si8);
        jm8.Controls.Add(fip);
        jm8.Controls.Add(yie);
        jm8.Controls.Add(eiS);
        jm8.Controls.Add(OiO);
        jm8.Controls.Add(jih);
        jm8.Controls.Add(NiV);
        jm8.Controls.Add(lil);
        jm8.Controls.Add(eit);
        jm8.Controls.Add(siG);
        jm8.Controls.Add(nio);
        jm8.Controls.Add(Iib);
        jm8.Controls.Add(piv);
        jm8.Location = new Point(12, 12);
        jm8.Name = "groupBox2";
        jm8.Size = new Size(506, 441);
        jm8.TabIndex = 76;
        jm8.TabStop = false;
        jm8.Text = "Hero Mode Overall";
        Rmn.AutoSize = true;
        Rmn.Location = new Point(3, 336);
        Rmn.Name = "label3";
        Rmn.Size = new Size(22, 13);
        Rmn.TabIndex = 76;
        Rmn.Text = "Lv.";
        base.AutoScaleDimensions = new SizeF(6f, 13f);
        base.AutoScaleMode = AutoScaleMode.Font;
        base.ClientSize = new Size(526, 489);
        base.Controls.Add(jm8);
        base.Controls.Add(gPB);
        base.Controls.Add(fPY);
        base.Name = "StorySplat1";
        base.ShowIcon = false;
        base.StartPosition = FormStartPosition.CenterScreen;
        Text = "SplatHeX - Splatoon 1 - Hero Mode Editor";
        bPf.ResumeLayout(performLayout: false);
        sP6.ResumeLayout(performLayout: false);
        sP6.PerformLayout();
        ((ISupportInitialize)tPx).EndInit();
        bPy.ResumeLayout(performLayout: false);
        bPy.PerformLayout();
        ((ISupportInitialize)ePr).EndInit();
        pPk.ResumeLayout(performLayout: false);
        pPk.PerformLayout();
        ((ISupportInitialize)ris).EndInit();
        ((ISupportInitialize)sii).EndInit();
        ((ISupportInitialize)ci0).EndInit();
        ((ISupportInitialize)MiR).EndInit();
        ((ISupportInitialize)qiK).EndInit();
        uPM.ResumeLayout(performLayout: false);
        uPM.PerformLayout();
        ((ISupportInitialize)HiT).EndInit();
        ((ISupportInitialize)LiW).EndInit();
        ((ISupportInitialize)WiN).EndInit();
        ((ISupportInitialize)kiB).EndInit();
        ((ISupportInitialize)Fif).EndInit();
        ((ISupportInitialize)xix).EndInit();
        ((ISupportInitialize)Kic).EndInit();
        ((ISupportInitialize)kir).EndInit();
        iPu.ResumeLayout(performLayout: false);
        iPu.PerformLayout();
        ((ISupportInitialize)QmD).EndInit();
        ((ISupportInitialize)Uik).EndInit();
        ((ISupportInitialize)ciu).EndInit();
        ((ISupportInitialize)Li2).EndInit();
        ((ISupportInitialize)qid).EndInit();
        ((ISupportInitialize)Qi4).EndInit();
        EPg.ResumeLayout(performLayout: false);
        EPg.PerformLayout();
        ((ISupportInitialize)YPd).EndInit();
        ((ISupportInitialize)BPH).EndInit();
        ((ISupportInitialize)PP5).EndInit();
        ((ISupportInitialize)EPa).EndInit();
        ((ISupportInitialize)aPj).EndInit();
        ((ISupportInitialize)uPz).EndInit();
        ((ISupportInitialize)oiD).EndInit();
        ((ISupportInitialize)eiS).EndInit();
        ((ISupportInitialize)eit).EndInit();
        ((ISupportInitialize)yie).EndInit();
        ((ISupportInitialize)jih).EndInit();
        ((ISupportInitialize)lil).EndInit();
        ((ISupportInitialize)siG).EndInit();
        ((ISupportInitialize)Iib).EndInit();
        ((ISupportInitialize)JiQ).EndInit();
        ((ISupportInitialize)HiF).EndInit();
        ((ISupportInitialize)LiL).EndInit();
        ((ISupportInitialize)QiJ).EndInit();
        ((ISupportInitialize)si7).EndInit();
        ((ISupportInitialize)fiP).EndInit();
        qme.ResumeLayout(performLayout: false);
        jm8.ResumeLayout(performLayout: false);
        jm8.PerformLayout();
        ResumeLayout(performLayout: false);
    }

    static Class57() {
        oPW = -1;
    }
}