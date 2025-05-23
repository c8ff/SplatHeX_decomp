using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace SplatHex;
public class Class31 : Form {
    private NumericUpDown[] qv8;
    private NumericUpDown[] Pvn;
    private NumericUpDown[] PvQ;
    private IDisposable GvF;
    private GroupBox dvL;
    private GroupBox BvJ;
    private PictureBox Iv7;
    private NumericUpDown mvP;
    private NumericUpDown Rvi;
    private PictureBox ivm;
    private NumericUpDown kv0;
    private PictureBox KvI;
    private NumericUpDown CvR;
    private PictureBox NvC;
    private NumericUpDown TvK;
    private PictureBox cvU;
    private NumericUpDown kvT;
    private PictureBox ev1;
    private NumericUpDown fvW;
    private PictureBox Dvw;
    private NumericUpDown vvN;
    private PictureBox yvY;
    private NumericUpDown lvB;
    private PictureBox IvA;
    private NumericUpDown Dvf;
    private PictureBox pv6;
    private NumericUpDown Kvx;
    private PictureBox Sv9;
    private NumericUpDown Fvc;
    private PictureBox Tvy;
    private NumericUpDown pvr;
    private PictureBox dvq;
    private NumericUpDown Nvk;
    private PictureBox uvM;
    private PictureBox svu;
    private PictureBox mvg;
    private PictureBox Jv2;
    private PictureBox Rv3;
    private PictureBox mvd;
    private PictureBox dvH;
    private NumericUpDown Jv4;
    private NumericUpDown vv5;
    private NumericUpDown fvs;
    private NumericUpDown GvZ;
    private NumericUpDown kva;
    private NumericUpDown Nvj;
    private Button ovz;
    private Button MoE;
    private GroupBox woD;
    private NumericUpDown doX;
    private PictureBox lop;
    private NumericUpDown soS;
    private NumericUpDown Qoh;
    private PictureBox Aol;
    private PictureBox WoG;
    private PictureBox iob;
    private PictureBox Kov;
    private NumericUpDown Moo;
    private NumericUpDown Bot;
    private PictureBox voV;
    private NumericUpDown LoO;
    private PictureBox Foe;
    private PictureBox zo8;
    private PictureBox Bon;
    private NumericUpDown LoQ;
    private NumericUpDown DoF;
    private PictureBox hoL;
    private PictureBox MoJ;
    private PictureBox co7;
    private PictureBox AoP;
    private PictureBox Foi;
    private NumericUpDown nom;
    private NumericUpDown wo0;
    private NumericUpDown aoI;
    private NumericUpDown LoR;
    private NumericUpDown woC;
    private NumericUpDown uoK;
    public Class31() {
        hve();
        qv8 = new NumericUpDown[14]
        {
            mvP,
            Nvk,
            pvr,
            Fvc,
            Kvx,
            Dvf,
            lvB,
            vvN,
            fvW,
            kvT,
            TvK,
            CvR,
            kv0,
            Nvj
        };
        Pvn = new NumericUpDown[6]
        {
            fvs,
            vv5,
            Rvi,
            kva,
            Jv4,
            GvZ
        };
        PvQ = new NumericUpDown[14]
        {
            uoK,
            woC,
            LoR,
            aoI,
            wo0,
            nom,
            DoF,
            LoQ,
            LoO,
            Bot,
            Moo,
            Qoh,
            soS,
            doX
        };
        for (int i = 0; i < Class26.MX4.Length; i++) {
            if (Class26.MX4[i].uho == 4) {
                qv8[Class26.MX4[i].qht].Value = Class26.MX4[i].ChV;
            } else if (Class26.MX4[i].uho >= 0 && Class26.MX4[i].uho <= 3) {
                Pvn[Class26.MX4[i].uho].Value = Class26.MX4[i].ChV;
            } else if (Class26.MX4[i].uho == 5 || Class26.MX4[i].uho == 6) {
                Pvn[Class26.MX4[i].uho - 1].Value = Class26.MX4[i].ChV;
            }
        }

        for (int j = 0; j < Class26.jX5.Length; j++) {
            if (Class26.jX5[j].eh8 != -1) {
                PvQ[Class26.jX5[j].eh8].Value = Class26.jX5[j].Dhn;
            }
        }

        if (Class26.QXu.Lpp >= 7) {
            lop.Image = Resources.MarkingTime_Reduction2;
            Aol.Image = Resources.BombDamage_Reduction2;
            uvM.Image = Resources.GearPowerDrink_01_2;
            ivm.Image = Resources.GearPowerDrink_13_2;
        }

        GvZ.Enabled = Class26.QXu.Lpp != 0;
        Jv4.Enabled = Class26.QXu.Lpp != 0;
    }

