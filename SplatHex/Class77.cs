using System.IO;

namespace SplatHex;
internal class Class77 {
    private readonly BinaryReader dSUW;
    public Class77(Stream stream_0) {
        dSUW = new BinaryReader(stream_0);
    }

    public Class77(byte[] byte_0) : this(new MemoryStream(byte_0)) {
    }

    public string gSUR() {
        return dSUW.ReadString();
    }

    public sbyte PSUC() {
        return dSUW.ReadSByte();
    }

    public int cSUK() {
        return dSUW.ReadInt32();
    }

    public long RSUU() {
        return dSUW.ReadInt64();
    }

    public float hSUT() {
        return dSUW.ReadSingle();
    }

    public double QSU1() {
        return dSUW.ReadDouble();
    }

    internal static bool Jpq() {
        return true;
    }

    internal static bool ppI() {
        return false;
    }
}