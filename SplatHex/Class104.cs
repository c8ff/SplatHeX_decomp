using System;
using System.Drawing;
using System.Windows.Forms;

namespace SplatHex;
public class Class104 : Form {
    private IDisposable aoB;
    private Button goA;
    private Button Vof;
    private CheckBox oo6;
    public Class104() {
        YoY();
        Po1();
    }

    private void Po1() {
        oo6.Checked = (Class26.QXu.ESp & 1) != 0;
    }

    private void woW() {
        Class115.cH2(ref Class26.QXu.ESp, 1u, oo6.Checked);
    }

    private void Mow(object sender, EventArgs e) {
        woW();
        Close();
    }

    private void IoN(object sender, EventArgs e) {
        Close();
    }

    protected override void Dispose(bool disposing) {
        if (disposing && aoB != null) {
            aoB.Dispose();
        }

        base.Dispose(disposing);
    }

    private void YoY() {
        goA = new Button();
        Vof = new Button();
        oo6 = new CheckBox();
        SuspendLayout();
        goA.Location = new Point(184, 340);
        goA.Name = "BTN_Cancel";
        goA.Size = new Size(65, 23);
        goA.TabIndex = 7;
        goA.Text = "Cancel";
        goA.UseVisualStyleBackColor = true;
        goA.Click += IoN;
        Vof.Location = new Point(113, 340);
        Vof.Name = "BTN_Save";
        Vof.Size = new Size(65, 23);
        Vof.TabIndex = 6;
        Vof.Text = "Save";
        Vof.UseVisualStyleBackColor = true;
        Vof.Click += Mow;
        oo6.AutoSize = true;
        oo6.Location = new Point(12, 13);
        oo6.Name = "CB_Tuto";
        oo6.Size = new Size(334, 17);
        oo6.TabIndex = 8;
        oo6.Text = "Finished Tutorial, seen Great Zapfish news and Plaza explanation";
        oo6.UseVisualStyleBackColor = true;
        base.AutoScaleDimensions = new SizeF(6f, 13f);
        base.AutoScaleMode = AutoScaleMode.Font;
        base.ClientSize = new Size(363, 375);
        base.Controls.Add(oo6);
        base.Controls.Add(goA);
        base.Controls.Add(Vof);
        base.Name = "BitFlagSplat2";
        base.ShowIcon = false;
        base.StartPosition = FormStartPosition.CenterScreen;
        Text = "SplatHeX - Splatoon 2 - BitFlag Editor";
        ResumeLayout(performLayout: false);
        PerformLayout();
    }
}