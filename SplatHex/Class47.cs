namespace SplatHex;
internal class Class47 {
    public static int i4E(object object_0, int int_0) {
        return (((byte[])object_0)[int_0] << 24) | (((byte[])object_0)[int_0 + 1] << 16) | (((byte[])object_0)[int_0 + 2] << 8) | ((byte[])object_0)[int_0 + 3];
    }

    public static short y4D(short short_0) {
        return (short)(((short_0 & 0xFF) << 8) | ((short_0 >> 8) & 0xFF));
    }

    public static int a4X(int int_0) {
        return ((y4D((short)int_0) & 0xFFFF) << 16) | (y4D((short)(int_0 >> 16)) & 0xFFFF);
    }

    internal static bool kZk() {
        return true;
    }

    internal static bool eZc() {
        return false;
    }
}