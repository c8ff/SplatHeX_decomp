using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;

namespace SplatHex;
internal class Class89 {
    internal class bYr : Attribute {
        internal class JY7<T> {
        }

        // The fuck is this
        [bYr(typeof(BOz_002FbYr_002FJY7<object>[]))]
        public bYr(object object_0) {
        }
    }

    [Flags]
    private enum qYB {
    }

    private static bool RSTe;
    private static byte[] ySTQ;
    private static IntPtr MSTL;
    private static IntPtr cSTJ;
    private static int[] nSTP;
    private static int jSTi;
    private static int JST0;
    private static byte[] bSTF;
    private static bool OSTI;
    private static long bSTm;
    private static byte[] BST8;
    private static byte[] BSTn;
    private static bool VSTO;
    private static string[] vST7;
    private static uint[] NSTV;
    static Class89() {
        NSTV = new uint[64]
        {
            3614090360u,
            3905402710u,
            606105819u,
            3250441966u,
            4118548399u,
            1200080426u,
            2821735955u,
            4249261313u,
            1770035416u,
            2336552879u,
            4294925233u,
            2304563134u,
            1804603682u,
            4254626195u,
            2792965006u,
            1236535329u,
            4129170786u,
            3225465664u,
            643717713u,
            3921069994u,
            3593408605u,
            38016083u,
            3634488961u,
            3889429448u,
            568446438u,
            3275163606u,
            4107603335u,
            1163531501u,
            2850285829u,
            4243563512u,
            1735328473u,
            2368359562u,
            4294588738u,
            2272392833u,
            1839030562u,
            4259657740u,
            2763975236u,
            1272893353u,
            4139469664u,
            3200236656u,
            681279174u,
            3936430074u,
            3572445317u,
            76029189u,
            3654602809u,
            3873151461u,
            530742520u,
            3299628645u,
            4096336452u,
            1126891415u,
            2878612391u,
            4237533241u,
            1700485571u,
            2399980690u,
            4293915773u,
            2240044497u,
            1873313359u,
            4264355552u,
            2734768916u,
            1309151649u,
            4149444226u,
            3174756917u,
            718787259u,
            3951481745u
        };
        VSTO = false;
        RSTe = false;
        BST8 = new byte[0];
        BSTn = new byte[0];
        ySTQ = new byte[0];
        bSTF = new byte[0];
        MSTL = IntPtr.Zero;
        cSTJ = IntPtr.Zero;
        vST7 = new string[0];
        nSTP = new int[0];
        jSTi = 1;
        bSTm = 0L;
        JST0 = 0;
        OSTI = false;
    }

    private void method_0() {
    }

