using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;

namespace SplatHex;
public class Class120 {
    private Class121 YY;
    private const uint jB = 1024u;
    private const uint eA = 1024u;
    private const byte df = 1;
    private const byte P6 = 2;
    private const byte Xx = 3;
    private const byte h9 = 4;
    private const byte Vc = 6;
    private const byte Yy = 7;
    private const byte Hr = 9;
    private const byte bq = 11;
    private const byte Wk = 12;
    private const byte zM = 16;
    private const byte gu = 47;
    private const byte Sg = 48;
    private const byte N2 = 56;
    private const byte r3 = 64;
    private const byte dd = 65;
    private const byte AH = 66;
    private const byte V4 = 67;
    private const byte H5 = 68;
    private const byte es = 80;
    private const byte gZ = 96;
    private const byte Ua = 112;
    private const byte mj = 137;
    private const byte az = 153;
    private const byte oDE = 154;
    private const byte NDD = 17;
    private const byte SDX = 170;
    private const byte qDp = 187;
    private const byte dDS = 204;
    private const byte XDh = byte.MaxValue;
    private const byte qDl = 176;
    private const byte gDG = 189;
    private const byte wDb = 128;
    private const byte JDv = 129;
    private const byte nDo = 130;
    private static readonly byte[] xDt;
    private const byte YDV = 3;
    private const byte RDO = 5;
    private const byte gDe = 6;
    private const byte TD8 = 7;
    [CompilerGenerated]
    private mi wDn;
    private bool LDQ;
    private bool cDF;
    private event mi ST {
        [CompilerGenerated]
        add {
            mi mi = wDn;
            mi mi2;
            do {
                mi2 = mi;
                mi value2 = (mi)Delegate.Combine(mi2, value);
                mi = Interlocked.CompareExchange(ref wDn, value2, mi2);
            }
            while ((object)mi != mi2);
        }

        [CompilerGenerated]
        remove {
            mi mi = wDn;
            mi mi2;
            do {
                mi2 = mi;
                mi value2 = (mi)Delegate.Remove(mi2, value);
                mi = Interlocked.CompareExchange(ref wDn, value2, mi2);
            }
            while ((object)mi != mi2);
        }
    }

    public event mi TN {
        add {
            ST += value;
        }

        remove {
            ST -= value;
        }
    }

    public void WO(uint uint_0, byte[] byte_0) {
        ajTg(uint_0, byte_0);
    }

    public virtual bool ajTg(uint uint_0, byte[] byte_0) {
        if (le(65) != (Wc)2) {
            throw new Class73((Mo)8);
        }

        byte[] array = new byte[8];
        byte[] bytes = BitConverter.GetBytes(Class17.MX(uint_0));
        Array.Copy(bytes, 0, array, 0, 4);
        bytes = BitConverter.GetBytes(Class17.MX(uint_0 + (uint)byte_0.Length));
        Array.Copy(bytes, 0, array, 4, 4);
        int int_ = byte_0.Length;
        if (lL(array, 8) != (Wc)2) {
            throw new Class73((Mo)8);
        }

        if (lL(byte_0, int_) != (Wc)2) {
            throw new Class73((Mo)8);
        }

        byte[] array2 = new byte[1];
        if (WF(array2, 1u) != (Wc)2) {
            throw new Class73((Mo)9);
        }

        byte b = array2[0];
        return b == 170;
    }

    public Wc le(byte byte_0) {
        return lL(BitConverter.GetBytes(byte_0), 1);
    }

    [SpecialName]
    public bool L0() {
        return cDF;
    }

    [SpecialName]
    public void YI(bool bool_0) {
        cDF = bool_0;
    }

    public Class120(string string_0, int int_0) {
        YY = new Class121(string_0, int_0);
        LDQ = false;
        wDn = null;
    }

    protected bool s8() {
        return true;
    }

    public bool yn() {
        if (LDQ) {
            aQ();
        }

        LDQ = false;
        try {
            YY.dDL();
        } catch (IOException) {
            aQ();
            throw new Class73((Mo)2);
        }

        if (s8()) {
            Thread.Sleep(150);
            LDQ = true;
            return true;
        }

        return false;
    }

    public void aQ() {
        LDQ = false;
        YY.IDJ();
    }

    protected Wc WF(byte[] byte_0, uint uint_0) {
        uint uint_1 = 0u;
        try {
            YY.GDP(byte_0, uint_0, ref uint_1);
        } catch (IOException) {
            aQ();
            return (Wc)1;
        }

        if (uint_1 != uint_0) {
            return (Wc)0;
        }

        return (Wc)2;
    }

    protected Wc lL(byte[] byte_0, int int_0) {
        uint uint_ = 0u;
        try {
            YY.EDi(byte_0, int_0, ref uint_);
        } catch (IOException) {
            aQ();
            return (Wc)1;
        }

        if (uint_ != int_0) {
            return (Wc)0;
        }

        return (Wc)2;
    }

