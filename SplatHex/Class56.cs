using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace SplatHex;
public class Class56 : Form {
    public float oQV;
    public float rQO;
    public float RQe;
    private IDisposable aQ8;
    private ListBox DQn;
    public GroupBox VQQ;
    public PictureBox OQF;
    private Label rQL;
    private Button oQJ;
    public NumericUpDown XQ7;
    public Label XQP;
    public Label jQi;
    public TextBox pQm;
    public NumericUpDown YQ0;
    public Label RQI;
    public ComboBox vQR;
    public Label XQC;
    public PictureBox vQK;
    public NumericUpDown RQU;
    public Label TQT;
    public PictureBox nQ1;
    public NumericUpDown UQW;
    public Label KQw;
    public Label iQN;
    public NumericUpDown TQY;
    private Button TQB;
    public PictureBox oQA;
    private ColorDialog pQf;
    private Button QQ6;
    private ComboBox PQx;
    private PictureBox EQ9;
    private ComboBox lQc;
    private PictureBox jQy;
    private ComboBox kQr;
    private PictureBox pQq;
    private ComboBox bQk;
    private PictureBox HQM;
    public Class56() {
        tQt();
        En5();
        Jns();
    }

    private void En5() {
        oQA.BackColor = Color.FromArgb(Convert.ToInt32(oQV), Convert.ToInt32(rQO), Convert.ToInt32(RQe));
        foreach (int key in Class117.eoy.Keys) {
            kQr.Items.Add(Class117.eoy[key].rDY);
        }

        foreach (int key2 in Class117.qor.Keys) {
            lQc.Items.Add(Class117.qor[key2].rDY);
        }

        foreach (int key3 in Class117.toq.Keys) {
            PQx.Items.Add(Class117.toq[key3].rDY);
        }

        foreach (int key4 in Class46.Lou.Keys) {
            bQk.Items.Add(Class46.Lou[key4].aDj);
        }
    }

    private void Jns() {
        DQn.Items.Clear();
        for (int i = 0; i < Class108.Foa.Length; i++) {
            DQn.Items.Add(Class108.Foa[i].Btd);
        }

        DQn.SelectedIndex = 0;
    }

    private void PnZ(object sender, EventArgs e) {
        int selectedIndex = DQn.SelectedIndex;
        Una(selectedIndex);
    }

    private void Una(int int_0) {
        if (DQn.SelectedIndex == -1) {
            return;
        }

        if (Class108.Foa[int_0].XtH != -1) {
            VQQ.Enabled = true;
            VQQ.Text = "Data";
            YQ0.Value = Class108.Foa[int_0].ut4;
            vQR.SelectedIndex = Class108.Foa[int_0].Gt5;
            XQ7.Value = Class108.Foa[int_0].xtj;
            pQm.Text = Class108.Foa[int_0].Btd;
            TQY.Value = Class108.Foa[int_0].AtZ;
            UQW.Value = Class108.Foa[int_0].Jts;
            RQU.Value = Class108.Foa[int_0].wta;
            oQV = Class115.eHM((uint)Class108.Foa[int_0].BVp) * 256f;
            rQO = Class115.eHM((uint)Class108.Foa[int_0].aVS) * 256f;
            RQe = Class115.eHM((uint)Class108.Foa[int_0].HVh) * 256f;
            if (oQV > 255f) {
                oQV = 255f;
            }

            if (rQO > 255f) {
                rQO = 255f;
            }

            if (RQe > 255f) {
                RQe = 255f;
            }

            oQA.BackColor = Color.FromArgb(Convert.ToInt32(oQV), Convert.ToInt32(rQO), Convert.ToInt32(RQe));
            pQq.Image = (Image)Class117.eoy[Class108.Foa[int_0].HVE].eDB;
            jQy.Image = (Image)Class117.qor[Class108.Foa[int_0].SVD].eDB;
            EQ9.Image = (Image)Class117.toq[Class108.Foa[int_0].vVX].eDB;
            HQM.Image = (Image)Class46.Lou[Class108.Foa[int_0].btz].oDz;
            kQr.SelectedIndex = kQr.FindStringExact(Class117.eoy[Class108.Foa[int_0].HVE].rDY);
            lQc.SelectedIndex = lQc.FindStringExact(Class117.qor[Class108.Foa[int_0].SVD].rDY);
            PQx.SelectedIndex = PQx.FindStringExact(Class117.toq[Class108.Foa[int_0].vVX].rDY);
            bQk.SelectedIndex = bQk.FindStringExact(Class46.Lou[Class108.Foa[int_0].btz].aDj);
        } else {
            vnj();
        }
    }

