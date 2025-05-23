using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

namespace SplatHex;
public class Class74 : Form {
    private IDisposable NDk5;
    public Class74() {
        zDkH();
        new Thread((ThreadStart)delegate {
            while (Class5.CDU5 == null) {
                Thread.Sleep(Class13.KSEM);
            }

            if (base.InvokeRequired) {
                try {
                    Invoke(new MethodInvoker(base.Close));
                    return;
                } catch {
                    Close();
                    return;
                }
            }

            Close();
        }).Start();
    }

    protected override void Dispose(bool disposing) {
        if (disposing && NDk5 != null) {
            NDk5.Dispose();
        }

        base.Dispose(disposing);
    }

    private void zDkH() {
        SuspendLayout();
        base.AutoScaleDimensions = new SizeF(Class13.WSE9, Class13.bSEc);
        base.AutoScaleMode = AutoScaleMode.Font;
        base.ClientSize = new Size(Class13.lSEy, Class13.uSEr);
        base.FormBorderStyle = FormBorderStyle.None;
        base.Name = Class13.dSEq;
        base.ShowIcon = false;
        base.ShowInTaskbar = false;
        base.StartPosition = FormStartPosition.CenterScreen;
        Text = Class13.NSEk;
        ResumeLayout(performLayout: false);
    }

    [CompilerGenerated]
    private void XDk4() {
        while (Class5.CDU5 == null) {
            Thread.Sleep(Class13.KSEM);
        }

        if (base.InvokeRequired) {
            try {
                Invoke(new MethodInvoker(base.Close));
                return;
            } catch {
                Close();
                return;
            }
        }

        Close();
    }
}