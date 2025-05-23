using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SplatHex;
public class Class14 : Form {
    private readonly string XDkt;
    public bool yDkV;
    private IDisposable fDkO;
    private Label qDke;
    private TextBox pDk8;
    private Button QDkn;
    private Button fDkQ;
    public Class14(string string_0) {
        wDko();
        XDkt = string_0;
        fDkQ.DialogResult = DialogResult.Cancel;
        pDk8.Text = string_0;
        pDk8.MaxLength = string_0.Length;
        QDkn.DialogResult = DialogResult.OK;
    }

    private void oDkb(object sender, EventArgs e) {
        if (XDkt.Length > pDk8.Text.Length) {
            if (!pDk8.Text.Contains(Class13.Npj1)) {
                pDk8.AppendText(Class13.BpjW);
            }

            while (XDkt.Length > pDk8.Text.Length) {
                pDk8.AppendText(Class13.tpjw);
            }
        }

        yDkV = Regex.IsMatch(pDk8.Text, Class13.qpjN);
    }

    public string pDkv() {
        return pDk8.Text;
    }

    protected override void Dispose(bool disposing) {
        if (disposing && fDkO != null) {
            fDkO.Dispose();
        }

        base.Dispose(disposing);
    }

    private void wDko() {
        qDke = new Label();
        pDk8 = new TextBox();
        QDkn = new Button();
        fDkQ = new Button();
        SuspendLayout();
        qDke.AutoSize = true;
        qDke.Location = new Point(Class13.cpjY, Class13.ipjB);
        qDke.Name = Class13.upjA;
        qDke.Size = new Size(Class13.npjf, Class13.Npj6);
        qDke.TabIndex = 0;
        qDke.Text = Class13.Rpjx;
        pDk8.Location = new Point(Class13.Dpj9, Class13.dpjc);
        pDk8.Name = Class13.lpjy;
        pDk8.Size = new Size(Class13.Kpjr, Class13.opjq);
        pDk8.TabIndex = 1;
        QDkn.Location = new Point(Class13.Fpjk, Class13.CpjM);
        QDkn.Name = Class13.Spju;
        QDkn.Size = new Size(Class13.Apjg, Class13.Upj2);
        QDkn.TabIndex = 2;
        QDkn.Text = Class13.ppj3;
        QDkn.UseVisualStyleBackColor = true;
        QDkn.Click += oDkb;
        fDkQ.Location = new Point(Class13.mpjd, Class13.QpjH);
        fDkQ.Name = Class13.npj4;
        fDkQ.Size = new Size(Class13.hpj5, Class13.Bpjs);
        fDkQ.TabIndex = 3;
        fDkQ.Text = Class13.jpjZ;
        fDkQ.UseVisualStyleBackColor = true;
        base.AutoScaleDimensions = new SizeF(Class13.mpja, Class13.tpjj);
        base.AutoScaleMode = AutoScaleMode.Font;
        base.ClientSize = new Size(Class13.Ypjz, Class13.XpzE);
        base.Controls.Add(fDkQ);
        base.Controls.Add(QDkn);
        base.Controls.Add(pDk8);
        base.Controls.Add(qDke);
        base.FormBorderStyle = FormBorderStyle.FixedSingle;
        base.MaximizeBox = false;
        base.Name = Class13.JpzD;
        base.ShowIcon = false;
        base.StartPosition = FormStartPosition.CenterScreen;
        Text = Class13.rpzX;
        ResumeLayout(performLayout: false);
        PerformLayout();
    }
}