using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;

namespace SplatHex;
public class Class102 {
    [CompilerGenerated]
    private FileInfo hDn7;
    public Class58 vDnP = new Class58();
    public Class114 zDni = new Class114();
    public Class43 uDnm = new Class43();
    public Class10 GDn0 = new Class10();
    public Class53 JDnI = new Class53();
    public Class84 kDnR = new Class84();
    public Class50 tDnC = new Class50();
    public Encoding SDnK = Encoding.Unicode;
    public List<string> BDnU = new List<string>();
    public bool QDnT;
    private byte IDn1 = 171;
    public static uint kDnW;
    public static string rDnw;
    public FileInfo File {
        [CompilerGenerated]
        get {
            return hDn7;
        }

        [CompilerGenerated]
        set {
            hDn7 = value;
        }
    }

    private void SDnG(Stream stream_0) {
        Class91 a7W = new Class91(stream_0);
        zDni.OD8g = new List<Class49>();
        zDni.jD82 = new List<H7m>();
        tDnC.hDnp = new List<H7m>();
        tDnC.UDnS = new List<H7m>();
        vDnP.kD8Y = a7W.MD8P(8);
        if (vDnP.kD8Y != "MsgStdBn") {
            throw new Class12("The file provided is not a valid MSBT file.");
        }

        vDnP.xD8B = a7W.ReadBytes(2);
        a7W.bD8R((vDnP.xD8B[0] <= vDnP.xD8B[1]) ? ((q7J)1) : ((q7J)0));
        vDnP.hD8A = a7W.ReadUInt16();
        vDnP.AD8f = (V75)a7W.ReadByte();
        SDnK = ((vDnP.AD8f == (V75)0) ? Encoding.UTF8 : Encoding.Unicode);
        vDnP.uD86 = a7W.ReadByte();
        vDnP.jD8x = a7W.ReadUInt16();
        vDnP.qD89 = a7W.ReadUInt16();
        vDnP.CD8r = (uint)a7W.BaseStream.Position;
        vDnP.WD8c = a7W.ReadUInt32();
        vDnP.PD8y = a7W.ReadBytes(10);
        if (vDnP.WD8c != a7W.BaseStream.Length) {
            throw new Class12("The file provided is not a valid MSBT file.");
        }

        BDnU.Clear();
        for (int i = 0; i < vDnP.jD8x; i++) {
            switch (a7W.YD8m()) {
                case "TXT2":
                    SDne(a7W);
                    BDnU.Add("TXT2");
                    break;
                case "TSY1":
                    pDnO(a7W);
                    BDnU.Add("TSY1");
                    break;
                case "ATR1":
                    RDnV(a7W);
                    BDnU.Add("ATR1");
                    break;
                case "ATO1":
                    eDnt(a7W);
                    BDnU.Add("ATO1");
                    break;
                case "NLI1":
                    WDno(a7W);
                    BDnU.Add("NLI1");
                    break;
                case "LBL1":
                    aDnv(a7W);
                    BDnU.Add("LBL1");
                    break;
            }
        }

        a7W.Close();
    }

    public Class102(Stream stream_0) {
        SDnG(stream_0);
    }

    public Class102(string string_0) {
        File = new FileInfo(string_0);
        if (File.Exists && string_0.Length > 0) {
            FileStream stream_ = System.IO.File.Open(File.FullName, FileMode.Open, FileAccess.Read, FileShare.Read);
            SDnG(stream_);
        }
    }

    public uint LDnb(string string_0) {
        uint num = 0u;
        for (int i = 0; i < string_0.Length; i++) {
            num *= 1170;
            num += string_0[i];
            num &= 0xFFFFFFFFu;
        }

        return num % zDni.gD8u;
    }

    private void aDnv(Class91 a7W_0) {
        zDni.RD8q = a7W_0.MD8P(4);
        zDni.mD8k = a7W_0.ReadUInt32();
        zDni.OD8M = a7W_0.ReadBytes(8);
        long position = a7W_0.BaseStream.Position;
        zDni.gD8u = a7W_0.ReadUInt32();
        for (int i = 0; i < zDni.gD8u; i++) {
            Class49 q7P = new Class49();
            q7P.kD83 = a7W_0.ReadUInt32();
            q7P.sD8d = a7W_0.ReadUInt32();
            zDni.OD8g.Add(q7P);
        }

        foreach (Class49 item in zDni.OD8g) {
            a7W_0.BaseStream.Seek(position + item.sD8d, SeekOrigin.Begin);
            for (int j = 0; j < item.kD83; j++) {
                Class29 t = new Class29();
                t.ED84 = Convert.ToUInt32(a7W_0.ReadByte());
                t.cD85 = a7W_0.MD8P((int)t.ED84);
                t.Index = a7W_0.ReadUInt32();
                t.vD8s = (uint)zDni.OD8g.IndexOf(item);
                zDni.jD82.Add(t);
            }
        }

        foreach (Class29 item2 in zDni.jD82) {
            uint vD8s = item2.vD8s;
            item2.vD8s = LDnb(item2.cD85);
            if (vD8s != item2.vD8s) {
                zDni.OD8g[(int)vD8s].kD83--;
                zDni.OD8g[(int)item2.vD8s].kD83++;
            }
        }

        if (zDni.jD82.Count > 0) {
            QDnT = true;
        }

        LDn8(a7W_0);
    }

    private void WDno(Class91 a7W_0) {
        uDnm.RD8q = a7W_0.MD8P(4);
        uDnm.mD8k = a7W_0.ReadUInt32();
        uDnm.OD8M = a7W_0.ReadBytes(8);
        uDnm.JD8a = a7W_0.ReadBytes((int)uDnm.mD8k);
        LDn8(a7W_0);
    }

