using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;

namespace SplatHex;
internal static class Class65 {
    private static byte[] kDnA(Class48 mbr_0, int int_0) {
        uint[] array = new uint[64]
        {
            1198245351u,
            1994344998u,
            735515874u,
            1663443877u,
            3546822893u,
            1971520559u,
            850634446u,
            806453410u,
            1665636468u,
            2968449352u,
            1095037823u,
            1904139539u,
            2814389599u,
            3746782308u,
            404138500u,
            3286831528u,
            132567370u,
            4209403373u,
            3768887966u,
            2993812487u,
            3850160719u,
            3536584582u,
            866933786u,
            277249546u,
            1122251923u,
            2362165062u,
            511896764u,
            4259461788u,
            1386823229u,
            1635416216u,
            122889564u,
            3757170377u,
            823004983u,
            474720064u,
            2382539526u,
            3720250752u,
            3340007518u,
            186968955u,
            3868532527u,
            1921957761u,
            2701835199u,
            1207247951u,
            4184529370u,
            2340713165u,
            3997676891u,
            2716432768u,
            4077617114u,
            4246933217u,
            2079869454u,
            1884957436u,
            1720051361u,
            2561323552u,
            724594759u,
            1427637483u,
            406492603u,
            1160901608u,
            4257945430u,
            4030230578u,
            522693757u,
            1523586274u,
            1695081395u,
            4047338642u,
            3621406164u,
            2686293125u
        };
        uint[] array2 = new uint[64]
        {
            3754991922u,
            355981285u,
            3367040725u,
            1815215827u,
            3080790554u,
            2610807820u,
            1144083833u,
            4063879258u,
            2279922095u,
            1508858209u,
            4121898441u,
            3511819266u,
            1749045858u,
            2556741001u,
            2566256830u,
            210828836u,
            2604646442u,
            837090562u,
            3967056685u,
            1606533198u,
            2161555250u,
            851078327u,
            2518308483u,
            855789720u,
            3580323721u,
            2875337306u,
            4132567354u,
            319647080u,
            4026456648u,
            618840787u,
            3934897629u,
            4031445592u,
            1987918361u,
            3211245704u,
            1411485440u,
            1866865407u,
            2585882167u,
            1482795728u,
            994365102u,
            3446446658u,
            101772498u,
            713641846u,
            601304041u,
            1677340051u,
            719096336u,
            4212039530u,
            1004588689u,
            2159776673u,
            3683487731u,
            1927421383u,
            2477835888u,
            688375105u,
            1035934829u,
            1658360399u,
            839246703u,
            68961493u,
            3670746256u,
            30999977u,
            1821136795u,
            3821358530u,
            4099422216u,
            1984271496u,
            509574241u,
            678884192u
        };
        uint[] array3 = new uint[64]
        {
            3754991922u,
            355981285u,
            3367040725u,
            1815215827u,
            3080790554u,
            2610807820u,
            1144083833u,
            4063879258u,
            2279922095u,
            1508858209u,
            4121898441u,
            3511819266u,
            1749045858u,
            2556741001u,
            2566256830u,
            210828836u,
            2604646442u,
            837090562u,
            3967056685u,
            1606533198u,
            2161555250u,
            851078327u,
            2518308483u,
            855789720u,
            3580323721u,
            2875337306u,
            4132567354u,
            319647080u,
            4026456648u,
            618840787u,
            3934897629u,
            4031445592u,
            1987918361u,
            3211245704u,
            1411485440u,
            1866865407u,
            2585882167u,
            1482795728u,
            994365102u,
            3446446658u,
            101772498u,
            713641846u,
            601304041u,
            1677340051u,
            719096336u,
            4212039530u,
            1004588689u,
            2159776673u,
            3683487731u,
            1927421383u,
            2477835888u,
            688375105u,
            1035934829u,
            1658360399u,
            839246703u,
            68961493u,
            3670746256u,
            30999977u,
            1821136795u,
            3821358530u,
            4099422216u,
            1984271496u,
            509574241u,
            678884192u
        };
        uint[] array4 = new uint[64]
        {
            644289958u,
            2312185744u,
            1781510424u,
            2015159370u,
            1724384458u,
            1713717796u,
            1905629321u,
            3996392517u,
            3372006173u,
            2223305796u,
            1493722509u,
            395349213u,
            983169377u,
            2568752290u,
            2200057345u,
            273134812u,
            3856667972u,
            2631953478u,
            249615333u,
            590112689u,
            3330481317u,
            1503582831u,
            1374246210u,
            297312545u,
            3472945543u,
            1625425834u,
            2075790769u,
            2950634062u,
            1738230523u,
            389336821u,
            3158875687u,
            3943886474u,
            1449373057u,
            3885073118u,
            533758381u,
            1674205795u,
            680459326u,
            1130499203u,
            3626250411u,
            3909906574u,
            3057389213u,
            3848866509u,
            473030563u,
            2519946411u,
            3224234006u,
            1841278396u,
            4292979567u,
            4084936244u,
            1555629333u,
            3439038835u,
            1051976016u,
            345203260u,
            2157337622u,
            2432054654u,
            837746513u,
            3202611666u,
            2359784692u,
            2916875739u,
            3951659846u,
            1241895564u,
            4256305132u,
            2415198372u,
            679573927u,
            1282695049u
        };
        byte[] array5 = new byte[16];
        uint[] array6;
        if (int_0 < 7) {
            if (int_0 < 4) {
                array6 = ((int_0 < 2) ? array : array2);
            } else {
                if (array2[0] == array3[0]) {
                    Class48 mBr = new Class48(2989015228u, 2430523333u, 3283585288u, 4291357111u);
                    for (int i = 0; i < 64; i++) {
                        array3[i] = mBr.kDnN();
                    }
                }

                array6 = array3;
            }
        } else {
            Class48 mBr2 = new Class48(1367784952u, 2468841429u, 2244794920u, 1114245486u);
            for (int j = 0; j < 64; j++) {
                array4[j] = mBr2.kDnN();
            }

            array6 = array4;
        }

        uint num = 0u;
        do {
            array5[num] = 0;
            for (int k = 0; k < 4; k++) {
                uint num2 = array6[mbr_0.kDnN() >> 26];
                int num3 = (int)((mbr_0.kDnN() >> 27) & 0x18);
                uint num4 = num2 >> num3;
                array5[num + 3 - k] = (byte)(num4 & 0xFF);
            }

            num += 4;
        }
        while (num != 16);
        return array5;
    }

