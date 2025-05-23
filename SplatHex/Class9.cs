using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SplatHex;
[ComVisible(true)]
[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Parameter | AttributeTargets.Delegate, AllowMultiple = true, Inherited = false)]
internal sealed class Class9 : Attribute {
    private bool bST6 = true;
    private bool ISTx = true;
    private bool YST9 = true;
    private string CSTc = "";
    [SpecialName]
    public bool WSTC() {
        return bST6;
    }

    [SpecialName]
    public void VSTK(bool bool_0) {
        bST6 = bool_0;
    }

    [SpecialName]
    public bool mSTT() {
        return ISTx;
    }

    [SpecialName]
    public void OST1(bool bool_0) {
        ISTx = bool_0;
    }

    [SpecialName]
    public string fSTw() {
        return CSTc;
    }

    [SpecialName]
    public void eSTN(string string_0) {
        CSTc = string_0;
    }

    [SpecialName]
    public bool dSTB() {
        return YST9;
    }

    [SpecialName]
    public void BSTA(bool bool_0) {
        YST9 = bool_0;
    }

    internal static bool rp2() {
        return true;
    }
}