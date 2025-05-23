using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SplatHex;
public class Class109 : Form {
    public int JGq;
    public int NGk;
    public int qGM;
    public int WGu;
    private Class33 aGg;
    private int lG2;
    private int HG3;
    public string lGd;
    public string EGH;
    public string bG4;
    public string xG5;
    public string gGs;
    public string IGZ;
    public readonly int[] iGa;
    private readonly object sGj;
    private IDisposable hGz;
    private TabControl GbE;
    private TabPage xbD;
    private Class35 wbX;
    private TabPage wbp;
    private Class35 PbS;
    private TabPage nbh;
    private Class35 xbl;
    private GroupBox TbG;
    private PictureBox Abb;
    private Label Ibv;
    private DateTimePicker ibo;
    private NumericUpDown kbt;
    private NumericUpDown XbV;
    private Label KbO;
    private Label gbe;
    private Label Pb8;
    private CheckBox ybn;
    private Label abQ;
    private NumericUpDown jbF;
    private GroupBox GbL;
    private Button FbJ;
    private Button Mb7;
    private Button LbP;
    private Button qbi;
    private Label Rbm;
    private Button ab0;
    private Label JbI;
    private Label xbR;
    private GroupBox NbC;
    private Button bbK;
    private Button IbU;
    private Button MbT;
    private Button Wb1;
    public Class109(string string_0, Dictionary<int, Class25>[] dictionary_0, Class33[] x0_0, Class33[] x0_1, Class33[] x0_2, int[] int_0) {
        GGr();
        Text = string_0;
        sGj = dictionary_0;
        GbL.Enabled = false;
        NbC.Enabled = false;
        TbG.Enabled = false;
        iGa = int_0;
        xGI(x0_0, x0_1, x0_2);
    }

    private void xGI(Class33[] x0_0, Class33[] x0_1, Class33[] x0_2) {
        AGR(x0_0, "headGear", 0, wbX);
        AGR(x0_1, "clothesGear", 1, PbS);
        AGR(x0_2, "shoesGear", 2, xbl);
    }

    private void AGR(Class33[] x0_0, string string_0, int int_0, Class35 c7_0) {
        Dictionary<int, Class25> dictionary = (Dictionary<int, Class25>)((object[])sGj)[int_0];
        foreach (Class33 x in x0_0) {
            Button button = new Button();
            if (x.hXP <= -1 || !dictionary.ContainsKey(x.hXP)) {
                continue;
            }

            button.BackgroundImage = Class4.ADq(x.hXP, dictionary);
            button.AccessibleDescription = Class4.SDr(x.hXP, dictionary);
            button.BackgroundImageLayout = ImageLayout.Zoom;
            button.Size = new Size(80, 80);
            button.Name = string_0 + x.hXP;
            button.Tag = x;
            c7_0.Controls.Add(button);
            button.Click += kGC;
            if (Class67.l8l == 0) {
                if (int_0 == 0 && x.hXP == Class108.io2.MtS) {
                    button.BackColor = Color.Red;
                    c7_0.Controls.SetChildIndex(button, 0);
                    lGd = button.Name;
                }

                if (!Class4.rDg(x.hXP, Class117.Sox)) {
                    button.Image = Resources.warning;
                    button.ImageAlign = ContentAlignment.TopRight;
                }

                if (int_0 == 1 && x.hXP == Class108.io2.yth) {
                    button.BackColor = Color.Red;
                    c7_0.Controls.SetChildIndex(button, 0);
                    bG4 = button.Name;
                }

                if (!Class4.rDg(x.hXP, Class117.Qo9)) {
                    button.Image = Resources.warning;
                    button.ImageAlign = ContentAlignment.TopRight;
                }

                if (int_0 == 2 && x.hXP == Class108.io2.btl) {
                    button.BackColor = Color.Red;
                    c7_0.Controls.SetChildIndex(button, 0);
                    gGs = button.Name;
                }

                if (!Class4.rDg(x.hXP, Class117.Yoc)) {
                    button.Image = Resources.warning;
                    button.ImageAlign = ContentAlignment.TopRight;
                }
            } else if (Class67.l8l == 1) {
                if (int_0 == 0 && x.hXP == Class26.QXu.gph) {
                    button.BackColor = Color.Red;
                    c7_0.Controls.SetChildIndex(button, 0);
                    lGd = button.Name;
                }

                if (int_0 == 1 && x.hXP == Class26.QXu.Spl) {
                    button.BackColor = Color.Red;
                    c7_0.Controls.SetChildIndex(button, 0);
                    bG4 = button.Name;
                }

                if (int_0 == 2 && x.hXP == Class26.QXu.mpG) {
                    button.BackColor = Color.Red;
                    c7_0.Controls.SetChildIndex(button, 0);
                    gGs = button.Name;
                }

                if (!Class4.bD2(x.hXP)) {
                    button.Image = Resources.warning;
                    button.ImageAlign = ContentAlignment.TopRight;
                }
            }
        }
    }

