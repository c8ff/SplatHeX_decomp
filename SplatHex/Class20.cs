using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
namespace SplatHex;
public class Class20 : Form {
    private bool[] PJX = new bool[3];
    private object xJp = new Dictionary<int, Class25>[3]
    {
        Class85.DhZ,
        Class85.Lhs,
        Class85.hh5
    };
    private ComboBox[] lJS;
    private ComboBox[] KJh;
    private PictureBox[] UJl;
    private Button[] PJG;
    private Button[] hJb;
    private Button[] tJv;
    private Button[] EJo;
    private NumericUpDown[] JJt;
    private NumericUpDown[] hJV;
    private GroupBox[] lJO;
    private GroupBox[] bJe;
    private DateTimePicker[] wJ8;
    private DateTimePicker[] vJn;
    private Button[] tJQ;
    private int[] pJF = new int[3];
    private IDisposable wJL;
    private GroupBox LJJ;
    private TabControl VJ7;
    private TabPage MJP;
    private TabPage BJi;
    private TabPage pJm;
    private PictureBox SJ0;
    private DateTimePicker KJI;
    private DateTimePicker LJR;
    private ComboBox PJC;
    private ComboBox xJK;
    private Label uJU;
    private Label FJT;
    private Label yJ1;
    private Label CJW;
    private Button PJw;
    private Label JJN;
    private GroupBox IJY;
    private GroupBox EJB;
    private NumericUpDown PJA;
    private NumericUpDown HJf;
    private Label bJ6;
    private Label YJx;
    private GroupBox JJ9;
    private Button YJc;
    private Button tJy;
    private Button AJr;
    private Button iJq;
    private GroupBox AJk;
    private GroupBox AJM;
    private GroupBox KJu;
    private GroupBox qJg;
    private Button VJ2;
    private Button OJ3;
    private ComboBox lJd;
    private PictureBox wJH;
    private Label cJ4;
    private Label qJ5;
    private ComboBox iJs;
    private DateTimePicker DJZ;
    private Label JJa;
    private DateTimePicker AJj;
    private Label XJz;
    private ComboBox x7E;
    private PictureBox A7D;
    private Label l7X;
    private Label f7p;
    private ComboBox S7S;
    private DateTimePicker E7h;
    private Label m7l;
    private DateTimePicker v7G;
    private Label p7b;
    private Button d7v;
    private Label O7o;
    private Label w7t;
    private NumericUpDown p7V;
    private NumericUpDown d7O;
    private Label I7e;
    private Button m78;
    private Label s7n;
    private Label z7Q;
    private NumericUpDown X7F;
    private NumericUpDown M7L;
    private Label n7J;
    private GroupBox k77;
    private Button y7P;
    private Button M7i;
    private Button B7m;
    private GroupBox H70;
    private Button v7I;
    private Button B7R;
    private Button g7C;
    public Class20() {
        NJD();
        lJS = new ComboBox[3]
        {
            xJK,
            lJd,
            Class53
        };
        KJh = new ComboBox[3]
        {
            PJC,
            iJs,
            S7S
        };
        UJl = new PictureBox[3]
        {
            SJ0,
            wJH,
            A7D
        };
        PJG = new Button[3]
        {
            iJq,
            d7v,
            m78
        };
        hJb = new Button[3]
        {
            AJr,
            B7m,
            g7C
        };
        tJv = new Button[3]
        {
            tJy,
            M7i,
            B7R
        };
        EJo = new Button[3]
        {
            YJc,
            y7P,
            v7I
        };
        JJt = new NumericUpDown[3]
        {
            HJf,
            d7O,
            M7L
        };
        hJV = new NumericUpDown[3]
        {
            PJA,
            p7V,
            X7F
        };
        lJO = new GroupBox[3]
        {
            IJY,
            AJk,
            KJu
        };
        bJe = new GroupBox[3]
        {
            EJB,
            AJM,
            qJg
        };
        wJ8 = new DateTimePicker[3]
        {
            LJR,
            AJj,
            v7G
        };
        vJn = new DateTimePicker[3]
        {
            KJI,
            DJZ,
            E7h
        };
        tJQ = new Button[3]
        {
            PJw,
            VJ2,
            OJ3
        };
        sLm();
    }

    private void sLm() {
        for (int i = 0; i < 3; i++) {
            if (Class26.TXZ[i].EhR == -1) {
                bJe[i].Enabled = false;
                lJO[i].Enabled = false;
                tJQ[i].Enabled = false;
            } else {
                Class26.AL aL = Class26.TXZ[i];
                lJS[i].SelectedIndex = aL.PhI;
                wJ8[i].Value = Class115.LHu(aL.ahY);
                vJn[i].Value = Class115.LHu(aL.QhA);
                hJV[i].Value = aL.VhK;
                JJt[i].Value = aL.FhC;
                JJt[i].Maximum = hJV[i].Value;
                hJV[i].Minimum = JJt[i].Value;
                CL0(PJG[i], hJb[i], tJv[i], EJo[i], JJt[i], aL.fhU, aL.UhT, aL.oh1, aL.ahW);
            }

            PJX[i] = true;
        }
    }

    private void CL0(Button button_0, Button button_1, Button button_2, Button button_3, NumericUpDown numericUpDown_0, int int_0, int int_1, int int_2, int int_3) {
        button_0.BackgroundImage = Class38.Jnp(int_0);
        button_1.BackgroundImage = Class38.Jnp(int_1);
        button_2.BackgroundImage = Class38.Jnp(int_2);
        button_3.BackgroundImage = Class38.Jnp(int_3);
        if (!(numericUpDown_0.Value < 4m)) {
            button_3.BackColor = Color.Black;
        } else {
            button_3.BackColor = Color.Gray;
        }

        if (numericUpDown_0.Value < 3m) {
            button_2.BackColor = Color.Gray;
        } else {
            button_2.BackColor = Color.Black;
        }

        if (numericUpDown_0.Value < 2m) {
            button_1.BackColor = Color.Gray;
        } else {
            button_1.BackColor = Color.Black;
        }
    }

