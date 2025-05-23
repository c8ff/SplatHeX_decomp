using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;

namespace SplatHex;
internal class Class91 : BinaryReader {
    [CompilerGenerated]
    private q7J iD8K;
    [SpecialName]
    [CompilerGenerated]
    public q7J eD8I() {
        return iD8K;
    }

    [SpecialName]
    [CompilerGenerated]
    public void bD8R(q7J q7J_0) {
        iD8K = q7J_0;
    }

    public Class91(Stream stream_0, q7J q7J_0 = (q7J)0) : base(stream_0) {
        bD8R(q7J_0);
    }

    public Class91(Stream stream_0, Encoding encoding_0, q7J q7J_0 = (q7J)0) : base(stream_0, encoding_0) {
        bD8R(q7J_0);
    }

    public override short ReadInt16() {
        if (eD8I() == (q7J)0) {
            return base.ReadInt16();
        }

        return BitConverter.ToInt16(base.ReadBytes(2).Reverse().ToArray(), 0);
    }

    public override int ReadInt32() {
        if (eD8I() == (q7J)0) {
            return base.ReadInt32();
        }

        return BitConverter.ToInt32(base.ReadBytes(4).Reverse().ToArray(), 0);
    }

    public override long ReadInt64() {
        if (eD8I() == (q7J)0) {
            return base.ReadInt64();
        }

        return BitConverter.ToInt64(base.ReadBytes(8).Reverse().ToArray(), 0);
    }

    public override ushort ReadUInt16() {
        if (eD8I() == (q7J)0) {
            return base.ReadUInt16();
        }

        return BitConverter.ToUInt16(base.ReadBytes(2).Reverse().ToArray(), 0);
    }

    public override uint ReadUInt32() {
        if (eD8I() == (q7J)0) {
            return base.ReadUInt32();
        }

        return BitConverter.ToUInt32(base.ReadBytes(4).Reverse().ToArray(), 0);
    }

    public override ulong ReadUInt64() {
        if (eD8I() == (q7J)0) {
            return base.ReadUInt64();
        }

        return BitConverter.ToUInt64(base.ReadBytes(8).Reverse().ToArray(), 0);
    }

    public string MD8P(int int_0) {
        return Encoding.ASCII.GetString(ReadBytes(int_0)).TrimEnd(default(char));
    }

    public string ED8i(int int_0, Encoding encoding_0) {
        return encoding_0.GetString(ReadBytes(int_0)).TrimEnd(default(char));
    }

    public string YD8m(int int_0 = 4) {
        List<byte> list = new List<byte>();
        long position = BaseStream.Position;
        for (int i = 0; i < int_0; i++) {
            list.Add(ReadByte());
        }

        BaseStream.Seek(position, SeekOrigin.Begin);
        return Encoding.ASCII.GetString(list.ToArray());
    }

    public string vD80(int int_0, Encoding encoding_0) {
        List<byte> list = new List<byte>();
        long position = BaseStream.Position;
        for (int i = 0; i < int_0; i++) {
            list.Add(ReadByte());
        }

        BaseStream.Seek(position, SeekOrigin.Begin);
        return encoding_0.GetString(list.ToArray());
    }
}