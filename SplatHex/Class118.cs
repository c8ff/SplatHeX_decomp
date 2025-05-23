using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace SplatHex;
public class Class118 : Form {
    public int bFV;
    public int fFO;
    private bool MFe;
    private static int[][] aF8;
    private Container UFn;
    private GroupBox UFQ;
    public PictureBox gFF;
    public PictureBox IFL;
    private PictureBox BFJ;
    private ComboBox DF7;
    private ComboBox YFP;
    private ComboBox WFi;
    private Label rFm;
    private Label RF0;
    private Label tFI;
    private GroupBox iFR;
    private Label gFC;
    private PictureBox UFK;
    private PictureBox IFU;
    private NumericUpDown bFT;
    private NumericUpDown jF1;
    private ComboBox iFW;
    private ComboBox GFw;
    private Label AFN;
    private Label QFY;
    private GroupBox uFB;
    private ComboBox JFA;
    private GroupBox QFf;
    private NumericUpDown LF6;
    private PictureBox dFx;
    private NumericUpDown IF9;
    private CheckBox dFc;
    private CheckBox dFy;
    private GroupBox WFr;
    private ComboBox TFq;
    private Label LFk;
    private Label IFM;
    private TrackBar yFu;
    private TrackBar NFg;
    public CheckBox bF2;
    public CheckBox RF3;
    public CheckBox NFd;
    private PictureBox lFH;
    private Button DF4;
    private Button aF5;
    private PictureBox nFs;
    private Label hFZ;
    private GroupBox cFa;
    private Label tFj;
    private NumericUpDown oFz;
    private Label tLE;
    private NumericUpDown kLD;
    private CheckBox WLX;
    private NumericUpDown BLp;
    private Label CLS;
    private Label CLh;
    private CheckBox VLl;
    private Label sLG;
    private Label oLb;
    private Label nLv;
    private Label QLo;
    private Label QLt;
    private ProgressBar VLV;
    private ProgressBar ALO;
    private NumericUpDown oLe;
    private NumericUpDown LL8;
    private Label vLn;
    private PictureBox QLQ;
    private GroupBox WLF;
    private ContextMenuStrip GLL;
    private ToolStripMenuItem bLJ;
    private ToolStripMenuItem fL7;
    private ToolStripMenuItem kLP;
    private ToolStripMenuItem SLi;
    private static int hQu(object object_0, int int_0) {
        int num = 0;
        while (true) {
            if (num < ((Array)object_0).Length) {
                if (((int[])object_0)[num] == int_0) {
                    break;
                }

                num++;
                continue;
            }

            return -1;
        }

        return num;
    }

    private static float AQg(float float_0) {
        _ = (float)(Math.Truncate((double)float_0 * 100.0) / 100.0);
        return (float)Math.Round(float_0, 2);
    }

    private bool RQ2(byte[] byte_0, int int_0, int int_1, bool bool_0 = false) {
        if (bool_0) {
            int num = int_1 * 320 + int_0;
            int num2 = num / 8;
            int num3 = num % 8;
            return ((byte_0[num2] >> num3) & 1) == 1;
        }

        return byte_0[int_0 + 320 * int_1] == 0;
    }

    private void UQ3(byte[] byte_0) {
        Bitmap bitmap = new Bitmap(QLQ.Width, QLQ.Height);
        SolidBrush brush = new SolidBrush(Color.Black);
        SolidBrush brush2 = new SolidBrush(Color.White);
        bool bool_ = byte_0.Length != 38400;
        using (Graphics graphics = Graphics.FromImage(bitmap)) {
            for (int i = 0; i < bitmap.Height; i++) {
                for (int j = 0; j < bitmap.Width; j++) {
                    if (RQ2(byte_0, j, i, bool_)) {
                        graphics.FillRectangle(brush, j, i, 1, 1);
                    } else {
                        graphics.FillRectangle(brush2, j, i, 1, 1);
                    }
                }
            }
        }

        QLQ.Image = bitmap;
    }

    public Class118() {
        EFt();
        dFx.Visible = false;
        IF9.Visible = false;
        VLl.Visible = false;
        gQd();
        TFq.SelectedIndex = 0;
    }

    private void gQd() {
        WFi.SelectedIndex = Class26.QXu.Tpv;
        if (Class26.QXu.Lpp > 2) {
            MFe = Class26.QXu.RpL;
            WFi.Items.Add("Octogirl");
            WFi.Items.Add("Octoboy");
            if (MFe) {
                WFi.SelectedIndex = Class26.QXu.vpe;
            }
        }

        if (Class26.QXu.Lpp > 0) {
            iFW.Items.Add(4);
            iFW.Items.Add(5);
        } else {
            WFi.Items.Add("Octoling");
        }

        MFe = Class26.QXu.RpL;
        if (!MFe && Class26.QXu.Tpv == 0) {
            int ypo = Class26.QXu.ypo;
            GFw.SelectedIndex = ((ypo <= 1) ? ypo : (ypo / 2));
        } else if (!MFe && Class26.QXu.Tpv == 1) {
            int num = Class26.QXu.ypo - 2;
            GFw.SelectedIndex = ((num <= 1) ? num : ((num + 1) / 2));
        } else if (Class26.QXu.Lpp > 2 && MFe && Class26.QXu.vpe == 2) {
            GFw.SelectedIndex = ((Class26.QXu.Fp8 != 50) ? 1 : 0);
        } else if (Class26.QXu.Lpp > 2 && MFe && Class26.QXu.vpe == 3) {
            GFw.SelectedIndex = ((Class26.QXu.Fp8 != 51) ? 1 : 0);
        } else if (Class26.QXu.Lpp == 0 && Class26.QXu.Tpv == 6) {
            WFi.SelectedIndex = 2;
        }

        try {
            if (Class26.QXu.Lpp > 2 && MFe) {
                iFW.SelectedIndex = hQu(aF8[Class26.QXu.vpe & 1], Class26.QXu.qpF);
            } else {
                iFW.SelectedIndex = hQu(aF8[Class26.QXu.Tpv], Class26.QXu.HpO);
            }
        } catch {
            iFW.SelectedIndex = 0;
        }

        if (Class26.QXu.Lpp > 2 && MFe) {
            YFP.SelectedIndex = Class26.QXu.opQ - 1;
            DF7.SelectedIndex = Class26.QXu.Jpn;
        } else {
            YFP.SelectedIndex = Class26.QXu.NpV - 1;
            DF7.SelectedIndex = Class26.QXu.Npt;
        }

        jF1.Value = Class26.QXu.CpI;
        bFT.Value = Class26.QXu.EpR;
        kLD.Value = Class26.QXu.GpJ;
        oFz.Value = Class26.QXu.yp7;
        LF6.Value = Class26.QXu.hpm;
        if (Class26.QXu.jp0 != -1) {
            dFx.Visible = true;
            IF9.Value = Class26.QXu.jp0;
            switch (Class26.QXu.jp0) {
                case 0:
                    dFx.Image = Resources.CoinEXPIcon_00_Splat2;
                    break;
                case 1:
                    dFx.Image = Resources.CoinEXPIcon_01_Splat2;
                    break;
                case 2:
                    dFx.Image = Resources.CoinEXPIcon_02_Splat2;
                    break;
                case 3:
                    dFx.Image = Resources.CoinEXPIcon_03_Splat2;
                    break;
                case 4:
                    switch (Class26.QXu.mpi) {
                        case 0:
                            dFx.Image = Resources.GearPowerDrink_00_Splat2;
                            break;
                        case 1:
                            dFx.Image = Resources.GearPowerDrink_01_Splat2;
                            break;
                        case 2:
                            dFx.Image = Resources.GearPowerDrink_02_Splat2;
                            break;
                        case 3:
                            dFx.Image = Resources.GearPowerDrink_03_Splat2;
                            break;
                        case 4:
                            dFx.Image = Resources.GearPowerDrink_04_Splat2;
                            break;
                        case 5:
                            dFx.Image = Resources.GearPowerDrink_05_Splat2;
                            break;
                        case 6:
                            dFx.Image = Resources.GearPowerDrink_06_Splat2;
                            break;
                        case 7:
                            dFx.Image = Resources.GearPowerDrink_07_Splat2;
                            break;
                        case 8:
                            dFx.Image = Resources.GearPowerDrink_08_Splat2;
                            break;
                        case 9:
                            dFx.Image = Resources.GearPowerDrink_09_Splat2;
                            break;
                        case 10:
                            dFx.Image = Resources.GearPowerDrink_10_Splat2;
                            break;
                        case 11:
                            dFx.Image = Resources.GearPowerDrink_11_Splat2;
                            break;
                        case 12:
                            dFx.Image = Resources.GearPowerDrink_12_Splat2;
                            break;
                        case 13:
                            dFx.Image = Resources.GearPowerDrink_13_Splat2;
                            break;
                    }

                    break;
                case 5:
                    dFx.Image = Resources.CoinEXPIcon_05_Splat2;
                    break;
                case 6:
                    dFx.Image = Resources.CoinEXPIcon_06_Splat2;
                    break;
            }

            VLl.Checked = true;
        } else {
            IF9.Enabled = false;
            dFx.Visible = false;
        }

        if (Class26.QXu.Lpp > 0) {
            BLp.Enabled = Class26.QXu.GpP > 0;
            WLX.Checked = Class26.QXu.GpP > 0;
            if ((decimal)Class26.QXu.GpP > BLp.Maximum) {
                BLp.Maximum = Class26.QXu.GpP;
                kLD.ReadOnly = true;
            }

            BLp.Value = Class26.QXu.GpP;
        } else {
            kLD.Maximum = 50m;
            WLX.Visible = false;
            BLp.Visible = false;
        }

        dFy.Checked = Class26.QXu.NST;
        dFc.Checked = !Class26.QXu.XS1;
        UQ3((byte[])Class26.QXu.MSY);
    }

