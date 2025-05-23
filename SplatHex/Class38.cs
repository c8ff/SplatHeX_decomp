using System.Drawing;

namespace SplatHex;
internal static class Class38 {
    public static Image LnD(object object_0, int int_0) {
        if (object_0 is Class108.fr2) {
            return RnX(int_0);
        }

        if (object_0 is Class26.P4) {
            return Jnp(int_0);
        }

        return null;
    }

    public static Image RnX(int int_0) {
        return int_0 switch {
            100 => Resources.startallup,
            101 => Resources.endallup,
            102 => Resources.minorityup,
            103 => Resources.comeback,
            104 => Resources.markingcance,
            105 => Resources.squidmovespatter_reduction,
            106 => Resources.deathmarking,
            107 => Resources.respawnradar,
            108 => Resources.trapdetect,
            109 => Resources.enemyinkeffect_reduction,
            110 => Resources.superjumpsign_hide,
            0 => Resources.attack_up,
            1 => Resources.defense_up,
            2 => Resources.mainink_save,
            3 => Resources.subink_save,
            4 => Resources.inkrecovery_up,
            5 => Resources.humanmove_up,
            6 => Resources.squidmove_up,
            7 => Resources.specialincrease_up,
            8 => Resources.specialtime_up,
            9 => Resources.respawntime_save,
            10 => Resources.respawnspecialgauge_save,
            11 => Resources.jumptime_save,
            12 => Resources.bombdistance_up,
            _ => Resources.unknown,
        };
    }

    public static Image Jnp(int int_0, bool bool_0 = true) {
        switch (int_0) {
            default:
                return Resources.unknown;
            case 100:
                return Resources.StartAllUp_Splat2;
            case 101:
                return Resources.EndAllUp_Splat2;
            case 102:
                return Resources.MinorityUp_Splat2;
            case 103:
                return Resources.ComeBack_Splat2;
            case 104:
                return Resources.SquidMoveSpatter_Reduction_Splat2;
            case 105:
                return Resources.DeathMarking_Splat2;
            case 106:
                return Resources.ThermalInk_Splat2;
            case 107:
                return Resources.Exorcist_Splat2;
            case 108:
                return Resources.ExSkillDouble_Splat2;
            case 109:
                return Resources.SuperJumpSign_Hide_Splat2;
            case 110:
                return Resources.ObjectEffect_Up_Splat2;
            case 111:
                return Resources.SomersaultLanding_Splat2;
            case 0:
                return Resources.MainInk_Save_Splat2;
            case 1:
                return Resources.SubInk_Save_Splat2;
            case 2:
                return Resources.InkRecovery_Up_Splat2;
            case 3:
                return Resources.HumanMove_Up_Splat2;
            case 4:
                return Resources.SquidMove_Up_Splat2;
            case 5:
                return Resources.SpecialIncrease_Up_Splat2;
            case 6:
                return Resources.RespawnSpecialGauge_Save_Splat2;
            case 7:
                return Resources.SpecialTime_Up_Splat2;
            case 8:
                return Resources.RespawnTime_Save_Splat2;
            case 9:
                return Resources.JumpTime_Save_Splat2;
            case 10:
                return Resources.BombDistance_Up_Splat2;
            case 11:
                return Resources.OpInkEffect_Reduction_Splat2;
            case 12:
                if (!bool_0) {
                    return Resources.BombDamage_Reduction_Splat2;
                }

                return Resources.BombDamage_Reduction2;
            case 13:
                if (bool_0) {
                    return Resources.MarkingTime_Reduction2;
                }

                return Resources.MarkingTime_Reduction_Splat2;
        }
    }

    public static Image anS(uint uint_0) {
        return uint_0 switch {
            0u => Resources.hairgirl_0,
            1u => Resources.hairgirl_1,
            2u => Resources.hairboy_0,
            3u => Resources.hairboy_1,
            4u => Resources.hairgirl_2,
            5u => Resources.hairboy_2,
            6u => Resources.hairgirl_3,
            7u => Resources.hairboy_3,
            _ => Resources.unknown,
        };
    }

