using System.Collections.Generic;
using System.IO;

namespace SplatHex;
internal class Class127 {
    public static Dictionary<string, string> BD8N(Stream stream_0) {
        Dictionary<string, string> dictionary = new Dictionary<string, string>();
        Class102 e7z = new Class102(stream_0);
        for (int i = 0; i < e7z.tDnC.EDnX; i++) {
            H7m h7m = ((!e7z.QDnT) ? e7z.tDnC.hDnp[i] : e7z.zDni.jD82[i]);
            dictionary.Add(h7m.ToString(), e7z.SDnK.GetString(h7m.Value).Replace("\0", ""));
        }

        return dictionary;
    }
}