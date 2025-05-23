using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace SplatHex;
public class Class78 : Form {
    public Class120 De1;
    public string VeW = Path.GetTempPath() + "temp.dat";
    private byte[] jew = new byte[48]
    {
        102,
        77,
        116,
        88,
        0,
        0,
        0,
        0,
        0,
        0,
        0,
        0,
        0,
        0,
        0,
        0,
        0,
        0,
        0,
        0,
        0,
        0,
        0,
        0,
        0,
        0,
        0,
        0,
        0,
        0,
        0,
        0,
        0,
        0,
        0,
        0,
        0,
        0,
        0,
        0,
        0,
        0,
        0,
        0,
        0,
        28,
        0,
        54
    };
    public byte[] heN;
    private IDisposable GeY;
    private GroupBox deB;
    private Button xeA;
    private Button ief;
    private TextBox Ye6;
    private Button uex;
    private Button Be9;
    private GroupBox Xec;
    public Class78() {
        reT();
        Ye6.Text = Settings.Default.WiiUIP;
        if (Class67.M8b) {
            AeR();
        }
    }

    private void Hei(object sender, EventArgs e) {
        AeR();
    }

    private void oem(object sender, EventArgs e) {
        De1.aQ();
        Xec.Enabled = false;
        xeA.Enabled = false;
        ief.Enabled = true;
    }

    private void pe0(object sender, EventArgs e) {
        LeC();
    }

    private void HeI(object sender, EventArgs e) {
        if (Settings.Default.LegalCheck && Class129.jXL(bool_0: true)) {
            new Class125().ShowDialog();
        }

        beK();
    }

    private void AeR() {
        De1 = new Class120(Ye6.Text, 7331);
        try {
            De1.yn();
        } catch (Class73 nK) {
            MessageBox.Show("Connection to the TCPGecko failed: \n\n" + nK.Message + "\n\nCheck your network connection/firewall.", "Connection failed", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            return;
        }

        Settings.Default.WiiUIP = Ye6.Text;
        Settings.Default.Save();
        Xec.Enabled = true;
        ief.Enabled = false;
        xeA.Enabled = true;
        if (Class108.io2 == null) {
            LeC();
        }
    }

    private void LeC() {
        try {
            int num = weU();
            if (num != -1) {
                Class108.io2 = new Class108.hrV(heN.Skip(num).Take(Class32.eVi).ToArray());
                MessageBox.Show("Save successfully loaded from memory.");
                xeA.PerformClick();
                Close();
            } else {
                MessageBox.Show("Save Pattern not found !");
                xeA.PerformClick();
                Close();
            }
        } catch {
            MessageBox.Show("Save file loading failed !");
        }
    }

    private void beK() {
        try {
            if (Class108.io2 == null) {
                MessageBox.Show("No Save loaded !");
                return;
            }

            Class97.GXM();
            int num = weU();
            De1.WO((uint)(315228160 + num), (byte[])Class108.io2.ztX);
            MessageBox.Show("Save successfully restored to the memory.");
            xeA.PerformClick();
            Close();
        } catch {
            MessageBox.Show("Failed to restore the save file.");
        }
    }

    private int weU() {
        try {
            FileStream fileStream = new FileStream(VeW, FileMode.Create);
            MemoryStream memoryStream = new MemoryStream();
            De1.P7(315228160u, 315621376u, memoryStream);
            memoryStream.Seek(0L, SeekOrigin.Begin);
            memoryStream.CopyTo(fileStream);
            fileStream.Close();
            heN = File.ReadAllBytes(VeW);
            File.Delete(VeW);
            return Class115.aHd(heN, jew, -54004);
        } catch {
            MessageBox.Show("Failed to attempt to get the save file offset.");
        }

        return -1;
    }

    protected override void Dispose(bool disposing) {
        if (disposing && GeY != null) {
            GeY.Dispose();
        }

        base.Dispose(disposing);
    }

    private void reT() {
        deB = new GroupBox();
        xeA = new Button();
        ief = new Button();
        Ye6 = new TextBox();
        uex = new Button();
        Be9 = new Button();
        Xec = new GroupBox();
        deB.SuspendLayout();
        Xec.SuspendLayout();
        SuspendLayout();
        deB.Controls.Add(xeA);
        deB.Controls.Add(ief);
        deB.Controls.Add(Ye6);
        deB.Location = new Point(12, 12);
        deB.Name = "groupBox1";
        deB.Size = new Size(350, 49);
        deB.TabIndex = 5;
        deB.TabStop = false;
        deB.Text = "TCPGecko Connection";
        xeA.Enabled = false;
        xeA.Location = new Point(230, 17);
        xeA.Name = "B_Disco";
        xeA.Size = new Size(112, 23);
        xeA.TabIndex = 2;
        xeA.Text = "Disconnect";
        xeA.UseVisualStyleBackColor = true;
        xeA.Click += oem;
        ief.Location = new Point(112, 17);
        ief.Name = "B_Connect";
        ief.Size = new Size(112, 23);
        ief.TabIndex = 1;
        ief.Text = "Connect to Gecko";
        ief.UseVisualStyleBackColor = true;
        ief.Click += Hei;
        Ye6.Location = new Point(6, 19);
        Ye6.Name = "TB_WiiUIP";
        Ye6.Size = new Size(100, 20);
        Ye6.TabIndex = 0;
        Ye6.Text = "192.168.147.10";
        uex.Location = new Point(27, 17);
        uex.Name = "B_LoadMem";
        uex.Size = new Size(133, 23);
        uex.TabIndex = 6;
        uex.Text = "Load Save From Memory";
        uex.UseVisualStyleBackColor = true;
        uex.Click += pe0;
        Be9.Location = new Point(190, 17);
        Be9.Name = "B_RMem";
        Be9.Size = new Size(142, 23);
        Be9.TabIndex = 7;
        Be9.Text = "Restore Save To Memory";
        Be9.UseVisualStyleBackColor = true;
        Be9.Click += HeI;
        Xec.Controls.Add(uex);
        Xec.Controls.Add(Be9);
        Xec.Enabled = false;
        Xec.Location = new Point(12, 67);
        Xec.Name = "GB_Files";
        Xec.Size = new Size(350, 47);
        Xec.TabIndex = 8;
        Xec.TabStop = false;
        Xec.Text = "Save Manager";
        base.AutoScaleDimensions = new SizeF(6f, 13f);
        base.AutoScaleMode = AutoScaleMode.Font;
        base.ClientSize = new Size(380, 124);
        base.Controls.Add(Xec);
        base.Controls.Add(deB);
        base.Name = "GeckoForm";
        base.ShowIcon = false;
        base.StartPosition = FormStartPosition.CenterScreen;
        Text = "Gecko Save Manager";
        deB.ResumeLayout(performLayout: false);
        deB.PerformLayout();
        Xec.ResumeLayout(performLayout: false);
        ResumeLayout(performLayout: false);
    }
}