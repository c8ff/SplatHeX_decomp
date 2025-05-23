using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SplatHex;
public class Class125 : Form {
    public bool XV3;
    public bool GVd;
    public bool rVH;
    public bool CV4;
    public int SV5;
    public int aVs;
    public int OVZ;
    public int AVa;
    private IDisposable RVj;
    private GroupBox UVz;
    private CheckBox hOE;
    private CheckBox UOD;
    private CheckBox cOX;
    private CheckBox GOp;
    private Button VOS;
    private RichTextBox EOh;
    private CheckBox ROl;
    public Class125() {
        AV2();
        if (!Settings.Default.FlagMessage1) {
            zVg("Here you can fix impossible data, like gears and/or weapons you are not supposed to own at your current level and invalid gear ID's that can be used to wear hidden gear sets.\n\nIf you just want to avoid a ban, check all the checkboxes and select 'Fix'");
            Settings.Default.FlagMessage1 = true;
            Settings.Default.Save();
        }
    }

    private void tVk(Dictionary<int, int> dictionary_0, Dictionary<int, Class25> dictionary_1, Class108.fr2[] fr2_0, string string_0) {
        SV5 = 0;
        OVZ = 0;
        for (int i = 0; i < fr2_0.Length; i++) {
            if (rVH && fr2_0[i].hXP != -1 && !Class4.rDg(fr2_0[i].hXP, dictionary_0)) {
                Class4.ODH(fr2_0, fr2_0[i]);
                OVZ++;
            }

            if (XV3 && fr2_0[i].hXP != -1 && !dictionary_1.ContainsKey(fr2_0[i].hXP)) {
                Class4.ODH(fr2_0, fr2_0[i]);
                SV5++;
            }
        }

        if (OVZ != 0) {
            zVg("Removed: " + OVZ + " " + string_0 + " you aren't supposed to own.");
        }

        if (SV5 != 0) {
            zVg("Removed: " + SV5 + " invalid gears.");
        }

        if (SV5 == 0 && OVZ == 0) {
            zVg("Clean: " + string_0 + " data");
        }

        Class4.DD5(fr2_0);
    }

    private void xVM() {
        aVs = 0;
        AVa = 0;
        for (int i = 0; i < Class108.Vo4.Length; i++) {
            if (CV4 && Class108.Vo4[i].btx != -1 && !Class22.vXO(Class108.Vo4[i].btx)) {
                Class22.NXn(i);
                AVa++;
            }

            if (GVd && Class108.Vo4[i].btx != -1 && !Class46.Lou.ContainsKey(Class108.Vo4[i].btx)) {
                Class22.NXn(i);
                aVs++;
            }
        }

        if (AVa != 0) {
            zVg("Removed: " + AVa + " weapons you aren't supposed to own.");
        }

        if (aVs != 0) {
            zVg("Removed: " + aVs + " invalid weapons.");
        }

        if (aVs == 0 && AVa == 0) {
            zVg("Clean: Weapons data");
        }

        Class22.nXF();
    }

    private void UVu(object sender, EventArgs e) {
        EOh.Clear();
        XV3 = (GOp.Checked ? true : false);
        GVd = (UOD.Checked ? true : false);
        rVH = (hOE.Checked ? true : false);
        CV4 = (cOX.Checked ? true : false);
        if (XV3 || rVH) {
            tVk(Class117.Sox, Class117.eoy, Class108.Jo3, "Hat");
            tVk(Class117.Qo9, Class117.qor, Class108.Yod, "Clothes");
            tVk(Class117.Yoc, Class117.toq, Class108.YoH, "Shoes");
        }

        if (GVd || CV4) {
            xVM();
        }

        if (ROl.Checked && Class108.io2.Tti < 10 && (Class108.io2.TtR != 0 || Class108.io2.ftC != 0)) {
            Class108.io2.ftC = 0;
            Class108.io2.TtR = 0;
            zVg("Removed: Player Rank");
        }
    }

    private void zVg(string string_0) {
        if (!string.IsNullOrWhiteSpace(EOh.Text)) {
            EOh.AppendText("\r\n" + string_0);
        } else {
            EOh.AppendText(string_0);
        }

        EOh.ScrollToCaret();
    }

