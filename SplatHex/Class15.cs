using System.IO;
using System.Security.Cryptography;

namespace SplatHex;
internal static class Class15 {
    public static byte[] hSUw(byte[] byte_0) {
        using Aes aes = Aes.Create();
        aes.GenerateKey();
        aes.GenerateIV();
        using MemoryStream memoryStream = new MemoryStream(byte_0);
        byte[] array = new byte[aes.Key.Length];
        byte[] array2 = new byte[aes.IV.Length];
        memoryStream.Read(array, 0, array.Length);
        memoryStream.Read(array2, 0, array2.Length);
        using ICryptoTransform transform = aes.CreateDecryptor(array, array2);
        using CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Read);
        byte[] array3 = new byte[memoryStream.Length - memoryStream.Position];
        cryptoStream.Read(array3, 0, array3.Length);
        return array3;
    }

    public static byte[] GSUN(Stream stream_0) {
        byte[] array = new byte[stream_0.Length];
        stream_0.Read(array, 0, array.Length);
        return array;
    }

    internal static bool jpG() {
        return false;
    }
}