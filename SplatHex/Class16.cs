using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace SplatHex;
public class Class16 : Form {
    private ComboBox[] JOe;
    private IDisposable dO8;
    private ComboBox jOn;
    private PictureBox zOQ;
    private GroupBox COF;
    private PictureBox ROL;
    private PictureBox dOJ;
    private PictureBox MO7;
    private PictureBox tOP;
    private PictureBox pOi;
    private PictureBox LOm;
    private PictureBox XO0;
    private PictureBox QOI;
    private PictureBox dOR;
    private PictureBox dOC;
    private PictureBox POK;
    private PictureBox eOU;
    private PictureBox yOT;
    private PictureBox KO1;
    private PictureBox wOW;
    private PictureBox COw;
    private PictureBox PON;
    private PictureBox rOY;
    private PictureBox sOB;
    private Label POA;
    private Button TOf;
    private Button lO6;
    private Button QOx;
    private Label HO9;
    private ComboBox eOc;
    private ComboBox COy;
    private ComboBox IOr;
    private ComboBox wOq;
    private ComboBox GOk;
    private ComboBox UOM;
    private ComboBox hOu;
    private ComboBox rOg;
    private ComboBox kO2;
    private ComboBox iO3;
    private ComboBox JOd;
    private ComboBox uOH;
    private ComboBox eO4;
    private ComboBox EO5;
    private ComboBox JOs;
    private ComboBox DOZ;
    private ComboBox aOa;
    private ComboBox dOj;
    private ComboBox vOz;
    private ComboBox seE;
    public Class16() {
        lOO();
        JOe = new ComboBox[20]
        {
            seE,
            vOz,
            dOj,
            aOa,
            DOZ,
            JOs,
            EO5,
            eO4,
            uOH,
            JOd,
            iO3,
            kO2,
            rOg,
            hOu,
            UOM,
            GOk,
            wOq,
            IOr,
            COy,
            eOc
        };
        wOG();
    }

    private void wOG() {
        jOn.SelectedIndex = 0;
        fOv(jOn.SelectedIndex);
    }

    private void YOb(object sender, EventArgs e) {
        fOv(jOn.SelectedIndex);
    }

    private void fOv(int int_0) {
        if (int_0 == 0) {
            for (int i = 0; i < Class108.bo5.Length; i++) {
                JOe[i].SelectedIndex = Class108.bo5[i].ftg;
            }
        }

        if (int_0 == 1) {
            for (int j = 0; j < Class108.kos.Length; j++) {
                JOe[j].SelectedIndex = Class108.kos[j].ftg;
            }
        }

        if (int_0 == 2) {
            for (int k = 0; k < Class108.yoZ.Length; k++) {
                JOe[k].SelectedIndex = Class108.yoZ[k].ftg;
            }
        }
    }

    private void EOo(object sender, EventArgs e) {
        if (jOn.SelectedIndex == 0) {
            for (int i = 0; i < JOe.Length; i++) {
                Class108.bo5[i].ftg = JOe[i].SelectedIndex;
            }
        }

        if (jOn.SelectedIndex == 1) {
            for (int j = 0; j < JOe.Length; j++) {
                Class108.kos[j].ftg = JOe[j].SelectedIndex;
            }
        }

        if (jOn.SelectedIndex == 2) {
            for (int k = 0; k < JOe.Length; k++) {
                Class108.yoZ[k].ftg = JOe[k].SelectedIndex;
            }
        }
    }

    private void kOt(object sender, EventArgs e) {
        for (int i = 0; i < JOe.Length; i++) {
            JOe[i].SelectedIndex = 0;
        }
    }

    private void XOV(object sender, EventArgs e) {
        for (int i = 0; i < JOe.Length; i++) {
            JOe[i].SelectedIndex = 4;
        }
    }

    protected override void Dispose(bool disposing) {
        if (disposing && dO8 != null) {
            dO8.Dispose();
        }

        base.Dispose(disposing);
    }

