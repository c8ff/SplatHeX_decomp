using System;
using System.Drawing;
using System.Windows.Forms;

namespace SplatHex;
public class Class7 : Form {
    private IDisposable Iel;
    private Button ceG;
    private Button seb;
    private CheckBox jev;
    private CheckBox eeo;
    private CheckBox Uet;
    private CheckBox seV;
    private CheckBox YeO;
    private CheckBox Aee;
    private CheckBox xe8;
    private CheckBox Een;
    private CheckBox JeQ;
    private CheckBox aeF;
    private CheckBox peL;
    private CheckBox keJ;
    private CheckBox Ke7;
    private CheckBox UeP;
    public Class7() {
        ueh();
        CeD();
    }

    private void CeD() {
        uint itb = (uint)Class108.io2.itb;
        uint ttv = (uint)Class108.io2.ttv;
        uint vto = (uint)Class108.io2.Vto;
        keJ.Checked = (itb & 1) != 0;
        peL.Checked = (itb & 2) != 0;
        aeF.Checked = (itb & 4) != 0;
        JeQ.Checked = (itb & 8) != 0;
        Een.Checked = (itb & 0x10) != 0;
        xe8.Checked = (itb & 0x80) != 0;
        Aee.Checked = (itb & 0x100) != 0;
        YeO.Checked = (itb & 0x800) != 0;
        seV.Checked = (itb & 0x1000) != 0;
        Uet.Checked = (itb & 0x10000) != 0;
        eeo.Checked = (itb & 0x100000) != 0;
        jev.Checked = (itb & 0x200000) != 0;
        Ke7.Checked = ttv != 0;
        UeP.Checked = (vto & 0x10) != 0;
    }

    private void MeX() {
        uint uint_ = (uint)Class108.io2.itb;
        uint uint_2 = (uint)Class108.io2.ttv;
        uint uint_3 = (uint)Class108.io2.Vto;
        Class115.cH2(ref uint_, 1u, keJ.Checked);
        Class115.cH2(ref uint_, 2u, peL.Checked);
        Class115.cH2(ref uint_, 4u, aeF.Checked);
        Class115.cH2(ref uint_, 8u, JeQ.Checked);
        Class115.cH2(ref uint_, 16u, Een.Checked);
        Class115.cH2(ref uint_, 128u, xe8.Checked);
        Class115.cH2(ref uint_, 256u, Aee.Checked);
        Class115.cH2(ref uint_, 2048u, YeO.Checked);
        Class115.cH2(ref uint_, 4096u, seV.Checked);
        Class115.cH2(ref uint_, 65536u, Uet.Checked);
        Class115.cH2(ref uint_, 1048576u, eeo.Checked);
        Class115.cH2(ref uint_, 2097152u, jev.Checked);
        Class115.cH2(ref uint_2, 24u, Ke7.Checked);
        Class115.cH2(ref uint_3, 16u, UeP.Checked);
        Class108.io2.itb = (int)uint_;
        Class108.io2.ttv = (int)uint_2;
        Class108.io2.Vto = (int)uint_3;
    }

    private void Jep(object sender, EventArgs e) {
        MeX();
        Close();
    }

    private void XeS(object sender, EventArgs e) {
        Close();
    }

    protected override void Dispose(bool disposing) {
        if (disposing && Iel != null) {
            Iel.Dispose();
        }

        base.Dispose(disposing);
    }

