using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SplatHex;
public class Class79 : Form {
    private int[] wCK = new int[9]
    {
        0,
        16,
        227696,
        240984,
        265168,
        276688,
        295568,
        295852,
        550924
    };
    private int[] wCU = new int[9]
    {
        16,
        176656,
        13288,
        24184,
        11520,
        18880,
        284,
        255072,
        9556
    };
    private int[] vCT = new int[23]
    {
        0,
        1,
        2,
        3,
        4,
        5,
        6,
        7,
        8,
        9,
        10,
        11,
        12,
        13,
        14,
        15,
        16,
        17,
        18,
        19,
        20,
        21,
        22
    };
    private IDisposable MC1;
    private GroupBox VCW;
    private CheckBox HCw;
    private Button fCN;
    private Button XCY;
    private GroupBox SCB;
    private ComboBox LCA;
    private Button YCf;
    private Button IC6;
    private Button CCx;
    private GroupBox HC9;
    private Button ACc;
    private Button nCy;
    public Class79() {
        KCC();
        LCA.SelectedIndex = 0;
    }

    private void GCJ(object sender, EventArgs e) {
        DialogResult dialogResult = MessageBox.Show("Are you sure you want to unlock all gears ?\n(This will unlock all gears you don't have yet, none of your actual gears will be overwritten.)", "", MessageBoxButtons.YesNo);
        if (dialogResult == DialogResult.Yes) {
            jC7(Class85.hh5, Class26.iXg);
            jC7(Class85.Lhs, Class26.rX2);
            jC7(Class85.DhZ, Class26.pX3);
            MessageBox.Show("All Gears unlocked.");
        }
    }

    private void jC7(Dictionary<int, Class25> dictionary_0, Class26.P4[] p4_0) {
        List<int> list = dictionary_0.Keys.ToList();
        list.Sort();
        foreach (int item in list) {
            if (!Class4.kDM(item, p4_0) && !dictionary_0[item].kDx && (!HCw.Checked || Class4.bD2(item))) {
                int num = Class115.nHs(0, 13);
                Class4.LDd(p4_0, item, 4, 4, dictionary_0[item].YDA, num, num, num, Class115.vHZ(), 0);
            }
        }
    }

    private void gCP(object sender, EventArgs e) {
        DialogResult dialogResult = MessageBox.Show("Are you sure you want to unlock all weapons ?\n(This will unlock all weapons you don't have yet, none of your actual gears will be overwritten.)", "", MessageBoxButtons.YesNo);
        if (dialogResult != DialogResult.Yes) {
            return;
        }

        List<int> list = Class122.PlD.Keys.ToList();
        list.Sort();
        foreach (int item in list) {
            if (!Class22.LXo(item) && !Class122.PlD[item].tXX && (!HCw.Checked || Class22.JXe(item))) {
                int num = Class22.YXV(Class26.RXd);
                if (num != 1000) {
                    Class22.JXb(num, item, Class115.vHZ(), 0, Class122.PlD[item].WXE, Class122.PlD[item].DXD);
                }
            }
        }

        MessageBox.Show("All Weapons unlocked.");
    }

    private void bCi(object sender, EventArgs e) {
        int selectedIndex = LCA.SelectedIndex;
        Class26.QXu.kpE();
        Class115.bH4(Class26.QXu.dpX, wCK[selectedIndex], wCU[selectedIndex], LCA.Text, LCA.Text);
        Class26.QXu.aXz();
    }

    private void LCm(object sender, EventArgs e) {
        for (int i = 0; i < vCT.Length; i++) {
            byte[] bytes = BitConverter.GetBytes(vCT[i]);
            Array.Copy(bytes, 0, Class26.QXu.fSW, i * 4, 4);
        }

        MessageBox.Show("Done.");
    }

    private void KC0(object sender, EventArgs e) {
        for (int i = 0; i < 256; i++) {
            Array.Copy(BitConverter.GetBytes(uint.MaxValue), 0, Class26.QXu.WSw, i * 12, 4);
            Array.Copy(BitConverter.GetBytes(0), 0, Class26.QXu.WSw, i * 12 + 4, 4);
            Array.Copy(BitConverter.GetBytes(0), 0, Class26.QXu.WSw, i * 12 + 8, 4);
        }

        for (int j = 0; j < Class122.PlD.Count; j++) {
            Array.Copy(BitConverter.GetBytes(Class122.PlD.Keys.ElementAt(j)), 0, Class26.QXu.WSw, j * 12, 4);
            Array.Copy(BitConverter.GetBytes(16843009), 0, Class26.QXu.WSw, j * 12 + 4, 4);
            Array.Copy(BitConverter.GetBytes(0), 0, Class26.QXu.WSw, j * 12 + 8, 4);
        }

        for (int k = 0; k < 4; k++) {
            Array.Copy(BitConverter.GetBytes(6), 0, Class26.QXu.wSN, 4 * k, 4);
            Array.Copy(BitConverter.GetBytes(16843009), 0, Class26.QXu.wSN, 4 * k + 16, 4);
        }

        MessageBox.Show("Done.");
    }

    private void wCI(object sender, EventArgs e) {
        for (int i = 1; i < vCT.Length; i++) {
            byte[] bytes = BitConverter.GetBytes(uint.MaxValue);
            Array.Copy(bytes, 0, Class26.QXu.fSW, i * 4, 4);
        }

        MessageBox.Show("Done.");
    }

    private void ACR(object sender, EventArgs e) {
        int selectedIndex = LCA.SelectedIndex;
        Class26.QXu.kpE();
        Class115.LH5((Array)Class26.QXu.dpX, wCK[selectedIndex], wCU[selectedIndex], LCA.Text, LCA.Text);
        Class26.QXu.aXz();
        MessageBox.Show("Done.");
    }

