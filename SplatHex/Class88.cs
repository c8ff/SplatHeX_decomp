using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace SplatHex;
public class Class88 : Form {
    public bool Umq;
    public bool Imk;
    public bool tmM;
    private IDisposable Ymu;
    private GroupBox umg;
    private GroupBox Pm2;
    private GroupBox zm3;
    private Label Pmd;
    private DateTimePicker bmH;
    private DateTimePicker om4;
    private Label zm5;
    private ComboBox Jms;
    private ComboBox JmZ;
    private Label Lma;
    private Label Vmj;
    private DateTimePicker ymz;
    private ComboBox p0E;
    private Label V0D;
    private Label F0X;
    private DateTimePicker s0p;
    private DateTimePicker p0S;
    private DateTimePicker H0h;
    private PictureBox v0l;
    private PictureBox i0G;
    private PictureBox C0b;
    private ComboBox V0v;
    private ComboBox S0o;
    private ComboBox C0t;
    private ComboBox c0V;
    private ComboBox S0O;
    private ComboBox a0e;
    private Button B08;
    private Button l0n;
    private GroupBox w0Q;
    private Button u0F;
    private Button S0L;
    private Button h0J;
    public Class88() {
        Mmr();
        gmN();
    }

    private void gmN() {
        if (Class108.Voj[0].mVb != -1) {
            om4.Value = Class115.LHu(Class108.Voj[0].jV8);
            bmH.Value = Class115.LHu(Class108.Voj[0].HVn);
            if (Class108.Voj[0].mVb == 0) {
                v0l.Image = (Image)Class117.toq[Class108.Voj[0].zVv].eDB;
                c0V.SelectedIndex = 0;
                Umq = true;
            } else if (Class108.Voj[0].mVb == 1) {
                v0l.Image = (Image)Class117.qor[Class108.Voj[0].zVv].eDB;
                c0V.SelectedIndex = 1;
                Umq = true;
            } else if (Class108.Voj[0].mVb == 2) {
                v0l.Image = (Image)Class117.eoy[Class108.Voj[0].zVv].eDB;
                c0V.SelectedIndex = 2;
                Umq = true;
            }

            if (Class108.Voj[0].iVQ == -1) {
                Jms.SelectedIndex = 0;
            } else if (Class108.Voj[0].iVQ == 0) {
                Jms.SelectedIndex = 1;
            } else if (Class108.Voj[0].iVQ == 1) {
                Jms.SelectedIndex = 2;
            }
        } else {
            umg.Enabled = false;
            umg.Text = "Gear 1 - Never Ordered";
        }

        if (Class108.Voj[1].mVb != -1) {
            ymz.Value = Class115.LHu(Class108.Voj[1].jV8);
            H0h.Value = Class115.LHu(Class108.Voj[1].HVn);
            if (Class108.Voj[1].mVb == 0) {
                i0G.Image = (Image)Class117.toq[Class108.Voj[1].zVv].eDB;
                S0O.SelectedIndex = 0;
                Imk = true;
            } else if (Class108.Voj[1].mVb == 1) {
                i0G.Image = (Image)Class117.qor[Class108.Voj[1].zVv].eDB;
                S0O.SelectedIndex = 1;
                Imk = true;
            } else if (Class108.Voj[1].mVb == 2) {
                i0G.Image = (Image)Class117.eoy[Class108.Voj[1].zVv].eDB;
                S0O.SelectedIndex = 2;
                Imk = true;
            }

            if (Class108.Voj[1].iVQ == -1) {
                JmZ.SelectedIndex = 0;
            } else if (Class108.Voj[1].iVQ == 0) {
                JmZ.SelectedIndex = 1;
            } else if (Class108.Voj[1].iVQ == 1) {
                JmZ.SelectedIndex = 2;
            }
        } else {
            Pm2.Enabled = false;
            Pm2.Text = "Gear 2 - Never Ordered";
        }

        if (Class108.Voj[2].mVb != -1) {
            p0S.Value = Class115.LHu(Class108.Voj[2].jV8);
            s0p.Value = Class115.LHu(Class108.Voj[2].HVn);
            if (Class108.Voj[2].mVb == 0) {
                C0b.Image = (Image)Class117.toq[Class108.Voj[2].zVv].eDB;
                a0e.SelectedIndex = 0;
                tmM = true;
            } else if (Class108.Voj[2].mVb == 1) {
                C0b.Image = (Image)Class117.qor[Class108.Voj[2].zVv].eDB;
                a0e.SelectedIndex = 1;
                tmM = true;
            } else if (Class108.Voj[2].mVb == 2) {
                C0b.Image = (Image)Class117.eoy[Class108.Voj[2].zVv].eDB;
                a0e.SelectedIndex = 2;
                tmM = true;
            }

            if (Class108.Voj[2].iVQ == -1) {
                p0E.SelectedIndex = 0;
            } else if (Class108.Voj[2].iVQ == 0) {
                p0E.SelectedIndex = 1;
            } else if (Class108.Voj[2].iVQ == 1) {
                p0E.SelectedIndex = 2;
            }
        } else {
            zm3.Enabled = false;
            zm3.Text = "Gear 3 - Never Ordered";
        }
    }

