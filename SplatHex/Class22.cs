using System;
using System.Collections.Generic;
using System.Drawing;

namespace SplatHex;
internal static class Class22 {
    public static string KXS(int int_0, Dictionary<int, Class119> dictionary_0) {
        return dictionary_0[int_0].aDj;
    }

    public static Image hXh(int int_0, Dictionary<int, Class119> dictionary_0) {
        return (Image)dictionary_0[int_0].oDz;
    }

    public static int RXl(object object_0, Dictionary<int, Class119> dictionary_0) {
        Dictionary<string, int> dictionary = dictionary_0.ToDictionary((KeyValuePair<int, Class119> keyValuePair_0) => keyValuePair_0.Value.aDj, (KeyValuePair<int, Class119> keyValuePair_0) => keyValuePair_0.Key);
        return dictionary[(string)object_0];
    }

    public static void iXG(int int_0, int int_1, int int_2, int int_3, int int_4, int int_5) {
        Class108.Vo4[int_0].btx = int_1;
        Class108.Vo4[int_0].atq = int_2;
        Class108.Vo4[int_0].itk = int_3;
        Class108.Vo4[int_0].gtc = int_4;
        Class108.Vo4[int_0].pty = int_5;
    }

    public static void JXb(int int_0, int int_1, int int_2, int int_3, int int_4, int int_5) {
        Class26.RXd[int_0].ISk = int_1;
        Class26.RXd[int_0].wS2 = int_2;
        Class26.RXd[int_0].NSH = int_3;
        Class26.RXd[int_0].nSM = int_4;
        Class26.RXd[int_0].kSu = int_5;
    }

    public static bool WXv(int int_0) {
        int num = 0;
        while (true) {
            if (num < Class108.Vo4.Length) {
                if (Class108.Vo4[num].btx == int_0) {
                    break;
                }

                num++;
                continue;
            }

            return false;
        }

        return true;
    }

    public static bool LXo(int int_0) {
        int num = 0;
        while (true) {
            if (num < Class26.RXd.Length) {
                if (Class26.RXd[num].ISk == int_0) {
                    break;
                }

                num++;
                continue;
            }

            return false;
        }

        return true;
    }

    public static int qXt(object object_0) {
        int num = 0;
        while (true) {
            if (num < ((Array)object_0).Length) {
                if (((Class108.UrT)((object[])object_0)[num]).btx == -1) {
                    break;
                }

                num++;
                continue;
            }

            return 500;
        }

        return num;
    }

    public static int YXV(object object_0) {
        int num = 0;
        while (true) {
            if (num < ((Array)object_0).Length) {
                if (((Class26.AP)((object[])object_0)[num]).ISk == -1) {
                    break;
                }

                num++;
                continue;
            }

            return 1000;
        }

        return num;
    }

    public static bool vXO(int int_0) {
        return Class46.Lou[int_0].SDa <= Class108.io2.Tti;
    }

    public static bool JXe(int int_0) {
        if (Class122.PlD[int_0].SDa > Class26.QXu.GpJ && Class26.QXu.GpP == 0) {
            return false;
        }

        return true;
    }

    public static bool PX8(int int_0) {
        if (Class26.RXd[int_0].kSu != Class122.PlD[Class26.RXd[int_0].ISk].DXD) {
            return false;
        }

        if (Class26.RXd[int_0].nSM != Class122.PlD[Class26.RXd[int_0].ISk].WXE) {
            return false;
        }

        return true;
    }

    public static void NXn(int int_0) {
        byte[] emptyWeapon = Resources.emptyWeapon;
        Class108.Vo4[int_0] = new Class108.UrT(emptyWeapon);
    }

    public static void cXQ(int int_0) {
        byte[] emptyWeaponS = Resources.emptyWeaponS2;
        Class26.RXd[int_0] = new Class26.AP(emptyWeaponS);
    }

    public static void nXF() {
        byte[] emptyWeapon = Resources.emptyWeapon;
        byte[] array = new byte[0];
        for (int i = 0; i < Class108.Vo4.Length; i++) {
            if (Class108.Vo4[i].btx != -1) {
                Array.Resize(ref array, array.Length + Class32.TVA);
                Array.Copy(Class108.Vo4[i].Gtf(), 0, array, array.Length - Class32.TVA, Class32.TVA);
            }
        }

        for (int j = 0; j < Class108.Vo4.Length; j++) {
            Class108.Vo4[j] = new Class108.UrT(emptyWeapon);
        }

        for (int k = 0; k < array.Length / Class32.TVA; k++) {
            Class108.Vo4[k] = new Class108.UrT(array.Skip(k * Class32.TVA).Take(Class32.TVA).ToArray());
        }
    }
}