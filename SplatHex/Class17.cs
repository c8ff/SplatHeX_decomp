using System;

namespace SplatHex;
public static class Class17 {
    public static ushort rD(ushort ushort_0) {
        if (BitConverter.IsLittleEndian) {
            return (ushort)(((0xFF00 & ushort_0) >> 8) | ((0xFF & ushort_0) << 8));
        }

        return ushort_0;
    }

    public static uint MX(uint uint_0) {
        if (BitConverter.IsLittleEndian) {
            return ((0xFF000000u & uint_0) >> 24) | ((0xFF0000 & uint_0) >> 8) | ((0xFF00 & uint_0) << 8) | ((0xFF & uint_0) << 24);
        }

        return uint_0;
    }

    public static ulong jp(ulong ulong_0) {
        if (BitConverter.IsLittleEndian) {
            return ((0xFF00000000000000uL & ulong_0) >> 56) | ((0xFF000000000000L & ulong_0) >> 40) | ((0xFF0000000000L & ulong_0) >> 24) | ((0xFF00000000L & ulong_0) >> 8) | ((0xFF000000L & ulong_0) << 8) | ((0xFF0000L & ulong_0) << 24) | ((0xFF00L & ulong_0) << 40) | ((0xFFL & ulong_0) << 56);
        }

        return ulong_0;
    }

    internal static bool o8() {
        return true;
    }

    internal static bool yp() {
        return false;
    }
}