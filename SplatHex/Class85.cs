using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net;
using System.Resources;
using System.Text;
using Newtonsoft.Json;

namespace SplatHex;
internal static class Class85 {
    public class PQ : Class25 {
        private static Dictionary<int, Class83> Hhj;
        public PQ(int int_0, int int_1, string string_0, Bitmap bitmap_0, int int_2, int int_3, int int_4, int int_5, bool bool_0 = false) : base(int_0, int_1, string_0, bitmap_0, int_2, Hhj[int_3], int_4, int_5, bool_0) {
        }

        public override bool AjTy() {
            if (!kDx && CDw < 20000) {
                return false;
            }

            return !wjTh();
        }

        public override bool CjTP() {
            return CDw == 26000;
        }

        public override bool wjTh() {
            if (CDw >= 21000) {
                return 22000 >= CDw;
            }

            return false;
        }

        public override int VjTo(int int_0) {
            if (AjTy()) {
                return int_0;
            }

            int_0++;
            switch (int_0) {
                case 14:
                    if (wjTh()) {
                        return 0;
                    }

                    if (tD6 == 0) {
                        return 100;
                    }

                    if (tD6 == 1) {
                        return 104;
                    }

                    if (tD6 == 2) {
                        return 109;
                    }

                    break;
                case 104:
                    return 0;
                case 108:
                    return 0;
                case 112:
                    return 0;
            }

            return int_0;
        }

        public override int tjTc(int int_0) {
            return (int_0 + 15) % 14;
        }

        public override int YjT9(int int_0) {
            if (AjTy()) {
                return int_0;
            }

            int_0--;
            switch (int_0) {
                case -1:
                    if (wjTh()) {
                        return 13;
                    }

                    if (tD6 == 0) {
                        return 103;
                    }

                    if (tD6 == 1) {
                        return 107;
                    }

                    if (tD6 == 2) {
                        return 111;
                    }

                    break;
                case 99:
                    return 13;
                case 103:
                    return 13;
                case 108:
                    return 13;
            }

            return int_0;
        }

        public override int bjTe(int int_0) {
            return (int_0 + 13) % 14;
        }

        public override bool mjTM(int int_0) {
            return int_0 >= WD9;
        }

        static PQ() {
            Hhj = new Dictionary<int, Class83>
            {
                {
                    0,
                    new Class83(0, Resources.B00_Splat2)
                },
                {
                    1,
                    new Class83(1, Resources.B01_Splat2)
                },
                {
                    2,
                    new Class83(2, Resources.B02_Splat2)
                },
                {
                    3,
                    new Class83(3, Resources.B03_Splat2)
                },
                {
                    4,
                    new Class83(4, Resources.B04_Splat2)
                },
                {
                    5,
                    new Class83(5, Resources.B05_Splat2)
                },
                {
                    6,
                    new Class83(6, Resources.B06_Splat2)
                },
                {
                    7,
                    new Class83(7, Resources.B07_Splat2)
                },
                {
                    8,
                    new Class83(8, Resources.B08_Splat2)
                },
                {
                    9,
                    new Class83(9, Resources.B09_Splat2)
                },
                {
                    10,
                    new Class83(10, Resources.B10_Splat2)
                },
                {
                    11,
                    new Class83(11, Resources.B11_Splat2)
                },
                {
                    15,
                    new Class83(15, Resources.B15_Splat2)
                },
                {
                    16,
                    new Class83(16, Resources.B16_Splat2)
                },
                {
                    17,
                    new Class83(17, Resources.B17_Splat2)
                },
                {
                    97,
                    new Class83(97, Resources.B97_Splat2)
                },
                {
                    98,
                    new Class83(98, Resources.B98_Splat2)
                },
                {
                    99,
                    new Class83(99, Resources.B99_Splat2)
                }
            };
        }
    }