    public static Image Dnh(int int_0) {
        return int_0 switch {
            2 => Resources.CapsuleIcon_00,
            3 => Resources.CapsuleIcon_01,
            4 => Resources.CapsuleIcon_02,
            5 => Resources.CapsuleIcon_03,
            6 => Resources.CapsuleIcon_04,
            _ => Resources.CapsuleIcon_05,
        };
    }

    public static Image vnl(int int_0) {
        return int_0 switch {
            0 => Resources.wsb_bomb_throw,
            1 => Resources.wsb_bomb_hold,
            2 => Resources.wsb_bomb_handy,
            3 => Resources.wsb_bomb_chase,
            4 => Resources.wsb_markingba,
            5 => Resources.wsb_timertrap,
            6 => Resources.wsb_sprinkler,
            7 => Resources.wsb_flag,
            8 => Resources.wsb_shield,
            9 => Resources.wsb_devilba,
            _ => Resources.unknown,
        };
    }

    public static Image TnG(int int_0) {
        return int_0 switch {
            0 => Resources.wsp_supershot,
            1 => Resources.wsp_biglaser,
            2 => Resources.wsp_tornado,
            3 => Resources.wsp_barrier,
            5 => Resources.wsp_kingsquid,
            6 => Resources.wsp_allmarking,
            _ => Resources.unknown,
        };
    }

    public static Image Cnb(int int_0) {
        return int_0 switch {
            0 => Resources.wsp_freebombs_bomb_throw,
            1 => Resources.wsp_freebombs_bomb_hold,
            2 => Resources.wsp_freebombs_bomb_handy,
            3 => Resources.wsp_freebombs_bomb_chase,
            _ => Resources.unknown,
        };
    }

    public static Image Mnv(int int_0) {
        return int_0 switch {
            0 => Resources.Wsb_Bomb_Splash_Splat2,
            1 => Resources.Wsb_Bomb_Suction_Splat2,
            2 => Resources.Wsb_Bomb_Quick_Splat2,
            3 => Resources.Wsb_Bomb_Curling_Splat2,
            4 => Resources.Wsb_Bomb_Robo_Splat2,
            5 => Resources.Wsb_TimerTrap_Splat2,
            6 => Resources.Wsb_Sprinkler_Splat2,
            7 => Resources.Wsb_PoisonFog_Splat2,
            8 => Resources.Wsb_PointSensor_Splat2,
            9 => Resources.Wsb_Shield_Splat2,
            10 => Resources.Wsb_Flag_Splat2,
            11 => Resources.Wsb_Bomb_Piyo_Splat2,
            12 => Resources.Wsb_Bomb_Tako,
            _ => Resources.unknown,
        };
    }

    public static Image dno(int int_0) {
        return int_0 switch {
            0 => Resources.Wsp_SuperMissile_Splat2,
            1 => Resources.Wsp_SuperArmor_Splat2,
            2 => Resources.Wsp_LauncherSplash_Splat2,
            3 => Resources.Wsp_LauncherSuction_Splat2,
            4 => Resources.Wsp_LauncherQuick_Splat2,
            5 => Resources.Wsp_LauncherCurling_Splat2,
            6 => Resources.Wsp_LauncherRobo_Splat2,
            7 => Resources.Wsp_WaterCutter_Splat2,
            8 => Resources.Wsp_Jetpack_Splat2,
            9 => Resources.Wsp_SuperLanding_Splat2,
            10 => Resources.Wsp_RainCloud_Splat2,
            11 => Resources.Wsp_AquaBall_Splat2,
            12 => Resources.Wsp_SuperBubble_Splat2,
            17 => Resources.Wsp_SuperBall_Splat2,
            18 => Resources.Wsp_SuperStamp,
            _ => Resources.unknown,
        };
    }

    internal static bool HZJ() {
        return true;
    }
}