    internal static byte[] LSUY(object object_0) {
        uint[] array = new uint[16];
        int num = 448 - ((Array)object_0).Length * 8 % 512;
        uint num2 = (uint)((num + 512) % 512);
        if (num2 == 0) {
            num2 = 512u;
        }

        uint num3 = (uint)(((Array)object_0).Length + num2 / 8 + 8L);
        ulong num4 = (ulong)(((Array)object_0).Length * 8L);
        byte[] array2 = new byte[num3];
        for (int i = 0; i < ((Array)object_0).Length; i++) {
            array2[i] = ((byte[])object_0)[i];
        }

        array2[((Array)object_0).Length] |= 128;
        for (int num5 = 8; num5 > 0; num5--) {
            array2[num3 - num5] = (byte)((num4 >> (8 - num5) * 8) & 0xFFL);
        }

        uint num6 = (uint)(array2.Length * 8) / 32u;
        uint uint_ = 1732584193u;
        uint uint_2 = 4023233417u;
        uint uint_3 = 2562383102u;
        uint uint_4 = 271733878u;
        for (uint num7 = 0u; num7 < num6 / 16; num7++) {
            uint num8 = num7 << 6;
            for (uint num9 = 0u; num9 < 61; num9 += 4) {
                array[num9 >> 2] = (uint)((array2[num8 + (num9 + 3)] << 24) | (array2[num8 + (num9 + 2)] << 16) | (array2[num8 + (num9 + 1)] << 8) | array2[num8 + num9]);
            }

            uint num10 = uint_;
            uint num11 = uint_2;
            uint num12 = uint_3;
            uint num13 = uint_4;
            lSUB(ref uint_, uint_2, uint_3, uint_4, 0u, 7, 1u, array);
            lSUB(ref uint_4, uint_, uint_2, uint_3, 1u, 12, 2u, array);
            lSUB(ref uint_3, uint_4, uint_, uint_2, 2u, 17, 3u, array);
            lSUB(ref uint_2, uint_3, uint_4, uint_, 3u, 22, 4u, array);
            lSUB(ref uint_, uint_2, uint_3, uint_4, 4u, 7, 5u, array);
            lSUB(ref uint_4, uint_, uint_2, uint_3, 5u, 12, 6u, array);
            lSUB(ref uint_3, uint_4, uint_, uint_2, 6u, 17, 7u, array);
            lSUB(ref uint_2, uint_3, uint_4, uint_, 7u, 22, 8u, array);
            lSUB(ref uint_, uint_2, uint_3, uint_4, 8u, 7, 9u, array);
            lSUB(ref uint_4, uint_, uint_2, uint_3, 9u, 12, 10u, array);
            lSUB(ref uint_3, uint_4, uint_, uint_2, 10u, 17, 11u, array);
            lSUB(ref uint_2, uint_3, uint_4, uint_, 11u, 22, 12u, array);
            lSUB(ref uint_, uint_2, uint_3, uint_4, 12u, 7, 13u, array);
            lSUB(ref uint_4, uint_, uint_2, uint_3, 13u, 12, 14u, array);
            lSUB(ref uint_3, uint_4, uint_, uint_2, 14u, 17, 15u, array);
            lSUB(ref uint_2, uint_3, uint_4, uint_, 15u, 22, 16u, array);
            xSUA(ref uint_, uint_2, uint_3, uint_4, 1u, 5, 17u, array);
            xSUA(ref uint_4, uint_, uint_2, uint_3, 6u, 9, 18u, array);
            xSUA(ref uint_3, uint_4, uint_, uint_2, 11u, 14, 19u, array);
            xSUA(ref uint_2, uint_3, uint_4, uint_, 0u, 20, 20u, array);
            xSUA(ref uint_, uint_2, uint_3, uint_4, 5u, 5, 21u, array);
            xSUA(ref uint_4, uint_, uint_2, uint_3, 10u, 9, 22u, array);
            xSUA(ref uint_3, uint_4, uint_, uint_2, 15u, 14, 23u, array);
            xSUA(ref uint_2, uint_3, uint_4, uint_, 4u, 20, 24u, array);
            xSUA(ref uint_, uint_2, uint_3, uint_4, 9u, 5, 25u, array);
            xSUA(ref uint_4, uint_, uint_2, uint_3, 14u, 9, 26u, array);
            xSUA(ref uint_3, uint_4, uint_, uint_2, 3u, 14, 27u, array);
            xSUA(ref uint_2, uint_3, uint_4, uint_, 8u, 20, 28u, array);
            xSUA(ref uint_, uint_2, uint_3, uint_4, 13u, 5, 29u, array);
            xSUA(ref uint_4, uint_, uint_2, uint_3, 2u, 9, 30u, array);
            xSUA(ref uint_3, uint_4, uint_, uint_2, 7u, 14, 31u, array);
            xSUA(ref uint_2, uint_3, uint_4, uint_, 12u, 20, 32u, array);
            vSUf(ref uint_, uint_2, uint_3, uint_4, 5u, 4, 33u, array);
            vSUf(ref uint_4, uint_, uint_2, uint_3, 8u, 11, 34u, array);
            vSUf(ref uint_3, uint_4, uint_, uint_2, 11u, 16, 35u, array);
            vSUf(ref uint_2, uint_3, uint_4, uint_, 14u, 23, 36u, array);
            vSUf(ref uint_, uint_2, uint_3, uint_4, 1u, 4, 37u, array);
            vSUf(ref uint_4, uint_, uint_2, uint_3, 4u, 11, 38u, array);
            vSUf(ref uint_3, uint_4, uint_, uint_2, 7u, 16, 39u, array);
            vSUf(ref uint_2, uint_3, uint_4, uint_, 10u, 23, 40u, array);
            vSUf(ref uint_, uint_2, uint_3, uint_4, 13u, 4, 41u, array);
            vSUf(ref uint_4, uint_, uint_2, uint_3, 0u, 11, 42u, array);
            vSUf(ref uint_3, uint_4, uint_, uint_2, 3u, 16, 43u, array);
            vSUf(ref uint_2, uint_3, uint_4, uint_, 6u, 23, 44u, array);
            vSUf(ref uint_, uint_2, uint_3, uint_4, 9u, 4, 45u, array);
            vSUf(ref uint_4, uint_, uint_2, uint_3, 12u, 11, 46u, array);
            vSUf(ref uint_3, uint_4, uint_, uint_2, 15u, 16, 47u, array);
            vSUf(ref uint_2, uint_3, uint_4, uint_, 2u, 23, 48u, array);
            ESU6(ref uint_, uint_2, uint_3, uint_4, 0u, 6, 49u, array);
            ESU6(ref uint_4, uint_, uint_2, uint_3, 7u, 10, 50u, array);
            ESU6(ref uint_3, uint_4, uint_, uint_2, 14u, 15, 51u, array);
            ESU6(ref uint_2, uint_3, uint_4, uint_, 5u, 21, 52u, array);
            ESU6(ref uint_, uint_2, uint_3, uint_4, 12u, 6, 53u, array);
            ESU6(ref uint_4, uint_, uint_2, uint_3, 3u, 10, 54u, array);
            ESU6(ref uint_3, uint_4, uint_, uint_2, 10u, 15, 55u, array);
            ESU6(ref uint_2, uint_3, uint_4, uint_, 1u, 21, 56u, array);
            ESU6(ref uint_, uint_2, uint_3, uint_4, 8u, 6, 57u, array);
            ESU6(ref uint_4, uint_, uint_2, uint_3, 15u, 10, 58u, array);
            ESU6(ref uint_3, uint_4, uint_, uint_2, 6u, 15, 59u, array);
            ESU6(ref uint_2, uint_3, uint_4, uint_, 13u, 21, 60u, array);
            ESU6(ref uint_, uint_2, uint_3, uint_4, 4u, 6, 61u, array);
            ESU6(ref uint_4, uint_, uint_2, uint_3, 11u, 10, 62u, array);
            ESU6(ref uint_3, uint_4, uint_, uint_2, 2u, 15, 63u, array);
            ESU6(ref uint_2, uint_3, uint_4, uint_, 9u, 21, 64u, array);
            uint_ += num10;
            uint_2 += num11;
            uint_3 += num12;
            uint_4 += num13;
        }

        byte[] array3 = new byte[16];
        Array.Copy(BitConverter.GetBytes(uint_), 0, array3, 0, 4);
        Array.Copy(BitConverter.GetBytes(uint_2), 0, array3, 4, 4);
        Array.Copy(BitConverter.GetBytes(uint_3), 0, array3, 8, 4);
        Array.Copy(BitConverter.GetBytes(uint_4), 0, array3, 12, 4);
        return array3;
    }