    protected void MJ(uint uint_0, uint uint_1, uint uint_2, uint uint_3, uint uint_4, bool bool_0, bool bool_1) {
        if (wDn != null) {
            wDn(uint_0, uint_1, uint_2, uint_3, uint_4, bool_0, bool_1);
        }
    }

    public void P7(uint uint_0, uint uint_1, Stream stream_0) {
        Stream[] stream_1 = new Stream[1]
        {
            stream_0
        };
        NP(uint_0, uint_1, stream_1);
    }

    public void NP(uint uint_0, uint uint_1, Stream[] stream_0) {
        s8();
        uint num = uint_1 - uint_0;
        uint num2 = num / 1024;
        uint num3 = num % 1024;
        uint num4 = num2;
        if (num3 != 0) {
            num4++;
        }

        ulong value = Class17.jp(((ulong)uint_0 << 32) + uint_1);
        if (lL(BitConverter.GetBytes((short)4), 1) != (Wc)2) {
            throw new Class73((Mo)8);
        }

        byte b = 0;
        if (lL(BitConverter.GetBytes(value), 8) != (Wc)2) {
            throw new Class73((Mo)8);
        }

        uint num5 = 0u;
        b = 0;
        bool flag = false;
        YI(bool_0: false);
        byte[] array = new byte[1024];
        while (num5 < num2 && !flag) {
            MJ(uint_0 + num5 * 1024, num5, num4, num5 * 1024, num, b == 0, bool_1: true);
            byte[] array2 = new byte[1];
            if (WF(array2, 1u) == (Wc)2) {
                byte b2 = array2[0];
                if (b2 == 176) {
                    for (int i = 0; i < 1024L; i++) {
                        array[i] = 0;
                    }
                } else {
                    switch (WF(array, 1024u)) {
                        case (Wc)0:
                            b++;
                            if (b < 3) {
                                continue;
                            }

                            lL(BitConverter.GetBytes((short)204), 1);
                            throw new Class73((Mo)11);
                        case (Wc)1:
                            lL(BitConverter.GetBytes((short)204), 1);
                            throw new Class73((Mo)9);
                    }
                }

                foreach (Stream stream in stream_0) {
                    stream.Write(array, 0, 1024);
                }

                b = 0;
                num5++;
                if (L0()) {
                    lL(BitConverter.GetBytes((short)204), 1);
                    flag = true;
                }

                continue;
            }

            lL(BitConverter.GetBytes((short)204), 1);
            throw new Class73((Mo)9);
        }

        while (!flag && num3 != 0) {
            MJ(uint_0 + num5 * 1024, num5, num4, num5 * 1024, num, b == 0, bool_1: true);
            byte[] array3 = new byte[1];
            if (WF(array3, 1u) == (Wc)2) {
                byte b3 = array3[0];
                if (b3 == 176) {
                    for (int k = 0; k < num3; k++) {
                        array[k] = 0;
                    }
                } else {
                    switch (WF(array, num3)) {
                        case (Wc)0:
                            b++;
                            if (b < 3) {
                                continue;
                            }

                            lL(BitConverter.GetBytes((short)204), 1);
                            throw new Class73((Mo)11);
                        case (Wc)1:
                            lL(BitConverter.GetBytes((short)204), 1);
                            throw new Class73((Mo)9);
                    }
                }

                foreach (Stream stream2 in stream_0) {
                    stream2.Write(array, 0, (int)num3);
                }

                b = 0;
                flag = true;
                continue;
            }

            lL(BitConverter.GetBytes((short)204), 1);
            throw new Class73((Mo)9);
        }

        MJ(uint_1, num4, num4, num, num, bool_0: true, bool_1: true);
    }