    private void kGC(object sender, EventArgs e) {
        Abb.BackgroundImage = ((Button)sender).BackgroundImage;
        TbG.Text = ((Button)sender).AccessibleDescription;
        lG2 = GbE.SelectedIndex;
        VGU((Class33)((Button)sender).Tag);
        GbL.Enabled = true;
        NbC.Enabled = true;
        TbG.Enabled = true;
        if (lG2 == 0) {
            EGH = ((Button)sender).Name;
        } else if (lG2 == 1) {
            xG5 = ((Button)sender).Name;
        } else {
            IGZ = ((Button)sender).Name;
        }

        if (((Button)sender).BackColor == Color.Red) {
            MbT.Enabled = false;
            bbK.Enabled = false;
        } else {
            MbT.Enabled = true;
            bbK.Enabled = true;
        }
    }

    private void MGK() {
        if (((Dictionary<int, Class25>)((object[])sGj)[lG2])[aGg.hXP].CjTP()) {
            if (aGg.RX7 == 4) {
                jbF.Maximum = 0m;
            } else {
                jbF.Maximum = 7499m;
            }
        } else {
            jbF.Maximum = iGa[4 * ((Dictionary<int, Class25>)((object[])sGj)[lG2])[aGg.hXP].YDN + aGg.RX7 - 1];
        }
    }

    private void VGU(Class33 x0_0) {
        NbC.Enabled = true;
        aGg = x0_0;
        XbV.Maximum = 4m;
        kbt.Maximum = 4m;
        XbV.Value = x0_0.xXi;
        kbt.Value = 1m;
        kbt.Maximum = x0_0.xXi;
        kbt.Value = x0_0.RX7;
        jbF.Value = 0m;
        MGK();
        jbF.Value = x0_0.iXC;
        ybn.Checked = x0_0.CXU == 0;
        ibo.Value = Class115.LHu(x0_0.UXK);
        JGq = x0_0.HXm;
        NGk = x0_0.vX0;
        qGM = x0_0.wXI;
        WGu = x0_0.GXR;
        VGT();
    }

    private void VGT() {
        FbJ.BackgroundImage = Class38.LnD(aGg, JGq);
        Mb7.BackgroundImage = (Image)((Dictionary<int, Class25>)((object[])sGj)[lG2])[aGg.hXP].sDf.sDy;
        LbP.BackgroundImage = Class38.LnD(aGg, NGk);
        ab0.BackgroundImage = Class38.LnD(aGg, qGM);
        qbi.BackgroundImage = Class38.LnD(aGg, WGu);
        if (!(kbt.Value < 4m)) {
            qbi.BackColor = Color.Black;
        } else {
            qbi.BackColor = Color.Gray;
        }

        if (kbt.Value < 3m) {
            ab0.BackColor = Color.Gray;
        } else {
            ab0.BackColor = Color.Black;
        }

        if (kbt.Value < 2m) {
            LbP.BackColor = Color.Gray;
        } else {
            LbP.BackColor = Color.Black;
        }
    }

