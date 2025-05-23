using System;
using System.Collections.Generic;
using System.IO;
using System.Resources;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace SplatHex;
public class Class67 : Form {
    internal static int l8l;
    internal static int h8G;
    internal static bool M8b;
    public string F8v = "http://leanny.github.io/files/version.txt";
    public string N8o = "https://leanny.github.io/SplatHeX.html";
    public static ResourceManager l8t;
    public static string Q8V;
    public static string g8O;
    private IDisposable J8e;
    private GroupBox h88;
    private Button M8n;
    private Button U8Q;
    private Button b8F;
    private Button j8L;
    private Button j8J;
    private Button w87;
    private Button l8P;
    private Button S8i;
    private Button S8m;
    private MenuStrip d80;
    private ToolStripMenuItem N8I;
    private ToolStripMenuItem U8R;
    private ToolStripMenuItem V8C;
    private ToolStripMenuItem g8K;
    private ToolStripMenuItem G8U;
    private ToolStripMenuItem g8T;
    private Button Q81;
    private ToolStripMenuItem D8W;
    private ToolStripMenuItem f8w;
    private ToolStripMenuItem S8N;
    private ToolStripMenuItem J8Y;
    private LinkLabel j8B;
    private void wey(object sender, EventArgs e) {
        new Class51().ShowDialog();
    }

    private void Jer(object sender, EventArgs e) {
        new Class78().ShowDialog();
        if (Class108.io2 != null) {
            WeH();
            M8b = true;
        }
    }

    private void Teq() {
        G8U.Checked = Settings.Default.LegalCheck;
    }

    private void dek(object sender, EventArgs e) {
        Settings.Default.LegalCheck = G8U.Checked;
        Settings.Default.Save();
    }

    public Class67() {
        k8h();
        BeM();
        ee2();
        neg();
        Teq();
        if (!Settings.Default.FlagMessage2) {
            MessageBox.Show("SplatHeX is currently in a big WIP state, it might not be perfect yet, so do not play online with any unreleased gear/weapons, Otherwise you have a major risk of your console being banned. We are not responsible if you get banned, please make good use of this editor and everything should be fine, enjoy.");
            Settings.Default.FlagMessage2 = true;
            Settings.Default.Save();
        }
    }

    private void BeM() {
        V8C.Enabled = false;
        h88.Enabled = false;
    }

    private void seu() {
        V8C.Enabled = true;
        h88.Enabled = true;
    }

    private void neg() {
        if (!Directory.Exists("json")) {
            Directory.CreateDirectory("json");
        }

        if (!Directory.Exists("img")) {
            Directory.CreateDirectory("img");
        }

        if (!File.Exists("json/versions.json")) {
            File.WriteAllText("json/versions.json", "");
        }

        string string_ = "https://raw.githubusercontent.com/Leanny/leanny.github.io/master/data/versions.json";
        string text = "https://raw.githubusercontent.com/Leanny/leanny.github.io/master/data/Mush/";
        string text2 = Class115.FH3(string_);
        string text3 = File.ReadAllText("json/versions.json");
        if (text3 == text2) {
            return;
        }

        string[] array = new string[4]
        {
            "WeaponInfo_Main.json",
            "GearInfo_Shoes.json",
            "GearInfo_Head.json",
            "GearInfo_Clothes.json"
        };
        if (text2 == null) {
            return;
        }

        List<int> list = JsonConvert.DeserializeObject<List<int>>(text2);
        File.WriteAllText("json/versions.json", text2);
        int num = list[list.Count - 1];
        string[] array2 = array;
        foreach (string text4 in array2) {
            string text5 = Class115.FH3(text + num + "/" + text4);
            if (text5 != null) {
                File.WriteAllText("json/" + text4, text5);
            }
        }

        string text6 = Class115.FH3("https://raw.githubusercontent.com/Leanny/leanny.github.io/master/data/Languages/lang_dict_EUen.json");
        if (text6 != null) {
            File.WriteAllText("json/lang_dict.json", text6);
        }
    }