    public void Mi(uint uint_0, uint uint_1, Class52 cg_0) {
        s8();
        uint num = uint_1 - uint_0;
        uint num2 = num / 1024;
        uint num3 = num % 1024;
        uint num4 = num2;
        if (num3 != 0) {
            num4++;
        }

        ulong value = Class17.jp(((ulong)uint_0 << 32) + uint_1);
        if (lL(BitConverter.GetBytes((short)4), 1) != (Wc)2) {
            throw new Class73((Mo)8);
        }

        byte b = 0;
        if (lL(BitConverter.GetBytes(value), 8) != (Wc)2) {
            throw new Class73((Mo)8);
        }

        uint num5 = 0u;
        b = 0;
        bool flag = false;
        YI(bool_0: false);
        byte[] array = new byte[1024];
        while (num5 < num2 && !flag) {
            MJ(uint_0 + num5 * 1024, num5, num4, num5 * 1024, num, b == 0, bool_1: true);
            byte[] array2 = new byte[1];
            if (WF(array2, 1u) == (Wc)2) {
                byte b2 = array2[0];
                if (b2 == 176) {
                    for (int i = 0; i < 1024L; i++) {
                        array[i] = 0;
                    }
                } else {
                    switch (WF(array, 1024u)) {
                        case (Wc)0:
                            b++;
                            if (b < 3) {
                                continue;
                            }

                            lL(BitConverter.GetBytes((short)204), 1);
                            throw new Class73((Mo)11);
                        case (Wc)1:
                            lL(BitConverter.GetBytes((short)204), 1);
                            throw new Class73((Mo)9);
                    }
                }

                Buffer.BlockCopy(array, 0, cg_0.Uv, (int)(num5 * 1024 + (uint_0 - cg_0.GS())), 1024);
                cg_0.EG((num5 + 1) * 1024 + uint_0);
                b = 0;
                num5++;
                if (L0()) {
                    lL(BitConverter.GetBytes((short)204), 1);
                    flag = true;
                }

                continue;
            }

            lL(BitConverter.GetBytes((short)204), 1);
            throw new Class73((Mo)9);
        }

        while (!flag && num3 != 0) {
            MJ(uint_0 + num5 * 1024, num5, num4, num5 * 1024, num, b == 0, bool_1: true);
            byte[] array3 = new byte[1];
            if (WF(array3, 1u) == (Wc)2) {
                byte b3 = array3[0];
                if (b3 == 176) {
                    for (int j = 0; j < num3; j++) {
                        array[j] = 0;
                    }
                } else {
                    switch (WF(array, num3)) {
                        case (Wc)0:
                            b++;
                            if (b < 3) {
                                continue;
                            }

                            lL(BitConverter.GetBytes((short)204), 1);
                            throw new Class73((Mo)11);
                        case (Wc)1:
                            lL(BitConverter.GetBytes((short)204), 1);
                            throw new Class73((Mo)9);
                    }
                }

                Buffer.BlockCopy(array, 0, cg_0.Uv, (int)(num5 * 1024 + (uint_0 - cg_0.GS())), (int)num3);
                b = 0;
                flag = true;
                continue;
            }

            lL(BitConverter.GetBytes((short)204), 1);
            throw new Class73((Mo)9);
        }

        MJ(uint_1, num4, num4, num, num, bool_0: true, bool_1: true);
    }

    public void wm(uint uint_0, uint uint_1, Stream stream_0) {
        s8();
        uint num = uint_1 - uint_0;
        uint num2 = num / 1024;
        uint num3 = num % 1024;
        uint num4 = num2;
        if (num3 != 0) {
            num4++;
        }

        ulong value = Class17.jp(((ulong)uint_0 << 32) + uint_1);
        if (lL(BitConverter.GetBytes((short)65), 1) != (Wc)2) {
            throw new Class73((Mo)8);
        }

        byte b = 0;
        if (lL(BitConverter.GetBytes(value), 8) != (Wc)2) {
            throw new Class73((Mo)8);
        }

        uint num5 = 0u;
        b = 0;
        while (num5 < num2) {
            MJ(uint_0 + num5 * 1024, num5, num4, num5 * 1024, num, b == 0, bool_1: false);
            byte[] array = new byte[1024];
            stream_0.Read(array, 0, 1024);
            switch (lL(array, 1024)) {
                case (Wc)0:
                    b++;
                    if (b < 3) {
                        stream_0.Seek(-1024L, SeekOrigin.Current);
                        break;
                    }

                    aQ();
                    throw new Class73((Mo)11);
                default:
                    b = 0;
                    num5++;
                    break;
                case (Wc)1:
                    aQ();
                    throw new Class73((Mo)9);
            }
        }

        while (num3 != 0) {
            MJ(uint_0 + num5 * 1024, num5, num4, num5 * 1024, num, b == 0, bool_1: false);
            byte[] array = new byte[num3];
            stream_0.Read(array, 0, (int)num3);
            switch (lL(array, (int)num3)) {
                case (Wc)0:
                    b++;
                    if (b < 3) {
                        stream_0.Seek(-1 * (int)num3, SeekOrigin.Current);
                        break;
                    }

                    aQ();
                    throw new Class73((Mo)11);
                default:
                    b = 0;
                    num3 = 0u;
                    break;
                case (Wc)1:
                    aQ();
                    throw new Class73((Mo)9);
            }
        }

        byte[] array2 = new byte[1];
        if (WF(array2, 1u) != (Wc)2) {
            throw new Class73((Mo)9);
        }

        byte b2 = array2[0];
        if (b2 != 170) {
            throw new Class73((Mo)10);
        }

        MJ(uint_1, num4, num4, num, num, bool_0: true, bool_1: false);
    }

    static N1() {
        xDt = new byte[1]
        {
            130
        };
    }
}