    private static void lSUB(ref uint uint_0, uint uint_1, uint uint_2, uint uint_3, uint uint_4, ushort ushort_0, uint uint_5, object object_0) {
        uint_0 = uint_1 + QSUx(uint_0 + ((uint_1 & uint_2) | (~uint_1 & uint_3)) + ((uint[])object_0)[uint_4] + NSTV[uint_5 - 1], ushort_0);
    }

    private static void xSUA(ref uint uint_0, uint uint_1, uint uint_2, uint uint_3, uint uint_4, ushort ushort_0, uint uint_5, object object_0) {
        uint_0 = uint_1 + QSUx(uint_0 + ((uint_1 & uint_3) | (uint_2 & ~uint_3)) + ((uint[])object_0)[uint_4] + NSTV[uint_5 - 1], ushort_0);
    }

    private static void vSUf(ref uint uint_0, uint uint_1, uint uint_2, uint uint_3, uint uint_4, ushort ushort_0, uint uint_5, object object_0) {
        uint_0 = uint_1 + QSUx(uint_0 + (uint_1 ^ uint_2 ^ uint_3) + ((uint[])object_0)[uint_4] + NSTV[uint_5 - 1], ushort_0);
    }

    private static void ESU6(ref uint uint_0, uint uint_1, uint uint_2, uint uint_3, uint uint_4, ushort ushort_0, uint uint_5, object object_0) {
        uint_0 = uint_1 + QSUx(uint_0 + (uint_2 ^ (uint_1 | ~uint_3)) + ((uint[])object_0)[uint_4] + NSTV[uint_5 - 1], ushort_0);
    }

    private static uint QSUx(uint uint_0, ushort ushort_0) {
        return (uint_0 >> 32 - ushort_0) | (uint_0 << (int)ushort_0);
    }

    internal static bool CSU9() {
        if (!VSTO) {
            bSUc();
            VSTO = true;
        }

        return RSTe;
    }

    internal static void bSUc() {
        try {
            RSTe = (bool)typeof(RijndaelManaged).Assembly.GetType("System.Security.Cryptography.CryptoConfig", throwOnError: false).GetMethod("get_AllowOnlyFipsAlgorithms", BindingFlags.Static | BindingFlags.Public).Invoke(null, new object[0]);
        } catch {
        }
    }

    internal static SymmetricAlgorithm qSUy() {
        SymmetricAlgorithm symmetricAlgorithm = null;
        if (CSU9()) {
            try {
                return new AesCryptoServiceProvider();
            } catch {
                return new RijndaelManaged();
            }
        }

        return new RijndaelManaged();
    }

    internal static byte[] LSUr(byte[] byte_0) {
        if (!CSU9()) {
            return new MD5CryptoServiceProvider().ComputeHash(byte_0);
        }

        return LSUY(byte_0);
    }

