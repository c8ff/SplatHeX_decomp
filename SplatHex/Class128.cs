using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;

namespace SplatHex;
public class Class128 {
    private Class54 TDPO;
    private const uint PDPe = 1024u;
    private const uint zDP8 = 1024u;
    private const byte QDPn = 1;
    private const byte nDPQ = 2;
    private const byte ADPF = 3;
    private const byte bDPL = 4;
    private const byte IDPJ = 5;
    private const byte aDP7 = 6;
    private const byte VDPP = 11;
    private const byte RDPi = 12;
    private const byte TDPm = 65;
    private const byte WDP0 = 80;
    private const byte kDPI = 81;
    private const byte MDPR = 82;
    private const byte QDPC = 83;
    private const byte mDPK = 84;
    private const byte gDPU = 85;
    private const byte TDPT = 96;
    private const byte vDP1 = 112;
    private const byte uDPW = 113;
    private const byte ODPw = 114;
    private const byte CDPN = 128;
    private const byte mDPY = 153;
    private const byte RDPB = 154;
    private const byte gDPA = 17;
    private const byte EDPf = 170;
    private const byte WDP6 = 187;
    private const byte PDPx = 204;
    private const byte NDP9 = byte.MaxValue;
    private const byte dDPc = 176;
    private const byte uDPy = 189;
    private const byte UDPr = 128;
    private const byte SDPq = 129;
    private const byte VDPk = 130;
    private static readonly byte[] MDPM;
    [CompilerGenerated]
    private fBA yDPu;
    private bool qDPg;
    private bool jDP2;
    private int dDP3;
    [SpecialName]
    [CompilerGenerated]
    private void c(fBA fBA_0) {
        fBA fBA = yDPu;
        fBA fBA2;
        do {
            fBA2 = fBA;
            fBA value = (fBA)Delegate.Combine(fBA2, fBA_0);
            fBA = Interlocked.CompareExchange(ref yDPu, value, fBA2);
        }
        while ((object)fBA != fBA2);
    }

    [SpecialName]
    [CompilerGenerated]
    private void d(fBA fBA_0) {
        fBA fBA = yDPu;
        fBA fBA2;
        do {
            fBA2 = fBA;
            fBA value = (fBA)Delegate.Remove(fBA2, fBA_0);
            fBA = Interlocked.CompareExchange(ref yDPu, value, fBA2);
        }
        while ((object)fBA != fBA2);
    }

    [SpecialName]
    public void e(fBA fBA_0) {
        c(fBA_0);
    }

    [SpecialName]
    public void f(fBA fBA_0) {
        d(fBA_0);
    }

    [SpecialName]
    public bool h() {
        return qDPg;
    }

    [SpecialName]
    public bool i() {
        return jDP2;
    }

    [SpecialName]
    public void j(bool bool_0) {
        jDP2 = bool_0;
    }

    public Class128(string string_0, int int_0) {
        TDPO = new Class54(string_0, int_0);
        qDPg = false;
        yDPu = null;
    }

    public Class128() {
    }

    protected virtual void k() {
        try {
            if (qDPg) {
                ijJX();
            }
        } finally {
            base.Finalize();
        }
    }

    protected bool QD7r() {
        return true;
    }

    public virtual bool hjJp() {
        //IL_002f: Expected O, but got I4
        if (qDPg) {
            ijJX();
        }

        qDPg = false;
        try {
            TDPO.ED7R();
        } catch (IOException) {
            ijJX();
            throw new Class71((dB9)2);
        }

        Thread.Sleep(Class13.uDgd);
        qDPg = true;
        return true;
    }

    public virtual void ijJX() {
        qDPg = false;
        TDPO.dD7C();
    }

    protected SBd UD7q(byte[] byte_0, uint uint_0) {
        //IL_001c: Expected O, but got I4
        //IL_0028: Expected O, but got I4
        //IL_0026: Expected O, but got I4
        uint uint_1 = 0u;
        try {
            TDPO.CD7U(byte_0, uint_0, ref uint_1);
        } catch (IOException) {
            ijJX();
            return (SBd)1;
        }

        if (uint_1 == uint_0) {
            return (SBd)2;
        }

        return (SBd)0;
    }

