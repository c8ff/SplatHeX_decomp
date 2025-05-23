namespace SplatHex;
internal static class Class129 {
    public static bool jXL(bool bool_0) {
        int num = 0;
        while (true) {
            if (num < Class108.Jo3.Length) {
                if (Class108.Jo3[num].hXP != -1) {
                    if (!Class4.rDg(Class108.Jo3[num].hXP, Class117.Sox)) {
                        break;
                    }

                    if (!Class117.eoy.ContainsKey(Class108.Jo3[num].hXP)) {
                        if (bool_0) {
                            return ShowMessage();
                        }

                        return true;
                    }
                }

                num++;
                continue;
            }

            int num2 = 0;
            while (true) {
                if (num2 < Class108.Yod.Length) {
                    if (Class108.Yod[num2].hXP != -1) {
                        if (!Class4.rDg(Class108.Yod[num2].hXP, Class117.Qo9)) {
                            break;
                        }

                        if (!Class117.qor.ContainsKey(Class108.Yod[num2].hXP)) {
                            if (bool_0) {
                                return ShowMessage();
                            }

                            return true;
                        }
                    }

                    num2++;
                    continue;
                }

                int num3 = 0;
                while (true) {
                    if (num3 < Class108.YoH.Length) {
                        if (Class108.YoH[num3].hXP != -1) {
                            if (!Class4.rDg(Class108.YoH[num3].hXP, Class117.Yoc)) {
                                break;
                            }

                            if (!Class117.toq.ContainsKey(Class108.YoH[num3].hXP)) {
                                if (bool_0) {
                                    return ShowMessage();
                                }

                                return true;
                            }
                        }

                        num3++;
                        continue;
                    }

                    int num4 = 0;
                    while (true) {
                        if (num4 < Class108.Vo4.Length) {
                            if (Class108.Vo4[num4].btx != -1) {
                                if (!Class22.vXO(Class108.Vo4[num4].btx)) {
                                    break;
                                }

                                if (!Class46.Lou.ContainsKey(Class108.Vo4[num4].btx)) {
                                    if (bool_0) {
                                        return ShowMessage();
                                    }

                                    return true;
                                }
                            }

                            num4++;
                            continue;
                        }

                        if (Class108.io2.Tti < 10 && (Class108.io2.TtR != 0 || Class108.io2.ftC != 0)) {
                            if (bool_0) {
                                return ShowMessage();
                            }

                            return true;
                        }

                        return false;
                    }

                    if (bool_0) {
                        return ShowMessage();
                    }

                    return true;
                }

                if (bool_0) {
                    return ShowMessage();
                }

                return true;
            }

            if (bool_0) {
                return ShowMessage();
            }

            return true;
        }

        if (bool_0) {
            return ShowMessage();
        }

        return true;
    }

    public static bool ShowMessage() {
        DialogResult dialogResult = MessageBox.Show("You own gear/weapons that you aren't supposed to own at your current level! Do you want to remove them?\n\nYou have the possibility of being banned if you play online with weapons or gear you aren't supposed to own/use.", "Remove any gear you aren't suppose to have?", MessageBoxButtons.YesNo);
        if (dialogResult == DialogResult.Yes) {
            return true;
        }

        return false;
    }
}