    static string sSUu(int int_0) {
        if (bSTF.Length == 0) {
            BinaryReader binaryReader = new BinaryReader(typeof(Class89).Assembly.GetManifestResourceStream("b1fc1e61-00b3-4011-85de-07e057fdb475"));
            binaryReader.BaseStream.Position = 0L;
            byte[] array = binaryReader.ReadBytes((int)binaryReader.BaseStream.Length);
            byte[] array2 = new byte[32];
            array2[0] = 92;
            array2[0] = 160;
            array2[0] = 121;
            array2[0] = 145;
            array2[0] = 25;
            array2[1] = 164;
            array2[1] = 164;
            array2[1] = 228;
            array2[1] = 100;
            array2[1] = 113;
            array2[2] = 120;
            array2[2] = 98;
            array2[2] = 129;
            array2[2] = 76;
            array2[2] = 143;
            array2[2] = 104;
            array2[3] = 122;
            array2[3] = 121;
            array2[3] = 84;
            array2[3] = 13;
            array2[4] = 120;
            array2[4] = 150;
            array2[4] = 130;
            array2[4] = 87;
            array2[4] = 132;
            array2[4] = 121;
            array2[5] = 122;
            array2[5] = 154;
            array2[5] = 86;
            array2[5] = 160;
            array2[5] = 180;
            array2[6] = 85;
            array2[6] = 41;
            array2[6] = 101;
            array2[6] = 11;
            array2[7] = 149;
            array2[7] = 114;
            array2[7] = 158;
            array2[7] = 164;
            array2[7] = 223;
            array2[8] = 95;
            array2[8] = 85;
            array2[8] = 97;
            array2[8] = 97;
            array2[8] = 203;
            array2[8] = 205;
            array2[9] = 128;
            array2[9] = 173;
            array2[9] = 247;
            array2[10] = 161;
            array2[10] = 25;
            array2[10] = 16;
            array2[11] = 139;
            array2[11] = 137;
            array2[11] = 165;
            array2[11] = 156;
            array2[11] = 21;
            array2[12] = 110;
            array2[12] = 74;
            array2[12] = 149;
            array2[12] = 161;
            array2[12] = 40;
            array2[12] = 151;
            array2[13] = 153;
            array2[13] = 97;
            array2[13] = 94;
            array2[13] = 95;
            array2[13] = 102;
            array2[13] = 36;
            array2[14] = 127;
            array2[14] = 97;
            array2[14] = 167;
            array2[15] = 162;
            array2[15] = 178;
            array2[15] = 128;
            array2[15] = 170;
            array2[15] = 110;
            array2[16] = 146;
            array2[16] = 169;
            array2[16] = 30;
            array2[16] = 159;
            array2[17] = 162;
            array2[17] = 153;
            array2[17] = 166;
            array2[17] = 99;
            array2[17] = 35;
            array2[18] = 128;
            array2[18] = 154;
            array2[18] = 130;
            array2[18] = 127;
            array2[18] = 217;
            array2[19] = 94;
            array2[19] = 141;
            array2[19] = 80;
            array2[20] = 96;
            array2[20] = 75;
            array2[20] = 160;
            array2[20] = 170;
            array2[20] = 97;
            array2[20] = 56;
            array2[21] = 90;
            array2[21] = 124;
            array2[21] = 152;
            array2[21] = 105;
            array2[21] = 54;
            array2[22] = 140;
            array2[22] = 139;
            array2[22] = 84;
            array2[23] = 218;
            array2[23] = 157;
            array2[23] = 84;
            array2[23] = 176;
            array2[24] = 125;
            array2[24] = 111;
            array2[24] = 134;
            array2[24] = 32;
            array2[24] = 35;
            array2[24] = 28;
            array2[25] = 191;
            array2[25] = 96;
            array2[25] = 90;
            array2[25] = 96;
            array2[25] = 47;
            array2[26] = 189;
            array2[26] = 147;
            array2[26] = 152;
            array2[26] = 146;
            array2[26] = 155;
            array2[26] = 144;
            array2[27] = 81;
            array2[27] = 88;
            array2[27] = 139;
            array2[27] = 100;
            array2[28] = 109;
            array2[28] = 52;
            array2[28] = 98;
            array2[28] = 30;
            array2[28] = 159;
            array2[29] = 169;
            array2[29] = 119;
            array2[29] = 225;
            array2[30] = 193;
            array2[30] = 109;
            array2[30] = 120;
            array2[31] = 150;
            array2[31] = 146;
            array2[31] = 41;
            byte[] array3 = array2;
            byte[] array4 = new byte[16];
            array4[0] = 168;
            array4[0] = 144;
            array4[0] = 180;
            array4[1] = 126;
            array4[1] = 59;
            array4[1] = 114;
            array4[1] = 124;
            array4[2] = 199;
            array4[2] = 95;
            array4[2] = 193;
            array4[3] = 170;
            array4[3] = 94;
            array4[3] = 214;
            array4[4] = 100;
            array4[4] = 105;
            array4[4] = 142;
            array4[4] = 156;
            array4[4] = 156;
            array4[4] = 209;
            array4[5] = 148;
            array4[5] = 62;
            array4[5] = 158;
            array4[5] = 118;
            array4[5] = 201;
            array4[6] = 146;
            array4[6] = 126;
            array4[6] = 127;
            array4[6] = 5;
            array4[7] = 73;
            array4[7] = 125;
            array4[7] = 87;
            array4[7] = 100;
            array4[7] = 198;
            array4[8] = 106;
            array4[8] = 168;
            array4[8] = 136;
            array4[9] = 126;
            array4[9] = 86;
            array4[9] = 124;
            array4[9] = 107;
            array4[10] = 65;
            array4[10] = 131;
            array4[10] = 143;
            array4[10] = 101;
            array4[10] = 157;
            array4[10] = 117;
            array4[11] = 141;
            array4[11] = 139;
            array4[11] = 89;
            array4[11] = 120;
            array4[11] = 88;
            array4[12] = 110;
            array4[12] = 170;
            array4[12] = 141;
            array4[12] = 94;
            array4[12] = 214;
            array4[13] = 88;
            array4[13] = 238;
            array4[13] = 125;
            array4[13] = 141;
            array4[13] = 194;
            array4[14] = 153;
            array4[14] = 143;
            array4[14] = 128;
            array4[14] = 35;
            array4[15] = 116;
            array4[15] = 146;
            array4[15] = 128;
            array4[15] = 96;
            array4[15] = 129;
            array4[15] = 190;
            byte[] array5 = array4;
            byte[] publicKeyToken = typeof(Class89).Assembly.GetName().GetPublicKeyToken();
            if (publicKeyToken != null && publicKeyToken.Length > 0) {
                array5[1] = publicKeyToken[0];
                array5[3] = publicKeyToken[1];
                array5[5] = publicKeyToken[2];
                array5[7] = publicKeyToken[3];
                array5[9] = publicKeyToken[4];
                array5[11] = publicKeyToken[5];
                array5[13] = publicKeyToken[6];
                array5[15] = publicKeyToken[7];
            }

            for (int i = 0; i < array5.Length; i++) {
                array3[i] ^= array5[i];
            }

            if (int_0 == -1) {
                SymmetricAlgorithm symmetricAlgorithm = qSUy();
                symmetricAlgorithm.Mode = CipherMode.CBC;
                ICryptoTransform transform = symmetricAlgorithm.CreateDecryptor(array3, array5);
                MemoryStream memoryStream = new MemoryStream();
                CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
                cryptoStream.Write(array, 0, array.Length);
                cryptoStream.FlushFinalBlock();
                bSTF = memoryStream.ToArray();
                if (bSTF.Length > 0) {
                    vST7 = new string[bSTF.Length / 4 + 1];
                    nSTP = new int[bSTF.Length / 4 + 1];
                }

                memoryStream.Close();
                cryptoStream.Close();
                binaryReader.Close();
                array = bSTF;
            }

            int num = array.Length % 4;
            int num2 = array.Length / 4;
            byte[] array6 = new byte[array.Length];
            int num3 = array3.Length / 4;
            uint num4 = 0u;
            uint num5 = 0u;
            uint num6 = 0u;
            if (num > 0) {
                num2++;
            }

            uint num7 = 0u;
            for (int j = 0; j < num2; j++) {
                int num8 = j % num3;
                int num9 = j * 4;
                num7 = (uint)(num8 * 4);
                num5 = (uint)((array3[num7 + 3] << 24) | (array3[num7 + 2] << 16) | (array3[num7 + 1] << 8) | array3[num7]);
                uint num10 = 255u;
                int num11 = 0;
                if (j == num2 - 1 && num > 0) {
                    num6 = 0u;
                    for (int k = 0; k < num; k++) {
                        if (k > 0) {
                            num6 <<= 8;
                        }

                        num6 |= array[array.Length - (1 + k)];
                    }

                    num4 += num5;
                } else {
                    num7 = (uint)num9;
                    num6 = (uint)((array[num7 + 3] << 24) | (array[num7 + 2] << 16) | (array[num7 + 1] << 8) | array[num7]);
                    num4 += num5;
                }

                uint num12 = num4;
                uint num13 = num4;
                num13 ^= num13 >> 4;
                num13 += 3617633032u;
                num13 ^= num13 << 3;
                num13 += 412565304;
                num13 ^= num13 >> 17;
                num13 += 503087788;
                num13 = 1905258876 + num13;
                num4 = num12 + (uint)(double)num13;
                if (j == num2 - 1 && num > 0) {
                    uint num14 = num4 ^ num6;
                    for (int l = 0; l < num; l++) {
                        if (l > 0) {
                            num10 <<= 8;
                            num11 += 8;
                        }

                        array6[num9 + l] = (byte)((num14 & num10) >> num11);
                    }
                } else {
                    uint num15 = num4 ^ num6;
                    array6[num9] = (byte)(num15 & 0xFF);
                    array6[num9 + 1] = (byte)((num15 & 0xFF00) >> 8);
                    array6[num9 + 2] = (byte)((num15 & 0xFF0000) >> 16);
                    array6[num9 + 3] = (byte)((num15 & 0xFF000000u) >> 24);
                }
            }

            bSTF = array6;
            if (bSTF.Length > 0) {
                vST7 = new string[bSTF.Length / 4 + 1];
                nSTP = new int[bSTF.Length / 4 + 1];
            }

            Assembly assembly = typeof(Class89).Assembly;
            if (IntPtr.Size == 4) {
                JST0 = Marshal.GetHINSTANCE(assembly.GetModules()[0]).ToInt32();
            }

            bSTm = Marshal.GetHINSTANCE(assembly.GetModules()[0]).ToInt64();
        }

        int num16 = int_0 / 4;
        if (nSTP[num16] > 0) {
            return vST7[nSTP[num16]];
        }

        int num17 = BitConverter.ToInt32(bSTF, int_0);
        if (MSTL == IntPtr.Zero) {
            MSTL = OpenProcess(16u, 1, (uint)Process.GetCurrentProcess().Id);
        }

        byte[] array7 = new byte[4];
        if (IntPtr.Size == 4) {
            ReadProcessMemory(MSTL, new IntPtr(JST0 + num17), array7, 4u, out cSTJ);
        } else {
            ReadProcessMemory(MSTL, new IntPtr(bSTm + num17), array7, 4u, out cSTJ);
        }

        int num18 = BitConverter.ToInt32(array7, 0);
        array7 = new byte[num18];
        if (IntPtr.Size == 4) {
            ReadProcessMemory(MSTL, new IntPtr(JST0 + num17 + 4), array7, Convert.ToUInt32(num18), out cSTJ);
        } else {
            ReadProcessMemory(MSTL, new IntPtr(bSTm + num17 + 4L), array7, Convert.ToUInt32(num18), out cSTJ);
        }

        byte[] array8 = USUj(array7);
        string text = Encoding.Unicode.GetString(array8, 0, array8.Length);
        nSTP[num16] = jSTi;
        vST7[jSTi] = text;
        jSTi++;
        return text;
    }

