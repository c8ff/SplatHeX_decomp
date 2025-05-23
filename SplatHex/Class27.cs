using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace SplatHex;
public class Class27 : Button {
    protected override void OnPaint(PaintEventArgs pevent) {
        GraphicsPath graphicsPath = new GraphicsPath();
        Rectangle clientRectangle = base.ClientRectangle;
        clientRectangle.Inflate(Class13.Upz1, Class13.IpzW);
        pevent.Graphics.DrawEllipse(Pens.Black, clientRectangle);
        clientRectangle.Inflate(1, 1);
        graphicsPath.AddEllipse(clientRectangle);
        base.Region = new Region(graphicsPath);
    }

    internal static bool H8y() {
        return false;
    }
}