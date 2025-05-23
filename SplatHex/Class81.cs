using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace SplatHex;
internal abstract class Class81 : ContainerControl {
    protected Graphics sDFA;
    protected Bitmap nDFf;
    private bool aDF6;
    private bool CDFx;
    private Rectangle FDF9;
    protected wB0 xDFc;
    private bool hDFy;
    private Point jDFr;
    private bool FDFq;
    private bool tDFk;
    private bool UDFM;
    private bool UDFu;
    private int VDFg;
    private int MDF2;
    private Message[] UDF3 = new Message[Class13.KDuI];
    private bool xDFd;
    private bool oDFH = true;
    private bool UDF4 = true;
    private bool UDF5 = true;
    private Color TDFs;
    private FormBorderStyle WDFZ;
    private FormStartPosition hDFa;
    private bool FDFj;
    private Image cDFz;
    private Dictionary<string, Color> ADLE = new Dictionary<string, Color>();
    private string HDLD;
    private bool eDLX;
    private Size tDLp;
    private bool qDLS;
    private int FDLh;
    private int BDLl;
    private int hDLG = Class13.KDuR;
    private bool nDLb;
    private bool SDLv;
    private Rectangle UDLo;
    private Size FDLt;
    private Point PDLV;
    private Point eDLO;
    private Bitmap qDLe;
    private Graphics pDL8;
    private SolidBrush kDLn;
    private SolidBrush zDLQ;
    private Point hDLF;
    private Size BDLL;
    private Point bDLJ;
    private LinearGradientBrush sDL7;
    private Rectangle GDLP;
    private GraphicsPath uDLi;
    private PathGradientBrush EDLm;
    private LinearGradientBrush kDL0;
    private Rectangle JDLI;
    private GraphicsPath QDLR;
    private Rectangle KDLC;
    public Class81() {
        SetStyle((ControlStyles)Class13.bDuC, value: true);
        tDLp = Size.Empty;
        Font = new Font(Class13.IDuK, Class13.LDuU);
        qDLe = new Bitmap(1, 1);
        pDL8 = Graphics.FromImage(qDLe);
        uDLi = new GraphicsPath();
        FDQc();
    }

    protected sealed override void OnHandleCreated(EventArgs e) {
        if (aDF6) {
            yDQ1();
        }

        FDQc();
        GjJ9();
        if (FDLh != 0) {
            base.Width = FDLh;
        }

        if (BDLl != 0) {
            base.Height = BDLl;
        }

        if (!nDLb) {
            base.Dock = DockStyle.Fill;
        }

        w(eDLX);
        if (eDLX && xDFd) {
            BackColor = Color.Transparent;
        }

        base.OnHandleCreated(e);
    }

    protected sealed override void OnParentChanged(EventArgs e) {
        base.OnParentChanged(e);
        if (base.Parent == null) {
            return;
        }

        qDLS = base.Parent is Form;
        if (!nDLb) {
            yDQ1();
            if (qDLS) {
                base.ParentForm.FormBorderStyle = WDFZ;
                base.ParentForm.TransparencyKey = TDFs;
                if (!base.DesignMode) {
                    base.ParentForm.Shown += pDQC;
                }
            }

            base.Parent.BackColor = BackColor;
        }

        gjJM();
        aDF6 = true;
        mDQy();
    }

    private void ADQR(bool bool_0) {
        AjJ0();
        if (bool_0) {
            Invalidate();
        }
    }

    protected sealed override void OnPaint(PaintEventArgs pevent) {
        if (base.Width != 0 && base.Height != 0) {
            if (eDLX && nDLb) {
                bjJe();
                pevent.Graphics.DrawImage(nDFf, 0, 0);
            } else {
                sDFA = pevent.Graphics;
                bjJe();
            }
        }
    }

    protected override void OnHandleDestroyed(EventArgs e) {
        Class24.uD7o(new Class24.MBX(ADQR));
        base.OnHandleDestroyed(e);
    }

    private void pDQC(object sender, EventArgs e) {
        if (!nDLb && !CDFx) {
            if (hDFa == FormStartPosition.CenterParent || hDFa == FormStartPosition.CenterScreen) {
                Rectangle bounds = Screen.PrimaryScreen.Bounds;
                Rectangle bounds2 = base.ParentForm.Bounds;
                base.ParentForm.Location = new Point(bounds.Width / 2 - bounds2.Width / 2, bounds.Height / 2 - bounds2.Width / 2);
            }

            CDFx = true;
        }
    }

