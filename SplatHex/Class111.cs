using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;


namespace SplatHex;
public class Class111 : Form {
    private IDisposable Sm0;
    private GroupBox cmI;
    private Button QmR;
    private Button ImC;
    private GroupBox mmK;
    private ComboBox BmU;
    private Button MmT;
    private Button Rm1;
    private Button XmW;
    private CheckBox Tmw;
    public Class111() {
        pmm();
        BmU.SelectedIndex = 0;
    }

    private void NmQ(object sender, EventArgs e) {
        DialogResult dialogResult = MessageBox.Show("Are you sure you want to unlock all gears ?\n(This will unlock all gears you don't have yet, none of your actual gears will be overwritten.)", "", MessageBoxButtons.YesNo);
        if (dialogResult == DialogResult.Yes) {
            bmF(Class117.eoy, Class108.Jo3, Class117.Sox);
            bmF(Class117.qor, Class108.Yod, Class117.Qo9);
            bmF(Class117.toq, Class108.YoH, Class117.Yoc);
            MessageBox.Show("All Gears unlocked.");
        }
    }

    private void bmF(Dictionary<int, Class25> dictionary_0, Class108.fr2[] fr2_0, Dictionary<int, int> dictionary_1) {
        List<int> list = dictionary_0.Keys.ToList();
        list.Sort();
        foreach (int item in list) {
            if (Class4.kDM(item, fr2_0)) {
                continue;
            }

            if (Tmw.Checked) {
                if (Class4.rDg(item, dictionary_1)) {
                    int num = Class115.nHs(0, 12);
                    Class4.kD3(fr2_0, item, 4, 4, num, num, num, Class115.vHZ(), 1);
                }
            } else {
                int num2 = Class115.nHs(0, 12);
                Class4.kD3(fr2_0, item, 4, 4, num2, num2, num2, Class115.vHZ(), 1);
            }
        }
    }

    private void dmL(object sender, EventArgs e) {
        DialogResult dialogResult = MessageBox.Show("Are you sure you want to unlock all weapons ?\n(This will unlock all weapons you don't have yet, none of your actual gears will be overwritten.)", "", MessageBoxButtons.YesNo);
        if (dialogResult != DialogResult.Yes) {
            return;
        }

        List<int> list = Class46.Lou.Keys.ToList();
        list.Sort();
        foreach (int item in list) {
            if (Class22.WXv(item)) {
                continue;
            }

            if (Tmw.Checked) {
                if (Class22.vXO(item)) {
                    int num = Class22.qXt(Class108.Vo4);
                    if (num != 500) {
                        Class22.iXG(num, item, Class115.vHZ(), 1, Class46.Lou[item].WXE, Class46.Lou[item].DXD);
                    }
                }
            } else {
                int num2 = Class22.qXt(Class108.Vo4);
                if (num2 != 500) {
                    Class22.iXG(num2, item, Class115.vHZ(), 1, Class46.Lou[item].WXE, Class46.Lou[item].DXD);
                }
            }
        }

        MessageBox.Show("All Weapons unlocked.");
    }

    private void dmJ(object sender, EventArgs e) {
        if (BmU.SelectedIndex == 0) {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = "Weapon Data";
            saveFileDialog.Filter = "Save the file containing your weapons|*.bin";
            if (saveFileDialog.ShowDialog() == DialogResult.OK) {
                byte[] bytes = ((IEnumerable<byte>)Class108.io2.ztX).Skip(Class32.jVU).Take(5120).ToArray();
                File.WriteAllBytes(saveFileDialog.FileName, bytes);
            }
        } else {
            if (BmU.SelectedIndex != 1) {
                return;
            }

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Weapon Database File|*.bin";
            if (openFileDialog.ShowDialog() == DialogResult.OK) {
                string fileName = openFileDialog.FileName;
                long length = new FileInfo(fileName).Length;
                if (length != 5120L) {
                    MessageBox.Show("Invalid file.");
                    return;
                }

                byte[] sourceArray = File.ReadAllBytes(fileName);
                Array.Copy(sourceArray, 0L, (Array)Class108.io2.ztX, Class32.jVU, length);
            }
        }
    }

