using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace SplatHex;
internal class Class51 : Form {
    private IDisposable IDe5;
    private PictureBox BDes;
    private LinkLabel PDeZ;
    private Label uDea;
    private Label dDej;
    private Button fDez;
    private Label oD8E;
    private Label pD8D;
    public Class51() {
        YDec();
        Text = $"About {iDey()}";
        oD8E.Text = "Actual Revision: " + Class67.Q8V;
        if (Class67.g8O != null) {
            pD8D.Text = "Latest Revision: " + Class67.g8O;
            pD8D.Visible = true;
        }
    }

    [SpecialName]
    public string iDey() {
        object[] customAttributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), inherit: false);
        if (customAttributes.Length != 0) {
            AssemblyTitleAttribute assemblyTitleAttribute = (AssemblyTitleAttribute)customAttributes[0];
            if (assemblyTitleAttribute.Title != "") {
                return assemblyTitleAttribute.Title;
            }
        }

        return Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
    }

    [SpecialName]
    public string sDeq() {
        return Assembly.GetExecutingAssembly().GetName().Version.ToString();
    }

    [SpecialName]
    public string tDeM() {
        object[] customAttributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), inherit: false);
        if (customAttributes.Length == 0) {
            return "";
        }

        return ((AssemblyDescriptionAttribute)customAttributes[0]).Description;
    }

    [SpecialName]
    public string DDeg() {
        object[] customAttributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), inherit: false);
        if (customAttributes.Length == 0) {
            return "";
        }

        return ((AssemblyProductAttribute)customAttributes[0]).Product;
    }

    [SpecialName]
    public string ADe3() {
        object[] customAttributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), inherit: false);
        if (customAttributes.Length == 0) {
            return "";
        }

        return ((AssemblyCopyrightAttribute)customAttributes[0]).Copyright;
    }

    [SpecialName]
    public string WDeH() {
        object[] customAttributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), inherit: false);
        if (customAttributes.Length == 0) {
            return "";
        }

        return ((AssemblyCompanyAttribute)customAttributes[0]).Company;
    }

    private void yDex(object sender, EventArgs e) {
        Close();
    }

    private void yDe9(object sender, LinkLabelLinkClickedEventArgs e) {
        Process.Start("https://leanny.github.io/SplatHeX.html");
    }

    protected override void Dispose(bool disposing) {
        if (disposing && IDe5 != null) {
            IDe5.Dispose();
        }

        base.Dispose(disposing);
    }

    private void YDec() {
        ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Class51));
        BDes = new PictureBox();
        PDeZ = new LinkLabel();
        uDea = new Label();
        dDej = new Label();
        fDez = new Button();
        oD8E = new Label();
        pD8D = new Label();
        ((ISupportInitialize)BDes).BeginInit();
        SuspendLayout();
        BDes.Image = (Image)componentResourceManager.GetObject("logoPictureBox.Image");
        BDes.Location = new Point(12, 13);
        BDes.Name = "logoPictureBox";
        BDes.Size = new Size(128, 128);
        BDes.SizeMode = PictureBoxSizeMode.StretchImage;
        BDes.TabIndex = 12;
        BDes.TabStop = false;
        PDeZ.Location = new Point(143, 30);
        PDeZ.Name = "gitLink";
        PDeZ.Padding = new Padding(4, 0, 0, 0);
        PDeZ.Size = new Size(100, 17);
        PDeZ.TabIndex = 30;
        PDeZ.TabStop = true;
        PDeZ.Text = "Website";
        PDeZ.TextAlign = ContentAlignment.MiddleLeft;
        PDeZ.LinkClicked += yDe9;
        uDea.AutoSize = true;
        uDea.Location = new Point(146, 13);
        uDea.Name = "labelProductName";
        uDea.Size = new Size(107, 13);
        uDea.TabIndex = 31;
        uDea.Text = "Splatoon Save Editor";
        dDej.AutoSize = true;
        dDej.Location = new Point(146, 52);
        dDej.Name = "labelVersion";
        dDej.Size = new Size(135, 13);
        dDej.TabIndex = 32;
        dDej.Text = "Created By: WemI0 && Lean";
        fDez.DialogResult = DialogResult.Cancel;
        fDez.Location = new Point(206, 118);
        fDez.Name = "okButton";
        fDez.Size = new Size(75, 23);
        fDez.TabIndex = 34;
        fDez.Text = "&OK";
        fDez.Click += yDex;
        oD8E.AutoSize = true;
        oD8E.Location = new Point(145, 75);
        oD8E.Name = "LB_Rev";
        oD8E.Size = new Size(84, 13);
        oD8E.TabIndex = 35;
        oD8E.Text = "Actual Revision:";
        pD8D.AutoSize = true;
        pD8D.Location = new Point(146, 93);
        pD8D.Name = "LB_Rev2";
        pD8D.Size = new Size(83, 13);
        pD8D.TabIndex = 36;
        pD8D.Text = "Latest Revision:";
        pD8D.Visible = false;
        base.AutoScaleDimensions = new SizeF(6f, 13f);
        base.AutoScaleMode = AutoScaleMode.Font;
        base.ClientSize = new Size(293, 146);
        base.Controls.Add(pD8D);
        base.Controls.Add(oD8E);
        base.Controls.Add(fDez);
        base.Controls.Add(dDej);
        base.Controls.Add(uDea);
        base.Controls.Add(PDeZ);
        base.Controls.Add(BDes);
        base.FormBorderStyle = FormBorderStyle.FixedDialog;
        base.MaximizeBox = false;
        base.MinimizeBox = false;
        base.Name = "AboutForm";
        base.Padding = new Padding(9);
        base.ShowIcon = false;
        base.ShowInTaskbar = false;
        base.StartPosition = FormStartPosition.CenterParent;
        Text = "AboutForm";
        ((ISupportInitialize)BDes).EndInit();
        ResumeLayout(performLayout: false);
        PerformLayout();
    }
}