    private void mmY(object sender, EventArgs e) {
        if (Class108.Voj[0].mVb == 0) {
            int key = Class4.JDk(V0v.SelectedItem.ToString(), Class117.toq);
            v0l.Image = (Image)Class117.toq[key].eDB;
        } else if (Class108.Voj[0].mVb == 1) {
            int key2 = Class4.JDk(V0v.SelectedItem.ToString(), Class117.qor);
            v0l.Image = (Image)Class117.qor[key2].eDB;
        } else if (Class108.Voj[0].mVb == 2) {
            int key3 = Class4.JDk(V0v.SelectedItem.ToString(), Class117.eoy);
            v0l.Image = (Image)Class117.eoy[key3].eDB;
        }
    }

    private void mmB(object sender, EventArgs e) {
        if (Class108.Voj[1].mVb == 0) {
            int key = Class4.JDk(S0o.SelectedItem.ToString(), Class117.toq);
            i0G.Image = (Image)Class117.toq[key].eDB;
        } else if (Class108.Voj[1].mVb == 1) {
            int key2 = Class4.JDk(S0o.SelectedItem.ToString(), Class117.qor);
            i0G.Image = (Image)Class117.qor[key2].eDB;
        } else if (Class108.Voj[1].mVb == 2) {
            int key3 = Class4.JDk(S0o.SelectedItem.ToString(), Class117.eoy);
            i0G.Image = (Image)Class117.eoy[key3].eDB;
        }
    }

    private void HmA(object sender, EventArgs e) {
        if (Class108.Voj[2].mVb == 0) {
            int key = Class4.JDk(C0t.SelectedItem.ToString(), Class117.toq);
            C0b.Image = (Image)Class117.toq[key].eDB;
        } else if (Class108.Voj[2].mVb == 1) {
            int key2 = Class4.JDk(C0t.SelectedItem.ToString(), Class117.qor);
            C0b.Image = (Image)Class117.qor[key2].eDB;
        } else if (Class108.Voj[2].mVb == 2) {
            int key3 = Class4.JDk(C0t.SelectedItem.ToString(), Class117.eoy);
            C0b.Image = (Image)Class117.eoy[key3].eDB;
        }
    }

    private void Fmf(object sender, EventArgs e) {
        V0v.Items.Clear();
        if (c0V.SelectedIndex == 0) {
            Class108.Voj[0].mVb = 0;
            foreach (int key in Class117.toq.Keys) {
                V0v.Items.Add(Class117.toq[key].rDY);
            }

            if (!Umq) {
                V0v.SelectedIndex = V0v.FindStringExact(Class117.toq[Class108.Voj[0].zVv].rDY);
            } else {
                V0v.SelectedIndex = 0;
            }
        } else if (c0V.SelectedIndex == 1) {
            Class108.Voj[0].mVb = 1;
            foreach (int key2 in Class117.qor.Keys) {
                V0v.Items.Add(Class117.qor[key2].rDY);
            }

            if (!Umq) {
                V0v.SelectedIndex = V0v.FindStringExact(Class117.qor[Class108.Voj[0].zVv].rDY);
            } else {
                V0v.SelectedIndex = 0;
            }
        } else {
            if (c0V.SelectedIndex != 2) {
                return;
            }

            Class108.Voj[0].mVb = 2;
            foreach (int key3 in Class117.eoy.Keys) {
                V0v.Items.Add(Class117.eoy[key3].rDY);
            }

            if (!Umq) {
                V0v.SelectedIndex = V0v.FindStringExact(Class117.eoy[Class108.Voj[0].zVv].rDY);
            } else {
                V0v.SelectedIndex = 0;
            }
        }
    }