    private void gG1(object sender, MouseEventArgs e) {
        _ = ((Dictionary<int, Class25>)((object[])sGj)[lG2])[aGg.hXP];
        if (e.Button == MouseButtons.Left) {
            JGq = ((Dictionary<int, Class25>)((object[])sGj)[lG2])[aGg.hXP].VjTo(JGq);
            VGT();
        }

        if (e.Button == MouseButtons.Right) {
            JGq = ((Dictionary<int, Class25>)((object[])sGj)[lG2])[aGg.hXP].YjT9(JGq);
            VGT();
        }
    }

    private void xGW(object sender, MouseEventArgs e) {
        if (e.Button == MouseButtons.Left) {
            NGk = ((Dictionary<int, Class25>)((object[])sGj)[lG2])[aGg.hXP].tjTc(NGk);
            VGT();
        }

        if (e.Button == MouseButtons.Right) {
            NGk = ((Dictionary<int, Class25>)((object[])sGj)[lG2])[aGg.hXP].bjTe(NGk);
            VGT();
        }
    }

    private void cGw(object sender, MouseEventArgs e) {
        if (e.Button == MouseButtons.Left) {
            qGM = ((Dictionary<int, Class25>)((object[])sGj)[lG2])[aGg.hXP].tjTc(qGM);
            VGT();
        }

        if (e.Button == MouseButtons.Right) {
            qGM = ((Dictionary<int, Class25>)((object[])sGj)[lG2])[aGg.hXP].bjTe(qGM);
            VGT();
        }
    }

    private void pGN(object sender, MouseEventArgs e) {
        if (e.Button == MouseButtons.Left) {
            WGu = ((Dictionary<int, Class25>)((object[])sGj)[lG2])[aGg.hXP].tjTc(WGu);
            VGT();
        }

        if (e.Button == MouseButtons.Right) {
            WGu = ((Dictionary<int, Class25>)((object[])sGj)[lG2])[aGg.hXP].bjTe(WGu);
            VGT();
        }
    }

    private void TGY(object sender, EventArgs e) {
        aGg.RX7 = (int)kbt.Value;
        aGg.xXi = (int)XbV.Value;
        aGg.iXC = (int)jbF.Value;
        aGg.CXU = ((!ybn.Checked) ? 1 : 0);
        aGg.HXm = JGq;
        aGg.vX0 = NGk;
        aGg.wXI = qGM;
        aGg.GXR = WGu;
        aGg.UXK = Class115.DHg(ibo);
    }

    private void QGB(object sender, EventArgs e) {
        if (aGg != null) {
            XbV.Maximum = 4m;
            kbt.Maximum = XbV.Value;
            jbF.Value = 0m;
            aGg.iXC = 0;
            MGK();
            jbF.Value = aGg.iXC;
            VGT();
        }
    }

    private void RGA(object sender, EventArgs e) {
        if (aGg != null) {
            XbV.Maximum = 4m;
            kbt.Maximum = 99999m;
            kbt.Value = Math.Min(kbt.Value, XbV.Value);
            kbt.Maximum = XbV.Value;
            jbF.Value = 0m;
            MGK();
            jbF.Value = aGg.iXC;
        }
    }

    private void tGf(object sender, EventArgs e) {
        Class25 aT = ((Dictionary<int, Class25>)((object[])sGj)[lG2])[aGg.hXP];
        if (Class25 is Class117.vrh) {
            if (Class25.tD6 == 0) {
                base.Controls.Find(lGd, searchAllChildren: true)[0].BackColor = Color.Transparent;
                base.Controls.Find(EGH, searchAllChildren: true)[0].BackColor = Color.Red;
                Class108.io2.MtS = Class25.CDw;
                lGd = EGH;
            } else if (Class25.tD6 == 1) {
                base.Controls.Find(bG4, searchAllChildren: true)[0].BackColor = Color.Transparent;
                base.Controls.Find(xG5, searchAllChildren: true)[0].BackColor = Color.Red;
                Class108.io2.yth = Class25.CDw;
                bG4 = xG5;
            } else {
                base.Controls.Find(gGs, searchAllChildren: true)[0].BackColor = Color.Transparent;
                base.Controls.Find(IGZ, searchAllChildren: true)[0].BackColor = Color.Red;
                Class108.io2.btl = Class25.CDw;
                gGs = IGZ;
            }
        } else if (Class25 is Class85.PQ) {
            if (Class25.tD6 == 0) {
                base.Controls.Find(lGd, searchAllChildren: true)[0].BackColor = Color.Transparent;
                base.Controls.Find(EGH, searchAllChildren: true)[0].BackColor = Color.Red;
                Class26.QXu.gph = Class25.CDw;
                lGd = EGH;
            } else if (Class25.tD6 == 1) {
                base.Controls.Find(bG4, searchAllChildren: true)[0].BackColor = Color.Transparent;
                base.Controls.Find(xG5, searchAllChildren: true)[0].BackColor = Color.Red;
                Class26.QXu.Spl = Class25.CDw;
                bG4 = xG5;
            } else {
                base.Controls.Find(gGs, searchAllChildren: true)[0].BackColor = Color.Transparent;
                base.Controls.Find(IGZ, searchAllChildren: true)[0].BackColor = Color.Red;
                Class26.QXu.mpG = Class25.CDw;
                gGs = IGZ;
            }
        }
    }