    protected SBd HD7k(byte[] byte_0, int int_0) {
        //IL_001c: Expected O, but got I4
        //IL_002a: Expected O, but got I4
        //IL_0028: Expected O, but got I4
        uint uint_ = 0u;
        try {
            TDPO.rD7T(byte_0, int_0, ref uint_);
        } catch (IOException) {
            ijJX();
            return (SBd)1;
        }

        if (uint_ == int_0) {
            return (SBd)2;
        }

        return (SBd)0;
    }

    protected void WD7M(uint uint_0, uint uint_1, uint uint_2, uint uint_3, uint uint_4, bool bool_0, bool bool_1) {
        if (yDPu != null) {
            yDPu(uint_0, uint_1, uint_2, uint_3, uint_4, bool_0, bool_1);
        }
    }

    public void hD7u(uint uint_0, uint uint_1, Stream stream_0) {
        Stream[] stream_1 = new Stream[1]
        {
            stream_0
        };
        MjJO(uint_0, uint_1, stream_1);
    }

    public virtual void MjJO(uint uint_0, uint uint_1, Stream[] stream_0) {
        //IL_0077: Expected O, but got I4
        //IL_0092: Expected O, but got I4
        //IL_01c4: Expected O, but got I4
        //IL_02d6: Expected O, but got I4
        //IL_01fe: Expected O, but got I4
        //IL_01e1: Expected O, but got I4
        //IL_0310: Expected O, but got I4
        //IL_02f3: Expected O, but got I4
        QD7r();
        if (Class103.rDPZ(uint_0) != Class103.rDPZ(uint_1)) {
            uint_1 = Class103.cDip[Class103.rDPZ(uint_0)].method_3();
        }

        if (!Class103.xDPj(uint_0)) {
            return;
        }

        uint num = uint_1 - uint_0;
        uint num2 = num / (uint)Class13.SDgH;
        uint num3 = num % (uint)Class13.KDg4;
        uint num4 = num2;
        if (num3 != 0) {
            num4++;
        }

        ulong value = Class101.SD7A(((ulong)uint_0 << (int)Class13.aDg5) + uint_1);
        if ((nint)HD7k(BitConverter.GetBytes((short)4), 1) != 2) {
            throw new Class71((dB9)8);
        }

        byte b = 0;
        if ((nint)HD7k(BitConverter.GetBytes(value), 8) != 2) {
            throw new Class71((dB9)8);
        }

        uint num5 = 0u;
        b = 0;
        bool flag = false;
        this.j(bool_0: false);
        byte[] array = new byte[Class13.FDgs];
        while (num5 < num2 && !flag) {
            WD7M(uint_0 + (uint)((int)num5 * Class13.IDgZ), num5, num4, num5 * (uint)Class13.VDga, num, b == 0, bool_1: true);
            byte[] array2 = new byte[1];
            if ((nint)UD7q(array2, 1u) == 2) {
                if (array2[0] == Class13.UD2E) {
                    for (int i = 0; (long)i < (long)Class13.bD2D; i++) {
                        array[i] = 0;
                    }
                } else {
                    SBd sBd = UD7q(array, (uint)Class13.LD2X);
                    if ((object)sBd == null) {
                        b++;
                        if (b >= 3) {
                            HD7k(BitConverter.GetBytes((short)Class13.dD2p), 1);
                            throw new Class71((dB9)Class13.AD2S);
                        }

                        continue;
                    }

                    if ((nint)sBd == 1) {
                        HD7k(BitConverter.GetBytes((short)Class13.XD2h), 1);
                        throw new Class71((dB9)Class13.rD2l);
                    }
                }

                Stream[] array3 = stream_0;
                for (int j = 0; j < array3.Length; j++) {
                    array3[j].Write(array, 0, Class13.dD2G);
                }

                b = 0;
                num5++;
                if (this.i()) {
                    HD7k(BitConverter.GetBytes((short)Class13.VD2b), 1);
                    flag = true;
                }

                continue;
            }

            HD7k(BitConverter.GetBytes((short)Class13.VDgj), 1);
            throw new Class71((dB9)Class13.HDgz);
        }

        while (!flag && num3 != 0) {
            WD7M(uint_0 + (uint)((int)num5 * Class13.lD2v), num5, num4, num5 * (uint)Class13.RD2o, num, b == 0, bool_1: true);
            byte[] array4 = new byte[1];
            if ((nint)UD7q(array4, 1u) == 2) {
                if (array4[0] == Class13.xD2O) {
                    for (int k = 0; k < num3; k++) {
                        array[k] = 0;
                    }
                } else {
                    SBd sBd2 = UD7q(array, num3);
                    if ((object)sBd2 == null) {
                        b++;
                        if (b >= 3) {
                            HD7k(BitConverter.GetBytes((short)Class13.zD2e), 1);
                            throw new Class71((dB9)Class13.nD28);
                        }

                        continue;
                    }

                    if ((nint)sBd2 == 1) {
                        HD7k(BitConverter.GetBytes((short)Class13.DD2n), 1);
                        throw new Class71((dB9)Class13.iD2Q);
                    }
                }

                Stream[] array3 = stream_0;
                for (int j = 0; j < array3.Length; j++) {
                    array3[j].Write(array, 0, (int)num3);
                }

                b = 0;
                flag = true;
                continue;
            }

            HD7k(BitConverter.GetBytes((short)Class13.yD2t), 1);
            throw new Class71((dB9)Class13.mD2V);
        }

        WD7M(uint_1, num4, num4, num, num, bool_0: true, bool_1: true);
    }