    private void CvV(object sender, EventArgs e) {
        int num = 0;
        for (int i = 0; i < Class26.MX4.Length; i++) {
            Class26.MX4[i].uho = -1;
            Class26.MX4[i].qht = -1;
            Class26.MX4[i].ChV = 0;
        }

        for (int j = 0; j < Class26.jX5.Length; j++) {
            Class26.jX5[j].eh8 = -1;
            Class26.jX5[j].Dhn = 0;
        }

        for (int k = 0; k < qv8.Length; k++) {
            if (qv8[k].Value != 0m) {
                Class26.MX4[k].uho = 4;
                Class26.MX4[k].qht = k;
                Class26.MX4[k].ChV = (int)qv8[k].Value;
                num++;
            }
        }

        for (int l = 0; l < Pvn.Length; l++) {
            if (!(Pvn[l].Value == 0m)) {
                if (l != 4 && l != 5) {
                    Class26.MX4[l + num].uho = l;
                    Class26.MX4[l + num].qht = -1;
                    Class26.MX4[l + num].ChV = (int)Pvn[l].Value;
                } else {
                    Class26.MX4[l + num].uho = l + 1;
                    Class26.MX4[l + num].qht = -1;
                    Class26.MX4[l + num].ChV = (int)Pvn[l].Value;
                }
            }
        }

        for (int m = 0; m < PvQ.Length; m++) {
            if (!(PvQ[m].Value == 0m)) {
                Class26.jX5[m].eh8 = m;
                Class26.jX5[m].Dhn = (int)PvQ[m].Value;
            }
        }

        Close();
    }

    private void PvO(object sender, EventArgs e) {
        Close();
    }

    protected override void Dispose(bool disposing) {
        if (disposing && GvF != null) {
            GvF.Dispose();
        }

        base.Dispose(disposing);
    }

