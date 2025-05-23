
using System;
using System.Globalization;

namespace SplatHex;
public class Class70 {
    public static int DDnZ(string string_0) {
        return (int)long.Parse(string_0, (NumberStyles)Class13.FDMT);
    }

    public static float gDna(uint uint_0) {
        return BitConverter.ToSingle(BitConverter.GetBytes(uint_0), 0);
    }

    public static uint nDnj(float float_0) {
        return (uint)(BitConverter.GetBytes(float_0)[3] << 8);
    }

    internal static string SDnz(uint uint_0) {
        throw new NotImplementedException();
    }

    internal static bool vUL() {
        return true;
    }

    internal static bool FUG() {
        return false;
    }
}