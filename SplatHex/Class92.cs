using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace SplatHex;
public class Class92 : Form {
    private IDisposable MKW;
    private Button AKw;
    private NumericUpDown BKN;
    private GroupBox XKY;
    private ListBox sKB;
    private PictureBox KKA;
    private ComboBox BKf;
    private Button nK6;
    private Label DKx;
    private GroupBox bK9;
    private NumericUpDown fKc;
    private Label TKy;
    private NumericUpDown hKr;
    private Label eKq;
    private NumericUpDown aKk;
    private Label sKM;
    private NumericUpDown uKu;
    private Label WKg;
    private NumericUpDown eK2;
    private Label PK3;
    private NumericUpDown qKd;
    private Label YKH;
    private ComboBox MK4;
    private Label aK5;
    private NumericUpDown nKs;
    private Label iKZ;
    private Button UKa;
    public Class92() {
        XK1();
        kKP();
        kKJ();
        if (sKB.Items.Count != 0) {
            sKB.SelectedIndex = 0;
        }
    }

    private void kKJ() {
        MK4.SelectedIndex = Class26.QXu.vps;
        nKs.Value = Class26.QXu.MpZ;
        aKk.Value = Class26.QXu.ipj;
        hKr.Value = Class26.QXu.Rpz;
        fKc.Value = Class26.QXu.HSE;
        qKd.Value = Class26.QXu.QSD;
        eK2.Value = Class26.QXu.hSX;
        uKu.Value = Class26.QXu.Gpa;
    }

    private void VK7(object sender, EventArgs e) {
        Class26.QXu.vps = MK4.SelectedIndex;
        Class26.QXu.MpZ = (int)nKs.Value;
        Class26.QXu.ipj = (int)aKk.Value;
        Class26.QXu.Rpz = (int)hKr.Value;
        Class26.QXu.HSE = (int)fKc.Value;
        Class26.QXu.QSD = (int)qKd.Value;
        Class26.QXu.hSX = (int)eK2.Value;
        Class26.QXu.Gpa = (int)uKu.Value;
        MessageBox.Show("Done.");
    }

    private void kKP() {
        sKB.Items.Clear();
        for (int i = 1; i < Class26.QXu.tp4 + 1; i++) {
            sKB.Items.Add("Loot n°" + i);
        }
    }

    private void XKi(object sender, EventArgs e) {
        KKA.BackgroundImage = Class38.Dnh(Class26.TXs[sKB.SelectedIndex].yhL);
        if (Class26.TXs[sKB.SelectedIndex].yhL != 0) {
            BKf.SelectedIndex = Class26.TXs[sKB.SelectedIndex].YhJ - 2;
            if (Class26.TXs[sKB.SelectedIndex].yhL == 2) {
                DKx.Text = JKR(Class26.TXs[sKB.SelectedIndex].YhJ);
            } else if (Class26.TXs[sKB.SelectedIndex].yhL == 3) {
                DKx.Text = GKC(Class26.TXs[sKB.SelectedIndex].YhJ);
            } else if (Class26.TXs[sKB.SelectedIndex].yhL == 4) {
                DKx.Text = FKK(Class26.TXs[sKB.SelectedIndex].YhJ);
            } else if (Class26.TXs[sKB.SelectedIndex].yhL == 5) {
                DKx.Text = iKU(Class26.TXs[sKB.SelectedIndex].YhJ);
            } else if (Class26.TXs[sKB.SelectedIndex].yhL == 6 || Class26.TXs[sKB.SelectedIndex].yhL == 7) {
                DKx.Text = WKT(Class26.TXs[sKB.SelectedIndex].YhJ);
            }
        }
    }

    private void aKm(object sender, EventArgs e) {
        Class26.TXs[sKB.SelectedIndex].YhJ = BKf.SelectedIndex + 2;
    }

    private void zK0(object sender, EventArgs e) {
        DialogResult dialogResult = MessageBox.Show("Do you want to overwrite your bonus to add " + BKN.Value + " new random bonus ?", "Randomize?", MessageBoxButtons.YesNo);
        if (dialogResult != DialogResult.Yes) {
            return;
        }

        for (int i = 0; i < Class26.TXs.Length; i++) {
            Class26.TXs[i].yhL = 0;
            Class26.TXs[i].YhJ = 0;
            Class26.TXs[i].Wh7 = -1;
            Class26.TXs[i].BhP = -1;
            Class26.TXs[i].Ahi = 0;
        }

        for (int j = 0; (decimal)j < BKN.Value; j++) {
            int num = Class115.nHs(2, 5);
            int yhJ = Class115.nHs(2, 4);
            switch (num) {
                case 2:
                    Class26.TXs[j].yhL = num;
                    Class26.TXs[j].YhJ = yhJ;
                    break;
                case 3:
                case 4:
                case 5:
                    Class26.TXs[j].yhL = num;
                    Class26.TXs[j].YhJ = yhJ;
                    Class26.TXs[j].Ahi = Class115.nHs(0, 2147483646);
                    break;
            }
        }

        Class26.QXu.tp4 = (int)BKN.Value;
        kKP();
        MessageBox.Show("Done.");
    }