    private void kLI(int int_0) {
        KJh[int_0].Items.Clear();
        Dictionary<int, Class25> dictionary = (Dictionary<int, Class25>)((object[])xJp)[lJS[int_0].SelectedIndex];
        foreach (int key in dictionary.Keys) {
            if (!dictionary[key].AjTy() && !dictionary[key].wjTh()) {
                KJh[int_0].Items.Add(dictionary[key].rDY);
            }
        }

        if (!PJX[int_0]) {
            KJh[int_0].SelectedIndex = KJh[int_0].FindStringExact(dictionary[Class26.TXZ[int_0].EhR].rDY);
            return;
        }

        KJh[int_0].SelectedIndex = 0;
        Class26.AL aL = Class26.TXZ[int_0];
        aL.fhU = 0;
        CL0(PJG[int_0], hJb[int_0], tJv[int_0], EJo[int_0], JJt[int_0], aL.fhU, aL.UhT, aL.oh1, aL.ahW);
    }

    private void bLR(object sender, EventArgs e) {
        kLI(0);
    }

    private void LLC(object sender, EventArgs e) {
        kLI(1);
    }

    private void JLK(object sender, EventArgs e) {
        kLI(2);
    }

    private void CLU(int int_0) {
        Class26.AL aL = Class26.TXZ[int_0];
        aL.PhI = lJS[int_0].SelectedIndex;
        Dictionary<int, Class25> dictionary_ = (Dictionary<int, Class25>)((object[])xJp)[aL.PhI];
        aL.EhR = Class4.JDk(KJh[int_0].SelectedItem.ToString(), dictionary_);
        aL.ahY = Class115.DHg(wJ8[int_0]);
        aL.QhA = Class115.DHg(vJn[int_0]);
        MessageBox.Show("Done.");
    }

    private void ILT(object sender, EventArgs e) {
        CLU(0);
    }

    private void pL1(object sender, EventArgs e) {
    }

    private void VLW(int int_0) {
        Dictionary<int, Class25>[] array = new Dictionary<int, Class25>[3]
        {
            Class85.DhZ,
            Class85.Lhs,
            Class85.hh5
        };
        Dictionary<int, Class25> dictionary = array[lJS[int_0].SelectedIndex];
        int num = Class4.JDk(KJh[int_0].SelectedItem.ToString(), dictionary);
        pJF[int_0] = num;
        UJl[int_0].BackgroundImage = (Image)dictionary[num].eDB;
    }

    private void dLw(object sender, EventArgs e) {
        VLW(0);
    }

    private void fLN(object sender, EventArgs e) {
        VLW(1);
    }

    private void yLY(object sender, EventArgs e) {
        VLW(2);
    }

    private void hLB(int int_0) {
        hJV[int_0].Maximum = 4m;
        JJt[int_0].Maximum = 99999m;
        JJt[int_0].Value = Math.Min(JJt[int_0].Value, hJV[int_0].Value);
        JJt[int_0].Maximum = hJV[int_0].Value;
    }

    private void sLA(object sender, EventArgs e) {
        hLB(0);
    }

    private void ELf(object sender, EventArgs e) {
        hLB(1);
    }

    private void lL6(object sender, EventArgs e) {
        hLB(2);
    }

    private void FLx(int int_0) {
        hJV[int_0].Maximum = 4m;
        JJt[int_0].Maximum = hJV[int_0].Value;
        hJV[int_0].Minimum = JJt[int_0].Value;
        Class26.AL aL = Class26.TXZ[int_0];
        CL0(PJG[int_0], hJb[int_0], tJv[int_0], EJo[int_0], JJt[int_0], aL.fhU, aL.UhT, aL.oh1, aL.ahW);
    }

    private void uL9(object sender, EventArgs e) {
        FLx(0);
    }

    private void FLc(object sender, EventArgs e) {
        FLx(1);
    }

    private void KLy(object sender, EventArgs e) {
        FLx(2);
    }

    private void mLr(MouseEventArgs mouseEventArgs_0, int int_0) {
        Dictionary<int, Class25> dictionary = (Dictionary<int, Class25>)((object[])xJp)[lJS[int_0].SelectedIndex];
        _ = dictionary[pJF[int_0]];
        Class26.AL aL = Class26.TXZ[int_0];
        if (mouseEventArgs_0.Button == MouseButtons.Left) {
            aL.fhU = dictionary[pJF[int_0]].VjTo(aL.fhU);
        }

        if (mouseEventArgs_0.Button == MouseButtons.Right) {
            aL.fhU = dictionary[pJF[int_0]].YjT9(aL.fhU);
        }

        CL0(PJG[int_0], hJb[int_0], tJv[int_0], EJo[int_0], JJt[int_0], aL.fhU, aL.UhT, aL.oh1, aL.ahW);
    }

