using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace SplatHex;
internal static class Class115 {
    internal static string oHa;
    internal static string kHj;
    internal static Random KHz;
    public static void LHc() {
        OpenFileDialog openFileDialog = new OpenFileDialog();
        openFileDialog.Filter = "save.dat (*.dat)|*.dat";
        openFileDialog.FileName = "save.dat";
        if (openFileDialog.ShowDialog() != DialogResult.OK) {
            oHa = null;
        } else {
            oHa = openFileDialog.FileName;
        }
    }

    public static void FHy() {
        SaveFileDialog saveFileDialog = new SaveFileDialog();
        saveFileDialog.Filter = "save.dat (*.dat)|*.dat";
        saveFileDialog.FileName = Path.GetFileName(oHa);
        if (saveFileDialog.ShowDialog() != DialogResult.OK) {
            kHj = null;
        } else {
            kHj = saveFileDialog.FileName;
        }
    }

    public static byte[] yHr(string string_0) {
        return Class65.uDng(File.ReadAllBytes(string_0));
    }

    public static void SHq(string string_0) {
        Class26.QXu.fpD();
        Class26.QXu.kpE();
        File.WriteAllBytes(string_0, Class65.IDn2(Class26.QXu.dpX));
        Class26.QXu.aXz();
    }

    public static decimal VHk(object object_0, int int_0, bool bool_0 = false) {
        byte[] array = ((IEnumerable<byte>)object_0).Skip(int_0).Take(4).ToArray();
        if (!BitConverter.IsLittleEndian) {
            array = array.Reverse().ToArray();
        }

        if (bool_0) {
            array = array.Reverse().ToArray();
        }

        return new decimal(BitConverter.ToSingle(array, 0));
    }

    public static float eHM(uint uint_0) {
        return BitConverter.ToSingle(BitConverter.GetBytes(uint_0), 0);
    }

    public static DateTime LHu(double double_0) {
        return new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc).AddSeconds(double_0).ToLocalTime();
    }

    public static int DHg(DateTimePicker dateTimePicker_0) {
        return (int)dateTimePicker_0.Value.Subtract(new DateTime(1970, 1, 1)).TotalSeconds;
    }

    public static void cH2(ref uint uint_0, uint uint_1, bool bool_0) {
        if ((uint_0 & uint_1) != 0 && !bool_0) {
            uint_0 ^= uint_1;
        } else if ((uint_0 & uint_1) == 0 && bool_0) {
            uint_0 |= uint_1;
        }
    }

    public static string FH3(string string_0) {
        try {
            using WebClient webClient = new WebClient();
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            if (stopwatch.ElapsedMilliseconds < 1000L) {
                if (stopwatch.ElapsedMilliseconds > 1000L) {
                    return null;
                }

                return webClient.DownloadString(string_0);
            }

            return null;
        } catch {
            return null;
        }
    }

    public static int aHd(object object_0, object object_1, int int_0) {
        int num = -1;
        try {
            for (int i = 0; i < ((Array)object_0).Length; i++) {
                if (oHH(object_0, object_1, i)) {
                    num = i + int_0;
                    return num;
                }
            }

            if (num == -1) {
                return num;
            }
        } catch {
            MessageBox.Show("Error while searching pattern");
        }

        return num;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static bool oHH(object object_0, object object_1, int int_0) {
        if (int_0 + ((Array)object_1).Length > ((Array)object_0).Length) {
            return false;
        }

        int num = 0;
        while (true) {
            if (num < ((Array)object_1).Length) {
                if (((byte[])object_1)[num] != ((byte[])object_0)[int_0 + num]) {
                    break;
                }

                num++;
                continue;
            }

            return true;
        }

        return false;
    }

    public static void bH4(object object_0, int int_0, int int_1, string string_0, string string_1) {
        SaveFileDialog saveFileDialog = new SaveFileDialog();
        saveFileDialog.FileName = string_0;
        saveFileDialog.Filter = string_1 + "| *.bin";
        if (saveFileDialog.ShowDialog() == DialogResult.OK) {
            byte[] bytes = ((IEnumerable<byte>)object_0).Skip(int_0).Take(int_1).ToArray();
            File.WriteAllBytes(saveFileDialog.FileName, bytes);
        }
    }

    public static void LH5(Array array_0, int int_0, int int_1, string string_0, string string_1) {
        OpenFileDialog openFileDialog = new OpenFileDialog();
        openFileDialog.FileName = string_0;
        openFileDialog.Filter = string_1 + "| *.bin";
        if (openFileDialog.ShowDialog() == DialogResult.OK) {
            string fileName = openFileDialog.FileName;
            long length = new FileInfo(fileName).Length;
            if (length != int_1) {
                MessageBox.Show("Invalid file.");
                return;
            }

            byte[] sourceArray = File.ReadAllBytes(fileName);
            Array.Copy(sourceArray, 0, array_0, int_0, int_1);
        }
    }

    public static int nHs(int int_0, int int_1) {
        lock (KHz) {
            return KHz.Next(int_0, int_1 + 1);
        }
    }

    public static int vHZ() {
        return (int)DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1)).TotalSeconds;
    }

    static C76() {
        KHz = new Random();
    }
}