    private void ueh() {
        ceG = new Button();
        seb = new Button();
        jev = new CheckBox();
        eeo = new CheckBox();
        Uet = new CheckBox();
        seV = new CheckBox();
        YeO = new CheckBox();
        Aee = new CheckBox();
        xe8 = new CheckBox();
        Een = new CheckBox();
        JeQ = new CheckBox();
        aeF = new CheckBox();
        peL = new CheckBox();
        keJ = new CheckBox();
        Ke7 = new CheckBox();
        UeP = new CheckBox();
        SuspendLayout();
        ceG.Location = new Point(186, 345);
        ceG.Name = "BTN_Cancel";
        ceG.Size = new Size(65, 23);
        ceG.TabIndex = 5;
        ceG.Text = "Cancel";
        ceG.UseVisualStyleBackColor = true;
        ceG.Click += XeS;
        seb.Location = new Point(115, 345);
        seb.Name = "BTN_Save";
        seb.Size = new Size(65, 23);
        seb.TabIndex = 4;
        seb.Text = "Save";
        seb.UseVisualStyleBackColor = true;
        seb.Click += Jep;
        jev.AutoSize = true;
        jev.ImeMode = ImeMode.NoControl;
        jev.Location = new Point(12, 274);
        jev.Name = "CB_Warning";
        jev.Size = new Size(283, 17);
        jev.TabIndex = 23;
        jev.Text = "Seen warning about game stats being published online";
        jev.UseVisualStyleBackColor = true;
        eeo.AutoSize = true;
        eeo.ImeMode = ImeMode.NoControl;
        eeo.Location = new Point(12, 250);
        eeo.Name = "CB_L50";
        eeo.Size = new Size(131, 17);
        eeo.TabIndex = 22;
        eeo.Text = "Level cap raised to 50";
        eeo.UseVisualStyleBackColor = true;
        Uet.AutoSize = true;
        Uet.ImeMode = ImeMode.NoControl;
        Uet.Location = new Point(12, 226);
        Uet.Name = "CB_snailsShown";
        Uet.Size = new Size(268, 17);
        Uet.TabIndex = 21;
        Uet.Text = "Super Sea Snail counter shown in Plaza and Lobby";
        Uet.UseVisualStyleBackColor = true;
        seV.AutoSize = true;
        seV.ImeMode = ImeMode.NoControl;
        seV.Location = new Point(12, 203);
        seV.Name = "CB_RankShown";
        seV.Size = new Size(179, 17);
        seV.TabIndex = 20;
        seV.Text = "Rank shown in Plaza and Lobby";
        seV.UseVisualStyleBackColor = true;
        YeO.AutoSize = true;
        YeO.ImeMode = ImeMode.NoControl;
        YeO.Location = new Point(12, 179);
        YeO.Name = "CB_RankedUnlocked";
        YeO.Size = new Size(146, 17);
        YeO.TabIndex = 19;
        YeO.Text = "Ranked Battles unlocked";
        YeO.UseVisualStyleBackColor = true;
        Aee.AutoSize = true;
        Aee.ImeMode = ImeMode.NoControl;
        Aee.Location = new Point(12, 155);
        Aee.Name = "CB_cuttlefish";
        Aee.Size = new Size(346, 17);
        Aee.TabIndex = 18;
        Aee.Text = "Cap'n Cuttlefish's post-game dialogue shown, credits block available";
        Aee.UseVisualStyleBackColor = true;
        xe8.AutoSize = true;
        xe8.ImeMode = ImeMode.NoControl;
        xe8.Location = new Point(12, 131);
        xe8.Name = "CB_GreatZapFish";
        xe8.Size = new Size(314, 17);
        xe8.TabIndex = 17;
        xe8.Text = "Great Zapfish returned and DJ Octavio's snowglobe is shown";
        xe8.UseVisualStyleBackColor = true;
        Een.AutoSize = true;
        Een.ImeMode = ImeMode.NoControl;
        Een.Location = new Point(12, 107);
        Een.Name = "Cb_HeroSuit";
        Een.Size = new Size(275, 17);
        Een.TabIndex = 16;
        Een.Text = "Seen Octo Valley intro cutscene and given Hero Suit";
        Een.UseVisualStyleBackColor = true;
        JeQ.AutoSize = true;
        JeQ.ImeMode = ImeMode.NoControl;
        JeQ.Location = new Point(12, 84);
        JeQ.Name = "CB_Lobby";
        JeQ.Size = new Size(140, 17);
        JeQ.TabIndex = 15;
        JeQ.Text = "Seen Lobby explanation";
        JeQ.UseVisualStyleBackColor = true;
        aeF.AutoSize = true;
        aeF.ImeMode = ImeMode.NoControl;
        aeF.Location = new Point(12, 60);
        aeF.Name = "CB_RankedNews";
        aeF.Size = new Size(195, 17);
        aeF.TabIndex = 14;
        aeF.Text = "Seen Ranked Battle available news";
        aeF.UseVisualStyleBackColor = true;
        peL.AutoSize = true;
        peL.ImeMode = ImeMode.NoControl;
        peL.Location = new Point(12, 36);
        peL.Name = "CB_Splafest";
        peL.Size = new Size(152, 17);
        peL.TabIndex = 13;
        peL.Text = "Seen Splatfest explanation";
        peL.UseVisualStyleBackColor = true;
        keJ.AutoSize = true;
        keJ.ImeMode = ImeMode.NoControl;
        keJ.Location = new Point(12, 13);
        keJ.Name = "CB_Tuto";
        keJ.Size = new Size(288, 17);
        keJ.TabIndex = 12;
        keJ.Text = "Finished tutorial, seen UFO news and Plaza explanation";
        keJ.UseVisualStyleBackColor = true;
        Ke7.AutoSize = true;
        Ke7.ImeMode = ImeMode.NoControl;
        Ke7.Location = new Point(12, 297);
        Ke7.Name = "CB_spyke";
        Ke7.Size = new Size(141, 17);
        Ke7.TabIndex = 24;
        Ke7.Text = "Seen Spyke explanation";
        Ke7.UseVisualStyleBackColor = true;
        UeP.AutoSize = true;
        UeP.ImeMode = ImeMode.NoControl;
        UeP.Location = new Point(12, 320);
        UeP.Name = "CB_SSSyke";
        UeP.Size = new Size(255, 17);
        UeP.TabIndex = 25;
        UeP.Text = "Seen Spyke explanation about Super Sea Snails";
        UeP.UseVisualStyleBackColor = true;
        base.AutoScaleDimensions = new SizeF(6f, 13f);
        base.AutoScaleMode = AutoScaleMode.Font;
        base.ClientSize = new Size(363, 375);
        base.Controls.Add(UeP);
        base.Controls.Add(Ke7);
        base.Controls.Add(jev);
        base.Controls.Add(eeo);
        base.Controls.Add(Uet);
        base.Controls.Add(seV);
        base.Controls.Add(YeO);
        base.Controls.Add(Aee);
        base.Controls.Add(xe8);
        base.Controls.Add(Een);
        base.Controls.Add(JeQ);
        base.Controls.Add(aeF);
        base.Controls.Add(peL);
        base.Controls.Add(keJ);
        base.Controls.Add(ceG);
        base.Controls.Add(seb);
        base.Name = "BitFlagSplat1";
        base.ShowIcon = false;
        base.StartPosition = FormStartPosition.CenterScreen;
        Text = "SplatHeX - Splatoon 1 - BitFlag Editor";
        ResumeLayout(performLayout: false);
        PerformLayout();
    }
}