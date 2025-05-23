using System;
using System.Collections.Generic;
using System.Globalization;

namespace SplatHex;
public class Class110 {
    public List<uint> vDn5;
    private string BDns;
    public Class110(string string_0) {
        vDn5 = new List<uint>();
        string[] array = string_0.Split(new string[1] { Environment.NewLine }, StringSplitOptions.None);
        foreach (string text in array) {
            if (text.Length > 0) {
                if (text[0] == Class13.GDMI) {
                    BDns = text.Substring(1, text.IndexOf((char)Class13.iDMR) - 1);
                    continue;
                }

                string[] array2 = text.Split((char)Class13.FDMC);
                vDn5.Add(uint.Parse(array2[0], (NumberStyles)Class13.LDMK));
                vDn5.Add(uint.Parse(array2[1], (NumberStyles)Class13.iDMU));
            }
        }
    }

    public uint jDn4(Class128 mbz_0, uint uint_0) {
        foreach (uint item in vDn5) {
            mbz_0.tjJs(uint_0, item);
            uint_0 += 4;
        }

        return uint_0;
    }

    public override string ToString() {
        return BDns;
    }
}