    private static uint sDnf(object object_0, int int_0) {
        return (uint)((((byte[])object_0)[int_0 + 3] << 24) | (((byte[])object_0)[int_0 + 2] << 16) | (((byte[])object_0)[int_0 + 1] << 8) | ((byte[])object_0)[int_0]);
    }

    private static uint dDn6(uint uint_0) {
        uint_0 = ((uint_0 << 1) & 0xAAAAAAAAu) | ((uint_0 >> 1) & 0x55555555);
        uint_0 = ((uint_0 << 2) & 0xCCCCCCCCu) | ((uint_0 >> 2) & 0x33333333);
        uint_0 = ((uint_0 << 4) & 0xF0F0F0F0u) | ((uint_0 >> 4) & 0xF0F0F0F);
        uint_0 = ((uint_0 << 8) & 0xFF00FF00u) | ((uint_0 >> 8) & 0xFF00FF);
        uint_0 = ((uint_0 << 16) & 0xFFFF0000u) | ((uint_0 >> 16) & 0xFFFF);
        return uint_0;
    }

    private static List<Tuple<uint, uint>> YDnx(uint uint_0, uint uint_1, bool bool_0 = false) {
        Class48 mBr = new Class48(uint_0);
        uint num = 0u;
        uint num2 = uint_1 >> 3;
        uint num3 = uint_1 >> 4;
        if (bool_0) {
            num2 &= 0xFFFFFFF0u;
            num3 &= 0xFFFFFFF0u;
        }

        List<Tuple<uint, uint>> list = new List<Tuple<uint, uint>>();
        while (num < uint_1) {
            if (num + num2 > uint_1) {
                num2 = uint_1 - num;
            }

            long num4 = mBr.kDnN();
            long num5 = num2 - num3;
            long num6 = num4 * num5 + num4;
            uint num7 = (uint)((num6 >> 32) + num3);
            if (bool_0) {
                num7 &= 0xFFFFFFF0u;
            }

            if (num + num7 > uint_1) {
                num7 = uint_1 - num;
            }

            list.Add(Tuple.Create(num, num7));
            num += num7;
            if (num != uint_1 && uint_1 - num < num3) {
                list.Add(Tuple.Create(num, uint_1 - num));
                num += uint_1;
            }
        }

        if (list.Count >= 2) {
            for (uint num8 = (uint)list.Count; num8 > 1; num8--) {
                long num9 = (long)mBr.kDnN() * (long)num8;
                uint index = (uint)(num9 >> 32);
                Tuple<uint, uint> value = list[(int)(num8 - 1)];
                list[(int)(num8 - 1)] = list[(int)index];
                list[(int)index] = value;
            }
        }

        return list;
    }

