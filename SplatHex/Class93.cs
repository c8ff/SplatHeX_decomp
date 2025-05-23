using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;

namespace SplatHex;
internal class Class93 : BinaryWriter {
    [CompilerGenerated]
    private q7J rD8w;
    [SpecialName]
    [CompilerGenerated]
    public q7J dD8T() {
        return rD8w;
    }

    [SpecialName]
    [CompilerGenerated]
    public void gD81(q7J q7J_0) {
        rD8w = q7J_0;
    }

    public Class93(Stream stream_0, q7J q7J_0 = (q7J)0) : base(stream_0) {
        gD81(q7J_0);
    }

    public Class93(Stream stream_0, Encoding encoding_0, q7J q7J_0 = (q7J)0) : base(stream_0, encoding_0) {
        gD81(q7J_0);
    }

    public override void Write(short value) {
        if (dD8T() != 0) {
            base.Write(BitConverter.GetBytes(value).Reverse().ToArray());
        } else {
            base.Write(value);
        }
    }

    public override void Write(int value) {
        if (dD8T() == (q7J)0) {
            base.Write(value);
        } else {
            base.Write(BitConverter.GetBytes(value).Reverse().ToArray());
        }
    }

    public override void Write(long value) {
        if (dD8T() != 0) {
            base.Write(BitConverter.GetBytes(value).Reverse().ToArray());
        } else {
            base.Write(value);
        }
    }

    public override void Write(ushort value) {
        if (dD8T() == (q7J)0) {
            base.Write(value);
        } else {
            base.Write(BitConverter.GetBytes(value).Reverse().ToArray());
        }
    }

    public override void Write(uint value) {
        if (dD8T() != 0) {
            base.Write(BitConverter.GetBytes(value).Reverse().ToArray());
        } else {
            base.Write(value);
        }
    }

    public override void Write(ulong value) {
        if (dD8T() != 0) {
            base.Write(BitConverter.GetBytes(value).Reverse().ToArray());
        } else {
            base.Write(value);
        }
    }

    public void FD8U(string string_0) {
        base.Write(Encoding.ASCII.GetBytes(string_0));
    }
}