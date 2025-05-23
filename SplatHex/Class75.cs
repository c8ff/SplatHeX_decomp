using System;
using System.Drawing;
using System.Windows.Forms;

namespace SplatHex;
public class Class75 : Form {
    private Class128 HDiG;
    private IDisposable oDib;
    public Class75(Class128 mbz_0) {
        uDil();
        HDiG = mbz_0;
    }

    public void MDiS(object sender, EventArgs e) {
        MessageBox.Show(Class13.bD30);
    }

    private void pDih(object sender, EventArgs e) {
        Close();
    }

    protected override void Dispose(bool disposing) {
        if (disposing && oDib != null) {
            oDib.Dispose();
        }

        base.Dispose(disposing);
    }

    private void uDil() {
        SuspendLayout();
        base.AutoScaleDimensions = new SizeF(Class13.qD3I, Class13.VD3R);
        base.AutoScaleMode = AutoScaleMode.Font;
        base.ClientSize = new Size(Class13.MD3C, Class13.HD3K);
        base.MaximizeBox = false;
        base.MinimizeBox = false;
        base.Name = Class13.dD3U;
        base.ShowIcon = false;
        base.ShowInTaskbar = false;
        base.StartPosition = FormStartPosition.CenterScreen;
        Text = Class13.GD3T;
        base.Load += MDiS;
        ResumeLayout(performLayout: false);
    }
}