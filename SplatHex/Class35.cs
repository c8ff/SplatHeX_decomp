using System.Windows.Forms;

namespace SplatHex;
public class Class35 : FlowLayoutPanel {
    protected override CreateParams CreateParams {
        get {
            CreateParams createParams = base.CreateParams;
            createParams.ExStyle |= 33554432;
            return createParams;
        }
    }

    public Class35() {
        SetStyle(ControlStyles.UserPaint, value: true);
        SetStyle(ControlStyles.AllPaintingInWmPaint, value: true);
        SetStyle(ControlStyles.OptimizedDoubleBuffer, value: true);
    }

    protected override void OnScroll(ScrollEventArgs se) {
        Invalidate();
        base.OnScroll(se);
    }

    internal static bool yv() {
        return true;
    }

    internal static bool PU() {
        return false;
    }
}