    protected override void Dispose(bool disposing) {
        if (disposing && MC1 != null) {
            MC1.Dispose();
        }

        base.Dispose(disposing);
    }

    private void KCC() {
        VCW = new GroupBox();
        HCw = new CheckBox();
        fCN = new Button();
        XCY = new Button();
        SCB = new GroupBox();
        YCf = new Button();
        IC6 = new Button();
        LCA = new ComboBox();
        CCx = new Button();
        HC9 = new GroupBox();
        nCy = new Button();
        ACc = new Button();
        VCW.SuspendLayout();
        SCB.SuspendLayout();
        HC9.SuspendLayout();
        SuspendLayout();
        VCW.Controls.Add(HCw);
        VCW.Controls.Add(fCN);
        VCW.Controls.Add(XCY);
        VCW.Location = new Point(33, 12);
        VCW.Name = "groupBox1";
        VCW.Size = new Size(210, 74);
        VCW.TabIndex = 19;
        VCW.TabStop = false;
        VCW.Text = "Unlock all:";
        HCw.AutoSize = true;
        HCw.Checked = true;
        HCw.CheckState = CheckState.Checked;
        HCw.Location = new Point(8, 51);
        HCw.Name = "CB_Legal";
        HCw.Size = new Size(197, 17);
        HCw.TabIndex = 22;
        HCw.Text = "Only if the item match with your level";
        HCw.UseVisualStyleBackColor = true;
        fCN.ImeMode = ImeMode.NoControl;
        fCN.Location = new Point(125, 23);
        fCN.Name = "B_UWeapons";
        fCN.Size = new Size(79, 23);
        fCN.TabIndex = 21;
        fCN.Text = "Weapons";
        fCN.UseVisualStyleBackColor = true;
        fCN.Click += gCP;
        XCY.ImeMode = ImeMode.NoControl;
        XCY.Location = new Point(6, 23);
        XCY.Name = "B_UGear";
        XCY.Size = new Size(77, 22);
        XCY.TabIndex = 20;
        XCY.Text = "Gears";
        XCY.UseVisualStyleBackColor = true;
        XCY.Click += GCJ;
        SCB.Controls.Add(YCf);
        SCB.Controls.Add(IC6);
        SCB.Controls.Add(LCA);
        SCB.Location = new Point(33, 198);
        SCB.Name = "groupBox2";
        SCB.Size = new Size(210, 79);
        SCB.TabIndex = 20;
        SCB.TabStop = false;
        SCB.Text = "Save Partition Tool";
        YCf.Location = new Point(125, 46);
        YCf.Name = "B_RestorePart";
        YCf.Size = new Size(75, 23);
        YCf.TabIndex = 2;
        YCf.Text = "Restore";
        YCf.UseVisualStyleBackColor = true;
        YCf.Click += ACR;
        IC6.Location = new Point(8, 46);
        IC6.Name = "B_DumpPart";
        IC6.Size = new Size(75, 23);
        IC6.TabIndex = 1;
        IC6.Text = "Dump";
        IC6.UseVisualStyleBackColor = true;
        IC6.Click += bCi;
        LCA.DropDownStyle = ComboBoxStyle.DropDownList;
        LCA.FormattingEnabled = true;
        LCA.Items.AddRange(new object[9] { "Header", "Common", "Local", "Mission", "Shop", "Coop", "Fest", "Statistics", "Octo" });
        LCA.Location = new Point(43, 19);
        LCA.Name = "CB_Partitions";
        LCA.Size = new Size(121, 21);
        LCA.TabIndex = 0;
        CCx.Location = new Point(34, 20);
        CCx.Name = "B_ShoalMaps";
        CCx.Size = new Size(141, 23);
        CCx.TabIndex = 21;
        CCx.Text = "Unlock Every Shoal Map";
        CCx.UseVisualStyleBackColor = true;
        CCx.Click += LCm;
        HC9.Controls.Add(nCy);
        HC9.Controls.Add(ACc);
        HC9.Controls.Add(CCx);
        HC9.Location = new Point(33, 92);
        HC9.Name = "groupBox3";
        HC9.Size = new Size(210, 100);
        HC9.TabIndex = 22;
        HC9.TabStop = false;
        HC9.Text = "Offline Unlock";
        nCy.Location = new Point(34, 46);
        nCy.Name = "B_RShoalMap";
        nCy.Size = new Size(141, 23);
        nCy.TabIndex = 23;
        nCy.Text = "Remove Every Shoal Map";
        nCy.UseVisualStyleBackColor = true;
        nCy.Click += wCI;
        ACc.Location = new Point(34, 73);
        ACc.Name = "B_WeaponUnlock";
        ACc.Size = new Size(141, 23);
        ACc.TabIndex = 22;
        ACc.Text = "Every Weapon is Buyable";
        ACc.UseVisualStyleBackColor = true;
        ACc.Click += KC0;
        base.AutoScaleDimensions = new SizeF(6f, 13f);
        base.AutoScaleMode = AutoScaleMode.Font;
        base.ClientSize = new Size(288, 199);
        base.Controls.Add(HC9);
        base.Controls.Add(SCB);
        base.Controls.Add(VCW);
        base.Name = "UnlockSplat2";
        base.ShowIcon = false;
        base.StartPosition = FormStartPosition.CenterScreen;
        Text = "Bulk Edit";
        VCW.ResumeLayout(performLayout: false);
        VCW.PerformLayout();
        SCB.ResumeLayout(performLayout: false);
        HC9.ResumeLayout(performLayout: false);
        ResumeLayout(performLayout: false);
    }
}