    protected sealed override void OnSizeChanged(EventArgs e) {
        if (UDF4 && !nDLb) {
            FDF9 = new Rectangle(7, 7, base.Width - Class13.KDuT, hDLG - 7);
        }

        vDQ9();
        Invalidate();
        base.OnSizeChanged(e);
    }

    protected override void SetBoundsCore(int x, int y, int width, int height, BoundsSpecified specified) {
        if (FDLh != 0) {
            width = FDLh;
        }

        if (BDLl != 0) {
            height = BDLl;
        }

        base.SetBoundsCore(x, y, width, height, specified);
    }

    private void gDQK(wB0 wB0_0) {
        xDFc = wB0_0;
        Invalidate();
    }

    protected override void OnMouseMove(MouseEventArgs mevent) {
        if ((!qDLS || base.ParentForm.WindowState != FormWindowState.Maximized) && UDF5 && !nDLb) {
            CDQT();
        }

        base.OnMouseMove(mevent);
    }

    protected override void OnEnabledChanged(EventArgs e) {
        //IL_0018: Expected O, but got I4
        //IL_000f: Expected O, but got I4
        if (!base.Enabled) {
            gDQK((wB0)3);
        } else {
            gDQK((wB0)0);
        }

        base.OnEnabledChanged(e);
    }

    protected override void OnMouseEnter(EventArgs e) {
        //IL_0007: Expected O, but got I4
        gDQK((wB0)1);
        base.OnMouseEnter(e);
    }

    protected override void OnMouseUp(MouseEventArgs mevent) {
        //IL_0007: Expected O, but got I4
        gDQK((wB0)1);
        base.OnMouseUp(mevent);
    }

    protected override void OnMouseLeave(EventArgs e) {
        //IL_0007: Expected O, but got I4
        gDQK((wB0)0);
        if (GetChildAtPoint(PointToClient(Control.MousePosition)) != null && UDF5 && !nDLb) {
            Cursor = Cursors.Default;
            MDF2 = 0;
        }

        base.OnMouseLeave(e);
    }

    protected override void OnMouseDown(MouseEventArgs mevent) {
        //IL_0014: Expected O, but got I4
        if (mevent.Button == (MouseButtons)Class13.PDu1) {
            gDQK((wB0)2);
        }

        if ((!qDLS || base.ParentForm.WindowState != FormWindowState.Maximized) && !nDLb) {
            if (UDF4 && FDF9.Contains(mevent.Location)) {
                base.Capture = false;
                hDFy = true;
                DefWndProc(ref UDF3[0]);
            } else if (UDF5 && MDF2 != 0) {
                base.Capture = false;
                hDFy = true;
                DefWndProc(ref UDF3[MDF2]);
            }
        }

        base.OnMouseDown(mevent);
    }

    protected override void WndProc(ref Message m) {
        //IL_002a: Expected O, but got I4
        base.WndProc(ref m);
        if (!hDFy || m.Msg != Class13.KDuW) {
            return;
        }

        hDFy = false;
        gDQK((wB0)1);
        if (oDFH) {
            if (z()) {
                wDQW(new Rectangle(Point.Empty, base.Parent.Parent.Size));
            } else {
                wDQW(Screen.FromControl(base.Parent).WorkingArea);
            }
        }
    }

    private int JDQU() {
        jDFr = PointToClient(Control.MousePosition);
        FDFq = jDFr.X < 7;
        tDFk = jDFr.X > base.Width - 7;
        UDFM = jDFr.Y < 7;
        UDFu = jDFr.Y > base.Height - 7;
        if (FDFq && UDFM) {
            return 4;
        }

        if (FDFq && UDFu) {
            return 7;
        }

        if (tDFk && UDFM) {
            return 5;
        }

        if (tDFk && UDFu) {
            return 8;
        }

        if (FDFq) {
            return 1;
        }

        if (tDFk) {
            return 2;
        }

        if (UDFM) {
            return 3;
        }

        if (UDFu) {
            return 6;
        }

        return 0;
    }

    private void CDQT() {
        VDFg = JDQU();
        if (VDFg != MDF2) {
            MDF2 = VDFg;
            switch (MDF2) {
                case 0:
                    Cursor = Cursors.Default;
                    break;
                case 1:
                case 2:
                    Cursor = Cursors.SizeWE;
                    break;
                case 3:
                case 6:
                    Cursor = Cursors.SizeNS;
                    break;
                case 5:
                case 7:
                    Cursor = Cursors.SizeNESW;
                    break;
                case 4:
                case 8:
                    Cursor = Cursors.SizeNWSE;
                    break;
            }
        }
    }