    private void Ym6(object sender, EventArgs e) {
        S0o.Items.Clear();
        if (S0O.SelectedIndex == 0) {
            Class108.Voj[1].mVb = 0;
            foreach (int key in Class117.toq.Keys) {
                S0o.Items.Add(Class117.toq[key].rDY);
            }

            if (!Imk) {
                S0o.SelectedIndex = S0o.FindStringExact(Class117.toq[Class108.Voj[1].zVv].rDY);
            } else {
                S0o.SelectedIndex = 0;
            }
        } else if (S0O.SelectedIndex == 1) {
            Class108.Voj[1].mVb = 1;
            foreach (int key2 in Class117.qor.Keys) {
                S0o.Items.Add(Class117.qor[key2].rDY);
            }

            if (!Imk) {
                S0o.SelectedIndex = S0o.FindStringExact(Class117.qor[Class108.Voj[1].zVv].rDY);
            } else {
                S0o.SelectedIndex = 0;
            }
        } else {
            if (S0O.SelectedIndex != 2) {
                return;
            }

            Class108.Voj[1].mVb = 2;
            foreach (int key3 in Class117.eoy.Keys) {
                S0o.Items.Add(Class117.eoy[key3].rDY);
            }

            if (!Imk) {
                S0o.SelectedIndex = S0o.FindStringExact(Class117.eoy[Class108.Voj[1].zVv].rDY);
            } else {
                S0o.SelectedIndex = 0;
            }
        }
    }

    private void qmx(object sender, EventArgs e) {
        C0t.Items.Clear();
        if (a0e.SelectedIndex == 0) {
            Class108.Voj[2].mVb = 0;
            foreach (int key in Class117.toq.Keys) {
                C0t.Items.Add(Class117.toq[key].rDY);
            }

            if (!tmM) {
                C0t.SelectedIndex = C0t.FindStringExact(Class117.toq[Class108.Voj[2].zVv].rDY);
            } else {
                C0t.SelectedIndex = 0;
            }
        } else if (a0e.SelectedIndex == 1) {
            Class108.Voj[2].mVb = 1;
            foreach (int key2 in Class117.qor.Keys) {
                C0t.Items.Add(Class117.qor[key2].rDY);
            }

            if (!tmM) {
                C0t.SelectedIndex = C0t.FindStringExact(Class117.qor[Class108.Voj[1].zVv].rDY);
            } else {
                C0t.SelectedIndex = 0;
            }
        } else {
            if (a0e.SelectedIndex != 2) {
                return;
            }

            Class108.Voj[2].mVb = 2;
            foreach (int key3 in Class117.eoy.Keys) {
                C0t.Items.Add(Class117.eoy[key3].rDY);
            }

            if (!tmM) {
                C0t.SelectedIndex = C0t.FindStringExact(Class117.eoy[Class108.Voj[2].zVv].rDY);
            } else {
                C0t.SelectedIndex = 0;
            }
        }
    }