    internal static string gSUg(string string_0) {
        "{11111-22222-50001-00000}".Trim();
        byte[] array = Convert.FromBase64String(string_0);
        return Encoding.Unicode.GetString(array, 0, array.Length);
    }

    [DllImport("kernel32.dll")]
    private static extern int VirtualProtect(IntPtr intptr_0, int int_0, int int_1, ref int int_2);
    [bYr(typeof(BOz_002FbYr_002FJY7<object>[]))]
    static void LSUd() {
        if (OSTI) {
            return;
        }

        OSTI = true;
        BinaryReader binaryReader = new BinaryReader(typeof(Class89).Assembly.GetManifestResourceStream("c680ca40-6dcc-4160-95ff-dd0bdfc19002"));
        binaryReader.BaseStream.Position = 0L;
        byte[] array = binaryReader.ReadBytes((int)binaryReader.BaseStream.Length);
        byte[] array2 = new byte[32];
        array2[0] = 37;
        array2[0] = 150;
        array2[0] = 150;
        array2[0] = 108;
        array2[0] = 37;
        array2[1] = 205;
        array2[1] = 100;
        array2[1] = 112;
        array2[1] = 205;
        array2[2] = 24;
        array2[2] = 95;
        array2[2] = 169;
        array2[2] = 57;
        array2[2] = 24;
        array2[3] = 202;
        array2[3] = 132;
        array2[3] = 114;
        array2[3] = 89;
        array2[3] = 202;
        array2[4] = 0;
        array2[4] = 96;
        array2[4] = 127;
        array2[4] = 92;
        array2[4] = 160;
        array2[4] = 0;
        array2[5] = 61;
        array2[5] = 118;
        array2[5] = 86;
        array2[5] = 90;
        array2[5] = 61;
        array2[6] = 195;
        array2[6] = 11;
        array2[6] = 142;
        array2[6] = 109;
        array2[6] = 164;
        array2[6] = 45;
        array2[6] = 195;
        array2[7] = 123;
        array2[7] = 128;
        array2[7] = 165;
        array2[7] = 103;
        array2[7] = 123;
        array2[8] = 89;
        array2[8] = 152;
        array2[8] = 120;
        array2[8] = 93;
        array2[8] = 148;
        array2[8] = 89;
        array2[9] = 226;
        array2[9] = 103;
        array2[9] = 124;
        array2[9] = 229;
        array2[9] = 150;
        array2[9] = 124;
        array2[9] = 226;
        array2[10] = 159;
        array2[10] = 167;
        array2[10] = 117;
        array2[10] = 159;
        array2[11] = 212;
        array2[11] = 112;
        array2[11] = 138;
        array2[11] = 103;
        array2[11] = 212;
        array2[12] = 9;
        array2[12] = 120;
        array2[12] = 210;
        array2[12] = 115;
        array2[12] = 9;
        array2[13] = 160;
        array2[13] = 104;
        array2[13] = 116;
        array2[13] = 160;
        array2[14] = 116;
        array2[14] = 131;
        array2[14] = 147;
        array2[14] = 128;
        array2[14] = 146;
        array2[14] = 116;
        array2[15] = 52;
        array2[15] = 177;
        array2[15] = 118;
        array2[15] = 106;
        array2[15] = 52;
        array2[16] = 199;
        array2[16] = 117;
        array2[16] = 118;
        array2[16] = 114;
        array2[16] = 199;
        array2[17] = 171;
        array2[17] = 160;
        array2[17] = 102;
        array2[17] = 89;
        array2[17] = 171;
        array2[18] = 73;
        array2[18] = 226;
        array2[18] = 160;
        array2[18] = 73;
        array2[19] = 216;
        array2[19] = 145;
        array2[19] = 92;
        array2[19] = 87;
        array2[19] = 169;
        array2[19] = 35;
        array2[19] = 216;
        array2[20] = 167;
        array2[20] = 132;
        array2[20] = 106;
        array2[20] = 96;
        array2[20] = 127;
        array2[20] = 126;
        array2[20] = 167;
        array2[21] = 151;
        array2[21] = 143;
        array2[21] = 128;
        array2[21] = 153;
        array2[21] = 7;
        array2[21] = 149;
        array2[21] = 151;
        array2[22] = 86;
        array2[22] = 108;
        array2[22] = 154;
        array2[22] = 94;
        array2[22] = 86;
        array2[23] = 117;
        array2[23] = 88;
        array2[23] = 152;
        array2[23] = 153;
        array2[23] = 117;
        array2[24] = 126;
        array2[24] = 86;
        array2[24] = 88;
        array2[24] = 112;
        array2[24] = 143;
        array2[24] = 126;
        array2[25] = 239;
        array2[25] = 155;
        array2[25] = 136;
        array2[25] = 161;
        array2[25] = 239;
        array2[26] = 17;
        array2[26] = 230;
        array2[26] = 157;
        array2[26] = 17;
        array2[27] = 61;
        array2[27] = 46;
        array2[27] = 173;
        array2[27] = 61;
        array2[28] = 113;
        array2[28] = 25;
        array2[28] = 206;
        array2[28] = 113;
        array2[29] = 146;
        array2[29] = 137;
        array2[29] = 145;
        array2[29] = 151;
        array2[29] = 146;
        array2[30] = 107;
        array2[30] = 121;
        array2[30] = 86;
        array2[30] = 102;
        array2[30] = 169;
        array2[30] = 147;
        array2[30] = 107;
        array2[31] = 212;
        array2[31] = 167;
        array2[31] = 137;
        array2[31] = 98;
        array2[31] = 118;
        array2[31] = 212;
        byte[] array3 = array2;
        byte[] array4 = new byte[16];
        array4[0] = 128;
        array4[0] = 64;
        array4[0] = 152;
        array4[0] = 148;
        array4[0] = 205;
        array4[1] = 98;
        array4[1] = 150;
        array4[1] = 208;
        array4[2] = 116;
        array4[2] = 100;
        array4[2] = 164;
        array4[2] = 206;
        array4[3] = 88;
        array4[3] = 160;
        array4[3] = 197;
        array4[3] = 29;
        array4[3] = 99;
        array4[3] = 212;
        array4[4] = 218;
        array4[4] = 164;
        array4[4] = 96;
        array4[4] = 92;
        array4[4] = 147;
        array4[4] = 225;
        array4[5] = 66;
        array4[5] = 167;
        array4[5] = 178;
        array4[5] = 85;
        array4[5] = 120;
        array4[5] = 184;
        array4[6] = 157;
        array4[6] = 174;
        array4[6] = 117;
        array4[6] = 86;
        array4[7] = 79;
        array4[7] = 94;
        array4[7] = 109;
        array4[7] = 137;
        array4[7] = 124;
        array4[8] = 154;
        array4[8] = 146;
        array4[8] = 120;
        array4[8] = 122;
        array4[8] = 163;
        array4[8] = 86;
        array4[9] = 130;
        array4[9] = 99;
        array4[9] = 240;
        array4[10] = 136;
        array4[10] = 100;
        array4[10] = 89;
        array4[10] = 130;
        array4[10] = 76;
        array4[10] = 235;
        array4[11] = 167;
        array4[11] = 149;
        array4[11] = 129;
        array4[11] = 128;
        array4[11] = 8;
        array4[12] = 99;
        array4[12] = 166;
        array4[12] = 117;
        array4[13] = 151;
        array4[13] = 141;
        array4[13] = 113;
        array4[13] = 163;
        array4[14] = 120;
        array4[14] = 134;
        array4[14] = 155;
        array4[14] = 116;
        array4[14] = 193;
        array4[15] = 119;
        array4[15] = 96;
        array4[15] = 92;
        array4[15] = 92;
        array4[15] = 114;
        byte[] array5 = array4;
        Array.Reverse(array5);
        byte[] publicKeyToken = typeof(Class89).Assembly.GetName().GetPublicKeyToken();
        if (publicKeyToken != null && publicKeyToken.Length > 0) {
            array5[1] = publicKeyToken[0];
            array5[3] = publicKeyToken[1];
            array5[5] = publicKeyToken[2];
            array5[7] = publicKeyToken[3];
            array5[9] = publicKeyToken[4];
            array5[11] = publicKeyToken[5];
            array5[13] = publicKeyToken[6];
            array5[15] = publicKeyToken[7];
            Array.Clear(publicKeyToken, 0, publicKeyToken.Length);
        }

        for (int i = 0; i < array5.Length; i++) {
            array3[i] ^= array5[i];
        }

        byte[] array6 = array;
        int num = array6.Length % 4;
        int num2 = array6.Length / 4;
        byte[] array7 = new byte[array6.Length];
        int num3 = array3.Length / 4;
        uint num4 = 0u;
        uint num5 = 0u;
        uint num6 = 0u;
        if (num > 0) {
            num2++;
        }

        uint num7 = 0u;
        for (int j = 0; j < num2; j++) {
            int num8 = j % num3;
            int num9 = j * 4;
            num7 = (uint)(num8 * 4);
            num5 = (uint)((array3[num7 + 3] << 24) | (array3[num7 + 2] << 16) | (array3[num7 + 1] << 8) | array3[num7]);
            uint num10 = 255u;
            int num11 = 0;
            if (j == num2 - 1 && num > 0) {
                num4 += num5;
                num6 = 0u;
                for (int k = 0; k < num; k++) {
                    if (k > 0) {
                        num6 <<= 8;
                    }

                    num6 |= array6[array6.Length - (1 + k)];
                }
            } else {
                num7 = (uint)num9;
                num4 += num5;
                num6 = (uint)((array6[num7 + 3] << 24) | (array6[num7 + 2] << 16) | (array6[num7 + 1] << 8) | array6[num7]);
            }

            num4 = num4;
            uint num12 = num4;
            uint num13 = num4;
            num13 ^= num13 >> 4;
            num13 += 3617633032u;
            num13 ^= num13 << 3;
            num13 += 412565304;
            num13 ^= num13 >> 17;
            num13 += 503087788;
            num13 = 1905258876 + num13;
            num4 = num12 + (uint)(double)num13;
            if (j == num2 - 1 && num > 0) {
                uint num14 = num4 ^ num6;
                for (int l = 0; l < num; l++) {
                    if (l > 0) {
                        num10 <<= 8;
                        num11 += 8;
                    }

                    array7[num9 + l] = (byte)((num14 & num10) >> num11);
                }
            } else {
                uint num15 = num4 ^ num6;
                array7[num9] = (byte)(num15 & 0xFF);
                array7[num9 + 1] = (byte)((num15 & 0xFF00) >> 8);
                array7[num9 + 2] = (byte)((num15 & 0xFF0000) >> 16);
                array7[num9 + 3] = (byte)((num15 & 0xFF000000u) >> 24);
            }
        }

        byte[] buffer = array7;
        Array.Clear(array5, 0, array5.Length);
        binaryReader.Close();
        binaryReader = new BinaryReader(new MemoryStream(buffer));
        binaryReader.BaseStream.Position = 0L;
        IntPtr zero = IntPtr.Zero;
        Assembly assembly = typeof(Class89).Assembly;
        zero = OpenProcess(56u, 1, (uint)Process.GetCurrentProcess().Id);
        bSTm = Marshal.GetHINSTANCE(assembly.GetModules()[0]).ToInt64();
        IntPtr intptr_ = IntPtr.Zero;
        int int_ = 0;
        int num16 = binaryReader.ReadInt32();
        binaryReader.ReadInt32();
        for (int m = 0; m < num16; m++) {
            IntPtr intPtr = new IntPtr(bSTm + binaryReader.ReadInt32());
            VirtualProtect(intPtr, 4, 4, ref int_);
            if (IntPtr.Size == 4) {
                WriteProcessMemory(zero, intPtr, BitConverter.GetBytes(binaryReader.ReadInt32()), 4u, out intptr_);
            } else {
                WriteProcessMemory(zero, intPtr, BitConverter.GetBytes(binaryReader.ReadInt32()), 4u, out intptr_);
            }

            VirtualProtect(intPtr, 4, int_, ref int_);
        }

        try {
            while (binaryReader.BaseStream.Position < binaryReader.BaseStream.Length - 1L) {
                int num17 = binaryReader.ReadInt32();
                IntPtr intptr_2 = new IntPtr(bSTm + num17);
                int num18 = binaryReader.ReadInt32();
                VirtualProtect(intptr_2, num18 * 4, 4, ref int_);
                for (int n = 0; n < num18; n++) {
                    Marshal.WriteInt32(new IntPtr(intptr_2.ToInt64() + n * 4), binaryReader.ReadInt32());
                }

                VirtualProtect(intptr_2, num18 * 4, int_, ref int_);
            }

            CloseHandle(zero);
        } catch {
        }
    }

