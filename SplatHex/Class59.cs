
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace SplatHex;
internal abstract class Class59 : Control {
    protected Graphics xDJN;
    protected Bitmap fDJY;
    private bool gDJB;
    private bool jDJA;
    protected wB0 ADJf;
    private bool TDJ6;
    private bool GDJx;
    private Image mDJ9;
    private bool LDJc;
    private Dictionary<string, Color> eDJy = new Dictionary<string, Color>();
    private string LDJr;
    private Size KDJq;
    private int gDJk;
    private int BDJM;
    private bool yDJu;
    private Rectangle QDJg;
    private Size oDJ2;
    private Point PDJ3;
    private Point vDJd;
    private Bitmap cDJH;
    private Graphics tDJ4;
    private SolidBrush ODJ5;
    private SolidBrush IDJs;
    private Point yDJZ;
    private Size EDJa;
    private Point lDJj;
    private LinearGradientBrush rDJz;
    private Rectangle xD7E;
    private GraphicsPath fD7D;
    private PathGradientBrush ED7X;
    private LinearGradientBrush pD7p;
    private Rectangle JD7S;
    private GraphicsPath nD7h;
    private Rectangle lD7l;
    public Class59() {
        SetStyle((ControlStyles)Class13.VDud, value: true);
        KDJq = Size.Empty;
        Font = new Font(Class13.DDuH, Class13.IDu4);
        cDJH = new Bitmap(1, 1);
        tDJ4 = Graphics.FromImage(cDJH);
        fD7D = new GraphicsPath();
        aDL6();
    }

    protected sealed override void OnHandleCreated(EventArgs e) {
        aDL6();
        GjJ9();
        if (gDJk != 0) {
            base.Width = gDJk;
        }

        if (BDJM != 0) {
            base.Height = BDJM;
        }

        method_5(LDJc);
        if (LDJc && TDJ6) {
            BackColor = Color.Transparent;
        }

        base.OnHandleCreated(e);
    }

    protected sealed override void OnParentChanged(EventArgs e) {
        if (base.Parent != null) {
            gjJM();
            gDJB = true;
            uDLx();
        }

        base.OnParentChanged(e);
    }

    private void NDLK(bool bool_0) {
        AjJ0();
        if (bool_0) {
            Invalidate();
        }
    }

    protected sealed override void OnPaint(PaintEventArgs pevent) {
        if (base.Width != 0 && base.Height != 0) {
            if (LDJc) {
                bjJe();
                pevent.Graphics.DrawImage(fDJY, 0, 0);
            } else {
                xDJN = pevent.Graphics;
                bjJe();
            }
        }
    }

    protected override void OnHandleDestroyed(EventArgs e) {
        Class24.uD7o(new Class24.MBX(NDLK));
        base.OnHandleDestroyed(e);
    }

    protected sealed override void OnSizeChanged(EventArgs e) {
        if (LDJc) {
            yDLf();
        }

        Invalidate();
        base.OnSizeChanged(e);
    }

    protected override void SetBoundsCore(int x, int y, int width, int height, BoundsSpecified specified) {
        if (gDJk != 0) {
            width = gDJk;
        }

        if (BDJM != 0) {
            height = BDJM;
        }

        base.SetBoundsCore(x, y, width, height, specified);
    }

    protected override void OnMouseEnter(EventArgs e) {
        //IL_000e: Expected O, but got I4
        jDJA = true;
        bDLU((wB0)1);
        base.OnMouseEnter(e);
    }

    protected override void OnMouseUp(MouseEventArgs mevent) {
        //IL_000f: Expected O, but got I4
        if (jDJA) {
            bDLU((wB0)1);
        }

        base.OnMouseUp(mevent);
    }

    protected override void OnMouseDown(MouseEventArgs mevent) {
        //IL_0014: Expected O, but got I4
        if (mevent.Button == (MouseButtons)Class13.hDu5) {
            bDLU((wB0)2);
        }

        base.OnMouseDown(mevent);
    }

    protected override void OnMouseLeave(EventArgs e) {
        //IL_000e: Expected O, but got I4
        jDJA = false;
        bDLU((wB0)0);
        base.OnMouseLeave(e);
    }

    protected override void OnEnabledChanged(EventArgs e) {
        //IL_0018: Expected O, but got I4
        //IL_000f: Expected O, but got I4
        if (!base.Enabled) {
            bDLU((wB0)3);
        } else {
            bDLU((wB0)0);
        }

        base.OnEnabledChanged(e);
    }

