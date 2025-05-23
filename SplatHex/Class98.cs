using System;
using System.Drawing;
using System.Windows.Forms;

namespace SplatHex;
public class Class98 : Form {
    private IDisposable o7U;
    public Class98() {
        c7K();
    }

    protected override void Dispose(bool disposing) {
        if (disposing && o7U != null) {
            o7U.Dispose();
        }

        base.Dispose(disposing);
    }

    private void c7K() {
        SuspendLayout();
        base.AutoScaleDimensions = new SizeF(6f, 13f);
        base.AutoScaleMode = AutoScaleMode.Font;
        base.ClientSize = new Size(284, 261);
        base.Name = "PlazaSplat2";
        base.ShowIcon = false;
        Text = "SplatHeX - Splatoon 2 - Plaza Editor";
        ResumeLayout(performLayout: false);
    }
}