using System;
using System.Drawing;
using System.Windows.Forms;

namespace SplatHex;
public class Class126 : Form {
    private IDisposable foT;
    public Class126() {
        coU();
    }

    protected override void Dispose(bool disposing) {
        if (disposing && foT != null) {
            foT.Dispose();
        }

        base.Dispose(disposing);
    }

    private void coU() {
        SuspendLayout();
        base.AutoScaleDimensions = new SizeF(6f, 13f);
        base.AutoScaleMode = AutoScaleMode.Font;
        base.ClientSize = new Size(284, 261);
        base.Name = "SplatHeX";
        base.ShowIcon = false;
        Text = "CheckLegalitySplat2";
        ResumeLayout(performLayout: false);
    }
}