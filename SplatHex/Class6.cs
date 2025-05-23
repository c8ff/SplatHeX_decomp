using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace SplatHex;
public class Class6 : Form {
    private Class128 eDk9;
    private Container QDkc;
    private CheckBox SDky;
    private CheckBox kDkr;
    private Button FDkq;
    private NumericUpDown LDkk;
    private Label JDkM;
    private GroupBox ADku;
    private Label yDkg;
    private ToolTip VDk2;
    private ComboBox FDk3;
    private Label ODkd;

    public Class6(Class128 mbz_0) {
        zDkx();
        eDk9 = mbz_0;
    }

    private void DDkf(object sender, EventArgs e) {
        if (SDky.Checked) {
            Class1.smethod_0().method_7(bool_0: true);
        } else {
            Class1.smethod_0().method_7(bool_0: false);
        }

        if (kDkr.Checked) {
            Class1.smethod_0().a(bool_0: true);
        } else {
            Class1.smethod_0().a(bool_0: false);
        }

        if (FDk3.SelectedIndex == 0) {
            Class1.smethod_0().g(0);
        } else if (FDk3.SelectedIndex == 1) {
            Class1.smethod_0().g(1);
        } else if (FDk3.SelectedIndex == -1) {
            Class1.smethod_0().g(1);
        }

        uint uint_ = Convert.ToUInt32(LDkk.Value);
        Class1.smethod_0().c(uint_);
        Class1.smethod_0().Save();
        Close();
    }

    private void vDk6(object sender, EventArgs e) {
        if (Class1.smethod_0().method_6()) {
            SDky.Checked = true;
        } else {
            SDky.Checked = false;
        }

        if (Class1.smethod_0().method_8()) {
            kDkr.Checked = true;
        } else {
            kDkr.Checked = false;
        }

        FDk3.SelectedIndex = Class1.smethod_0().f();
        LDkk.Value = Class1.smethod_0().b();
    }

    protected override void Dispose(bool disposing) {
        if (disposing && QDkc != null) {
            ((IDisposable)QDkc).Dispose();
        }

        base.Dispose(disposing);
    }

    private void zDkx() {
        QDkc = new Container();
        SDky = new CheckBox();
        kDkr = new CheckBox();
        FDkq = new Button();
        LDkk = new NumericUpDown();
        JDkM = new Label();
        ADku = new GroupBox();
        yDkg = new Label();
        VDk2 = new ToolTip(QDkc);
        FDk3 = new ComboBox();
        ODkd = new Label();
        ((ISupportInitialize)LDkk).BeginInit();
        ADku.SuspendLayout();
        SuspendLayout();
        SDky.AutoSize = true;
        SDky.Location = new Point(Class13.vpzN, Class13.SpzY);
        SDky.Name = Class13.BpzB;
        SDky.Size = new Size(Class13.WpzA, Class13.spzf);
        SDky.TabIndex = 0;
        SDky.Text = Class13.fpz6;
        SDky.UseVisualStyleBackColor = true;
        kDkr.AutoSize = true;
        kDkr.Location = new Point(Class13.qpzx, Class13.Bpz9);
        kDkr.Name = Class13.epzc;
        kDkr.Size = new Size(Class13.qpzy, Class13.gpzr);
        kDkr.TabIndex = Class13.ypzq;
        kDkr.Text = Class13.qpzk;
        kDkr.UseVisualStyleBackColor = true;
        FDkq.Location = new Point(Class13.MpzM, Class13.Ppzu);
        FDkq.Name = Class13.Wpzg;
        FDkq.Size = new Size(Class13.vpz2, Class13.Fpz3);
        FDkq.TabIndex = Class13.Gpzd;
        FDkq.Text = Class13.YpzH;
        FDkq.UseVisualStyleBackColor = true;
        FDkq.Click += DDkf;
        LDkk.Location = new Point(Class13.Bpz4, Class13.Hpz5);
        LDkk.Maximum = new decimal(new int[4] { Class13.opzs, 0, 0, 0 });
        LDkk.Name = Class13.opzZ;
        LDkk.Size = new Size(Class13.Ppza, Class13.ypzj);
        LDkk.TabIndex = Class13.Opzz;
        JDkM.AutoSize = true;
        JDkM.Location = new Point(Class13.mSEE, Class13.QSED);
        JDkM.Name = Class13.USEX;
        JDkM.Size = new Size(Class13.JSEp, Class13.GSES);
        JDkM.TabIndex = Class13.mSEh;
        JDkM.Text = Class13.uSEl;
        ADku.Controls.Add(yDkg);
        ADku.Controls.Add(SDky);
        ADku.Controls.Add(JDkM);
        ADku.Controls.Add(LDkk);
        ADku.Location = new Point(Class13.tSEG, Class13.cSEb);
        ADku.Name = Class13.zSEv;
        ADku.Size = new Size(Class13.QSEo, Class13.RSEt);
        ADku.TabIndex = Class13.wSEV;
        ADku.TabStop = false;
        ADku.Text = Class13.jSEO;
        yDkg.AutoSize = true;
        yDkg.Location = new Point(Class13.vSEe, Class13.BSE8);
        yDkg.Name = Class13.WSEn;
        yDkg.Size = new Size(Class13.SSEQ, Class13.sSEF);
        yDkg.TabIndex = Class13.MSEL;
        yDkg.Text = Class13.gSEJ;
        FDk3.DropDownStyle = ComboBoxStyle.DropDownList;
        FDk3.FormattingEnabled = true;
        FDk3.Items.AddRange(new object[2] { Class13.SSE7, Class13.TSEP });
        FDk3.Location = new Point(Class13.gSEi, Class13.XSEm);
        FDk3.Name = Class13.SSE0;
        FDk3.Size = new Size(Class13.ESEI, Class13.cSER);
        FDk3.TabIndex = Class13.iSEC;
        ODkd.AutoSize = true;
        ODkd.Location = new Point(Class13.xSEK, Class13.VSEU);
        ODkd.Name = Class13.mSET;
        ODkd.Size = new Size(Class13.mSE1, Class13.wSEW);
        ODkd.TabIndex = Class13.kSEw;
        ODkd.Text = Class13.WSEN;
        base.AutoScaleDimensions = new SizeF(Class13.VSEY, Class13.TSEB);
        base.AutoScaleMode = AutoScaleMode.Font;
        base.ClientSize = new Size(Class13.ySEA, Class13.KSEf);
        base.Controls.Add(ODkd);
        base.Controls.Add(FDk3);
        base.Controls.Add(ADku);
        base.Controls.Add(FDkq);
        base.Controls.Add(kDkr);
        base.FormBorderStyle = FormBorderStyle.FixedSingle;
        base.MaximizeBox = false;
        base.Name = Class13.BSE6;
        base.ShowIcon = false;
        base.StartPosition = FormStartPosition.CenterScreen;
        Text = Class13.QSEx;
        base.Load += vDk6;
        ((ISupportInitialize)LDkk).EndInit();
        ADku.ResumeLayout(performLayout: false);
        ADku.PerformLayout();
        ResumeLayout(performLayout: false);
        PerformLayout();
    }
}