    private void yDQ1() {
        UDF3[0] = Message.Create(base.Parent.Handle, Class13.pDuw, new IntPtr(2), IntPtr.Zero);
        for (int i = 1; i <= 8; i++) {
            UDF3[i] = Message.Create(base.Parent.Handle, Class13.zDuN, new IntPtr(i + Class13.XDuY), IntPtr.Zero);
        }
    }

    private void wDQW(Rectangle rectangle_0) {
        if (base.Parent.Width > rectangle_0.Width) {
            base.Parent.Width = rectangle_0.Width;
        }

        if (base.Parent.Height > rectangle_0.Height) {
            base.Parent.Height = rectangle_0.Height;
        }

        int num = base.Parent.Location.X;
        int num2 = base.Parent.Location.Y;
        if (num < rectangle_0.X) {
            num = rectangle_0.X;
        }

        if (num2 < rectangle_0.Y) {
            num2 = rectangle_0.Y;
        }

        int num3 = rectangle_0.X + rectangle_0.Width;
        int num4 = rectangle_0.Y + rectangle_0.Height;
        if (num + base.Parent.Width > num3) {
            num = num3 - base.Parent.Width;
        }

        if (num2 + base.Parent.Height > num4) {
            num2 = num4 - base.Parent.Height;
        }

        base.Parent.Location = new Point(num, num2);
    }

    [SpecialName]
    public virtual DockStyle get_Dock() {
        return base.Dock;
    }

    [SpecialName]
    public virtual void set_Dock(DockStyle value) {
        if (nDLb) {
            base.Dock = value;
        }
    }

    [SpecialName]
    public virtual Color get_BackColor() {
        return base.BackColor;
    }

    [SpecialName]
    public virtual void set_BackColor(Color value) {
        if (value == base.BackColor) {
            return;
        }

        if (!base.IsHandleCreated && nDLb && value == Color.Transparent) {
            xDFd = true;
            return;
        }

        base.BackColor = value;
        if (base.Parent != null) {
            if (!nDLb) {
                base.Parent.BackColor = value;
            }

            GjJ9();
        }
    }

    [SpecialName]
    public virtual Size get_MinimumSize() {
        return base.MinimumSize;
    }

    [SpecialName]
    public virtual void set_MinimumSize(Size value) {
        base.MinimumSize = value;
        if (base.Parent != null) {
            base.Parent.MinimumSize = value;
        }
    }

    [SpecialName]
    public virtual Size get_MaximumSize() {
        return base.MaximumSize;
    }

