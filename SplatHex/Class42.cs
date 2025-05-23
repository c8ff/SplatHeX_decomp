using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SplatHex;
public class Class42 : Form {
    public static int Uvl;
    private IDisposable rvG;
    private CheckBox evb;
    private Button Gvv;
    private Button Wvo;
    private Class35 Yvt;
    public Class42() {
        nvh();
        Wvo.Enabled = false;
        vvE();
    }

    private void vvE() {
        Yvt.Controls.Clear();
        List<int> list = Class122.PlD.Keys.ToList();
        list.Sort();
        foreach (int item in list) {
            if (Class122.PlD[item].tXX || Class22.LXo(item) || !Class122.PlD[item].sDs(Class26.QXu.UpS)) {
                continue;
            }

            if (evb.Checked) {
                if (Class22.JXe(item)) {
                    Button button = new Button();
                    button.BackgroundImage = (Image)Class122.PlD[item].oDz;
                    button.AccessibleDescription = Class122.PlD[item].aDj;
                    button.BackgroundImageLayout = ImageLayout.Zoom;
                    button.Click += TvD;
                    button.Size = new Size(80, 80);
                    button.Name = "Weap" + item;
                    Yvt.Controls.Add(button);
                }

                continue;
            }

            Button button2 = new Button();
            button2.BackgroundImage = (Image)Class122.PlD[item].oDz;
            button2.AccessibleDescription = Class122.PlD[item].aDj;
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.Click += TvD;
            button2.Size = new Size(80, 80);
            button2.Name = "Weap" + item;
            Yvt.Controls.Add(button2);
            if (!Class22.JXe(item)) {
                button2.Image = Resources.warning;
                button2.ImageAlign = ContentAlignment.TopRight;
            }
        }

        if (Yvt.Controls.Count == 0) {
            Text = "No new weapons to add.";
        } else {
            Text = "Add New Weapon";
        }
    }

    private void TvD(object sender, EventArgs e) {
        Wvo.Enabled = true;
        Text = ((Button)sender).AccessibleDescription;
        string name = ((Button)sender).Name;
        name = name.Remove(0, 4);
        Uvl = int.Parse(name);
    }

    private void VvX(object sender, EventArgs e) {
        Close();
    }

    private void Mvp(object sender, EventArgs e) {
        Uvl = -1;
        Close();
    }

    private void SvS(object sender, EventArgs e) {
        vvE();
        Uvl = -1;
    }

    protected override void Dispose(bool disposing) {
        if (disposing && rvG != null) {
            rvG.Dispose();
        }

        base.Dispose(disposing);
    }

    private void nvh() {
        evb = new CheckBox();
        Gvv = new Button();
        Wvo = new Button();
        Yvt = new Class35();
        SuspendLayout();
        evb.AutoSize = true;
        evb.Checked = true;
        evb.CheckState = CheckState.Checked;
        evb.Location = new Point(4, 278);
        evb.Name = "CB_ShowLegal";
        evb.Size = new Size(296, 17);
        evb.TabIndex = 10;
        evb.Text = "Only show weapons that is available for your current level";
        evb.UseVisualStyleBackColor = true;
        evb.CheckedChanged += SvS;
        Gvv.Location = new Point(383, 274);
        Gvv.Name = "B_Cancel";
        Gvv.Size = new Size(49, 23);
        Gvv.TabIndex = 9;
        Gvv.Text = "Cancel";
        Gvv.UseVisualStyleBackColor = true;
        Gvv.Click += Mvp;
        Wvo.Location = new Point(328, 274);
        Wvo.Name = "B_Add";
        Wvo.Size = new Size(49, 23);
        Wvo.TabIndex = 8;
        Wvo.Text = "Add";
        Wvo.UseVisualStyleBackColor = true;
        Wvo.Click += VvX;
        Yvt.AutoScroll = true;
        Yvt.Dock = DockStyle.Top;
        Yvt.Location = new Point(0, 0);
        Yvt.Name = "weaponsPanel";
        Yvt.Size = new Size(457, 269);
        Yvt.TabIndex = 7;
        base.AutoScaleDimensions = new SizeF(6f, 13f);
        base.AutoScaleMode = AutoScaleMode.Font;
        base.ClientSize = new Size(457, 302);
        base.ControlBox = false;
        base.Controls.Add(evb);
        base.Controls.Add(Gvv);
        base.Controls.Add(Wvo);
        base.Controls.Add(Yvt);
        base.Name = "AddNewWeaponS2";
        base.ShowIcon = false;
        base.StartPosition = FormStartPosition.CenterScreen;
        Text = "Add New Weapon";
        ResumeLayout(performLayout: false);
        PerformLayout();
    }

    static Class42() {
        Uvl = -1;
    }
}