    private void qQH(object sender, EventArgs e) {
        if (WFi.SelectedIndex > 1 && MFe && Class26.QXu.Lpp > 2) {
            Class26.QXu.vpe = fFO;
            Class26.QXu.Fp8 = bFV;
            Class26.QXu.qpF = aF8[fFO & 1][iFW.SelectedIndex];
            Class26.QXu.Jpn = DF7.SelectedIndex;
            Class26.QXu.opQ = YFP.SelectedIndex + 1;
            Class26.QXu.RpL = true;
        } else {
            Class26.QXu.Tpv = fFO;
            Class26.QXu.ypo = bFV;
            Class26.QXu.HpO = aF8[fFO][iFW.SelectedIndex];
            Class26.QXu.Npt = DF7.SelectedIndex;
            Class26.QXu.NpV = YFP.SelectedIndex + 1;
            Class26.QXu.RpL = false;
        }

        Class26.QXu.CpI = (int)jF1.Value;
        Class26.QXu.EpR = (int)bFT.Value;
        Class26.QXu.GpJ = (int)kLD.Value;
        Class26.QXu.yp7 = (int)oFz.Value;
        Class26.QXu.hpm = (int)LF6.Value;
        if (Class26.QXu.hpm > 0) {
            Class26.QXu.jp0 = (int)IF9.Value;
        } else {
            Class26.QXu.jp0 = -1;
        }

        if (WLX.Checked) {
            Class26.QXu.GpP = (int)BLp.Value;
        } else {
            Class26.QXu.GpP = 0;
        }

        Class26.QXu.NST = dFy.Checked;
        Class26.QXu.XS1 = !dFc.Checked;
        Close();
    }

    private void XQ4(object sender, EventArgs e) {
        Close();
    }

    private void UQ5(object sender, EventArgs e) {
        if (WLX.Checked) {
            BLp.Enabled = true;
            BLp.Minimum = 1m;
            BLp.Value = 1m;
            WLX.Text = "★";
        } else {
            BLp.Enabled = false;
            BLp.Minimum = 0m;
            BLp.Value = 0m;
            WLX.Text = "☆";
        }
    }

    private void rQs(object sender, EventArgs e) {
        if (!VLl.Checked) {
            IF9.Enabled = false;
        } else {
            IF9.Enabled = true;
        }
    }

    private void wQZ(object sender, EventArgs e) {
        if (WFi.SelectedIndex == 0) {
            if (GFw.SelectedIndex == 0) {
                lFH.BackgroundImage = Resources.hairgirl_0;
                bFV = 0;
            } else if (GFw.SelectedIndex == 1) {
                lFH.BackgroundImage = Resources.hairgirl_1;
                bFV = 1;
            } else if (GFw.SelectedIndex == 2) {
                lFH.BackgroundImage = Resources.hairgirl_2;
                bFV = 4;
            } else if (GFw.SelectedIndex == 3) {
                lFH.BackgroundImage = Resources.hairgirl_3;
                bFV = 6;
            } else if (GFw.SelectedIndex == 4) {
                lFH.BackgroundImage = Resources.hairgirl_4;
                bFV = 8;
            } else if (GFw.SelectedIndex == 5) {
                lFH.BackgroundImage = Resources.hairgirl_5;
                bFV = 10;
            }
        } else if (WFi.SelectedIndex == 1) {
            if (GFw.SelectedIndex == 0) {
                lFH.BackgroundImage = Resources.hairboy_0;
                bFV = 2;
            } else if (GFw.SelectedIndex == 1) {
                lFH.BackgroundImage = Resources.hairboy_1;
                bFV = 3;
            } else if (GFw.SelectedIndex == 2) {
                lFH.BackgroundImage = Resources.hairboy_2;
                bFV = 5;
            } else if (GFw.SelectedIndex == 3) {
                lFH.BackgroundImage = Resources.hairboy_3;
                bFV = 7;
            } else if (GFw.SelectedIndex == 4) {
                lFH.BackgroundImage = Resources.hairboy_4;
                bFV = 9;
            } else if (GFw.SelectedIndex == 5) {
                lFH.BackgroundImage = Resources.hairboy_5;
                bFV = 11;
            }
        } else if (WFi.SelectedIndex == 2 && Class26.QXu.Lpp > 2) {
            if (GFw.SelectedIndex == 0) {
                lFH.BackgroundImage = Resources.hairoctogirl_0;
                bFV = 50;
            } else if (GFw.SelectedIndex == 1) {
                lFH.BackgroundImage = Resources.hairoctogirl_1;
                bFV = 52;
            }
        } else if (WFi.SelectedIndex == 3 && Class26.QXu.Lpp > 2) {
            if (GFw.SelectedIndex == 0) {
                lFH.BackgroundImage = Resources.hairoctoboy_0;
                bFV = 51;
            } else if (GFw.SelectedIndex == 1) {
                lFH.BackgroundImage = Resources.hairoctoboy_1;
                bFV = 53;
            }
        } else if (WFi.SelectedIndex == 2 && Class26.QXu.Lpp < 3) {
            if (GFw.SelectedIndex == 0) {
                lFH.BackgroundImage = null;
                bFV = 100;
            } else if (GFw.SelectedIndex == 1) {
                lFH.BackgroundImage = null;
                bFV = 101;
            }
        }
    }

