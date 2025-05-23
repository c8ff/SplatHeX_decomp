using System.Collections.Generic;

namespace SplatHex;
internal class Class66 {
    public readonly List<Class66> tDki;
    private object cDkm;
    public readonly uint GDk0;
    public Class66() {
        tDki = new List<Class66>();
    }

    public Class66(object object_0) {
        cDkm = object_0;
        tDki = new List<Class66>();
    }

    public Class66(object object_0, uint uint_0) {
        cDkm = object_0;
        tDki = new List<Class66>();
        GDk0 = uint_0;
    }

    public void QDk7(Class66 uOG_0) {
        tDki.Add(uOG_0);
    }

    public void eDkP(object object_0) {
        cDkm = object_0;
    }

    public override string ToString() {
        return cDkm.ToString();
    }

    internal static bool r8B() {
        return false;
    }
}