    private void qKI(object sender, EventArgs e) {
        if (Class26.TXs[sKB.SelectedIndex].yhL == 2) {
            DKx.Text = JKR(BKf.SelectedIndex + 2);
        } else if (Class26.TXs[sKB.SelectedIndex].yhL == 3) {
            DKx.Text = GKC(BKf.SelectedIndex + 2);
        } else if (Class26.TXs[sKB.SelectedIndex].yhL == 4) {
            DKx.Text = FKK(BKf.SelectedIndex + 2);
        } else if (Class26.TXs[sKB.SelectedIndex].yhL == 5) {
            DKx.Text = iKU(BKf.SelectedIndex + 2);
        } else if (Class26.TXs[sKB.SelectedIndex].yhL == 6 || Class26.TXs[sKB.SelectedIndex].yhL == 7) {
            DKx.Text = WKT(BKf.SelectedIndex + 2);
        }
    }

    public string JKR(int int_0) {
        switch (int_0) {
            default:
                return "?";
            case 2:
                return "4000 Cash";
            case 3:
                return "16000 Cash";
            case 4:
            case 5:
                return "32000 Cash";
        }
    }

    public string GKC(int int_0) {
        switch (int_0) {
            default:
                return "?";
            case 2:
                return "4000 Cash";
            case 3:
                return "One 2× ticket";
            case 4:
            case 5:
                return "One 2.5× ticket";
        }
    }

    public string FKK(int int_0) {
        switch (int_0) {
            default:
                return "?";
            case 2:
                return "4000 Cash";
            case 3:
                return "One drink ticket";
            case 4:
            case 5:
                return "Three drink tickets";
        }
    }

    public string iKU(int int_0) {
        switch (int_0) {
            default:
                return "?";
            case 2:
                return "4000 Cash";
            case 3:
                return "Two ability chunks";
            case 4:
            case 5:
                return "Four ability chunks";
        }
    }

    public string WKT(int int_0) {
        switch (int_0) {
            default:
                return "?";
            case 2:
                return "No slots";
            case 3:
                return "One slot";
            case 4:
            case 5:
                return "Three slots";
        }
    }

    protected override void Dispose(bool disposing) {
        if (disposing && MKW != null) {
            MKW.Dispose();
        }

        base.Dispose(disposing);
    }