    public SBd QD7g(byte byte_0) {
        return HD7k(BitConverter.GetBytes(byte_0), 1);
    }

    public void OD72() {
        QD7g((byte)Class13.UD2F);
    }

    public virtual void tjJs(uint uint_0, uint uint_1) {
        QjJU((uint)(uint_0 + dDP3), uint_1);
    }

    public virtual void QjJU(uint uint_0, uint uint_1) {
        //IL_002c: Expected O, but got I4
        //IL_0043: Expected O, but got I4
        uint_0 &= (uint)Class13.nD2L;
        ulong ulong_ = ((ulong)uint_0 << (int)Class13.cD2J) | uint_1;
        ulong_ = Class101.SD7A(ulong_);
        if ((nint)QD7g(3) != 2) {
            throw new Class71((dB9)8);
        }

        if ((nint)HD7k(BitConverter.GetBytes(ulong_), 8) != 2) {
            throw new Class71((dB9)8);
        }
    }

    public virtual void ojJW(uint uint_0, ushort ushort_0) {
        //IL_002c: Expected O, but got I4
        //IL_0043: Expected O, but got I4
        uint_0 &= (uint)Class13.TD27;
        ulong ulong_ = ((ulong)uint_0 << (int)Class13.sD2P) | ushort_0;
        ulong_ = Class101.SD7A(ulong_);
        if ((nint)QD7g(2) != 2) {
            throw new Class71((dB9)8);
        }

        if ((nint)HD7k(BitConverter.GetBytes(ulong_), 8) != 2) {
            throw new Class71((dB9)8);
        }
    }

    public virtual void NjJY(uint uint_0, byte byte_0) {
        //IL_0023: Expected O, but got I4
        //IL_003a: Expected O, but got I4
        ulong ulong_ = ((ulong)uint_0 << (int)Class13.MD2i) | byte_0;
        ulong_ = Class101.SD7A(ulong_);
        if ((nint)QD7g(1) != 2) {
            throw new Class71((dB9)8);
        }

        if ((nint)HD7k(BitConverter.GetBytes(ulong_), 8) != 2) {
            throw new Class71((dB9)8);
        }
    }

    public void CD73(uint uint_0, uint uint_1) {
        //IL_0027: Expected O, but got I4
        //IL_003e: Expected O, but got I4
        ulong ulong_ = ((ulong)uint_0 << (int)Class13.fD2m) | uint_1;
        ulong_ = Class101.SD7A(ulong_);
        if ((nint)QD7g((byte)Class13.JD20) != 2) {
            throw new Class71((dB9)8);
        }

        if ((nint)HD7k(BitConverter.GetBytes(ulong_), 8) != 2) {
            throw new Class71((dB9)8);
        }
    }

    public uint HD7d(uint uint_0) {
        //IL_001c: Expected O, but got I4
        //IL_0033: Expected O, but got I4
        //IL_004c: Expected O, but got I4
        uint_0 = Class101.BD7B(uint_0);
        if ((nint)QD7g((byte)Class13.zD2I) != 2) {
            throw new Class71((dB9)8);
        }

        if ((nint)HD7k(BitConverter.GetBytes(uint_0), 4) != 2) {
            throw new Class71((dB9)8);
        }

        byte[] array = new byte[4];
        if ((nint)UD7q(array, 4u) != 2) {
            throw new Class71((dB9)8);
        }

        return Class101.BD7B(BitConverter.ToUInt32(array, 0));
    }

