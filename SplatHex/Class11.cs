using System;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SplatHex;
public class Class11 : Form {
    public int yCH;
    public string oC4;
    public string pC5;
    public string UCs;
    private IDisposable tCZ;
    private TabControl tCa;
    private TabPage mCj;
    private Class35 tCz;
    private GroupBox tKE;
    private GroupBox bKD;
    private Button YKX;
    private Button AKp;
    private Button GKS;
    private Button dKh;
    private PictureBox BKl;
    private Label PKG;
    private DateTimePicker aKb;
    private Label IKv;
    private Label FKo;
    private CheckBox bKt;
    private NumericUpDown HKV;
    private PictureBox lKO;
    private Label AKe;
    private Label AK8;
    private Button wKn;
    private Button OKQ;
    private NumericUpDown dKF;
    private Label nKL;
    public Class11() {
        lCd();
        lKO.Visible = false;
        uCr();
    }

    private void uCr() {
        for (int i = 0; i < Class26.RXd.Length; i++) {
            Button button = new Button();
            if (Class26.RXd[i].ISk != -1 && Class122.PlD.ContainsKey(Class26.RXd[i].ISk)) {
                button.BackgroundImage = (Image)Class122.PlD[Class26.RXd[i].ISk].oDz;
                button.AccessibleDescription = Class122.PlD[Class26.RXd[i].ISk].aDj;
                button.BackgroundImageLayout = ImageLayout.Zoom;
                button.Size = new Size(80, 80);
                button.Name = "weapon" + i;
                tCz.Controls.Add(button);
                button.Click += pCq;
                if (Class26.RXd[i].ISk == Class26.QXu.Qpb) {
                    button.BackColor = Color.Red;
                    tCz.Controls.SetChildIndex(button, 0);
                    oC4 = button.Name;
                }

                if (!Class22.JXe(Class26.RXd[i].ISk) || !Class22.PX8(i)) {
                    button.Image = Resources.warning;
                    button.ImageAlign = ContentAlignment.TopRight;
                }
            }
        }
    }

    private void pCq(object sender, EventArgs e) {
        string name = ((Button)sender).Name;
        name = name.Remove(0, 6);
        int num = int.Parse(name);
        UCs = null;
        BKl.BackgroundImage = ((Button)sender).BackgroundImage;
        tKE.Text = ((Button)sender).AccessibleDescription;
        iCk(num);
        if (((Button)sender).BackColor == Color.Red) {
            GKS.Enabled = false;
            AKp.Enabled = false;
        } else {
            GKS.Enabled = true;
            AKp.Enabled = true;
        }

        if (((Button)sender).Image != null) {
            StringBuilder stringBuilder = new StringBuilder();
            lKO.Visible = true;
            if (!Class22.JXe(Class26.RXd[num].ISk)) {
                stringBuilder.Append("Warning: Invalid level for this weapon.").AppendLine();
            }

            if (!Class22.PX8(num)) {
                stringBuilder.Append("Warning: Invalid Sub / Special.").AppendLine();
            }

            UCs = stringBuilder.ToString();
        } else {
            lKO.Visible = false;
        }

        wKn.BackgroundImage = Class38.Mnv(Class122.PlD[Class26.RXd[num].ISk].WXE);
        OKQ.BackgroundImage = Class38.dno(Class122.PlD[Class26.RXd[num].ISk].DXD);
        pC5 = ((Button)sender).Name;
    }

    private void iCk(int int_0) {
        tKE.Visible = true;
        bKD.Enabled = true;
        HKV.Value = Class26.RXd[int_0].ISg;
        bKt.Checked = Class26.RXd[int_0].NSH == 0;
        aKb.Value = Class115.LHu(Class26.RXd[int_0].wS2);
        dKF.Value = (decimal)((double)Class26.RXd[int_0].oS3 / 2.0);
        yCH = int_0;
    }

