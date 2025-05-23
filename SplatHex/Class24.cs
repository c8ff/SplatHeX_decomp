using System;
using System.Collections.Generic;

namespace SplatHex;
internal static class Class24 {
    public delegate void MBX(bool bool_0);
    private static int SD7t;
    private static bool TD7V;
    public static Class60 zD7O;
    private const int yD7e = 50;
    private const int QD78 = 10;
    private static List<MBX> hD7n;
    private static void yD7G(IntPtr intptr_0, bool bool_0) {
        TD7V = SD7t >= Class13.dDgo;
        if (TD7V) {
            SD7t = 0;
        }

        lock (hD7n) {
            for (int i = 0; i <= hD7n.Count - 1; i++) {
                hD7n[i](TD7V);
            }
        }

        SD7t += Class13.MDgt;
    }

    private static void bD7b() {
        if (hD7n.Count != 0) {
            zD7O.BD77(0u, (uint)Class13.YDgV, yD7G);
        } else {
            zD7O.nD7P();
        }
    }

    public static void eD7v(object object_0) {
        lock (hD7n) {
            if (!hD7n.Contains((MBX)object_0)) {
                hD7n.Add((MBX)object_0);
                bD7b();
            }
        }
    }

    public static void uD7o(object object_0) {
        lock (hD7n) {
            if (hD7n.Contains((MBX)object_0)) {
                hD7n.Remove((MBX)object_0);
                bD7b();
            }
        }
    }

    static gB8() {
        zD7O = new Class60();
        hD7n = new List<MBX>();
    }
}