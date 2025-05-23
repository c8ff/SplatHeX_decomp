using System;

namespace SplatHex;
public class Class112 {
    public static ushort qDQ7(ushort ushort_0) {
        if (BitConverter.IsLittleEndian) {
            return (ushort)(((Class13.YDM2 & ushort_0) >> 8) | ((Class13.YDM3 & ushort_0) << 8));
        }

        return ushort_0;
    }

    public static uint FDQP(uint uint_0) {
        if (BitConverter.IsLittleEndian) {
            return (((uint)Class13.YDMd & uint_0) >> (int)Class13.oDMH) | (((uint)Class13.zDM4 & uint_0) >> 8) | (((uint)Class13.RDM5 & uint_0) << 8) | (((uint)Class13.RDMs & uint_0) << (int)Class13.wDMZ);
        }

        return uint_0;
    }

    public static ulong hDQi(ulong ulong_0) {
        if (BitConverter.IsLittleEndian) {
            return (((ulong)Class13.yDMa & ulong_0) >> (int)Class13.kDMj) | (((ulong)Class13.sDMz & ulong_0) >> (int)Class13.aDuE) | (((ulong)Class13.yDuD & ulong_0) >> (int)Class13.eDuX) | (((ulong)Class13.YDup & ulong_0) >> 8) | (((uint)Class13.UDuS & ulong_0) << 8) | (((ulong)Class13.tDuh & ulong_0) << (int)Class13.TDul) | (((ulong)Class13.PDuG & ulong_0) << (int)Class13.aDub) | (((ulong)Class13.hDuv & ulong_0) << (int)Class13.EDuo);
        }

        return ulong_0;
    }

    internal static bool PUX() {
        return true;
    }

    internal static bool KUM() {
        return false;
    }
}