    internal static object kSUH(Assembly assembly_0) {
        try {
            if (File.Exists(assembly_0.Location)) {
                return assembly_0.Location;
            }
        } catch {
        }

        try {
            if (File.Exists(assembly_0.GetName().CodeBase.ToString().Replace("file:///", ""))) {
                return assembly_0.GetName().CodeBase.ToString().Replace("file:///", "");
            }
        } catch {
        }

        try {
            if (File.Exists(assembly_0.GetType().GetProperty("Location").GetValue(assembly_0, new object[0]).ToString())) {
                return assembly_0.GetType().GetProperty("Location").GetValue(assembly_0, new object[0]).ToString();
            }
        } catch {
        }

        return "";
    }

    [DllImport("kernel32.dll")]
    private static extern int WriteProcessMemory(IntPtr intptr_0, IntPtr intptr_1, [In][Out] byte[] byte_0, uint uint_0, out IntPtr intptr_2);
    [DllImport("kernel32.dll")]
    private static extern int ReadProcessMemory(IntPtr intptr_0, IntPtr intptr_1, [In][Out] byte[] byte_0, uint uint_0, out IntPtr intptr_2);
    [DllImport("kernel32.dll")]
    private static extern IntPtr OpenProcess(uint uint_0, int int_0, uint uint_1);
    [DllImport("kernel32.dll")]
    private static extern int CloseHandle(IntPtr intptr_0);
    private static byte[] jSUa(string string_0) {
        using FileStream fileStream = new FileStream(string_0, FileMode.Open, FileAccess.Read, FileShare.Read);
        int num = 0;
        long length = fileStream.Length;
        int num2 = (int)length;
        byte[] array = new byte[num2];
        while (num2 > 0) {
            int num3 = fileStream.Read(array, num, num2);
            num += num3;
            num2 -= num3;
        }

        return array;
    }