    private void bDLU(wB0 wB0_0) {
        ADJf = wB0_0;
        Invalidate();
    }

    [SpecialName]
    public virtual Color get_ForeColor() {
        return Color.Empty;
    }

    [SpecialName]
    public virtual void set_ForeColor(Color value) {
    }

    [SpecialName]
    public virtual Image get_BackgroundImage() {
        return null;
    }

    [SpecialName]
    public virtual void set_BackgroundImage(Image value) {
    }

    [SpecialName]
    public virtual ImageLayout get_BackgroundImageLayout() {
        return ImageLayout.None;
    }

    [SpecialName]
    public virtual void set_BackgroundImageLayout(ImageLayout value) {
    }

    [SpecialName]
    public virtual string get_Text() {
        return base.Text;
    }

    [SpecialName]
    public virtual void set_Text(string value) {
        base.Text = value;
        Invalidate();
    }

    [SpecialName]
    public virtual Font get_Font() {
        return base.Font;
    }

    [SpecialName]
    public virtual void set_Font(Font value) {
        base.Font = value;
        Invalidate();
    }

    [SpecialName]
    public virtual Color get_BackColor() {
        return base.BackColor;
    }

    [SpecialName]
    public virtual void set_BackColor(Color value) {
        if (!base.IsHandleCreated && value == Color.Transparent) {
            TDJ6 = true;
            return;
        }

        base.BackColor = value;
        if (base.Parent != null) {
            GjJ9();
        }
    }

    [SpecialName]
    public bool method_0() {
        return GDJx;
    }

    [SpecialName]
    public void method_1(bool bool_0) {
        GDJx = bool_0;
        Invalidate();
    }

    [SpecialName]
    public Image method_2() {
        return mDJ9;
    }

    [SpecialName]
    public void method_3(Image image_0) {
        if (image_0 == null) {
            KDJq = Size.Empty;
        } else {
            KDJq = image_0.Size;
        }

        mDJ9 = image_0;
        Invalidate();
    }

    [SpecialName]
    public bool method_4() {
        return LDJc;
    }

    [SpecialName]
    public void method_5(bool bool_0) {
        LDJc = bool_0;
        if (base.IsHandleCreated) {
            if (!bool_0 && BackColor.A != Class13.HDus) {
                throw new Exception(Class13.TDuZ);
            }

            SetStyle(ControlStyles.Opaque, !bool_0);
            SetStyle((ControlStyles)Class13.XDua, bool_0);
            if (!bool_0) {
                fDJY = null;
            } else {
                yDLf();
            }

            Invalidate();
        }
    }

    [SpecialName]
    public uBw[] method_6() {
        List<uBw> list = new List<uBw>();
        Dictionary<string, Color>.Enumerator enumerator = eDJy.GetEnumerator();
        while (enumerator.MoveNext()) {
            list.Add(new uBw(enumerator.Current.Key, enumerator.Current.Value));
        }

        return list.ToArray();
    }

    [SpecialName]
    public void method_7(uBw[] uBw_0) {
        for (int i = 0; i < uBw_0.Length; i++) {
            uBw uBw = uBw_0[i];
            if (eDJy.ContainsKey(uBw.method_0())) {
                eDJy[uBw.method_0()] = uBw.method_1();
            }
        }

        aDL6();
        GjJ9();
        Invalidate();
    }

    [SpecialName]
    public string a() {
        return LDJr;
    }

    [SpecialName]
    public void b(string string_0) {
        if (string_0 == LDJr) {
            return;
        }

        byte[] array = null;
        uBw[] array2 = method_6();
        try {
            array = Convert.FromBase64String(string_0);
            for (int i = 0; i <= array2.Length - 1; i++) {
                array2[i].method_2(Color.FromArgb(BitConverter.ToInt32(array, i * 4)));
            }
        } catch {
            return;
        }

        LDJr = string_0;
        method_7(array2);
        GjJ9();
        Invalidate();
    }

    [SpecialName]
    protected Size g() {
        return KDJq;
    }

    [SpecialName]
    protected int h() {
        return gDJk;
    }

    [SpecialName]
    protected void i(int int_0) {
        gDJk = int_0;
        if (h() != 0 && base.IsHandleCreated) {
            base.Width = h();
        }
    }

    [SpecialName]
    protected int j() {
        return BDJM;
    }

    [SpecialName]
    protected void k(int int_0) {
        BDJM = int_0;
        if (j() != 0 && base.IsHandleCreated) {
            base.Height = j();
        }
    }