    private void ee2() {
        Q8V = Resources.version;
        g8O = Class115.FH3(F8v);
        if (g8O == null) {
            return;
        }

        int num = int.Parse(g8O);
        int num2 = int.Parse(Q8V);
        if (num > num2) {
            j8B.Visible = true;
            j8B.Click += delegate {
                new Class94().ShowDialog();
            };
        }
    }

    private void Ce3(object sender, EventArgs e) {
        Class115.LHc();
        if (Class115.oHa == null) {
            return;
        }

        long length = new FileInfo(Class115.oHa).Length;
        if (length == Class32.eVi) {
            l8l = 0;
            Class108.io2 = new Class108.hrV(File.ReadAllBytes(Class115.oHa));
            WeH();
            return;
        }

        switch (length) {
            default:
                MessageBox.Show("Not a valid savegame file !");
                Class115.oHa = null;
                break;
            case 295904L:
            case 550976L:
            case 560528L:
                l8l = 1;
                Class26.QXu = new Class26.ux(Class115.yHr(Class115.oHa));
                Ye4();
                h8G = (int)length - 48;
                break;
            case 295856L:
            case 550928L:
            case 560480L:
                l8l = 1;
                Class26.QXu = new Class26.ux(File.ReadAllBytes(Class115.oHa));
                Ye4();
                h8G = 295856;
                break;
        }
    }

    private void led(object sender, EventArgs e) {
        try {
            Class115.FHy();
            if (Class115.kHj == null) {
                return;
            }

            if (l8l == 0) {
                if (Settings.Default.LegalCheck && Class129.jXL(bool_0: true)) {
                    new Class125().ShowDialog();
                }

                Class97.GXM();
                File.WriteAllBytes(Class115.kHj, Class108.io2.qtD());
                Class3.DHY(Class115.kHj, Class32.zVm, Class32.NV0, Class32.kVI, bool_0: false);
                MessageBox.Show("All Data Saved");
            } else if (l8l == 1) {
                Class21.ulm();
                if (Class26.QXu.Lpp != 0) {
                    Class115.SHq(Class115.kHj);
                    MessageBox.Show("All Data Saved");
                    return;
                }

                Class26.QXu.fpD();
                Class26.QXu.kpE();
                File.WriteAllBytes(Class115.kHj, (byte[])Class26.QXu.dpX);
                Class3.DHY(Class115.kHj, 8, 16, h8G - 16, bool_0: true);
                Class26.QXu.aXz();
                MessageBox.Show("All Data Saved");
            }
        } catch {
            MessageBox.Show("An error happened while saving the file !");
        }
    }

    public void WeH() {
        Text = "SplatHeX - Splatoon 1";
        S8i.Text = "amiibo challenges";
        Q81.Text = "Minigames";
        S8m.Text = "Spyke Order";
        l8t = new ResourceManager("R71.y7e", typeof(Class67).Assembly);
        Class97.pXk();
        seu();
    }

    private void Ye4() {
        S8i.Text = "Salmon Editor";
        Q81.Text = "Food Tickets";
        S8m.Text = "Murch Order";
        l8t = new ResourceManager("g7K.e7h", typeof(Class67).Assembly);
        Class21.cli();
        Text = "SplatHeX - Splatoon 2, SGRev " + Class26.QXu.Lpp;
        seu();
    }

    private void ge5(object sender, EventArgs e) {
        Close();
    }

    private void tes(object sender, EventArgs e) {
        try {
            if (l8l == 0) {
                Dictionary<int, Class25>[] dictionary_ = new Dictionary<int, Class25>[3]
                {
                    Class117.eoy,
                    Class117.qor,
                    Class117.toq
                };
                Class33[] jo = Class108.Jo3;
                Class33[] x0_ = jo;
                jo = Class108.Yod;
                Class33[] x0_2 = jo;
                jo = Class108.YoH;
                new Class109("SplatHeX - Splatoon 1 - Gears Editor", dictionary_, x0_, x0_2, jo, new int[12] { 999, 2999, 4999, 0, 1999, 5999, 9999, 0, 2999, 8999, 14999, 0 }).ShowDialog();
            } else if (l8l == 1) {
                Dictionary<int, Class25>[] dictionary_2 = new Dictionary<int, Class25>[3]
                {
                    Class85.hh5,
                    Class85.Lhs,
                    Class85.DhZ
                };
                Class33[] jo = Class26.iXg;
                Class33[] x0_3 = jo;
                jo = Class26.rX2;
                Class33[] x0_4 = jo;
                jo = Class26.pX3;
                new Class109("SplatHeX - Splatoon 2 - Gears Editor", dictionary_2, x0_3, x0_4, jo, new int[12] { 1999, 5999, 9999, 0, 2999, 6999, 10999, 0, 3999, 7999, 11999, 0 }).ShowDialog();
            }
        } catch (Exception ex) {
            MessageBox.Show("Error:" + Environment.NewLine + ex);
        }
    }