    private void zG6(object sender, EventArgs e) {
        if (Class67.l8l == 0) {
            if (lG2 == 0) {
                Class4.ODH(Class108.Jo3, aGg);
                wbX.Controls.Remove(base.Controls.Find(EGH, searchAllChildren: true)[0]);
            } else if (lG2 == 1) {
                Class4.ODH(Class108.Yod, aGg);
                PbS.Controls.Remove(base.Controls.Find(xG5, searchAllChildren: true)[0]);
            } else if (lG2 == 2) {
                Class4.ODH(Class108.YoH, aGg);
                xbl.Controls.Remove(base.Controls.Find(IGZ, searchAllChildren: true)[0]);
            }
        } else if (Class67.l8l == 1) {
            if (lG2 == 0) {
                Class4.GD4(Class26.iXg, aGg);
                wbX.Controls.Remove(base.Controls.Find(EGH, searchAllChildren: true)[0]);
            } else if (lG2 == 1) {
                Class4.GD4(Class26.rX2, aGg);
                PbS.Controls.Remove(base.Controls.Find(xG5, searchAllChildren: true)[0]);
            } else if (lG2 == 2) {
                Class4.GD4(Class26.pX3, aGg);
                xbl.Controls.Remove(base.Controls.Find(IGZ, searchAllChildren: true)[0]);
            }
        }
    }

    private void kGx(Class108.fr2[] fr2_0, int int_0, string string_0, int int_1, Class35 c7_0) {
        int num = Class115.nHs(0, 12);
        Dictionary<int, Class25> dictionary_ = (Dictionary<int, Class25>)((object[])sGj)[int_1];
        Button button = new Button();
        button.BackgroundImage = Class4.ADq(int_0, dictionary_);
        button.AccessibleDescription = Class4.SDr(int_0, dictionary_);
        button.BackgroundImageLayout = ImageLayout.Zoom;
        button.Size = new Size(80, 80);
        button.Name = string_0 + int_0;
        button.Tag = Class4.aDu(fr2_0);
        c7_0.Controls.Add(button);
        button.Click += kGC;
        Class4.kD3(fr2_0, int_0, 4, 4, num, num, num, Class115.vHZ(), 1);
    }

    private void nG9(Class26.P4[] p4_0, int int_0, string string_0, int int_1, Class35 c7_0) {
        int num = Class115.nHs(0, 13);
        Dictionary<int, Class25> dictionary = (Dictionary<int, Class25>)((object[])sGj)[int_1];
        Button button = new Button();
        button.BackgroundImage = Class4.ADq(int_0, dictionary);
        button.AccessibleDescription = Class4.SDr(int_0, dictionary);
        button.BackgroundImageLayout = ImageLayout.Zoom;
        button.Size = new Size(80, 80);
        button.Name = string_0 + int_0;
        button.Tag = Class4.aDu(p4_0);
        c7_0.Controls.Add(button);
        button.Click += kGC;
        Class4.LDd(p4_0, int_0, 4, 4, dictionary[int_0].YDA, num, num, num, Class115.vHZ(), 1);
    }