    [SpecialName]
    protected bool l() {
        return yDJu;
    }

    [SpecialName]
    protected void m(bool bool_0) {
        yDJu = bool_0;
        uDLx();
    }

    protected Pen lDLT(string string_0) {
        return new Pen(eDJy[string_0]);
    }

    protected Pen dDL1(string string_0, float float_0) {
        return new Pen(eDJy[string_0], float_0);
    }

    protected SolidBrush iDLW(string string_0) {
        return new SolidBrush(eDJy[string_0]);
    }

    protected Color rDLw(string string_0) {
        return eDJy[string_0];
    }

    protected void PDLN(string string_0, Color color_0) {
        if (!eDJy.ContainsKey(string_0)) {
            eDJy.Add(string_0, color_0);
        } else {
            eDJy[string_0] = color_0;
        }
    }

    protected void dDLY(string string_0, byte byte_0, byte byte_1, byte byte_2) {
        PDLN(string_0, Color.FromArgb(byte_0, byte_1, byte_2));
    }

    protected void DDLB(string string_0, byte byte_0, byte byte_1, byte byte_2, byte byte_3) {
        PDLN(string_0, Color.FromArgb(byte_0, byte_1, byte_2, byte_3));
    }

    protected void dDLA(string string_0, byte byte_0, Color color_0) {
        PDLN(string_0, Color.FromArgb(byte_0, color_0));
    }

    private void yDLf() {
        if (base.Width != 0 && base.Height != 0) {
            fDJY = new Bitmap(base.Width, base.Height, (PixelFormat)Class13.GDuj);
            xDJN = Graphics.FromImage(fDJY);
        }
    }

    private void aDL6() {
        MemoryStream memoryStream = new MemoryStream(eDJy.Count * 4);
        uBw[] array = method_6();
        foreach (uBw uBw in array) {
            memoryStream.Write(BitConverter.GetBytes(uBw.method_1().ToArgb()), 0, 4);
        }

        memoryStream.Close();
        LDJr = Convert.ToBase64String(memoryStream.ToArray());
    }

    private void uDLx() {
        if (!base.DesignMode && gDJB) {
            if (yDJu) {
                Class24.eD7v(new Class24.MBX(NDLK));
            } else {
                Class24.uD7o(new Class24.MBX(NDLK));
            }
        }
    }

    protected abstract void GjJ9();
    protected abstract void bjJe();
    protected virtual void gjJM() {
    }

    protected virtual void AjJ0() {
    }

    protected Rectangle RDL9(Rectangle rectangle_0, int int_0) {
        QDJg = new Rectangle(rectangle_0.X + int_0, rectangle_0.Y + int_0, rectangle_0.Width - int_0 * 2, rectangle_0.Height - int_0 * 2);
        return QDJg;
    }

    protected Size zDLc(Size size_0, int int_0) {
        oDJ2 = new Size(size_0.Width + int_0, size_0.Height + int_0);
        return oDJ2;
    }

    protected Point JDLy(Point point_0, int int_0) {
        PDJ3 = new Point(point_0.X + int_0, point_0.Y + int_0);
        return PDJ3;
    }

    protected Point TDLr(Rectangle rectangle_0, Rectangle rectangle_1) {
        vDJd = new Point(rectangle_0.Width / 2 - rectangle_1.Width / 2 + rectangle_0.X + rectangle_1.X, rectangle_0.Height / 2 - rectangle_1.Height / 2 + rectangle_0.Y + rectangle_1.Y);
        return vDJd;
    }

    protected Point YDLq(Rectangle rectangle_0, Size size_0) {
        vDJd = new Point(rectangle_0.Width / 2 - size_0.Width / 2 + rectangle_0.X, rectangle_0.Height / 2 - size_0.Height / 2 + rectangle_0.Y);
        return vDJd;
    }

    protected Point PDLk(Rectangle rectangle_0) {
        return oDL2(base.Width, base.Height, rectangle_0.Width, rectangle_0.Height);
    }

    protected Point SDLM(Size size_0) {
        return oDL2(base.Width, base.Height, size_0.Width, size_0.Height);
    }

    protected Point XDLu(int int_0, int int_1) {
        return oDL2(base.Width, base.Height, int_0, int_1);
    }

    protected Point rDLg(Size size_0, Size size_1) {
        return oDL2(size_0.Width, size_0.Height, size_1.Width, size_1.Height);
    }