    private void heZ(object sender, EventArgs e) {
        try {
            if (l8l == 0) {
                new Class124().ShowDialog();
            } else if (l8l == 1) {
                new Class11().ShowDialog();
            }
        } catch (Exception ex) {
            MessageBox.Show("Error:" + Environment.NewLine + ex);
        }
    }

    private void Qea(object sender, EventArgs e) {
        try {
            if (l8l == 0) {
                new Class62().ShowDialog();
            } else if (l8l == 1) {
                new Class118().ShowDialog();
            }
        } catch (Exception ex) {
            MessageBox.Show("Error:" + Environment.NewLine + ex);
        }
    }

    private void Hej(object sender, EventArgs e) {
        try {
            if (l8l == 0) {
                new Class57().ShowDialog();
            } else if (l8l == 1) {
                new Class99().ShowDialog();
            }
        } catch (Exception ex) {
            MessageBox.Show("Error:" + Environment.NewLine + ex);
        }
    }

    private void cez(object sender, EventArgs e) {
        try {
            if (l8l == 0) {
                new Class56().ShowDialog();
            } else if (l8l == 1) {
                MessageBox.Show("Currently a WIP, nothing to see here.");
            }
        } catch (Exception ex) {
            MessageBox.Show("Error:" + Environment.NewLine + ex);
        }
    }

    private void Q8E(object sender, EventArgs e) {
        try {
            if (l8l == 0) {
                new Class7().ShowDialog();
            } else if (l8l == 1) {
                new Class104().ShowDialog();
            }
        } catch (Exception ex) {
            MessageBox.Show("Error:" + Environment.NewLine + ex);
        }
    }

    private void m8D(object sender, EventArgs e) {
        if (l8l == 0) {
            new Class111().ShowDialog();
        } else if (l8l == 1) {
            new Class79().ShowDialog();
        }
    }

    private void R8X(object sender, EventArgs e) {
        try {
            if (l8l == 0) {
                new Class16().ShowDialog();
            } else if (l8l == 1) {
                new Class92().ShowDialog();
            }
        } catch (Exception ex) {
            MessageBox.Show("Error:" + Environment.NewLine + ex);
        }
    }

    private void v8p(object sender, EventArgs e) {
        try {
            if (l8l == 0) {
                new Class88().ShowDialog();
            } else if (l8l == 1) {
                new Class20().ShowDialog();
            }
        } catch (Exception ex) {
            MessageBox.Show("Error:" + Environment.NewLine + ex);
        }
    }

    private void y8S(object sender, EventArgs e) {
        try {
            if (l8l == 0) {
                new Class64().ShowDialog();
            } else if (l8l == 1) {
                new Class31().ShowDialog();
            }
        } catch (Exception ex) {
            MessageBox.Show("Error:" + Environment.NewLine + ex);
        }
    }

    protected override void Dispose(bool disposing) {
        if (disposing && J8e != null) {
            J8e.Dispose();
        }

        base.Dispose(disposing);
    }

