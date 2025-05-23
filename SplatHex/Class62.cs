using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace SplatHex;
public class Class62 : Form {
    private IDisposable xnP;
    private GroupBox cni;
    private ComboBox Dnm;
    private ComboBox tn0;
    private ComboBox knI;
    private Label EnR;
    private Label pnC;
    private Label AnK;
    private Button jnU;
    private Button gnT;
    private PictureBox vn1;
    public GroupBox rnW;
    public CheckBox Anw;
    public CheckBox tnN;
    public CheckBox hnY;
    public NumericUpDown FnB;
    public Label dnA;
    public CheckBox Hnf;
    public PictureBox Dn6;
    public PictureBox Vnx;
    private TrackBar Bn9;
    private GroupBox bnc;
    private PictureBox Bny;
    private PictureBox qnr;
    private NumericUpDown Fnq;
    private ComboBox qnk;
    private NumericUpDown fnM;
    private NumericUpDown Knu;
    private NumericUpDown eng;
    private Label an2;
    private Label Ln3;
    private GroupBox qnd;
    private NumericUpDown FnH;
    private Label Pn4;
    public Class62() {
        Qn7();
        pnt();
    }

    private void pnt() {
        knI.SelectedIndex = Class108.io2.dt8;
        tn0.SelectedIndex = Class108.io2.otn;
        Dnm.SelectedIndex = Class108.io2.CtQ;
        Hnf.Checked = Class108.io2.NtF == 1;
        tnN.Checked = Class108.io2.PtJ == 1;
        Anw.Checked = Class108.io2.gt7 == 1;
        hnY.Checked = Class108.io2.StL == 1;
        FnB.Value = Class115.VHk(Class108.io2.ztX, 20, bool_0: true) * 5m;
        if (Class108.io2.Tti < 50) {
            eng.Value = Class108.io2.Tti;
        } else {
            eng.Value = 50m;
        }

        eng.Minimum = 1m;
        FnH.Value = Class108.io2.Qtm;
        Knu.Value = Class108.io2.Wt0;
        fnM.Value = Class108.io2.ytI;
        Fnq.Value = Class108.io2.ftC;
        qnk.SelectedIndex = Class108.io2.TtR;
    }

    private void EnV() {
        Class108.io2.Tti = (int)eng.Value;
        Class108.io2.Qtm = (int)FnH.Value;
        Class108.io2.Wt0 = (int)Knu.Value;
        Class108.io2.ytI = (int)fnM.Value;
        Class108.io2.ftC = (int)Fnq.Value;
        Class108.io2.TtR = qnk.SelectedIndex;
        Class108.io2.dt8 = knI.SelectedIndex;
        Class108.io2.otn = tn0.SelectedIndex;
        Class108.io2.CtQ = Dnm.SelectedIndex;
        Class108.io2.NtF = (Hnf.Checked ? 1 : 0);
        Class108.io2.PtJ = (tnN.Checked ? 1 : 0);
        Class108.io2.gt7 = (Anw.Checked ? 1 : 0);
        Class108.io2.StL = (hnY.Checked ? 1 : 0);
        byte[] bytes = BitConverter.GetBytes(Convert.ToSingle(FnB.Value / 5m));
        Class108.io2.ytP = BitConverter.ToInt32(bytes, 0);
        if (Class108.io2.Tti < 10 && (Class108.io2.TtR != 0 || Class108.io2.ftC != 0)) {
            DialogResult dialogResult = MessageBox.Show("Your rank doesn't match with your level,\ndo you want to reset your rank ?", "SplatHeX", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes) {
                Class108.io2.ftC = 0;
                Class108.io2.TtR = 0;
            }
        }
    }

    private void GnO(object sender, EventArgs e) {
        EnV();
        Close();
    }

    private void Lne(object sender, EventArgs e) {
        Close();
    }

    private void Gn8(object sender, EventArgs e) {
        Bn9.Value = (int)FnB.Value;
    }

    private void fnn(object sender, EventArgs e) {
        FnB.Value = Bn9.Value;
    }

    private void JnQ(object sender, EventArgs e) {
        if (eng.Value == 50m) {
            FnH.Enabled = false;
            Pn4.Text = "MAX";
            FnH.Value = 0m;
        } else {
            FnH.Enabled = true;
            FnH.Value = 0m;
            FnH.Maximum = Class108.wog[(int)eng.Value] - 1;
            Pn4.Text = "/ " + Class108.wog[(int)eng.Value];
        }
    }