    private void AQa(object sender, EventArgs e) {
        if (WFi.SelectedIndex != 0 && WFi.SelectedIndex != 2 && WFi.SelectedIndex != 4) {
            if (WFi.SelectedIndex == 1 || WFi.SelectedIndex == 3) {
                if (iFW.SelectedIndex == 0) {
                    nFs.BackgroundImage = Resources.legwear_boy_0;
                } else if (iFW.SelectedIndex == 1) {
                    nFs.BackgroundImage = Resources.legwear_boy_1;
                } else if (iFW.SelectedIndex == 2) {
                    nFs.BackgroundImage = Resources.legwear_boy_2;
                } else if (iFW.SelectedIndex == 3) {
                    nFs.BackgroundImage = Resources.legwear_boy_3;
                } else if (iFW.SelectedIndex == 4) {
                    nFs.BackgroundImage = Resources.legwear_boy_4;
                }
            }
        } else if (iFW.SelectedIndex == 0) {
            nFs.BackgroundImage = Resources.legwear_girl_0;
        } else if (iFW.SelectedIndex == 1) {
            nFs.BackgroundImage = Resources.legwear_girl_1;
        } else if (iFW.SelectedIndex == 2) {
            nFs.BackgroundImage = Resources.legwear_girl_2;
        } else if (iFW.SelectedIndex == 3) {
            nFs.BackgroundImage = Resources.legwear_girl_3;
        } else if (iFW.SelectedIndex == 4) {
            nFs.BackgroundImage = Resources.legwear_girl_4;
        }
    }

    private void mQj(object sender, EventArgs e) {
        fFO = WFi.SelectedIndex;
        int int_ = 4;
        if (Class26.QXu.Lpp > 0) {
            int_ = 6;
        }

        if (WFi.SelectedIndex == 0) {
            BFJ.BackgroundImage = Resources.inkling_girl_Splat2;
            JFD(DFX(int_), GFw);
            wQZ(null, null);
            AQa(null, null);
            fFO = 0;
        } else if (WFi.SelectedIndex == 1) {
            BFJ.BackgroundImage = Resources.Inkling_boy_Splat2;
            JFD(DFX(int_), GFw);
            wQZ(null, null);
            AQa(null, null);
            fFO = 1;
        } else if (WFi.SelectedIndex == 2) {
            if (Class26.QXu.Lpp < 3) {
                BFJ.BackgroundImage = Resources.octoling_Splat2;
                JFD(DFX(2), GFw);
                wQZ(null, null);
                AQa(null, null);
                fFO = 6;
            } else {
                BFJ.BackgroundImage = Resources.OctoGirl;
                JFD(DFX(2), GFw);
                wQZ(null, null);
                AQa(null, null);
                fFO = 2;
            }
        } else if (WFi.SelectedIndex == 3) {
            BFJ.BackgroundImage = Resources.OctoBoy;
            JFD(DFX(2), GFw);
            wQZ(null, null);
            AQa(null, null);
            fFO = 3;
        }
    }

    private void PQz(object sender, EventArgs e) {
        switch (YFP.SelectedIndex) {
            case 0:
                gFF.BackColor = Color.Magenta;
                break;
            case 1:
                gFF.BackColor = Color.Blue;
                break;
            case 2:
                gFF.BackColor = Color.Orange;
                break;
            case 3:
                gFF.BackColor = Color.Green;
                break;
            case 4:
                gFF.BackColor = Color.Yellow;
                break;
            case 5:
                gFF.BackColor = Color.Black;
                break;
            case 6:
                gFF.BackColor = Color.Red;
                break;
            case 7:
                gFF.BackColor = Color.Gray;
                break;
            case 8:
                gFF.BackColor = Color.Silver;
                break;
            case 9:
                gFF.BackColor = Color.Teal;
                break;
            case 10:
                gFF.BackColor = Color.DarkOliveGreen;
                break;
            case 11:
                gFF.BackColor = Color.Olive;
                break;
            case 12:
                gFF.BackColor = Color.Brown;
                break;
            case 13:
                gFF.BackColor = Color.DarkGray;
                break;
        }
    }

    private void TFE(object sender, EventArgs e) {
        switch (DF7.SelectedIndex) {
            case 0:
                IFL.BackColor = Color.FromArgb(219, 189, 168);
                break;
            case 1:
                IFL.BackColor = Color.FromArgb(218, 182, 152);
                break;
            case 2:
                IFL.BackColor = Color.FromArgb(219, 173, 126);
                break;
            case 3:
                IFL.BackColor = Color.FromArgb(195, 125, 81);
                break;
            case 4:
                IFL.BackColor = Color.FromArgb(165, 85, 46);
                break;
            case 5:
                IFL.BackColor = Color.FromArgb(117, 46, 20);
                break;
            case 6:
                IFL.BackColor = Color.FromArgb(76, 27, 15);
                break;
        }
    }

    private void JFD(string[] string_0, ComboBox comboBox_0) {
        comboBox_0.Items.Clear();
        for (int i = 0; i < string_0.Length; i++) {
            comboBox_0.Items.Add(string_0[i]);
        }

        comboBox_0.SelectedIndex = 0;
    }

    private string[] DFX(int int_0) {
        string[] array = new string[int_0];
        for (int i = 1; i < int_0 + 1; i++) {
            array[i - 1] = i.ToString();
        }

        return array;
    }