    private static byte[] BDn9(uint uint_0, Array array_0) {
        List<Tuple<uint, uint>> list = YDnx(uint_0, (uint)array_0.Length);
        byte[] array = new byte[array_0.Length];
        uint num = 0u;
        foreach (Tuple<uint, uint> item in list) {
            Array.Copy(array_0, num, array, item.Item1, item.Item2);
            num += item.Item2;
        }

        return array;
    }

    private static byte[] NDnc(uint uint_0, Array array_0) {
        List<Tuple<uint, uint>> list = YDnx(uint_0, (uint)array_0.Length, bool_0: true);
        byte[] array = new byte[array_0.Length];
        uint num = 0u;
        foreach (Tuple<uint, uint> item in list) {
            Class48 mBr = new Class48(item.Item2);
            byte[] bytes = BitConverter.GetBytes(mBr.IDnY());
            byte[] bytes2 = BitConverter.GetBytes(mBr.IDnY());
            byte[] byte_ = kDnA(mBr, 8);
            byte[] array2 = new byte[16];
            for (int i = 0; i < 8; i++) {
                array2[i] = bytes[i];
                array2[i + 8] = bytes2[i];
            }

            byte[] array3 = new byte[item.Item2];
            Array.Copy(array_0, num, array3, 0L, item.Item2);
            byte[] sourceArray = KDnq(byte_, array2, array3);
            Array.Copy(sourceArray, 0L, array, item.Item1, item.Item2);
            num += item.Item2;
        }

        return array;
    }

    private static byte[] uDny(uint uint_0, Array array_0) {
        List<Tuple<uint, uint>> list = YDnx(uint_0, (uint)array_0.Length, bool_0: true);
        byte[] array = new byte[array_0.Length];
        uint num = 0u;
        foreach (Tuple<uint, uint> item in list) {
            Class48 mBr = new Class48(item.Item2);
            byte[] bytes = BitConverter.GetBytes(mBr.IDnY());
            byte[] bytes2 = BitConverter.GetBytes(mBr.IDnY());
            byte[] byte_ = kDnA(mBr, 8);
            byte[] array2 = new byte[16];
            for (int i = 0; i < 8; i++) {
                array2[i] = bytes[i];
                array2[i + 8] = bytes2[i];
            }

            byte[] array3 = new byte[item.Item2];
            Array.Copy(array_0, item.Item1, array3, 0L, item.Item2);
            byte[] sourceArray = kDnk(byte_, array2, array3);
            Array.Copy(sourceArray, 0L, array, num, item.Item2);
            num += item.Item2;
        }

        return array;
    }