    [SpecialName]
    public virtual void set_MaximumSize(Size value) {
        base.MaximumSize = value;
        if (base.Parent != null) {
            base.Parent.MaximumSize = value;
        }
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
    public bool method_0() {
        return oDFH;
    }

    [SpecialName]
    public void method_1(bool bool_0) {
        oDFH = bool_0;
    }

    [SpecialName]
    public bool method_2() {
        return UDF4;
    }

    [SpecialName]
    public void a(bool bool_0) {
        UDF4 = bool_0;
    }

    [SpecialName]
    public bool b() {
        return UDF5;
    }

    [SpecialName]
    public void g(bool bool_0) {
        UDF5 = bool_0;
    }

    [SpecialName]
    public Color h() {
        if (qDLS && !nDLb) {
            return base.ParentForm.TransparencyKey;
        }

        return TDFs;
    }

    [SpecialName]
    public void i(Color color_0) {
        if (!(color_0 == TDFs)) {
            TDFs = color_0;
            if (qDLS && !nDLb) {
                base.ParentForm.TransparencyKey = color_0;
                GjJ9();
            }
        }
    }

    [SpecialName]
    public FormBorderStyle j() {
        if (qDLS && !nDLb) {
            return base.ParentForm.FormBorderStyle;
        }

        return WDFZ;
    }

    [SpecialName]
    public void k(FormBorderStyle formBorderStyle_0) {
        WDFZ = formBorderStyle_0;
        if (qDLS && !nDLb) {
            base.ParentForm.FormBorderStyle = formBorderStyle_0;
            if (formBorderStyle_0 != FormBorderStyle.None) {
                a(bool_0: false);
                g(bool_0: false);
            }
        }
    }

    [SpecialName]
    public FormStartPosition l() {
        if (qDLS && !nDLb) {
            return base.ParentForm.StartPosition;
        }

        return hDFa;
    }

    [SpecialName]
    public void m(FormStartPosition formStartPosition_0) {
        hDFa = formStartPosition_0;
        if (qDLS && !nDLb) {
            base.ParentForm.StartPosition = formStartPosition_0;
        }
    }

    [SpecialName]
    public bool n() {
        return FDFj;
    }

    [SpecialName]
    public void o(bool bool_0) {
        FDFj = bool_0;
        Invalidate();
    }

    [SpecialName]
    public Image p() {
        return cDFz;
    }

    [SpecialName]
    public void q(Image image_0) {
        if (image_0 == null) {
            tDLp = Size.Empty;
        } else {
            tDLp = image_0.Size;
        }

        cDFz = image_0;
        Invalidate();
    }

    [SpecialName]
    public uBw[] r() {
        List<uBw> list = new List<uBw>();
        Dictionary<string, Color>.Enumerator enumerator = ADLE.GetEnumerator();
        while (enumerator.MoveNext()) {
            list.Add(new uBw(enumerator.Current.Key, enumerator.Current.Value));
        }

        return list.ToArray();
    }

    [SpecialName]
    public void s(uBw[] uBw_0) {
        for (int i = 0; i < uBw_0.Length; i++) {
            uBw uBw = uBw_0[i];
            if (ADLE.ContainsKey(uBw.method_0())) {
                ADLE[uBw.method_0()] = uBw.method_1();
            }
        }

        FDQc();
        GjJ9();
        Invalidate();
    }

    [SpecialName]
    public string t() {
        return HDLD;
    }

    [SpecialName]
    public void u(string string_0) {
        if (string_0 == HDLD) {
            return;
        }

        byte[] array = null;
        uBw[] array2 = r();
        try {
            array = Convert.FromBase64String(string_0);
            for (int i = 0; i <= array2.Length - 1; i++) {
                array2[i].method_2(Color.FromArgb(BitConverter.ToInt32(array, i * 4)));
            }
        } catch {
            return;
        }

        HDLD = string_0;
        s(array2);
        GjJ9();
        Invalidate();
    }

    [SpecialName]
    public bool v() {
        return eDLX;
    }

    [SpecialName]
    public void w(bool bool_0) {
        eDLX = bool_0;
        if (base.IsHandleCreated || nDLb) {
            if (!bool_0 && BackColor.A != Class13.tDuB) {
                throw new Exception(Class13.sDuA);
            }

            SetStyle(ControlStyles.Opaque, !bool_0);
            SetStyle((ControlStyles)Class13.eDuf, bool_0);
            vDQ9();
            Invalidate();
        }
    }

    [SpecialName]
    protected Size x() {
        return tDLp;
    }

    [SpecialName]
    protected bool y() {
        return qDLS;
    }

    [SpecialName]
    protected bool z() {
        if (base.Parent == null) {
            return false;
        }

        return base.Parent.Parent != null;
    }

    [SpecialName]
    protected int A() {
        return FDLh;
    }

    [SpecialName]
    protected void B(int int_0) {
        FDLh = int_0;
        if (A() != 0 && base.IsHandleCreated) {
            base.Width = A();
        }
    }

    [SpecialName]
    protected int C() {
        return BDLl;
    }

    [SpecialName]
    protected void D(int int_0) {
        BDLl = int_0;
        if (C() != 0 && base.IsHandleCreated) {
            base.Height = C();
        }
    }

    [SpecialName]
    protected int E() {
        return hDLG;
    }

    [SpecialName]
    protected void F(int int_0) {
        hDLG = int_0;
        if (!nDLb) {
            FDF9 = new Rectangle(7, 7, base.Width - Class13.PDu6, int_0 - 7);
            Invalidate();
        }
    }

    [SpecialName]
    protected bool G() {
        return nDLb;
    }

    [SpecialName]
    protected void H(bool bool_0) {
        nDLb = bool_0;
        w(eDLX);
        if (eDLX && xDFd) {
            BackColor = Color.Transparent;
        }

        vDQ9();
        Invalidate();
    }

    [SpecialName]
    protected bool I() {
        return SDLv;
    }

    [SpecialName]
    protected void J(bool bool_0) {
        SDLv = bool_0;
        mDQy();
    }

    protected Pen kDQw(string string_0) {
        return new Pen(ADLE[string_0]);
    }

    protected Pen CDQN(string string_0, float float_0) {
        return new Pen(ADLE[string_0], float_0);
    }

    protected SolidBrush cDQY(string string_0) {
        return new SolidBrush(ADLE[string_0]);
    }

    protected Color JDQB(string string_0) {
        return ADLE[string_0];
    }

    protected void aDQA(string string_0, Color color_0) {
        if (!ADLE.ContainsKey(string_0)) {
            ADLE.Add(string_0, color_0);
        } else {
            ADLE[string_0] = color_0;
        }
    }

    protected void LDQf(string string_0, byte byte_0, byte byte_1, byte byte_2) {
        aDQA(string_0, Color.FromArgb(byte_0, byte_1, byte_2));
    }

    protected void PDQ6(string string_0, byte byte_0, byte byte_1, byte byte_2, byte byte_3) {
        aDQA(string_0, Color.FromArgb(byte_0, byte_1, byte_2, byte_3));
    }

    protected void yDQx(string string_0, byte byte_0, Color color_0) {
        aDQA(string_0, Color.FromArgb(byte_0, color_0));
    }

    private void vDQ9() {
        if (eDLX && nDLb) {
            if (base.Width != 0 && base.Height != 0) {
                nDFf = new Bitmap(base.Width, base.Height, (PixelFormat)Class13.jDux);
                sDFA = Graphics.FromImage(nDFf);
            }
        } else {
            sDFA = null;
            nDFf = null;
        }
    }

    private void FDQc() {
        MemoryStream memoryStream = new MemoryStream(ADLE.Count * 4);
        uBw[] array = r();
        foreach (uBw uBw in array) {
            memoryStream.Write(BitConverter.GetBytes(uBw.method_1().ToArgb()), 0, 4);
        }

        memoryStream.Close();
        HDLD = Convert.ToBase64String(memoryStream.ToArray());
    }

    private void mDQy() {
        if (!base.DesignMode && aDF6) {
            if (SDLv) {
                Class24.eD7v(new Class24.MBX(ADQR));
            } else {
                Class24.uD7o(new Class24.MBX(ADQR));
            }
        }
    }

    protected abstract void GjJ9();
    protected abstract void bjJe();
    protected virtual void gjJM() {
    }

    protected virtual void AjJ0() {
    }

    protected Rectangle kDQr(Rectangle rectangle_0, int int_0) {
        UDLo = new Rectangle(rectangle_0.X + int_0, rectangle_0.Y + int_0, rectangle_0.Width - int_0 * 2, rectangle_0.Height - int_0 * 2);
        return UDLo;
    }

    protected Size FDQq(Size size_0, int int_0) {
        FDLt = new Size(size_0.Width + int_0, size_0.Height + int_0);
        return FDLt;
    }

    protected Point xDQk(Point point_0, int int_0) {
        PDLV = new Point(point_0.X + int_0, point_0.Y + int_0);
        return PDLV;
    }

    protected Point zDQM(Rectangle rectangle_0, Rectangle rectangle_1) {
        eDLO = new Point(rectangle_0.Width / 2 - rectangle_1.Width / 2 + rectangle_0.X + rectangle_1.X, rectangle_0.Height / 2 - rectangle_1.Height / 2 + rectangle_0.Y + rectangle_1.Y);
        return eDLO;
    }

    protected Point nDQu(Rectangle rectangle_0, Size size_0) {
        eDLO = new Point(rectangle_0.Width / 2 - size_0.Width / 2 + rectangle_0.X, rectangle_0.Height / 2 - size_0.Height / 2 + rectangle_0.Y);
        return eDLO;
    }

    protected Point wDQg(Rectangle rectangle_0) {
        return cDQH(base.Width, base.Height, rectangle_0.Width, rectangle_0.Height);
    }

    protected Point KDQ2(Size size_0) {
        return cDQH(base.Width, base.Height, size_0.Width, size_0.Height);
    }

    protected Point XDQ3(int int_0, int int_1) {
        return cDQH(base.Width, base.Height, int_0, int_1);
    }

    protected Point SDQd(Size size_0, Size size_1) {
        return cDQH(size_0.Width, size_0.Height, size_1.Width, size_1.Height);
    }

    protected Point cDQH(int int_0, int int_1, int int_2, int int_3) {
        eDLO = new Point(int_0 / 2 - int_2 / 2, int_1 / 2 - int_3 / 2);
        return eDLO;
    }

    protected Size CDQ4() {
        lock (pDL8) {
            return pDL8.MeasureString(Text, Font, base.Width).ToSize();
        }
    }

    protected Size tDQ5(string string_0) {
        lock (pDL8) {
            return pDL8.MeasureString(string_0, Font, base.Width).ToSize();
        }
    }

    protected void KDQs(Color color_0, int int_0, int int_1) {
        if (!eDLX) {
            kDLn = new SolidBrush(color_0);
            sDFA.FillRectangle(kDLn, int_0, int_1, 1, 1);
        } else {
            nDFf.SetPixel(int_0, int_1, color_0);
        }
    }

    protected void eDQZ(Color color_0, int int_0) {
        oDQj(color_0, 0, 0, base.Width, base.Height, int_0);
    }

    protected void EDQa(Color color_0, Rectangle rectangle_0, int int_0) {
        oDQj(color_0, rectangle_0.X, rectangle_0.Y, rectangle_0.Width, rectangle_0.Height, int_0);
    }

    protected void oDQj(Color color_0, int int_0, int int_1, int int_2, int int_3, int int_4) {
        ODFD(color_0, int_0 + int_4, int_1 + int_4, int_2 - int_4 * 2, int_3 - int_4 * 2);
    }

    protected void mDQz(Color color_0) {
        ODFD(color_0, 0, 0, base.Width, base.Height);
    }

    protected void bDFE(Color color_0, Rectangle rectangle_0) {
        ODFD(color_0, rectangle_0.X, rectangle_0.Y, rectangle_0.Width, rectangle_0.Height);
    }

    protected void ODFD(Color color_0, int int_0, int int_1, int int_2, int int_3) {
        if (!FDFj) {
            if (eDLX) {
                nDFf.SetPixel(int_0, int_1, color_0);
                nDFf.SetPixel(int_0 + (int_2 - 1), int_1, color_0);
                nDFf.SetPixel(int_0, int_1 + (int_3 - 1), color_0);
                nDFf.SetPixel(int_0 + (int_2 - 1), int_1 + (int_3 - 1), color_0);
            } else {
                zDLQ = new SolidBrush(color_0);
                sDFA.FillRectangle(zDLQ, int_0, int_1, 1, 1);
                sDFA.FillRectangle(zDLQ, int_0 + (int_2 - 1), int_1, 1, 1);
                sDFA.FillRectangle(zDLQ, int_0, int_1 + (int_3 - 1), 1, 1);
                sDFA.FillRectangle(zDLQ, int_0 + (int_2 - 1), int_1 + (int_3 - 1), 1, 1);
            }
        }
    }

    protected void vDFX(Pen pen_0, int int_0) {
        WDFS(pen_0, 0, 0, base.Width, base.Height, int_0);
    }

    protected void tDFp(Pen pen_0, Rectangle rectangle_0, int int_0) {
        WDFS(pen_0, rectangle_0.X, rectangle_0.Y, rectangle_0.Width, rectangle_0.Height, int_0);
    }

    protected void WDFS(Pen pen_0, int int_0, int int_1, int int_2, int int_3, int int_4) {
        YDFG(pen_0, int_0 + int_4, int_1 + int_4, int_2 - int_4 * 2, int_3 - int_4 * 2);
    }

    protected void mDFh(Pen pen_0) {
        YDFG(pen_0, 0, 0, base.Width, base.Height);
    }

    protected void VDFl(Pen pen_0, Rectangle rectangle_0) {
        YDFG(pen_0, rectangle_0.X, rectangle_0.Y, rectangle_0.Width, rectangle_0.Height);
    }

    protected void YDFG(Pen pen_0, int int_0, int int_1, int int_2, int int_3) {
        sDFA.DrawRectangle(pen_0, int_0, int_1, int_2 - 1, int_3 - 1);
    }

    protected void EDFb(Brush brush_0, HorizontalAlignment horizontalAlignment_0, int int_0, int int_1) {
        QDFv(brush_0, Text, horizontalAlignment_0, int_0, int_1);
    }

    protected void QDFv(Brush brush_0, string string_0, HorizontalAlignment horizontalAlignment_0, int int_0, int int_1) {
        if (string_0.Length != 0) {
            BDLL = tDQ5(string_0);
            hDLF = new Point(base.Width / 2 - BDLL.Width / 2, E() / 2 - BDLL.Height / 2);
            switch (horizontalAlignment_0) {
                case HorizontalAlignment.Left:
                    sDFA.DrawString(string_0, Font, brush_0, int_0, hDLF.Y + int_1);
                    break;
                case HorizontalAlignment.Right:
                    sDFA.DrawString(string_0, Font, brush_0, base.Width - BDLL.Width - int_0, hDLF.Y + int_1);
                    break;
                case HorizontalAlignment.Center:
                    sDFA.DrawString(string_0, Font, brush_0, hDLF.X + int_0, hDLF.Y + int_1);
                    break;
            }
        }
    }

    protected void sDFo(Brush brush_0, Point point_0) {
        if (Text.Length != 0) {
            sDFA.DrawString(Text, Font, brush_0, point_0);
        }
    }

    protected void DDFt(Brush brush_0, int int_0, int int_1) {
        if (Text.Length != 0) {
            sDFA.DrawString(Text, Font, brush_0, int_0, int_1);
        }
    }

    protected void PDFV(HorizontalAlignment horizontalAlignment_0, int int_0, int int_1) {
        iDFO(cDFz, horizontalAlignment_0, int_0, int_1);
    }

    protected void iDFO(Image image_0, HorizontalAlignment horizontalAlignment_0, int int_0, int int_1) {
        if (image_0 != null) {
            bDLJ = new Point(base.Width / 2 - image_0.Width / 2, E() / 2 - image_0.Height / 2);
            switch (horizontalAlignment_0) {
                case HorizontalAlignment.Left:
                    sDFA.DrawImage(image_0, int_0, bDLJ.Y + int_1, image_0.Width, image_0.Height);
                    break;
                case HorizontalAlignment.Right:
                    sDFA.DrawImage(image_0, base.Width - image_0.Width - int_0, bDLJ.Y + int_1, image_0.Width, image_0.Height);
                    break;
                case HorizontalAlignment.Center:
                    sDFA.DrawImage(image_0, bDLJ.X + int_0, bDLJ.Y + int_1, image_0.Width, image_0.Height);
                    break;
            }
        }
    }

    protected void yDFe(Point point_0) {
        uDFQ(cDFz, point_0.X, point_0.Y);
    }

    protected void yDF8(int int_0, int int_1) {
        uDFQ(cDFz, int_0, int_1);
    }

    protected void jDFn(Image image_0, Point point_0) {
        uDFQ(image_0, point_0.X, point_0.Y);
    }

    protected void uDFQ(Image image_0, int int_0, int int_1) {
        if (image_0 != null) {
            sDFA.DrawImage(image_0, int_0, int_1, image_0.Width, image_0.Height);
        }
    }

    protected void CDFF(ColorBlend colorBlend_0, int int_0, int int_1, int int_2, int int_3) {
        GDLP = new Rectangle(int_0, int_1, int_2, int_3);
        IDFJ(colorBlend_0, GDLP);
    }

    protected void qDFL(ColorBlend colorBlend_0, int int_0, int int_1, int int_2, int int_3, float float_0) {
        GDLP = new Rectangle(int_0, int_1, int_2, int_3);
        xDF7(colorBlend_0, GDLP, float_0);
    }

    protected void IDFJ(ColorBlend colorBlend_0, Rectangle rectangle_0) {
        sDL7 = new LinearGradientBrush(rectangle_0, Color.Empty, Color.Empty, Class13.uDu9);
        sDL7.InterpolationColors = colorBlend_0;
        sDFA.FillRectangle(sDL7, rectangle_0);
    }

    protected void xDF7(ColorBlend colorBlend_0, Rectangle rectangle_0, float float_0) {
        sDL7 = new LinearGradientBrush(rectangle_0, Color.Empty, Color.Empty, float_0);
        sDL7.InterpolationColors = colorBlend_0;
        sDFA.FillRectangle(sDL7, rectangle_0);
    }

    protected void zDFP(Color color_0, Color color_1, int int_0, int int_1, int int_2, int int_3) {
        GDLP = new Rectangle(int_0, int_1, int_2, int_3);
        hDFm(color_0, color_1, GDLP);
    }

    protected void ADFi(Color color_0, Color color_1, int int_0, int int_1, int int_2, int int_3, float float_0) {
        GDLP = new Rectangle(int_0, int_1, int_2, int_3);
        aDF0(color_0, color_1, GDLP, float_0);
    }

    protected void hDFm(Color color_0, Color color_1, Rectangle rectangle_0) {
        sDL7 = new LinearGradientBrush(rectangle_0, color_0, color_1, Class13.GDuc);
        sDFA.FillRectangle(sDL7, rectangle_0);
    }

    protected void aDF0(Color color_0, Color color_1, Rectangle rectangle_0, float float_0) {
        sDL7 = new LinearGradientBrush(rectangle_0, color_0, color_1, float_0);
        sDFA.FillRectangle(sDL7, rectangle_0);
    }

    public void NDFI(ColorBlend colorBlend_0, int int_0, int int_1, int int_2, int int_3) {
        JDLI = new Rectangle(int_0, int_1, int_2, int_3);
        MDFT(colorBlend_0, JDLI, int_2 / 2, int_3 / 2);
    }

    public void rDFR(ColorBlend colorBlend_0, int int_0, int int_1, int int_2, int int_3, Point point_0) {
        JDLI = new Rectangle(int_0, int_1, int_2, int_3);
        MDFT(colorBlend_0, JDLI, point_0.X, point_0.Y);
    }

    public void aDFC(ColorBlend colorBlend_0, int int_0, int int_1, int int_2, int int_3, int int_4, int int_5) {
        JDLI = new Rectangle(int_0, int_1, int_2, int_3);
        MDFT(colorBlend_0, JDLI, int_4, int_5);
    }

    public void RDFK(ColorBlend colorBlend_0, Rectangle rectangle_0) {
        MDFT(colorBlend_0, rectangle_0, rectangle_0.Width / 2, rectangle_0.Height / 2);
    }

    public void qDFU(ColorBlend colorBlend_0, Rectangle rectangle_0, Point point_0) {
        MDFT(colorBlend_0, rectangle_0, point_0.X, point_0.Y);
    }

    public void MDFT(ColorBlend colorBlend_0, Rectangle rectangle_0, int int_0, int int_1) {
        uDLi.Reset();
        uDLi.AddEllipse(rectangle_0.X, rectangle_0.Y, rectangle_0.Width - 1, rectangle_0.Height - 1);
        EDLm = new PathGradientBrush(uDLi);
        EDLm.CenterPoint = new Point(rectangle_0.X + int_0, rectangle_0.Y + int_1);
        EDLm.InterpolationColors = colorBlend_0;
        if (sDFA.SmoothingMode == SmoothingMode.AntiAlias) {
            sDFA.FillEllipse(EDLm, rectangle_0.X + 1, rectangle_0.Y + 1, rectangle_0.Width - 3, rectangle_0.Height - 3);
        } else {
            sDFA.FillEllipse(EDLm, rectangle_0);
        }
    }

    protected void MDF1(Color color_0, Color color_1, int int_0, int int_1, int int_2, int int_3) {
        JDLI = new Rectangle(int_0, int_1, int_2, int_3);
        pDFw(color_0, color_1, GDLP);
    }

    protected void BDFW(Color color_0, Color color_1, int int_0, int int_1, int int_2, int int_3, float float_0) {
        JDLI = new Rectangle(int_0, int_1, int_2, int_3);
        bDFN(color_0, color_1, GDLP, float_0);
    }

    protected void pDFw(Color color_0, Color color_1, Rectangle rectangle_0) {
        kDL0 = new LinearGradientBrush(rectangle_0, color_0, color_1, Class13.cDuy);
        sDFA.FillRectangle(sDL7, rectangle_0);
    }

    protected void bDFN(Color color_0, Color color_1, Rectangle rectangle_0, float float_0) {
        kDL0 = new LinearGradientBrush(rectangle_0, color_0, color_1, float_0);
        sDFA.FillEllipse(sDL7, rectangle_0);
    }

    public GraphicsPath zDFY(int int_0, int int_1, int int_2, int int_3, int int_4) {
        KDLC = new Rectangle(int_0, int_1, int_2, int_3);
        return yDFB(KDLC, int_4);
    }

    public GraphicsPath yDFB(Rectangle rectangle_0, int int_0) {
        QDLR = new GraphicsPath(FillMode.Winding);
        QDLR.AddArc(rectangle_0.X, rectangle_0.Y, int_0, int_0, Class13.RDur, Class13.PDuq);
        QDLR.AddArc(rectangle_0.Right - int_0, rectangle_0.Y, int_0, int_0, Class13.NDuk, Class13.gDuM);
        QDLR.AddArc(rectangle_0.Right - int_0, rectangle_0.Bottom - int_0, int_0, int_0, Class13.TDuu, Class13.cDug);
        QDLR.AddArc(rectangle_0.X, rectangle_0.Bottom - int_0, int_0, int_0, Class13.IDu2, Class13.nDu3);
        QDLR.CloseFigure();
        return QDLR;
    }
}