    private void vm9() {
        if (c0V.SelectedIndex == 0) {
            Class108.Voj[0].zVv = Class4.JDk(V0v.SelectedItem.ToString(), Class117.toq);
        } else if (c0V.SelectedIndex == 1) {
            Class108.Voj[0].zVv = Class4.JDk(V0v.SelectedItem.ToString(), Class117.qor);
        } else if (c0V.SelectedIndex == 2) {
            Class108.Voj[0].zVv = Class4.JDk(V0v.SelectedItem.ToString(), Class117.eoy);
        }

        if (S0O.SelectedIndex == 0) {
            Class108.Voj[1].zVv = Class4.JDk(S0o.SelectedItem.ToString(), Class117.toq);
        } else if (S0O.SelectedIndex == 1) {
            Class108.Voj[1].zVv = Class4.JDk(S0o.SelectedItem.ToString(), Class117.qor);
        } else if (S0O.SelectedIndex == 2) {
            Class108.Voj[1].zVv = Class4.JDk(S0o.SelectedItem.ToString(), Class117.eoy);
        }

        if (a0e.SelectedIndex == 0) {
            Class108.Voj[2].zVv = Class4.JDk(C0t.SelectedItem.ToString(), Class117.toq);
        } else if (a0e.SelectedIndex == 1) {
            Class108.Voj[2].zVv = Class4.JDk(C0t.SelectedItem.ToString(), Class117.qor);
        } else if (a0e.SelectedIndex == 2) {
            Class108.Voj[2].zVv = Class4.JDk(C0t.SelectedItem.ToString(), Class117.eoy);
        }

        if (Jms.SelectedIndex == 0) {
            Class108.Voj[0].iVQ = -1;
        } else if (Jms.SelectedIndex == 1) {
            Class108.Voj[0].iVQ = 0;
        } else if (Jms.SelectedIndex == 2) {
            Class108.Voj[0].iVQ = 1;
        }

        if (JmZ.SelectedIndex == 0) {
            Class108.Voj[1].iVQ = -1;
        } else if (JmZ.SelectedIndex == 1) {
            Class108.Voj[1].iVQ = 0;
        } else if (JmZ.SelectedIndex == 2) {
            Class108.Voj[1].iVQ = 1;
        }

        if (p0E.SelectedIndex == 0) {
            Class108.Voj[2].iVQ = -1;
        } else if (p0E.SelectedIndex == 1) {
            Class108.Voj[2].iVQ = 0;
        } else if (p0E.SelectedIndex == 2) {
            Class108.Voj[2].iVQ = 1;
        }

        Class108.Voj[0].jV8 = Class115.DHg(om4);
        Class108.Voj[0].HVn = Class115.DHg(bmH);
        Class108.Voj[1].jV8 = Class115.DHg(ymz);
        Class108.Voj[1].HVn = Class115.DHg(H0h);
        Class108.Voj[2].jV8 = Class115.DHg(p0S);
        Class108.Voj[2].HVn = Class115.DHg(s0p);
    }

    private void Tmc(object sender, EventArgs e) {
        vm9();
        Close();
    }

    private void lmy(object sender, EventArgs e) {
        Close();
    }

    protected override void Dispose(bool disposing) {
        if (disposing && Ymu != null) {
            Ymu.Dispose();
        }

        base.Dispose(disposing);
    }