    private void WFp(object sender, EventArgs e) {
        gFC.Visible = true;
        oLb.Visible = false;
        ALO.Visible = false;
        QLt.Visible = false;
        VLV.Visible = false;
        QLo.Visible = false;
        gFC.Visible = false;
        vLn.Visible = false;
        nLv.Visible = true;
        sLG.Visible = true;
        switch (JFA.SelectedIndex) {
            default:
                oLb.Visible = false;
                sLG.Visible = false;
                gFC.Visible = false;
                break;
            case 0:
                vLn.Visible = false;
                sLG.Text = AQg(Class26.QXu.ISb).ToString();
                break;
            case 1: {
                    Class26.ux.Tv mSG = Class26.QXu.FSS;
                    CFS(mSG);
                    gFC.Visible = true;
                    oLb.Visible = true;
                    if (mSG.uS9 == uint.MaxValue) {
                        sLG.Visible = false;
                        nLv.Visible = false;
                    } else if (mSG.uS9 < 20) {
                        ALO.Visible = true;
                        QLt.Visible = true;
                        VLV.Visible = true;
                        QLo.Visible = true;
                        sLG.Text = AQg(Class26.QXu.SSv).ToString();
                    } else {
                        sLG.Text = AQg(Class26.QXu.OSO).ToString();
                        QLt.Visible = true;
                        QLt.Text = "Placement";
                        vLn.Visible = true;
                        vLn.Text = Class26.QXu.WSQ.ToString();
                    }

                    break;
                }

            case 2: {
                    Class26.ux.Tv mSG = Class26.QXu.vSh;
                    CFS(mSG);
                    gFC.Visible = true;
                    oLb.Visible = true;
                    if (mSG.uS9 == uint.MaxValue) {
                        sLG.Visible = false;
                        nLv.Visible = false;
                    } else if (mSG.uS9 < 20) {
                        ALO.Visible = true;
                        QLt.Visible = true;
                        VLV.Visible = true;
                        QLo.Visible = true;
                        sLG.Text = AQg(Class26.QXu.lSo).ToString();
                    } else {
                        sLG.Text = AQg(Class26.QXu.mSe).ToString();
                        QLt.Visible = true;
                        QLt.Text = "Placement";
                        vLn.Visible = true;
                        vLn.Text = Class26.QXu.GSF.ToString();
                    }

                    break;
                }

            case 3: {
                    Class26.ux.Tv mSG = Class26.QXu.TSl;
                    CFS(mSG);
                    gFC.Visible = true;
                    oLb.Visible = true;
                    if (mSG.uS9 == uint.MaxValue) {
                        sLG.Visible = false;
                        nLv.Visible = false;
                    } else if (mSG.uS9 < 20) {
                        ALO.Visible = true;
                        QLt.Visible = true;
                        VLV.Visible = true;
                        QLo.Visible = true;
                        sLG.Text = AQg(Class26.QXu.USt).ToString();
                    } else {
                        sLG.Text = AQg(Class26.QXu.KS8).ToString();
                        QLt.Visible = true;
                        QLt.Text = "Placement";
                        vLn.Visible = true;
                        vLn.Text = Class26.QXu.CSL.ToString();
                    }

                    break;
                }

            case 4: {
                    Class26.ux.Tv mSG = Class26.QXu.mSG;
                    CFS(mSG);
                    gFC.Visible = true;
                    oLb.Visible = true;
                    if (mSG.uS9 == uint.MaxValue) {
                        sLG.Visible = false;
                        nLv.Visible = false;
                    } else if (mSG.uS9 < 20) {
                        ALO.Visible = true;
                        QLt.Visible = true;
                        VLV.Visible = true;
                        QLo.Visible = true;
                        sLG.Text = AQg(Class26.QXu.CSV).ToString();
                    } else {
                        sLG.Text = AQg(Class26.QXu.USn).ToString();
                        QLt.Visible = true;
                        QLt.Text = "Placement";
                        vLn.Visible = true;
                        vLn.Text = Class26.QXu.USJ.ToString();
                    }

                    break;
                }
        }
    }

    private void CFS(Class26.ux.Tv tv_0) {
        string[] array = new string[21]
        {
            "C-",
            "xOV.xOy",
            "C+",
            "B-",
            "HO1.rOe",
            "B+",
            "A-",
            "aOK.tOh",
            "A+",
            "rOL.VOd",
            "S+0",
            "S+1",
            "S+2",
            "S+3",
            "S+4",
            "S+5",
            "S+6",
            "S+7",
            "S+8",
            "S+9",
            "X"
        };
        oLb.Visible = true;
        if (tv_0.uS9 == uint.MaxValue) {
            oLb.Text = "---";
            return;
        }

        oLb.Text = array[tv_0.uS9];
        if (tv_0.uS9 < 20) {
            ALO.Visible = true;
            QLt.Visible = true;
            VLV.Visible = true;
            QLo.Visible = true;
            ALO.Value = (int)tv_0.USc;
            VLV.Value = (int)tv_0.SSy;
            QLt.Text = "Win";
        }
    }

    private void KFh(object sender, EventArgs e) {
        if (TFq.SelectedIndex == 0) {
            NFg.Value = (int)(Class26.QXu.oS7 * 20f + 20f);
            oLe.Value = (decimal)(Class26.QXu.oS7 * 5f);
            yFu.Value = (int)(Class26.QXu.pSi * 20f + 20f);
            LL8.Value = (decimal)(Class26.QXu.pSi * 5f);
            NFd.Checked = Class26.QXu.LSK;
            bF2.Checked = Class26.QXu.nS0;
            RF3.Checked = Class26.QXu.ESR;
        } else {
            NFg.Value = (int)(Class26.QXu.ESP * 20f + 20f);
            yFu.Value = (int)(Class26.QXu.pSm * 20f + 20f);
            oLe.Value = (decimal)(Class26.QXu.ESP * 5f);
            LL8.Value = (decimal)(Class26.QXu.pSm * 5f);
            NFd.Checked = Class26.QXu.BSU;
            bF2.Checked = Class26.QXu.mSI;
            RF3.Checked = Class26.QXu.iSC;
        }
    }

    private void PFl(object sender, EventArgs e) {
        NFg.Visible = NFd.Checked;
        oLe.Visible = NFd.Checked;
        bF2.Visible = !NFd.Checked;
    }

    private void cFG(object sender, EventArgs e) {
        Class115.bH4(Class26.QXu.MSY, 0, ((Array)Class26.QXu.MSY).Length, string.Empty, string.Empty);
    }

    private void hFb(object sender, EventArgs e) {
        Class115.LH5((Array)Class26.QXu.MSY, 0, ((Array)Class26.QXu.MSY).Length, string.Empty, string.Empty);
        UQ3((byte[])Class26.QXu.MSY);
    }

    private void MFv(object sender, EventArgs e) {
        SaveFileDialog saveFileDialog = new SaveFileDialog();
        saveFileDialog.FileName = "image.png";
        saveFileDialog.Filter = "image| *.png";
        if (saveFileDialog.ShowDialog() == DialogResult.OK) {
            QLQ.Image.Save(saveFileDialog.FileName, ImageFormat.Png);
        }
    }

    private void HFo(object sender, EventArgs e) {
        OpenFileDialog openFileDialog = new OpenFileDialog();
        openFileDialog.Filter = "raw image data| *.data";
        if (openFileDialog.ShowDialog() != DialogResult.OK) {
            return;
        }

        string fileName = openFileDialog.FileName;
        long length = new FileInfo(fileName).Length;
        if (length != 38400L && length != 76800L) {
            MessageBox.Show("Invalid file.");
            return;
        }

        byte[] array = File.ReadAllBytes(fileName);
        byte[] array2 = new byte[4800];
        if (length == 76800L) {
            for (int i = 0; i < array2.Length; i++) {
                byte b = 0;
                for (int j = 0; j < 8; j++) {
                    b = (byte)((b << 1) | (array[i * 16 + 2 * (7 - j)] & 1));
                }

                array2[i] = b;
            }
        } else {
            for (int k = 0; k < array2.Length; k++) {
                byte b2 = 0;
                for (int l = 0; l < 8; l++) {
                    b2 = (byte)((b2 << 1) | (1 - (array[k * 8 + (7 - l)] & 1)));
                }

                array2[k] = b2;
            }
        }

        Array.Copy(array2, 0, (Array)Class26.QXu.MSY, 0, ((Array)Class26.QXu.MSY).Length);
        UQ3((byte[])Class26.QXu.MSY);
    }

    protected override void Dispose(bool disposing) {
        if (disposing && UFn != null) {
            ((IDisposable)UFn).Dispose();
        }

        base.Dispose(disposing);
    }