    private void FLq(MouseEventArgs mouseEventArgs_0, int int_0) {
        Dictionary<int, Class25> dictionary = (Dictionary<int, Class25>)((object[])xJp)[lJS[int_0].SelectedIndex];
        _ = dictionary[pJF[int_0]];
        Class26.AL aL = Class26.TXZ[int_0];
        if (mouseEventArgs_0.Button == MouseButtons.Left) {
            aL.UhT = dictionary[pJF[int_0]].tjTc(aL.UhT);
        }

        if (mouseEventArgs_0.Button == MouseButtons.Right) {
            aL.UhT = dictionary[pJF[int_0]].bjTe(aL.UhT);
        }

        CL0(PJG[int_0], hJb[int_0], tJv[int_0], EJo[int_0], JJt[int_0], aL.fhU, aL.UhT, aL.oh1, aL.ahW);
    }

    private void ELk(MouseEventArgs mouseEventArgs_0, int int_0) {
        Dictionary<int, Class25> dictionary = (Dictionary<int, Class25>)((object[])xJp)[lJS[int_0].SelectedIndex];
        _ = dictionary[pJF[int_0]];
        Class26.AL aL = Class26.TXZ[int_0];
        if (mouseEventArgs_0.Button == MouseButtons.Left) {
            aL.oh1 = dictionary[pJF[int_0]].tjTc(aL.oh1);
        }

        if (mouseEventArgs_0.Button == MouseButtons.Right) {
            aL.oh1 = dictionary[pJF[int_0]].bjTe(aL.oh1);
        }

        CL0(PJG[int_0], hJb[int_0], tJv[int_0], EJo[int_0], JJt[int_0], aL.fhU, aL.UhT, aL.oh1, aL.ahW);
    }

    private void OLM(MouseEventArgs mouseEventArgs_0, int int_0) {
        Dictionary<int, Class25> dictionary = (Dictionary<int, Class25>)((object[])xJp)[lJS[int_0].SelectedIndex];
        _ = dictionary[pJF[int_0]];
        Class26.AL aL = Class26.TXZ[int_0];
        if (mouseEventArgs_0.Button == MouseButtons.Left) {
            aL.ahW = dictionary[pJF[int_0]].tjTc(aL.ahW);
        }

        if (mouseEventArgs_0.Button == MouseButtons.Right) {
            aL.ahW = dictionary[pJF[int_0]].bjTe(aL.ahW);
        }

        CL0(PJG[int_0], hJb[int_0], tJv[int_0], EJo[int_0], JJt[int_0], aL.fhU, aL.UhT, aL.oh1, aL.ahW);
    }

    private void bLu(object sender, MouseEventArgs e) {
        mLr(e, 0);
    }

    private void hLg(object sender, MouseEventArgs e) {
        FLq(e, 0);
    }

    private void LL2(object sender, MouseEventArgs e) {
        ELk(e, 0);
    }

    private void dL3(object sender, MouseEventArgs e) {
        OLM(e, 0);
    }

    private void DLd(object sender, MouseEventArgs e) {
        mLr(e, 1);
    }

    private void FLH(object sender, MouseEventArgs e) {
        FLq(e, 1);
    }

    private void YL4(object sender, MouseEventArgs e) {
        ELk(e, 1);
    }

    private void gL5(object sender, MouseEventArgs e) {
        OLM(e, 1);
    }

    private void PLs(object sender, MouseEventArgs e) {
        mLr(e, 2);
    }

    private void ALZ(object sender, MouseEventArgs e) {
        FLq(e, 2);
    }

    private void OLa(object sender, MouseEventArgs e) {
        ELk(e, 2);
    }

    private void lLj(object sender, MouseEventArgs e) {
        OLM(e, 2);
    }

    private void RLz(object sender, EventArgs e) {
        CLU(2);
    }

    private void CJE(object sender, EventArgs e) {
        CLU(1);
    }

    protected override void Dispose(bool disposing) {
        if (disposing && wJL != null) {
            wJL.Dispose();
        }

        base.Dispose(disposing);
    }