    public virtual gBH LjJv() {
        //IL_0018: Expected O, but got I4
        //IL_002d: Expected O, but got I4
        //IL_004a: Expected O, but got I4
        //IL_0069: Expected O, but got I4
        //IL_006b: Expected O, but got I4
        //IL_006d: Expected O, but got I4
        //IL_006f: Expected O, but got I4
        //IL_0067: Expected O, but got I4
        Thread.Sleep(Class13.eD2R);
        if (!QD7r()) {
            throw new Class71((dB9)3);
        }

        if ((nint)QD7g((byte)Class13.KD2C) != 2) {
            throw new Class71((dB9)8);
        }

        byte[] array = new byte[1];
        if ((nint)UD7q(array, 1u) != 2) {
            throw new Class71((dB9)Class13.wD2K);
        }

        return array[0] switch {
            0 => (gBH)0,
            1 => (gBH)1,
            2 => (gBH)2,
            3 => (gBH)3,
            _ => (gBH)4,
        };
    }

    protected bool kD7H(byte byte_0) {
        int num = 0;
        while (true) {
            if (num < MDPM.Length) {
                if (MDPM[num] == byte_0) {
                    break;
                }

                num++;
                continue;
            }

            return false;
        }

        return true;
    }

    public byte sD74() {
        //IL_001b: Expected O, but got I4
        QD7r();
        if ((nint)QD7g((byte)Class13.JD2U) != 2) {
            throw new Class71((dB9)8);
        }

        byte b = 0;
        byte result = 0;
        byte[] array = new byte[1];
        do {
            if ((nint)UD7q(array, 1u) != 2 || !kD7H(array[0])) {
                b++;
                continue;
            }

            result = array[0];
            break;
        }
        while (b < 3);
        return result;
    }

    public uint qD75() {
        //IL_0014: Expected O, but got I4
        //IL_002d: Expected O, but got I4
        if ((nint)QD7g((byte)Class13.kD2T) != 2) {
            throw new Class71((dB9)8);
        }

        byte[] array = new byte[4];
        if ((nint)UD7q(array, 4u) != 2) {
            throw new Class71((dB9)8);
        }

        return Class101.BD7B(BitConverter.ToUInt32(array, 0));
    }

    public virtual uint cjJt(uint uint_0) {
        return NjJb((uint)(uint_0 + dDP3));
    }

    public virtual uint NjJb(uint uint_0) {
        if (Class103.xDPj(uint_0)) {
            uint num = uint_0 & (uint)Class13.LD21;
            MemoryStream memoryStream = new MemoryStream();
            fBA fBA = yDPu;
            yDPu = null;
            try {
                hD7u(num, num + 4, memoryStream);
                memoryStream.Seek(0L, SeekOrigin.Begin);
                byte[] array = new byte[4];
                memoryStream.Read(array, 0, 4);
                return Class101.BD7B(BitConverter.ToUInt32(array, 0));
            } finally {
                yDPu = fBA;
                memoryStream.Close();
            }
        }

        return 0u;
    }

    public virtual uint pjJd(string string_0) {
        return (uint)Class13.OD2W;
    }

    public virtual bool KjJB(uint uint_0, byte[] byte_0) {
        //IL_0014: Expected O, but got I4
        //IL_005d: Expected O, but got I4
        //IL_006f: Expected O, but got I4
        //IL_008c: Expected O, but got I4
        if ((nint)QD7g((byte)Class13.OD2w) != 2) {
            throw new Class71((dB9)8);
        }

        byte[] array = new byte[8];
        Array.Copy(BitConverter.GetBytes(Class101.BD7B(uint_0)), 0, array, 0, 4);
        Array.Copy(BitConverter.GetBytes(Class101.BD7B(uint_0 + (uint)byte_0.Length)), 0, array, 4, 4);
        int int_ = byte_0.Length;
        if ((nint)HD7k(array, 8) != 2) {
            throw new Class71((dB9)8);
        }

        if ((nint)HD7k(byte_0, int_) != 2) {
            throw new Class71((dB9)8);
        }

        byte[] array2 = new byte[1];
        if ((nint)UD7q(array2, 1u) != 2) {
            throw new Class71((dB9)Class13.bD2N);
        }

        return array2[0] == Class13.rD2Y;
    }