    private static byte[] fDnr(uint uint_0, Array array_0) {
        List<Tuple<uint, uint>> list = YDnx(uint_0, (uint)array_0.Length);
        byte[] array = new byte[array_0.Length];
        uint num = 0u;
        foreach (Tuple<uint, uint> item in list) {
            Array.Copy(array_0, item.Item1, array, num, item.Item2);
            num += item.Item2;
        }

        return array;
    }

    private static byte[] KDnq(byte[] byte_0, byte[] byte_1, byte[] byte_2) {
        using Aes aes = Aes.Create();
        aes.Key = byte_0;
        aes.IV = byte_1;
        aes.Padding = PaddingMode.None;
        aes.Mode = CipherMode.CBC;
        using MemoryStream stream = new MemoryStream(byte_2);
        aes.CreateDecryptor(aes.Key, aes.IV);
        using CryptoStream stream2 = new CryptoStream(stream, aes.CreateDecryptor(aes.Key, aes.IV), CryptoStreamMode.Read);
        using StreamReader streamReader = new StreamReader(stream2);
        using MemoryStream memoryStream = new MemoryStream();
        streamReader.BaseStream.CopyTo(memoryStream);
        return memoryStream.ToArray();
    }

    private static byte[] kDnk(byte[] byte_0, byte[] byte_1, byte[] byte_2) {
        using MemoryStream memoryStream = new MemoryStream();
        AesCryptoServiceProvider aesCryptoServiceProvider = new AesCryptoServiceProvider();
        aesCryptoServiceProvider.Mode = CipherMode.CBC;
        aesCryptoServiceProvider.Padding = PaddingMode.None;
        using CryptoStream cryptoStream = new CryptoStream(memoryStream, aesCryptoServiceProvider.CreateEncryptor(byte_0, byte_1), CryptoStreamMode.Write);
        cryptoStream.Write(byte_2, 0, byte_2.Length);
        cryptoStream.FlushFinalBlock();
        return memoryStream.ToArray();
    }

    private static byte[] qDnM(object object_0) {
        byte[] array = new byte[((Array)object_0).Length];
        byte b = 0;
        for (int num = ((Array)object_0).Length - 1; num >= 0; num--) {
            ushort num2 = (ushort)(((byte[])object_0)[num] << 1);
            array[num] = (byte)((num2 & 0xFF) + b);
            b = (byte)((num2 & 0xFF00) >> 8);
        }

        return array;
    }

    private static byte[] FDnu(byte[] byte_0, byte[] byte_1) {
        byte[] array = kDnk(byte_0, new byte[16], new byte[16]);
        byte[] array2 = qDnM(array);
        if ((array[0] & 0x80) == 128) {
            array2[15] ^= 135;
        }

        byte[] array3 = qDnM(array2);
        if ((array2[0] & 0x80) == 128) {
            array3[15] ^= 135;
        }

        if (byte_1.Length != 0 && byte_1.Length % 16 == 0) {
            for (int i = 0; i < array2.Length; i++) {
                byte_1[byte_1.Length - 16 + i] ^= array2[i];
            }
        } else {
            byte[] array4 = new byte[16 - byte_1.Length % 16];
            array4[0] = 128;
            byte_1 = byte_1.Concat(array4.AsEnumerable()).ToArray();
            for (int j = 0; j < array3.Length; j++) {
                byte_1[byte_1.Length - 16 + j] ^= array3[j];
            }
        }

        byte[] array5 = kDnk(byte_0, new byte[16], byte_1);
        byte[] array6 = new byte[16];
        Array.Copy(array5, array5.Length - array6.Length, array6, 0, array6.Length);
        return array6;
    }

