using System.Drawing;
using System.Runtime.CompilerServices;

namespace SplatHex;
internal struct uBw {
    public string WD7Q;
    private Color KD7F;
    [SpecialName]
    public string method_0() {
        return WD7Q;
    }

    [SpecialName]
    public Color method_1() {
        return KD7F;
    }

    [SpecialName]
    public void method_2(Color color_0) {
        KD7F = color_0;
    }

    [SpecialName]
    public string method_3() {
        return Class13.BDgO + KD7F.R.ToString(Class13.ODge, null) + KD7F.G.ToString(Class13.yDg8, null) + KD7F.B.ToString(Class13.zDgn, null);
    }

    [SpecialName]
    public void method_4(string string_0) {
        try {
            KD7F = ColorTranslator.FromHtml(string_0);
        } catch {
        }
    }

    public uBw(string string_0, Color color_0) {
        WD7Q = string_0;
        KD7F = color_0;
    }

    internal static bool lUf() {
        return true;
    }

    internal static bool vUl() {
        return false;
    }
}