    private void am7(object sender, EventArgs e) {
        if (BmU.SelectedIndex == 0) {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = "Gears Data";
            saveFileDialog.Filter = "Save the file containing your gears|*.bin";
            if (saveFileDialog.ShowDialog() == DialogResult.OK) {
                byte[] bytes = ((IEnumerable<byte>)Class108.io2.ztX).Skip(Class32.YVR).Take(36864).ToArray();
                File.WriteAllBytes(saveFileDialog.FileName, bytes);
            }
        } else {
            if (BmU.SelectedIndex != 1) {
                return;
            }

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Gears Database File|*.bin";
            if (openFileDialog.ShowDialog() == DialogResult.OK) {
                string fileName = openFileDialog.FileName;
                long length = new FileInfo(fileName).Length;
                if (length != 36864L) {
                    MessageBox.Show("Invalid file.");
                    return;
                }

                byte[] sourceArray = File.ReadAllBytes(fileName);
                Array.Copy(sourceArray, 0L, (Array)Class108.io2.ztX, Class32.YVR, length);
            }
        }
    }

    private void VmP(object sender, EventArgs e) {
        if (BmU.SelectedIndex == 0) {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = "Hero Mode Data";
            saveFileDialog.Filter = "|*.bin";
            if (saveFileDialog.ShowDialog() == DialogResult.OK) {
                byte[] bytes = ((IEnumerable<byte>)Class108.io2.ztX).Skip(0).Take(0).ToArray();
                File.WriteAllBytes(saveFileDialog.FileName, bytes);
            }
        } else {
            if (BmU.SelectedIndex != 1) {
                return;
            }

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Hero Mode Database File|*.bin";
            if (openFileDialog.ShowDialog() == DialogResult.OK) {
                string fileName = openFileDialog.FileName;
                long length = new FileInfo(fileName).Length;
                if (length == 0L) {
                    byte[] sourceArray = File.ReadAllBytes(fileName);
                    Array.Copy(sourceArray, 0L, (Array)Class108.io2.ztX, 0L, length);
                } else {
                    MessageBox.Show("Invalid file.");
                }
            }
        }
    }

    private void kmi(object sender, EventArgs e) {
        if (BmU.SelectedIndex == 0) {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = "Plaza Data";
            saveFileDialog.Filter = "Save the file containing the plaza|*.bin";
            if (saveFileDialog.ShowDialog() == DialogResult.OK) {
                byte[] bytes = ((IEnumerable<byte>)Class108.io2.ztX).Skip(46100).Take(5900).ToArray();
                File.WriteAllBytes(saveFileDialog.FileName, bytes);
            }
        } else {
            if (BmU.SelectedIndex != 1) {
                return;
            }

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Plaza Database File|*.bin";
            if (openFileDialog.ShowDialog() == DialogResult.OK) {
                string fileName = openFileDialog.FileName;
                long length = new FileInfo(fileName).Length;
                if (length != 5900L) {
                    MessageBox.Show("Invalid file.");
                    return;
                }

                byte[] sourceArray = File.ReadAllBytes(fileName);
                Array.Copy(sourceArray, 0L, (Array)Class108.io2.ztX, 46100L, length);
            }
        }
    }

    protected override void Dispose(bool disposing) {
        if (disposing && Sm0 != null) {
            Sm0.Dispose();
        }

        base.Dispose(disposing);
    }

