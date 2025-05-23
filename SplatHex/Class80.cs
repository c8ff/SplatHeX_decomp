using System.Drawing;

namespace SplatHex;
public class Class80 {
    public readonly string dDQE;
    public readonly uint gDQD;
    public readonly Image PDQX;
    public readonly uint[] FDQp;
    public Class80(string string_0, Image image_0, uint uint_0) {
        dDQE = string_0;
        gDQD = uint_0;
        PDQX = image_0;
    }

    public Class80(string string_0, Image image_0, uint uint_0, uint[] uint_1) {
        dDQE = string_0;
        gDQD = uint_0;
        PDQX = image_0;
        FDQp = uint_1;
    }

    public override string ToString() {
        return dDQE;
    }
}