    protected Point oDL2(int int_0, int int_1, int int_2, int int_3) {
        vDJd = new Point(int_0 / 2 - int_2 / 2, int_1 / 2 - int_3 / 2);
        return vDJd;
    }

    protected Size aDL3() {
        return tDJ4.MeasureString(Text, Font, base.Width).ToSize();
    }

    protected Size xDLd(string string_0) {
        return tDJ4.MeasureString(string_0, Font, base.Width).ToSize();
    }

    protected void RDLH(Color color_0, int int_0, int int_1) {
        if (LDJc) {
            fDJY.SetPixel(int_0, int_1, color_0);
            return;
        }

        ODJ5 = new SolidBrush(color_0);
        xDJN.FillRectangle(ODJ5, int_0, int_1, 1, 1);
    }

    protected void qDL4(Color color_0, int int_0) {
        qDLs(color_0, 0, 0, base.Width, base.Height, int_0);
    }

    protected void pDL5(Color color_0, Rectangle rectangle_0, int int_0) {
        qDLs(color_0, rectangle_0.X, rectangle_0.Y, rectangle_0.Width, rectangle_0.Height, int_0);
    }

    protected void qDLs(Color color_0, int int_0, int int_1, int int_2, int int_3, int int_4) {
        tDLj(color_0, int_0 + int_4, int_1 + int_4, int_2 - int_4 * 2, int_3 - int_4 * 2);
    }

    protected void cDLZ(Color color_0) {
        tDLj(color_0, 0, 0, base.Width, base.Height);
    }

    protected void KDLa(Color color_0, Rectangle rectangle_0) {
        tDLj(color_0, rectangle_0.X, rectangle_0.Y, rectangle_0.Width, rectangle_0.Height);
    }

    protected void tDLj(Color color_0, int int_0, int int_1, int int_2, int int_3) {
        if (!GDJx) {
            if (LDJc) {
                fDJY.SetPixel(int_0, int_1, color_0);
                fDJY.SetPixel(int_0 + (int_2 - 1), int_1, color_0);
                fDJY.SetPixel(int_0, int_1 + (int_3 - 1), color_0);
                fDJY.SetPixel(int_0 + (int_2 - 1), int_1 + (int_3 - 1), color_0);
            } else {
                IDJs = new SolidBrush(color_0);
                xDJN.FillRectangle(IDJs, int_0, int_1, 1, 1);
                xDJN.FillRectangle(IDJs, int_0 + (int_2 - 1), int_1, 1, 1);
                xDJN.FillRectangle(IDJs, int_0, int_1 + (int_3 - 1), 1, 1);
                xDJN.FillRectangle(IDJs, int_0 + (int_2 - 1), int_1 + (int_3 - 1), 1, 1);
            }
        }
    }

    protected void hDLz(Pen pen_0, int int_0) {
        MDJD(pen_0, 0, 0, base.Width, base.Height, int_0);
    }

    protected void rDJE(Pen pen_0, Rectangle rectangle_0, int int_0) {
        MDJD(pen_0, rectangle_0.X, rectangle_0.Y, rectangle_0.Width, rectangle_0.Height, int_0);
    }

    protected void MDJD(Pen pen_0, int int_0, int int_1, int int_2, int int_3, int int_4) {
        uDJS(pen_0, int_0 + int_4, int_1 + int_4, int_2 - int_4 * 2, int_3 - int_4 * 2);
    }

    protected void HDJX(Pen pen_0) {
        uDJS(pen_0, 0, 0, base.Width, base.Height);
    }

    protected void cDJp(Pen pen_0, Rectangle rectangle_0) {
        uDJS(pen_0, rectangle_0.X, rectangle_0.Y, rectangle_0.Width, rectangle_0.Height);
    }

    protected void uDJS(Pen pen_0, int int_0, int int_1, int int_2, int int_3) {
        xDJN.DrawRectangle(pen_0, int_0, int_1, int_2 - 1, int_3 - 1);
    }

    protected void kDJh(Brush brush_0, HorizontalAlignment horizontalAlignment_0, int int_0, int int_1) {
        YDJl(brush_0, Text, horizontalAlignment_0, int_0, int_1);
    }