    private void hve() {
        dvL = new GroupBox();
        Nvj = new NumericUpDown();
        ivm = new PictureBox();
        kv0 = new NumericUpDown();
        CvR = new NumericUpDown();
        uvM = new PictureBox();
        Iv7 = new PictureBox();
        KvI = new PictureBox();
        Sv9 = new PictureBox();
        TvK = new NumericUpDown();
        kvT = new NumericUpDown();
        NvC = new PictureBox();
        fvW = new NumericUpDown();
        ev1 = new PictureBox();
        cvU = new PictureBox();
        Dvw = new PictureBox();
        vvN = new NumericUpDown();
        lvB = new NumericUpDown();
        yvY = new PictureBox();
        IvA = new PictureBox();
        pv6 = new PictureBox();
        Tvy = new PictureBox();
        dvq = new PictureBox();
        Dvf = new NumericUpDown();
        Kvx = new NumericUpDown();
        Fvc = new NumericUpDown();
        pvr = new NumericUpDown();
        Nvk = new NumericUpDown();
        mvP = new NumericUpDown();
        BvJ = new GroupBox();
        Jv4 = new NumericUpDown();
        vv5 = new NumericUpDown();
        fvs = new NumericUpDown();
        GvZ = new NumericUpDown();
        kva = new NumericUpDown();
        Rvi = new NumericUpDown();
        svu = new PictureBox();
        mvg = new PictureBox();
        Jv2 = new PictureBox();
        Rv3 = new PictureBox();
        mvd = new PictureBox();
        dvH = new PictureBox();
        ovz = new Button();
        MoE = new Button();
        woD = new GroupBox();
        doX = new NumericUpDown();
        lop = new PictureBox();
        soS = new NumericUpDown();
        Qoh = new NumericUpDown();
        Aol = new PictureBox();
        WoG = new PictureBox();
        iob = new PictureBox();
        Kov = new PictureBox();
        Moo = new NumericUpDown();
        Bot = new NumericUpDown();
        voV = new PictureBox();
        LoO = new NumericUpDown();
        Foe = new PictureBox();
        zo8 = new PictureBox();
        Bon = new PictureBox();
        LoQ = new NumericUpDown();
        DoF = new NumericUpDown();
        hoL = new PictureBox();
        MoJ = new PictureBox();
        co7 = new PictureBox();
        AoP = new PictureBox();
        Foi = new PictureBox();
        nom = new NumericUpDown();
        wo0 = new NumericUpDown();
        aoI = new NumericUpDown();
        LoR = new NumericUpDown();
        woC = new NumericUpDown();
        uoK = new NumericUpDown();
        dvL.SuspendLayout();
        ((ISupportInitialize)Nvj).BeginInit();
        ((ISupportInitialize)ivm).BeginInit();
        ((ISupportInitialize)kv0).BeginInit();
        ((ISupportInitialize)CvR).BeginInit();
        ((ISupportInitialize)uvM).BeginInit();
        ((ISupportInitialize)Iv7).BeginInit();
        ((ISupportInitialize)KvI).BeginInit();
        ((ISupportInitialize)Sv9).BeginInit();
        ((ISupportInitialize)TvK).BeginInit();
        ((ISupportInitialize)kvT).BeginInit();
        ((ISupportInitialize)NvC).BeginInit();
        ((ISupportInitialize)fvW).BeginInit();
        ((ISupportInitialize)ev1).BeginInit();
        ((ISupportInitialize)cvU).BeginInit();
        ((ISupportInitialize)Dvw).BeginInit();
        ((ISupportInitialize)vvN).BeginInit();
        ((ISupportInitialize)lvB).BeginInit();
        ((ISupportInitialize)yvY).BeginInit();
        ((ISupportInitialize)IvA).BeginInit();
        ((ISupportInitialize)pv6).BeginInit();
        ((ISupportInitialize)Tvy).BeginInit();
        ((ISupportInitialize)dvq).BeginInit();
        ((ISupportInitialize)Dvf).BeginInit();
        ((ISupportInitialize)Kvx).BeginInit();
        ((ISupportInitialize)Fvc).BeginInit();
        ((ISupportInitialize)pvr).BeginInit();
        ((ISupportInitialize)Nvk).BeginInit();
        ((ISupportInitialize)mvP).BeginInit();
        BvJ.SuspendLayout();
        ((ISupportInitialize)Jv4).BeginInit();
        ((ISupportInitialize)vv5).BeginInit();
        ((ISupportInitialize)fvs).BeginInit();
        ((ISupportInitialize)GvZ).BeginInit();
        ((ISupportInitialize)kva).BeginInit();
        ((ISupportInitialize)Rvi).BeginInit();
        ((ISupportInitialize)svu).BeginInit();
        ((ISupportInitialize)mvg).BeginInit();
        ((ISupportInitialize)Jv2).BeginInit();
        ((ISupportInitialize)Rv3).BeginInit();
        ((ISupportInitialize)mvd).BeginInit();
        ((ISupportInitialize)dvH).BeginInit();
        woD.SuspendLayout();
        ((ISupportInitialize)doX).BeginInit();
        ((ISupportInitialize)lop).BeginInit();
        ((ISupportInitialize)soS).BeginInit();
        ((ISupportInitialize)Qoh).BeginInit();
        ((ISupportInitialize)Aol).BeginInit();
        ((ISupportInitialize)WoG).BeginInit();
        ((ISupportInitialize)iob).BeginInit();
        ((ISupportInitialize)Kov).BeginInit();
        ((ISupportInitialize)Moo).BeginInit();
        ((ISupportInitialize)Bot).BeginInit();
        ((ISupportInitialize)voV).BeginInit();
        ((ISupportInitialize)LoO).BeginInit();
        ((ISupportInitialize)Foe).BeginInit();
        ((ISupportInitialize)zo8).BeginInit();
        ((ISupportInitialize)Bon).BeginInit();
        ((ISupportInitialize)LoQ).BeginInit();
        ((ISupportInitialize)DoF).BeginInit();
        ((ISupportInitialize)hoL).BeginInit();
        ((ISupportInitialize)MoJ).BeginInit();
        ((ISupportInitialize)co7).BeginInit();
        ((ISupportInitialize)AoP).BeginInit();
        ((ISupportInitialize)Foi).BeginInit();
        ((ISupportInitialize)nom).BeginInit();
        ((ISupportInitialize)wo0).BeginInit();
        ((ISupportInitialize)aoI).BeginInit();
        ((ISupportInitialize)LoR).BeginInit();
        ((ISupportInitialize)woC).BeginInit();
        ((ISupportInitialize)uoK).BeginInit();
        SuspendLayout();
        dvL.Controls.Add(Nvj);
        dvL.Controls.Add(ivm);
        dvL.Controls.Add(kv0);
        dvL.Controls.Add(CvR);
        dvL.Controls.Add(uvM);
        dvL.Controls.Add(Iv7);
        dvL.Controls.Add(KvI);
        dvL.Controls.Add(Sv9);
        dvL.Controls.Add(TvK);
        dvL.Controls.Add(kvT);
        dvL.Controls.Add(NvC);
        dvL.Controls.Add(fvW);
        dvL.Controls.Add(ev1);
        dvL.Controls.Add(cvU);
        dvL.Controls.Add(Dvw);
        dvL.Controls.Add(vvN);
        dvL.Controls.Add(lvB);
        dvL.Controls.Add(yvY);
        dvL.Controls.Add(IvA);
        dvL.Controls.Add(pv6);
        dvL.Controls.Add(Tvy);
        dvL.Controls.Add(dvq);
        dvL.Controls.Add(Dvf);
        dvL.Controls.Add(Kvx);
        dvL.Controls.Add(Fvc);
        dvL.Controls.Add(pvr);
        dvL.Controls.Add(Nvk);
        dvL.Controls.Add(mvP);
        dvL.Location = new Point(12, 12);
        dvL.Name = "groupBox1";
        dvL.Size = new Size(358, 321);
        dvL.TabIndex = 0;
        dvL.TabStop = false;
        dvL.Text = "Drinks";
        Nvj.Location = new Point(261, 282);
        Nvj.Maximum = new decimal(new int[4] { 99, 0, 0, 0 });
        Nvj.Name = "NUD_Drinks13";
        Nvj.Size = new Size(34, 20);
        Nvj.TabIndex = 27;
        ivm.Image = Resources.GearPowerDrink_13_Splat2;
        ivm.Location = new Point(246, 212);
        ivm.Name = "PB_Drinks13";
        ivm.Size = new Size(64, 64);
        ivm.TabIndex = 26;
        ivm.TabStop = false;
        kv0.Location = new Point(191, 282);
        kv0.Maximum = new decimal(new int[4] { 99, 0, 0, 0 });
        kv0.Name = "NUD_Drinks12";
        kv0.Size = new Size(34, 20);
        kv0.TabIndex = 25;
        CvR.Location = new Point(121, 282);
        CvR.Maximum = new decimal(new int[4] { 99, 0, 0, 0 });
        CvR.Name = "NUD_Drinks11";
        CvR.Size = new Size(34, 20);
        CvR.TabIndex = 23;
        uvM.Image = Resources.GearPowerDrink_01_Splat2;
        uvM.Location = new Point(176, 212);
        uvM.Name = "PB_Drinks12";
        uvM.Size = new Size(64, 64);
        uvM.TabIndex = 2;
        uvM.TabStop = false;
        Iv7.Image = Resources.GearPowerDrink_00_Splat2;
        Iv7.Location = new Point(106, 212);
        Iv7.Name = "PB_Drinks11";
        Iv7.Size = new Size(64, 64);
        Iv7.SizeMode = PictureBoxSizeMode.Zoom;
        Iv7.TabIndex = 0;
        Iv7.TabStop = false;
        KvI.Image = Resources.GearPowerDrink_12_Splat2;
        KvI.Location = new Point(36, 212);
        KvI.Name = "PB_Drinks10";
        KvI.Size = new Size(64, 64);
        KvI.TabIndex = 24;
        KvI.TabStop = false;
        Sv9.Image = Resources.GearPowerDrink_04_Splat2;
        Sv9.Location = new Point(146, 19);
        Sv9.Name = "PB_Drinks02";
        Sv9.Size = new Size(64, 64);
        Sv9.TabIndex = 8;
        Sv9.TabStop = false;
        TvK.Location = new Point(51, 282);
        TvK.Maximum = new decimal(new int[4] { 99, 0, 0, 0 });
        TvK.Name = "NUD_Drinks10";
        TvK.Size = new Size(34, 20);
        TvK.TabIndex = 21;
        kvT.Location = new Point(301, 185);
        kvT.Maximum = new decimal(new int[4] { 99, 0, 0, 0 });
        kvT.Name = "NUD_Drinks09";
        kvT.Size = new Size(34, 20);
        kvT.TabIndex = 19;
        NvC.Image = Resources.GearPowerDrink_11_Splat2;
        NvC.Location = new Point(286, 115);
        NvC.Name = "PB_Drinks09";
        NvC.Size = new Size(64, 64);
        NvC.TabIndex = 22;
        NvC.TabStop = false;
        fvW.Location = new Point(231, 185);
        fvW.Maximum = new decimal(new int[4] { 99, 0, 0, 0 });
        fvW.Name = "NUD_Drinks08";
        fvW.Size = new Size(34, 20);
        fvW.TabIndex = 17;
        ev1.Image = Resources.GearPowerDrink_09_Splat2;
        ev1.Location = new Point(216, 115);
        ev1.Name = "PB_Drinks08";
        ev1.Size = new Size(64, 64);
        ev1.TabIndex = 18;
        ev1.TabStop = false;
        cvU.Image = Resources.GearPowerDrink_10_Splat2;
        cvU.Location = new Point(76, 115);
        cvU.Name = "PB_Drinks06";
        cvU.Size = new Size(64, 64);
        cvU.TabIndex = 20;
        cvU.TabStop = false;
        Dvw.Image = Resources.GearPowerDrink_08_Splat2;
        Dvw.Location = new Point(146, 115);
        Dvw.Name = "PB_Drinks07";
        Dvw.Size = new Size(64, 64);
        Dvw.TabIndex = 16;
        Dvw.TabStop = false;
        vvN.Location = new Point(161, 185);
        vvN.Maximum = new decimal(new int[4] { 99, 0, 0, 0 });
        vvN.Name = "NUD_Drinks07";
        vvN.Size = new Size(34, 20);
        vvN.TabIndex = 15;
        lvB.Location = new Point(91, 185);
        lvB.Maximum = new decimal(new int[4] { 99, 0, 0, 0 });
        lvB.Name = "NUD_Drinks06";
        lvB.Size = new Size(34, 20);
        lvB.TabIndex = 13;
        yvY.Image = Resources.GearPowerDrink_07_Splat2;
        yvY.Location = new Point(6, 115);
        yvY.Name = "PB_Drinks05";
        yvY.Size = new Size(64, 64);
        yvY.TabIndex = 14;
        yvY.TabStop = false;
        IvA.Image = Resources.GearPowerDrink_06_Splat2;
        IvA.Location = new Point(286, 19);
        IvA.Name = "PB_Drinks04";
        IvA.Size = new Size(64, 64);
        IvA.TabIndex = 12;
        IvA.TabStop = false;
        pv6.Image = Resources.GearPowerDrink_05_Splat2;
        pv6.Location = new Point(216, 19);
        pv6.Name = "PB_Drinks03";
        pv6.Size = new Size(64, 64);
        pv6.TabIndex = 10;
        pv6.TabStop = false;
        Tvy.Image = Resources.GearPowerDrink_03_Splat2;
        Tvy.Location = new Point(76, 19);
        Tvy.Name = "PB_Drinks01";
        Tvy.Size = new Size(64, 64);
        Tvy.TabIndex = 6;
        Tvy.TabStop = false;
        dvq.Image = Resources.GearPowerDrink_02_Splat2;
        dvq.Location = new Point(6, 19);
        dvq.Name = "PB_Drinks00";
        dvq.Size = new Size(64, 64);
        dvq.TabIndex = 4;
        dvq.TabStop = false;
        Dvf.Location = new Point(21, 185);
        Dvf.Maximum = new decimal(new int[4] { 99, 0, 0, 0 });
        Dvf.Name = "NUD_Drinks05";
        Dvf.Size = new Size(34, 20);
        Dvf.TabIndex = 11;
        Kvx.Location = new Point(301, 89);
        Kvx.Maximum = new decimal(new int[4] { 99, 0, 0, 0 });
        Kvx.Name = "NUD_Drinks04";
        Kvx.Size = new Size(34, 20);
        Kvx.TabIndex = 9;
        Fvc.Location = new Point(231, 89);
        Fvc.Maximum = new decimal(new int[4] { 99, 0, 0, 0 });
        Fvc.Name = "NUD_Drinks03";
        Fvc.Size = new Size(34, 20);
        Fvc.TabIndex = 7;
        pvr.Location = new Point(161, 89);
        pvr.Maximum = new decimal(new int[4] { 99, 0, 0, 0 });
        pvr.Name = "NUD_Drinks02";
        pvr.Size = new Size(34, 20);
        pvr.TabIndex = 5;
        Nvk.Location = new Point(91, 89);
        Nvk.Maximum = new decimal(new int[4] { 99, 0, 0, 0 });
        Nvk.Name = "NUD_Drinks01";
        Nvk.Size = new Size(34, 20);
        Nvk.TabIndex = 3;
        mvP.Location = new Point(21, 89);
        mvP.Maximum = new decimal(new int[4] { 99, 0, 0, 0 });
        mvP.Name = "NUD_Drinks00";
        mvP.Size = new Size(34, 20);
        mvP.TabIndex = 1;
        BvJ.Controls.Add(Jv4);
        BvJ.Controls.Add(vv5);
        BvJ.Controls.Add(fvs);
        BvJ.Controls.Add(GvZ);
        BvJ.Controls.Add(kva);
        BvJ.Controls.Add(Rvi);
        BvJ.Controls.Add(svu);
        BvJ.Controls.Add(mvg);
        BvJ.Controls.Add(Jv2);
        BvJ.Controls.Add(Rv3);
        BvJ.Controls.Add(mvd);
        BvJ.Controls.Add(dvH);
        BvJ.Location = new Point(202, 339);
        BvJ.Name = "groupBox2";
        BvJ.Size = new Size(358, 260);
        BvJ.TabIndex = 1;
        BvJ.TabStop = false;
        BvJ.Text = "Foods";
        Jv4.Location = new Point(256, 230);
        Jv4.Maximum = new decimal(new int[4] { 99, 0, 0, 0 });
        Jv4.Name = "NUD_Foods05";
        Jv4.Size = new Size(34, 20);
        Jv4.TabIndex = 33;
        vv5.Location = new Point(161, 230);
        vv5.Maximum = new decimal(new int[4] { 99, 0, 0, 0 });
        vv5.Name = "NUD_Foods04";
        vv5.Size = new Size(34, 20);
        vv5.TabIndex = 32;
        fvs.Location = new Point(68, 230);
        fvs.Maximum = new decimal(new int[4] { 99, 0, 0, 0 });
        fvs.Name = "NUD_Foods03";
        fvs.Size = new Size(34, 20);
        fvs.TabIndex = 31;
        GvZ.Location = new Point(256, 111);
        GvZ.Maximum = new decimal(new int[4] { 99, 0, 0, 0 });
        GvZ.Name = "NUD_Foods02";
        GvZ.Size = new Size(34, 20);
        GvZ.TabIndex = 29;
        kva.Location = new Point(161, 111);
        kva.Maximum = new decimal(new int[4] { 99, 0, 0, 0 });
        kva.Name = "NUD_Foods01";
        kva.Size = new Size(34, 20);
        kva.TabIndex = 28;
        Rvi.Location = new Point(68, 111);
        Rvi.Maximum = new decimal(new int[4] { 99, 0, 0, 0 });
        Rvi.Name = "NUD_Foods00";
        Rvi.Size = new Size(34, 20);
        Rvi.TabIndex = 27;
        svu.Image = Resources.GearPowerDrink_19_Splat2;
        svu.Location = new Point(229, 138);
        svu.Name = "PB_Foods05";
        svu.Size = new Size(86, 86);
        svu.TabIndex = 6;
        svu.TabStop = false;
        mvg.Image = Resources.GearPowerDrink_17_Splat2;
        mvg.Location = new Point(137, 138);
        mvg.Name = "PB_Foods04";
        mvg.Size = new Size(86, 86);
        mvg.TabIndex = 5;
        mvg.TabStop = false;
        Jv2.Image = Resources.GearPowerDrink_16_Splat2;
        Jv2.Location = new Point(45, 138);
        Jv2.Name = "PB_Foods03";
        Jv2.Size = new Size(86, 86);
        Jv2.TabIndex = 4;
        Jv2.TabStop = false;
        Rv3.ErrorImage = null;
        Rv3.Image = Resources.GearPowerDrink_18_Splat2;
        Rv3.Location = new Point(229, 19);
        Rv3.Name = "PB_Foods02";
        Rv3.Size = new Size(86, 86);
        Rv3.TabIndex = 2;
        Rv3.TabStop = false;
        mvd.Image = Resources.GearPowerDrink_15_Splat2;
        mvd.Location = new Point(137, 19);
        mvd.Name = "PB_Foods01";
        mvd.Size = new Size(86, 86);
        mvd.TabIndex = 1;
        mvd.TabStop = false;
        dvH.Image = Resources.GearPowerDrink_14_Splat2;
        dvH.Location = new Point(45, 19);
        dvH.Name = "PB_Foods00";
        dvH.Size = new Size(86, 86);
        dvH.TabIndex = 0;
        dvH.TabStop = false;
        ovz.Location = new Point(319, 605);
        ovz.Name = "B_Save";
        ovz.Size = new Size(53, 23);
        ovz.TabIndex = 2;
        ovz.Text = "Save";
        ovz.UseVisualStyleBackColor = true;
        ovz.Click += CvV;
        MoE.Location = new Point(378, 605);
        MoE.Name = "B_Close";
        MoE.Size = new Size(53, 23);
        MoE.TabIndex = 3;
        MoE.Text = "Close";
        MoE.UseVisualStyleBackColor = true;
        MoE.Click += PvO;
        woD.Controls.Add(doX);
        woD.Controls.Add(lop);
        woD.Controls.Add(soS);
        woD.Controls.Add(Qoh);
        woD.Controls.Add(Aol);
        woD.Controls.Add(WoG);
        woD.Controls.Add(iob);
        woD.Controls.Add(Kov);
        woD.Controls.Add(Moo);
        woD.Controls.Add(Bot);
        woD.Controls.Add(voV);
        woD.Controls.Add(LoO);
        woD.Controls.Add(Foe);
        woD.Controls.Add(zo8);
        woD.Controls.Add(Bon);
        woD.Controls.Add(LoQ);
        woD.Controls.Add(DoF);
        woD.Controls.Add(hoL);
        woD.Controls.Add(MoJ);
        woD.Controls.Add(co7);
        woD.Controls.Add(AoP);
        woD.Controls.Add(Foi);
        woD.Controls.Add(nom);
        woD.Controls.Add(wo0);
        woD.Controls.Add(aoI);
        woD.Controls.Add(LoR);
        woD.Controls.Add(woC);
        woD.Controls.Add(uoK);
        woD.Location = new Point(376, 12);
        woD.Name = "groupBox3";
        woD.Size = new Size(358, 321);
        woD.TabIndex = 4;
        woD.TabStop = false;
        woD.Text = "Ability Chunks";
        doX.Location = new Point(259, 284);
        doX.Maximum = new decimal(new int[4] { 999, 0, 0, 0 });
        doX.Name = "NUD_Chunk13";
        doX.Size = new Size(39, 20);
        doX.TabIndex = 27;
        lop.Image = Resources.S2ability14_Badge;
        lop.Location = new Point(253, 228);
        lop.Name = "pictureBox1";
        lop.Size = new Size(50, 50);
        lop.TabIndex = 26;
        lop.TabStop = false;
        soS.Location = new Point(189, 284);
        soS.Maximum = new decimal(new int[4] { 999, 0, 0, 0 });
        soS.Name = "NUD_Chunk12";
        soS.Size = new Size(39, 20);
        soS.TabIndex = 25;
        Qoh.Location = new Point(119, 284);
        Qoh.Maximum = new decimal(new int[4] { 999, 0, 0, 0 });
        Qoh.Name = "NUD_Chunk11";
        Qoh.Size = new Size(39, 20);
        Qoh.TabIndex = 23;
        Aol.Image = Resources.S2ability13_Badge;
        Aol.Location = new Point(183, 228);
        Aol.Name = "pictureBox2";
        Aol.Size = new Size(50, 50);
        Aol.TabIndex = 2;
        Aol.TabStop = false;
        WoG.Image = Resources.S2ability12_Badge;
        WoG.Location = new Point(113, 228);
        WoG.Name = "pictureBox3";
        WoG.Size = new Size(50, 50);
        WoG.SizeMode = PictureBoxSizeMode.Zoom;
        WoG.TabIndex = 0;
        WoG.TabStop = false;
        iob.Image = Resources.S2ability11_Badge;
        iob.Location = new Point(43, 228);
        iob.Name = "pictureBox4";
        iob.Size = new Size(50, 50);
        iob.TabIndex = 24;
        iob.TabStop = false;
        Kov.Image = Resources.S2ability3_Badge;
        Kov.Location = new Point(153, 24);
        Kov.Name = "pictureBox5";
        Kov.Size = new Size(50, 50);
        Kov.TabIndex = 8;
        Kov.TabStop = false;
        Moo.Location = new Point(49, 284);
        Moo.Maximum = new decimal(new int[4] { 999, 0, 0, 0 });
        Moo.Name = "NUD_Chunk10";
        Moo.Size = new Size(39, 20);
        Moo.TabIndex = 21;
        Bot.Location = new Point(301, 184);
        Bot.Maximum = new decimal(new int[4] { 999, 0, 0, 0 });
        Bot.Name = "NUD_Chunk09";
        Bot.Size = new Size(39, 20);
        Bot.TabIndex = 19;
        voV.Image = Resources.S2ability10_Badge;
        voV.Location = new Point(295, 128);
        voV.Name = "pictureBox6";
        voV.Size = new Size(50, 50);
        voV.TabIndex = 22;
        voV.TabStop = false;
        LoO.Location = new Point(231, 184);
        LoO.Maximum = new decimal(new int[4] { 999, 0, 0, 0 });
        LoO.Name = "NUD_Chunk08";
        LoO.Size = new Size(39, 20);
        LoO.TabIndex = 17;
        Foe.Image = Resources.S2ability9_Badge;
        Foe.Location = new Point(225, 128);
        Foe.Name = "pictureBox7";
        Foe.Size = new Size(50, 50);
        Foe.TabIndex = 18;
        Foe.TabStop = false;
        zo8.Image = Resources.S2ability7_Badge;
        zo8.Location = new Point(85, 128);
        zo8.Name = "pictureBox8";
        zo8.Size = new Size(50, 50);
        zo8.TabIndex = 20;
        zo8.TabStop = false;
        Bon.Image = Resources.S2ability8_Badge;
        Bon.Location = new Point(155, 128);
        Bon.Name = "pictureBox9";
        Bon.Size = new Size(50, 50);
        Bon.TabIndex = 16;
        Bon.TabStop = false;
        LoQ.Location = new Point(161, 184);
        LoQ.Maximum = new decimal(new int[4] { 999, 0, 0, 0 });
        LoQ.Name = "NUD_Chunk07";
        LoQ.Size = new Size(39, 20);
        LoQ.TabIndex = 15;
        DoF.Location = new Point(91, 184);
        DoF.Maximum = new decimal(new int[4] { 999, 0, 0, 0 });
        DoF.Name = "NUD_Chunk06";
        DoF.Size = new Size(39, 20);
        DoF.TabIndex = 13;
        hoL.Image = Resources.S2ability6_Badge;
        hoL.Location = new Point(15, 128);
        hoL.Name = "pictureBox10";
        hoL.Size = new Size(50, 50);
        hoL.TabIndex = 14;
        hoL.TabStop = false;
        MoJ.Image = Resources.S2ability5_Badge;
        MoJ.Location = new Point(293, 24);
        MoJ.Name = "pictureBox11";
        MoJ.Size = new Size(50, 50);
        MoJ.TabIndex = 12;
        MoJ.TabStop = false;
        co7.Image = Resources.S2ability4_Badge;
        co7.Location = new Point(223, 24);
        co7.Name = "pictureBox12";
        co7.Size = new Size(50, 50);
        co7.TabIndex = 10;
        co7.TabStop = false;
        AoP.Image = Resources.S2ability2_Badge;
        AoP.Location = new Point(83, 24);
        AoP.Name = "pictureBox13";
        AoP.Size = new Size(50, 50);
        AoP.TabIndex = 6;
        AoP.TabStop = false;
        Foi.BackgroundImage = Resources.S2ability1_Badge;
        Foi.BackgroundImageLayout = ImageLayout.None;
        Foi.Location = new Point(13, 24);
        Foi.Name = "pictureBox14";
        Foi.Size = new Size(50, 50);
        Foi.TabIndex = 4;
        Foi.TabStop = false;
        nom.Location = new Point(21, 184);
        nom.Maximum = new decimal(new int[4] { 999, 0, 0, 0 });
        nom.Name = "NUD_Chunk05";
        nom.Size = new Size(39, 20);
        nom.TabIndex = 11;
        wo0.Location = new Point(299, 80);
        wo0.Maximum = new decimal(new int[4] { 999, 0, 0, 0 });
        wo0.Name = "NUD_Chunk04";
        wo0.Size = new Size(39, 20);
        wo0.TabIndex = 9;
        aoI.Location = new Point(229, 80);
        aoI.Maximum = new decimal(new int[4] { 999, 0, 0, 0 });
        aoI.Name = "NUD_Chunk03";
        aoI.Size = new Size(39, 20);
        aoI.TabIndex = 7;
        LoR.Location = new Point(159, 80);
        LoR.Maximum = new decimal(new int[4] { 999, 0, 0, 0 });
        LoR.Name = "NUD_Chunk02";
        LoR.Size = new Size(39, 20);
        LoR.TabIndex = 5;
        woC.Location = new Point(89, 80);
        woC.Maximum = new decimal(new int[4] { 999, 0, 0, 0 });
        woC.Name = "NUD_Chunk01";
        woC.Size = new Size(39, 20);
        woC.TabIndex = 3;
        uoK.Location = new Point(19, 80);
        uoK.Maximum = new decimal(new int[4] { 999, 0, 0, 0 });
        uoK.Name = "NUD_Chunk00";
        uoK.Size = new Size(39, 20);
        uoK.TabIndex = 1;
        base.AutoScaleDimensions = new SizeF(6f, 13f);
        base.AutoScaleMode = AutoScaleMode.Font;
        base.ClientSize = new Size(743, 631);
        base.Controls.Add(woD);
        base.Controls.Add(MoE);
        base.Controls.Add(ovz);
        base.Controls.Add(BvJ);
        base.Controls.Add(dvL);
        base.Name = "FoodSplat2";
        base.ShowIcon = false;
        base.StartPosition = FormStartPosition.CenterScreen;
        Text = "SplatHeX - Splatoon 2 - Food Tickets/Chunks Editor";
        dvL.ResumeLayout(performLayout: false);
        ((ISupportInitialize)Nvj).EndInit();
        ((ISupportInitialize)ivm).EndInit();
        ((ISupportInitialize)kv0).EndInit();
        ((ISupportInitialize)CvR).EndInit();
        ((ISupportInitialize)uvM).EndInit();
        ((ISupportInitialize)Iv7).EndInit();
        ((ISupportInitialize)KvI).EndInit();
        ((ISupportInitialize)Sv9).EndInit();
        ((ISupportInitialize)TvK).EndInit();
        ((ISupportInitialize)kvT).EndInit();
        ((ISupportInitialize)NvC).EndInit();
        ((ISupportInitialize)fvW).EndInit();
        ((ISupportInitialize)ev1).EndInit();
        ((ISupportInitialize)cvU).EndInit();
        ((ISupportInitialize)Dvw).EndInit();
        ((ISupportInitialize)vvN).EndInit();
        ((ISupportInitialize)lvB).EndInit();
        ((ISupportInitialize)yvY).EndInit();
        ((ISupportInitialize)IvA).EndInit();
        ((ISupportInitialize)pv6).EndInit();
        ((ISupportInitialize)Tvy).EndInit();
        ((ISupportInitialize)dvq).EndInit();
        ((ISupportInitialize)Dvf).EndInit();
        ((ISupportInitialize)Kvx).EndInit();
        ((ISupportInitialize)Fvc).EndInit();
        ((ISupportInitialize)pvr).EndInit();
        ((ISupportInitialize)Nvk).EndInit();
        ((ISupportInitialize)mvP).EndInit();
        BvJ.ResumeLayout(performLayout: false);
        ((ISupportInitialize)Jv4).EndInit();
        ((ISupportInitialize)vv5).EndInit();
        ((ISupportInitialize)fvs).EndInit();
        ((ISupportInitialize)GvZ).EndInit();
        ((ISupportInitialize)kva).EndInit();
        ((ISupportInitialize)Rvi).EndInit();
        ((ISupportInitialize)svu).EndInit();
        ((ISupportInitialize)mvg).EndInit();
        ((ISupportInitialize)Jv2).EndInit();
        ((ISupportInitialize)Rv3).EndInit();
        ((ISupportInitialize)mvd).EndInit();
        ((ISupportInitialize)dvH).EndInit();
        woD.ResumeLayout(performLayout: false);
        ((ISupportInitialize)doX).EndInit();
        ((ISupportInitialize)lop).EndInit();
        ((ISupportInitialize)soS).EndInit();
        ((ISupportInitialize)Qoh).EndInit();
        ((ISupportInitialize)Aol).EndInit();
        ((ISupportInitialize)WoG).EndInit();
        ((ISupportInitialize)iob).EndInit();
        ((ISupportInitialize)Kov).EndInit();
        ((ISupportInitialize)Moo).EndInit();
        ((ISupportInitialize)Bot).EndInit();
        ((ISupportInitialize)voV).EndInit();
        ((ISupportInitialize)LoO).EndInit();
        ((ISupportInitialize)Foe).EndInit();
        ((ISupportInitialize)zo8).EndInit();
        ((ISupportInitialize)Bon).EndInit();
        ((ISupportInitialize)LoQ).EndInit();
        ((ISupportInitialize)DoF).EndInit();
        ((ISupportInitialize)hoL).EndInit();
        ((ISupportInitialize)MoJ).EndInit();
        ((ISupportInitialize)co7).EndInit();
        ((ISupportInitialize)AoP).EndInit();
        ((ISupportInitialize)Foi).EndInit();
        ((ISupportInitialize)nom).EndInit();
        ((ISupportInitialize)wo0).EndInit();
        ((ISupportInitialize)aoI).EndInit();
        ((ISupportInitialize)LoR).EndInit();
        ((ISupportInitialize)woC).EndInit();
        ((ISupportInitialize)uoK).EndInit();
        ResumeLayout(performLayout: false);
    }
}