    private void cGc(object sender, EventArgs e) {
        if (Class67.l8l == 0) {
            if (HG3 == 0) {
                Class33[] jo = Class108.Jo3;
                Class63 wz = new Class63(jo, (Dictionary<int, Class25>[])sGj, 0, 0, Class117.Sox);
                Class63.ShowDialog();
                if (Class63.abf != -1) {
                    kGx(Class108.Jo3, Class63.abf, "headGear", 0, wbX);
                }
            } else if (HG3 == 1) {
                Class33[] jo = Class108.Yod;
                Class63 wz2 = new Class63(jo, (Dictionary<int, Class25>[])sGj, 1, 0, Class117.Qo9);
                wz2.ShowDialog();
                if (Class63.abf != -1) {
                    kGx(Class108.Yod, Class63.abf, "clothesGear", 1, PbS);
                }
            } else if (HG3 == 2) {
                Class33[] jo = Class108.YoH;
                Class63 wz3 = new Class63(jo, (Dictionary<int, Class25>[])sGj, 2, 0, Class117.Yoc);
                wz3.ShowDialog();
                if (Class63.abf != -1) {
                    kGx(Class108.YoH, Class63.abf, "shoesGear", 2, xbl);
                }
            }
        } else {
            if (Class67.l8l != 1) {
                return;
            }

            if (HG3 == 0) {
                Class33[] jo = Class26.iXg;
                Class63 wz4 = new Class63(jo, (Dictionary<int, Class25>[])sGj, 0, Class26.QXu.UpS);
                wz4.ShowDialog();
                if (Class63.abf != -1) {
                    nG9(Class26.iXg, Class63.abf, "headGear", 0, wbX);
                }
            } else if (HG3 == 1) {
                Class33[] jo = Class26.rX2;
                Class63 wz5 = new Class63(jo, (Dictionary<int, Class25>[])sGj, 1, Class26.QXu.UpS);
                wz5.ShowDialog();
                if (Class63.abf != -1) {
                    nG9(Class26.rX2, Class63.abf, "clothesGear", 1, PbS);
                }
            } else if (HG3 == 2) {
                Class33[] jo = Class26.pX3;
                Class63 wz6 = new Class63(jo, (Dictionary<int, Class25>[])sGj, 2, Class26.QXu.UpS);
                wz6.ShowDialog();
                if (Class63.abf != -1) {
                    nG9(Class26.pX3, Class63.abf, "shoesGear", 2, xbl);
                }
            }
        }
    }

    private void YGy(object sender, EventArgs e) {
        HG3 = GbE.SelectedIndex;
    }

    protected override void Dispose(bool disposing) {
        if (disposing && hGz != null) {
            hGz.Dispose();
        }

        base.Dispose(disposing);
    }