    private void eDnt(Class91 a7W_0) {
        GDn0.RD8q = a7W_0.MD8P(4);
        GDn0.mD8k = a7W_0.ReadUInt32();
        GDn0.OD8M = a7W_0.ReadBytes(8);
        GDn0.fD8j = a7W_0.ReadBytes((int)GDn0.mD8k);
    }

    private void RDnV(Class91 a7W_0) {
        JDnI.RD8q = a7W_0.MD8P(4);
        JDnI.mD8k = a7W_0.ReadUInt32();
        JDnI.OD8M = a7W_0.ReadBytes(8);
        JDnI.lD8z = a7W_0.ReadUInt32();
        JDnI.kDnE = a7W_0.ReadBytes((int)(JDnI.mD8k - 4));
        LDn8(a7W_0);
    }

    private void pDnO(Class91 a7W_0) {
        kDnR.RD8q = a7W_0.MD8P(4);
        kDnR.mD8k = a7W_0.ReadUInt32();
        kDnR.OD8M = a7W_0.ReadBytes(8);
        kDnR.jDnD = a7W_0.ReadBytes((int)kDnR.mD8k);
        LDn8(a7W_0);
    }

    private void SDne(Class91 a7W_0) {
        tDnC.RD8q = a7W_0.MD8P(4);
        tDnC.mD8k = a7W_0.ReadUInt32();
        tDnC.OD8M = a7W_0.ReadBytes(8);
        long position = a7W_0.BaseStream.Position;
        tDnC.EDnX = a7W_0.ReadUInt32();
        List<uint> list = new List<uint>();
        for (int i = 0; i < tDnC.EDnX; i++) {
            list.Add(a7W_0.ReadUInt32());
        }

        for (int j = 0; j < tDnC.EDnX; j++) {
            Class44 s7A = new Class44();
            uint num = ((j + 1 < list.Count) ? ((uint)(int)position + list[j + 1]) : ((uint)(int)position + tDnC.mD8k));
            a7W_0.BaseStream.Seek(position + list[j], SeekOrigin.Begin);
            List<byte> list2 = new List<byte>();
            while (a7W_0.BaseStream.Position < num && a7W_0.BaseStream.Position < vDnP.WD8c) {
                if (vDnP.AD8f == (V75)0) {
                    list2.Add(a7W_0.ReadByte());
                    continue;
                }

                byte[] array = a7W_0.ReadBytes(2);
                if (a7W_0.eD8I() == (q7J)1) {
                    Array.Reverse(array);
                }

                list2.AddRange(array);
            }

            s7A.Value = list2.ToArray();
            s7A.Index = (uint)j;
            tDnC.UDnS.Add(s7A);
            Class44 s7A2 = new Class44();
            s7A2.Value = s7A.Value;
            s7A2.Index = s7A.Index;
            tDnC.hDnp.Add(s7A2);
        }

        foreach (Class29 item in zDni.jD82) {
            item.dD8Z = tDnC.hDnp[(int)item.Index];
        }

        LDn8(a7W_0);
    }

    private void LDn8(Class91 a7W_0) {
        long num = a7W_0.BaseStream.Position % 16L;
        if (num > 0L) {
            IDn1 = a7W_0.ReadByte();
            a7W_0.BaseStream.Seek(-1L, SeekOrigin.Current);
            a7W_0.BaseStream.Seek(16L - num, SeekOrigin.Current);
        }
    }

    public Class29 oDnn(string string_0) {
        Class44 s7A = new Class44();
        s7A.Value = new byte[0];
        tDnC.hDnp.Add(s7A);
        Class44 s7A2 = new Class44();
        s7A2.Value = s7A.Value;
        tDnC.UDnS.Add(s7A2);
        Class29 t = new Class29();
        t.ED84 = (uint)string_0.Trim().Length;
        t.cD85 = string_0.Trim();
        t.Index = (uint)tDnC.hDnp.IndexOf(s7A);
        t.vD8s = LDnb(string_0.Trim());
        t.dD8Z = s7A;
        zDni.jD82.Add(t);
        zDni.OD8g[(int)t.vD8s].kD83++;
        JDnI.lD8z++;
        tDnC.EDnX++;
        return t;
    }

    public void IDnQ(Class29 t79_0, string string_0) {
        t79_0.ED84 = (uint)Encoding.ASCII.GetBytes(string_0.Trim()).Length;
        t79_0.cD85 = string_0.Trim();
        zDni.OD8g[(int)t79_0.vD8s].kD83--;
        t79_0.vD8s = LDnb(string_0.Trim());
        zDni.OD8g[(int)t79_0.vD8s].kD83++;
    }

    public void jDnF(Class29 t79_0) {
        int num = tDnC.hDnp.IndexOf((H7m)t79_0.dD8Z);
        for (int i = 0; i < tDnC.EDnX; i++) {
            if (zDni.jD82[i].Index > num) {
                zDni.jD82[i].Index--;
            }
        }

        zDni.OD8g[(int)t79_0.vD8s].kD83--;
        zDni.jD82.Remove(t79_0);
        JDnI.lD8z--;
        tDnC.hDnp.RemoveAt((int)t79_0.Index);
        tDnC.UDnS.RemoveAt((int)t79_0.Index);
        tDnC.EDnX--;
    }

    static Class102() {
        kDnW = 64u;
        rDnw = "^[a-zA-Z0-9_]+$";
    }
}