    private void vnj() {
        VQQ.Enabled = false;
        VQQ.Text = "Data - (FAKE PLAYER)";
    }

    private void Enz(object sender, EventArgs e) {
        decimal value = UQW.Value;
        if (!0m.Equals(value)) {
            if (!1m.Equals(value)) {
                if (!2m.Equals(value)) {
                    if (!3m.Equals(value)) {
                        if (!4m.Equals(value)) {
                            if (!5m.Equals(value)) {
                                if (6m.Equals(value)) {
                                    nQ1.BackColor = Color.FromArgb(76, 27, 15);
                                }
                            } else {
                                nQ1.BackColor = Color.FromArgb(117, 46, 20);
                            }
                        } else {
                            nQ1.BackColor = Color.FromArgb(165, 85, 46);
                        }
                    } else {
                        nQ1.BackColor = Color.FromArgb(195, 125, 81);
                    }
                } else {
                    nQ1.BackColor = Color.FromArgb(219, 173, 126);
                }
            } else {
                nQ1.BackColor = Color.FromArgb(218, 182, 152);
            }
        } else {
            nQ1.BackColor = Color.FromArgb(219, 189, 168);
        }
    }

    private void oQE(object sender, EventArgs e) {
        decimal value = TQY.Value;
        if (!0m.Equals(value)) {
            if (!1m.Equals(value)) {
                if (!2m.Equals(value)) {
                    if (!3m.Equals(value)) {
                        if (!4m.Equals(value)) {
                            if (!5m.Equals(value)) {
                                if (6m.Equals(value)) {
                                    OQF.BackColor = Color.Yellow;
                                }
                            } else {
                                OQF.BackColor = Color.Black;
                            }
                        } else {
                            OQF.BackColor = Color.Turquoise;
                        }
                    } else {
                        OQF.BackColor = Color.Orange;
                    }
                } else {
                    OQF.BackColor = Color.Blue;
                }
            } else {
                OQF.BackColor = Color.Magenta;
            }
        } else {
            OQF.BackColor = Color.SaddleBrown;
        }
    }

    private void QQD(object sender, EventArgs e) {
        decimal value = RQU.Value;
        if (!0m.Equals(value)) {
            if (!1m.Equals(value)) {
                if (2m.Equals(value)) {
                    vQK.Image = Resources.octoling;
                }
            } else {
                vQK.Image = Resources.inkling_boy;
            }
        } else {
            vQK.Image = Resources.inkling_girl;
        }
    }

    private void hQX(object sender, EventArgs e) {
        DialogResult dialogResult = pQf.ShowDialog();
        if (dialogResult == DialogResult.OK) {
            oQV = (int)pQf.Color.R;
            rQO = (int)pQf.Color.G;
            RQe = (int)pQf.Color.B;
            oQA.BackColor = pQf.Color;
        }
    }

    private void sQp(object sender, EventArgs e) {
        Close();
    }

    private void KQS(object sender, EventArgs e) {
        int selectedIndex = DQn.SelectedIndex;
        vQh(selectedIndex);
    }

