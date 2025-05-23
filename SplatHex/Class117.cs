using System.Collections.Generic;
using System.Drawing;

namespace SplatHex;
internal static class Class117 {
    public class vrh : Class25 {
        private static Dictionary<int, Class83> xoM;
        public vrh(int int_0, int int_1, string string_0, Bitmap bitmap_0, int int_2, int int_3, int int_4) : base(int_0, int_1, string_0, bitmap_0, int_2, xoM[int_3], int_4) {
        }

        public override bool CjTP() {
            return false;
        }

        public override bool AjTy() {
            return true;
        }

        public override bool wjTh() {
            return false;
        }

        public override int VjTo(int int_0) {
            return int_0;
        }

        public override int tjTc(int int_0) {
            return (int_0 + 14) % 13;
        }

        public override int YjT9(int int_0) {
            return int_0;
        }

        public override int bjTe(int int_0) {
            return (int_0 + 12) % 13;
        }

        public override bool mjTM(int int_0) {
            return true;
        }

        static vrh() {
            xoM = new Dictionary<int, Class83>
            {
                {
                    0,
                    new Class83(0, Resources.b00)
                },
                {
                    1,
                    new Class83(1, Resources.b01)
                },
                {
                    2,
                    new Class83(2, Resources.b02)
                },
                {
                    3,
                    new Class83(3, Resources.b03)
                },
                {
                    4,
                    new Class83(4, Resources.b04)
                },
                {
                    5,
                    new Class83(5, Resources.b05)
                },
                {
                    6,
                    new Class83(6, Resources.b06)
                },
                {
                    7,
                    new Class83(7, Resources.b07)
                },
                {
                    8,
                    new Class83(8, Resources.b08)
                },
                {
                    9,
                    new Class83(9, Resources.b09)
                },
                {
                    10,
                    new Class83(10, Resources.b10)
                },
                {
                    11,
                    new Class83(11, Resources.b11)
                },
                {
                    12,
                    new Class83(12, Resources.b12)
                },
                {
                    13,
                    new Class83(13, Resources.b13)
                },
                {
                    14,
                    new Class83(14, Resources.b14)
                },
                {
                    98,
                    new Class83(98, Resources.b98)
                },
                {
                    99,
                    new Class83(99, Resources.b99)
                }
            };
        }

        internal static bool CNj() {
            return true;
        }

        internal static bool mNE() {
            return false;
        }
    }

