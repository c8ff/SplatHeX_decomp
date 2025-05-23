using System;

namespace SplatHex;
public class Class101 {
    public static ushort qD7Y(ushort ushort_0) {
        if (BitConverter.IsLittleEndian) {
            return (ushort)(((Class13.SDgT & ushort_0) >> 8) | ((Class13.oDg1 & ushort_0) << 8));
        }

        return ushort_0;
    }

    public static uint BD7B(uint uint_0) {
        if (BitConverter.IsLittleEndian) {
            return (((uint)Class13.KDgW & uint_0) >> (int)Class13.jDgw) | (((uint)Class13.YDgN & uint_0) >> 8) | (((uint)Class13.cDgY & uint_0) << 8) | (((uint)Class13.GDgB & uint_0) << (int)Class13.nDgA);
        }

        return uint_0;
    }

    public static ulong SD7A(ulong ulong_0) {
        if (BitConverter.IsLittleEndian) {
            return (((ulong)Class13.eDgf & ulong_0) >> (int)Class13.NDg6) | (((ulong)Class13.YDgx & ulong_0) >> (int)Class13.MDg9) | (((ulong)Class13.cDgc & ulong_0) >> (int)Class13.rDgy) | (((ulong)Class13.eDgr & ulong_0) >> 8) | (((uint)Class13.HDgq & ulong_0) << 8) | (((ulong)Class13.pDgk & ulong_0) << (int)Class13.nDgM) | (((ulong)Class13.yDgu & ulong_0) << (int)Class13.ADgg) | (((ulong)Class13.zDg2 & ulong_0) << (int)Class13.yDg3);
        }

        return ulong_0;
    }

    internal static bool MUk() {
        return true;
    }

    internal static bool OUc() {
        return false;
    }
}