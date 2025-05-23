using System.IO;
using System.Windows.Forms;

namespace SplatHex;
internal class Class107 {
    public readonly Class66 UDkL;
    private uint KDkJ;
    public Class107(uint uint_0, Class128 mbz_0, TreeNode treeNode_0) {
        string object_ = mbz_0.sD7s(uint_0);
        uint uint_1 = uint_0 + (uint)Class13.Qpzp;
        uint kDkJ = mbz_0.cjJt(mbz_0.cjJt(uint_1) + 4);
        KDkJ = kDkJ;
        uint num = mbz_0.cjJt(mbz_0.cjJt(uint_1) + 8);
        MemoryStream memoryStream = new MemoryStream();
        mbz_0.hD7u(KDkJ, KDkJ + num, memoryStream);
        byte[] buffer = memoryStream.GetBuffer();
        byte[] bytes = Encoding.GetEncoding(Class13.OpzS).GetBytes(Encoding.Default.GetString(buffer));
        string string_ = Encoding.GetEncoding(Class13.Spzh).GetString(bytes);
        UDkL = new Class66(object_);
        sDkF(string_, 1, UDkL, treeNode_0);
    }

    private int sDkF(string string_0, int int_0, Class66 uOG_0, TreeNode treeNode_0) {
        int num = int_0;
        while (true) {
            if (num < string_0.Length) {
                if (string_0[num] == Class13.Kpzl) {
                    Class66 uOG_1 = new Class66();
                    TreeNode treeNode = new TreeNode();
                    num = sDkF(string_0, num + 1, uOG_1, treeNode);
                    uOG_0.QDk7(uOG_1);
                    treeNode_0.Nodes.Add(treeNode);
                } else if (string_0[num] == Class13.FpzG) {
                    int num2 = string_0.IndexOf((char)Class13.Jpzb, num);
                    string text = string_0.Substring(num + 1, num2 - num - 2);
                    uOG_0.eDkP(text);
                    treeNode_0.Text = text;
                    num = sDkF(string_0, num2 + 1, uOG_0, treeNode_0);
                } else {
                    if (string_0[num] >= Class13.epzv && string_0[num] <= Class13.Apzo) {
                        int num3 = string_0.IndexOf((char)Class13.Ypzt, num);
                        string[] array = string_0.Substring(num, num3 - num - 1).Split((char)Class13.fpzV);
                        uint num4 = (uint)num;
                        string[] array2 = array;
                        foreach (string text2 in array2) {
                            Class66 uOG = new Class66(text2, KDkJ + num4);
                            TreeNode treeNode2 = new TreeNode(text2);
                            treeNode2.Tag = uOG;
                            uOG_0.QDk7(uOG);
                            treeNode_0.Nodes.Add(treeNode2);
                            num4 += (uint)(text2.Length + 1);
                        }

                        return num3;
                    }

                    if (string_0[num] == Class13.FpzO) {
                        break;
                    }
                }

                num++;
                continue;
            }

            return Class13.fpze;
        }

        return num;
    }
}