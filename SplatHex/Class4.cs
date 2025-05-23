using System;
using System.Collections.Generic;
using System.Drawing;

namespace SplatHex;
public abstract class Class4 {
    public static string SDr(int int_0, Dictionary<int, Class25> dictionary_0) {
        return dictionary_0[int_0].rDY;
    }

    public static Image ADq(int int_0, Dictionary<int, Class25> dictionary_0) {
        return (Image)dictionary_0[int_0].eDB;
    }

    public static int JDk(object object_0, Dictionary<int, Class25> dictionary_0) {
        Dictionary<string, int> dictionary = dictionary_0.ToDictionary((KeyValuePair<int, Class25> keyValuePair_0) => keyValuePair_0.Value.rDY, (KeyValuePair<int, Class25> keyValuePair_0) => keyValuePair_0.Key);
        return dictionary[(string)object_0];
    }

    public static bool kDM(int int_0, object object_0) {
        return ((IEnumerable<Class33>)object_0).Where((Class33 x0_0) => x0_0.hXP == int_0).Any();
    }

    public static Class33 aDu(object object_0) {
        return ((IEnumerable<Class33>)object_0).Where((Class33 x0_0) => x0_0.hXP == -1).First();
    }

    public static bool rDg(int int_0, Dictionary<int, int> dictionary_0) {
        try {
            if (dictionary_0[int_0] > Class108.io2.Tti) {
                return false;
            }
        } catch {
            if (4 > Class108.io2.Tti && !Class117.kok.Contains(int_0)) {
                return false;
            }

            if (int_0 == 26000) {
                return false;
            }
        }

        return true;
    }

    public static bool bD2(int int_0) {
        if (4 > Class26.QXu.GpJ && !Class85.Sha.Contains(int_0)) {
            return Class26.QXu.GpP != 0;
        }

        return true;
    }

    public static Class33 kD3(Class33[] x0_0, int int_0, int int_1, int int_2, int int_3, int int_4, int int_5, int int_6, int int_7) {
        Class33 x = aDu(x0_0);
        x.hXP = int_0;
        x.RX7 = int_1;
        x.xXi = int_2;
        x.vX0 = int_3;
        x.wXI = int_4;
        x.GXR = int_5;
        x.UXK = int_6;
        x.CXU = int_7;
        return x;
    }

    public static Class33 LDd(Class33[] x0_0, int int_0, int int_1, int int_2, int int_3, int int_4, int int_5, int int_6, int int_7, int int_8) {
        Class33 x = aDu(x0_0);
        x.hXP = int_0;
        x.RX7 = int_1;
        x.xXi = int_2;
        x.HXm = int_3;
        x.vX0 = int_4;
        x.wXI = int_5;
        x.GXR = int_6;
        x.UXK = int_7;
        x.CXU = int_8;
        return x;
    }

    public static void ODH(object object_0, object object_1) {
        for (int i = 0; i < ((Array)object_0).Length; i++) {
            if (((Class33)((object[])object_0)[i]).hXP == ((Class33)object_1).hXP) {
                ((object[])object_0)[i] = new Class108.fr2(Resources.emptyGearS2);
            }
        }
    }

    public static void GD4(object object_0, object object_1) {
        for (int i = 0; i < ((Array)object_0).Length; i++) {
            if (((Class33)((object[])object_0)[i]).hXP == ((Class33)object_1).hXP) {
                ((object[])object_0)[i] = new Class26.P4(Resources.emptyGearS2);
            }
        }
    }

    public static void DD5(object object_0) {
        byte[] emptyGear = Resources.emptyGear;
        byte[] array = new byte[0];
        for (int i = 0; i < ((Array)object_0).Length; i++) {
            if (((Class33)((object[])object_0)[i]).hXP != -1) {
                Array.Resize(ref array, array.Length + Class32.uVB);
                Array.Copy(((Class33)((object[])object_0)[i]).Write(), 0, array, array.Length - Class32.uVB, Class32.uVB);
            }
        }

        for (int j = 0; j < ((Array)object_0).Length; j++) {
            ((object[])object_0)[j] = new Class108.fr2(emptyGear);
        }

        for (int k = 0; k < array.Length / Class32.uVB; k++) {
            ((object[])object_0)[k] = new Class108.fr2(array.Skip(k * Class32.uVB).Take(Class32.uVB).ToArray());
        }
    }

    internal static bool nV() {
        return false;
    }
}