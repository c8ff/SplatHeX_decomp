namespace SplatHex;
internal class Class48 {
    private uint[] NDnB;
    public Class48(uint uint_0, uint uint_1, uint uint_2, uint uint_3) {
        NDnB = new uint[4]
        {
            uint_0,
            uint_1,
            uint_2,
            uint_3
        };
    }

    public Class48(uint uint_0) {
        uint[] array = new uint[5]
        {
            uint_0,
            0u,
            0u,
            0u,
            0u
        };
        for (uint num = 1u; num < 5; num++) {
            array[num] = 1812433253 * (array[num - 1] ^ (array[num - 1] >> 30)) + num;
        }

        NDnB = new uint[4]
        {
            array[1],
            array[2],
            array[3],
            array[4]
        };
    }

    public uint kDnN() {
        uint num = NDnB[0] ^ (NDnB[0] << 11);
        NDnB[0] = NDnB[1];
        uint num2 = NDnB[3];
        uint num3 = num ^ (num >> 8) ^ num2 ^ (num2 >> 19);
        NDnB[1] = NDnB[2];
        NDnB[2] = num2;
        NDnB[3] = num3;
        return num3;
    }

    public ulong IDnY() {
        uint num = NDnB[1];
        uint num2 = NDnB[0] ^ (NDnB[0] << 11);
        uint num3 = NDnB[3];
        NDnB[0] = NDnB[2];
        NDnB[1] = num3;
        uint num4 = num2 ^ (num2 >> 8) ^ num3;
        uint num5 = num4 ^ (num3 >> 19);
        uint num6 = num ^ (num << 11) ^ ((num ^ (num << 11)) >> 8) ^ num5 ^ (num4 >> 19);
        NDnB[2] = num5;
        NDnB[3] = num6;
        return num6 | ((ulong)num5 << 32);
    }
}