    private void lOO() {
        jOn = new ComboBox();
        zOQ = new PictureBox();
        COF = new GroupBox();
        eOc = new ComboBox();
        COy = new ComboBox();
        IOr = new ComboBox();
        TOf = new Button();
        wOq = new ComboBox();
        GOk = new ComboBox();
        UOM = new ComboBox();
        hOu = new ComboBox();
        rOg = new ComboBox();
        kO2 = new ComboBox();
        iO3 = new ComboBox();
        JOd = new ComboBox();
        uOH = new ComboBox();
        eO4 = new ComboBox();
        EO5 = new ComboBox();
        JOs = new ComboBox();
        DOZ = new ComboBox();
        aOa = new ComboBox();
        dOj = new ComboBox();
        vOz = new ComboBox();
        ROL = new PictureBox();
        dOJ = new PictureBox();
        MO7 = new PictureBox();
        tOP = new PictureBox();
        seE = new ComboBox();
        pOi = new PictureBox();
        LOm = new PictureBox();
        XO0 = new PictureBox();
        QOI = new PictureBox();
        dOR = new PictureBox();
        dOC = new PictureBox();
        POK = new PictureBox();
        eOU = new PictureBox();
        yOT = new PictureBox();
        KO1 = new PictureBox();
        wOW = new PictureBox();
        COw = new PictureBox();
        PON = new PictureBox();
        rOY = new PictureBox();
        sOB = new PictureBox();
        POA = new Label();
        lO6 = new Button();
        QOx = new Button();
        HO9 = new Label();
        ((ISupportInitialize)zOQ).BeginInit();
        COF.SuspendLayout();
        ((ISupportInitialize)ROL).BeginInit();
        ((ISupportInitialize)dOJ).BeginInit();
        ((ISupportInitialize)MO7).BeginInit();
        ((ISupportInitialize)tOP).BeginInit();
        ((ISupportInitialize)pOi).BeginInit();
        ((ISupportInitialize)LOm).BeginInit();
        ((ISupportInitialize)XO0).BeginInit();
        ((ISupportInitialize)QOI).BeginInit();
        ((ISupportInitialize)dOR).BeginInit();
        ((ISupportInitialize)dOC).BeginInit();
        ((ISupportInitialize)POK).BeginInit();
        ((ISupportInitialize)eOU).BeginInit();
        ((ISupportInitialize)yOT).BeginInit();
        ((ISupportInitialize)KO1).BeginInit();
        ((ISupportInitialize)wOW).BeginInit();
        ((ISupportInitialize)COw).BeginInit();
        ((ISupportInitialize)PON).BeginInit();
        ((ISupportInitialize)rOY).BeginInit();
        ((ISupportInitialize)sOB).BeginInit();
        SuspendLayout();
        jOn.DropDownStyle = ComboBoxStyle.DropDownList;
        jOn.FormattingEnabled = true;
        jOn.Items.AddRange(new object[3] { "Inkling Girl", "Inkling Boy", "Squid" });
        jOn.Location = new Point(12, 24);
        jOn.Name = "CB_amiibo";
        jOn.Size = new Size(121, 21);
        jOn.TabIndex = 0;
        jOn.SelectedIndexChanged += YOb;
        zOQ.Image = Resources.Stage_01_Splat1;
        zOQ.Location = new Point(6, 19);
        zOQ.Name = "PB_Challenge01";
        zOQ.Size = new Size(81, 86);
        zOQ.SizeMode = PictureBoxSizeMode.Zoom;
        zOQ.TabIndex = 1;
        zOQ.TabStop = false;
        COF.Controls.Add(eOc);
        COF.Controls.Add(COy);
        COF.Controls.Add(IOr);
        COF.Controls.Add(TOf);
        COF.Controls.Add(wOq);
        COF.Controls.Add(GOk);
        COF.Controls.Add(UOM);
        COF.Controls.Add(hOu);
        COF.Controls.Add(rOg);
        COF.Controls.Add(kO2);
        COF.Controls.Add(iO3);
        COF.Controls.Add(JOd);
        COF.Controls.Add(uOH);
        COF.Controls.Add(eO4);
        COF.Controls.Add(EO5);
        COF.Controls.Add(JOs);
        COF.Controls.Add(DOZ);
        COF.Controls.Add(aOa);
        COF.Controls.Add(dOj);
        COF.Controls.Add(vOz);
        COF.Controls.Add(ROL);
        COF.Controls.Add(dOJ);
        COF.Controls.Add(MO7);
        COF.Controls.Add(tOP);
        COF.Controls.Add(seE);
        COF.Controls.Add(pOi);
        COF.Controls.Add(LOm);
        COF.Controls.Add(XO0);
        COF.Controls.Add(QOI);
        COF.Controls.Add(dOR);
        COF.Controls.Add(dOC);
        COF.Controls.Add(POK);
        COF.Controls.Add(eOU);
        COF.Controls.Add(yOT);
        COF.Controls.Add(KO1);
        COF.Controls.Add(wOW);
        COF.Controls.Add(COw);
        COF.Controls.Add(PON);
        COF.Controls.Add(rOY);
        COF.Controls.Add(sOB);
        COF.Controls.Add(zOQ);
        COF.Location = new Point(12, 46);
        COF.Name = "groupBox1";
        COF.Size = new Size(505, 671);
        COF.TabIndex = 2;
        COF.TabStop = false;
        COF.Text = "Challenges";
        eOc.DropDownStyle = ComboBoxStyle.DropDownList;
        eOc.FormattingEnabled = true;
        eOc.Items.AddRange(new object[5] { "Hidden", "Locked", "Unlocked", "Unlocked (F)", "Finished" });
        eOc.Location = new Point(405, 617);
        eOc.Name = "CB_State19";
        eOc.Size = new Size(88, 21);
        eOc.TabIndex = 39;
        COy.DropDownStyle = ComboBoxStyle.DropDownList;
        COy.FormattingEnabled = true;
        COy.Items.AddRange(new object[5] { "Hidden", "Locked", "Unlocked", "Unlocked (F)", "Finished" });
        COy.Location = new Point(228, 617);
        COy.Name = "CB_State18";
        COy.Size = new Size(88, 21);
        COy.TabIndex = 38;
        IOr.DropDownStyle = ComboBoxStyle.DropDownList;
        IOr.FormattingEnabled = true;
        IOr.Items.AddRange(new object[5] { "Hidden", "Locked", "Unlocked", "Unlocked (F)", "Finished" });
        IOr.Location = new Point(115, 617);
        IOr.Name = "CB_State17";
        IOr.Size = new Size(88, 21);
        IOr.TabIndex = 37;
        TOf.Location = new Point(442, 644);
        TOf.Name = "BTN_saveState";
        TOf.Size = new Size(51, 23);
        TOf.TabIndex = 5;
        TOf.Text = "Save";
        TOf.UseVisualStyleBackColor = true;
        TOf.Click += EOo;
        wOq.DropDownStyle = ComboBoxStyle.DropDownList;
        wOq.FormattingEnabled = true;
        wOq.Items.AddRange(new object[5] { "Hidden", "Locked", "Unlocked", "Unlocked (F)", "Finished" });
        wOq.Location = new Point(3, 617);
        wOq.Name = "CB_State16";
        wOq.Size = new Size(88, 21);
        wOq.TabIndex = 36;
        GOk.DropDownStyle = ComboBoxStyle.DropDownList;
        GOk.FormattingEnabled = true;
        GOk.Items.AddRange(new object[5] { "Hidden", "Locked", "Unlocked", "Unlocked (F)", "Finished" });
        GOk.Location = new Point(405, 484);
        GOk.Name = "CB_State15";
        GOk.Size = new Size(88, 21);
        GOk.TabIndex = 35;
        UOM.DropDownStyle = ComboBoxStyle.DropDownList;
        UOM.FormattingEnabled = true;
        UOM.Items.AddRange(new object[5] { "Hidden", "Locked", "Unlocked", "Unlocked (F)", "Finished" });
        UOM.Location = new Point(228, 484);
        UOM.Name = "CB_State14";
        UOM.Size = new Size(88, 21);
        UOM.TabIndex = 34;
        hOu.DropDownStyle = ComboBoxStyle.DropDownList;
        hOu.FormattingEnabled = true;
        hOu.Items.AddRange(new object[5] { "Hidden", "Locked", "Unlocked", "Unlocked (F)", "Finished" });
        hOu.Location = new Point(115, 484);
        hOu.Name = "CB_State13";
        hOu.Size = new Size(88, 21);
        hOu.TabIndex = 33;
        rOg.DropDownStyle = ComboBoxStyle.DropDownList;
        rOg.FormattingEnabled = true;
        rOg.Items.AddRange(new object[5] { "Hidden", "Locked", "Unlocked", "Unlocked (F)", "Finished" });
        rOg.Location = new Point(3, 484);
        rOg.Name = "CB_State12";
        rOg.Size = new Size(88, 21);
        rOg.TabIndex = 32;
        kO2.DropDownStyle = ComboBoxStyle.DropDownList;
        kO2.FormattingEnabled = true;
        kO2.Items.AddRange(new object[5] { "Hidden", "Locked", "Unlocked", "Unlocked (F)", "Finished" });
        kO2.Location = new Point(405, 357);
        kO2.Name = "CB_State11";
        kO2.Size = new Size(88, 21);
        kO2.TabIndex = 31;
        iO3.DropDownStyle = ComboBoxStyle.DropDownList;
        iO3.FormattingEnabled = true;
        iO3.Items.AddRange(new object[5] { "Hidden", "Locked", "Unlocked", "Unlocked (F)", "Finished" });
        iO3.Location = new Point(228, 357);
        iO3.Name = "CB_State10";
        iO3.Size = new Size(88, 21);
        iO3.TabIndex = 30;
        JOd.DropDownStyle = ComboBoxStyle.DropDownList;
        JOd.FormattingEnabled = true;
        JOd.Items.AddRange(new object[5] { "Hidden", "Locked", "Unlocked", "Unlocked (F)", "Finished" });
        JOd.Location = new Point(115, 357);
        JOd.Name = "CB_State09";
        JOd.Size = new Size(88, 21);
        JOd.TabIndex = 29;
        uOH.DropDownStyle = ComboBoxStyle.DropDownList;
        uOH.FormattingEnabled = true;
        uOH.Items.AddRange(new object[5] { "Hidden", "Locked", "Unlocked", "Unlocked (F)", "Finished" });
        uOH.Location = new Point(3, 357);
        uOH.Name = "CB_State08";
        uOH.Size = new Size(88, 21);
        uOH.TabIndex = 28;
        eO4.DropDownStyle = ComboBoxStyle.DropDownList;
        eO4.FormattingEnabled = true;
        eO4.Items.AddRange(new object[5] { "Hidden", "Locked", "Unlocked", "Unlocked (F)", "Finished" });
        eO4.Location = new Point(405, 232);
        eO4.Name = "CB_State07";
        eO4.Size = new Size(88, 21);
        eO4.TabIndex = 27;
        EO5.DropDownStyle = ComboBoxStyle.DropDownList;
        EO5.FormattingEnabled = true;
        EO5.Items.AddRange(new object[5] { "Hidden", "Locked", "Unlocked", "Unlocked (F)", "Finished" });
        EO5.Location = new Point(228, 232);
        EO5.Name = "CB_State06";
        EO5.Size = new Size(88, 21);
        EO5.TabIndex = 26;
        JOs.DropDownStyle = ComboBoxStyle.DropDownList;
        JOs.FormattingEnabled = true;
        JOs.Items.AddRange(new object[5] { "Hidden", "Locked", "Unlocked", "Unlocked (F)", "Finished" });
        JOs.Location = new Point(115, 232);
        JOs.Name = "CB_State05";
        JOs.Size = new Size(88, 21);
        JOs.TabIndex = 25;
        DOZ.DropDownStyle = ComboBoxStyle.DropDownList;
        DOZ.FormattingEnabled = true;
        DOZ.Items.AddRange(new object[5] { "Hidden", "Locked", "Unlocked", "Unlocked (F)", "Finished" });
        DOZ.Location = new Point(3, 232);
        DOZ.Name = "CB_State04";
        DOZ.Size = new Size(88, 21);
        DOZ.TabIndex = 24;
        aOa.DropDownStyle = ComboBoxStyle.DropDownList;
        aOa.FormattingEnabled = true;
        aOa.Items.AddRange(new object[5] { "Hidden", "Locked", "Unlocked", "Unlocked (F)", "Finished" });
        aOa.Location = new Point(405, 111);
        aOa.Name = "CB_State03";
        aOa.Size = new Size(88, 21);
        aOa.TabIndex = 23;
        dOj.DropDownStyle = ComboBoxStyle.DropDownList;
        dOj.FormattingEnabled = true;
        dOj.Items.AddRange(new object[5] { "Hidden", "Locked", "Unlocked", "Unlocked (F)", "Finished" });
        dOj.Location = new Point(228, 111);
        dOj.Name = "CB_State02";
        dOj.Size = new Size(88, 21);
        dOj.TabIndex = 22;
        vOz.DropDownStyle = ComboBoxStyle.DropDownList;
        vOz.FormattingEnabled = true;
        vOz.Items.AddRange(new object[5] { "Hidden", "Locked", "Unlocked", "Unlocked (F)", "Finished" });
        vOz.Location = new Point(115, 111);
        vOz.Name = "CB_State01";
        vOz.Size = new Size(88, 21);
        vOz.TabIndex = 21;
        ROL.Image = Resources.Boss_05_Splat1;
        ROL.Location = new Point(408, 525);
        ROL.Name = "PB_Challenge20";
        ROL.Size = new Size(81, 86);
        ROL.SizeMode = PictureBoxSizeMode.Zoom;
        ROL.TabIndex = 20;
        ROL.TabStop = false;
        dOJ.Image = Resources.Stage_25_Splat1;
        dOJ.Location = new Point(232, 525);
        dOJ.Name = "PB_Challenge19";
        dOJ.Size = new Size(81, 86);
        dOJ.SizeMode = PictureBoxSizeMode.Zoom;
        dOJ.TabIndex = 19;
        dOJ.TabStop = false;
        MO7.Image = Resources.Stage_24_Splat1;
        MO7.Location = new Point(119, 525);
        MO7.Name = "PB_Challenge18";
        MO7.Size = new Size(81, 86);
        MO7.SizeMode = PictureBoxSizeMode.Zoom;
        MO7.TabIndex = 18;
        MO7.TabStop = false;
        tOP.Image = Resources.Stage_23_Splat1;
        tOP.Location = new Point(6, 525);
        tOP.Name = "PB_Challenge17";
        tOP.Size = new Size(81, 86);
        tOP.SizeMode = PictureBoxSizeMode.Zoom;
        tOP.TabIndex = 17;
        tOP.TabStop = false;
        seE.DropDownStyle = ComboBoxStyle.DropDownList;
        seE.FormattingEnabled = true;
        seE.Items.AddRange(new object[5] { "Hidden", "Locked", "Unlocked", "Unlocked (F)", "Finished" });
        seE.Location = new Point(3, 111);
        seE.Name = "CB_State00";
        seE.Size = new Size(88, 21);
        seE.TabIndex = 4;
        pOi.Image = Resources.Boss_04_Splat1;
        pOi.Location = new Point(408, 392);
        pOi.Name = "PB_Challenge16";
        pOi.Size = new Size(81, 86);
        pOi.SizeMode = PictureBoxSizeMode.Zoom;
        pOi.TabIndex = 16;
        pOi.TabStop = false;
        LOm.Image = Resources.Stage_20_Splat1;
        LOm.Location = new Point(232, 392);
        LOm.Name = "PB_Challenge15";
        LOm.Size = new Size(81, 86);
        LOm.SizeMode = PictureBoxSizeMode.Zoom;
        LOm.TabIndex = 15;
        LOm.TabStop = false;
        XO0.Image = Resources.Stage_19_Splat1;
        XO0.Location = new Point(119, 392);
        XO0.Name = "PB_Challenge14";
        XO0.Size = new Size(81, 86);
        XO0.SizeMode = PictureBoxSizeMode.Zoom;
        XO0.TabIndex = 14;
        XO0.TabStop = false;
        QOI.Image = Resources.Stage_18_Splat1;
        QOI.Location = new Point(6, 392);
        QOI.Name = "PB_Challenge13";
        QOI.Size = new Size(81, 86);
        QOI.SizeMode = PictureBoxSizeMode.Zoom;
        QOI.TabIndex = 13;
        QOI.TabStop = false;
        dOR.Image = Resources.Boss_03_Splat1;
        dOR.Location = new Point(408, 265);
        dOR.Name = "PB_Challenge12";
        dOR.Size = new Size(81, 86);
        dOR.SizeMode = PictureBoxSizeMode.Zoom;
        dOR.TabIndex = 12;
        dOR.TabStop = false;
        dOC.Image = Resources.Stage_13_Splat1;
        dOC.Location = new Point(232, 265);
        dOC.Name = "PB_Challenge11";
        dOC.Size = new Size(81, 86);
        dOC.SizeMode = PictureBoxSizeMode.Zoom;
        dOC.TabIndex = 11;
        dOC.TabStop = false;
        POK.Image = Resources.Stage_12_Splat1;
        POK.Location = new Point(119, 265);
        POK.Name = "PB_Challenge10";
        POK.Size = new Size(81, 86);
        POK.SizeMode = PictureBoxSizeMode.Zoom;
        POK.TabIndex = 10;
        POK.TabStop = false;
        eOU.Image = Resources.Stage_11_Splat1;
        eOU.Location = new Point(6, 265);
        eOU.Name = "PB_Challenge09";
        eOU.Size = new Size(81, 86);
        eOU.SizeMode = PictureBoxSizeMode.Zoom;
        eOU.TabIndex = 9;
        eOU.TabStop = false;
        yOT.Image = Resources.Boss_02_Splat1;
        yOT.Location = new Point(408, 140);
        yOT.Name = "PB_Challenge08";
        yOT.Size = new Size(81, 86);
        yOT.SizeMode = PictureBoxSizeMode.Zoom;
        yOT.TabIndex = 8;
        yOT.TabStop = false;
        KO1.Image = Resources.Stage_07_Splat1;
        KO1.Location = new Point(232, 140);
        KO1.Name = "PB_Challenge07";
        KO1.Size = new Size(81, 86);
        KO1.SizeMode = PictureBoxSizeMode.Zoom;
        KO1.TabIndex = 7;
        KO1.TabStop = false;
        wOW.Image = Resources.Stage_05_Splat1;
        wOW.Location = new Point(119, 140);
        wOW.Name = "PB_Challenge06";
        wOW.Size = new Size(81, 86);
        wOW.SizeMode = PictureBoxSizeMode.Zoom;
        wOW.TabIndex = 6;
        wOW.TabStop = false;
        COw.Image = Resources.Stage_04_Splat1;
        COw.Location = new Point(6, 140);
        COw.Name = "PB_Challenge05";
        COw.Size = new Size(81, 86);
        COw.SizeMode = PictureBoxSizeMode.Zoom;
        COw.TabIndex = 5;
        COw.TabStop = false;
        PON.Image = Resources.Boss_01_Splat1;
        PON.Location = new Point(408, 19);
        PON.Name = "PB_Challenge04";
        PON.Size = new Size(81, 86);
        PON.SizeMode = PictureBoxSizeMode.Zoom;
        PON.TabIndex = 4;
        PON.TabStop = false;
        rOY.Image = Resources.Stage_03_Splat1;
        rOY.Location = new Point(232, 19);
        rOY.Name = "PB_Challenge03";
        rOY.Size = new Size(81, 86);
        rOY.SizeMode = PictureBoxSizeMode.Zoom;
        rOY.TabIndex = 3;
        rOY.TabStop = false;
        sOB.Image = Resources.Stage_02_Splat1;
        sOB.Location = new Point(119, 19);
        sOB.Name = "PB_Challenge02";
        sOB.Size = new Size(81, 86);
        sOB.SizeMode = PictureBoxSizeMode.Zoom;
        sOB.TabIndex = 2;
        sOB.TabStop = false;
        POA.AutoSize = true;
        POA.Location = new Point(9, 9);
        POA.Name = "label1";
        POA.Size = new Size(37, 13);
        POA.TabIndex = 3;
        POA.Text = "amiibo";
        lO6.Location = new Point(139, 23);
        lO6.Name = "BTN_resetChallenge";
        lO6.Size = new Size(178, 23);
        lO6.TabIndex = 8;
        lO6.Text = "Reset Selected amiibo Challenges";
        lO6.UseVisualStyleBackColor = true;
        lO6.Click += kOt;
        QOx.Location = new Point(323, 23);
        QOx.Name = "BTN_completeChallenge";
        QOx.Size = new Size(194, 23);
        QOx.TabIndex = 9;
        QOx.Text = "Complete Selected amiibo Challenges";
        QOx.UseVisualStyleBackColor = true;
        QOx.Click += XOV;
        HO9.AutoSize = true;
        HO9.Location = new Point(53, 56);
        HO9.Name = "label2";
        HO9.Size = new Size(0, 13);
        HO9.TabIndex = 10;
        base.AutoScaleDimensions = new SizeF(6f, 13f);
        base.AutoScaleMode = AutoScaleMode.Font;
        base.ClientSize = new Size(525, 723);
        base.Controls.Add(HO9);
        base.Controls.Add(QOx);
        base.Controls.Add(lO6);
        base.Controls.Add(POA);
        base.Controls.Add(COF);
        base.Controls.Add(jOn);
        base.Name = "amiiboChallengeSplat1";
        base.ShowIcon = false;
        base.StartPosition = FormStartPosition.CenterScreen;
        Text = "SplatHeX - Splatoon 1 - amiibo Challenge Editor";
        ((ISupportInitialize)zOQ).EndInit();
        COF.ResumeLayout(performLayout: false);
        ((ISupportInitialize)ROL).EndInit();
        ((ISupportInitialize)dOJ).EndInit();
        ((ISupportInitialize)MO7).EndInit();
        ((ISupportInitialize)tOP).EndInit();
        ((ISupportInitialize)pOi).EndInit();
        ((ISupportInitialize)LOm).EndInit();
        ((ISupportInitialize)XO0).EndInit();
        ((ISupportInitialize)QOI).EndInit();
        ((ISupportInitialize)dOR).EndInit();
        ((ISupportInitialize)dOC).EndInit();
        ((ISupportInitialize)POK).EndInit();
        ((ISupportInitialize)eOU).EndInit();
        ((ISupportInitialize)yOT).EndInit();
        ((ISupportInitialize)KO1).EndInit();
        ((ISupportInitialize)wOW).EndInit();
        ((ISupportInitialize)COw).EndInit();
        ((ISupportInitialize)PON).EndInit();
        ((ISupportInitialize)rOY).EndInit();
        ((ISupportInitialize)sOB).EndInit();
        ResumeLayout(performLayout: false);
        PerformLayout();
    }
}