    private void pmm() {
        cmI = new GroupBox();
        Tmw = new CheckBox();
        QmR = new Button();
        ImC = new Button();
        mmK = new GroupBox();
        XmW = new Button();
        MmT = new Button();
        Rm1 = new Button();
        BmU = new ComboBox();
        cmI.SuspendLayout();
        mmK.SuspendLayout();
        SuspendLayout();
        cmI.Controls.Add(Tmw);
        cmI.Controls.Add(QmR);
        cmI.Controls.Add(ImC);
        cmI.Location = new Point(12, 104);
        cmI.Name = "groupBox2";
        cmI.Size = new Size(210, 74);
        cmI.TabIndex = 18;
        cmI.TabStop = false;
        cmI.Text = "Unlock all:";
        Tmw.AutoSize = true;
        Tmw.Checked = true;
        Tmw.CheckState = CheckState.Checked;
        Tmw.Location = new Point(8, 51);
        Tmw.Name = "CB_Legal";
        Tmw.Size = new Size(197, 17);
        Tmw.TabIndex = 22;
        Tmw.Text = "Only if the item match with your level";
        Tmw.UseVisualStyleBackColor = true;
        QmR.ImeMode = ImeMode.NoControl;
        QmR.Location = new Point(125, 23);
        QmR.Name = "B_UWeapons";
        QmR.Size = new Size(79, 23);
        QmR.TabIndex = 21;
        QmR.Text = "Weapons";
        QmR.UseVisualStyleBackColor = true;
        QmR.Click += dmL;
        ImC.ImeMode = ImeMode.NoControl;
        ImC.Location = new Point(6, 23);
        ImC.Name = "B_UGear";
        ImC.Size = new Size(77, 22);
        ImC.TabIndex = 20;
        ImC.Text = "Gears";
        ImC.UseVisualStyleBackColor = true;
        ImC.Click += NmQ;
        mmK.Controls.Add(XmW);
        mmK.Controls.Add(MmT);
        mmK.Controls.Add(Rm1);
        mmK.Controls.Add(BmU);
        mmK.Location = new Point(12, 12);
        mmK.Name = "groupBox1";
        mmK.Size = new Size(210, 86);
        mmK.TabIndex = 19;
        mmK.TabStop = false;
        mmK.Text = "Dump/Inject Options";
        XmW.Location = new Point(139, 55);
        XmW.Name = "B_Plaza";
        XmW.Size = new Size(65, 23);
        XmW.TabIndex = 4;
        XmW.Text = "Plaza";
        XmW.UseVisualStyleBackColor = true;
        XmW.Click += kmi;
        MmT.Location = new Point(68, 55);
        MmT.Name = "B_Gears";
        MmT.Size = new Size(65, 23);
        MmT.TabIndex = 2;
        MmT.Text = "Gears";
        MmT.UseVisualStyleBackColor = true;
        MmT.Click += am7;
        Rm1.Location = new Point(6, 55);
        Rm1.Name = "B_Weapons";
        Rm1.Size = new Size(56, 23);
        Rm1.TabIndex = 1;
        Rm1.Text = "Weapons";
        Rm1.UseVisualStyleBackColor = true;
        Rm1.Click += dmJ;
        BmU.DropDownStyle = ComboBoxStyle.DropDownList;
        BmU.FormattingEnabled = true;
        BmU.Items.AddRange(new object[2] { "Export", "Import" });
        BmU.Location = new Point(74, 24);
        BmU.Name = "CB_Choice";
        BmU.Size = new Size(56, 21);
        BmU.TabIndex = 0;
        base.AutoScaleDimensions = new SizeF(6f, 13f);
        base.AutoScaleMode = AutoScaleMode.Font;
        base.ClientSize = new Size(234, 185);
        base.Controls.Add(mmK);
        base.Controls.Add(cmI);
        base.Name = "UnlockSplat1";
        base.ShowIcon = false;
        base.StartPosition = FormStartPosition.CenterScreen;
        Text = "Bulk Edit";
        cmI.ResumeLayout(performLayout: false);
        cmI.PerformLayout();
        mmK.ResumeLayout(performLayout: false);
        ResumeLayout(performLayout: false);
    }
}