    public virtual uint JjJA(uint uint_0) {
        uint num = (uint)Class13.LD2B;
        int num2 = Class13.LD2A;
        if ((uint_0 & 3) == 1) {
            num = (uint)Class13.eD2f;
            num2 = Class13.LD26;
        } else if ((uint_0 & 3) == 2) {
            num = (uint)Class13.jD2x;
            num2 = 8;
        } else if ((uint_0 & 3) == 3) {
            num = (uint)Class13.iD29;
            num2 = 0;
        }

        return (cjJt(uint_0) & num) >> (num2 & Class13.sD2c);
    }

    public string sD7s(uint uint_0) {
        string text = Class13.hD2y;
        for (uint num = 0u; JjJA(uint_0 + num) != 0; num++) {
            text += (char)JjJA(uint_0 + num);
        }

        return text;
    }

    public string PD7Z(uint uint_0, uint uint_1) {
        string text = Class13.WD2r;
        for (uint num = 0u; num < uint_1; num++) {
            text += (char)JjJA(uint_0 + num);
        }

        return text;
    }

    public string vD7a(string string_0) {
        uint num = pjJd(string_0);
        if (num != uint.MaxValue) {
            return sD7s(num);
        }

        return null;
    }

    public void ND7j(uint uint_0, string string_0) {
        mD7z(uint_0, string_0, string_0.Length);
    }

    public void mD7z(uint uint_0, string string_0, int int_0) {
        byte[] array = new byte[int_0 * 2];
        for (int i = 0; i < string_0.Length; i++) {
            _ = string_0[i];
            array[2 * i] = (byte)((int)string_0[i] >> 8);
            array[2 * i + 1] = (byte)(string_0[i] & Class13.eD2q);
        }

        KjJB(uint_0, array);
    }

    public void JDPE(uint uint_0, string string_0) {
        mDPX(uint_0, string_0, string_0.Length);
    }

    public void hDPD(uint uint_0, byte[] byte_0) {
        KjJB(uint_0, byte_0);
    }

    public void mDPX(uint uint_0, string string_0, int int_0) {
        byte[] array = new byte[int_0];
        for (int i = 0; i < string_0.Length; i++) {
            array[i] = (byte)string_0[i];
        }

        KjJB(uint_0, array);
    }

    public void pDPp(uint uint_0, byte[] byte_0, int int_0) {
        byte[] array = new byte[int_0];
        Array.Copy(byte_0, 0, array, 0, byte_0.Length);
        KjJB(uint_0, array);
    }

    private void BDPS(int int_0) {
        dDP3 = int_0;
    }

    public uint rDPh(string string_0) {
        Class36 sBh = new Class36(string_0);
        uint num = sBh.GDQS();
        int[] array = sBh.EDQl();
        uint num2 = num;
        int[] array2 = array;
        int num3 = 0;
        while (true) {
            if (num3 < array2.Length) {
                uint num4 = (uint)array2[num3];
                num2 = NjJb(num2);
                if (num2 < (uint)Class13.yD2k || num2 > (uint)Class13.QD2M) {
                    break;
                }

                num2 += num4;
                num3++;
                continue;
            }

            return num2;
        }

        return uint.MaxValue;
    }

    public void KDPl(string string_0, uint uint_0) {
        uint num = pjJd(string_0);
        if (num != uint.MaxValue) {
            tjJs(num, uint_0);
        }
    }

    public void EDPG(string string_0, uint uint_0) {
        uint num = pjJd(string_0);
        if (num != uint.MaxValue) {
            QjJU(num, uint_0);
        }
    }

    public uint iDPb(string string_0) {
        uint num = pjJd(string_0);
        if (num == uint.MaxValue) {
            throw new InvalidOperationException();
        }

        return cjJt(num);
    }

    public uint aDPv(string string_0) {
        uint num = pjJd(string_0);
        if (num == uint.MaxValue) {
            throw new InvalidOperationException();
        }

        return NjJb(num);
    }

    public void vDPo(string string_0, byte byte_0) {
        uint num = pjJd(string_0);
        if (num != uint.MaxValue) {
            NjJY(num, byte_0);
        }
    }

    public void lDPt() {
        tjJs((uint)Class13.xD2u, (uint)Class13.SD2g);
    }

    public void zDPV() {
        tjJs((uint)Class13.gD22, (uint)Class13.dD23);
    }

    static Class128() {
        MDPM = new byte[1]
        {
            (byte)Class13.CD2d
        };
    }
}