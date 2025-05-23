using System.Windows.Forms;

namespace SplatHex;
internal class Class82 : ListView {
    private const int TDiv = 276;
    private const int ODio = 277;
    protected override void WndProc(ref Message m) {
        if (m.Msg == Class13.qD31 || m.Msg == Class13.ND3W) {
            Focus();
        }

        if (m.Msg != Class13.cD3w) {
            base.WndProc(ref m);
        }
    }

    internal static bool m8W() {
        return false;
    }
}