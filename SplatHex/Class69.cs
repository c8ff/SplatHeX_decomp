using System;
using System.IO;

namespace SplatHex;
public class Class69 : Class128 {
    private byte[] RDQ0;
    private int xDQI;
    public Class69() {
        RDQ0 = new byte[Class13.EDut];
    }

    public Class69(string string_0) {
        RDQ0 = File.ReadAllBytes(string_0);
        ADQm(Class13.UDuV);
    }

    public override bool hjJp() {
        return true;
    }

    public override gBH LjJv() {
        //IL_0002: Expected O, but got I4
        return (gBH)0;
    }

    public override void MjJO(uint uint_0, uint uint_1, Stream[] stream_0) {
        QD7r();
        stream_0[0].Write(RDQ0, (int)(uint_0 + xDQI), (int)(uint_1 - uint_0));
    }

    public override void ijJX() {
    }

    public override void tjJs(uint uint_0, uint uint_1) {
        QjJU(uint_0, uint_1);
    }

    public override void QjJU(uint uint_0, uint uint_1) {
        int num = (int)uint_0 + xDQI;
        RDQ0[num + 3] = (byte)(uint_1 & (uint)Class13.wDuO);
        RDQ0[num + 2] = (byte)((uint_1 >> 8) & (uint)Class13.xDue);
        RDQ0[num + 1] = (byte)((uint_1 >> (int)Class13.cDu8) & (uint)Class13.HDun);
        RDQ0[num] = (byte)((uint_1 >> (int)Class13.dDuQ) & (uint)Class13.aDuF);
    }

    public override void ojJW(uint uint_0, ushort ushort_0) {
        int num = (int)uint_0 + xDQI;
        RDQ0[num + 1] = (byte)(ushort_0 & Class13.sDuL);
        RDQ0[num] = (byte)((ushort_0 >> 8) & Class13.VDuJ);
    }

    public override void NjJY(uint uint_0, byte byte_0) {
        int num = (int)uint_0 + xDQI;
        RDQ0[num] = byte_0;
    }

    public override uint cjJt(uint uint_0) {
        return NjJb(uint_0);
    }

    public override uint NjJb(uint uint_0) {
        return Class112.FDQP(BitConverter.ToUInt32(RDQ0, (int)uint_0 + xDQI));
    }

    public override uint pjJd(string string_0) {
        Class36 sBh = new Class36(string_0);
        uint num = sBh.GDQS();
        int[] array = sBh.EDQl();
        uint num2 = num;
        int[] array2 = array;
        int num3 = 0;
        while (true) {
            if (num3 < array2.Length) {
                uint num4 = (uint)array2[num3];
                num2 = NjJb(num2);
                if (num2 < (uint)Class13.xDu7 || num2 > (uint)Class13.CDuP) {
                    break;
                }

                num2 += num4;
                num3++;
                continue;
            }

            return num2;
        }

        return uint.MaxValue;
    }

    public override uint JjJA(uint uint_0) {
        uint fDui = (uint)Class13.fDui;
        int zDum = Class13.zDum;
        return (cjJt(uint_0) & fDui) >> (zDum & Class13.jDu0);
    }

    private void ADQm(int int_0) {
        xDQI = int_0;
    }
}