    public static byte[] uDng(object object_0) {
        int num = ((byte[])object_0)[0];
        int num2 = 16;
        int[] array = new int[9]
        {
            295840,
            295840,
            550912,
            560464,
            560464,
            560464,
            560464,
            560464,
            560464
        };
        int num3 = array[num];
        byte[] array2 = new byte[num3];
        byte[] array3 = new byte[num3 + 16];
        byte[] array4 = new byte[num3];
        byte[] array5 = new byte[16];
        byte[] array6 = new byte[16];
        uint num4 = sDnf(object_0, 8);
        uint uint_ = sDnf(object_0, num3 + 32);
        uint uint_2 = sDnf(object_0, num3 + 36);
        uint uint_3 = sDnf(object_0, num3 + 40);
        uint uint_4 = sDnf(object_0, num3 + 44);
        Class48 mbr_ = new Class48(uint_, uint_2, uint_3, uint_4);
        for (int i = 0; i < num3; i++) {
            array2[i] = ((byte[])object_0)[num2 + i];
        }

        for (int j = 0; j < 16; j++) {
            array5[j] = ((byte[])object_0)[num2 + num3 + j];
            array6[j] = ((byte[])object_0)[num2 + num3 + 32 + j];
            array3[j] = ((byte[])object_0)[j];
        }

        byte[] byte_ = kDnA(mbr_, num);
        if (num == 4 || num == 7) {
            array2 = BDn9(num4, array2);
        }

        if (num == 8) {
            array2 = NDnc(dDn6(num4), array2);
        }

        byte[] array7 = KDnq(byte_, array5, array2);
        if (num == 7) {
            array7 = BDn9(num4, array7);
        }

        if (num == 8) {
            array7 = NDnc(dDn6(~num4), array7);
        }

        for (int k = 0; k < num3 && k < array7.Length; k++) {
            array3[k + num2] = array7[k];
            array4[k] = array7[k];
        }

        byte[] byte_2 = kDnA(mbr_, num);
        byte[] array8 = FDnu(byte_2, array4);
        for (int l = 0; l < array8.Length; l++) {
            if (array8[l] != array6[l]) {
                throw new Exception("Invalid HMAC");
            }
        }

        return array3;
    }

