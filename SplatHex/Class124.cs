using System;
using System.Drawing;
using System.Windows.Forms;

namespace SplatHex;
public class Class124 : Form {
    public int A7x;
    public string f79;
    public string o7c;
    public string O7y;
    private IDisposable R7r;
    private GroupBox e7q;
    private Label w7k;
    private Label f7M;
    private CheckBox P7u;
    private NumericUpDown G7g;
    private Button m72;
    private Class35 f73;
    private Label u7d;
    private DateTimePicker Q7H;
    private TabControl u74;
    private TabPage o75;
    private Button k7s;
    private PictureBox f7Z;
    private GroupBox F7a;
    private Button c7j;
    private Button v7z;
    private PictureBox CPE;
    private Button APD;
    private Button DPX;
    private Label tPp;
    private Label mPS;
    public Class124() {
        X76();
        q71();
    }

    private void q71() {
        for (int i = 0; i < Class108.Vo4.Length; i++) {
            Button button = new Button();
            if (Class108.Vo4[i].btx != -1 && Class46.Lou.ContainsKey(Class108.Vo4[i].btx)) {
                button.BackgroundImage = (Image)Class46.Lou[Class108.Vo4[i].btx].oDz;
                button.AccessibleDescription = Class46.Lou[Class108.Vo4[i].btx].aDj;
                button.BackgroundImageLayout = ImageLayout.Zoom;
                button.Size = new Size(80, 80);
                button.Name = "weapon" + i;
                f73.Controls.Add(button);
                button.Click += s7W;
                if (Class108.Vo4[i].btx == Class108.io2.CtG) {
                    button.BackColor = Color.Red;
                    f73.Controls.SetChildIndex(button, 0);
                    f79 = button.Name;
                }

                if (!Class22.vXO(Class108.Vo4[i].btx)) {
                    button.Image = Resources.warning;
                    button.ImageAlign = ContentAlignment.TopRight;
                }
            }
        }
    }

    private void s7W(object sender, EventArgs e) {
        string name = ((Button)sender).Name;
        name = name.Remove(0, 6);
        int num = int.Parse(name);
        f7Z.BackgroundImage = ((Button)sender).BackgroundImage;
        e7q.Text = ((Button)sender).AccessibleDescription;
        d7w(num);
        if (((Button)sender).BackColor == Color.Red) {
            k7s.Enabled = false;
            c7j.Enabled = false;
        } else {
            k7s.Enabled = true;
            c7j.Enabled = true;
        }

        if (((Button)sender).Image != null) {
            CPE.Visible = true;
            O7y = "Warning: Invalid level for this weapon.";
        } else {
            CPE.Visible = false;
        }

        APD.BackgroundImage = Class38.vnl(Class46.Lou[Class108.Vo4[num].btx].WXE);
        if (Class46.Lou[Class108.Vo4[num].btx].DXD == 4) {
            DPX.BackgroundImage = Class38.Cnb(Class46.Lou[Class108.Vo4[num].btx].WXE);
        } else {
            DPX.BackgroundImage = Class38.TnG(Class46.Lou[Class108.Vo4[num].btx].DXD);
        }

        o7c = ((Button)sender).Name;
    }

    private void d7w(int int_0) {
        e7q.Visible = true;
        F7a.Enabled = true;
        G7g.Value = Class108.Vo4[int_0].Ttr;
        P7u.Checked = Class108.Vo4[int_0].itk == 1;
        Q7H.Value = Class115.LHu(Class108.Vo4[int_0].atq);
        A7x = int_0;
    }

    private void n7N(object sender, EventArgs e) {
        Class108.Vo4[A7x].Ttr = (int)G7g.Value;
        Class108.Vo4[A7x].itk = (P7u.Checked ? 1 : 0);
        Class108.Vo4[A7x].atq = Class115.DHg(Q7H);
    }

    private void u7Y(object sender, EventArgs e) {
        base.Controls.Find(f79, searchAllChildren: true)[0].BackColor = Color.Transparent;
        base.Controls.Find(o7c, searchAllChildren: true)[0].BackColor = Color.Red;
        Class108.io2.CtG = Class22.RXl(e7q.Text, Class46.Lou);
        f79 = o7c;
        F7a.Enabled = false;
    }

    private void p7B(object sender, EventArgs e) {
        Class8 zrr = new Class8();
        zrr.ShowDialog();
        if (Class8.Gb5 != -1) {
            Button button = new Button();
            int int_ = Class22.qXt(Class108.Vo4);
            Class22.iXG(int_, Class8.Gb5, Class115.vHZ(), 1, Class46.Lou[Class8.Gb5].WXE, Class46.Lou[Class8.Gb5].DXD);
            button.BackgroundImage = (Image)Class46.Lou[Class8.Gb5].oDz;
            button.AccessibleDescription = Class46.Lou[Class8.Gb5].aDj;
            button.BackgroundImageLayout = ImageLayout.Zoom;
            button.Size = new Size(80, 80);
            button.Name = "weapon" + int_;
            f73.Controls.Add(button);
            button.Click += s7W;
            if (!Class22.vXO(Class8.Gb5)) {
                button.Image = Resources.warning;
                button.ImageAlign = ContentAlignment.TopRight;
            }

            button.PerformClick();
        }
    }