    private const string Vh4 = "https://raw.githubusercontent.com/Leanny/leanny.github.io/master/splat2/gear/";
    public static Dictionary<int, Class25> hh5;
    public static Dictionary<int, Class25> Lhs;
    public static Dictionary<int, Class25> DhZ;
    public static int[] Sha;
    private static void Yhd(Dictionary<string, string> dictionary_0, List<Dictionary<string, object>> list_0, Dictionary<int, Class25> dictionary_1, object object_0, int int_0) {
        Dictionary<string, int> dictionary = new Dictionary<string, int>();
        List<Dictionary<string, object>> list = JsonConvert.DeserializeObject<List<Dictionary<string, object>>>(Encoding.Default.GetString(Resources.SkillInfo_byaml));
        foreach (Dictionary<string, object> item in list) {
            dictionary.Add((string)item["Name"], (int)(long)item["Id"]);
        }

        ResourceManager oKz = Resources.oKz;
        foreach (Dictionary<string, object> item2 in list_0) {
            if ("cImpossible".Equals(item2["HowToGet"])) {
                continue;
            }

            int num = (int)(long)item2["Id"];
            int int_1 = (int)(long)item2["Rarity"];
            string string_ = dictionary_0[(string)item2[(string)object_0]];
            Bitmap bitmap = (Bitmap)oKz.GetObject(string.Concat(item2["ModelName"], "_Splat2"));
            if (bitmap == null) {
                string text = string.Concat("img/", item2["ModelName"], ".png");
                if (!File.Exists(text)) {
                    using WebClient webClient = new WebClient();
                    webClient.DownloadFile(new Uri(string.Concat("https://raw.githubusercontent.com/Leanny/leanny.github.io/master/splat2/gear/", item2["ModelName"], ".png")), text);
                }

                bitmap = new Bitmap(text);
            }

            int int_2 = dictionary[(string)item2["Skill0"]];
            int int_3 = int.Parse(((string)item2["Brand"]).Substring(1));
            int num2;
            try {
                num2 = (int)(long)item2["Addition"];
            } catch (Exception) {
                num2 = int.Parse((string)item2["Addition"]);
            }

            string text2 = (string)item2["ModelName"];
            bool bool_ = (bool_ = "cOther".Equals(item2["HowToGet"]) && !text2.Contains("AMB") && (!text2.Contains("COP") || num2 >= Class26.QXu.UpS)) && (27000 > num || 27100 < num);
            PQ pQ = new PQ(num, int_1, string_, bitmap, int_2, int_3, int_0, num2, bool_);
            if (dictionary_1.ContainsKey(pQ.CDw)) {
                dictionary_1[pQ.CDw] = pQ;
            } else {
                dictionary_1.Add(pQ.CDw, pQ);
            }
        }
    }

    static Class85() {
        hh5 = new Dictionary<int, Class25>();
        Lhs = new Dictionary<int, Class25>();
        DhZ = new Dictionary<int, Class25>();
        Sha = new int[11]
        {
            25000,
            25001,
            25002,
            25003,
            25004,
            25005,
            27000,
            27004,
            27101,
            1,
            2
        };
        Dictionary<string, string> dictionary_ = Class127.BD8N(new MemoryStream(Resources.GearName_Head));
        Dictionary<string, string> dictionary_2 = Class127.BD8N(new MemoryStream(Resources.GearName_Clothes));
        Dictionary<string, string> dictionary_3 = Class127.BD8N(new MemoryStream(Resources.GearName_Shoes));
        List<Dictionary<string, object>> list_ = JsonConvert.DeserializeObject<List<Dictionary<string, object>>>(Encoding.Default.GetString(Resources.GearInfo_Head_byaml));
        List<Dictionary<string, object>> list_2 = JsonConvert.DeserializeObject<List<Dictionary<string, object>>>(Encoding.Default.GetString(Resources.GearInfo_Clothes_byaml));
        List<Dictionary<string, object>> list_3 = JsonConvert.DeserializeObject<List<Dictionary<string, object>>>(Encoding.Default.GetString(Resources.GearInfo_Shoes_byaml));
        Yhd(dictionary_, list_, hh5, "Name", 0);
        Yhd(dictionary_2, list_2, Lhs, "Name", 1);
        Yhd(dictionary_3, list_3, DhZ, "Name", 2);
        GhH();
    }

    private static void GhH() {
        if (File.Exists("json/lang_dict.json") && File.Exists("json/GearInfo_Clothes.json") && File.Exists("json/GearInfo_Head.json") && File.Exists("json/GearInfo_Shoes.json")) {
            Dictionary<string, string> dictionary_;
            using (StreamReader streamReader = new StreamReader("json/lang_dict.json")) {
                string value = streamReader.ReadToEnd();
                dictionary_ = JsonConvert.DeserializeObject<Dictionary<string, string>>(value);
            }

            List<Dictionary<string, object>> list_;
            using (StreamReader streamReader2 = new StreamReader("json/GearInfo_Clothes.json")) {
                string value2 = streamReader2.ReadToEnd();
                list_ = JsonConvert.DeserializeObject<List<Dictionary<string, object>>>(value2);
            }

            List<Dictionary<string, object>> list_2;
            using (StreamReader streamReader3 = new StreamReader("json/GearInfo_Head.json")) {
                string value3 = streamReader3.ReadToEnd();
                list_2 = JsonConvert.DeserializeObject<List<Dictionary<string, object>>>(value3);
            }

            List<Dictionary<string, object>> list_3;
            using (StreamReader streamReader4 = new StreamReader("json/GearInfo_Shoes.json")) {
                string value4 = streamReader4.ReadToEnd();
                list_3 = JsonConvert.DeserializeObject<List<Dictionary<string, object>>>(value4);
            }

            Yhd(dictionary_, list_2, hh5, "ModelName", 0);
            Yhd(dictionary_, list_, Lhs, "ModelName", 1);
            Yhd(dictionary_, list_3, DhZ, "ModelName", 2);
        }
    }
}