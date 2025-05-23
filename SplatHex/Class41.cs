using System.Security.Cryptography;
using System.Text;

namespace SplatHex;
internal class Class41 {
    public static string LDkA(HashAlgorithm hashAlgorithm_0, string string_0) {
        byte[] array = hashAlgorithm_0.ComputeHash(Encoding.UTF8.GetBytes(string_0));
        StringBuilder stringBuilder = new StringBuilder();
        for (int i = 0; i < array.Length; i++) {
            stringBuilder.Append(array[i].ToString(Class13.Npzw));
        }

        return stringBuilder.ToString();
    }

    internal static bool m8A() {
        return false;
    }
}