    private static byte[] USUj(byte[] byte_0) {
        MemoryStream memoryStream = new MemoryStream();
        SymmetricAlgorithm symmetricAlgorithm = qSUy();
        symmetricAlgorithm.Key = new byte[32]
        {
            191,
            128,
            122,
            145,
            190,
            129,
            31,
            227,
            50,
            3,
            250,
            44,
            193,
            186,
            47,
            122,
            29,
            176,
            162,
            237,
            50,
            85,
            194,
            143,
            62,
            45,
            124,
            204,
            192,
            99,
            11,
            243
        };
        symmetricAlgorithm.IV = new byte[16]
        {
            108,
            112,
            33,
            167,
            72,
            202,
            197,
            103,
            217,
            40,
            210,
            151,
            152,
            133,
            193,
            153
        };
        CryptoStream cryptoStream = new CryptoStream(memoryStream, symmetricAlgorithm.CreateDecryptor(), CryptoStreamMode.Write);
        cryptoStream.Write(byte_0, 0, byte_0.Length);
        cryptoStream.Close();
        return memoryStream.ToArray();
    }

    private byte[] hSUz() {
        return null;
    }

    private byte[] GSTE() {
        return null;
    }

    private byte[] RSTD() {
        return null;
    }

    private byte[] ASTX() {
        return null;
    }

