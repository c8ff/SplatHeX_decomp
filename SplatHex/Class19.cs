using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace SplatHex;
public class Class19 : Form {
    private bool rDka;
    private IDisposable dDkj;
    public TextBox jDkz;
    private Button XDME;
    public Class19(string string_0, bool bool_0) {
        vDkZ();
        jDkz.Text = string_0;
        rDka = bool_0;
    }

    private void bDks(object sender, EventArgs e) {
        float result2;
        if (rDka) {
            if (uint.TryParse(jDkz.Text, (NumberStyles)Class13.PSEu, CultureInfo.InvariantCulture, out var _)) {
                Close();
                return;
            }
        } else if (float.TryParse(jDkz.Text, out result2)) {
            Close();
            return;
        }

        MessageBox.Show(Class13.NSEg);
    }

    protected override void Dispose(bool disposing) {
        if (disposing && dDkj != null) {
            dDkj.Dispose();
        }

        base.Dispose(disposing);
    }

    private void vDkZ() {
        jDkz = new TextBox();
        XDME = new Button();
        SuspendLayout();
        jDkz.Location = new Point(Class13.PSE2, Class13.ASE3);
        jDkz.Name = Class13.rSEd;
        jDkz.Size = new Size(Class13.LSEH, Class13.cSE4);
        jDkz.TabIndex = 1;
        XDME.Location = new Point(Class13.kSE5, Class13.WSEs);
        XDME.Name = Class13.wSEZ;
        XDME.Size = new Size(Class13.VSEa, Class13.pSEj);
        XDME.TabIndex = 2;
        XDME.Text = Class13.CSEz;
        XDME.UseVisualStyleBackColor = true;
        XDME.Click += bDks;
        base.AcceptButton = XDME;
        base.AutoScaleDimensions = new SizeF(Class13.fSDE, Class13.hSDD);
        base.AutoScaleMode = AutoScaleMode.Font;
        base.ClientSize = new Size(Class13.MSDX, Class13.fSDp);
        base.ControlBox = false;
        base.Controls.Add(XDME);
        base.Controls.Add(jDkz);
        base.MaximizeBox = false;
        MaximumSize = new Size(Class13.kSDS, Class13.ySDh);
        base.MinimizeBox = false;
        MinimumSize = new Size(Class13.USDl, Class13.OSDG);
        base.Name = Class13.pSDb;
        base.ShowIcon = false;
        base.ShowInTaskbar = false;
        Text = Class13.kSDv;
        base.TopMost = true;
        ResumeLayout(performLayout: false);
        PerformLayout();
    }
}