    public static Dictionary<int, int> Sox;
    public static Dictionary<int, int> Qo9;
    public static Dictionary<int, int> Yoc;
    public static Dictionary<int, Class25> eoy;
    public static Dictionary<int, Class25> qor;
    public static Dictionary<int, Class25> toq;
    public static int[] kok;
    static Class117() {
        eoy = new Dictionary<int, Class25>();
        qor = new Dictionary<int, Class25>();
        toq = new Dictionary<int, Class25>();
        kok = new int[6]
        {
            27000,
            28000,
            25000,
            25001,
            25002,
            1
        };
        vrh[] array = new vrh[70]
        {
            new vrh(1, 0, Class67.l8t.GetString("First1"), Resources.Hed_First, 4, 0, 0),
            new vrh(1000, 0, Class67.l8t.GetString("CAP000"), Resources.Hed_CAP000, 12, 7, 0),
            new vrh(1001, 0, Class67.l8t.GetString("CAP001"), Resources.Hed_CAP001, 6, 9, 0),
            new vrh(1002, 0, Class67.l8t.GetString("CAP002"), Resources.Hed_CAP002, 1, 11, 0),
            new vrh(1003, 0, Class67.l8t.GetString("CAP003"), Resources.Hed_CAP003, 3, 7, 0),
            new vrh(1004, 2, Class67.l8t.GetString("CAP004"), Resources.Hed_CAP004, 100, 7, 0),
            new vrh(1005, 1, Class67.l8t.GetString("CAP005"), Resources.Hed_CAP005, 7, 7, 0),
            new vrh(1006, 1, Class67.l8t.GetString("CAP006"), Resources.Hed_CAP006, 6, 6, 0),
            new vrh(1007, 1, Class67.l8t.GetString("CAP007"), Resources.Hed_CAP007, 103, 4, 0),
            new vrh(1008, 0, Class67.l8t.GetString("CAP008"), Resources.Hed_CAP008, 11, 4, 0),
            new vrh(1009, 0, Class67.l8t.GetString("CAP009"), Resources.Hed_CAP009, 9, 4, 0),
            new vrh(1010, 0, Class67.l8t.GetString("CAP010"), Resources.Hed_CAP010, 10, 2, 0),
            new vrh(1011, 0, Class67.l8t.GetString("CAP011"), Resources.Hed_CAP011, 10, 6, 0),
            new vrh(1012, 0, Class67.l8t.GetString("CAP012"), Resources.Hed_CAP012, 12, 1, 0),
            new vrh(1013, 1, Class67.l8t.GetString("CAP013"), Resources.Hed_CAP013, 100, 13, 0),
            new vrh(1014, 1, Class67.l8t.GetString("CAP014"), Resources.Hed_CAP014, 1, 10, 0),
            new vrh(1015, 2, Class67.l8t.GetString("CAP015"), Resources.Hed_CAP015, 0, 98, 0),
            new vrh(1016, 2, Class67.l8t.GetString("CAP016"), Resources.Hed_CAP016, 0, 4, 0),
            new vrh(2000, 1, Class67.l8t.GetString("NCP000"), Resources.Hed_NCP000, 11, 8, 0),
            new vrh(2001, 0, Class67.l8t.GetString("NCP001"), Resources.Hed_NCP001, 2, 9, 0),
            new vrh(2002, 1, Class67.l8t.GetString("NCP002"), Resources.Hed_NCP002, 100, 8, 0),
            new vrh(2003, 0, Class67.l8t.GetString("NCP003"), Resources.Hed_NCP003, 102, 7, 0),
            new vrh(2004, 2, Class67.l8t.GetString("NCP004"), Resources.Hed_NCP004, 100, 5, 0),
            new vrh(2005, 2, Class67.l8t.GetString("NCP005"), Resources.Hed_NCP005, 103, 7, 0),
            new vrh(3000, 0, Class67.l8t.GetString("EYE000"), Resources.Hed_EYE000, 9, 8, 0),
            new vrh(3001, 1, Class67.l8t.GetString("EYE001"), Resources.Hed_EYE001, 1, 5, 0),
            new vrh(3002, 2, Class67.l8t.GetString("EYE002"), Resources.Hed_EYE002, 12, 5, 0),
            new vrh(3003, 0, Class67.l8t.GetString("EYE003"), Resources.Hed_EYE003, 101, 4, 0),
            new vrh(3004, 1, Class67.l8t.GetString("EYE004"), Resources.Hed_EYE004, 102, 4, 0),
            new vrh(3005, 1, Class67.l8t.GetString("EYE005"), Resources.Hed_EYE005, 0, 5, 0),
            new vrh(3006, 2, Class67.l8t.GetString("EYE006"), Resources.Hed_EYE006, 8, 4, 0),
            new vrh(3007, 1, Class67.l8t.GetString("EYE007"), Resources.Hed_EYE007, 7, 10, 0),
            new vrh(3008, 2, Class67.l8t.GetString("EYE008"), Resources.Hed_EYE008, 101, 3, 0),
            new vrh(3009, 0, Class67.l8t.GetString("EYE009"), Resources.Hed_EYE009, 11, 2, 0),
            new vrh(3010, 2, Class67.l8t.GetString("EYE010"), Resources.Hed_EYE010, 101, 6, 0),
            new vrh(4000, 1, Class67.l8t.GetString("HAT000"), Resources.Hed_HAT000, 101, 5, 0),
            new vrh(4001, 2, Class67.l8t.GetString("HAT001"), Resources.Hed_HAT001, 2, 6, 0),
            new vrh(4002, 0, Class67.l8t.GetString("HAT002"), Resources.Hed_HAT002, 8, 9, 0),
            new vrh(4003, 0, Class67.l8t.GetString("HAT003"), Resources.Hed_HAT003, 4, 6, 0),
            new vrh(4004, 1, Class67.l8t.GetString("HAT004"), Resources.Hed_HAT004, 2, 9, 0),
            new vrh(4005, 0, Class67.l8t.GetString("HAT005"), Resources.Hed_HAT005, 11, 7, 0),
            new vrh(4006, 1, Class67.l8t.GetString("HAT006"), Resources.Hed_HAT006, 8, 7, 0),
            new vrh(4007, 1, Class67.l8t.GetString("HAT007"), Resources.Hed_HAT007, 4, 5, 0),
            new vrh(5000, 1, Class67.l8t.GetString("HDP000"), Resources.Hed_HDP000, 2, 5, 0),
            new vrh(5001, 1, Class67.l8t.GetString("HDP001"), Resources.Hed_HDP001, 3, 5, 0),
            new vrh(5002, 1, Class67.l8t.GetString("HDP002"), Resources.Hed_HDP002, 9, 5, 0),
            new vrh(6000, 0, Class67.l8t.GetString("VIS000"), Resources.Hed_VIS000, 5, 1, 0),
            new vrh(6001, 0, Class67.l8t.GetString("VIS001"), Resources.Hed_VIS001, 7, 6, 0),
            new vrh(6002, 1, Class67.l8t.GetString("VIS002"), Resources.Hed_VIS002, 12, 10, 0),
            new vrh(7000, 2, Class67.l8t.GetString("MET000"), Resources.Hed_MET000, 4, 7, 0),
            new vrh(7002, 2, Class67.l8t.GetString("MET002"), Resources.Hed_MET002, 6, 5, 0),
            new vrh(7003, 2, Class67.l8t.GetString("MET003"), Resources.Hed_MET003, 5, 5, 0),
            new vrh(7004, 1, Class67.l8t.GetString("MET004"), Resources.Hed_MET004, 10, 7, 0),
            new vrh(7005, 2, Class67.l8t.GetString("MET005"), Resources.Hed_MET005, 101, 7, 0),
            new vrh(8000, 2, Class67.l8t.GetString("MSK000"), Resources.Hed_MSK000, 102, 5, 0),
            new vrh(8001, 2, Class67.l8t.GetString("MSK001"), Resources.Hed_MSK001, 103, 5, 0),
            new vrh(8002, 0, Class67.l8t.GetString("MSK002"), Resources.Hed_MSK002, 3, 2, 0),
            new vrh(8003, 1, Class67.l8t.GetString("MSK003"), Resources.Hed_MSK003, 10, 5, 0),
            new vrh(9001, 0, Class67.l8t.GetString("HBD001"), Resources.Hed_HBD001, 100, 1, 0),
            new vrh(9002, 0, Class67.l8t.GetString("HBD002"), Resources.Hed_HBD002, 0, 1, 0),
            new vrh(9003, 0, Class67.l8t.GetString("HBD003"), Resources.Hed_HBD003, 103, 10, 0),
            new vrh(9004, 0, Class67.l8t.GetString("HBD004"), Resources.Hed_HBD004, 3, 4, 0),
            new vrh(9005, 2, Class67.l8t.GetString("HBD005"), Resources.Hed_HBD005, 102, 10, 0),
            new vrh(9006, 1, Class67.l8t.GetString("HBD006"), Resources.Hed_HBD006, 103, 14, 0),
            new vrh(25000, 1, Class67.l8t.GetString("AMB0001"), Resources.Hed_AMB000, 6, 99, 0),
            new vrh(25001, 1, Class67.l8t.GetString("AMB0011"), Resources.Hed_AMB001, 0, 99, 0),
            new vrh(25002, 1, Class67.l8t.GetString("AMB0021"), Resources.Hed_AMB002, 1, 99, 0),
            new vrh(27000, 1, Class67.l8t.GetString("MSN0001"), Resources.Hed_MSN000, 5, 98, 0),
            new vrh(27004, 2, Class67.l8t.GetString("MSN0041"), Resources.Hed_MSN004, 102, 98, 0),
            new vrh(28000, 1, Class67.l8t.GetString("RVL0001"), Resources.Hed_RVL000, 12, 98, 0)
        };
        vrh[] array2 = new vrh[122]
        {
            new vrh(1, 0, Class67.l8t.GetString("First"), Resources.Clt_First, 9, 0, 1),
            new vrh(1000, 0, Class67.l8t.GetString("TES000"), Resources.Clt_TES000, 3, 0, 1),
            new vrh(1001, 0, Class67.l8t.GetString("TES001"), Resources.Clt_TES001, 5, 10, 1),
            new vrh(1003, 0, Class67.l8t.GetString("TES003"), Resources.Clt_TES003, 104, 10, 1),
            new vrh(1004, 1, Class67.l8t.GetString("TES004"), Resources.Clt_TES004, 4, 3, 1),
            new vrh(1005, 0, Class67.l8t.GetString("TES005"), Resources.Clt_TES005, 0, 3, 1),
            new vrh(1006, 0, Class67.l8t.GetString("TES006"), Resources.Clt_TES006, 8, 0, 1),
            new vrh(1007, 0, Class67.l8t.GetString("TES007"), Resources.Clt_TES007, 7, 2, 1),
            new vrh(1008, 0, Class67.l8t.GetString("TES008"), Resources.Clt_TES008, 2, 2, 1),
            new vrh(1009, 2, Class67.l8t.GetString("TES009"), Resources.Clt_TES009, 10, 7, 1),
            new vrh(1010, 0, Class67.l8t.GetString("TES010"), Resources.Clt_TES010, 6, 6, 1),
            new vrh(1011, 0, Class67.l8t.GetString("TES011"), Resources.Clt_TES011, 1, 7, 1),
            new vrh(1012, 0, Class67.l8t.GetString("TES012"), Resources.Clt_TES012, 4, 7, 1),
            new vrh(1013, 0, Class67.l8t.GetString("TES013"), Resources.Clt_TES013, 2, 11, 1),
            new vrh(1014, 0, Class67.l8t.GetString("TES014"), Resources.Clt_TES014, 11, 11, 1),
            new vrh(1015, 0, Class67.l8t.GetString("TES015"), Resources.Clt_TES015, 3, 9, 1),
            new vrh(1016, 0, Class67.l8t.GetString("TES016"), Resources.Clt_TES016, 106, 9, 1),
            new vrh(1017, 0, Class67.l8t.GetString("TES017"), Resources.Clt_TES017, 6, 7, 1),
            new vrh(1018, 0, Class67.l8t.GetString("TES018"), Resources.Clt_TES018, 8, 8, 1),
            new vrh(1019, 0, Class67.l8t.GetString("TES019"), Resources.Clt_TES019, 5, 8, 1),
            new vrh(1020, 0, Class67.l8t.GetString("TES020"), Resources.Clt_TES020, 107, 6, 1),
            new vrh(1021, 0, Class67.l8t.GetString("TES021"), Resources.Clt_TES021, 1, 6, 1),
            new vrh(1022, 2, Class67.l8t.GetString("TES022"), Resources.Clt_TES022, 105, 0, 1),
            new vrh(1023, 1, Class67.l8t.GetString("TES023"), Resources.Clt_TES023, 107, 0, 1),
            new vrh(1024, 0, Class67.l8t.GetString("TES024"), Resources.Clt_TES024, 6, 12, 1),
            new vrh(1025, 0, Class67.l8t.GetString("TES025"), Resources.Clt_TES025, 10, 12, 1),
            new vrh(1026, 0, Class67.l8t.GetString("TES026"), Resources.Clt_TES026, 1, 6, 1),
            new vrh(1027, 0, Class67.l8t.GetString("TES027"), Resources.Clt_TES027, 3, 7, 1),
            new vrh(1028, 2, Class67.l8t.GetString("TES028"), Resources.Clt_TES028, 106, 98, 1),
            new vrh(1029, 0, Class67.l8t.GetString("TES029"), Resources.Clt_TES029, 105, 6, 1),
            new vrh(2000, 1, Class67.l8t.GetString("TEL000"), Resources.Clt_TEL000, 9, 8, 1),
            new vrh(2001, 1, Class67.l8t.GetString("TEL001"), Resources.Clt_TEL001, 11, 4, 1),
            new vrh(2002, 0, Class67.l8t.GetString("TEL002"), Resources.Clt_TEL002, 12, 11, 1),
            new vrh(2003, 1, Class67.l8t.GetString("TEL003"), Resources.Clt_TEL003, 0, 8, 1),
            new vrh(2004, 0, Class67.l8t.GetString("TEL004"), Resources.Clt_TEL004, 1, 4, 1),
            new vrh(2005, 0, Class67.l8t.GetString("TEL005"), Resources.Clt_TEL005, 107, 8, 1),
            new vrh(2006, 0, Class67.l8t.GetString("TEL006"), Resources.Clt_TEL006, 6, 3, 1),
            new vrh(2007, 0, Class67.l8t.GetString("TEL007"), Resources.Clt_TEL007, 11, 3, 1),
            new vrh(2008, 0, Class67.l8t.GetString("TEL008"), Resources.Clt_TEL008, 4, 0, 1),
            new vrh(2009, 0, Class67.l8t.GetString("TEL009"), Resources.Clt_TEL009, 105, 9, 1),
            new vrh(2010, 0, Class67.l8t.GetString("TEL010"), Resources.Clt_TEL010, 106, 0, 1),
            new vrh(2011, 0, Class67.l8t.GetString("TEL011"), Resources.Clt_TEL011, 8, 1, 1),
            new vrh(2012, 0, Class67.l8t.GetString("TEL012"), Resources.Clt_TEL012, 11, 9, 1),
            new vrh(3000, 0, Class67.l8t.GetString("TLY000"), Resources.Clt_TLY000, 10, 0, 1),
            new vrh(3001, 0, Class67.l8t.GetString("TLY001"), Resources.Clt_TLY001, 11, 0, 1),
            new vrh(3002, 0, Class67.l8t.GetString("TLY002"), Resources.Clt_TLY002, 7, 0, 1),
            new vrh(3003, 0, Class67.l8t.GetString("TLY003"), Resources.Clt_TLY003, 2, 0, 1),
            new vrh(3004, 0, Class67.l8t.GetString("TLY004"), Resources.Clt_TLY004, 0, 1, 1),
            new vrh(3005, 2, Class67.l8t.GetString("TLY005"), Resources.Clt_TLY005, 5, 0, 1),
            new vrh(3006, 1, Class67.l8t.GetString("TLY006"), Resources.Clt_TLY006, 3, 11, 1),
            new vrh(3007, 0, Class67.l8t.GetString("TLY007"), Resources.Clt_TLY007, 0, 10, 1),
            new vrh(3008, 1, Class67.l8t.GetString("TLY008"), Resources.Clt_TLY008, 10, 11, 1),
            new vrh(3009, 1, Class67.l8t.GetString("TLY009"), Resources.Clt_TLY009, 10, 5, 1),
            new vrh(4000, 0, Class67.l8t.GetString("PLO000"), Resources.Clt_PLO000, 105, 8, 1),
            new vrh(4001, 1, Class67.l8t.GetString("PLO001"), Resources.Clt_PLO001, 5, 11, 1),
            new vrh(4002, 0, Class67.l8t.GetString("PLO002"), Resources.Clt_PLO002, 9, 11, 1),
            new vrh(4003, 0, Class67.l8t.GetString("PLO003"), Resources.Clt_PLO003, 104, 8, 1),
            new vrh(4004, 0, Class67.l8t.GetString("PLO004"), Resources.Clt_PLO004, 107, 4, 1),
            new vrh(4005, 1, Class67.l8t.GetString("PLO005"), Resources.Clt_PLO005, 104, 1, 1),
            new vrh(4006, 2, Class67.l8t.GetString("PLO006"), Resources.Clt_PLO006, 1, 10, 1),
            new vrh(4007, 1, Class67.l8t.GetString("PLO007"), Resources.Clt_PLO007, 1, 11, 1),
            new vrh(4008, 0, Class67.l8t.GetString("PLO008"), Resources.Clt_PLO008, 0, 11, 1),
            new vrh(5000, 2, Class67.l8t.GetString("JKT000"), Resources.Clt_JKT000, 107, 9, 1),
            new vrh(5002, 1, Class67.l8t.GetString("JKT002"), Resources.Clt_JKT002, 8, 9, 1),
            new vrh(5003, 2, Class67.l8t.GetString("JKT003"), Resources.Clt_JKT003, 0, 4, 1),
            new vrh(5004, 1, Class67.l8t.GetString("JKT004"), Resources.Clt_JKT004, 105, 1, 1),
            new vrh(5005, 1, Class67.l8t.GetString("JKT005"), Resources.Clt_JKT005, 107, 8, 1),
            new vrh(5006, 2, Class67.l8t.GetString("JKT006"), Resources.Clt_JKT006, 12, 3, 1),
            new vrh(5007, 2, Class67.l8t.GetString("JKT007"), Resources.Clt_JKT007, 8, 3, 1),
            new vrh(5008, 2, Class67.l8t.GetString("JKT008"), Resources.Clt_JKT008, 9, 1, 1),
            new vrh(5009, 0, Class67.l8t.GetString("JKT009"), Resources.Clt_JKT009, 7, 8, 1),
            new vrh(5010, 1, Class67.l8t.GetString("JKT010"), Resources.Clt_JKT010, 5, 5, 1),
            new vrh(5011, 1, Class67.l8t.GetString("JKT011"), Resources.Clt_JKT011, 106, 5, 1),
            new vrh(5012, 2, Class67.l8t.GetString("JKT012"), Resources.Clt_JKT012, 12, 5, 1),
            new vrh(5013, 1, Class67.l8t.GetString("JKT013"), Resources.Clt_JKT013, 2, 5, 1),
            new vrh(5014, 2, Class67.l8t.GetString("JKT014"), Resources.Clt_JKT014, 9, 4, 1),
            new vrh(5015, 1, Class67.l8t.GetString("JKT015"), Resources.Clt_JKT015, 7, 4, 1),
            new vrh(5016, 0, Class67.l8t.GetString("JKT016"), Resources.Clt_JKT016, 5, 2, 1),
            new vrh(6000, 1, Class67.l8t.GetString("TNK000"), Resources.Clt_TNK000, 10, 1, 1),
            new vrh(6001, 0, Class67.l8t.GetString("TNK001"), Resources.Clt_TNK001, 3, 1, 1),
            new vrh(6002, 1, Class67.l8t.GetString("TNK002"), Resources.Clt_TNK002, 0, 13, 1),
            new vrh(7000, 0, Class67.l8t.GetString("SWT000"), Resources.Clt_SWT000, 6, 8, 1),
            new vrh(7001, 0, Class67.l8t.GetString("SWT001"), Resources.Clt_SWT001, 12, 0, 1),
            new vrh(7002, 2, Class67.l8t.GetString("SWT002"), Resources.Clt_SWT002, 1, 0, 1),
            new vrh(7003, 1, Class67.l8t.GetString("SWT003"), Resources.Clt_SWT003, 12, 6, 1),
            new vrh(7004, 0, Class67.l8t.GetString("SWT004"), Resources.Clt_SWT004, 0, 8, 1),
            new vrh(7005, 0, Class67.l8t.GetString("SWT005"), Resources.Clt_SWT005, 8, 4, 1),
            new vrh(7006, 1, Class67.l8t.GetString("SWT006"), Resources.Clt_SWT006, 104, 0, 1),
            new vrh(8000, 0, Class67.l8t.GetString("SHT000"), Resources.Clt_SHT000, 2, 3, 1),
            new vrh(8001, 0, Class67.l8t.GetString("SHT001"), Resources.Clt_SHT001, 11, 2, 1),
            new vrh(8002, 1, Class67.l8t.GetString("SHT002"), Resources.Clt_SHT002, 12, 4, 1),
            new vrh(8003, 1, Class67.l8t.GetString("SHT003"), Resources.Clt_SHT003, 4, 8, 1),
            new vrh(8004, 0, Class67.l8t.GetString("SHT004"), Resources.Clt_SHT004, 5, 1, 1),
            new vrh(8005, 0, Class67.l8t.GetString("SHT005"), Resources.Clt_SHT005, 4, 5, 1),
            new vrh(8006, 1, Class67.l8t.GetString("SHT006"), Resources.Clt_SHT006, 2, 4, 1),
            new vrh(8007, 1, Class67.l8t.GetString("SHT007"), Resources.Clt_SHT007, 1, 8, 1),
            new vrh(8008, 2, Class67.l8t.GetString("SHT008"), Resources.Clt_SHT008, 7, 6, 1),
            new vrh(8009, 1, Class67.l8t.GetString("SHT009"), Resources.Clt_SHT009, 11, 4, 1),
            new vrh(8010, 2, Class67.l8t.GetString("SHT010"), Resources.Clt_SHT010, 106, 3, 1),
            new vrh(8011, 0, Class67.l8t.GetString("SHT011"), Resources.Clt_SHT011, 3, 3, 1),
            new vrh(8012, 1, Class67.l8t.GetString("SHT012"), Resources.Clt_SHT012, 4, 4, 1),
            new vrh(8013, 1, Class67.l8t.GetString("SHT013"), Resources.Clt_SHT013, 11, 8, 1),
            new vrh(8014, 0, Class67.l8t.GetString("SHT014"), Resources.Clt_SHT014, 12, 8, 1),
            new vrh(8015, 2, Class67.l8t.GetString("SHT015"), Resources.Clt_SHT015, 10, 8, 1),
            new vrh(8016, 1, Class67.l8t.GetString("SHT016"), Resources.Clt_SHT016, 9, 14, 1),
            new vrh(9000, 2, Class67.l8t.GetString("VST000"), Resources.Clt_VST000, 6, 9, 1),
            new vrh(9001, 2, Class67.l8t.GetString("VST001"), Resources.Clt_VST001, 4, 9, 1),
            new vrh(9002, 2, Class67.l8t.GetString("VST002"), Resources.Clt_VST002, 104, 6, 1),
            new vrh(9003, 1, Class67.l8t.GetString("VST003"), Resources.Clt_VST003, 106, 6, 1),
            new vrh(9004, 0, Class67.l8t.GetString("VST004"), Resources.Clt_VST004, 8, 2, 1),
            new vrh(9005, 0, Class67.l8t.GetString("VST005"), Resources.Clt_VST005, 104, 2, 1),
            new vrh(10000, 2, Class67.l8t.GetString("PRK000"), Resources.Clt_PRK000, 9, 6, 1),
            new vrh(10001, 1, Class67.l8t.GetString("PRK001"), Resources.Clt_PRK001, 8, 6, 1),
            new vrh(10002, 1, Class67.l8t.GetString("PRK002"), Resources.Clt_PRK002, 105, 4, 1),
            new vrh(10003, 2, Class67.l8t.GetString("PRK003"), Resources.Clt_PRK003, 104, 4, 1),
            new vrh(25000, 1, Class67.l8t.GetString("AMB000"), Resources.Clt_AMB000, 4, 99, 1),
            new vrh(25001, 1, Class67.l8t.GetString("AMB001"), Resources.Clt_AMB001, 7, 99, 1),
            new vrh(25002, 1, Class67.l8t.GetString("AMB002"), Resources.Clt_AMB002, 9, 99, 1),
            new vrh(26000, 2, Class67.l8t.GetString("HAP000"), Resources.Clt_HAP000, 10, 0, 1),
            new vrh(27000, 1, Class67.l8t.GetString("MSN000"), Resources.Clt_MSN000, 6, 98, 1),
            new vrh(27004, 2, Class67.l8t.GetString("MSN004"), Resources.Clt_MSN004, 7, 98, 1),
            new vrh(28000, 1, Class67.l8t.GetString("RVL000"), Resources.Clt_RVL000, 3, 98, 1)
        };
        vrh[] array3 = new vrh[67]
        {
            new vrh(1, 0, Class67.l8t.GetString("First2"), Resources.Shs_First, 10, 2, 2),
            new vrh(1000, 0, Class67.l8t.GetString("SLO000"), Resources.Shs_SLO000, 1, 4, 2),
            new vrh(1001, 0, Class67.l8t.GetString("SLO001"), Resources.Shs_SLO001, 108, 2, 2),
            new vrh(1002, 2, Class67.l8t.GetString("SLO002"), Resources.Shs_SLO002, 3, 4, 2),
            new vrh(1003, 0, Class67.l8t.GetString("SLO003"), Resources.Shs_SLO003, 4, 1, 2),
            new vrh(1004, 0, Class67.l8t.GetString("SLO004"), Resources.Shs_SLO004, 6, 4, 2),
            new vrh(1005, 1, Class67.l8t.GetString("SLO005"), Resources.Shs_SLO005, 6, 1, 2),
            new vrh(1006, 0, Class67.l8t.GetString("SLO006"), Resources.Shs_SLO006, 7, 2, 2),
            new vrh(1007, 1, Class67.l8t.GetString("SLO007"), Resources.Shs_SLO007, 108, 1, 2),
            new vrh(1008, 2, Class67.l8t.GetString("SLO008"), Resources.Shs_SLO008, 3, 8, 2),
            new vrh(1009, 0, Class67.l8t.GetString("SLO009"), Resources.Shs_SLO009, 109, 8, 2),
            new vrh(1010, 2, Class67.l8t.GetString("SLO010"), Resources.Shs_SLO010, 108, 11, 2),
            new vrh(1011, 1, Class67.l8t.GetString("SLO011"), Resources.Shs_SLO011, 109, 11, 2),
            new vrh(2000, 0, Class67.l8t.GetString("SHI000"), Resources.Shs_SHI000, 2, 1, 2),
            new vrh(2001, 0, Class67.l8t.GetString("SHI001"), Resources.Shs_SHI001, 7, 1, 2),
            new vrh(2002, 0, Class67.l8t.GetString("SHI002"), Resources.Shs_SHI002, 110, 2, 2),
            new vrh(2003, 0, Class67.l8t.GetString("SHI003"), Resources.Shs_SHI003, 8, 1, 2),
            new vrh(2004, 0, Class67.l8t.GetString("SHI004"), Resources.Shs_SHI004, 4, 2, 2),
            new vrh(2005, 1, Class67.l8t.GetString("SHI005"), Resources.Shs_SHI005, 109, 2, 2),
            new vrh(2006, 1, Class67.l8t.GetString("SHI006"), Resources.Shs_SHI006, 5, 1, 2),
            new vrh(2007, 1, Class67.l8t.GetString("SHI007"), Resources.Shs_SHI007, 6, 13, 2),
            new vrh(2008, 0, Class67.l8t.GetString("SHI008"), Resources.Shs_SHI008, 12, 8, 2),
            new vrh(2009, 0, Class67.l8t.GetString("SHI009"), Resources.Shs_SHI009, 4, 8, 2),
            new vrh(3000, 0, Class67.l8t.GetString("SHT000"), Resources.Shs_SHT000, 12, 10, 2),
            new vrh(3001, 0, Class67.l8t.GetString("SHT001"), Resources.Shs_SHT001, 2, 11, 2),
            new vrh(3002, 0, Class67.l8t.GetString("SHT002"), Resources.Shs_SHT002, 109, 10, 2),
            new vrh(3003, 1, Class67.l8t.GetString("SHT003"), Resources.Shs_SHT003, 8, 11, 2),
            new vrh(3004, 0, Class67.l8t.GetString("SHT004"), Resources.Shs_SHT004, 0, 10, 2),
            new vrh(3005, 0, Class67.l8t.GetString("SHT005"), Resources.Shs_SHT005, 7, 10, 2),
            new vrh(3006, 2, Class67.l8t.GetString("SHT006"), Resources.Shs_SHT006, 10, 10, 2),
            new vrh(3007, 0, Class67.l8t.GetString("SHT007"), Resources.Shs_SHT007, 5, 10, 2),
            new vrh(3008, 2, Class67.l8t.GetString("SHT008"), Resources.Shs_SHT008, 110, 11, 2),
            new vrh(3009, 0, Class67.l8t.GetString("SHT009"), Resources.Shs_SHT009, 9, 10, 2),
            new vrh(4000, 0, Class67.l8t.GetString("SDL000"), Resources.Shs_SDL000, 5, 2, 2),
            new vrh(4001, 1, Class67.l8t.GetString("SDL001"), Resources.Shs_SDL001, 9, 2, 2),
            new vrh(4006, 1, Class67.l8t.GetString("SDL002"), Resources.Shs_SDL002, 5, 14, 2),
            new vrh(4002, 0, Class67.l8t.GetString("CFS000"), Resources.Shs_CFS000, 3, 2, 2),
            new vrh(4003, 1, Class67.l8t.GetString("CFS001"), Resources.Shs_CFS001, 0, 2, 2),
            new vrh(5000, 1, Class67.l8t.GetString("TRS000"), Resources.Shs_TRS000, 4, 9, 2),
            new vrh(5001, 1, Class67.l8t.GetString("TRS001"), Resources.Shs_TRS001, 8, 9, 2),
            new vrh(5002, 2, Class67.l8t.GetString("TRS002"), Resources.Shs_TRS002, 108, 9, 2),
            new vrh(6000, 1, Class67.l8t.GetString("BOT000"), Resources.Shs_BOT000, 9, 3, 2),
            new vrh(6001, 1, Class67.l8t.GetString("BOT001"), Resources.Shs_BOT001, 12, 3, 2),
            new vrh(6002, 2, Class67.l8t.GetString("BOT002"), Resources.Shs_BOT002, 11, 3, 2),
            new vrh(6003, 2, Class67.l8t.GetString("BOT003"), Resources.Shs_BOT003, 109, 3, 2),
            new vrh(6004, 1, Class67.l8t.GetString("BOT004"), Resources.Shs_BOT004, 110, 9, 2),
            new vrh(6005, 0, Class67.l8t.GetString("BOT005"), Resources.Shs_BOT005, 5, 9, 2),
            new vrh(6006, 1, Class67.l8t.GetString("BOT006"), Resources.Shs_BOT006, 7, 3, 2),
            new vrh(6007, 2, Class67.l8t.GetString("BOT007"), Resources.Shs_BOT007, 108, 3, 2),
            new vrh(6008, 1, Class67.l8t.GetString("BOT008"), Resources.Shs_BOT008, 10, 3, 2),
            new vrh(6009, 0, Class67.l8t.GetString("BOT009"), Resources.Shs_BOT009, 0, 9, 2),
            new vrh(6010, 2, Class67.l8t.GetString("BOT010"), Resources.Shs_BOT010, 11, 10, 2),
            new vrh(6011, 2, Class67.l8t.GetString("BOT011"), Resources.Shs_BOT011, 110, 10, 2),
            new vrh(7000, 0, Class67.l8t.GetString("SLP000"), Resources.Shs_SLP000, 12, 2, 2),
            new vrh(7001, 0, Class67.l8t.GetString("SLP001"), Resources.Shs_SLP001, 11, 2, 2),
            new vrh(7002, 1, Class67.l8t.GetString("SLP002"), Resources.Shs_SLP002, 1, 2, 2),
            new vrh(8000, 0, Class67.l8t.GetString("LTS000"), Resources.Shs_LTS000, 6, 3, 2),
            new vrh(8001, 1, Class67.l8t.GetString("LTS001"), Resources.Shs_LTS001, 110, 3, 2),
            new vrh(8002, 1, Class67.l8t.GetString("LTS002"), Resources.Shs_LTS002, 7, 3, 2),
            new vrh(8003, 0, Class67.l8t.GetString("LTS003"), Resources.Shs_LTS003, 9, 3, 2),
            new vrh(8004, 0, Class67.l8t.GetString("LTS004"), Resources.Shs_LTS004, 1, 3, 2),
            new vrh(25000, 1, Class67.l8t.GetString("AMB0002"), Resources.Shs_AMB000, 3, 99, 2),
            new vrh(25001, 1, Class67.l8t.GetString("AMB0012"), Resources.Shs_AMB001, 8, 99, 2),
            new vrh(25002, 1, Class67.l8t.GetString("AMB0022"), Resources.Shs_AMB002, 2, 99, 2),
            new vrh(27000, 1, Class67.l8t.GetString("MSN0002"), Resources.Shs_MSN000, 11, 98, 2),
            new vrh(27004, 2, Class67.l8t.GetString("MSN0042"), Resources.Shs_MSN004, 2, 98, 2),
            new vrh(28000, 1, Class67.l8t.GetString("RVL0002"), Resources.Shs_RVL000, 10, 98, 2)
        };
        Sox = new Dictionary<int, int>
        {
            {
                1015,
                50
            },
            {
                27004,
                25
            }
        };
        Qo9 = new Dictionary<int, int>
        {
            {
                1028,
                45
            },
            {
                27004,
                30
            }
        };
        Yoc = new Dictionary<int, int>
        {
            {
                27004,
                35
            }
        };
        vrh[] array4 = array;
        foreach (vrh vrh in array4) {
            eoy.Add(vrh.CDw, vrh);
        }

        vrh[] array5 = array2;
        foreach (vrh vrh2 in array5) {
            qor.Add(vrh2.CDw, vrh2);
        }

        vrh[] array6 = array3;
        foreach (vrh vrh3 in array6) {
            toq.Add(vrh3.CDw, vrh3);
        }
    }
}