    protected void YDJl(Brush brush_0, string string_0, HorizontalAlignment horizontalAlignment_0, int int_0, int int_1) {
        if (string_0.Length != 0) {
            EDJa = xDLd(string_0);
            yDJZ = SDLM(EDJa);
            switch (horizontalAlignment_0) {
                case HorizontalAlignment.Left:
                    xDJN.DrawString(string_0, Font, brush_0, int_0, yDJZ.Y + int_1);
                    break;
                case HorizontalAlignment.Right:
                    xDJN.DrawString(string_0, Font, brush_0, base.Width - EDJa.Width - int_0, yDJZ.Y + int_1);
                    break;
                case HorizontalAlignment.Center:
                    xDJN.DrawString(string_0, Font, brush_0, yDJZ.X + int_0, yDJZ.Y + int_1);
                    break;
            }
        }
    }

    protected void HDJG(Brush brush_0, Point point_0) {
        if (Text.Length != 0) {
            xDJN.DrawString(Text, Font, brush_0, point_0);
        }
    }

    protected void xDJb(Brush brush_0, int int_0, int int_1) {
        if (Text.Length != 0) {
            xDJN.DrawString(Text, Font, brush_0, int_0, int_1);
        }
    }

    protected void QDJv(HorizontalAlignment horizontalAlignment_0, int int_0, int int_1) {
        BDJo(mDJ9, horizontalAlignment_0, int_0, int_1);
    }

    protected void BDJo(Image image_0, HorizontalAlignment horizontalAlignment_0, int int_0, int int_1) {
        if (image_0 != null) {
            lDJj = SDLM(image_0.Size);
            switch (horizontalAlignment_0) {
                case HorizontalAlignment.Left:
                    xDJN.DrawImage(image_0, int_0, lDJj.Y + int_1, image_0.Width, image_0.Height);
                    break;
                case HorizontalAlignment.Right:
                    xDJN.DrawImage(image_0, base.Width - image_0.Width - int_0, lDJj.Y + int_1, image_0.Width, image_0.Height);
                    break;
                case HorizontalAlignment.Center:
                    xDJN.DrawImage(image_0, lDJj.X + int_0, lDJj.Y + int_1, image_0.Width, image_0.Height);
                    break;
            }
        }
    }

    protected void LDJt(Point point_0) {
        QDJe(mDJ9, point_0.X, point_0.Y);
    }

    protected void yDJV(int int_0, int int_1) {
        QDJe(mDJ9, int_0, int_1);
    }

    protected void mDJO(Image image_0, Point point_0) {
        QDJe(image_0, point_0.X, point_0.Y);
    }

    protected void QDJe(Image image_0, int int_0, int int_1) {
        if (image_0 != null) {
            xDJN.DrawImage(image_0, int_0, int_1, image_0.Width, image_0.Height);
        }
    }

    protected void zDJ8(ColorBlend colorBlend_0, int int_0, int int_1, int int_2, int int_3) {
        xD7E = new Rectangle(int_0, int_1, int_2, int_3);
        aDJQ(colorBlend_0, xD7E);
    }

    protected void RDJn(ColorBlend colorBlend_0, int int_0, int int_1, int int_2, int int_3, float float_0) {
        xD7E = new Rectangle(int_0, int_1, int_2, int_3);
        mDJF(colorBlend_0, xD7E, float_0);
    }

    protected void aDJQ(ColorBlend colorBlend_0, Rectangle rectangle_0) {
        rDJz = new LinearGradientBrush(rectangle_0, Color.Empty, Color.Empty, Class13.gDuz);
        rDJz.InterpolationColors = colorBlend_0;
        xDJN.FillRectangle(rDJz, rectangle_0);
    }

    protected void mDJF(ColorBlend colorBlend_0, Rectangle rectangle_0, float float_0) {
        rDJz = new LinearGradientBrush(rectangle_0, Color.Empty, Color.Empty, float_0);
        rDJz.InterpolationColors = colorBlend_0;
        xDJN.FillRectangle(rDJz, rectangle_0);
    }

    protected void KDJL(Color color_0, Color color_1, int int_0, int int_1, int int_2, int int_3) {
        xD7E = new Rectangle(int_0, int_1, int_2, int_3);
        YDJ7(color_0, color_1, xD7E);
    }

    protected void rDJJ(Color color_0, Color color_1, int int_0, int int_1, int int_2, int int_3, float float_0) {
        xD7E = new Rectangle(int_0, int_1, int_2, int_3);
        iDJP(color_0, color_1, xD7E, float_0);
    }

    protected void YDJ7(Color color_0, Color color_1, Rectangle rectangle_0) {
        rDJz = new LinearGradientBrush(rectangle_0, color_0, color_1, Class13.sDgE);
        xDJN.FillRectangle(rDJz, rectangle_0);
    }