    private void onF(object sender, EventArgs e) {
        switch (knI.SelectedIndex) {
            case 0:
                vn1.Image = Resources.inkling_girl;
                break;
            case 1:
                vn1.Image = Resources.inkling_boy;
                break;
            case 2:
                vn1.Image = Resources.octoling;
                break;
        }
    }

    private void anL(object sender, EventArgs e) {
        switch (tn0.SelectedIndex) {
            case 0:
                Dn6.BackColor = Color.SaddleBrown;
                break;
            case 1:
                Dn6.BackColor = Color.Magenta;
                break;
            case 2:
                Dn6.BackColor = Color.Blue;
                break;
            case 3:
                Dn6.BackColor = Color.Orange;
                break;
            case 4:
                Dn6.BackColor = Color.Turquoise;
                break;
            case 5:
                Dn6.BackColor = Color.Black;
                break;
            case 6:
                Dn6.BackColor = Color.Yellow;
                break;
        }
    }

    private void qnJ(object sender, EventArgs e) {
        switch (Dnm.SelectedIndex) {
            case 0:
                Vnx.BackColor = Color.FromArgb(219, 189, 168);
                break;
            case 1:
                Vnx.BackColor = Color.FromArgb(218, 182, 152);
                break;
            case 2:
                Vnx.BackColor = Color.FromArgb(219, 173, 126);
                break;
            case 3:
                Vnx.BackColor = Color.FromArgb(195, 125, 81);
                break;
            case 4:
                Vnx.BackColor = Color.FromArgb(165, 85, 46);
                break;
            case 5:
                Vnx.BackColor = Color.FromArgb(117, 46, 20);
                break;
            case 6:
                Vnx.BackColor = Color.FromArgb(76, 27, 15);
                break;
        }
    }

    protected override void Dispose(bool disposing) {
        if (disposing && xnP != null) {
            xnP.Dispose();
        }

        base.Dispose(disposing);
    }