    private void NJD() {
        LJJ = new GroupBox();
        VJ7 = new TabControl();
        MJP = new TabPage();
        IJY = new GroupBox();
        iJq = new Button();
        JJ9 = new GroupBox();
        YJc = new Button();
        tJy = new Button();
        AJr = new Button();
        bJ6 = new Label();
        YJx = new Label();
        PJA = new NumericUpDown();
        HJf = new NumericUpDown();
        JJN = new Label();
        EJB = new GroupBox();
        xJK = new ComboBox();
        SJ0 = new PictureBox();
        uJU = new Label();
        FJT = new Label();
        PJC = new ComboBox();
        KJI = new DateTimePicker();
        CJW = new Label();
        LJR = new DateTimePicker();
        yJ1 = new Label();
        PJw = new Button();
        BJi = new TabPage();
        VJ2 = new Button();
        AJk = new GroupBox();
        k77 = new GroupBox();
        y7P = new Button();
        M7i = new Button();
        B7m = new Button();
        d7v = new Button();
        O7o = new Label();
        w7t = new Label();
        p7V = new NumericUpDown();
        d7O = new NumericUpDown();
        I7e = new Label();
        AJM = new GroupBox();
        lJd = new ComboBox();
        wJH = new PictureBox();
        cJ4 = new Label();
        qJ5 = new Label();
        iJs = new ComboBox();
        DJZ = new DateTimePicker();
        JJa = new Label();
        AJj = new DateTimePicker();
        XJz = new Label();
        pJm = new TabPage();
        OJ3 = new Button();
        KJu = new GroupBox();
        H70 = new GroupBox();
        v7I = new Button();
        B7R = new Button();
        g7C = new Button();
        m78 = new Button();
        s7n = new Label();
        z7Q = new Label();
        X7F = new NumericUpDown();
        M7L = new NumericUpDown();
        n7J = new Label();
        qJg = new GroupBox();
        Class53 = new ComboBox();
        A7D = new PictureBox();
        l7X = new Label();
        f7p = new Label();
        S7S = new ComboBox();
        E7h = new DateTimePicker();
        m7l = new Label();
        v7G = new DateTimePicker();
        p7b = new Label();
        LJJ.SuspendLayout();
        VJ7.SuspendLayout();
        MJP.SuspendLayout();
        IJY.SuspendLayout();
        JJ9.SuspendLayout();
        ((ISupportInitialize)PJA).BeginInit();
        ((ISupportInitialize)HJf).BeginInit();
        EJB.SuspendLayout();
        ((ISupportInitialize)SJ0).BeginInit();
        BJi.SuspendLayout();
        AJk.SuspendLayout();
        k77.SuspendLayout();
        ((ISupportInitialize)p7V).BeginInit();
        ((ISupportInitialize)d7O).BeginInit();
        AJM.SuspendLayout();
        ((ISupportInitialize)wJH).BeginInit();
        pJm.SuspendLayout();
        KJu.SuspendLayout();
        H70.SuspendLayout();
        ((ISupportInitialize)X7F).BeginInit();
        ((ISupportInitialize)M7L).BeginInit();
        qJg.SuspendLayout();
        ((ISupportInitialize)A7D).BeginInit();
        SuspendLayout();
        LJJ.Controls.Add(VJ7);
        LJJ.Location = new Point(12, 12);
        LJJ.Name = "groupBox1";
        LJJ.Size = new Size(727, 309);
        LJJ.TabIndex = 0;
        LJJ.TabStop = false;
        LJJ.Text = "Murch Orders";
        VJ7.Controls.Add(MJP);
        VJ7.Controls.Add(BJi);
        VJ7.Controls.Add(pJm);
        VJ7.Location = new Point(6, 19);
        VJ7.Name = "tabControl1";
        VJ7.SelectedIndex = 0;
        VJ7.Size = new Size(715, 275);
        VJ7.TabIndex = 0;
        MJP.Controls.Add(IJY);
        MJP.Controls.Add(EJB);
        MJP.Controls.Add(PJw);
        MJP.Location = new Point(4, 22);
        MJP.Name = "TB_order1";
        MJP.Padding = new Padding(3);
        MJP.Size = new Size(707, 249);
        MJP.TabIndex = 0;
        MJP.Text = "Order 1";
        MJP.UseVisualStyleBackColor = true;
        IJY.Controls.Add(iJq);
        IJY.Controls.Add(JJ9);
        IJY.Controls.Add(bJ6);
        IJY.Controls.Add(YJx);
        IJY.Controls.Add(PJA);
        IJY.Controls.Add(HJf);
        IJY.Controls.Add(JJN);
        IJY.Location = new Point(359, 19);
        IJY.Name = "GB_GearInfo1";
        IJY.Size = new Size(330, 188);
        IJY.TabIndex = 18;
        IJY.TabStop = false;
        IJY.Text = "Gear Info";
        iJq.BackColor = Color.Black;
        iJq.Location = new Point(240, 23);
        iJq.Name = "B_Main1";
        iJq.Size = new Size(64, 64);
        iJq.TabIndex = 22;
        iJq.UseVisualStyleBackColor = false;
        iJq.MouseDown += bLu;
        JJ9.Controls.Add(YJc);
        JJ9.Controls.Add(tJy);
        JJ9.Controls.Add(AJr);
        JJ9.Location = new Point(16, 89);
        JJ9.Name = "groupBox4";
        JJ9.Size = new Size(308, 93);
        JJ9.TabIndex = 21;
        JJ9.TabStop = false;
        JJ9.Text = "Sub Abilities";
        YJc.BackColor = Color.Black;
        YJc.Location = new Point(224, 19);
        YJc.Name = "B_Sub13";
        YJc.Size = new Size(64, 64);
        YJc.TabIndex = 2;
        YJc.UseVisualStyleBackColor = false;
        YJc.MouseDown += dL3;
        tJy.BackColor = Color.Black;
        tJy.Location = new Point(120, 19);
        tJy.Name = "B_Sub12";
        tJy.Size = new Size(64, 64);
        tJy.TabIndex = 1;
        tJy.UseVisualStyleBackColor = false;
        tJy.MouseDown += LL2;
        AJr.BackColor = Color.Black;
        AJr.Location = new Point(16, 19);
        AJr.Name = "B_Sub11";
        AJr.Size = new Size(64, 64);
        AJr.TabIndex = 0;
        AJr.UseVisualStyleBackColor = false;
        AJr.MouseDown += hLg;
        bJ6.Font = new Font("Microsoft Sans Serif", 9.75f);
        bJ6.Location = new Point(13, 65);
        bJ6.Name = "label9";
        bJ6.Size = new Size(103, 18);
        bJ6.TabIndex = 20;
        bJ6.Text = "Leveled Slots";
        YJx.Font = new Font("Microsoft Sans Serif", 9.75f);
        YJx.Location = new Point(13, 36);
        YJx.Name = "label8";
        YJx.Size = new Size(103, 20);
        YJx.TabIndex = 19;
        YJx.Text = "Unlocked Slots";
        PJA.Location = new Point(122, 36);
        PJA.Maximum = new decimal(new int[4] { 4, 0, 0, 0 });
        PJA.Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
        PJA.Name = "NUD_Unlocked1";
        PJA.Size = new Size(30, 20);
        PJA.TabIndex = 18;
        PJA.Value = new decimal(new int[4] { 1, 0, 0, 0 });
        PJA.ValueChanged += sLA;
        HJf.Location = new Point(122, 63);
        HJf.Maximum = new decimal(new int[4] { 4, 0, 0, 0 });
        HJf.Name = "NUD_Leveled1";
        HJf.Size = new Size(30, 20);
        HJf.TabIndex = 17;
        HJf.ValueChanged += uL9;
        JJN.Font = new Font("Microsoft Sans Serif", 9.75f);
        JJN.Location = new Point(167, 36);
        JJN.Name = "label7";
        JJN.Size = new Size(67, 34);
        JJN.TabIndex = 0;
        JJN.Text = "Main Ability";
        EJB.Controls.Add(xJK);
        EJB.Controls.Add(SJ0);
        EJB.Controls.Add(uJU);
        EJB.Controls.Add(FJT);
        EJB.Controls.Add(PJC);
        EJB.Controls.Add(KJI);
        EJB.Controls.Add(CJW);
        EJB.Controls.Add(LJR);
        EJB.Controls.Add(yJ1);
        EJB.Location = new Point(6, 19);
        EJB.Name = "GB_GeneralInfo1";
        EJB.Size = new Size(347, 188);
        EJB.TabIndex = 17;
        EJB.TabStop = false;
        EJB.Text = "General Info";
        xJK.DropDownStyle = ComboBoxStyle.DropDownList;
        xJK.FormattingEnabled = true;
        xJK.Items.AddRange(new object[3] { "Shoes", "Clothes", "Head" });
        xJK.Location = new Point(98, 32);
        xJK.Name = "CB_GearType1";
        xJK.Size = new Size(121, 21);
        xJK.TabIndex = 3;
        xJK.SelectedIndexChanged += bLR;
        SJ0.BackgroundImageLayout = ImageLayout.Zoom;
        SJ0.Location = new Point(242, 23);
        SJ0.Name = "PB_Gear1";
        SJ0.Size = new Size(80, 80);
        SJ0.TabIndex = 2;
        SJ0.TabStop = false;
        uJU.AutoSize = true;
        uJU.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
        uJU.Location = new Point(10, 152);
        uJU.Name = "label5";
        uJU.Size = new Size(46, 16);
        uJU.TabIndex = 11;
        uJU.Text = "Arrival";
        FJT.AutoSize = true;
        FJT.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
        FJT.Location = new Point(10, 118);
        FJT.Name = "label4";
        FJT.Size = new Size(50, 16);
        FJT.TabIndex = 10;
        FJT.Text = "Orderd";
        PJC.FormattingEnabled = true;
        PJC.Location = new Point(98, 71);
        PJC.Name = "CB_Gear1";
        PJC.Size = new Size(121, 21);
        PJC.TabIndex = 5;
        PJC.SelectedIndexChanged += dLw;
        KJI.CustomFormat = "MM / dd / yyyy";
        KJI.Format = DateTimePickerFormat.Short;
        KJI.Location = new Point(98, 152);
        KJI.MaxDate = new DateTime(9998, 1, 1, 0, 0, 0, 0);
        KJI.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
        KJI.Name = "DTP_Arrival1";
        KJI.Size = new Size(224, 20);
        KJI.TabIndex = 1;
        KJI.Value = new DateTime(2000, 1, 1, 0, 0, 0, 0);
        CJW.AutoSize = true;
        CJW.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
        CJW.Location = new Point(10, 36);
        CJW.Name = "label1";
        CJW.Size = new Size(85, 16);
        CJW.TabIndex = 7;
        CJW.Text = "Type of gear";
        LJR.CustomFormat = "MM / dd / yyyy";
        LJR.Format = DateTimePickerFormat.Short;
        LJR.Location = new Point(98, 118);
        LJR.MaxDate = new DateTime(9998, 1, 1, 0, 0, 0, 0);
        LJR.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
        LJR.Name = "DTP_Ordered1";
        LJR.Size = new Size(224, 20);
        LJR.TabIndex = 0;
        LJR.Value = new DateTime(2000, 1, 1, 0, 0, 0, 0);
        yJ1.AutoSize = true;
        yJ1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
        yJ1.Location = new Point(10, 71);
        yJ1.Name = "label3";
        yJ1.Size = new Size(38, 16);
        yJ1.TabIndex = 9;
        yJ1.Text = "Gear";
        PJw.Location = new Point(318, 214);
        PJw.Name = "Button_SaveSlot1";
        PJw.Size = new Size(75, 23);
        PJw.TabIndex = 6;
        PJw.Text = "Save Slot";
        PJw.UseVisualStyleBackColor = true;
        PJw.Click += ILT;
        BJi.Controls.Add(VJ2);
        BJi.Controls.Add(AJk);
        BJi.Controls.Add(AJM);
        BJi.Location = new Point(4, 22);
        BJi.Name = "TB_order2";
        BJi.Padding = new Padding(3);
        BJi.Size = new Size(707, 249);
        BJi.TabIndex = 1;
        BJi.Text = "Order 2";
        BJi.UseVisualStyleBackColor = true;
        VJ2.Location = new Point(318, 214);
        VJ2.Name = "Button_SaveSlot2";
        VJ2.Size = new Size(75, 23);
        VJ2.TabIndex = 2;
        VJ2.Text = "Save Slot";
        VJ2.UseVisualStyleBackColor = true;
        VJ2.Click += CJE;
        AJk.Controls.Add(k77);
        AJk.Controls.Add(d7v);
        AJk.Controls.Add(O7o);
        AJk.Controls.Add(w7t);
        AJk.Controls.Add(p7V);
        AJk.Controls.Add(d7O);
        AJk.Controls.Add(I7e);
        AJk.Location = new Point(359, 19);
        AJk.Name = "GB_GearInfo2";
        AJk.Size = new Size(330, 188);
        AJk.TabIndex = 1;
        AJk.TabStop = false;
        AJk.Text = "Gear Info";
        k77.Controls.Add(y7P);
        k77.Controls.Add(M7i);
        k77.Controls.Add(B7m);
        k77.Location = new Point(16, 89);
        k77.Name = "groupBox2";
        k77.Size = new Size(308, 93);
        k77.TabIndex = 29;
        k77.TabStop = false;
        k77.Text = "Sub Abilities";
        y7P.BackColor = Color.Black;
        y7P.Location = new Point(224, 19);
        y7P.Name = "B_Sub23";
        y7P.Size = new Size(64, 64);
        y7P.TabIndex = 2;
        y7P.UseVisualStyleBackColor = false;
        y7P.MouseDown += gL5;
        M7i.BackColor = Color.Black;
        M7i.Location = new Point(120, 19);
        M7i.Name = "B_Sub22";
        M7i.Size = new Size(64, 64);
        M7i.TabIndex = 1;
        M7i.UseVisualStyleBackColor = false;
        M7i.MouseDown += YL4;
        B7m.BackColor = Color.Black;
        B7m.Location = new Point(16, 19);
        B7m.Name = "B_Sub21";
        B7m.Size = new Size(64, 64);
        B7m.TabIndex = 0;
        B7m.UseVisualStyleBackColor = false;
        B7m.MouseDown += FLH;
        d7v.BackColor = Color.Black;
        d7v.Location = new Point(240, 23);
        d7v.Name = "B_Main2";
        d7v.Size = new Size(64, 64);
        d7v.TabIndex = 28;
        d7v.UseVisualStyleBackColor = false;
        d7v.MouseDown += DLd;
        O7o.Font = new Font("Microsoft Sans Serif", 9.75f);
        O7o.Location = new Point(13, 65);
        O7o.Name = "label16";
        O7o.Size = new Size(103, 18);
        O7o.TabIndex = 27;
        O7o.Text = "Leveled Slots";
        w7t.Font = new Font("Microsoft Sans Serif", 9.75f);
        w7t.Location = new Point(13, 36);
        w7t.Name = "label17";
        w7t.Size = new Size(103, 20);
        w7t.TabIndex = 26;
        w7t.Text = "Unlocked Slots";
        p7V.Location = new Point(122, 36);
        p7V.Maximum = new decimal(new int[4] { 4, 0, 0, 0 });
        p7V.Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
        p7V.Name = "NUD_Unlocked2";
        p7V.Size = new Size(30, 20);
        p7V.TabIndex = 25;
        p7V.Value = new decimal(new int[4] { 1, 0, 0, 0 });
        p7V.ValueChanged += ELf;
        d7O.Location = new Point(122, 63);
        d7O.Maximum = new decimal(new int[4] { 4, 0, 0, 0 });
        d7O.Name = "NUD_Leveled2";
        d7O.Size = new Size(30, 20);
        d7O.TabIndex = 24;
        d7O.ValueChanged += FLc;
        I7e.Font = new Font("Microsoft Sans Serif", 9.75f);
        I7e.Location = new Point(167, 36);
        I7e.Name = "label18";
        I7e.Size = new Size(67, 34);
        I7e.TabIndex = 23;
        I7e.Text = "Main Ability";
        AJM.Controls.Add(lJd);
        AJM.Controls.Add(wJH);
        AJM.Controls.Add(cJ4);
        AJM.Controls.Add(qJ5);
        AJM.Controls.Add(iJs);
        AJM.Controls.Add(DJZ);
        AJM.Controls.Add(JJa);
        AJM.Controls.Add(AJj);
        AJM.Controls.Add(XJz);
        AJM.Location = new Point(6, 19);
        AJM.Name = "GB_GeneralInfo2";
        AJM.Size = new Size(347, 188);
        AJM.TabIndex = 0;
        AJM.TabStop = false;
        AJM.Text = "General Info";
        lJd.DropDownStyle = ComboBoxStyle.DropDownList;
        lJd.FormattingEnabled = true;
        lJd.Items.AddRange(new object[3] { "Shoes", "Clothes", "Head" });
        lJd.Location = new Point(98, 32);
        lJd.Name = "CB_GearType2";
        lJd.Size = new Size(121, 21);
        lJd.TabIndex = 15;
        lJd.SelectedIndexChanged += LLC;
        wJH.BackgroundImageLayout = ImageLayout.Zoom;
        wJH.Location = new Point(242, 23);
        wJH.Name = "PB_Gear2";
        wJH.Size = new Size(80, 80);
        wJH.TabIndex = 14;
        wJH.TabStop = false;
        cJ4.AutoSize = true;
        cJ4.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
        cJ4.Location = new Point(10, 152);
        cJ4.Name = "label2";
        cJ4.Size = new Size(46, 16);
        cJ4.TabIndex = 20;
        cJ4.Text = "Arrival";
        qJ5.AutoSize = true;
        qJ5.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
        qJ5.Location = new Point(10, 118);
        qJ5.Name = "label6";
        qJ5.Size = new Size(50, 16);
        qJ5.TabIndex = 19;
        qJ5.Text = "Orderd";
        iJs.FormattingEnabled = true;
        iJs.Location = new Point(98, 71);
        iJs.Name = "CB_Gear2";
        iJs.Size = new Size(121, 21);
        iJs.TabIndex = 16;
        iJs.SelectedIndexChanged += fLN;
        DJZ.CustomFormat = "MM/dd/yyyy";
        DJZ.Format = DateTimePickerFormat.Short;
        DJZ.Location = new Point(98, 152);
        DJZ.MaxDate = new DateTime(9998, 1, 1, 0, 0, 0, 0);
        DJZ.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
        DJZ.Name = "DTP_Arrival2";
        DJZ.Size = new Size(224, 20);
        DJZ.TabIndex = 13;
        DJZ.Value = new DateTime(2000, 1, 1, 0, 0, 0, 0);
        JJa.AutoSize = true;
        JJa.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
        JJa.Location = new Point(10, 36);
        JJa.Name = "label10";
        JJa.Size = new Size(85, 16);
        JJa.TabIndex = 17;
        JJa.Text = "Type of gear";
        AJj.CustomFormat = "MM/dd/yyyy";
        AJj.Format = DateTimePickerFormat.Short;
        AJj.Location = new Point(98, 118);
        AJj.MaxDate = new DateTime(9998, 1, 1, 0, 0, 0, 0);
        AJj.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
        AJj.Name = "DTP_Ordered2";
        AJj.Size = new Size(224, 20);
        AJj.TabIndex = 12;
        AJj.Value = new DateTime(2000, 1, 1, 0, 0, 0, 0);
        XJz.AutoSize = true;
        XJz.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
        XJz.Location = new Point(10, 71);
        XJz.Name = "label11";
        XJz.Size = new Size(38, 16);
        XJz.TabIndex = 18;
        XJz.Text = "Gear";
        pJm.Controls.Add(OJ3);
        pJm.Controls.Add(KJu);
        pJm.Controls.Add(qJg);
        pJm.Location = new Point(4, 22);
        pJm.Name = "TB_order3";
        pJm.Padding = new Padding(3);
        pJm.Size = new Size(707, 249);
        pJm.TabIndex = 2;
        pJm.Text = "Order 3";
        pJm.UseVisualStyleBackColor = true;
        OJ3.Location = new Point(318, 214);
        OJ3.Name = "Button_SaveSlot3";
        OJ3.Size = new Size(75, 23);
        OJ3.TabIndex = 2;
        OJ3.Text = "Save Slot";
        OJ3.UseVisualStyleBackColor = true;
        OJ3.Click += RLz;
        KJu.Controls.Add(H70);
        KJu.Controls.Add(m78);
        KJu.Controls.Add(s7n);
        KJu.Controls.Add(z7Q);
        KJu.Controls.Add(X7F);
        KJu.Controls.Add(M7L);
        KJu.Controls.Add(n7J);
        KJu.Location = new Point(359, 19);
        KJu.Name = "GB_GearInfo3";
        KJu.Size = new Size(330, 188);
        KJu.TabIndex = 1;
        KJu.TabStop = false;
        KJu.Text = "Gear Info";
        H70.Controls.Add(v7I);
        H70.Controls.Add(B7R);
        H70.Controls.Add(g7C);
        H70.Location = new Point(16, 89);
        H70.Name = "groupBox3";
        H70.Size = new Size(308, 93);
        H70.TabIndex = 29;
        H70.TabStop = false;
        H70.Text = "Sub Abilities";
        v7I.BackColor = Color.Black;
        v7I.Location = new Point(224, 19);
        v7I.Name = "B_Sub33";
        v7I.Size = new Size(64, 64);
        v7I.TabIndex = 2;
        v7I.UseVisualStyleBackColor = false;
        v7I.MouseDown += lLj;
        B7R.BackColor = Color.Black;
        B7R.Location = new Point(120, 19);
        B7R.Name = "B_Sub32";
        B7R.Size = new Size(64, 64);
        B7R.TabIndex = 1;
        B7R.UseVisualStyleBackColor = false;
        B7R.MouseDown += OLa;
        g7C.BackColor = Color.Black;
        g7C.Location = new Point(16, 19);
        g7C.Name = "B_Sub31";
        g7C.Size = new Size(64, 64);
        g7C.TabIndex = 0;
        g7C.UseVisualStyleBackColor = false;
        g7C.MouseDown += ALZ;
        m78.BackColor = Color.Black;
        m78.Location = new Point(240, 23);
        m78.Name = "B_Main3";
        m78.Size = new Size(64, 64);
        m78.TabIndex = 28;
        m78.UseVisualStyleBackColor = false;
        m78.MouseDown += PLs;
        s7n.Font = new Font("Microsoft Sans Serif", 9.75f);
        s7n.Location = new Point(13, 65);
        s7n.Name = "label19";
        s7n.Size = new Size(103, 18);
        s7n.TabIndex = 27;
        s7n.Text = "Leveled Slots";
        z7Q.Font = new Font("Microsoft Sans Serif", 9.75f);
        z7Q.Location = new Point(13, 36);
        z7Q.Name = "label20";
        z7Q.Size = new Size(103, 20);
        z7Q.TabIndex = 26;
        z7Q.Text = "Unlocked Slots";
        X7F.Location = new Point(122, 36);
        X7F.Maximum = new decimal(new int[4] { 4, 0, 0, 0 });
        X7F.Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
        X7F.Name = "NUD_Unlocked3";
        X7F.Size = new Size(30, 20);
        X7F.TabIndex = 25;
        X7F.Value = new decimal(new int[4] { 1, 0, 0, 0 });
        X7F.ValueChanged += lL6;
        M7L.Location = new Point(122, 63);
        M7L.Maximum = new decimal(new int[4] { 4, 0, 0, 0 });
        M7L.Name = "NUD_Leveled3";
        M7L.Size = new Size(30, 20);
        M7L.TabIndex = 24;
        M7L.ValueChanged += KLy;
        n7J.Font = new Font("Microsoft Sans Serif", 9.75f);
        n7J.Location = new Point(167, 36);
        n7J.Name = "label21";
        n7J.Size = new Size(67, 34);
        n7J.TabIndex = 23;
        n7J.Text = "Main Ability";
        qJg.Controls.Add(Class53);
        qJg.Controls.Add(A7D);
        qJg.Controls.Add(l7X);
        qJg.Controls.Add(f7p);
        qJg.Controls.Add(S7S);
        qJg.Controls.Add(E7h);
        qJg.Controls.Add(m7l);
        qJg.Controls.Add(v7G);
        qJg.Controls.Add(p7b);
        qJg.Location = new Point(6, 19);
        qJg.Name = "GB_GeneralInfo3";
        qJg.Size = new Size(347, 188);
        qJg.TabIndex = 0;
        qJg.TabStop = false;
        qJg.Text = "General Info";
        Class53.DropDownStyle = ComboBoxStyle.DropDownList;
        Class53.FormattingEnabled = true;
        Class53.Items.AddRange(new object[3] { "Shoes", "Clothes", "Head" });
        Class53.Location = new Point(98, 32);
        Class53.Name = "CB_GearType3";
        Class53.Size = new Size(121, 21);
        Class53.TabIndex = 15;
        Class53.SelectedIndexChanged += JLK;
        A7D.BackgroundImageLayout = ImageLayout.Zoom;
        A7D.Location = new Point(242, 23);
        A7D.Name = "PB_Gear3";
        A7D.Size = new Size(80, 80);
        A7D.TabIndex = 14;
        A7D.TabStop = false;
        l7X.AutoSize = true;
        l7X.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
        l7X.Location = new Point(10, 152);
        l7X.Name = "label12";
        l7X.Size = new Size(46, 16);
        l7X.TabIndex = 20;
        l7X.Text = "Arrival";
        f7p.AutoSize = true;
        f7p.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
        f7p.Location = new Point(10, 118);
        f7p.Name = "label13";
        f7p.Size = new Size(50, 16);
        f7p.TabIndex = 19;
        f7p.Text = "Orderd";
        S7S.FormattingEnabled = true;
        S7S.Location = new Point(98, 71);
        S7S.Name = "CB_Gear3";
        S7S.Size = new Size(121, 21);
        S7S.TabIndex = 16;
        S7S.SelectedIndexChanged += yLY;
        E7h.CustomFormat = "MM/dd/yyyy";
        E7h.Format = DateTimePickerFormat.Short;
        E7h.Location = new Point(98, 152);
        E7h.MaxDate = new DateTime(9998, 1, 1, 0, 0, 0, 0);
        E7h.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
        E7h.Name = "DTP_Arrival3";
        E7h.Size = new Size(224, 20);
        E7h.TabIndex = 13;
        E7h.Value = new DateTime(2000, 1, 1, 0, 0, 0, 0);
        m7l.AutoSize = true;
        m7l.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
        m7l.Location = new Point(10, 36);
        m7l.Name = "label14";
        m7l.Size = new Size(85, 16);
        m7l.TabIndex = 17;
        m7l.Text = "Type of gear";
        v7G.CustomFormat = "MM/dd/yyyy";
        v7G.Format = DateTimePickerFormat.Short;
        v7G.Location = new Point(98, 118);
        v7G.MaxDate = new DateTime(9998, 1, 1, 0, 0, 0, 0);
        v7G.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
        v7G.Name = "DTP_Ordered3";
        v7G.Size = new Size(224, 20);
        v7G.TabIndex = 12;
        v7G.Value = new DateTime(2000, 1, 1, 0, 0, 0, 0);
        p7b.AutoSize = true;
        p7b.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
        p7b.Location = new Point(10, 71);
        p7b.Name = "label15";
        p7b.Size = new Size(38, 16);
        p7b.TabIndex = 18;
        p7b.Text = "Gear";
        base.AutoScaleDimensions = new SizeF(6f, 13f);
        base.AutoScaleMode = AutoScaleMode.Font;
        base.ClientSize = new Size(751, 319);
        base.Controls.Add(LJJ);
        base.Name = "MurchOrderSplat2";
        base.ShowIcon = false;
        Text = "SplatHeX - Splatoon 2 - Murch Order Editor";
        LJJ.ResumeLayout(performLayout: false);
        VJ7.ResumeLayout(performLayout: false);
        MJP.ResumeLayout(performLayout: false);
        IJY.ResumeLayout(performLayout: false);
        JJ9.ResumeLayout(performLayout: false);
        ((ISupportInitialize)PJA).EndInit();
        ((ISupportInitialize)HJf).EndInit();
        EJB.ResumeLayout(performLayout: false);
        EJB.PerformLayout();
        ((ISupportInitialize)SJ0).EndInit();
        BJi.ResumeLayout(performLayout: false);
        AJk.ResumeLayout(performLayout: false);
        k77.ResumeLayout(performLayout: false);
        ((ISupportInitialize)p7V).EndInit();
        ((ISupportInitialize)d7O).EndInit();
        AJM.ResumeLayout(performLayout: false);
        AJM.PerformLayout();
        ((ISupportInitialize)wJH).EndInit();
        pJm.ResumeLayout(performLayout: false);
        KJu.ResumeLayout(performLayout: false);
        H70.ResumeLayout(performLayout: false);
        ((ISupportInitialize)X7F).EndInit();
        ((ISupportInitialize)M7L).EndInit();
        qJg.ResumeLayout(performLayout: false);
        qJg.PerformLayout();
        ((ISupportInitialize)A7D).EndInit();
        ResumeLayout(performLayout: false);
    }
}