    private void Mmr() {
        umg = new GroupBox();
        c0V = new ComboBox();
        V0v = new ComboBox();
        v0l = new PictureBox();
        Jms = new ComboBox();
        zm5 = new Label();
        Pmd = new Label();
        bmH = new DateTimePicker();
        om4 = new DateTimePicker();
        Pm2 = new GroupBox();
        S0O = new ComboBox();
        S0o = new ComboBox();
        i0G = new PictureBox();
        JmZ = new ComboBox();
        Lma = new Label();
        Vmj = new Label();
        H0h = new DateTimePicker();
        ymz = new DateTimePicker();
        zm3 = new GroupBox();
        a0e = new ComboBox();
        C0t = new ComboBox();
        C0b = new PictureBox();
        p0E = new ComboBox();
        V0D = new Label();
        F0X = new Label();
        s0p = new DateTimePicker();
        p0S = new DateTimePicker();
        B08 = new Button();
        l0n = new Button();
        w0Q = new GroupBox();
        h0J = new Button();
        S0L = new Button();
        u0F = new Button();
        umg.SuspendLayout();
        ((ISupportInitialize)v0l).BeginInit();
        Pm2.SuspendLayout();
        ((ISupportInitialize)i0G).BeginInit();
        zm3.SuspendLayout();
        ((ISupportInitialize)C0b).BeginInit();
        w0Q.SuspendLayout();
        SuspendLayout();
        umg.Controls.Add(c0V);
        umg.Controls.Add(V0v);
        umg.Controls.Add(v0l);
        umg.Controls.Add(Jms);
        umg.Controls.Add(zm5);
        umg.Controls.Add(Pmd);
        umg.Controls.Add(bmH);
        umg.Controls.Add(om4);
        umg.Location = new Point(6, 19);
        umg.Name = "groupBox1";
        umg.Size = new Size(233, 300);
        umg.TabIndex = 0;
        umg.TabStop = false;
        umg.Text = "Gear 1";
        c0V.DropDownStyle = ComboBoxStyle.DropDownList;
        c0V.FormattingEnabled = true;
        c0V.Items.AddRange(new object[3] { "Shoes", "Clothes", "Hat" });
        c0V.Location = new Point(77, 130);
        c0V.Name = "CB_GearType1";
        c0V.Size = new Size(80, 21);
        c0V.TabIndex = 49;
        c0V.SelectedIndexChanged += Fmf;
        V0v.DropDownStyle = ComboBoxStyle.DropDownList;
        V0v.FormattingEnabled = true;
        V0v.Location = new Point(36, 243);
        V0v.Name = "CB_GList1";
        V0v.Size = new Size(162, 21);
        V0v.TabIndex = 48;
        V0v.SelectedIndexChanged += mmY;
        v0l.Location = new Point(77, 157);
        v0l.Name = "PB_Gear1";
        v0l.Size = new Size(80, 80);
        v0l.SizeMode = PictureBoxSizeMode.Zoom;
        v0l.TabIndex = 47;
        v0l.TabStop = false;
        Jms.DropDownStyle = ComboBoxStyle.DropDownList;
        Jms.FormattingEnabled = true;
        Jms.Items.AddRange(new object[3] { "No Gear", "Coming Soon", "Can Withdraw" });
        Jms.Location = new Point(58, 99);
        Jms.Name = "CB_State1";
        Jms.Size = new Size(121, 21);
        Jms.TabIndex = 46;
        zm5.AutoSize = true;
        zm5.Location = new Point(44, 55);
        zm5.Name = "label2";
        zm5.Size = new Size(36, 13);
        zm5.TabIndex = 45;
        zm5.Text = "Arrival";
        Pmd.AutoSize = true;
        Pmd.Location = new Point(44, 12);
        Pmd.Name = "label1";
        Pmd.Size = new Size(45, 13);
        Pmd.TabIndex = 44;
        Pmd.Text = "Ordered";
        bmH.CustomFormat = "MM/dd/yyyy hh:mm:ss";
        bmH.Format = DateTimePickerFormat.Custom;
        bmH.Location = new Point(47, 71);
        bmH.MaxDate = new DateTime(9998, 1, 1, 0, 0, 0, 0);
        bmH.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
        bmH.Name = "g1_Arrival";
        bmH.Size = new Size(141, 20);
        bmH.TabIndex = 43;
        bmH.Value = new DateTime(2000, 1, 1, 0, 0, 0, 0);
        om4.CustomFormat = "MM/dd/yyyy hh:mm:ss";
        om4.Format = DateTimePickerFormat.Custom;
        om4.Location = new Point(47, 28);
        om4.MaxDate = new DateTime(9998, 1, 1, 0, 0, 0, 0);
        om4.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
        om4.Name = "g1_Order";
        om4.Size = new Size(141, 20);
        om4.TabIndex = 42;
        om4.Value = new DateTime(2000, 1, 1, 0, 0, 0, 0);
        Pm2.Controls.Add(S0O);
        Pm2.Controls.Add(S0o);
        Pm2.Controls.Add(i0G);
        Pm2.Controls.Add(JmZ);
        Pm2.Controls.Add(Lma);
        Pm2.Controls.Add(Vmj);
        Pm2.Controls.Add(H0h);
        Pm2.Controls.Add(ymz);
        Pm2.Location = new Point(245, 19);
        Pm2.Name = "groupBox2";
        Pm2.Size = new Size(233, 300);
        Pm2.TabIndex = 1;
        Pm2.TabStop = false;
        Pm2.Text = "Gear 2";
        S0O.DropDownStyle = ComboBoxStyle.DropDownList;
        S0O.FormattingEnabled = true;
        S0O.Items.AddRange(new object[3] { "Shoes", "Clothes", "Hat" });
        S0O.Location = new Point(84, 130);
        S0O.Name = "CB_GearType2";
        S0O.Size = new Size(80, 21);
        S0O.TabIndex = 50;
        S0O.SelectedIndexChanged += Ym6;
        S0o.DropDownStyle = ComboBoxStyle.DropDownList;
        S0o.FormattingEnabled = true;
        S0o.Location = new Point(44, 243);
        S0o.Name = "CB_GList2";
        S0o.Size = new Size(162, 21);
        S0o.TabIndex = 49;
        S0o.SelectedIndexChanged += mmB;
        i0G.Location = new Point(84, 157);
        i0G.Name = "PB_Gear2";
        i0G.Size = new Size(80, 80);
        i0G.SizeMode = PictureBoxSizeMode.Zoom;
        i0G.TabIndex = 52;
        i0G.TabStop = false;
        JmZ.DropDownStyle = ComboBoxStyle.DropDownList;
        JmZ.FormattingEnabled = true;
        JmZ.Items.AddRange(new object[3] { "No Gear", "Coming Soon", "Can Withdraw" });
        JmZ.Location = new Point(58, 102);
        JmZ.Name = "CB_State2";
        JmZ.Size = new Size(121, 21);
        JmZ.TabIndex = 51;
        Lma.AutoSize = true;
        Lma.Location = new Point(44, 58);
        Lma.Name = "label3";
        Lma.Size = new Size(36, 13);
        Lma.TabIndex = 50;
        Lma.Text = "Arrival";
        Vmj.AutoSize = true;
        Vmj.Location = new Point(44, 15);
        Vmj.Name = "label4";
        Vmj.Size = new Size(45, 13);
        Vmj.TabIndex = 49;
        Vmj.Text = "Ordered";
        H0h.CustomFormat = "MM/dd/yyyy hh:mm:ss";
        H0h.Format = DateTimePickerFormat.Custom;
        H0h.Location = new Point(47, 74);
        H0h.MaxDate = new DateTime(9998, 1, 1, 0, 0, 0, 0);
        H0h.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
        H0h.Name = "g2_Arrival";
        H0h.Size = new Size(141, 20);
        H0h.TabIndex = 48;
        H0h.Value = new DateTime(2000, 1, 1, 0, 0, 0, 0);
        ymz.CustomFormat = "MM/dd/yyyy hh:mm:ss";
        ymz.Format = DateTimePickerFormat.Custom;
        ymz.Location = new Point(47, 31);
        ymz.MaxDate = new DateTime(9998, 1, 1, 0, 0, 0, 0);
        ymz.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
        ymz.Name = "g2_Order";
        ymz.Size = new Size(141, 20);
        ymz.TabIndex = 47;
        ymz.Value = new DateTime(2000, 1, 1, 0, 0, 0, 0);
        zm3.Controls.Add(a0e);
        zm3.Controls.Add(C0t);
        zm3.Controls.Add(C0b);
        zm3.Controls.Add(p0E);
        zm3.Controls.Add(V0D);
        zm3.Controls.Add(F0X);
        zm3.Controls.Add(s0p);
        zm3.Controls.Add(p0S);
        zm3.Location = new Point(484, 19);
        zm3.Name = "groupBox3";
        zm3.Size = new Size(233, 300);
        zm3.TabIndex = 2;
        zm3.TabStop = false;
        zm3.Text = "Gear 3";
        a0e.DropDownStyle = ComboBoxStyle.DropDownList;
        a0e.FormattingEnabled = true;
        a0e.Items.AddRange(new object[3] { "Shoes", "Clothes", "Hat" });
        a0e.Location = new Point(79, 130);
        a0e.Name = "CB_GearType3";
        a0e.Size = new Size(80, 21);
        a0e.TabIndex = 53;
        a0e.SelectedIndexChanged += qmx;
        C0t.DropDownStyle = ComboBoxStyle.DropDownList;
        C0t.FormattingEnabled = true;
        C0t.Location = new Point(37, 243);
        C0t.Name = "CB_GList3";
        C0t.Size = new Size(162, 21);
        C0t.TabIndex = 53;
        C0t.SelectedIndexChanged += HmA;
        C0b.Location = new Point(79, 157);
        C0b.Name = "PB_Gear3";
        C0b.Size = new Size(80, 80);
        C0b.SizeMode = PictureBoxSizeMode.Zoom;
        C0b.TabIndex = 53;
        C0b.TabStop = false;
        p0E.DropDownStyle = ComboBoxStyle.DropDownList;
        p0E.FormattingEnabled = true;
        p0E.Items.AddRange(new object[3] { "No Gear", "Coming Soon", "Can Withdraw" });
        p0E.Location = new Point(58, 103);
        p0E.Name = "CB_State3";
        p0E.Size = new Size(121, 21);
        p0E.TabIndex = 51;
        V0D.AutoSize = true;
        V0D.Location = new Point(44, 59);
        V0D.Name = "label5";
        V0D.Size = new Size(36, 13);
        V0D.TabIndex = 50;
        V0D.Text = "Arrival";
        F0X.AutoSize = true;
        F0X.Location = new Point(44, 16);
        F0X.Name = "label6";
        F0X.Size = new Size(45, 13);
        F0X.TabIndex = 49;
        F0X.Text = "Ordered";
        s0p.CustomFormat = "MM/dd/yyyy hh:mm:ss";
        s0p.Format = DateTimePickerFormat.Custom;
        s0p.Location = new Point(47, 75);
        s0p.MaxDate = new DateTime(9998, 1, 1, 0, 0, 0, 0);
        s0p.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
        s0p.Name = "g3_Arrival";
        s0p.Size = new Size(141, 20);
        s0p.TabIndex = 48;
        s0p.Value = new DateTime(2000, 1, 1, 0, 0, 0, 0);
        p0S.CustomFormat = "MM/dd/yyyy hh:mm:ss";
        p0S.Format = DateTimePickerFormat.Custom;
        p0S.Location = new Point(47, 32);
        p0S.MaxDate = new DateTime(9998, 1, 1, 0, 0, 0, 0);
        p0S.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
        p0S.Name = "g3_Order";
        p0S.Size = new Size(141, 20);
        p0S.TabIndex = 47;
        p0S.Value = new DateTime(2000, 1, 1, 0, 0, 0, 0);
        B08.Location = new Point(621, 374);
        B08.Name = "B_Save";
        B08.Size = new Size(54, 23);
        B08.TabIndex = 3;
        B08.Text = "Save";
        B08.UseVisualStyleBackColor = true;
        B08.Click += Tmc;
        l0n.Location = new Point(681, 374);
        l0n.Name = "B_Cancel";
        l0n.Size = new Size(54, 23);
        l0n.TabIndex = 4;
        l0n.Text = "Cancel";
        l0n.UseVisualStyleBackColor = true;
        l0n.Click += lmy;
        w0Q.Controls.Add(u0F);
        w0Q.Controls.Add(S0L);
        w0Q.Controls.Add(h0J);
        w0Q.Controls.Add(umg);
        w0Q.Controls.Add(Pm2);
        w0Q.Controls.Add(zm3);
        w0Q.Location = new Point(12, 12);
        w0Q.Name = "groupBox4";
        w0Q.Size = new Size(723, 356);
        w0Q.TabIndex = 5;
        w0Q.TabStop = false;
        w0Q.Text = "Spyke Order List";
        h0J.Location = new Point(83, 325);
        h0J.Name = "button1";
        h0J.Size = new Size(80, 23);
        h0J.TabIndex = 3;
        h0J.Text = "Add Order";
        h0J.UseVisualStyleBackColor = true;
        S0L.Location = new Point(329, 325);
        S0L.Name = "button2";
        S0L.Size = new Size(80, 23);
        S0L.TabIndex = 4;
        S0L.Text = "Add Order";
        S0L.UseVisualStyleBackColor = true;
        u0F.Location = new Point(563, 325);
        u0F.Name = "button3";
        u0F.Size = new Size(80, 23);
        u0F.TabIndex = 5;
        u0F.Text = "Add Order";
        u0F.UseVisualStyleBackColor = true;
        base.AutoScaleDimensions = new SizeF(6f, 13f);
        base.AutoScaleMode = AutoScaleMode.Font;
        base.ClientSize = new Size(742, 401);
        base.Controls.Add(w0Q);
        base.Controls.Add(l0n);
        base.Controls.Add(B08);
        base.Name = "SpykeOrderSplat1";
        base.ShowIcon = false;
        base.StartPosition = FormStartPosition.CenterScreen;
        Text = "SplatHeX - Splatoon 1 - Spyke Order Editor";
        umg.ResumeLayout(performLayout: false);
        umg.PerformLayout();
        ((ISupportInitialize)v0l).EndInit();
        Pm2.ResumeLayout(performLayout: false);
        Pm2.PerformLayout();
        ((ISupportInitialize)i0G).EndInit();
        zm3.ResumeLayout(performLayout: false);
        zm3.PerformLayout();
        ((ISupportInitialize)C0b).EndInit();
        w0Q.ResumeLayout(performLayout: false);
        ResumeLayout(performLayout: false);
    }
}