    private void Qn7() {
        cni = new GroupBox();
        Dn6 = new PictureBox();
        Vnx = new PictureBox();
        vn1 = new PictureBox();
        Dnm = new ComboBox();
        tn0 = new ComboBox();
        knI = new ComboBox();
        EnR = new Label();
        pnC = new Label();
        AnK = new Label();
        jnU = new Button();
        gnT = new Button();
        rnW = new GroupBox();
        Bn9 = new TrackBar();
        Anw = new CheckBox();
        tnN = new CheckBox();
        hnY = new CheckBox();
        FnB = new NumericUpDown();
        dnA = new Label();
        Hnf = new CheckBox();
        bnc = new GroupBox();
        qnd = new GroupBox();
        Pn4 = new Label();
        FnH = new NumericUpDown();
        Ln3 = new Label();
        eng = new NumericUpDown();
        an2 = new Label();
        Bny = new PictureBox();
        qnr = new PictureBox();
        Fnq = new NumericUpDown();
        qnk = new ComboBox();
        fnM = new NumericUpDown();
        Knu = new NumericUpDown();
        cni.SuspendLayout();
        ((ISupportInitialize)Dn6).BeginInit();
        ((ISupportInitialize)Vnx).BeginInit();
        ((ISupportInitialize)vn1).BeginInit();
        rnW.SuspendLayout();
        ((ISupportInitialize)Bn9).BeginInit();
        ((ISupportInitialize)FnB).BeginInit();
        bnc.SuspendLayout();
        qnd.SuspendLayout();
        ((ISupportInitialize)FnH).BeginInit();
        ((ISupportInitialize)eng).BeginInit();
        ((ISupportInitialize)Bny).BeginInit();
        ((ISupportInitialize)qnr).BeginInit();
        ((ISupportInitialize)Fnq).BeginInit();
        ((ISupportInitialize)fnM).BeginInit();
        ((ISupportInitialize)Knu).BeginInit();
        SuspendLayout();
        cni.Controls.Add(Dn6);
        cni.Controls.Add(Vnx);
        cni.Controls.Add(vn1);
        cni.Controls.Add(Dnm);
        cni.Controls.Add(tn0);
        cni.Controls.Add(knI);
        cni.Controls.Add(EnR);
        cni.Controls.Add(pnC);
        cni.Controls.Add(AnK);
        cni.Location = new Point(60, 12);
        cni.Name = "groupBox5";
        cni.Size = new Size(292, 240);
        cni.TabIndex = 2;
        cni.TabStop = false;
        cni.Text = "Character";
        Dn6.BackColor = Color.SaddleBrown;
        Dn6.BorderStyle = BorderStyle.FixedSingle;
        Dn6.Location = new Point(212, 64);
        Dn6.Name = "pic_eye";
        Dn6.Size = new Size(69, 36);
        Dn6.SizeMode = PictureBoxSizeMode.StretchImage;
        Dn6.TabIndex = 13;
        Dn6.TabStop = false;
        Vnx.BackColor = Color.FromArgb(219, 189, 168);
        Vnx.BorderStyle = BorderStyle.FixedSingle;
        Vnx.Location = new Point(212, 158);
        Vnx.Name = "pic_skin";
        Vnx.Size = new Size(69, 36);
        Vnx.SizeMode = PictureBoxSizeMode.StretchImage;
        Vnx.TabIndex = 12;
        Vnx.TabStop = false;
        vn1.BackColor = Color.Transparent;
        vn1.BorderStyle = BorderStyle.FixedSingle;
        vn1.Image = Resources.inkling_girl;
        vn1.Location = new Point(9, 64);
        vn1.Name = "PB_Gender";
        vn1.Size = new Size(100, 168);
        vn1.SizeMode = PictureBoxSizeMode.Zoom;
        vn1.TabIndex = 11;
        vn1.TabStop = false;
        Dnm.DropDownStyle = ComboBoxStyle.DropDownList;
        Dnm.FormattingEnabled = true;
        Dnm.Items.AddRange(new object[7] { "1 - Lightest", "PBi.aBM", "gBK.sBh", "4", "rB1.GBe", "OBV.oBy", "7 - Darkest" });
        Dnm.Location = new Point(121, 158);
        Dnm.Name = "CB_skins";
        Dnm.Size = new Size(85, 21);
        Dnm.TabIndex = 10;
        Dnm.SelectedIndexChanged += qnJ;
        tn0.DropDownStyle = ComboBoxStyle.DropDownList;
        tn0.FormattingEnabled = true;
        tn0.Items.AddRange(new object[7] { "Brown", "Pink", "Blue", "Orange", "Green", "Black", "Yellow" });
        tn0.Location = new Point(121, 64);
        tn0.Name = "CB_eyecolors";
        tn0.Size = new Size(85, 21);
        tn0.TabIndex = 9;
        tn0.SelectedIndexChanged += anL;
        knI.DropDownStyle = ComboBoxStyle.DropDownList;
        knI.FormattingEnabled = true;
        knI.Items.AddRange(new object[3] { "Female", "Male", "Octoling" });
        knI.Location = new Point(9, 37);
        knI.Name = "CB_Gender";
        knI.Size = new Size(85, 21);
        knI.TabIndex = 8;
        knI.SelectedIndexChanged += onF;
        EnR.AutoSize = true;
        EnR.Location = new Point(118, 142);
        EnR.Name = "label29";
        EnR.Size = new Size(34, 13);
        EnR.TabIndex = 5;
        EnR.Text = "Skin :";
        pnC.AutoSize = true;
        pnC.Location = new Point(118, 48);
        pnC.Name = "label30";
        pnC.Size = new Size(31, 13);
        pnC.TabIndex = 3;
        pnC.Text = "Eye :";
        AnK.AutoSize = true;
        AnK.Location = new Point(6, 18);
        AnK.Name = "label31";
        AnK.Size = new Size(48, 13);
        AnK.TabIndex = 1;
        AnK.Text = "Gender :";
        jnU.Location = new Point(362, 458);
        jnU.Name = "BTN_Close";
        jnU.Size = new Size(45, 23);
        jnU.TabIndex = 5;
        jnU.Text = "Close";
        jnU.UseVisualStyleBackColor = true;
        jnU.Click += Lne;
        gnT.Location = new Point(313, 458);
        gnT.Name = "BTN_Save";
        gnT.Size = new Size(45, 23);
        gnT.TabIndex = 4;
        gnT.Text = "Save";
        gnT.UseVisualStyleBackColor = true;
        gnT.Click += GnO;
        rnW.Controls.Add(Bn9);
        rnW.Controls.Add(Anw);
        rnW.Controls.Add(tnN);
        rnW.Controls.Add(hnY);
        rnW.Controls.Add(FnB);
        rnW.Controls.Add(dnA);
        rnW.Controls.Add(Hnf);
        rnW.Location = new Point(12, 258);
        rnW.Name = "groupBox1";
        rnW.Size = new Size(199, 194);
        rnW.TabIndex = 10;
        rnW.TabStop = false;
        rnW.Text = "Options";
        Bn9.LargeChange = 1;
        Bn9.Location = new Point(4, 142);
        Bn9.Maximum = 5;
        Bn9.Minimum = -5;
        Bn9.Name = "track_camera";
        Bn9.Size = new Size(187, 45);
        Bn9.TabIndex = 8;
        Bn9.Scroll += fnn;
        Anw.AutoSize = true;
        Anw.Location = new Point(18, 60);
        Anw.Name = "CB_RevY";
        Anw.Size = new Size(96, 17);
        Anw.TabIndex = 6;
        Anw.Text = "Inverted Y axis";
        Anw.UseVisualStyleBackColor = true;
        tnN.AutoSize = true;
        tnN.Location = new Point(18, 76);
        tnN.Name = "CB_RevX";
        tnN.Size = new Size(96, 17);
        tnN.TabIndex = 5;
        tnN.Text = "Inverted X axis";
        tnN.UseVisualStyleBackColor = true;
        hnY.AutoSize = true;
        hnY.Location = new Point(18, 45);
        hnY.Name = "CB_MotionControl";
        hnY.Size = new Size(94, 17);
        hnY.TabIndex = 4;
        hnY.Text = "Motion Control";
        hnY.UseVisualStyleBackColor = true;
        FnB.Location = new Point(141, 109);
        FnB.Maximum = new decimal(new int[4] { 5, 0, 0, 0 });
        FnB.Minimum = new decimal(new int[4] { 5, 0, 0, -2147483648 });
        FnB.Name = "NUD_Camera";
        FnB.Size = new Size(50, 20);
        FnB.TabIndex = 3;
        FnB.ValueChanged += Gn8;
        dnA.AutoSize = true;
        dnA.Location = new Point(6, 114);
        dnA.Name = "label9";
        dnA.Size = new Size(93, 13);
        dnA.TabIndex = 2;
        dnA.Text = "Camera Sensitivity";
        Hnf.AutoSize = true;
        Hnf.Location = new Point(18, 29);
        Hnf.Name = "CB_ColorLock";
        Hnf.Size = new Size(77, 17);
        Hnf.TabIndex = 0;
        Hnf.Text = "Color Lock";
        Hnf.UseVisualStyleBackColor = true;
        bnc.Controls.Add(qnd);
        bnc.Controls.Add(an2);
        bnc.Controls.Add(Bny);
        bnc.Controls.Add(qnr);
        bnc.Controls.Add(Fnq);
        bnc.Controls.Add(qnk);
        bnc.Controls.Add(fnM);
        bnc.Controls.Add(Knu);
        bnc.Location = new Point(217, 258);
        bnc.Name = "groupBox4";
        bnc.Size = new Size(190, 194);
        bnc.TabIndex = 11;
        bnc.TabStop = false;
        bnc.Text = "Stats";
        qnd.Controls.Add(Pn4);
        qnd.Controls.Add(FnH);
        qnd.Controls.Add(Ln3);
        qnd.Controls.Add(eng);
        qnd.Location = new Point(6, 14);
        qnd.Name = "groupBox2";
        qnd.Size = new Size(180, 62);
        qnd.TabIndex = 12;
        qnd.TabStop = false;
        Pn4.AutoSize = true;
        Pn4.Location = new Point(134, 39);
        Pn4.Name = "LB_EXPMax";
        Pn4.Size = new Size(12, 13);
        Pn4.TabIndex = 16;
        Pn4.Text = "/";
        FnH.Location = new Point(83, 36);
        FnH.Maximum = new decimal(new int[4] { 9999999, 0, 0, 0 });
        FnH.Name = "NUD_Exp";
        FnH.Size = new Size(51, 20);
        FnH.TabIndex = 15;
        Ln3.AutoSize = true;
        Ln3.Font = new Font("Project Paintball", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
        Ln3.ForeColor = Color.Lime;
        Ln3.Location = new Point(3, 10);
        Ln3.Name = "label1";
        Ln3.Size = new Size(63, 23);
        Ln3.TabIndex = 13;
        Ln3.Text = "Level";
        eng.Location = new Point(142, 13);
        eng.Maximum = new decimal(new int[4] { 50, 0, 0, 0 });
        eng.Name = "NUD_Level";
        eng.Size = new Size(36, 20);
        eng.TabIndex = 0;
        eng.ValueChanged += JnQ;
        an2.AutoSize = true;
        an2.Font = new Font("Project Paintball", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
        an2.ForeColor = Color.FromArgb(255, 128, 0);
        an2.Location = new Point(9, 83);
        an2.Name = "label2";
        an2.Size = new Size(61, 23);
        an2.TabIndex = 14;
        an2.Text = "Rank";
        Bny.Image = Resources.icon_seasnail;
        Bny.Location = new Point(13, 154);
        Bny.Name = "pictureBox2";
        Bny.Size = new Size(34, 34);
        Bny.SizeMode = PictureBoxSizeMode.Zoom;
        Bny.TabIndex = 12;
        Bny.TabStop = false;
        qnr.Image = Resources.icon_cash;
        qnr.Location = new Point(13, 114);
        qnr.Name = "pictureBox1";
        qnr.Size = new Size(34, 34);
        qnr.SizeMode = PictureBoxSizeMode.Zoom;
        qnr.TabIndex = 11;
        qnr.TabStop = false;
        Fnq.Location = new Point(148, 87);
        Fnq.Maximum = new decimal(new int[4] { 99, 0, 0, 0 });
        Fnq.Name = "NUD_Rank";
        Fnq.Size = new Size(36, 20);
        Fnq.TabIndex = 10;
        qnk.DropDownStyle = ComboBoxStyle.DropDownList;
        qnk.FormattingEnabled = true;
        qnk.Items.AddRange(new object[11] { "C-", "xOV.xOy", "C+", "B-", "HO1.rOe", "B+", "A-", "aOK.tOh", "A+", "rOL.VOd", "S+" });
        qnk.Location = new Point(108, 87);
        qnk.Name = "rankBox";
        qnk.Size = new Size(36, 21);
        qnk.TabIndex = 7;
        fnM.Location = new Point(105, 160);
        fnM.Maximum = new decimal(new int[4] { 999, 0, 0, 0 });
        fnM.Name = "NUD_SeaSnail";
        fnM.Size = new Size(79, 20);
        fnM.TabIndex = 4;
        Knu.Location = new Point(105, 122);
        Knu.Maximum = new decimal(new int[4] { 9999999, 0, 0, 0 });
        Knu.Name = "NUD_Money";
        Knu.Size = new Size(79, 20);
        Knu.TabIndex = 2;
        base.AutoScaleDimensions = new SizeF(6f, 13f);
        base.AutoScaleMode = AutoScaleMode.Font;
        base.ClientSize = new Size(419, 487);
        base.Controls.Add(bnc);
        base.Controls.Add(rnW);
        base.Controls.Add(jnU);
        base.Controls.Add(gnT);
        base.Controls.Add(cni);
        base.Name = "PlayerEditorSplat1";
        base.ShowIcon = false;
        base.StartPosition = FormStartPosition.CenterScreen;
        Text = "SplatHeX - Splatoon 1 - Player Infos Editor";
        cni.ResumeLayout(performLayout: false);
        cni.PerformLayout();
        ((ISupportInitialize)Dn6).EndInit();
        ((ISupportInitialize)Vnx).EndInit();
        ((ISupportInitialize)vn1).EndInit();
        rnW.ResumeLayout(performLayout: false);
        rnW.PerformLayout();
        ((ISupportInitialize)Bn9).EndInit();
        ((ISupportInitialize)FnB).EndInit();
        bnc.ResumeLayout(performLayout: false);
        bnc.PerformLayout();
        qnd.ResumeLayout(performLayout: false);
        qnd.PerformLayout();
        ((ISupportInitialize)FnH).EndInit();
        ((ISupportInitialize)eng).EndInit();
        ((ISupportInitialize)Bny).EndInit();
        ((ISupportInitialize)qnr).EndInit();
        ((ISupportInitialize)Fnq).EndInit();
        ((ISupportInitialize)fnM).EndInit();
        ((ISupportInitialize)Knu).EndInit();
        ResumeLayout(performLayout: false);
    }
}