using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SplatHex;
public class Class63 : Form {
    public static int abf;
    private Class33[] Yb6;
    private object Tbx;
    private int ub9;
    private int ybc;
    private Dictionary<int, int> Bby;
    private IDisposable ebr;
    private Class35 ybq;
    private Button bbk;
    private Button TbM;
    private CheckBox Vbu;
    public Class63(Class33[] x0_0, Dictionary<int, Class25>[] dictionary_0, int int_0, int int_1 = 0, Dictionary<int, int> dictionary_1 = null) {
        vbA();
        if (dictionary_1 == null) {
            dictionary_1 = new Dictionary<int, int>();
        }

        bbW(x0_0, dictionary_0, int_0, int_1, dictionary_1);
        Yb6 = x0_0;
        Tbx = dictionary_0;
        ub9 = int_0;
        ybc = int_1;
        Bby = dictionary_1;
    }

    private void bbW(Class33[] x0_0, Dictionary<int, Class25>[] dictionary_0, int int_0, int int_1 = 0, Dictionary<int, int> dictionary_1 = null) {
        ybq.Controls.Clear();
        List<int> list = dictionary_0[int_0].Keys.ToList();
        list.Sort();
        foreach (int item in list) {
            if (dictionary_0[int_0][item].kDx || Class4.kDM(item, x0_0) || !dictionary_0[int_0][item].mjTM(int_1)) {
                continue;
            }

            if (Vbu.Checked) {
                if (Class67.l8l == 0) {
                    if (Class4.rDg(item, dictionary_1)) {
                        Button button = new Button();
                        button.BackgroundImage = Class4.ADq(item, dictionary_0[int_0]);
                        button.AccessibleDescription = Class4.SDr(item, dictionary_0[int_0]);
                        button.BackgroundImageLayout = ImageLayout.Zoom;
                        button.Size = new Size(80, 80);
                        button.Name = "gear" + item;
                        ybq.Controls.Add(button);
                        button.Click += ybw;
                    }
                } else if (Class67.l8l == 1 && Class4.bD2(item)) {
                    Button button2 = new Button();
                    button2.BackgroundImage = Class4.ADq(item, dictionary_0[int_0]);
                    button2.AccessibleDescription = Class4.SDr(item, dictionary_0[int_0]);
                    button2.BackgroundImageLayout = ImageLayout.Zoom;
                    button2.Size = new Size(80, 80);
                    button2.Name = "gear" + item;
                    ybq.Controls.Add(button2);
                    button2.Click += ybw;
                }

                continue;
            }

            Button button3 = new Button();
            button3.BackgroundImage = Class4.ADq(item, dictionary_0[int_0]);
            button3.AccessibleDescription = Class4.SDr(item, dictionary_0[int_0]);
            button3.BackgroundImageLayout = ImageLayout.Zoom;
            button3.Size = new Size(80, 80);
            button3.Name = "gear" + item;
            ybq.Controls.Add(button3);
            button3.Click += ybw;
            if (Class67.l8l == 0) {
                if (!Class4.rDg(item, dictionary_1)) {
                    button3.Image = Resources.warning;
                    button3.ImageAlign = ContentAlignment.TopRight;
                }
            } else if (Class67.l8l == 1 && !Class4.bD2(item)) {
                button3.Image = Resources.warning;
                button3.ImageAlign = ContentAlignment.TopRight;
            }
        }
    }

    private void ybw(object sender, EventArgs e) {
        bbk.Enabled = true;
        if (((Button)sender).AccessibleDescription == null) {
            Text = " ";
        } else {
            Text = ((Button)sender).AccessibleDescription;
        }

        string name = ((Button)sender).Name;
        name = name.Remove(0, 4);
        abf = int.Parse(name);
    }

    private void bbN(object sender, EventArgs e) {
        Close();
    }

    private void IbY(object sender, EventArgs e) {
        abf = -1;
        Close();
    }

    private void QbB(object sender, EventArgs e) {
        bbW(Yb6, (Dictionary<int, Class25>[])Tbx, ub9, ybc, Bby);
        abf = -1;
    }

    protected override void Dispose(bool disposing) {
        if (disposing && ebr != null) {
            ebr.Dispose();
        }

        base.Dispose(disposing);
    }

    private void vbA() {
        bbk = new Button();
        TbM = new Button();
        Vbu = new CheckBox();
        ybq = new Class35();
        SuspendLayout();
        bbk.Location = new Point(328, 274);
        bbk.Name = "B_Add";
        bbk.Size = new Size(49, 23);
        bbk.TabIndex = 1;
        bbk.Text = "Add";
        bbk.UseVisualStyleBackColor = true;
        bbk.Click += bbN;
        TbM.Location = new Point(383, 274);
        TbM.Name = "B_Cancel";
        TbM.Size = new Size(49, 23);
        TbM.TabIndex = 2;
        TbM.Text = "Cancel";
        TbM.UseVisualStyleBackColor = true;
        TbM.Click += IbY;
        Vbu.AutoSize = true;
        Vbu.Checked = true;
        Vbu.CheckState = CheckState.Checked;
        Vbu.Location = new Point(4, 278);
        Vbu.Name = "CB_ShowLegal";
        Vbu.Size = new Size(274, 17);
        Vbu.TabIndex = 3;
        Vbu.Text = "Only show gear that is available for your current level";
        Vbu.UseVisualStyleBackColor = true;
        Vbu.CheckedChanged += QbB;
        ybq.AutoScroll = true;
        ybq.Dock = DockStyle.Top;
        ybq.Location = new Point(0, 0);
        ybq.Name = "gearsPanel";
        ybq.Size = new Size(457, 269);
        ybq.TabIndex = 0;
        base.AutoScaleDimensions = new SizeF(6f, 13f);
        base.AutoScaleMode = AutoScaleMode.Font;
        base.ClientSize = new Size(457, 302);
        base.ControlBox = false;
        base.Controls.Add(Vbu);
        base.Controls.Add(TbM);
        base.Controls.Add(bbk);
        base.Controls.Add(ybq);
        base.Name = "AddNewGear";
        base.ShowIcon = false;
        base.StartPosition = FormStartPosition.CenterScreen;
        Text = "Add New Gear";
        ResumeLayout(performLayout: false);
        PerformLayout();
    }

    static wz() {
        abf = -1;
    }
}