    private void k8h() {
        ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Class67));
        h88 = new GroupBox();
        Q81 = new Button();
        S8m = new Button();
        S8i = new Button();
        b8F = new Button();
        l8P = new Button();
        w87 = new Button();
        j8L = new Button();
        j8J = new Button();
        U8Q = new Button();
        M8n = new Button();
        d80 = new MenuStrip();
        N8I = new ToolStripMenuItem();
        U8R = new ToolStripMenuItem();
        V8C = new ToolStripMenuItem();
        J8Y = new ToolStripMenuItem();
        D8W = new ToolStripMenuItem();
        f8w = new ToolStripMenuItem();
        S8N = new ToolStripMenuItem();
        g8K = new ToolStripMenuItem();
        G8U = new ToolStripMenuItem();
        g8T = new ToolStripMenuItem();
        j8B = new LinkLabel();
        h88.SuspendLayout();
        d80.SuspendLayout();
        SuspendLayout();
        h88.Controls.Add(Q81);
        h88.Controls.Add(S8m);
        h88.Controls.Add(S8i);
        h88.Controls.Add(b8F);
        h88.Controls.Add(l8P);
        h88.Controls.Add(w87);
        h88.Controls.Add(j8L);
        h88.Controls.Add(j8J);
        h88.Controls.Add(U8Q);
        h88.Controls.Add(M8n);
        h88.Location = new Point(12, 26);
        h88.Name = "GB_EditPanel";
        h88.Size = new Size(509, 95);
        h88.TabIndex = 2;
        h88.TabStop = false;
        h88.Text = "Edit Option";
        Q81.Location = new Point(395, 62);
        Q81.Name = "BTN_variable2";
        Q81.Size = new Size(99, 23);
        Q81.TabIndex = 10;
        Q81.Text = "Minigames";
        Q81.UseVisualStyleBackColor = true;
        Q81.Click += y8S;
        S8m.Location = new Point(101, 62);
        S8m.Name = "BTN_SpykeOrder";
        S8m.Size = new Size(99, 23);
        S8m.TabIndex = 9;
        S8m.Text = "Spyke Order";
        S8m.UseVisualStyleBackColor = true;
        S8m.Click += v8p;
        S8i.Location = new Point(297, 62);
        S8i.Name = "BTN_variable";
        S8i.Size = new Size(99, 23);
        S8i.TabIndex = 8;
        S8i.Text = "amiibo challenges";
        S8i.UseVisualStyleBackColor = true;
        S8i.Click += R8X;
        b8F.Location = new Point(199, 62);
        b8F.Name = "BTN_Plaza";
        b8F.Size = new Size(99, 23);
        b8F.TabIndex = 5;
        b8F.Text = "Plaza Editor";
        b8F.UseVisualStyleBackColor = true;
        b8F.Click += cez;
        l8P.Location = new Point(395, 19);
        l8P.Name = "BTN_Unlock";
        l8P.Size = new Size(99, 23);
        l8P.TabIndex = 7;
        l8P.Text = "Bulk Edit";
        l8P.UseVisualStyleBackColor = true;
        l8P.Click += m8D;
        w87.Location = new Point(3, 62);
        w87.Name = "BTN_FlagEditor";
        w87.Size = new Size(99, 23);
        w87.TabIndex = 6;
        w87.Text = "Flag Editor";
        w87.UseVisualStyleBackColor = true;
        w87.Click += Q8E;
        j8L.Location = new Point(297, 19);
        j8L.Name = "BTN_SPlayer";
        j8L.Size = new Size(99, 23);
        j8L.TabIndex = 4;
        j8L.Text = "Hero Mode";
        j8L.UseVisualStyleBackColor = true;
        j8L.Click += Hej;
        j8J.Location = new Point(199, 19);
        j8J.Name = "BTN_PInfos";
        j8J.Size = new Size(99, 23);
        j8J.TabIndex = 3;
        j8J.Text = "Player Editor";
        j8J.UseVisualStyleBackColor = true;
        j8J.Click += Qea;
        U8Q.Location = new Point(101, 19);
        U8Q.Name = "BTN_Weapons";
        U8Q.Size = new Size(99, 23);
        U8Q.TabIndex = 1;
        U8Q.Text = "Weapons Editor";
        U8Q.UseVisualStyleBackColor = true;
        U8Q.Click += heZ;
        M8n.Location = new Point(3, 19);
        M8n.Name = "BTN_Gear";
        M8n.Size = new Size(99, 23);
        M8n.TabIndex = 0;
        M8n.Text = "Gears Editor";
        M8n.UseVisualStyleBackColor = true;
        M8n.Click += tes;
        d80.BackColor = Color.Transparent;
        d80.Items.AddRange(new ToolStripItem[3] { N8I, D8W, g8K });
        d80.Location = new Point(0, 0);
        d80.Name = "menuStrip";
        d80.Size = new Size(527, 24);
        d80.TabIndex = 3;
        d80.Text = "menuStrip";
        N8I.DropDownItems.AddRange(new ToolStripItem[3] { U8R, V8C, J8Y });
        N8I.Name = "fileToolStripMenuItem";
        N8I.Size = new Size(37, 20);
        N8I.Text = "File";
        U8R.Image = (Image)componentResourceManager.GetObject("openToolStripMenuItem.Image");
        U8R.Name = "openToolStripMenuItem";
        U8R.Size = new Size(180, 22);
        U8R.Text = "Open";
        U8R.Click += Ce3;
        V8C.Image = (Image)componentResourceManager.GetObject("saveAsToolStripMenuItem.Image");
        V8C.Name = "saveAsToolStripMenuItem";
        V8C.Size = new Size(180, 22);
        V8C.Text = "Save As";
        V8C.Click += led;
        J8Y.Image = (Image)componentResourceManager.GetObject("closeToolStripMenuItem.Image");
        J8Y.Name = "closeToolStripMenuItem";
        J8Y.Size = new Size(180, 22);
        J8Y.Text = "Close";
        J8Y.Click += ge5;
        D8W.DropDownItems.AddRange(new ToolStripItem[1] { f8w });
        D8W.Name = "toolStripMenuItem";
        D8W.Size = new Size(47, 20);
        D8W.Text = "Tools";
        f8w.DropDownItems.AddRange(new ToolStripItem[1] { S8N });
        f8w.Image = (Image)componentResourceManager.GetObject("loadToolStripMenuItem.Image");
        f8w.Name = "loadToolStripMenuItem";
        f8w.Size = new Size(181, 22);
        f8w.Text = "Manage Save With...";
        S8N.Image = (Image)componentResourceManager.GetObject("Gecko_LoadSave.Image");
        S8N.Name = "Gecko_LoadSave";
        S8N.Size = new Size(198, 22);
        S8N.Text = "TCP Gecko (Splatoon 1)";
        S8N.Click += Jer;
        g8K.DropDownItems.AddRange(new ToolStripItem[2] { G8U, g8T });
        g8K.Name = "aboutToolStripMenuItem";
        g8K.Size = new Size(61, 20);
        g8K.Text = "Options";
        G8U.Checked = true;
        G8U.CheckOnClick = true;
        G8U.CheckState = CheckState.Checked;
        G8U.Name = "Menu_LegalCheck";
        G8U.Size = new Size(180, 22);
        G8U.Text = "Auto Legality Check";
        G8U.Click += dek;
        g8T.Image = (Image)componentResourceManager.GetObject("Menu_About.Image");
        g8T.Name = "Menu_About";
        g8T.Size = new Size(180, 22);
        g8T.Text = "About SplatHeX";
        g8T.Click += wey;
        j8B.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        j8B.Location = new Point(281, 8);
        j8B.Name = "L_StringUpdate";
        j8B.Size = new Size(233, 13);
        j8B.TabIndex = 4;
        j8B.TabStop = true;
        j8B.Text = "A New Version is Available!";
        j8B.TextAlign = ContentAlignment.MiddleRight;
        j8B.Visible = false;
        AllowDrop = true;
        base.AutoScaleDimensions = new SizeF(6f, 13f);
        base.AutoScaleMode = AutoScaleMode.Font;
        base.ClientSize = new Size(527, 126);
        base.Controls.Add(j8B);
        base.Controls.Add(h88);
        base.Controls.Add(d80);
        base.FormBorderStyle = FormBorderStyle.FixedSingle;
        base.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
        base.MaximizeBox = false;
        base.Name = "MainForm";
        base.StartPosition = FormStartPosition.CenterScreen;
        Text = "SplatHeX";
        h88.ResumeLayout(performLayout: false);
        d80.ResumeLayout(performLayout: false);
        d80.PerformLayout();
        ResumeLayout(performLayout: false);
        PerformLayout();
    }
}