    private void GGr() {
        GbE = new TabControl();
        xbD = new TabPage();
        wbp = new TabPage();
        nbh = new TabPage();
        TbG = new GroupBox();
        Abb = new PictureBox();
        Ibv = new Label();
        ibo = new DateTimePicker();
        kbt = new NumericUpDown();
        XbV = new NumericUpDown();
        KbO = new Label();
        gbe = new Label();
        Pb8 = new Label();
        ybn = new CheckBox();
        abQ = new Label();
        jbF = new NumericUpDown();
        GbL = new GroupBox();
        FbJ = new Button();
        Mb7 = new Button();
        LbP = new Button();
        qbi = new Button();
        Rbm = new Label();
        ab0 = new Button();
        JbI = new Label();
        xbR = new Label();
        NbC = new GroupBox();
        bbK = new Button();
        IbU = new Button();
        MbT = new Button();
        Wb1 = new Button();
        wbX = new Class35();
        PbS = new Class35();
        xbl = new Class35();
        GbE.SuspendLayout();
        xbD.SuspendLayout();
        wbp.SuspendLayout();
        nbh.SuspendLayout();
        TbG.SuspendLayout();
        ((ISupportInitialize)Abb).BeginInit();
        ((ISupportInitialize)kbt).BeginInit();
        ((ISupportInitialize)XbV).BeginInit();
        ((ISupportInitialize)jbF).BeginInit();
        GbL.SuspendLayout();
        NbC.SuspendLayout();
        SuspendLayout();
        GbE.Controls.Add(xbD);
        GbE.Controls.Add(wbp);
        GbE.Controls.Add(nbh);
        GbE.Location = new Point(12, 12);
        GbE.Name = "GearControlPanel";
        GbE.SelectedIndex = 0;
        GbE.Size = new Size(402, 510);
        GbE.TabIndex = 1;
        GbE.SelectedIndexChanged += YGy;
        xbD.Controls.Add(wbX);
        xbD.Location = new Point(4, 22);
        xbD.Name = "tabPage3";
        xbD.Padding = new Padding(3);
        xbD.Size = new Size(394, 484);
        xbD.TabIndex = 0;
        xbD.Text = "Head";
        xbD.UseVisualStyleBackColor = true;
        wbp.Controls.Add(PbS);
        wbp.Location = new Point(4, 22);
        wbp.Name = "tabPage4";
        wbp.Padding = new Padding(3);
        wbp.Size = new Size(394, 484);
        wbp.TabIndex = 1;
        wbp.Text = "Clothes";
        wbp.UseVisualStyleBackColor = true;
        nbh.Controls.Add(xbl);
        nbh.Location = new Point(4, 22);
        nbh.Name = "tabPage5";
        nbh.Padding = new Padding(3);
        nbh.Size = new Size(394, 484);
        nbh.TabIndex = 2;
        nbh.Text = "Shoes";
        nbh.UseVisualStyleBackColor = true;
        TbG.Controls.Add(Abb);
        TbG.Controls.Add(Ibv);
        TbG.Controls.Add(ibo);
        TbG.Controls.Add(kbt);
        TbG.Controls.Add(XbV);
        TbG.Controls.Add(KbO);
        TbG.Controls.Add(gbe);
        TbG.Controls.Add(Pb8);
        TbG.Controls.Add(ybn);
        TbG.Controls.Add(abQ);
        TbG.Controls.Add(jbF);
        TbG.Location = new Point(420, 27);
        TbG.Name = "GB_GearMisc";
        TbG.Size = new Size(328, 211);
        TbG.TabIndex = 48;
        TbG.TabStop = false;
        Abb.BackgroundImageLayout = ImageLayout.Zoom;
        Abb.Location = new Point(123, 28);
        Abb.Name = "PB_Gear";
        Abb.Size = new Size(70, 70);
        Abb.TabIndex = 1;
        Abb.TabStop = false;
        Ibv.AutoSize = true;
        Ibv.Location = new Point(7, 185);
        Ibv.Name = "label1";
        Ibv.Size = new Size(61, 13);
        Ibv.TabIndex = 40;
        Ibv.Text = "Last Usage";
        ibo.CustomFormat = "MM/dd/yyyy hh:mm:ss";
        ibo.Format = DateTimePickerFormat.Custom;
        ibo.Location = new Point(173, 180);
        ibo.MaxDate = new DateTime(9998, 1, 1, 0, 0, 0, 0);
        ibo.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
        ibo.Name = "gearTimeStamp";
        ibo.Size = new Size(141, 20);
        ibo.TabIndex = 39;
        ibo.Value = new DateTime(2000, 1, 1, 0, 0, 0, 0);
        kbt.Location = new Point(41, 113);
        kbt.Maximum = new decimal(new int[4] { 4, 0, 0, 0 });
        kbt.Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
        kbt.Name = "gearLevel";
        kbt.Size = new Size(26, 20);
        kbt.TabIndex = 27;
        kbt.Value = new decimal(new int[4] { 1, 0, 0, 0 });
        kbt.ValueChanged += QGB;
        XbV.Location = new Point(264, 114);
        XbV.Maximum = new decimal(new int[4] { 4, 0, 0, 0 });
        XbV.Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
        XbV.Name = "gearUnlocked";
        XbV.Size = new Size(26, 20);
        XbV.TabIndex = 28;
        XbV.Value = new decimal(new int[4] { 1, 0, 0, 0 });
        XbV.ValueChanged += RGA;
        KbO.AutoSize = true;
        KbO.Location = new Point(7, 152);
        KbO.Name = "label41";
        KbO.Size = new Size(60, 13);
        KbO.TabIndex = 23;
        KbO.Text = "Experience";
        gbe.AutoSize = true;
        gbe.Location = new Point(170, 151);
        gbe.Name = "label43";
        gbe.Size = new Size(29, 13);
        gbe.TabIndex = 24;
        gbe.Text = "New";
        Pb8.AutoSize = true;
        Pb8.Location = new Point(7, 116);
        Pb8.Name = "label38";
        Pb8.Size = new Size(33, 13);
        Pb8.TabIndex = 21;
        Pb8.Text = "Level";
        ybn.AutoSize = true;
        ybn.Location = new Point(269, 151);
        ybn.Name = "newGearBox";
        ybn.Size = new Size(15, 14);
        ybn.TabIndex = 25;
        ybn.UseVisualStyleBackColor = true;
        abQ.AutoSize = true;
        abQ.Location = new Point(170, 116);
        abQ.Name = "label40";
        abQ.Size = new Size(91, 13);
        abQ.TabIndex = 22;
        abQ.Text = "Unlocked Abilities";
        jbF.Location = new Point(68, 150);
        jbF.Name = "gearExp";
        jbF.Size = new Size(52, 20);
        jbF.TabIndex = 26;
        GbL.Controls.Add(FbJ);
        GbL.Controls.Add(Mb7);
        GbL.Controls.Add(LbP);
        GbL.Controls.Add(qbi);
        GbL.Controls.Add(Rbm);
        GbL.Controls.Add(ab0);
        GbL.Controls.Add(JbI);
        GbL.Controls.Add(xbR);
        GbL.Location = new Point(420, 240);
        GbL.Name = "GB_GearAbility";
        GbL.Size = new Size(328, 204);
        GbL.TabIndex = 47;
        GbL.TabStop = false;
        GbL.Text = "Gears Abilities/Brand";
        FbJ.BackColor = Color.Black;
        FbJ.BackgroundImageLayout = ImageLayout.Zoom;
        FbJ.Location = new Point(76, 38);
        FbJ.Name = "mainAbility";
        FbJ.Size = new Size(64, 64);
        FbJ.TabIndex = 36;
        FbJ.UseVisualStyleBackColor = false;
        FbJ.MouseDown += gG1;
        Mb7.BackColor = Color.White;
        Mb7.BackgroundImageLayout = ImageLayout.Zoom;
        Mb7.Location = new Point(218, 38);
        Mb7.Name = "brand";
        Mb7.Size = new Size(64, 64);
        Mb7.TabIndex = 37;
        Mb7.UseVisualStyleBackColor = false;
        LbP.BackColor = Color.Black;
        LbP.BackgroundImageLayout = ImageLayout.Zoom;
        LbP.Location = new Point(76, 130);
        LbP.Name = "subability1";
        LbP.Size = new Size(64, 64);
        LbP.TabIndex = 33;
        LbP.UseVisualStyleBackColor = false;
        LbP.MouseDown += xGW;
        qbi.BackColor = Color.Black;
        qbi.BackgroundImageLayout = ImageLayout.Zoom;
        qbi.Location = new Point(218, 130);
        qbi.Name = "subability3";
        qbi.Size = new Size(64, 64);
        qbi.TabIndex = 35;
        qbi.UseVisualStyleBackColor = false;
        qbi.MouseDown += pGN;
        Rbm.AutoSize = true;
        Rbm.Location = new Point(7, 64);
        Rbm.Name = "label42";
        Rbm.Size = new Size(60, 13);
        Rbm.TabIndex = 29;
        Rbm.Text = "Main Ability";
        ab0.BackColor = Color.Black;
        ab0.BackgroundImageLayout = ImageLayout.Zoom;
        ab0.Location = new Point(147, 130);
        ab0.Name = "subability2";
        ab0.Size = new Size(64, 64);
        ab0.TabIndex = 34;
        ab0.UseVisualStyleBackColor = false;
        ab0.MouseDown += cGw;
        JbI.AutoSize = true;
        JbI.Location = new Point(16, 155);
        JbI.Name = "label44";
        JbI.Size = new Size(42, 13);
        JbI.TabIndex = 30;
        JbI.Text = "Abilities";
        xbR.AutoSize = true;
        xbR.Location = new Point(162, 64);
        xbR.Name = "label45";
        xbR.Size = new Size(35, 13);
        xbR.TabIndex = 31;
        xbR.Text = "Brand";
        NbC.Controls.Add(bbK);
        NbC.Controls.Add(IbU);
        NbC.Controls.Add(MbT);
        NbC.Controls.Add(Wb1);
        NbC.Location = new Point(423, 443);
        NbC.Name = "GB_GearActions";
        NbC.Size = new Size(322, 75);
        NbC.TabIndex = 46;
        NbC.TabStop = false;
        NbC.Text = "Actions";
        bbK.Location = new Point(116, 45);
        bbK.Name = "B_Delete";
        bbK.Size = new Size(73, 23);
        bbK.TabIndex = 44;
        bbK.Text = "Delete Gear";
        bbK.UseVisualStyleBackColor = true;
        bbK.Click += zG6;
        IbU.Location = new Point(116, 16);
        IbU.Name = "B_AddGear";
        IbU.Size = new Size(73, 23);
        IbU.TabIndex = 43;
        IbU.Text = "Add Gear";
        IbU.UseVisualStyleBackColor = true;
        IbU.Click += cGc;
        MbT.Location = new Point(195, 16);
        MbT.Name = "B_WearGear";
        MbT.Size = new Size(73, 23);
        MbT.TabIndex = 42;
        MbT.Text = "Wear Gear";
        MbT.UseVisualStyleBackColor = true;
        MbT.Click += tGf;
        Wb1.Location = new Point(37, 16);
        Wb1.Name = "B_SaveGear";
        Wb1.Size = new Size(73, 23);
        Wb1.TabIndex = 38;
        Wb1.Text = "Save Gear";
        Wb1.UseVisualStyleBackColor = true;
        Wb1.Click += TGY;
        wbX.AutoScroll = true;
        wbX.Dock = DockStyle.Fill;
        wbX.Location = new Point(3, 3);
        wbX.Name = "headPanel";
        wbX.Size = new Size(388, 478);
        wbX.TabIndex = 2;
        PbS.AutoScroll = true;
        PbS.Dock = DockStyle.Fill;
        PbS.Location = new Point(3, 3);
        PbS.Name = "clothesPanel";
        PbS.Size = new Size(388, 478);
        PbS.TabIndex = 3;
        xbl.AutoScroll = true;
        xbl.Dock = DockStyle.Fill;
        xbl.Location = new Point(3, 3);
        xbl.Name = "shoesPanel";
        xbl.Size = new Size(388, 478);
        xbl.TabIndex = 3;
        base.AutoScaleDimensions = new SizeF(6f, 13f);
        base.AutoScaleMode = AutoScaleMode.Font;
        base.ClientSize = new Size(757, 524);
        base.Controls.Add(TbG);
        base.Controls.Add(GbL);
        base.Controls.Add(NbC);
        base.Controls.Add(GbE);
        base.Name = "GearSplat";
        base.ShowIcon = false;
        base.StartPosition = FormStartPosition.CenterScreen;
        Text = "SplatHeX - Splatoon 2 - Gears Editor";
        GbE.ResumeLayout(performLayout: false);
        xbD.ResumeLayout(performLayout: false);
        wbp.ResumeLayout(performLayout: false);
        nbh.ResumeLayout(performLayout: false);
        TbG.ResumeLayout(performLayout: false);
        TbG.PerformLayout();
        ((ISupportInitialize)Abb).EndInit();
        ((ISupportInitialize)kbt).EndInit();
        ((ISupportInitialize)XbV).EndInit();
        ((ISupportInitialize)jbF).EndInit();
        GbL.ResumeLayout(performLayout: false);
        GbL.PerformLayout();
        NbC.ResumeLayout(performLayout: false);
        ResumeLayout(performLayout: false);
    }
}