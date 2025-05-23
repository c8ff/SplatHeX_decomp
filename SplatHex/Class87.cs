using System;
using System.IO;
using System.Windows.Forms;

namespace SplatHex;
internal static class Class87 {
    [STAThread]
    private static void Main(string[] args) {
        if (args.Length != 0 && File.Exists(args[0])) {
            int[] source = new int[3]
            {
                295904,
                550976,
                560528
            };
            int[] source2 = new int[3]
            {
                295856,
                550928,
                560480
            };
            if (File.Exists(args[0])) {
                long length = new FileInfo(args[0]).Length;
                if (source.Contains((int)length)) {
                    File.WriteAllBytes(args[0], Class65.uDng(File.ReadAllBytes(args[0])));
                } else if (source2.Contains((int)length)) {
                    File.WriteAllBytes(args[0], Class65.IDn2(File.ReadAllBytes(args[0])));
                } else {
                    MessageBox.Show("Invalid save file.");
                }
            }
        } else {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(defaultValue: false);
            Application.Run(new Class67());
        }
    }

    internal static bool bZW() {
        return false;
    }
}