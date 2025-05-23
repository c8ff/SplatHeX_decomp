using System;
using System.Globalization;
using System.Windows.Forms;

namespace SplatHex;
internal class Class116 {
    private enum LOw {
    }

    private string YDkw;
    private Class36 CDkN;
    private LOw nDkY;
    private uint bDkB;
    public Class116(string string_0) {
        //IL_00da: Expected O, but got I4
        //IL_00ac: Expected O, but got I4
        string[] array = string_0.Split(new string[1] { Environment.NewLine }, StringSplitOptions.None);
        YDkw = array[0].Substring(1, array[0].Length - 2);
        string[] array2 = array[1].Split((char)Class13.xpz8);
        CDkN = new Class36(array2[0]);
        int num = array2[1].IndexOf((char)Class13.Tpzn);
        string text = array2[1].Substring(0, num).Replace(Class13.zpzQ, Class13.cpzF);
        char c = array2[1].Substring(num)[1];
        if (c != Class13.lpzL) {
            if (c == Class13.wpzJ) {
                nDkY = (LOw)1;
                if (text.StartsWith(Class13.mpz7)) {
                    text = text.Substring(2);
                }

                bDkB = uint.Parse(text, (NumberStyles)Class13.XpzP);
            }
        } else {
            nDkY = (LOw)0;
            float float_ = float.Parse(text);
            bDkB = Class70.nDnj(float_);
        }
    }

    public void nDkR(ListViewItem listViewItem_0, string string_0) {
        //IL_006d: Expected O, but got I4
        //IL_0018: Expected O, but got I4
        LOw lOw = nDkY;
        if ((object)lOw != null) {
            if ((nint)lOw == 1) {
                nDkY = (LOw)1;
                if (string_0.StartsWith(Class13.ipzi)) {
                    string_0 = string_0.Substring(2);
                }

                bDkB = uint.Parse(string_0, (NumberStyles)Class13.Rpzm);
                listViewItem_0.SubItems[1].Text = string.Format(Class13.Jpz0, bDkB);
            }
        } else {
            nDkY = (LOw)0;
            float float_ = float.Parse(string_0);
            bDkB = Class70.nDnj(float_);
            listViewItem_0.SubItems[1].Text = string.Concat(Class70.gDna(bDkB));
        }
    }

    public ListViewItem CDkC() {
        ListViewItem listViewItem = new ListViewItem(YDkw, 0);
        if ((nint)nDkY == 1) {
            listViewItem.SubItems.Add(string.Format(Class13.zpzI, bDkB));
        }

        if ((object)nDkY == null) {
            listViewItem.SubItems.Add(string.Concat(Class70.gDna(bDkB)));
        }

        listViewItem.SubItems.Add(nDkY.ToString());
        listViewItem.SubItems.Add(Class13.fpzR);
        listViewItem.SubItems.Add(Class13.zpzC);
        listViewItem.Tag = this;
        return listViewItem;
    }

    public void vDkK(ListViewItem listViewItem_0) {
        //IL_0047: Expected O, but got I4
        //IL_0018: Expected O, but got I4
        if ((object)nDkY != null) {
            if ((nint)nDkY == 1) {
                nDkY = (LOw)0;
                listViewItem_0.SubItems[1].Text = string.Concat(Class70.gDna(bDkB));
            }
        } else {
            nDkY = (LOw)1;
            listViewItem_0.SubItems[1].Text = string.Format(Class13.DpzK, bDkB);
        }

        listViewItem_0.SubItems[2].Text = nDkY.ToString();
    }

    public string KDkU() {
        if ((nint)nDkY == 1) {
            return string.Format(Class13.IpzU, bDkB);
        }

        return string.Concat(Class70.gDna(bDkB));
    }

    public bool BDkT() {
        return (nint)nDkY == 1;
    }

    public void UDk1(Class128 mbz_0) {
        mbz_0.tjJs(CDkN.cDQG(mbz_0), bDkB);
    }

    internal void CDkW(Class128 mbz_0, ListViewItem listViewItem_0) {
        bDkB = mbz_0.cjJt(CDkN.cDQG(mbz_0));
        if ((nint)nDkY == 1) {
            listViewItem_0.SubItems[1].Text = string.Format(Class13.HpzT, bDkB);
        }

        if ((object)nDkY == null) {
            listViewItem_0.SubItems[1].Text = string.Concat(Class70.gDna(bDkB));
        }
    }
}