    private void XK1() {
        AKw = new Button();
        BKN = new NumericUpDown();
        XKY = new GroupBox();
        DKx = new Label();
        nK6 = new Button();
        BKf = new ComboBox();
        KKA = new PictureBox();
        sKB = new ListBox();
        bK9 = new GroupBox();
        UKa = new Button();
        nKs = new NumericUpDown();
        iKZ = new Label();
        aK5 = new Label();
        MK4 = new ComboBox();
        eK2 = new NumericUpDown();
        PK3 = new Label();
        qKd = new NumericUpDown();
        YKH = new Label();
        fKc = new NumericUpDown();
        TKy = new Label();
        hKr = new NumericUpDown();
        eKq = new Label();
        aKk = new NumericUpDown();
        sKM = new Label();
        uKu = new NumericUpDown();
        WKg = new Label();
        ((ISupportInitialize)BKN).BeginInit();
        XKY.SuspendLayout();
        ((ISupportInitialize)KKA).BeginInit();
        bK9.SuspendLayout();
        ((ISupportInitialize)nKs).BeginInit();
        ((ISupportInitialize)eK2).BeginInit();
        ((ISupportInitialize)qKd).BeginInit();
        ((ISupportInitialize)fKc).BeginInit();
        ((ISupportInitialize)hKr).BeginInit();
        ((ISupportInitialize)aKk).BeginInit();
        ((ISupportInitialize)uKu).BeginInit();
        SuspendLayout();
        AKw.Location = new Point(163, 180);
        AKw.Name = "B_Random";
        AKw.Size = new Size(94, 23);
        AKw.TabIndex = 0;
        AKw.Text = "Randomize Loot";
        AKw.UseVisualStyleBackColor = true;
        AKw.Click += zK0;
        BKN.Location = new Point(262, 182);
        BKN.Maximum = new decimal(new int[4] { 99, 0, 0, 0 });
        BKN.Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
        BKN.Name = "NUD_BonusCount";
        BKN.Size = new Size(36, 20);
        BKN.TabIndex = 1;
        BKN.Value = new decimal(new int[4] { 99, 0, 0, 0 });
        XKY.Controls.Add(DKx);
        XKY.Controls.Add(nK6);
        XKY.Controls.Add(BKf);
        XKY.Controls.Add(KKA);
        XKY.Controls.Add(sKB);
        XKY.Controls.Add(AKw);
        XKY.Controls.Add(BKN);
        XKY.Location = new Point(12, 12);
        XKY.Name = "GB_Loot";
        XKY.Size = new Size(307, 210);
        XKY.TabIndex = 2;
        XKY.TabStop = false;
        XKY.Text = "Loot Editor";
        DKx.AutoSize = true;
        DKx.Location = new Point(213, 143);
        DKx.Name = "LB_RarTip";
        DKx.Size = new Size(0, 13);
        DKx.TabIndex = 6;
        nK6.Location = new Point(111, 180);
        nK6.Name = "B_Save";
        nK6.Size = new Size(46, 23);
        nK6.TabIndex = 5;
        nK6.Text = "Save";
        nK6.UseVisualStyleBackColor = true;
        nK6.Click += aKm;
        BKf.DropDownStyle = ComboBoxStyle.DropDownList;
        BKf.FormattingEnabled = true;
        BKf.Items.AddRange(new object[3] { "Common", "Rare", "Very Rare" });
        BKf.Location = new Point(111, 139);
        BKf.Name = "CB_Rarity";
        BKf.Size = new Size(100, 21);
        BKf.TabIndex = 4;
        BKf.SelectedIndexChanged += qKI;
        KKA.BackgroundImageLayout = ImageLayout.Zoom;
        KKA.Location = new Point(111, 19);
        KKA.Name = "PB_LootIcon";
        KKA.Size = new Size(100, 100);
        KKA.TabIndex = 3;
        KKA.TabStop = false;
        sKB.FormattingEnabled = true;
        sKB.Location = new Point(6, 19);
        sKB.Name = "lootList";
        sKB.Size = new Size(99, 186);
        sKB.TabIndex = 2;
        sKB.SelectedIndexChanged += XKi;
        bK9.Controls.Add(UKa);
        bK9.Controls.Add(nKs);
        bK9.Controls.Add(iKZ);
        bK9.Controls.Add(aK5);
        bK9.Controls.Add(MK4);
        bK9.Controls.Add(eK2);
        bK9.Controls.Add(PK3);
        bK9.Controls.Add(qKd);
        bK9.Controls.Add(YKH);
        bK9.Controls.Add(fKc);
        bK9.Controls.Add(TKy);
        bK9.Controls.Add(hKr);
        bK9.Controls.Add(eKq);
        bK9.Controls.Add(aKk);
        bK9.Controls.Add(sKM);
        bK9.Controls.Add(uKu);
        bK9.Controls.Add(WKg);
        bK9.Location = new Point(325, 12);
        bK9.Name = "groupBox1";
        bK9.Size = new Size(393, 210);
        bK9.TabIndex = 3;
        bK9.TabStop = false;
        bK9.Text = "Stats";
        UKa.Location = new Point(341, 184);
        UKa.Name = "B_SaveStats";
        UKa.Size = new Size(46, 23);
        UKa.TabIndex = 16;
        UKa.Text = "Save";
        UKa.UseVisualStyleBackColor = true;
        UKa.Click += VK7;
        nKs.Location = new Point(15, 88);
        nKs.Maximum = new decimal(new int[4] { 999, 0, 0, 0 });
        nKs.Name = "NUD_RankPTS";
        nKs.Size = new Size(39, 20);
        nKs.TabIndex = 15;
        iKZ.AutoSize = true;
        iKZ.Location = new Point(12, 72);
        iKZ.Name = "label8";
        iKZ.Size = new Size(64, 13);
        iKZ.TabIndex = 14;
        iKZ.Text = "Rank points";
        aK5.AutoSize = true;
        aK5.Location = new Point(12, 26);
        aK5.Name = "label7";
        aK5.Size = new Size(33, 13);
        aK5.TabIndex = 13;
        aK5.Text = "Rank";
        MK4.DropDownStyle = ComboBoxStyle.DropDownList;
        MK4.FormattingEnabled = true;
        MK4.Items.AddRange(new object[6] { "Intern", "Apprentice", "Part-Timer", "Go-Getter", "Overachiever", "Profreshional" });
        MK4.Location = new Point(15, 42);
        MK4.Name = "CB_Rank";
        MK4.Size = new Size(121, 21);
        MK4.TabIndex = 12;
        eK2.Location = new Point(279, 88);
        eK2.Maximum = new decimal(new int[4] { 9999999, 0, 0, 0 });
        eK2.Name = "NUD_Total";
        eK2.Size = new Size(69, 20);
        eK2.TabIndex = 11;
        PK3.AutoSize = true;
        PK3.Location = new Point(276, 72);
        PK3.Name = "label6";
        PK3.Size = new Size(62, 13);
        PK3.TabIndex = 10;
        PK3.Text = "Total points";
        qKd.Location = new Point(279, 44);
        qKd.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
        qKd.Name = "NUD_Rescued";
        qKd.Size = new Size(69, 20);
        qKd.TabIndex = 9;
        YKH.AutoSize = true;
        YKH.Location = new Point(276, 28);
        YKH.Name = "label5";
        YKH.Size = new Size(112, 13);
        YKH.TabIndex = 8;
        YKH.Text = "Crew member rescued";
        fKc.Location = new Point(161, 174);
        fKc.Maximum = new decimal(new int[4] { 999999999, 0, 0, 0 });
        fKc.Name = "NUD_PowerEggs";
        fKc.Size = new Size(69, 20);
        fKc.TabIndex = 7;
        TKy.AutoSize = true;
        TKy.Location = new Point(158, 158);
        TKy.Name = "label4";
        TKy.Size = new Size(109, 13);
        TKy.TabIndex = 6;
        TKy.Text = "Power eggs collected";
        hKr.Location = new Point(161, 131);
        hKr.Maximum = new decimal(new int[4] { 9999999, 0, 0, 0 });
        hKr.Name = "NUD_GoldenEggs";
        hKr.Size = new Size(69, 20);
        hKr.TabIndex = 5;
        eKq.AutoSize = true;
        eKq.Location = new Point(158, 115);
        eKq.Name = "label3";
        eKq.Size = new Size(113, 13);
        eKq.TabIndex = 4;
        eKq.Text = "Golden eggs collected";
        aKk.Location = new Point(161, 88);
        aKk.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
        aKk.Name = "NUD_Shifts";
        aKk.Size = new Size(69, 20);
        aKk.TabIndex = 3;
        sKM.AutoSize = true;
        sKM.Location = new Point(158, 72);
        sKM.Name = "label2";
        sKM.Size = new Size(71, 13);
        sKM.TabIndex = 2;
        sKM.Text = "Shifts worked";
        uKu.Location = new Point(161, 44);
        uKu.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
        uKu.Name = "NUD_CPTS";
        uKu.Size = new Size(69, 20);
        uKu.TabIndex = 1;
        WKg.AutoSize = true;
        WKg.Location = new Point(158, 28);
        WKg.Name = "label1";
        WKg.Size = new Size(72, 13);
        WKg.TabIndex = 0;
        WKg.Text = "Current points";
        base.AutoScaleDimensions = new SizeF(6f, 13f);
        base.AutoScaleMode = AutoScaleMode.Font;
        base.ClientSize = new Size(732, 226);
        base.Controls.Add(bK9);
        base.Controls.Add(XKY);
        base.Name = "SalmonSplat2";
        base.ShowIcon = false;
        base.StartPosition = FormStartPosition.CenterScreen;
        Text = "SplatHeX - Splatoon 2 - Salmon Editor";
        ((ISupportInitialize)BKN).EndInit();
        XKY.ResumeLayout(performLayout: false);
        XKY.PerformLayout();
        ((ISupportInitialize)KKA).EndInit();
        bK9.ResumeLayout(performLayout: false);
        bK9.PerformLayout();
        ((ISupportInitialize)nKs).EndInit();
        ((ISupportInitialize)eK2).EndInit();
        ((ISupportInitialize)qKd).EndInit();
        ((ISupportInitialize)fKc).EndInit();
        ((ISupportInitialize)hKr).EndInit();
        ((ISupportInitialize)aKk).EndInit();
        ((ISupportInitialize)uKu).EndInit();
        ResumeLayout(performLayout: false);
    }
}