    private void vQh(int int_0) {
        Class108.Foa[int_0].ut4 = (int)YQ0.Value;
        Class108.Foa[int_0].Btd = pQm.Text;
        Class108.Foa[int_0].Gt5 = vQR.SelectedIndex;
        Class108.Foa[int_0].xtj = (int)XQ7.Value;
        Class108.Foa[int_0].Jts = (int)UQW.Value;
        Class108.Foa[int_0].AtZ = (int)TQY.Value;
        Class108.Foa[int_0].wta = (int)RQU.Value;
        byte[] bytes = BitConverter.GetBytes(Convert.ToSingle(oQV / 256f));
        Class108.Foa[int_0].BVp = BitConverter.ToInt32(bytes, 0);
        byte[] bytes2 = BitConverter.GetBytes(Convert.ToSingle(rQO / 256f));
        Class108.Foa[int_0].aVS = BitConverter.ToInt32(bytes2, 0);
        byte[] bytes3 = BitConverter.GetBytes(Convert.ToSingle(RQe / 256f));
        Class108.Foa[int_0].HVh = BitConverter.ToInt32(bytes3, 0);
        Class108.Foa[int_0].HVE = Class4.JDk(kQr.SelectedItem.ToString(), Class117.eoy);
        Class108.Foa[int_0].SVD = Class4.JDk(lQc.SelectedItem.ToString(), Class117.qor);
        Class108.Foa[int_0].vVX = Class4.JDk(PQx.SelectedItem.ToString(), Class117.toq);
        Class108.Foa[int_0].btz = Class22.RXl(bQk.SelectedItem.ToString(), Class46.Lou);
        DQn.Items[int_0] = pQm.Text;
    }

    private void zQl(object sender, EventArgs e) {
        byte[] emptyPlayerPlaza = Resources.emptyPlayerPlaza;
        for (int i = 0; i < Class108.Foa.Length; i++) {
            Class108.Foa[i] = new Class108.irN(emptyPlayerPlaza);
        }

        MessageBox.Show("The Plaza has been filled with fake players.");
        Jns();
    }

    private void rQG(object sender, EventArgs e) {
        int key = Class4.JDk(kQr.SelectedItem.ToString(), Class117.eoy);
        pQq.Image = (Image)Class117.eoy[key].eDB;
    }

    private void hQb(object sender, EventArgs e) {
        int key = Class4.JDk(lQc.SelectedItem.ToString(), Class117.qor);
        jQy.Image = (Image)Class117.qor[key].eDB;
    }

    private void MQv(object sender, EventArgs e) {
        int key = Class4.JDk(PQx.SelectedItem.ToString(), Class117.toq);
        EQ9.Image = (Image)Class117.toq[key].eDB;
    }

    private void zQo(object sender, EventArgs e) {
        int key = Class22.RXl(bQk.SelectedItem.ToString(), Class46.Lou);
        HQM.Image = (Image)Class46.Lou[key].oDz;
    }

    protected override void Dispose(bool disposing) {
        if (disposing && aQ8 != null) {
            aQ8.Dispose();
        }

        base.Dispose(disposing);
    }