    private byte[] sSTp() {
        return null;
    }

    private byte[] kSTS() {
        return null;
    }

    internal byte[] KSTh() {
        string text = "{11111-22222-40001-00001}";
        if (text.Length > 0) {
            return new byte[2]
            {
                1,
                2
            };
        }

        return new byte[2]
        {
            1,
            2
        };
    }

    internal byte[] USTl() {
        string text = "{11111-22222-40001-00002}";
        if (text.Length > 0) {
            return new byte[2]
            {
                1,
                2
            };
        }

        return new byte[2]
        {
            1,
            2
        };
    }

    internal byte[] XSTG() {
        string text = "{11111-22222-50001-00001}";
        if (text.Length > 0) {
            return new byte[2]
            {
                1,
                2
            };
        }

        return new byte[2]
        {
            1,
            2
        };
    }

    internal byte[] ASTb() {
        string text = "{11111-22222-50001-00002}";
        if (text.Length > 0) {
            return new byte[2]
            {
                1,
                2
            };
        }

        return new byte[2]
        {
            1,
            2
        };
    }

    internal byte[] ESTv() {
        string text = "{11111-22222-60001-00001}";
        if (text.Length > 0) {
            return new byte[2]
            {
                1,
                2
            };
        }

        return new byte[2]
        {
            1,
            2
        };
    }

    internal byte[] GSTo() {
        string text = "{11111-22222-60001-00002}";
        if (text.Length > 0) {
            return new byte[2]
            {
                1,
                2
            };
        }

        return new byte[2]
        {
            1,
            2
        };
    }

    internal static string RSTt(string string_0, string string_1) {
        byte[] bytes = Encoding.Unicode.GetBytes(string_0);
        byte[] array = bytes;
        byte[] key = new byte[32]
        {
            202,
            123,
            33,
            184,
            79,
            39,
            235,
            233,
            64,
            144,
            93,
            200,
            211,
            163,
            93,
            172,
            197,
            32,
            77,
            24,
            34,
            158,
            161,
            41,
            97,
            28,
            118,
            181,
            5,
            25,
            1,
            88
        };
        byte[] iV = LSUr(Encoding.Unicode.GetBytes(string_1));
        MemoryStream memoryStream = new MemoryStream();
        SymmetricAlgorithm symmetricAlgorithm = qSUy();
        symmetricAlgorithm.Key = key;
        symmetricAlgorithm.IV = iV;
        CryptoStream cryptoStream = new CryptoStream(memoryStream, symmetricAlgorithm.CreateEncryptor(), CryptoStreamMode.Write);
        cryptoStream.Write(array, 0, array.Length);
        cryptoStream.Close();
        return Convert.ToBase64String(memoryStream.ToArray());
    }

    internal static bool dK() {
        return true;
    }

    internal static bool H5() {
        return false;
    }
}