    public static byte[] IDn2(object object_0) {
        int num = ((byte[])object_0)[0];
        int num2 = 16;
        int[] array = new int[9]
        {
            295840,
            295840,
            550912,
            560464,
            560464,
            560464,
            560464,
            560464,
            560464
        };
        int num3 = array[num];
        byte[] array2 = new byte[num3 + 16 + 48];
        byte[] array3 = new byte[num3];
        byte[] array4 = new byte[num3];
        byte[] array5 = new byte[16];
        Random random = new Random();
        uint num4 = (uint)random.Next();
        uint num5 = (uint)random.Next();
        uint num6 = (uint)random.Next();
        uint num7 = (uint)random.Next();
        Class48 mbr_ = new Class48(num4, num5, num6, num7);
        for (int i = 0; i < num3; i++) {
            array3[i] = ((byte[])object_0)[num2 + i];
        }

        for (int j = 0; j < 16; j++) {
            array5[j] = (byte)(random.Next() & 0xFF);
            array2[j] = ((byte[])object_0)[j];
        }

        uint num8 = xDn3(array3);
        array2[8] = (byte)(num8 & 0xFF);
        array2[9] = (byte)((num8 >> 8) & 0xFF);
        array2[10] = (byte)((num8 >> 16) & 0xFF);
        array2[11] = (byte)((num8 >> 24) & 0xFF);
        byte[] key = kDnA(mbr_, num);
        byte[] array6 = new byte[num3];
        Array.Copy(array3, 0, array6, 0, num3);
        if (num == 7) {
            array6 = fDnr(num8, array6);
        }

        if (num == 8) {
            array6 = uDny(dDn6(~num8), array6);
        }

        byte[] array7;
        using (Aes aes = Aes.Create()) {
            aes.Key = key;
            aes.IV = array5;
            aes.Padding = PaddingMode.None;
            aes.Mode = CipherMode.CBC;
            ICryptoTransform transform = aes.CreateEncryptor(aes.Key, aes.IV);
            using MemoryStream stream = new MemoryStream(array6);
            using CryptoStream stream2 = new CryptoStream(stream, transform, CryptoStreamMode.Read);
            using StreamReader streamReader = new StreamReader(stream2);
            using MemoryStream memoryStream = new MemoryStream();
            streamReader.BaseStream.CopyTo(memoryStream);
            array7 = memoryStream.ToArray();
        }

        if (num == 8) {
            array7 = uDny(dDn6(num8), array7);
        }

        for (int k = 0; k < num3 && k < array7.Length; k++) {
            array2[k + num2] = array7[k];
            array4[k] = array3[k];
        }

        byte[] byte_ = kDnA(mbr_, num);
        byte[] array8 = FDnu(byte_, array4);
        for (int l = 0; l < 16; l++) {
            array2[l + num2 + num3] = array5[l];
            array2[l + num2 + num3 + 32] = array8[l];
        }

        if (num == 4 || num == 7) {
            byte[] array9 = new byte[num3];
            Array.Copy(array2, 16, array9, 0, num3);
            array9 = fDnr(num8, array9);
            Array.Copy(array9, 0, array2, 16, num3);
        }

        array2[num2 + num3 + 16] = (byte)(num4 & 0xFF);
        array2[num2 + num3 + 17] = (byte)((num4 >> 8) & 0xFF);
        array2[num2 + num3 + 18] = (byte)((num4 >> 16) & 0xFF);
        array2[num2 + num3 + 19] = (byte)((num4 >> 24) & 0xFF);
        array2[num2 + num3 + 20] = (byte)(num5 & 0xFF);
        array2[num2 + num3 + 21] = (byte)((num5 >> 8) & 0xFF);
        array2[num2 + num3 + 22] = (byte)((num5 >> 16) & 0xFF);
        array2[num2 + num3 + 23] = (byte)((num5 >> 24) & 0xFF);
        array2[num2 + num3 + 24] = (byte)(num6 & 0xFF);
        array2[num2 + num3 + 25] = (byte)((num6 >> 8) & 0xFF);
        array2[num2 + num3 + 26] = (byte)((num6 >> 16) & 0xFF);
        array2[num2 + num3 + 27] = (byte)((num6 >> 24) & 0xFF);
        array2[num2 + num3 + 28] = (byte)(num7 & 0xFF);
        array2[num2 + num3 + 29] = (byte)((num7 >> 8) & 0xFF);
        array2[num2 + num3 + 30] = (byte)((num7 >> 16) & 0xFF);
        array2[num2 + num3 + 31] = (byte)((num7 >> 24) & 0xFF);
        return array2;
    }