    private void tQt() {
        DQn = new ListBox();
        VQQ = new GroupBox();
        bQk = new ComboBox();
        HQM = new PictureBox();
        PQx = new ComboBox();
        EQ9 = new PictureBox();
        lQc = new ComboBox();
        jQy = new PictureBox();
        kQr = new ComboBox();
        pQq = new PictureBox();
        oQA = new PictureBox();
        TQB = new Button();
        OQF = new PictureBox();
        rQL = new Label();
        oQJ = new Button();
        XQ7 = new NumericUpDown();
        XQP = new Label();
        jQi = new Label();
        pQm = new TextBox();
        YQ0 = new NumericUpDown();
        RQI = new Label();
        vQR = new ComboBox();
        XQC = new Label();
        vQK = new PictureBox();
        RQU = new NumericUpDown();
        TQT = new Label();
        nQ1 = new PictureBox();
        UQW = new NumericUpDown();
        KQw = new Label();
        iQN = new Label();
        TQY = new NumericUpDown();
        pQf = new ColorDialog();
        QQ6 = new Button();
        VQQ.SuspendLayout();
        ((ISupportInitialize)HQM).BeginInit();
        ((ISupportInitialize)EQ9).BeginInit();
        ((ISupportInitialize)jQy).BeginInit();
        ((ISupportInitialize)pQq).BeginInit();
        ((ISupportInitialize)oQA).BeginInit();
        ((ISupportInitialize)OQF).BeginInit();
        ((ISupportInitialize)XQ7).BeginInit();
        ((ISupportInitialize)YQ0).BeginInit();
        ((ISupportInitialize)vQK).BeginInit();
        ((ISupportInitialize)RQU).BeginInit();
        ((ISupportInitialize)nQ1).BeginInit();
        ((ISupportInitialize)UQW).BeginInit();
        ((ISupportInitialize)TQY).BeginInit();
        SuspendLayout();
        DQn.FormattingEnabled = true;
        DQn.Location = new Point(12, 12);
        DQn.Name = "InklingList";
        DQn.Size = new Size(200, 381);
        DQn.TabIndex = 0;
        DQn.SelectedIndexChanged += PnZ;
        VQQ.Controls.Add(bQk);
        VQQ.Controls.Add(HQM);
        VQQ.Controls.Add(PQx);
        VQQ.Controls.Add(EQ9);
        VQQ.Controls.Add(lQc);
        VQQ.Controls.Add(jQy);
        VQQ.Controls.Add(kQr);
        VQQ.Controls.Add(pQq);
        VQQ.Controls.Add(oQA);
        VQQ.Controls.Add(TQB);
        VQQ.Controls.Add(OQF);
        VQQ.Controls.Add(rQL);
        VQQ.Controls.Add(oQJ);
        VQQ.Controls.Add(XQ7);
        VQQ.Controls.Add(XQP);
        VQQ.Controls.Add(jQi);
        VQQ.Controls.Add(pQm);
        VQQ.Controls.Add(YQ0);
        VQQ.Controls.Add(RQI);
        VQQ.Controls.Add(vQR);
        VQQ.Controls.Add(XQC);
        VQQ.Controls.Add(vQK);
        VQQ.Controls.Add(RQU);
        VQQ.Controls.Add(TQT);
        VQQ.Controls.Add(nQ1);
        VQQ.Controls.Add(UQW);
        VQQ.Controls.Add(KQw);
        VQQ.Controls.Add(iQN);
        VQQ.Controls.Add(TQY);
        VQQ.Location = new Point(218, 12);
        VQQ.Name = "groupBox4";
        VQQ.Size = new Size(542, 381);
        VQQ.TabIndex = 13;
        VQQ.TabStop = false;
        VQQ.Text = "Data";
        bQk.DropDownStyle = ComboBoxStyle.DropDownList;
        bQk.FormattingEnabled = true;
        bQk.Location = new Point(374, 233);
        bQk.Name = "CB_Weapon";
        bQk.Size = new Size(162, 21);
        bQk.TabIndex = 56;
        bQk.SelectedIndexChanged += zQo;
        HQM.Location = new Point(415, 147);
        HQM.Name = "PB_Weapon";
        HQM.Size = new Size(80, 80);
        HQM.SizeMode = PictureBoxSizeMode.Zoom;
        HQM.TabIndex = 55;
        HQM.TabStop = false;
        PQx.DropDownStyle = ComboBoxStyle.DropDownList;
        PQx.FormattingEnabled = true;
        PQx.Location = new Point(192, 352);
        PQx.Name = "CB_GShoes";
        PQx.Size = new Size(162, 21);
        PQx.TabIndex = 54;
        PQx.SelectedIndexChanged += MQv;
        EQ9.Location = new Point(233, 266);
        EQ9.Name = "PB_GearShoes";
        EQ9.Size = new Size(80, 80);
        EQ9.SizeMode = PictureBoxSizeMode.Zoom;
        EQ9.TabIndex = 53;
        EQ9.TabStop = false;
        lQc.DropDownStyle = ComboBoxStyle.DropDownList;
        lQc.FormattingEnabled = true;
        lQc.Location = new Point(192, 233);
        lQc.Name = "CB_GClothes";
        lQc.Size = new Size(162, 21);
        lQc.TabIndex = 52;
        lQc.SelectedIndexChanged += hQb;
        jQy.Location = new Point(233, 147);
        jQy.Name = "PB_GearClothes";
        jQy.Size = new Size(80, 80);
        jQy.SizeMode = PictureBoxSizeMode.Zoom;
        jQy.TabIndex = 51;
        jQy.TabStop = false;
        kQr.DropDownStyle = ComboBoxStyle.DropDownList;
        kQr.FormattingEnabled = true;
        kQr.Location = new Point(192, 110);
        kQr.Name = "CB_GHat";
        kQr.Size = new Size(162, 21);
        kQr.TabIndex = 50;
        kQr.SelectedIndexChanged += rQG;
        pQq.Location = new Point(233, 24);
        pQq.Name = "PB_GearHat";
        pQq.Size = new Size(80, 80);
        pQq.SizeMode = PictureBoxSizeMode.Zoom;
        pQq.TabIndex = 49;
        pQq.TabStop = false;
        oQA.BackColor = Color.Gray;
        oQA.BorderStyle = BorderStyle.FixedSingle;
        oQA.Location = new Point(82, 298);
        oQA.Name = "PB_Color";
        oQA.Size = new Size(20, 20);
        oQA.SizeMode = PictureBoxSizeMode.StretchImage;
        oQA.TabIndex = 34;
        oQA.TabStop = false;
        TQB.Location = new Point(55, 323);
        TQB.Name = "BTN_SetColor";
        TQB.Size = new Size(75, 23);
        TQB.TabIndex = 33;
        TQB.Text = "Set Color";
        TQB.UseVisualStyleBackColor = true;
        TQB.Click += hQX;
        OQF.BackColor = Color.FromArgb(219, 189, 168);
        OQF.BorderStyle = BorderStyle.FixedSingle;
        OQF.Location = new Point(129, 207);
        OQF.Name = "PB_plz_eye";
        OQF.Size = new Size(47, 27);
        OQF.SizeMode = PictureBoxSizeMode.StretchImage;
        OQF.TabIndex = 5;
        OQF.TabStop = false;
        rQL.AutoSize = true;
        rQL.Location = new Point(74, 280);
        rQL.Name = "label6";
        rQL.Size = new Size(37, 13);
        rQL.TabIndex = 30;
        rQL.Text = "Color :";
        oQJ.Location = new Point(55, 353);
        oQJ.Name = "BTN_SavePlaza";
        oQJ.Size = new Size(75, 23);
        oQJ.TabIndex = 28;
        oQJ.Text = "Save";
        oQJ.UseVisualStyleBackColor = true;
        oQJ.Click += KQS;
        XQ7.Location = new Point(69, 69);
        XQ7.Maximum = new decimal(new int[4] { 999999999, 0, 0, 0 });
        XQ7.Name = "NUD_plz_inked";
        XQ7.Size = new Size(60, 20);
        XQ7.TabIndex = 27;
        XQP.AutoSize = true;
        XQP.Location = new Point(6, 71);
        XQP.Name = "label1";
        XQP.Size = new Size(61, 13);
        XQP.TabIndex = 26;
        XQP.Text = "Turf inked :";
        jQi.AutoSize = true;
        jQi.Location = new Point(14, 96);
        jQi.Name = "label2";
        jQi.Size = new Size(41, 13);
        jQi.TabIndex = 25;
        jQi.Text = "Name :";
        pQm.Location = new Point(10, 111);
        pQm.MaxLength = 16;
        pQm.Name = "TB_plz_name";
        pQm.Size = new Size(171, 20);
        pQm.TabIndex = 24;
        YQ0.Location = new Point(89, 18);
        YQ0.Maximum = new decimal(new int[4] { 999, 0, 0, 0 });
        YQ0.Name = "NUD_plz_lvl";
        YQ0.Size = new Size(40, 20);
        YQ0.TabIndex = 23;
        RQI.AutoSize = true;
        RQI.Font = new Font("Project Paintball", 17.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
        RQI.ForeColor = Color.Lime;
        RQI.Location = new Point(18, 16);
        RQI.Name = "label8";
        RQI.Size = new Size(70, 25);
        RQI.TabIndex = 22;
        RQI.Text = "Level";
        vQR.DropDownStyle = ComboBoxStyle.DropDownList;
        vQR.FormattingEnabled = true;
        vQR.Items.AddRange(new object[12] { "C-", "xOV.xOy", "C+", "B-", "HO1.rOe", "B+", "A-", "aOK.tOh", "A+", "S-", "rOL.VOd", "S+" });
        vQR.Location = new Point(89, 43);
        vQR.Name = "CB_plz_rank";
        vQR.Size = new Size(40, 21);
        vQR.TabIndex = 21;
        XQC.AutoSize = true;
        XQC.Font = new Font("Project Paintball", 17.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
        XQC.ForeColor = Color.FromArgb(255, 100, 0);
        XQC.Location = new Point(18, 40);
        XQC.Name = "label7";
        XQC.Size = new Size(69, 25);
        XQC.TabIndex = 20;
        XQC.Text = "Rank";
        vQK.BorderStyle = BorderStyle.FixedSingle;
        vQK.Image = Resources.inkling_girl;
        vQK.Location = new Point(5, 143);
        vQK.Name = "PB_plz_gender";
        vQK.Size = new Size(84, 132);
        vQK.SizeMode = PictureBoxSizeMode.Zoom;
        vQK.TabIndex = 0;
        vQK.TabStop = false;
        RQU.Location = new Point(138, 239);
        RQU.Maximum = new decimal(new int[4] { 2, 0, 0, 0 });
        RQU.Name = "NUD_plz_gender";
        RQU.Size = new Size(32, 20);
        RQU.TabIndex = 1;
        RQU.ValueChanged += QQD;
        TQT.AutoSize = true;
        TQT.Location = new Point(91, 241);
        TQT.Name = "label5";
        TQT.Size = new Size(48, 13);
        TQT.TabIndex = 2;
        TQT.Text = "Gender :";
        nQ1.BackColor = Color.SaddleBrown;
        nQ1.BorderStyle = BorderStyle.FixedSingle;
        nQ1.Location = new Point(129, 162);
        nQ1.Name = "PB_plz_skin";
        nQ1.Size = new Size(47, 29);
        nQ1.SizeMode = PictureBoxSizeMode.StretchImage;
        nQ1.TabIndex = 8;
        nQ1.TabStop = false;
        UQW.Location = new Point(94, 162);
        UQW.Maximum = new decimal(new int[4] { 6, 0, 0, 0 });
        UQW.Name = "NUD_plz_skin";
        UQW.Size = new Size(32, 20);
        UQW.TabIndex = 3;
        UQW.ValueChanged += Enz;
        KQw.AutoSize = true;
        KQw.Location = new Point(106, 191);
        KQw.Name = "label4";
        KQw.Size = new Size(63, 13);
        KQw.TabIndex = 7;
        KQw.Text = "Eye colour :";
        iQN.AutoSize = true;
        iQN.Location = new Point(108, 146);
        iQN.Name = "label3";
        iQN.Size = new Size(58, 13);
        iQN.TabIndex = 4;
        iQN.Text = "Skin tone :";
        TQY.Location = new Point(94, 207);
        TQY.Maximum = new decimal(new int[4] { 6, 0, 0, 0 });
        TQY.Name = "NUD_plz_eye";
        TQY.Size = new Size(32, 20);
        TQY.TabIndex = 6;
        TQY.ValueChanged += oQE;
        QQ6.Location = new Point(613, 399);
        QQ6.Name = "BTN_fillPlazaF";
        QQ6.Size = new Size(147, 23);
        QQ6.TabIndex = 16;
        QQ6.Text = "Fill Plaza with Fake Players";
        QQ6.UseVisualStyleBackColor = true;
        QQ6.Click += zQl;
        base.AutoScaleDimensions = new SizeF(6f, 13f);
        base.AutoScaleMode = AutoScaleMode.Font;
        base.ClientSize = new Size(772, 424);
        base.Controls.Add(QQ6);
        base.Controls.Add(VQQ);
        base.Controls.Add(DQn);
        base.Name = "PlazaSplat1";
        base.ShowIcon = false;
        base.StartPosition = FormStartPosition.CenterScreen;
        Text = "SplatHeX - Splatoon 1 - Plaza Editor";
        VQQ.ResumeLayout(performLayout: false);
        VQQ.PerformLayout();
        ((ISupportInitialize)HQM).EndInit();
        ((ISupportInitialize)EQ9).EndInit();
        ((ISupportInitialize)jQy).EndInit();
        ((ISupportInitialize)pQq).EndInit();
        ((ISupportInitialize)oQA).EndInit();
        ((ISupportInitialize)OQF).EndInit();
        ((ISupportInitialize)XQ7).EndInit();
        ((ISupportInitialize)YQ0).EndInit();
        ((ISupportInitialize)vQK).EndInit();
        ((ISupportInitialize)RQU).EndInit();
        ((ISupportInitialize)nQ1).EndInit();
        ((ISupportInitialize)UQW).EndInit();
        ((ISupportInitialize)TQY).EndInit();
        ResumeLayout(performLayout: false);
    }
}