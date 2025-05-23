using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Windows.Forms;

namespace SplatHex;
public class Class94 : Form {
    private WebClient RD8G;
    private Stopwatch kD8b = new Stopwatch();
    private IDisposable iD8v;
    private RichTextBox kD8o;
    private Label dD8t;
    private Label XD8V;
    private Label gD8O;
    private ProgressBar mD8e;
    private Button HD88;
    public Class94() {
        mD8l();
        base.Size = new Size(668, 381);
        kD8o.Text = Class115.FH3("http://leanny.github.io/files/changelog.txt");
    }

    public void rD8X(string string_0, string string_1) {
        using (RD8G = new WebClient()) {
            RD8G.DownloadFileCompleted += HD8p;
            RD8G.DownloadProgressChanged += PD8S;
            Uri address = (string_0.StartsWith("http://", StringComparison.OrdinalIgnoreCase) ? new Uri(string_0) : new Uri("http://" + string_0));
            kD8b.Start();
            try {
                RD8G.DownloadFileAsync(address, string_1);
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }

    private void HD8p(object sender, AsyncCompletedEventArgs e) {
        kD8b.Reset();
        if (e.Cancelled) {
            MessageBox.Show("Download has been canceled.");
            return;
        }

        MessageBox.Show("Download completed!\n" + AppDomain.CurrentDomain.BaseDirectory + "SplatHeX.zip");
        base.Size = new Size(668, 381);
    }

    private void PD8S(object sender, DownloadProgressChangedEventArgs e) {
        gD8O.Text = string.Format("{0} kb/s", ((double)e.BytesReceived / 1024.0 / kD8b.Elapsed.TotalSeconds).ToString("0.00"));
        mD8e.Value = e.ProgressPercentage;
        XD8V.Text = e.ProgressPercentage + "%";
        dD8t.Text = string.Format("{0} MB's / {1} MB's", ((double)e.BytesReceived / 1024.0 / 1024.0).ToString("0.00"), ((double)e.TotalBytesToReceive / 1024.0 / 1024.0).ToString("0.00"));
    }

    private void CD8h(object sender, EventArgs e) {
        rD8X(Class115.FH3("http://leanny.github.io/files/url.txt"), "SplatHeX.zip");
        base.Size = new Size(668, 480);
    }

    protected override void Dispose(bool disposing) {
        if (disposing && iD8v != null) {
            iD8v.Dispose();
        }

        base.Dispose(disposing);
    }

    private void mD8l() {
        kD8o = new RichTextBox();
        dD8t = new Label();
        XD8V = new Label();
        gD8O = new Label();
        mD8e = new ProgressBar();
        HD88 = new Button();
        SuspendLayout();
        kD8o.Location = new Point(12, 12);
        kD8o.Name = "RTB_Changelog";
        kD8o.ReadOnly = true;
        kD8o.Size = new Size(631, 296);
        kD8o.TabIndex = 1;
        kD8o.Text = "";
        kD8o.WordWrap = false;
        dD8t.AutoSize = true;
        dD8t.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
        dD8t.Location = new Point(230, 393);
        dD8t.Name = "labelDownloaded";
        dD8t.Size = new Size(64, 18);
        dD8t.TabIndex = 7;
        dD8t.Text = "TotalMB";
        XD8V.AutoSize = true;
        XD8V.Location = new Point(299, 369);
        XD8V.Name = "labelPerc";
        XD8V.Size = new Size(33, 13);
        XD8V.TabIndex = 6;
        XD8V.Text = "100%";
        gD8O.AutoSize = true;
        gD8O.Location = new Point(279, 422);
        gD8O.Name = "labelSpeed";
        gD8O.Size = new Size(38, 13);
        gD8O.TabIndex = 5;
        gD8O.Text = "Speed";
        mD8e.Location = new Point(9, 343);
        mD8e.Name = "progressBar";
        mD8e.Size = new Size(631, 23);
        mD8e.TabIndex = 4;
        HD88.Location = new Point(260, 314);
        HD88.Name = "BTN_Update";
        HD88.Size = new Size(103, 23);
        HD88.TabIndex = 8;
        HD88.Text = "Update SplatHeX";
        HD88.UseVisualStyleBackColor = true;
        HD88.Click += CD8h;
        base.AutoScaleDimensions = new SizeF(6f, 13f);
        base.AutoScaleMode = AutoScaleMode.Font;
        base.ClientSize = new Size(652, 441);
        base.Controls.Add(HD88);
        base.Controls.Add(dD8t);
        base.Controls.Add(XD8V);
        base.Controls.Add(gD8O);
        base.Controls.Add(mD8e);
        base.Controls.Add(kD8o);
        base.Name = "UpdateForm";
        base.ShowIcon = false;
        base.StartPosition = FormStartPosition.CenterScreen;
        Text = "Update";
        ResumeLayout(performLayout: false);
        PerformLayout();
    }
}