    private void tCM(object sender, EventArgs e) {
        base.Controls.Find(oC4, searchAllChildren: true)[0].BackColor = Color.Transparent;
        base.Controls.Find(pC5, searchAllChildren: true)[0].BackColor = Color.Red;
        Class26.QXu.Qpb = Class22.RXl(tKE.Text, Class122.PlD);
        oC4 = pC5;
        bKD.Enabled = false;
    }

    private void hCu(object sender, EventArgs e) {
        Class26.RXd[yCH].ISg = (int)HKV.Value;
        Class26.RXd[yCH].NSH = ((!bKt.Checked) ? 1 : 0);
        Class26.RXd[yCH].wS2 = Class115.DHg(aKb);
    }

    private void hCg(object sender, EventArgs e) {
        DialogResult dialogResult = MessageBox.Show("Do you really want to remove this weapon ?", "Remove Weapon?", MessageBoxButtons.YesNo);
        if (dialogResult == DialogResult.Yes) {
            Class22.cXQ(yCH);
            tCz.Controls.Remove(base.Controls.Find(pC5, searchAllChildren: true)[0]);
            bKD.Enabled = false;
        }
    }

    private void jC2(object sender, EventArgs e) {
        Class42 irB = new Class42();
        irB.ShowDialog();
        if (Class42.Uvl != -1) {
            Button button = new Button();
            int int_ = Class22.YXV(Class26.RXd);
            Class22.JXb(int_, Class42.Uvl, Class115.vHZ(), 0, Class122.PlD[Class42.Uvl].WXE, Class122.PlD[Class42.Uvl].DXD);
            button.BackgroundImage = (Image)Class122.PlD[Class42.Uvl].oDz;
            button.AccessibleDescription = Class122.PlD[Class42.Uvl].aDj;
            button.BackgroundImageLayout = ImageLayout.Zoom;
            button.Size = new Size(80, 80);
            button.Name = "weapon" + int_;
            tCz.Controls.Add(button);
            button.Click += pCq;
            if (!Class22.JXe(Class42.Uvl)) {
                button.Image = Resources.warning;
                button.ImageAlign = ContentAlignment.TopRight;
            }

            button.PerformClick();
        }
    }

    private void kC3(object sender, EventArgs e) {
        MessageBox.Show(UCs);
    }

    protected override void Dispose(bool disposing) {
        if (disposing && tCZ != null) {
            tCZ.Dispose();
        }

        base.Dispose(disposing);
    }