    private void EFt() {
        UFn = new Container();
        UFQ = new GroupBox();
        nFs = new PictureBox();
        lFH = new PictureBox();
        iFW = new ComboBox();
        GFw = new ComboBox();
        AFN = new Label();
        QFY = new Label();
        gFF = new PictureBox();
        IFL = new PictureBox();
        BFJ = new PictureBox();
        DF7 = new ComboBox();
        YFP = new ComboBox();
        WFi = new ComboBox();
        rFm = new Label();
        RF0 = new Label();
        tFI = new Label();
        iFR = new GroupBox();
        VLl = new CheckBox();
        cFa = new GroupBox();
        CLS = new Label();
        CLh = new Label();
        BLp = new NumericUpDown();
        WLX = new CheckBox();
        tFj = new Label();
        oFz = new NumericUpDown();
        tLE = new Label();
        kLD = new NumericUpDown();
        hFZ = new Label();
        IF9 = new NumericUpDown();
        LF6 = new NumericUpDown();
        dFx = new PictureBox();
        uFB = new GroupBox();
        vLn = new Label();
        QLo = new Label();
        QLt = new Label();
        VLV = new ProgressBar();
        ALO = new ProgressBar();
        sLG = new Label();
        oLb = new Label();
        nLv = new Label();
        JFA = new ComboBox();
        gFC = new Label();
        UFK = new PictureBox();
        IFU = new PictureBox();
        bFT = new NumericUpDown();
        jF1 = new NumericUpDown();
        QFf = new GroupBox();
        dFc = new CheckBox();
        dFy = new CheckBox();
        WFr = new GroupBox();
        oLe = new NumericUpDown();
        LL8 = new NumericUpDown();
        NFd = new CheckBox();
        bF2 = new CheckBox();
        RF3 = new CheckBox();
        LFk = new Label();
        IFM = new Label();
        yFu = new TrackBar();
        NFg = new TrackBar();
        TFq = new ComboBox();
        DF4 = new Button();
        aF5 = new Button();
        QLQ = new PictureBox();
        GLL = new ContextMenuStrip(UFn);
        bLJ = new ToolStripMenuItem();
        fL7 = new ToolStripMenuItem();
        SLi = new ToolStripMenuItem();
        kLP = new ToolStripMenuItem();
        WLF = new GroupBox();
        UFQ.SuspendLayout();
        ((ISupportInitialize)nFs).BeginInit();
        ((ISupportInitialize)lFH).BeginInit();
        ((ISupportInitialize)gFF).BeginInit();
        ((ISupportInitialize)IFL).BeginInit();
        ((ISupportInitialize)BFJ).BeginInit();
        iFR.SuspendLayout();
        cFa.SuspendLayout();
        ((ISupportInitialize)BLp).BeginInit();
        ((ISupportInitialize)oFz).BeginInit();
        ((ISupportInitialize)kLD).BeginInit();
        ((ISupportInitialize)IF9).BeginInit();
        ((ISupportInitialize)LF6).BeginInit();
        ((ISupportInitialize)dFx).BeginInit();
        uFB.SuspendLayout();
        ((ISupportInitialize)UFK).BeginInit();
        ((ISupportInitialize)IFU).BeginInit();
        ((ISupportInitialize)bFT).BeginInit();
        ((ISupportInitialize)jF1).BeginInit();
        QFf.SuspendLayout();
        WFr.SuspendLayout();
        ((ISupportInitialize)oLe).BeginInit();
        ((ISupportInitialize)LL8).BeginInit();
        ((ISupportInitialize)yFu).BeginInit();
        ((ISupportInitialize)NFg).BeginInit();
        ((ISupportInitialize)QLQ).BeginInit();
        GLL.SuspendLayout();
        WLF.SuspendLayout();
        SuspendLayout();
        UFQ.Controls.Add(nFs);
        UFQ.Controls.Add(lFH);
        UFQ.Controls.Add(iFW);
        UFQ.Controls.Add(GFw);
        UFQ.Controls.Add(AFN);
        UFQ.Controls.Add(QFY);
        UFQ.Controls.Add(gFF);
        UFQ.Controls.Add(IFL);
        UFQ.Controls.Add(BFJ);
        UFQ.Controls.Add(DF7);
        UFQ.Controls.Add(YFP);
        UFQ.Controls.Add(WFi);
        UFQ.Controls.Add(rFm);
        UFQ.Controls.Add(RF0);
        UFQ.Controls.Add(tFI);
        UFQ.Location = new Point(25, 12);
        UFQ.Name = "groupBox5";
        UFQ.Size = new Size(519, 240);
        UFQ.TabIndex = 3;
        UFQ.TabStop = false;
        UFQ.Text = "Character";
        nFs.BackgroundImage = Resources.legwear_girl_0;
        nFs.BackgroundImageLayout = ImageLayout.Zoom;
        nFs.Location = new Point(233, 70);
        nFs.Name = "PB_Legwear";
        nFs.Size = new Size(60, 60);
        nFs.TabIndex = 19;
        nFs.TabStop = false;
        lFH.BackgroundImage = Resources.hairgirl_0;
        lFH.BackgroundImageLayout = ImageLayout.Zoom;
        lFH.Location = new Point(233, 167);
        lFH.Name = "PB_Hair";
        lFH.Size = new Size(60, 60);
        lFH.TabIndex = 18;
        lFH.TabStop = false;
        iFW.DropDownStyle = ComboBoxStyle.DropDownList;
        iFW.FormattingEnabled = true;
        iFW.Items.AddRange(new object[3] { "oBc.tB6", "PBi.aBM", "gBK.sBh" });
        iFW.Location = new Point(142, 70);
        iFW.Name = "CB_Legwear";
        iFW.Size = new Size(85, 21);
        iFW.TabIndex = 17;
        iFW.SelectedIndexChanged += AQa;
        GFw.DropDownStyle = ComboBoxStyle.DropDownList;
        GFw.FormattingEnabled = true;
        GFw.Items.AddRange(new object[2] { "oBc.tB6", "PBi.aBM" });
        GFw.Location = new Point(142, 167);
        GFw.Name = "CB_Hair";
        GFw.Size = new Size(85, 21);
        GFw.TabIndex = 16;
        GFw.SelectedIndexChanged += wQZ;
        AFN.AutoSize = true;
        AFN.Location = new Point(139, 54);
        AFN.Name = "label3";
        AFN.Size = new Size(54, 13);
        AFN.TabIndex = 15;
        AFN.Text = "Legwear :";
        QFY.AutoSize = true;
        QFY.Location = new Point(139, 151);
        QFY.Name = "label4";
        QFY.Size = new Size(32, 13);
        QFY.TabIndex = 14;
        QFY.Text = "Hair :";
        gFF.BackColor = Color.Magenta;
        gFF.BorderStyle = BorderStyle.FixedSingle;
        gFF.Location = new Point(430, 70);
        gFF.Name = "pic_eye";
        gFF.Size = new Size(69, 36);
        gFF.SizeMode = PictureBoxSizeMode.StretchImage;
        gFF.TabIndex = 13;
        gFF.TabStop = false;
        IFL.BackColor = Color.FromArgb(219, 189, 168);
        IFL.BorderStyle = BorderStyle.FixedSingle;
        IFL.Location = new Point(430, 167);
        IFL.Name = "pic_skin";
        IFL.Size = new Size(69, 36);
        IFL.SizeMode = PictureBoxSizeMode.StretchImage;
        IFL.TabIndex = 12;
        IFL.TabStop = false;
        BFJ.BackColor = Color.Transparent;
        BFJ.BackgroundImage = Resources.inkling_girl_Splat2;
        BFJ.BackgroundImageLayout = ImageLayout.Zoom;
        BFJ.BorderStyle = BorderStyle.FixedSingle;
        BFJ.Location = new Point(9, 64);
        BFJ.Name = "PB_Gender";
        BFJ.Size = new Size(100, 168);
        BFJ.SizeMode = PictureBoxSizeMode.Zoom;
        BFJ.TabIndex = 11;
        BFJ.TabStop = false;
        DF7.DropDownStyle = ComboBoxStyle.DropDownList;
        DF7.FormattingEnabled = true;
        DF7.Items.AddRange(new object[7] { "1 - Lightest", "PBi.aBM", "gBK.sBh", "4", "rB1.GBe", "OBV.oBy", "7 - Darkest" });
        DF7.Location = new Point(339, 167);
        DF7.Name = "CB_skins";
        DF7.Size = new Size(85, 21);
        DF7.TabIndex = 10;
        DF7.SelectedIndexChanged += TFE;
        YFP.DropDownStyle = ComboBoxStyle.DropDownList;
        YFP.FormattingEnabled = true;
        YFP.Items.AddRange(new object[14] { "Magenta", "Blue", "Orange", "Green", "Yellow", "Black", "Red", "Gray", "Silver", "Blue Grey", "Olive Green", "Hazel", "Brown", "Dark Grey" });
        YFP.Location = new Point(339, 70);
        YFP.Name = "CB_eyecolors";
        YFP.Size = new Size(85, 21);
        YFP.TabIndex = 9;
        YFP.SelectedIndexChanged += PQz;
        WFi.DropDownStyle = ComboBoxStyle.DropDownList;
        WFi.FormattingEnabled = true;
        WFi.Items.AddRange(new object[2] { "Female", "Male" });
        WFi.Location = new Point(9, 37);
        WFi.Name = "CB_Gender";
        WFi.Size = new Size(85, 21);
        WFi.TabIndex = 8;
        WFi.SelectedIndexChanged += mQj;
        rFm.AutoSize = true;
        rFm.Location = new Point(336, 151);
        rFm.Name = "label29";
        rFm.Size = new Size(34, 13);
        rFm.TabIndex = 5;
        rFm.Text = "Skin :";
        RF0.AutoSize = true;
        RF0.Location = new Point(336, 54);
        RF0.Name = "label30";
        RF0.Size = new Size(31, 13);
        RF0.TabIndex = 3;
        RF0.Text = "Eye :";
        tFI.AutoSize = true;
        tFI.Location = new Point(6, 18);
        tFI.Name = "label31";
        tFI.Size = new Size(48, 13);
        tFI.TabIndex = 1;
        tFI.Text = "Gender :";
        iFR.Controls.Add(VLl);
        iFR.Controls.Add(cFa);
        iFR.Controls.Add(hFZ);
        iFR.Controls.Add(IF9);
        iFR.Controls.Add(LF6);
        iFR.Controls.Add(dFx);
        iFR.Controls.Add(uFB);
        iFR.Controls.Add(UFK);
        iFR.Controls.Add(IFU);
        iFR.Controls.Add(bFT);
        iFR.Controls.Add(jF1);
        iFR.Location = new Point(25, 264);
        iFR.Name = "groupBox4";
        iFR.Size = new Size(451, 241);
        iFR.TabIndex = 12;
        iFR.TabStop = false;
        iFR.Text = "Stats";
        VLl.AutoSize = true;
        VLl.Location = new Point(82, 210);
        VLl.Name = "CB_Boost";
        VLl.Size = new Size(15, 14);
        VLl.TabIndex = 20;
        VLl.UseVisualStyleBackColor = true;
        VLl.CheckedChanged += rQs;
        cFa.Controls.Add(CLS);
        cFa.Controls.Add(CLh);
        cFa.Controls.Add(BLp);
        cFa.Controls.Add(WLX);
        cFa.Controls.Add(tFj);
        cFa.Controls.Add(oFz);
        cFa.Controls.Add(tLE);
        cFa.Controls.Add(kLD);
        cFa.Location = new Point(13, 19);
        cFa.Name = "groupBox6";
        cFa.Size = new Size(214, 91);
        cFa.TabIndex = 18;
        cFa.TabStop = false;
        CLS.AutoSize = true;
        CLS.Location = new Point(76, 43);
        CLS.Name = "label9";
        CLS.Size = new Size(31, 13);
        CLS.TabIndex = 20;
        CLS.Text = "EXP:";
        CLh.AutoSize = true;
        CLh.Location = new Point(109, 68);
        CLh.Name = "label6";
        CLh.Size = new Size(59, 13);
        CLh.TabIndex = 19;
        CLh.Text = "Star Meter:";
        BLp.Location = new Point(171, 65);
        BLp.Maximum = new decimal(new int[4] { 10, 0, 0, 0 });
        BLp.Name = "NUD_StarMeter";
        BLp.Size = new Size(36, 20);
        BLp.TabIndex = 18;
        WLX.AutoSize = true;
        WLX.Location = new Point(6, 41);
        WLX.Name = "CB_PStar";
        WLX.Size = new Size(35, 17);
        WLX.TabIndex = 17;
        WLX.Text = "☆";
        WLX.UseVisualStyleBackColor = true;
        WLX.CheckedChanged += UQ5;
        tFj.AutoSize = true;
        tFj.Location = new Point(159, 42);
        tFj.Name = "LB_EXPMax";
        tFj.Size = new Size(12, 13);
        tFj.TabIndex = 16;
        tFj.Text = "/";
        oFz.Location = new Point(108, 40);
        oFz.Maximum = new decimal(new int[4] { 9999999, 0, 0, 0 });
        oFz.Name = "NUD_Exp";
        oFz.Size = new Size(51, 20);
        oFz.TabIndex = 15;
        tLE.AutoSize = true;
        tLE.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
        tLE.ForeColor = Color.Lime;
        tLE.Location = new Point(3, 10);
        tLE.Name = "label1";
        tLE.Size = new Size(60, 24);
        tLE.TabIndex = 13;
        tLE.Text = "Level";
        kLD.Location = new Point(171, 18);
        kLD.Maximum = new decimal(new int[4] { 99, 0, 0, 0 });
        kLD.Name = "NUD_Level";
        kLD.Size = new Size(36, 20);
        kLD.TabIndex = 0;
        hFZ.AutoSize = true;
        hFZ.Location = new Point(106, 211);
        hFZ.Name = "label5";
        hFZ.Size = new Size(68, 13);
        hFZ.TabIndex = 19;
        hFZ.Text = "Boost Count:";
        IF9.Location = new Point(52, 207);
        IF9.Maximum = new decimal(new int[4] { 10, 0, 0, 0 });
        IF9.Name = "NUD_Boost";
        IF9.Size = new Size(26, 20);
        IF9.TabIndex = 18;
        LF6.Location = new Point(179, 208);
        LF6.Maximum = new decimal(new int[4] { 20, 0, 0, 0 });
        LF6.Name = "NUD_BoostCount";
        LF6.Size = new Size(38, 20);
        LF6.TabIndex = 17;
        dFx.BackgroundImage = Resources.CoinEXPIcon_02_Splat2;
        dFx.BackgroundImageLayout = ImageLayout.Zoom;
        dFx.Location = new Point(13, 199);
        dFx.Name = "pictureBox3";
        dFx.Size = new Size(34, 34);
        dFx.SizeMode = PictureBoxSizeMode.Zoom;
        dFx.TabIndex = 16;
        dFx.TabStop = false;
        uFB.Controls.Add(vLn);
        uFB.Controls.Add(QLo);
        uFB.Controls.Add(QLt);
        uFB.Controls.Add(VLV);
        uFB.Controls.Add(ALO);
        uFB.Controls.Add(sLG);
        uFB.Controls.Add(oLb);
        uFB.Controls.Add(nLv);
        uFB.Controls.Add(JFA);
        uFB.Controls.Add(gFC);
        uFB.Location = new Point(233, 16);
        uFB.Name = "groupBox1";
        uFB.Size = new Size(210, 219);
        uFB.TabIndex = 15;
        uFB.TabStop = false;
        uFB.Text = "Mode";
        vLn.AutoSize = true;
        vLn.Location = new Point(137, 149);
        vLn.Name = "Lbl_Placement";
        vLn.Size = new Size(0, 13);
        vLn.TabIndex = 24;
        vLn.Visible = false;
        QLo.AutoSize = true;
        QLo.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
        QLo.ForeColor = Color.FromArgb(255, 128, 0);
        QLo.Location = new Point(6, 182);
        QLo.Name = "loseLBL";
        QLo.Size = new Size(55, 24);
        QLo.TabIndex = 23;
        QLo.Text = "Lose";
        QLo.Visible = false;
        QLt.AutoSize = true;
        QLt.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
        QLt.ForeColor = Color.FromArgb(255, 128, 0);
        QLt.Location = new Point(6, 141);
        QLt.Name = "winbarLBL";
        QLt.Size = new Size(46, 24);
        QLt.TabIndex = 22;
        QLt.Text = "Win";
        QLt.Visible = false;
        VLV.Location = new Point(72, 183);
        VLV.Name = "losebar";
        VLV.Size = new Size(100, 23);
        VLV.TabIndex = 21;
        VLV.Visible = false;
        ALO.Location = new Point(73, 142);
        ALO.Name = "winbar";
        ALO.Size = new Size(100, 23);
        ALO.TabIndex = 20;
        ALO.Visible = false;
        sLG.AutoSize = true;
        sLG.Location = new Point(137, 111);
        sLG.Name = "MMRLbl";
        sLG.Size = new Size(35, 13);
        sLG.TabIndex = 19;
        sLG.Text = "Unset";
        oLb.AutoSize = true;
        oLb.Location = new Point(137, 74);
        oLb.Name = "rankLBL";
        oLb.Size = new Size(35, 13);
        oLb.TabIndex = 18;
        oLb.Text = "Unset";
        nLv.AutoSize = true;
        nLv.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
        nLv.ForeColor = Color.FromArgb(255, 128, 0);
        nLv.Location = new Point(6, 104);
        nLv.Name = "label10";
        nLv.Size = new Size(58, 24);
        nLv.TabIndex = 17;
        nLv.Text = "MMR";
        JFA.DropDownStyle = ComboBoxStyle.DropDownList;
        JFA.FormattingEnabled = true;
        JFA.Items.AddRange(new object[5] { "Turf War", "Splat Zones", "Tower Control", "Rainmaker", "Clam Blitz" });
        JFA.Location = new Point(43, 19);
        JFA.Name = "CB_RankedGame";
        JFA.Size = new Size(121, 21);
        JFA.TabIndex = 15;
        JFA.SelectedIndexChanged += WFp;
        gFC.AutoSize = true;
        gFC.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
        gFC.ForeColor = Color.FromArgb(255, 128, 0);
        gFC.Location = new Point(6, 66);
        gFC.Name = "label2";
        gFC.Size = new Size(57, 24);
        gFC.TabIndex = 14;
        gFC.Text = "Rank";
        UFK.BackgroundImage = Resources.CoinSazae_01_Splat2;
        UFK.BackgroundImageLayout = ImageLayout.Zoom;
        UFK.Location = new Point(13, 159);
        UFK.Name = "pictureBox2";
        UFK.Size = new Size(34, 34);
        UFK.SizeMode = PictureBoxSizeMode.Zoom;
        UFK.TabIndex = 12;
        UFK.TabStop = false;
        IFU.BackgroundImage = Resources.CoinSazae_00_Splat2;
        IFU.BackgroundImageLayout = ImageLayout.Zoom;
        IFU.Location = new Point(13, 117);
        IFU.Name = "pictureBox1";
        IFU.Size = new Size(34, 34);
        IFU.SizeMode = PictureBoxSizeMode.Zoom;
        IFU.TabIndex = 11;
        IFU.TabStop = false;
        bFT.Location = new Point(179, 166);
        bFT.Maximum = new decimal(new int[4] { 999, 0, 0, 0 });
        bFT.Name = "NUD_SeaSnails";
        bFT.Size = new Size(38, 20);
        bFT.TabIndex = 4;
        jF1.Location = new Point(138, 126);
        jF1.Maximum = new decimal(new int[4] { 9999999, 0, 0, 0 });
        jF1.Name = "NUD_Money";
        jF1.Size = new Size(79, 20);
        jF1.TabIndex = 2;
        QFf.Controls.Add(dFc);
        QFf.Controls.Add(dFy);
        QFf.Controls.Add(WFr);
        QFf.Location = new Point(588, 12);
        QFf.Name = "groupBox2";
        QFf.Size = new Size(220, 326);
        QFf.TabIndex = 15;
        QFf.TabStop = false;
        QFf.Text = "Options";
        dFc.AutoSize = true;
        dFc.Location = new Point(68, 39);
        dFc.Name = "CB_PostDisplay";
        dFc.Size = new Size(84, 17);
        dFc.TabIndex = 2;
        dFc.Text = "Post Display";
        dFc.UseVisualStyleBackColor = true;
        dFy.AutoSize = true;
        dFy.Location = new Point(68, 16);
        dFy.Name = "CB_ColorLock";
        dFy.Size = new Size(77, 17);
        dFy.TabIndex = 1;
        dFy.Text = "Color Lock";
        dFy.UseVisualStyleBackColor = true;
        WFr.Controls.Add(oLe);
        WFr.Controls.Add(LL8);
        WFr.Controls.Add(NFd);
        WFr.Controls.Add(bF2);
        WFr.Controls.Add(RF3);
        WFr.Controls.Add(LFk);
        WFr.Controls.Add(IFM);
        WFr.Controls.Add(yFu);
        WFr.Controls.Add(NFg);
        WFr.Controls.Add(TFq);
        WFr.Location = new Point(6, 55);
        WFr.Name = "groupBox3";
        WFr.Size = new Size(205, 265);
        WFr.TabIndex = 0;
        WFr.TabStop = false;
        WFr.Text = "Camera";
        oLe.DecimalPlaces = 1;
        oLe.Enabled = false;
        oLe.Increment = new decimal(new int[4] { 5, 0, 0, 65536 });
        oLe.Location = new Point(143, 46);
        oLe.Maximum = new decimal(new int[4] { 5, 0, 0, 0 });
        oLe.Minimum = new decimal(new int[4] { 5, 0, 0, -2147483648 });
        oLe.Name = "NUD_MCS";
        oLe.ReadOnly = true;
        oLe.Size = new Size(43, 20);
        oLe.TabIndex = 11;
        LL8.DecimalPlaces = 1;
        LL8.Enabled = false;
        LL8.Increment = new decimal(new int[4] { 5, 0, 0, 65536 });
        LL8.Location = new Point(143, 121);
        LL8.Maximum = new decimal(new int[4] { 5, 0, 0, 0 });
        LL8.Minimum = new decimal(new int[4] { 5, 0, 0, -2147483648 });
        LL8.Name = "NUD_RSS";
        LL8.ReadOnly = true;
        LL8.Size = new Size(43, 20);
        LL8.TabIndex = 10;
        NFd.AutoSize = true;
        NFd.Enabled = false;
        NFd.Location = new Point(50, 225);
        NFd.Name = "CB_MotionControl";
        NFd.Size = new Size(94, 17);
        NFd.TabIndex = 9;
        NFd.Text = "Motion Control";
        NFd.UseVisualStyleBackColor = true;
        NFd.CheckedChanged += PFl;
        bF2.AutoSize = true;
        bF2.Enabled = false;
        bF2.Location = new Point(50, 193);
        bF2.Name = "CB_RevY";
        bF2.Size = new Size(96, 17);
        bF2.TabIndex = 8;
        bF2.Text = "Inverted Y axis";
        bF2.UseVisualStyleBackColor = true;
        RF3.AutoSize = true;
        RF3.Enabled = false;
        RF3.Location = new Point(50, 209);
        RF3.Name = "CB_RevX";
        RF3.Size = new Size(96, 17);
        RF3.TabIndex = 7;
        RF3.Text = "Inverted X axis";
        RF3.UseVisualStyleBackColor = true;
        LFk.AutoSize = true;
        LFk.Location = new Point(8, 123);
        LFk.Name = "label8";
        LFk.Size = new Size(77, 13);
        LFk.TabIndex = 4;
        LFk.Text = "(R) Sensitivity :";
        IFM.AutoSize = true;
        IFM.Location = new Point(6, 48);
        IFM.Name = "label7";
        IFM.Size = new Size(131, 13);
        IFM.TabIndex = 3;
        IFM.Text = "Motion Control Sensitivity :";
        yFu.Enabled = false;
        yFu.Location = new Point(6, 139);
        yFu.Maximum = 40;
        yFu.Name = "trackBar2";
        yFu.Size = new Size(193, 45);
        yFu.TabIndex = 2;
        NFg.Enabled = false;
        NFg.Location = new Point(6, 64);
        NFg.Maximum = 40;
        NFg.Name = "trackBar1";
        NFg.Size = new Size(193, 45);
        NFg.TabIndex = 1;
        TFq.DropDownStyle = ComboBoxStyle.DropDownList;
        TFq.FormattingEnabled = true;
        TFq.Items.AddRange(new object[2] { "TV/Tabletop Mode", "Handheld Mode" });
        TFq.Location = new Point(46, 19);
        TFq.Name = "CB_Gameplay";
        TFq.Size = new Size(121, 21);
        TFq.TabIndex = 0;
        TFq.SelectedIndexChanged += KFh;
        DF4.Location = new Point(765, 482);
        DF4.Name = "BTN_Close";
        DF4.Size = new Size(45, 23);
        DF4.TabIndex = 17;
        DF4.Text = "Close";
        DF4.UseVisualStyleBackColor = true;
        DF4.Click += XQ4;
        aF5.Location = new Point(716, 482);
        aF5.Name = "BTN_Save";
        aF5.Size = new Size(45, 23);
        aF5.TabIndex = 16;
        aF5.Text = "Save";
        aF5.UseVisualStyleBackColor = true;
        aF5.Click += qQH;
        QLQ.ContextMenuStrip = GLL;
        QLQ.Location = new Point(4, 14);
        QLQ.Name = "PB_PlazaDrawing";
        QLQ.Size = new Size(320, 120);
        QLQ.TabIndex = 18;
        QLQ.TabStop = false;
        GLL.Items.AddRange(new ToolStripItem[4] { bLJ, fL7, SLi, kLP });
        GLL.Name = "contextMenuStripDrawing";
        GLL.ShowImageMargin = false;
        GLL.Size = new Size(144, 92);
        bLJ.Name = "exportDrawing";
        bLJ.Size = new Size(143, 22);
        bLJ.Text = "Export binary";
        bLJ.Click += cFG;
        fL7.Name = "importDrawing";
        fL7.Size = new Size(143, 22);
        fL7.Text = "Import binary";
        fL7.Click += hFb;
        SLi.Name = "importDrawingRAW";
        SLi.Size = new Size(143, 22);
        SLi.Text = "Import raw image";
        SLi.Click += HFo;
        kLP.Name = "exportDrawingPNG";
        kLP.Size = new Size(143, 22);
        kLP.Text = "Export as png";
        kLP.Click += MFv;
        WLF.Controls.Add(QLQ);
        WLF.Location = new Point(482, 338);
        WLF.Name = "groupBox7";
        WLF.Size = new Size(329, 141);
        WLF.TabIndex = 19;
        WLF.TabStop = false;
        WLF.Text = "Plaza Drawing";
        base.AutoScaleDimensions = new SizeF(6f, 13f);
        base.AutoScaleMode = AutoScaleMode.Font;
        base.ClientSize = new Size(817, 510);
        base.Controls.Add(WLF);
        base.Controls.Add(DF4);
        base.Controls.Add(aF5);
        base.Controls.Add(QFf);
        base.Controls.Add(iFR);
        base.Controls.Add(UFQ);
        base.Name = "PlayerEditorSplat2";
        base.ShowIcon = false;
        base.StartPosition = FormStartPosition.CenterScreen;
        Text = "SplatHeX - Splatoon 2 - Player Editor";
        UFQ.ResumeLayout(performLayout: false);
        UFQ.PerformLayout();
        ((ISupportInitialize)nFs).EndInit();
        ((ISupportInitialize)lFH).EndInit();
        ((ISupportInitialize)gFF).EndInit();
        ((ISupportInitialize)IFL).EndInit();
        ((ISupportInitialize)BFJ).EndInit();
        iFR.ResumeLayout(performLayout: false);
        iFR.PerformLayout();
        cFa.ResumeLayout(performLayout: false);
        cFa.PerformLayout();
        ((ISupportInitialize)BLp).EndInit();
        ((ISupportInitialize)oFz).EndInit();
        ((ISupportInitialize)kLD).EndInit();
        ((ISupportInitialize)IF9).EndInit();
        ((ISupportInitialize)LF6).EndInit();
        ((ISupportInitialize)dFx).EndInit();
        uFB.ResumeLayout(performLayout: false);
        uFB.PerformLayout();
        ((ISupportInitialize)UFK).EndInit();
        ((ISupportInitialize)IFU).EndInit();
        ((ISupportInitialize)bFT).EndInit();
        ((ISupportInitialize)jF1).EndInit();
        QFf.ResumeLayout(performLayout: false);
        QFf.PerformLayout();
        WFr.ResumeLayout(performLayout: false);
        WFr.PerformLayout();
        ((ISupportInitialize)oLe).EndInit();
        ((ISupportInitialize)LL8).EndInit();
        ((ISupportInitialize)yFu).EndInit();
        ((ISupportInitialize)NFg).EndInit();
        ((ISupportInitialize)QLQ).EndInit();
        GLL.ResumeLayout(performLayout: false);
        WLF.ResumeLayout(performLayout: false);
        ResumeLayout(performLayout: false);
    }

    static ar9() {
        aF8 = new int[4][]
        {
            new int[5]
            {
                1,
                2,
                3,
                8,
                9
            },
            new int[5]
            {
                5,
                6,
                7,
                10,
                11
            },
            new int[4]
            {
                50,
                51,
                52,
                53
            },
            new int[4]
            {
                54,
                55,
                56,
                57
            }
        };
    }
}