using System;
using System.Collections.Generic;
using System.Globalization;

namespace SplatHex;
public class Class28 {
    public class XOu {
        public readonly Class113 kDkl;
        public readonly string LDkG;
        public XOu(Class113 jB2_0, string string_0) {
            kDkl = jB2_0;
            LDkG = string_0;
        }

        public override string ToString() {
            return LDkG;
        }

        internal static bool o8j() {
            return true;
        }
    }

    public List<string> UDkS;
    public List<List<XOu>> cDkh;
    public Class28(string string_0) {
        string[] array = string_0.Split(new string[1] { Environment.NewLine }, StringSplitOptions.None);
        UDkS = new List<string>();
        cDkh = new List<List<XOu>>();
        string text = null;
        string[] array2 = array;
        int num = 0;
        while (true) {
            if (num >= array2.Length) {
                return;
            }

            string text2 = array2[num];
            if (text2.Length != 0) {
                char c = text2[0];
                if (c != Class13.apjm) {
                    if (c != Class13.Fpj0) {
                        uint uint_ = uint.Parse(text2.Substring(0, 8), (NumberStyles)Class13.spjR);
                        uint uint_2 = uint.Parse(text2.Substring(Class13.XpjC, 8), (NumberStyles)Class13.apjK);
                        uint uint_3 = uint.Parse(text2.Substring(Class13.dpjU, 8), (NumberStyles)Class13.FpjT);
                        cDkh[cDkh.Count - 1].Add(new XOu(new Class113(uint_, uint_3, uint_2, 0), text));
                        text = null;
                    } else {
                        if (text != null) {
                            break;
                        }

                        text = text2.Substring(2);
                    }
                } else {
                    UDkS.Add(text2.Substring(1, text2.Length - 2));
                    cDkh.Add(new List<XOu>());
                }
            }

            num++;
        }

        throw new Exception(Class13.npjI);
    }
}