    private void lCd() {
        tCa = new TabControl();
        mCj = new TabPage();
        tCz = new Class35();
        tKE = new GroupBox();
        AKe = new Label();
        AK8 = new Label();
        wKn = new Button();
        OKQ = new Button();
        lKO = new PictureBox();
        bKD = new GroupBox();
        YKX = new Button();
        AKp = new Button();
        GKS = new Button();
        dKh = new Button();
        BKl = new PictureBox();
        PKG = new Label();
        aKb = new DateTimePicker();
        IKv = new Label();
        FKo = new Label();
        bKt = new CheckBox();
        HKV = new NumericUpDown();
        nKL = new Label();
        dKF = new NumericUpDown();
        tCa.SuspendLayout();
        mCj.SuspendLayout();
        tKE.SuspendLayout();
        ((ISupportInitialize)lKO).BeginInit();
        bKD.SuspendLayout();
        ((ISupportInitialize)BKl).BeginInit();
        ((ISupportInitialize)HKV).BeginInit();
        ((ISupportInitialize)dKF).BeginInit();
        SuspendLayout();
        tCa.Controls.Add(mCj);
        tCa.Location = new Point(3, 3);
        tCa.Name = "tabControl1";
        tCa.SelectedIndex = 0;
        tCa.Size = new Size(395, 455);
        tCa.TabIndex = 6;
        mCj.Controls.Add(tCz);
        mCj.Location = new Point(4, 22);
        mCj.Name = "tabPage1";
        mCj.Padding = new Padding(3);
        mCj.Size = new Size(387, 429);
        mCj.TabIndex = 0;
        mCj.Text = "Weapons";
        mCj.UseVisualStyleBackColor = true;
        tCz.AutoScroll = true;
        tCz.Dock = DockStyle.Fill;
        tCz.Location = new Point(3, 3);
        tCz.Name = "weaponPanel";
        tCz.Size = new Size(381, 423);
        tCz.TabIndex = 2;
        tKE.Controls.Add(dKF);
        tKE.Controls.Add(nKL);
        tKE.Controls.Add(AKe);
        tKE.Controls.Add(AK8);
        tKE.Controls.Add(wKn);
        tKE.Controls.Add(OKQ);
        tKE.Controls.Add(lKO);
        tKE.Controls.Add(bKD);
        tKE.Controls.Add(BKl);
        tKE.Controls.Add(PKG);
        tKE.Controls.Add(aKb);
        tKE.Controls.Add(IKv);
        tKE.Controls.Add(FKo);
        tKE.Controls.Add(bKt);
        tKE.Controls.Add(HKV);
        tKE.Location = new Point(404, 3);
        tKE.Name = "GB_weaponEdit";
        tKE.Size = new Size(291, 464);
        tKE.TabIndex = 5;
        tKE.TabStop = false;
        tKE.Text = "Weapon Name";
        tKE.Visible = false;
        AKe.AutoSize = true;
        AKe.Location = new Point(21, 303);
        AKe.Name = "label3";
        AKe.Size = new Size(26, 13);
        AKe.TabIndex = 55;
        AKe.Text = "Sub";
        AK8.AutoSize = true;
        AK8.Location = new Point(154, 303);
        AK8.Name = "label2";
        AK8.Size = new Size(42, 13);
        AK8.TabIndex = 54;
        AK8.Text = "Special";
        wKn.BackColor = Color.White;
        wKn.BackgroundImageLayout = ImageLayout.Zoom;
        wKn.Location = new Point(55, 277);
        wKn.Name = "PB_Sub";
        wKn.Size = new Size(64, 64);
        wKn.TabIndex = 52;
        wKn.UseVisualStyleBackColor = false;
        OKQ.BackColor = Color.White;
        OKQ.BackgroundImageLayout = ImageLayout.Zoom;
        OKQ.Location = new Point(202, 277);
        OKQ.Name = "PB_Spec";
        OKQ.Size = new Size(64, 64);
        OKQ.TabIndex = 53;
        OKQ.UseVisualStyleBackColor = false;
        lKO.BackgroundImage = Resources.warning;
        lKO.Location = new Point(191, 32);
        lKO.Name = "PB_Warning";
        lKO.Size = new Size(20, 18);
        lKO.TabIndex = 46;
        lKO.TabStop = false;
        lKO.Click += kC3;
        bKD.Controls.Add(YKX);
        bKD.Controls.Add(AKp);
        bKD.Controls.Add(GKS);
        bKD.Controls.Add(dKh);
        bKD.Dock = DockStyle.Bottom;
        bKD.Location = new Point(3, 376);
        bKD.Name = "GB_WeaponAction";
        bKD.Size = new Size(285, 85);
        bKD.TabIndex = 45;
        bKD.TabStop = false;
        bKD.Text = "Action";
        YKX.Location = new Point(98, 56);
        YKX.Name = "B_AddWeap";
        YKX.Size = new Size(85, 23);
        YKX.TabIndex = 47;
        YKX.Text = "Add Weapon";
        YKX.UseVisualStyleBackColor = true;
        YKX.Click += jC2;
        AKp.Location = new Point(188, 19);
        AKp.Name = "B_DelWeap";
        AKp.Size = new Size(90, 23);
        AKp.TabIndex = 45;
        AKp.Text = "Delete Weapon";
        AKp.UseVisualStyleBackColor = true;
        AKp.Click += hCg;
        GKS.Location = new Point(98, 19);
        GKS.Name = "B_WearWeapon";
        GKS.Size = new Size(85, 23);
        GKS.TabIndex = 43;
        GKS.Text = "Wear Weapon";
        GKS.UseVisualStyleBackColor = true;
        GKS.Click += tCM;
        dKh.Location = new Point(7, 19);
        dKh.Name = "B_SaveWeap";
        dKh.Size = new Size(84, 23);
        dKh.TabIndex = 16;
        dKh.Text = "Save Weapon";
        dKh.UseVisualStyleBackColor = true;
        dKh.Click += hCu;
        BKl.BackgroundImageLayout = ImageLayout.Zoom;
        BKl.Location = new Point(115, 32);
        BKl.Name = "PB_Weapon";
        BKl.Size = new Size(70, 70);
        BKl.TabIndex = 44;
        BKl.TabStop = false;
        PKG.AutoSize = true;
        PKG.Location = new Point(36, 214);
        PKG.Name = "label1";
        PKG.Size = new Size(61, 13);
        PKG.TabIndex = 42;
        PKG.Text = "Last Usage";
        aKb.CustomFormat = "MM/dd/yyyy hh:mm:ss";
        aKb.Format = DateTimePickerFormat.Custom;
        aKb.Location = new Point(146, 208);
        aKb.MaxDate = new DateTime(9998, 1, 1, 0, 0, 0, 0);
        aKb.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
        aKb.Name = "WeaponTimeStamp";
        aKb.Size = new Size(141, 20);
        aKb.TabIndex = 41;
        aKb.Value = new DateTime(2000, 1, 1, 0, 0, 0, 0);
        IKv.AutoSize = true;
        IKv.Location = new Point(36, 149);
        IKv.Name = "label23";
        IKv.Size = new Size(68, 13);
        IKv.TabIndex = 12;
        IKv.Text = "Turfed Inked";
        FKo.AutoSize = true;
        FKo.Location = new Point(36, 183);
        FKo.Name = "label39";
        FKo.Size = new Size(29, 13);
        FKo.TabIndex = 13;
        FKo.Text = "New";
        bKt.AutoSize = true;
        bKt.Location = new Point(195, 182);
        bKt.Name = "newBoxWeapon";
        bKt.Size = new Size(15, 14);
        bKt.TabIndex = 14;
        bKt.UseVisualStyleBackColor = true;
        HKV.Location = new Point(166, 147);
        HKV.Maximum = new decimal(new int[4] { 9999999, 0, 0, 0 });
        HKV.Name = "weaponTurfInked";
        HKV.Size = new Size(62, 20);
        HKV.TabIndex = 15;
        nKL.AutoSize = true;
        nKL.Location = new Point(36, 240);
        nKL.Name = "label4";
        nKL.Size = new Size(55, 13);
        nKL.TabIndex = 56;
        nKL.Text = "Freshness";
        dKF.DecimalPlaces = 1;
        dKF.Increment = new decimal(new int[4] { 5, 0, 0, 65536 });
        dKF.Location = new Point(146, 234);
        dKF.Maximum = new decimal(new int[4] { 99, 0, 0, 0 });
        dKF.Name = "NUD_Freshness";
        dKF.ReadOnly = true;
        dKF.Size = new Size(62, 20);
        dKF.TabIndex = 57;
        base.AutoScaleDimensions = new SizeF(6f, 13f);
        base.AutoScaleMode = AutoScaleMode.Font;
        base.ClientSize = new Size(707, 467);
        base.Controls.Add(tCa);
        base.Controls.Add(tKE);
        base.Name = "WeaponSplat2";
        base.ShowIcon = false;
        base.StartPosition = FormStartPosition.CenterScreen;
        Text = "SplatHeX - Splatoon 2 - Weapons Editor";
        tCa.ResumeLayout(performLayout: false);
        mCj.ResumeLayout(performLayout: false);
        tKE.ResumeLayout(performLayout: false);
        tKE.PerformLayout();
        ((ISupportInitialize)lKO).EndInit();
        bKD.ResumeLayout(performLayout: false);
        ((ISupportInitialize)BKl).EndInit();
        ((ISupportInitialize)HKV).EndInit();
        ((ISupportInitialize)dKF).EndInit();
        ResumeLayout(performLayout: false);
    }
}