    protected override void Dispose(bool disposing) {
        if (disposing && RVj != null) {
            RVj.Dispose();
        }

        base.Dispose(disposing);
    }

    private void AV2() {
        UVz = new GroupBox();
        UOD = new CheckBox();
        cOX = new CheckBox();
        GOp = new CheckBox();
        hOE = new CheckBox();
        VOS = new Button();
        EOh = new RichTextBox();
        ROl = new CheckBox();
        UVz.SuspendLayout();
        SuspendLayout();
        UVz.Controls.Add(ROl);
        UVz.Controls.Add(UOD);
        UVz.Controls.Add(cOX);
        UVz.Controls.Add(GOp);
        UVz.Controls.Add(hOE);
        UVz.Location = new Point(12, 12);
        UVz.Name = "groupBox1";
        UVz.Size = new Size(282, 131);
        UVz.TabIndex = 0;
        UVz.TabStop = false;
        UVz.Text = "Options:";
        UOD.AutoSize = true;
        UOD.Checked = true;
        UOD.CheckState = CheckState.Checked;
        UOD.Location = new Point(6, 88);
        UOD.Name = "CB_RemoveHiddenWeapons";
        UOD.Size = new Size(149, 17);
        UOD.TabIndex = 3;
        UOD.Text = "Remove Invalid Weapons";
        UOD.UseVisualStyleBackColor = true;
        cOX.AutoSize = true;
        cOX.Checked = true;
        cOX.CheckState = CheckState.Checked;
        cOX.Location = new Point(6, 65);
        cOX.Name = "CB_FixIllegalWeapons";
        cOX.Size = new Size(248, 17);
        cOX.TabIndex = 2;
        cOX.Text = "Remove Weapons you aren't supposed to own";
        cOX.UseVisualStyleBackColor = true;
        GOp.AutoSize = true;
        GOp.Checked = true;
        GOp.CheckState = CheckState.Checked;
        GOp.Location = new Point(6, 42);
        GOp.Name = "CB_RemoveHiddenGears";
        GOp.Size = new Size(134, 17);
        GOp.TabIndex = 1;
        GOp.Text = "Remove Invalid Gears ";
        GOp.UseVisualStyleBackColor = true;
        hOE.AutoSize = true;
        hOE.Checked = true;
        hOE.CheckState = CheckState.Checked;
        hOE.Location = new Point(6, 19);
        hOE.Name = "CB_FixIllegalGears";
        hOE.Size = new Size(230, 17);
        hOE.TabIndex = 0;
        hOE.Text = "Remove Gears you aren't supposed to own";
        hOE.UseVisualStyleBackColor = true;
        VOS.Location = new Point(122, 258);
        VOS.Name = "B_Fix";
        VOS.Size = new Size(48, 23);
        VOS.TabIndex = 2;
        VOS.Text = "Fix";
        VOS.UseVisualStyleBackColor = true;
        VOS.Click += UVu;
        EOh.BackColor = SystemColors.Control;
        EOh.Location = new Point(12, 145);
        EOh.Name = "RTB_Logs";
        EOh.ReadOnly = true;
        EOh.Size = new Size(282, 110);
        EOh.TabIndex = 26;
        EOh.Text = "";
        ROl.AutoSize = true;
        ROl.Checked = true;
        ROl.CheckState = CheckState.Checked;
        ROl.Location = new Point(6, 111);
        ROl.Name = "CB_FixRank";
        ROl.Size = new Size(198, 17);
        ROl.TabIndex = 4;
        ROl.Text = "Remove rank if player level is < lvl10";
        ROl.UseVisualStyleBackColor = true;
        base.AutoScaleDimensions = new SizeF(6f, 13f);
        base.AutoScaleMode = AutoScaleMode.Font;
        base.ClientSize = new Size(306, 288);
        base.Controls.Add(EOh);
        base.Controls.Add(VOS);
        base.Controls.Add(UVz);
        base.Name = "CheckLegalitySplat1";
        base.ShowIcon = false;
        base.StartPosition = FormStartPosition.CenterScreen;
        Text = "SplatHeX";
        UVz.ResumeLayout(performLayout: false);
        UVz.PerformLayout();
        ResumeLayout(performLayout: false);
    }
}