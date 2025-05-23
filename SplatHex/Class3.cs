using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;

namespace SplatHex;
public sealed class Class3 : HashAlgorithm {
    public const uint YHB = 3988292384u;
    public const uint rHA = uint.MaxValue;
    private static uint[] JHf;
    private readonly uint cH6;
    private readonly uint[] bHx;
    private uint iH9;
    public Class3() : this(3988292384u, uint.MaxValue) {
    }

    public Class3(uint uint_0, uint uint_1) {
        bHx = TH1(uint_0);
        cH6 = (iH9 = uint_1);
    }

    public override void Initialize() {
        iH9 = cH6;
    }

    protected override void HashCore(byte[] array, int ibStart, int cbSize) {
        iH9 = EHW(bHx, iH9, array, ibStart, cbSize);
    }

    protected override byte[] HashFinal() {
        return HashValue = DHw(~iH9);
    }

    public static uint GHU(uint uint_0, object object_0) {
        return wHT(3988292384u, uint_0, object_0);
    }

    public static uint wHT(uint uint_0, uint uint_1, object object_0) {
        return ~EHW(TH1(uint_0), uint_1, (IList<byte>)object_0, 0, ((Array)object_0).Length);
    }

    private static uint[] TH1(uint uint_0) {
        if (uint_0 == 3988292384u && JHf != null) {
            return JHf;
        }

        uint[] array = new uint[256];
        for (int i = 0; i < 256; i++) {
            uint num = (uint)i;
            for (int j = 0; j < 8; j++) {
                num = (((num & 1) != 1) ? (num >> 1) : ((num >> 1) ^ uint_0));
            }

            array[i] = num;
        }

        if (uint_0 == 3988292384u) {
            JHf = array;
        }

        return array;
    }

    private static uint EHW(object object_0, uint uint_0, IList<byte> ilist_0, int int_0, int int_1) {
        uint num = uint_0;
        for (int i = int_0; i < int_0 + int_1; i++) {
            num = (num >> 8) ^ ((uint[])object_0)[ilist_0[i] ^ (num & 0xFF)];
        }

        return num;
    }

    private static byte[] DHw(uint uint_0) {
        byte[] bytes = BitConverter.GetBytes(uint_0);
        if (BitConverter.IsLittleEndian) {
            Array.Reverse(bytes);
        }

        return bytes;
    }

    public static byte[] WHN(string string_0) {
        return (
            from int_0 in Enumerable.Range(0, string_0.Length)
            where int_0 % 2 == 0
            select Convert.ToByte(string_0.Substring(int_0, 2), 16)).ToArray();
    }

    public static void DHY(string string_0, int int_0, int int_1, int int_2, bool bool_0) {
        try {
            FileStream fileStream = new FileStream(string_0, FileMode.Open);
            BinaryReader binaryReader = new BinaryReader(fileStream);
            binaryReader.BaseStream.Position = int_1;
            byte[] buffer = binaryReader.ReadBytes(Convert.ToInt32(int_2));
            Class3 g7l2 = new Class3();
            string text = string.Empty;
            byte[] array = g7l2.ComputeHash(buffer);
            foreach (byte b in array) {
                text += b.ToString("x2");
            }

            byte[] array2 = WHN(text);
            if (bool_0) {
                Array.Reverse(array2);
            }

            BinaryWriter binaryWriter = new BinaryWriter(fileStream);
            fileStream.Position = int_0;
            binaryWriter.Write(array2);
            binaryReader.Close();
        } catch {
            MessageBox.Show("Error !\nUnable to save the file !");
        }
    }
}