    private void x7A(object sender, EventArgs e) {
        DialogResult dialogResult = MessageBox.Show("Do you really want to remove this weapon ?", "Remove Weapon?", MessageBoxButtons.YesNo);
        if (dialogResult == DialogResult.Yes) {
            Class22.NXn(A7x);
            f73.Controls.Remove(base.Controls.Find(o7c, searchAllChildren: true)[0]);
            F7a.Enabled = false;
        }
    }

    private void z7f(object sender, EventArgs e) {
        MessageBox.Show(O7y);
    }

    protected override void Dispose(bool disposing) {
        if (disposing && R7r != null) {
            R7r.Dispose();
        }

        base.Dispose(disposing);
    }

    private void X76() {
        e7q = new GroupBox();
        CPE = new PictureBox();
        F7a = new GroupBox();
        v7z = new Button();
        c7j = new Button();
        k7s = new Button();
        m72 = new Button();
        f7Z = new PictureBox();
        u7d = new Label();
        Q7H = new DateTimePicker();
        w7k = new Label();
        f7M = new Label();
        P7u = new CheckBox();
        G7g = new NumericUpDown();
        u74 = new TabControl();
        o75 = new TabPage();
        APD = new Button();
        DPX = new Button();
        tPp = new Label();
        mPS = new Label();
        f73 = new Class35();
        e7q.SuspendLayout();
        ((ISupportInitialize)CPE).BeginInit();
        F7a.SuspendLayout();
        ((ISupportInitialize)f7Z).BeginInit();
        ((ISupportInitialize)G7g).BeginInit();
        u74.SuspendLayout();
        o75.SuspendLayout();
        SuspendLayout();
        e7q.Controls.Add(mPS);
        e7q.Controls.Add(tPp);
        e7q.Controls.Add(APD);
        e7q.Controls.Add(DPX);
        e7q.Controls.Add(CPE);
        e7q.Controls.Add(F7a);
        e7q.Controls.Add(f7Z);
        e7q.Controls.Add(u7d);
        e7q.Controls.Add(Q7H);
        e7q.Controls.Add(w7k);
        e7q.Controls.Add(f7M);
        e7q.Controls.Add(P7u);
        e7q.Controls.Add(G7g);
        e7q.Location = new Point(404, 3);
        e7q.Name = "GB_weaponEdit";
        e7q.Size = new Size(291, 464);
        e7q.TabIndex = 3;
        e7q.TabStop = false;
        e7q.Text = "Weapon Name";
        e7q.Visible = false;
        CPE.BackgroundImage = Resources.warning;
        CPE.Location = new Point(191, 32);
        CPE.Name = "PB_Warning";
        CPE.Size = new Size(20, 18);
        CPE.TabIndex = 47;
        CPE.TabStop = false;
        CPE.Click += z7f;
        F7a.Controls.Add(v7z);
        F7a.Controls.Add(c7j);
        F7a.Controls.Add(k7s);
        F7a.Controls.Add(m72);
        F7a.Dock = DockStyle.Bottom;
        F7a.Location = new Point(3, 376);
        F7a.Name = "GB_WeaponAction";
        F7a.Size = new Size(285, 85);
        F7a.TabIndex = 45;
        F7a.TabStop = false;
        F7a.Text = "Action";
        v7z.Location = new Point(98, 56);
        v7z.Name = "B_AddWeap";
        v7z.Size = new Size(85, 23);
        v7z.TabIndex = 47;
        v7z.Text = "Add Weapon";
        v7z.UseVisualStyleBackColor = true;
        v7z.Click += p7B;
        c7j.Location = new Point(188, 19);
        c7j.Name = "B_DelWeap";
        c7j.Size = new Size(90, 23);
        c7j.TabIndex = 45;
        c7j.Text = "Delete Weapon";
        c7j.UseVisualStyleBackColor = true;
        c7j.Click += x7A;
        k7s.Location = new Point(98, 19);
        k7s.Name = "B_WearWeapon";
        k7s.Size = new Size(85, 23);
        k7s.TabIndex = 43;
        k7s.Text = "Wear Weapon";
        k7s.UseVisualStyleBackColor = true;
        k7s.Click += u7Y;
        m72.Location = new Point(7, 19);
        m72.Name = "B_SaveWeap";
        m72.Size = new Size(84, 23);
        m72.TabIndex = 16;
        m72.Text = "Save Weapon";
        m72.UseVisualStyleBackColor = true;
        m72.Click += n7N;
        f7Z.BackgroundImageLayout = ImageLayout.Zoom;
        f7Z.Location = new Point(115, 32);
        f7Z.Name = "PB_Weapon";
        f7Z.Size = new Size(70, 70);
        f7Z.TabIndex = 44;
        f7Z.TabStop = false;
        u7d.AutoSize = true;
        u7d.Location = new Point(21, 228);
        u7d.Name = "label1";
        u7d.Size = new Size(61, 13);
        u7d.TabIndex = 42;
        u7d.Text = "Last Usage";
        Q7H.CustomFormat = "MM/dd/yyyy hh:mm:ss";
        Q7H.Format = DateTimePickerFormat.Custom;
        Q7H.Location = new Point(131, 224);
        Q7H.MaxDate = new DateTime(9998, 1, 1, 0, 0, 0, 0);
        Q7H.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
        Q7H.Name = "WeaponTimeStamp";
        Q7H.Size = new Size(141, 20);
        Q7H.TabIndex = 41;
        Q7H.Value = new DateTime(2000, 1, 1, 0, 0, 0, 0);
        w7k.AutoSize = true;
        w7k.Location = new Point(36, 149);
        w7k.Name = "label23";
        w7k.Size = new Size(68, 13);
        w7k.TabIndex = 12;
        w7k.Text = "Turfed Inked";
        f7M.AutoSize = true;
        f7M.Location = new Point(44, 189);
        f7M.Name = "label39";
        f7M.Size = new Size(29, 13);
        f7M.TabIndex = 13;
        f7M.Text = "New";
        P7u.AutoSize = true;
        P7u.Location = new Point(187, 188);
        P7u.Name = "newBoxWeapon";
        P7u.Size = new Size(15, 14);
        P7u.TabIndex = 14;
        P7u.UseVisualStyleBackColor = true;
        G7g.Location = new Point(166, 147);
        G7g.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
        G7g.Name = "weaponTurfInked";
        G7g.Size = new Size(60, 20);
        G7g.TabIndex = 15;
        u74.Controls.Add(o75);
        u74.Location = new Point(3, 3);
        u74.Name = "tabControl1";
        u74.SelectedIndex = 0;
        u74.Size = new Size(395, 455);
        u74.TabIndex = 4;
        o75.Controls.Add(f73);
        o75.Location = new Point(4, 22);
        o75.Name = "tabPage1";
        o75.Padding = new Padding(3);
        o75.Size = new Size(387, 429);
        o75.TabIndex = 0;
        o75.Text = "Weapons";
        o75.UseVisualStyleBackColor = true;
        APD.BackColor = Color.White;
        APD.BackgroundImageLayout = ImageLayout.Zoom;
        APD.Location = new Point(55, 277);
        APD.Name = "PB_Sub";
        APD.Size = new Size(64, 64);
        APD.TabIndex = 48;
        APD.UseVisualStyleBackColor = false;
        DPX.BackColor = Color.White;
        DPX.BackgroundImageLayout = ImageLayout.Zoom;
        DPX.Location = new Point(202, 277);
        DPX.Name = "PB_Spec";
        DPX.Size = new Size(64, 64);
        DPX.TabIndex = 49;
        DPX.UseVisualStyleBackColor = false;
        tPp.AutoSize = true;
        tPp.Location = new Point(154, 303);
        tPp.Name = "label2";
        tPp.Size = new Size(42, 13);
        tPp.TabIndex = 50;
        tPp.Text = "Special";
        mPS.AutoSize = true;
        mPS.Location = new Point(21, 303);
        mPS.Name = "label3";
        mPS.Size = new Size(26, 13);
        mPS.TabIndex = 51;
        mPS.Text = "Sub";
        f73.AutoScroll = true;
        f73.Dock = DockStyle.Fill;
        f73.Location = new Point(3, 3);
        f73.Name = "weaponPanel";
        f73.Size = new Size(381, 423);
        f73.TabIndex = 2;
        base.AutoScaleDimensions = new SizeF(6f, 13f);
        base.AutoScaleMode = AutoScaleMode.Font;
        base.ClientSize = new Size(707, 467);
        base.Controls.Add(u74);
        base.Controls.Add(e7q);
        base.Name = "WeaponSplat1";
        RightToLeft = RightToLeft.No;
        base.ShowIcon = false;
        base.StartPosition = FormStartPosition.CenterScreen;
        Text = "SplatHeX - Splatoon 1 - Weapons Editor";
        e7q.ResumeLayout(performLayout: false);
        e7q.PerformLayout();
        ((ISupportInitialize)CPE).EndInit();
        F7a.ResumeLayout(performLayout: false);
        ((ISupportInitialize)f7Z).EndInit();
        ((ISupportInitialize)G7g).EndInit();
        u74.ResumeLayout(performLayout: false);
        o75.ResumeLayout(performLayout: false);
        ResumeLayout(performLayout: false);
    }
}