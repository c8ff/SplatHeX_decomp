using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SplatHex;
public class Class8 : Form {
    public static int Gb5;
    private IDisposable Gbs;
    private Class35 sbZ;
    private CheckBox Uba;
    private Button jbj;
    private Button Mbz;
    public Class8() {
        Ob4();
        Mbz.Enabled = false;
        Bbg();
    }

    private void Bbg() {
        sbZ.Controls.Clear();
        List<int> list = Class46.Lou.Keys.ToList();
        list.Sort();
        foreach (int item in list) {
            if (Class22.WXv(item)) {
                continue;
            }

            if (!Uba.Checked) {
                Button button = new Button();
                button.BackgroundImage = Class22.hXh(item, Class46.Lou);
                button.AccessibleDescription = Class22.KXS(item, Class46.Lou);
                button.BackgroundImageLayout = ImageLayout.Zoom;
                button.Click += Yb2;
                button.Size = new Size(80, 80);
                button.Name = "Weap" + item;
                sbZ.Controls.Add(button);
                if (!Class22.vXO(item)) {
                    button.Image = Resources.warning;
                    button.ImageAlign = ContentAlignment.TopRight;
                }
            } else if (Class22.vXO(item)) {
                Button button2 = new Button();
                button2.BackgroundImage = Class22.hXh(item, Class46.Lou);
                button2.AccessibleDescription = Class22.KXS(item, Class46.Lou);
                button2.BackgroundImageLayout = ImageLayout.Zoom;
                button2.Click += Yb2;
                button2.Size = new Size(80, 80);
                button2.Name = "Weap" + item;
                sbZ.Controls.Add(button2);
            }
        }

        if (sbZ.Controls.Count == 0) {
            Text = "No new weapons to add.";
        } else {
            Text = "Add New Weapon";
        }
    }

    private void Yb2(object sender, EventArgs e) {
        Mbz.Enabled = true;
        Text = ((Button)sender).AccessibleDescription;
        string name = ((Button)sender).Name;
        name = name.Remove(0, 4);
        Gb5 = int.Parse(name);
    }

    private void wb3(object sender, EventArgs e) {
        Close();
    }

    private void qbd(object sender, EventArgs e) {
        Gb5 = -1;
        Close();
    }

    private void zbH(object sender, EventArgs e) {
        Bbg();
        Gb5 = -1;
    }

    protected override void Dispose(bool disposing) {
        if (disposing && Gbs != null) {
            Gbs.Dispose();
        }

        base.Dispose(disposing);
    }

    private void Ob4() {
        sbZ = new Class35();
        Uba = new CheckBox();
        jbj = new Button();
        Mbz = new Button();
        SuspendLayout();
        sbZ.AutoScroll = true;
        sbZ.Dock = DockStyle.Top;
        sbZ.Location = new Point(0, 0);
        sbZ.Name = "weaponsPanel";
        sbZ.Size = new Size(457, 269);
        sbZ.TabIndex = 1;
        Uba.AutoSize = true;
        Uba.Checked = true;
        Uba.CheckState = CheckState.Checked;
        Uba.Location = new Point(4, 278);
        Uba.Name = "CB_ShowLegal";
        Uba.Size = new Size(296, 17);
        Uba.TabIndex = 6;
        Uba.Text = "Only show weapons that is available for your current level";
        Uba.UseVisualStyleBackColor = true;
        Uba.CheckedChanged += zbH;
        jbj.Location = new Point(383, 274);
        jbj.Name = "B_Cancel";
        jbj.Size = new Size(49, 23);
        jbj.TabIndex = 5;
        jbj.Text = "Cancel";
        jbj.UseVisualStyleBackColor = true;
        jbj.Click += qbd;
        Mbz.Location = new Point(328, 274);
        Mbz.Name = "B_Add";
        Mbz.Size = new Size(49, 23);
        Mbz.TabIndex = 4;
        Mbz.Text = "Add";
        Mbz.UseVisualStyleBackColor = true;
        Mbz.Click += wb3;
        base.AutoScaleDimensions = new SizeF(6f, 13f);
        base.AutoScaleMode = AutoScaleMode.Font;
        base.ClientSize = new Size(457, 302);
        base.ControlBox = false;
        base.Controls.Add(Uba);
        base.Controls.Add(jbj);
        base.Controls.Add(Mbz);
        base.Controls.Add(sbZ);
        base.Name = "AddNewWeaponS1";
        base.ShowIcon = false;
        base.StartPosition = FormStartPosition.CenterScreen;
        Text = "Add New Weapon";
        ResumeLayout(performLayout: false);
        PerformLayout();
    }

    static zrr() {
        Gb5 = -1;
    }
}