    protected void iDJP(Color color_0, Color color_1, Rectangle rectangle_0, float float_0) {
        rDJz = new LinearGradientBrush(rectangle_0, color_0, color_1, float_0);
        xDJN.FillRectangle(rDJz, rectangle_0);
    }

    public void UDJi(ColorBlend colorBlend_0, int int_0, int int_1, int int_2, int int_3) {
        JD7S = new Rectangle(int_0, int_1, int_2, int_3);
        uDJC(colorBlend_0, JD7S, int_2 / 2, int_3 / 2);
    }

    public void lDJm(ColorBlend colorBlend_0, int int_0, int int_1, int int_2, int int_3, Point point_0) {
        JD7S = new Rectangle(int_0, int_1, int_2, int_3);
        uDJC(colorBlend_0, JD7S, point_0.X, point_0.Y);
    }

    public void sDJ0(ColorBlend colorBlend_0, int int_0, int int_1, int int_2, int int_3, int int_4, int int_5) {
        JD7S = new Rectangle(int_0, int_1, int_2, int_3);
        uDJC(colorBlend_0, JD7S, int_4, int_5);
    }

    public void nDJI(ColorBlend colorBlend_0, Rectangle rectangle_0) {
        uDJC(colorBlend_0, rectangle_0, rectangle_0.Width / 2, rectangle_0.Height / 2);
    }

    public void XDJR(ColorBlend colorBlend_0, Rectangle rectangle_0, Point point_0) {
        uDJC(colorBlend_0, rectangle_0, point_0.X, point_0.Y);
    }

    public void uDJC(ColorBlend colorBlend_0, Rectangle rectangle_0, int int_0, int int_1) {
        fD7D.Reset();
        fD7D.AddEllipse(rectangle_0.X, rectangle_0.Y, rectangle_0.Width - 1, rectangle_0.Height - 1);
        ED7X = new PathGradientBrush(fD7D);
        ED7X.CenterPoint = new Point(rectangle_0.X + int_0, rectangle_0.Y + int_1);
        ED7X.InterpolationColors = colorBlend_0;
        if (xDJN.SmoothingMode == SmoothingMode.AntiAlias) {
            xDJN.FillEllipse(ED7X, rectangle_0.X + 1, rectangle_0.Y + 1, rectangle_0.Width - 3, rectangle_0.Height - 3);
        } else {
            xDJN.FillEllipse(ED7X, rectangle_0);
        }
    }

    protected void PDJK(Color color_0, Color color_1, int int_0, int int_1, int int_2, int int_3) {
        JD7S = new Rectangle(int_0, int_1, int_2, int_3);
        MDJT(color_0, color_1, JD7S);
    }

    protected void pDJU(Color color_0, Color color_1, int int_0, int int_1, int int_2, int int_3, float float_0) {
        JD7S = new Rectangle(int_0, int_1, int_2, int_3);
        DDJ1(color_0, color_1, JD7S, float_0);
    }

    protected void MDJT(Color color_0, Color color_1, Rectangle rectangle_0) {
        pD7p = new LinearGradientBrush(rectangle_0, color_0, color_1, Class13.TDgD);
        xDJN.FillEllipse(pD7p, rectangle_0);
    }

    protected void DDJ1(Color color_0, Color color_1, Rectangle rectangle_0, float float_0) {
        pD7p = new LinearGradientBrush(rectangle_0, color_0, color_1, float_0);
        xDJN.FillEllipse(pD7p, rectangle_0);
    }

    public GraphicsPath hDJW(int int_0, int int_1, int int_2, int int_3, int int_4) {
        lD7l = new Rectangle(int_0, int_1, int_2, int_3);
        return zDJw(lD7l, int_4);
    }

    public GraphicsPath zDJw(Rectangle rectangle_0, int int_0) {
        nD7h = new GraphicsPath(FillMode.Winding);
        nD7h.AddArc(rectangle_0.X, rectangle_0.Y, int_0, int_0, Class13.KDgX, Class13.WDgp);
        nD7h.AddArc(rectangle_0.Right - int_0, rectangle_0.Y, int_0, int_0, Class13.KDgS, Class13.SDgh);
        nD7h.AddArc(rectangle_0.Right - int_0, rectangle_0.Bottom - int_0, int_0, int_0, Class13.xDgl, Class13.KDgG);
        nD7h.AddArc(rectangle_0.X, rectangle_0.Bottom - int_0, int_0, int_0, Class13.hDgb, Class13.KDgv);
        nD7h.CloseFigure();
        return nD7h;
    }
}