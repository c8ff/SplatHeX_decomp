using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net;
using System.Resources;
using System.Text;
using Newtonsoft.Json;

namespace SplatHex;
internal static class Class122 {
    public static Dictionary<int, Class119> PlD;
    private const string ulX = "https://raw.githubusercontent.com/Leanny/leanny.github.io/master/splat2/weapons/";
    static Class122() {
        PlD = new Dictionary<int, Class119>();
        Dictionary<string, string> dictionary_ = Class127.BD8N(new MemoryStream(Resources.WeaponName_Main));
        List<Dictionary<string, object>> list_ = JsonConvert.DeserializeObject<List<Dictionary<string, object>>>(Encoding.Default.GetString(Resources.WeaponInfo_Main_byaml));
        uhz(dictionary_, list_);
        plE();
    }

    private static void uhz(Dictionary<string, string> dictionary_0, List<Dictionary<string, object>> list_0) {
        Dictionary<string, int> dictionary = new Dictionary<string, int>();
        List<Dictionary<string, object>> list = JsonConvert.DeserializeObject<List<Dictionary<string, object>>>(Encoding.Default.GetString(Resources.WeaponInfo_Sub_byaml));
        foreach (Dictionary<string, object> item in list) {
            dictionary.Add((string)item["Name"], (int)(long)item["Id"]);
        }

        Dictionary<string, int> dictionary2 = new Dictionary<string, int>();
        List<Dictionary<string, object>> list2 = JsonConvert.DeserializeObject<List<Dictionary<string, object>>>(Encoding.Default.GetString(Resources.WeaponInfo_Special_byaml));
        foreach (Dictionary<string, object> item2 in list2) {
            dictionary2.Add((string)item2["Name"], (int)(long)item2["Id"]);
        }

        ResourceManager oKz = Resources.oKz;
        foreach (Dictionary<string, object> item3 in list_0) {
            int num = (int)(long)item3["Id"];
            if (num >= 10000) {
                continue;
            }

            string string_ = dictionary_0[(string)item3["Name"]];
            Bitmap bitmap = null;
            bitmap = (Bitmap)oKz.GetObject(string.Concat("Wst_", item3["Name"], "_Splat2"));
            if (bitmap == null) {
                string text = string.Concat("img/Wst_", item3["Name"], ".png");
                if (!File.Exists(text)) {
                    using WebClient webClient = new WebClient();
                    webClient.DownloadFile(new Uri(string.Concat("https://raw.githubusercontent.com/Leanny/leanny.github.io/master/splat2/weapons/Wst_", item3["Name"], ".png")), text);
                }

                bitmap = new Bitmap(text);
            }

            int num2 = (int)(long)item3["Addition"];
            bool bool_ = "Other".Equals(item3["Lock"]) || "Mission".Equals(item3["Lock"]) || num2 > Class26.QXu.UpS;
            int int_ = (int)(long)item3["Rank"];
            int int_2 = dictionary[(string)item3["Sub"]];
            int int_3 = dictionary2[(string)item3["Special"]];
            Class119 aS = new Class119(num, int_, string_, bitmap, int_2, int_3, num2, bool_);
            if (PlD.ContainsKey(aS.UDZ)) {
                PlD[aS.UDZ] = aS;
            } else {
                PlD.Add(aS.UDZ, aS);
            }
        }
    }

    private static void plE() {
        if (File.Exists("json/lang_dict.json") && File.Exists("json/WeaponInfo_Main.json")) {
            Dictionary<string, string> dictionary_;
            using (StreamReader streamReader = new StreamReader("json/lang_dict.json")) {
                string value = streamReader.ReadToEnd();
                dictionary_ = JsonConvert.DeserializeObject<Dictionary<string, string>>(value);
            }

            List<Dictionary<string, object>> list_;
            using (StreamReader streamReader2 = new StreamReader("json/WeaponInfo_Main.json")) {
                string value2 = streamReader2.ReadToEnd();
                list_ = JsonConvert.DeserializeObject<List<Dictionary<string, object>>>(value2);
            }

            uhz(dictionary_, list_);
        }
    }

    internal static bool iN6() {
        return true;
    }
}