    private static uint xDn3(object object_0) {
        uint[] array = new uint[256]
        {
            0u,
            1996959894u,
            3993919788u,
            2567524794u,
            124634137u,
            1886057615u,
            3915621685u,
            2657392035u,
            249268274u,
            2044508324u,
            3772115230u,
            2547177864u,
            162941995u,
            2125561021u,
            3887607047u,
            2428444049u,
            498536548u,
            1789927666u,
            4089016648u,
            2227061214u,
            450548861u,
            1843258603u,
            4107580753u,
            2211677639u,
            325883990u,
            1684777152u,
            4251122042u,
            2321926636u,
            335633487u,
            1661365465u,
            4195302755u,
            2366115317u,
            997073096u,
            1281953886u,
            3579855332u,
            2724688242u,
            1006888145u,
            1258607687u,
            3524101629u,
            2768942443u,
            901097722u,
            1119000684u,
            3686517206u,
            2898065728u,
            853044451u,
            1172266101u,
            3705015759u,
            2882616665u,
            651767980u,
            1373503546u,
            3369554304u,
            3218104598u,
            565507253u,
            1454621731u,
            3485111705u,
            3099436303u,
            671266974u,
            1594198024u,
            3322730930u,
            2970347812u,
            795835527u,
            1483230225u,
            3244367275u,
            3060149565u,
            1994146192u,
            31158534u,
            2563907772u,
            4023717930u,
            1907459465u,
            112637215u,
            2680153253u,
            3904427059u,
            2013776290u,
            251722036u,
            2517215374u,
            3775830040u,
            2137656763u,
            141376813u,
            2439277719u,
            3865271297u,
            1802195444u,
            476864866u,
            2238001368u,
            4066508878u,
            1812370925u,
            453092731u,
            2181625025u,
            4111451223u,
            1706088902u,
            314042704u,
            2344532202u,
            4240017532u,
            1658658271u,
            366619977u,
            2362670323u,
            4224994405u,
            1303535960u,
            984961486u,
            2747007092u,
            3569037538u,
            1256170817u,
            1037604311u,
            2765210733u,
            3554079995u,
            1131014506u,
            879679996u,
            2909243462u,
            3663771856u,
            1141124467u,
            855842277u,
            2852801631u,
            3708648649u,
            1342533948u,
            654459306u,
            3188396048u,
            3373015174u,
            1466479909u,
            544179635u,
            3110523913u,
            3462522015u,
            1591671054u,
            702138776u,
            2966460450u,
            3352799412u,
            1504918807u,
            783551873u,
            3082640443u,
            3233442989u,
            3988292384u,
            2596254646u,
            62317068u,
            1957810842u,
            3939845945u,
            2647816111u,
            81470997u,
            1943803523u,
            3814918930u,
            2489596804u,
            225274430u,
            2053790376u,
            3826175755u,
            2466906013u,
            167816743u,
            2097651377u,
            4027552580u,
            2265490386u,
            503444072u,
            1762050814u,
            4150417245u,
            2154129355u,
            426522225u,
            1852507879u,
            4275313526u,
            2312317920u,
            282753626u,
            1742555852u,
            4189708143u,
            2394877945u,
            397917763u,
            1622183637u,
            3604390888u,
            2714866558u,
            953729732u,
            1340076626u,
            3518719985u,
            2797360999u,
            1068828381u,
            1219638859u,
            3624741850u,
            2936675148u,
            906185462u,
            1090812512u,
            3747672003u,
            2825379669u,
            829329135u,
            1181335161u,
            3412177804u,
            3160834842u,
            628085408u,
            1382605366u,
            3423369109u,
            3138078467u,
            570562233u,
            1426400815u,
            3317316542u,
            2998733608u,
            733239954u,
            1555261956u,
            3268935591u,
            3050360625u,
            752459403u,
            1541320221u,
            2607071920u,
            3965973030u,
            1969922972u,
            40735498u,
            2617837225u,
            3943577151u,
            1913087877u,
            83908371u,
            2512341634u,
            3803740692u,
            2075208622u,
            213261112u,
            2463272603u,
            3855990285u,
            2094854071u,
            198958881u,
            2262029012u,
            4057260610u,
            1759359992u,
            534414190u,
            2176718541u,
            4139329115u,
            1873836001u,
            414664567u,
            2282248934u,
            4279200368u,
            1711684554u,
            285281116u,
            2405801727u,
            4167216745u,
            1634467795u,
            376229701u,
            2685067896u,
            3608007406u,
            1308918612u,
            956543938u,
            2808555105u,
            3495958263u,
            1231636301u,
            1047427035u,
            2932959818u,
            3654703836u,
            1088359270u,
            936918000u,
            2847714899u,
            3736837829u,
            1202900863u,
            817233897u,
            3183342108u,
            3401237130u,
            1404277552u,
            615818150u,
            3134207493u,
            3453421203u,
            1423857449u,
            601450431u,
            3009837614u,
            3294710456u,
            1567103746u,
            711928724u,
            3020668471u,
            3272380065u,
            1510334235u,
            755167117u
        };
        uint num = uint.MaxValue;
        int num2 = ((Array)object_0).Length;
        for (int i = 0; i < num2; i++) {
            num = (num >> 8) ^ array[(num ^ ((byte[])object_0)[i]) & 0xFF];
        }

        return (uint)(num ^ -1L);
    }
}