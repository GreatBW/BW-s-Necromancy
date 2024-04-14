// Copyright (C)
// See LICENSE file for extended copyright information.
// This file is part of the repository from .

using ModShardLauncher;
using ModShardLauncher.Mods;
using UndertaleModLib.Models;
using System.Collections.Generic;
using System.IO;
using System;
using System.Linq;

namespace Necromancy;
static class StringExtensions
{
    public static IEnumerable<int> AllIndicesOf(this string text, string pattern)
    {
        if (string.IsNullOrEmpty(pattern))
        {
            throw new ArgumentNullException(pattern);
        }
        return Kmp(text, pattern);
    }

    private static IEnumerable<int> Kmp(string text, string pattern)
    {
        int M = pattern.Length;
        int N = text.Length;

        int[] lps = LongestPrefixSuffix(pattern);
        int i = 0, j = 0; 

        while (i < N)
        {
            if (pattern[j] == text[i])
            {
                j++;
                i++;
            }
            if (j == M)
            {
                yield return i - j;
                j = lps[j - 1];
            }

            else if (i < N && pattern[j] != text[i])
            {
                if (j != 0)
                {
                    j = lps[j - 1];
                }
                else
                {
                    i++;
                }
            }
        }
    }

    private static int[] LongestPrefixSuffix(string pattern)
    {
        int[] lps = new int[pattern.Length];
        int length = 0;
        int i = 1;

        while (i < pattern.Length)
        {
            if (pattern[i] == pattern[length])
            {
                length++;
                lps[i] = length;
                i++;
            }
            else
            {
                if (length != 0)
                {
                    length = lps[length - 1];
                }
                else
                {
                    lps[i] = length;
                    i++;
                }
            }
        }
        return lps;
    }
}
public class Necromancy : Mod
{
    public override string Author => "BW, CommissarAmethyst, zizani";
    public override string Name => "Necromancy";
    public override string Description => "mod_description";
    public override string Version => "0.2.0.0";
    public override string TargetVersion => "0.8.2.10";

    public override void PatchMod()
    {

        UndertaleGameObject o_skill_death_plague_ico = Msl.AddObject(
            name: "o_skill_death_plague_ico", 
            spriteName: "s_soul_abs", 
            parentName: "o_skill_ico", 
            isVisible: true, 
            isPersistent: false, 
            isAwake: false,
            collisionShapeFlags: CollisionShapeFlags.Circle
        );

        UndertaleGameObject o_skill_soul_explosion_ico = Msl.AddObject(
            name: "o_skill_soul_explosion_ico", 
            spriteName: "s_soulzac", 
            parentName: "o_skill_passive", 
            isVisible: true, 
            isPersistent: false, 
            isAwake: true,
            collisionShapeFlags: CollisionShapeFlags.Circle
        );

        UndertaleGameObject o_skill_Lostsouls_ico = Msl.AddObject(
            name: "o_skill_Lostsouls_ico", 
            spriteName: "s_disasterundead", 
            parentName: "o_skill_ico", 
            isVisible: true, 
            isPersistent: false, 
            isAwake: true,
            collisionShapeFlags: CollisionShapeFlags.Circle
        );

        UndertaleGameObject o_skill_bw_resurrection_ico = Msl.AddObject(
            name: "o_skill_bw_resurrection_ico", 
            spriteName: "s_recurct", 
            parentName: "o_skill_ico", 
            isVisible: true, 
            isPersistent: false, 
            isAwake: true,
            collisionShapeFlags: CollisionShapeFlags.Circle
        );

        UndertaleGameObject o_skill_bw_wraithsummon_ico = Msl.AddObject(
            name: "o_skill_bw_wraithsummon_ico", 
            spriteName: "s_wraithbind", 
            parentName: "o_skill_ico", 
            isVisible: true, 
            isPersistent: false, 
            isAwake: true,
            collisionShapeFlags: CollisionShapeFlags.Circle
        );

        UndertaleGameObject o_bw_curse_ico = Msl.AddObject(
            name: "o_bw_curse_ico", 
            spriteName: "s_pcurse", 
            parentName: "o_skill_ico", 
            isVisible: true, 
            isPersistent: false, 
            isAwake: true,
            collisionShapeFlags: CollisionShapeFlags.Circle
        );

        UndertaleGameObject o_bw_darkbolt_ico = Msl.AddObject(
            name: "o_bw_darkbolt_ico", 
            spriteName: "s_darkbalz", 
            parentName: "o_skill_ico", 
            isVisible: true, 
            isPersistent: false, 
            isAwake: true,
            collisionShapeFlags: CollisionShapeFlags.Circle
        );

        UndertaleGameObject o_bw_dark_bless_ico = Msl.AddObject(
            name: "o_bw_dark_bless_ico", 
            spriteName: "s_blusss", 
            parentName: "o_skill_ico", 
            isVisible: true, 
            isPersistent: false, 
            isAwake: true,
            collisionShapeFlags: CollisionShapeFlags.Circle
        );

        UndertaleGameObject o_skill_bw_touch_ico = Msl.AddObject(
            name: "o_skill_bw_touch_ico", 
            spriteName: "s_dtouch", 
            parentName: "o_skill_ico", 
            isVisible: true, 
            isPersistent: false, 
            isAwake: true,
            collisionShapeFlags: CollisionShapeFlags.Circle
        );

        Msl.AddFunction(ModFiles.GetCode("gml_GlobalScript_scr_bw_checker.gml"), "scr_bw_checker");
        Msl.AddFunction(ModFiles.GetCode("gml_GlobalScript_scr_bw_targeter.gml"), "scr_bw_targeter");

        Msl.GetObject("o_attitudes_menu").Sprite = Msl.GetSprite("s_big_att_menu");
        Msl.GetObject("o_b_magic_unholy").Sprite = Msl.GetSprite("s_b_sealofpower_unholy");
        
        Msl.AddObject(
            name: "o_inv_cgrimoir", 
            spriteName: "s_inv_cg01", 
            parentName: "o_inv_magic_treatise", 
            isVisible: true, 
            isPersistent: true, 
            isAwake: true,
            collisionShapeFlags: CollisionShapeFlags.Circle
        ).ApplyEvent(ModFiles, 
            new MslEvent("gml_Object_o_inv_cgrimoir_Create_0.gml", EventType.Create, 0),
            new MslEvent("gml_Object_o_inv_cgrimoir_Other_10.gml", EventType.Other, 10),
            new MslEvent("gml_Object_o_inv_cgrimoir_Draw_73.gml", EventType.Draw, 73),
            new MslEvent("gml_Object_o_inv_cgrimoir_PreCreate_0.gml", EventType.PreCreate, 0)
        );

        Msl.AddObject(
            name: "o_inv_cgrimoir2", 
            spriteName: "s_inv_cg02", 
            parentName: "o_inv_magic_treatise", 
            isVisible: true, 
            isPersistent: true, 
            isAwake: true,
            collisionShapeFlags: CollisionShapeFlags.Circle
        ).ApplyEvent(ModFiles, 
            new MslEvent("gml_Object_o_inv_cgrimoir2_Create_0.gml", EventType.Create, 0),
            new MslEvent("gml_Object_o_inv_cgrimoir2_Other_10.gml", EventType.Other, 10),
            new MslEvent("gml_Object_o_inv_cgrimoir2_Draw_73.gml", EventType.Draw, 73),
            new MslEvent("gml_Object_o_inv_cgrimoir2_PreCreate_0.gml", EventType.PreCreate, 0)
        );

        Msl.AddObject(
            name: "o_inv_cgrimoir3", 
            spriteName: "s_inv_cg03", 
            parentName: "o_inv_magic_treatise", 
            isVisible: true, 
            isPersistent: true, 
            isAwake: true,
            collisionShapeFlags: CollisionShapeFlags.Circle
        ).ApplyEvent(ModFiles, 
            new MslEvent("gml_Object_o_inv_cgrimoir3_Create_0.gml", EventType.Create, 0),
            new MslEvent("gml_Object_o_inv_cgrimoir3_Other_10.gml", EventType.Other, 10),
            new MslEvent("gml_Object_o_inv_cgrimoir3_Draw_73.gml", EventType.Draw, 73),
            new MslEvent("gml_Object_o_inv_cgrimoir3_PreCreate_0.gml", EventType.PreCreate, 0)
        );

        Msl.AddObject(
            name: "o_loot_cgrimoir", 
            spriteName: "s_loot_cg", 
            parentName: "o_consument_loot", 
            isVisible: true, 
            isPersistent: false, 
            isAwake: true,
            collisionShapeFlags: CollisionShapeFlags.Circle
        ).ApplyEvent(ModFiles, 
            new MslEvent("gml_Object_o_loot_cgrimoir_Create_0.gml", EventType.Create, 0),
            new MslEvent("gml_Object_o_loot_cgrimoir_PreCreate_0.gml", EventType.PreCreate, 0)
        );
        
        Msl.AddObject(
            name: "o_loot_cgrimoir2", 
            spriteName: "s_loot_cg", 
            parentName: "o_consument_loot", 
            isVisible: true, 
            isPersistent: false, 
            isAwake: true,
            collisionShapeFlags: CollisionShapeFlags.Circle
        ).ApplyEvent(ModFiles, 
            new MslEvent("gml_Object_o_loot_cgrimoir2_Create_0.gml", EventType.Create, 0),
            new MslEvent("gml_Object_o_loot_cgrimoir2_PreCreate_0.gml", EventType.PreCreate, 0)
        );

        Msl.AddObject(
            name: "o_loot_cgrimoir3", 
            spriteName: "s_loot_cg", 
            parentName: "o_consument_loot", 
            isVisible: true, 
            isPersistent: false, 
            isAwake: true,
            collisionShapeFlags: CollisionShapeFlags.Circle
        ).ApplyEvent(ModFiles, 
            new MslEvent("gml_Object_o_loot_cgrimoir3_Create_0.gml", EventType.Create, 0),
            new MslEvent("gml_Object_o_loot_cgrimoir3_PreCreate_0.gml", EventType.PreCreate, 0)
        );

        Msl.AddObject(
            name: "o_mortal_blocker", 
            spriteName: "", 
            parentName: "", 
            isVisible: false, 
            isPersistent: false, 
            isAwake: true,
            collisionShapeFlags: CollisionShapeFlags.Circle
        ).ApplyEvent(ModFiles, 
            new MslEvent("gml_Object_o_mortal_blocker_Create_0.gml", EventType.Create, 0),
            new MslEvent("gml_Object_o_mortal_blocker_Alarm_1.gml", EventType.Alarm, 1),
            new MslEvent("gml_Object_o_mortal_blocker_PreCreate_0.gml", EventType.PreCreate, 0)
        );

        Msl.AddObject(
            name: "o_res_buff_creator", 
            spriteName: "", 
            parentName: "", 
            isVisible: false, 
            isPersistent: true, 
            isAwake: true,
            collisionShapeFlags: CollisionShapeFlags.Circle
        ).ApplyEvent(ModFiles, 
            new MslEvent("gml_Object_o_res_buff_creator_Create_0.gml", EventType.Create, 0),
            new MslEvent("gml_Object_o_res_buff_creator_Alarm_1.gml", EventType.Alarm, 1),
            new MslEvent("gml_Object_o_res_buff_creator_Alarm_2.gml", EventType.Alarm, 2),
            new MslEvent("gml_Object_o_res_buff_creator_PreCreate_0.gml", EventType.PreCreate, 0)
        );

        Msl.AddObject(
            name: "o_undead_fixer", 
            spriteName: "", 
            parentName: "", 
            isVisible: false, 
            isPersistent: false, 
            isAwake: true,
            collisionShapeFlags: CollisionShapeFlags.Circle
        ).ApplyEvent(ModFiles, 
            new MslEvent("gml_Object_o_undead_fixer_Create_0.gml", EventType.Create, 0),
            new MslEvent("gml_Object_o_undead_fixer_Alarm_1.gml", EventType.Alarm, 1),
            new MslEvent("gml_Object_o_undead_fixer_Alarm_2.gml", EventType.Alarm, 2),
            new MslEvent("gml_Object_o_undead_fixer_PreCreate_0.gml", EventType.PreCreate, 0)
        );

        Msl.AddObject(
            name: "o_soul_destroyer", 
            spriteName: "", 
            parentName: "", 
            isVisible: false, 
            isPersistent: false, 
            isAwake: true,
            collisionShapeFlags: CollisionShapeFlags.Circle
        ).ApplyEvent(ModFiles, 
            new MslEvent("gml_Object_o_soul_destroyer_Create_0.gml", EventType.Create, 0),
            new MslEvent("gml_Object_o_soul_destroyer_Alarm_1.gml", EventType.Alarm, 1)
        );

        Msl.AddObject(
            name: "o_res_new01", 
            spriteName: "s_res_new", 
            parentName: "", 
            isVisible: true, 
            isPersistent: false, 
            isAwake: true,
            collisionShapeFlags: CollisionShapeFlags.Circle
        ).ApplyEvent(ModFiles, 
            new MslEvent("gml_Object_o_res_new01_Create_0.gml", EventType.Create, 0),
            new MslEvent("gml_Object_o_res_new01_Other_7.gml", EventType.Other, 7),
            new MslEvent("gml_Object_o_res_new01_Draw_0.gml", EventType.Draw, 0)
        );
                    
        Msl.AddObject(
            name: "o_trashy_corpz", 
            spriteName: "s_fleshpile_rotten", 
            parentName: "", 
            isVisible: true, 
            isPersistent: false, 
            isAwake: true,
            collisionShapeFlags: CollisionShapeFlags.Circle
        ).ApplyEvent(ModFiles, 
            new MslEvent("gml_Object_o_trashy_corpz_Create_0.gml", EventType.Create, 0),
            new MslEvent("gml_Object_o_trashy_corpz_Alarm_0.gml", EventType.Alarm, 0)
        );

        Msl.AddObject(
            name: "o_Lostsouls", 
            spriteName: "", 
            parentName: "", 
            isVisible: true, 
            isPersistent: false, 
            isAwake: true,
            collisionShapeFlags: CollisionShapeFlags.Circle
        ).ApplyEvent(ModFiles, 
            new MslEvent("gml_Object_o_Lostsouls_Create_0.gml", EventType.Create, 0),
            new MslEvent("gml_Object_o_Lostsouls_Destroy_0.gml", EventType.Destroy, 0),
            new MslEvent("gml_Object_o_Lostsouls_Alarm_0.gml", EventType.Alarm, 0),
            new MslEvent("gml_Object_o_Lostsouls_Alarm_10.gml", EventType.Alarm, 10),
            new MslEvent("gml_Object_o_Lostsouls_PreCreate_0.gml", EventType.PreCreate, 0)
        );

        Msl.AddObject(
            name: "o_absorption_soul", 
            spriteName: "s_essence_leech_cast", 
            parentName: "o_magic_pillar", 
            isVisible: true, 
            isPersistent: false, 
            isAwake: true,
            collisionShapeFlags: CollisionShapeFlags.Circle
        ).ApplyEvent(ModFiles, 
            new MslEvent("gml_Object_o_absorption_soul_Create_0.gml", EventType.Create, 0),
            new MslEvent("gml_Object_o_absorption_soul_Destroy_0.gml", EventType.Destroy, 0),
            new MslEvent("gml_Object_o_absorption_soul_Alarm_0.gml", EventType.Alarm, 0),
            new MslEvent("gml_Object_o_absorption_soul_Alarm_10.gml", EventType.Alarm, 10),
            new MslEvent("gml_Object_o_absorption_soul_Alarm_2.gml", EventType.Alarm, 2),
            new MslEvent("gml_Object_o_absorption_soul_PreCreate_0.gml", EventType.PreCreate, 0)
        );

        Msl.AddObject(
            name: "o_b_servemaster", 
            spriteName: "s_zompie_passiveskill", 
            parentName: "o_class_skills", 
            isVisible: true, 
            isPersistent: false, 
            isAwake: true,
            collisionShapeFlags: CollisionShapeFlags.Circle
        ).ApplyEvent(ModFiles, 
            new MslEvent("gml_Object_o_b_servemaster_Create_0.gml", EventType.Create, 0),
            new MslEvent("gml_Object_o_b_servemaster_Alarm_2.gml", EventType.Alarm, 2),
            new MslEvent("gml_Object_o_b_servemaster_Alarm_7.gml", EventType.Alarm, 7),
            new MslEvent("gml_Object_o_b_servemaster_Alarm_6.gml", EventType.Alarm, 6),
            new MslEvent("gml_Object_o_b_servemaster_Alarm_8.gml", EventType.Alarm, 8),
            new MslEvent("gml_Object_o_b_servemaster_Step_0.gml", EventType.Step, 0),
            new MslEvent("gml_Object_o_b_servemaster_Mouse_54.gml", EventType.Mouse, 54),
            new MslEvent("gml_Object_o_b_servemaster_Other_10.gml", EventType.Other, 10),
            new MslEvent("gml_Object_o_b_servemaster_KeyPress_86.gml", EventType.KeyPress, 86),
            new MslEvent("gml_Object_o_b_servemaster_PreCreate_0.gml", EventType.PreCreate, 0)
        );

        Msl.AddObject(
            name: "o_b_Lostsouls", 
            spriteName: "", 
            parentName: "o_class_skills", 
            isVisible: false, 
            isPersistent: false, 
            isAwake: true,
            collisionShapeFlags: CollisionShapeFlags.Circle
        ).ApplyEvent(ModFiles, 
            new MslEvent("gml_Object_o_b_Lostsouls_Create_0.gml", EventType.Create, 0),
            new MslEvent("gml_Object_o_b_Lostsouls_Alarm_2.gml", EventType.Alarm, 2),
            new MslEvent("gml_Object_o_b_Lostsouls_Other_10.gml", EventType.Other, 10)
        );

        Msl.AddObject(
            name: "o_b_unbind", 
            spriteName: "s_db_curse_new", 
            parentName: "o_class_skills", 
            isVisible: true, 
            isPersistent: false, 
            isAwake: true,
            collisionShapeFlags: CollisionShapeFlags.Circle
        ).ApplyEvent(ModFiles, 
            new MslEvent("gml_Object_o_b_unbind_Create_0.gml", EventType.Create, 0),
            new MslEvent("gml_Object_o_b_unbind_Mouse_53.gml", EventType.Mouse, 53),
            new MslEvent("gml_Object_o_b_unbind_Other_10.gml", EventType.Other, 10)
        );

                    Msl.AddObject(
                        name: "o_db_punishment", 
                        spriteName: "s_buff_punish", 
                        parentName: "o_class_skills", 
                        isVisible: true, 
                        isPersistent: false, 
                        isAwake: true,
                        collisionShapeFlags: CollisionShapeFlags.Circle
                    ).ApplyEvent(ModFiles, 
                        new MslEvent("gml_Object_o_db_punishment_Create_0.gml", EventType.Create, 0),
new MslEvent("gml_Object_o_db_punishment_Alarm_2.gml", EventType.Alarm, 2),
new MslEvent("gml_Object_o_db_punishment_Other_10.gml", EventType.Other, 10),
new MslEvent("gml_Object_o_db_punishment_PreCreate_0.gml", EventType.PreCreate, 0)
                    );
                    Msl.AddObject(
                        name: "o_db_takeover", 
                        spriteName: "s_take_over_effect", 
                        parentName: "o_mental_debuff", 
                        isVisible: true, 
                        isPersistent: false, 
                        isAwake: true,
                        collisionShapeFlags: CollisionShapeFlags.Circle
                    ).ApplyEvent(ModFiles, 
                        new MslEvent("gml_Object_o_db_takeover_Create_0.gml", EventType.Create, 0),
new MslEvent("gml_Object_o_db_takeover_Destroy_0.gml", EventType.Destroy, 0),
new MslEvent("gml_Object_o_db_takeover_Alarm_2.gml", EventType.Alarm, 2),
new MslEvent("gml_Object_o_db_takeover_Other_10.gml", EventType.Other, 10)
                    );
                    Msl.AddObject(
                        name: "o_b_exceptional", 
                        spriteName: "s_exception_soulus", 
                        parentName: "o_magical_buff", 
                        isVisible: true, 
                        isPersistent: false, 
                        isAwake: true,
                        collisionShapeFlags: CollisionShapeFlags.Circle
                    ).ApplyEvent(ModFiles, 
                        new MslEvent("gml_Object_o_b_exceptional_Create_0.gml", EventType.Create, 0),
new MslEvent("gml_Object_o_b_exceptional_Destroy_0.gml", EventType.Destroy, 0),
new MslEvent("gml_Object_o_b_exceptional_Alarm_2.gml", EventType.Alarm, 2),
new MslEvent("gml_Object_o_b_exceptional_Other_10.gml", EventType.Other, 10),
new MslEvent("gml_Object_o_b_exceptional_PreCreate_0.gml", EventType.PreCreate, 0)
                    );
                    Msl.AddObject(
                        name: "o_b_charged_soul", 
                        spriteName: "s_charged_z", 
                        parentName: "o_buff_stage", 
                        isVisible: true, 
                        isPersistent: false, 
                        isAwake: true,
                        collisionShapeFlags: CollisionShapeFlags.Circle
                    ).ApplyEvent(ModFiles, 
                        new MslEvent("gml_Object_o_b_charged_soul_Create_0.gml", EventType.Create, 0),
new MslEvent("gml_Object_o_b_charged_soul_Alarm_2.gml", EventType.Alarm, 2),
new MslEvent("gml_Object_o_b_charged_soul_Alarm_3.gml", EventType.Alarm, 3),
new MslEvent("gml_Object_o_b_charged_soul_Step_2.gml", EventType.Step, 2),
new MslEvent("gml_Object_o_b_charged_soul_Other_10.gml", EventType.Other, 10),
new MslEvent("gml_Object_o_b_charged_soul_Other_14.gml", EventType.Other, 14),
new MslEvent("gml_Object_o_b_charged_soul_PreCreate_0.gml", EventType.PreCreate, 0)
                    );
                    Msl.AddObject(
                        name: "o_b_angel_charm", 
                        spriteName: "s_buff_punish", 
                        parentName: "o_magical_buff", 
                        isVisible: true, 
                        isPersistent: false, 
                        isAwake: true,
                        collisionShapeFlags: CollisionShapeFlags.Circle
                    ).ApplyEvent(ModFiles, 
                        new MslEvent("gml_Object_o_b_angel_charm_Create_0.gml", EventType.Create, 0),
new MslEvent("gml_Object_o_b_angel_charm_Alarm_2.gml", EventType.Alarm, 2),
new MslEvent("gml_Object_o_b_angel_charm_Alarm_3.gml", EventType.Alarm, 3),
new MslEvent("gml_Object_o_b_angel_charm_Step_2.gml", EventType.Step, 2),
new MslEvent("gml_Object_o_b_angel_charm_Other_10.gml", EventType.Other, 10)
                    );
                    Msl.AddObject(
                        name: "o_b_darkenchant", 
                        spriteName: "s_dark_enchant_effect", 
                        parentName: "o_magical_buff", 
                        isVisible: true, 
                        isPersistent: false, 
                        isAwake: true,
                        collisionShapeFlags: CollisionShapeFlags.Circle
                    ).ApplyEvent(ModFiles, 
                        new MslEvent("gml_Object_o_b_darkenchant_Create_0.gml", EventType.Create, 0),
new MslEvent("gml_Object_o_b_darkenchant_Alarm_2.gml", EventType.Alarm, 2),
new MslEvent("gml_Object_o_b_darkenchant_Alarm_3.gml", EventType.Alarm, 3),
new MslEvent("gml_Object_o_b_darkenchant_Step_2.gml", EventType.Step, 2),
new MslEvent("gml_Object_o_b_darkenchant_Other_10.gml", EventType.Other, 10),
new MslEvent("gml_Object_o_b_darkenchant_PreCreate_0.gml", EventType.PreCreate, 0)
                    );
                    Msl.AddObject(
                        name: "o_skill_Lostsouls", 
                        spriteName: "s_disasterundead", 
                        parentName: "o_skill", 
                        isVisible: true, 
                        isPersistent: false, 
                        isAwake: true,
                        collisionShapeFlags: CollisionShapeFlags.Circle
                    ).ApplyEvent(ModFiles, 
                        new MslEvent("gml_Object_o_skill_Lostsouls_Create_0.gml", EventType.Create, 0),
new MslEvent("gml_Object_o_skill_Lostsouls_Other_14.gml", EventType.Other, 14),
new MslEvent("gml_Object_o_skill_Lostsouls_Other_17.gml", EventType.Other, 17),
new MslEvent("gml_Object_o_skill_Lostsouls_Other_13.gml", EventType.Other, 13)
                    );
                    Msl.AddObject(
                        name: "o_skill_death_plague", 
                        spriteName: "s_soul_abs", 
                        parentName: "o_skill", 
                        isVisible: true, 
                        isPersistent: false, 
                        isAwake: true,
                        collisionShapeFlags: CollisionShapeFlags.Circle
                    ).ApplyEvent(ModFiles, 
                        new MslEvent("gml_Object_o_skill_death_plague_Create_0.gml", EventType.Create, 0),
new MslEvent("gml_Object_o_skill_death_plague_Other_17.gml", EventType.Other, 17),
new MslEvent("gml_Object_o_skill_death_plague_Other_13.gml", EventType.Other, 13),
new MslEvent("gml_Object_o_skill_death_plague_Other_19.gml", EventType.Other, 19),
new MslEvent("gml_Object_o_skill_death_plague_Other_10.gml", EventType.Other, 10),
new MslEvent("gml_Object_o_skill_death_plague_PreCreate_0.gml", EventType.PreCreate, 0)
                    );
                    
        o_skill_death_plague_ico.ApplyEvent(ModFiles, 
            new MslEvent("gml_Object_o_skill_death_plague_ico_Create_0.gml", EventType.Create, 0),
            new MslEvent("gml_Object_o_skill_death_plague_ico_Step_0.gml", EventType.Step, 0),
            new MslEvent("gml_Object_o_skill_death_plague_ico_PreCreate_0.gml", EventType.PreCreate, 0)
        );

                    Msl.AddObject(
                        name: "o_skill_soul_explosion", 
                        spriteName: "s_soulzac", 
                        parentName: "o_skill", 
                        isVisible: true, 
                        isPersistent: false, 
                        isAwake: true,
                        collisionShapeFlags: CollisionShapeFlags.Circle
                    ).ApplyEvent(ModFiles, 
                        new MslEvent("gml_Object_o_skill_soul_explosion_Create_0.gml", EventType.Create, 0),
new MslEvent("gml_Object_o_skill_soul_explosion_Other_18.gml", EventType.Other, 18),
new MslEvent("gml_Object_o_skill_soul_explosion_Other_14.gml", EventType.Other, 14),
new MslEvent("gml_Object_o_skill_soul_explosion_Other_17.gml", EventType.Other, 17),
new MslEvent("gml_Object_o_skill_soul_explosion_Other_13.gml", EventType.Other, 13),
new MslEvent("gml_Object_o_skill_soul_explosion_PreCreate_0.gml", EventType.PreCreate, 0)
                    );
                    
        o_skill_soul_explosion_ico.ApplyEvent(ModFiles, 
            new MslEvent("gml_Object_o_skill_soul_explosion_ico_Create_0.gml", EventType.Create, 0),
            new MslEvent("gml_Object_o_skill_soul_explosion_ico_Step_2.gml", EventType.Step, 2),
            new MslEvent("gml_Object_o_skill_soul_explosion_ico_Other_13.gml", EventType.Other, 13),
            new MslEvent("gml_Object_o_skill_soul_explosion_ico_Other_17.gml", EventType.Other, 17),
            new MslEvent("gml_Object_o_skill_soul_explosion_ico_PreCreate_0.gml", EventType.PreCreate, 0)
        );

        Msl.AddObject(
            name: "o_pass_skill_nmadness", 
            spriteName: "s_growing_madness", 
            parentName: "o_skill_passive", 
            isVisible: true, 
            isPersistent: false, 
            isAwake: true,
            collisionShapeFlags: CollisionShapeFlags.Circle
        ).ApplyEvent(ModFiles, 
            new MslEvent("gml_Object_o_pass_skill_nmadness_Create_0.gml", EventType.Create, 0),
            new MslEvent("gml_Object_o_pass_skill_nmadness_Step_2.gml", EventType.Step, 2),
            new MslEvent("gml_Object_o_pass_skill_nmadness_Other_17.gml", EventType.Other, 17),
            new MslEvent("gml_Object_o_pass_skill_nmadness_Other_13.gml", EventType.Other, 13),
            new MslEvent("gml_Object_o_pass_skill_nmadness_PreCreate_0.gml", EventType.PreCreate, 0)
        );

                    Msl.AddObject(
                        name: "o_pass_skill_ndarkness", 
                        spriteName: "s_crazed_by_magic", 
                        parentName: "o_skill_passive", 
                        isVisible: true, 
                        isPersistent: false, 
                        isAwake: true,
                        collisionShapeFlags: CollisionShapeFlags.Circle
                    ).ApplyEvent(ModFiles, 
                        new MslEvent("gml_Object_o_pass_skill_ndarkness_Create_0.gml", EventType.Create, 0),
new MslEvent("gml_Object_o_pass_skill_ndarkness_Step_2.gml", EventType.Step, 2),
new MslEvent("gml_Object_o_pass_skill_ndarkness_Other_17.gml", EventType.Other, 17),
new MslEvent("gml_Object_o_pass_skill_ndarkness_Other_13.gml", EventType.Other, 13),
new MslEvent("gml_Object_o_pass_skill_ndarkness_PreCreate_0.gml", EventType.PreCreate, 0)
                    );

        o_skill_Lostsouls_ico.ApplyEvent(ModFiles, 
            new MslEvent("gml_Object_o_skill_Lostsouls_ico_Create_0.gml", EventType.Create, 0),
            new MslEvent("gml_Object_o_skill_Lostsouls_ico_Step_2.gml", EventType.Step, 2)
        );

                    Msl.AddObject(
                        name: "o_pass_skill_darkblood", 
                        spriteName: "s_grim_blood", 
                        parentName: "o_skill_passive", 
                        isVisible: true, 
                        isPersistent: false, 
                        isAwake: true,
                        collisionShapeFlags: CollisionShapeFlags.Circle
                    ).ApplyEvent(ModFiles, 
                        new MslEvent("gml_Object_o_pass_skill_darkblood_Create_0.gml", EventType.Create, 0),
new MslEvent("gml_Object_o_pass_skill_darkblood_Step_2.gml", EventType.Step, 2),
new MslEvent("gml_Object_o_pass_skill_darkblood_Other_17.gml", EventType.Other, 17),
new MslEvent("gml_Object_o_pass_skill_darkblood_Other_13.gml", EventType.Other, 13),
new MslEvent("gml_Object_o_pass_skill_darkblood_PreCreate_0.gml", EventType.PreCreate, 0)
                    );
                    Msl.AddObject(
                        name: "o_pass_skill_unholymind", 
                        spriteName: "s_reaping_darkness", 
                        parentName: "o_skill_passive", 
                        isVisible: true, 
                        isPersistent: false, 
                        isAwake: true,
                        collisionShapeFlags: CollisionShapeFlags.Circle
                    ).ApplyEvent(ModFiles, 
                        new MslEvent("gml_Object_o_pass_skill_unholymind_Create_0.gml", EventType.Create, 0),
new MslEvent("gml_Object_o_pass_skill_unholymind_Step_2.gml", EventType.Step, 2),
new MslEvent("gml_Object_o_pass_skill_unholymind_Other_13.gml", EventType.Other, 13),
new MslEvent("gml_Object_o_pass_skill_unholymind_Other_17.gml", EventType.Other, 17),
new MslEvent("gml_Object_o_pass_skill_unholymind_PreCreate_0.gml", EventType.PreCreate, 0)
                    );
                    Msl.AddObject(
                        name: "o_pass_skill_imortall", 
                        spriteName: "s_imortal_soul", 
                        parentName: "o_skill_passive", 
                        isVisible: true, 
                        isPersistent: false, 
                        isAwake: true,
                        collisionShapeFlags: CollisionShapeFlags.Circle
                    ).ApplyEvent(ModFiles, 
                        new MslEvent("gml_Object_o_pass_skill_imortall_Create_0.gml", EventType.Create, 0),
new MslEvent("gml_Object_o_pass_skill_imortall_Alarm_7.gml", EventType.Alarm, 7),
new MslEvent("gml_Object_o_pass_skill_imortall_Step_2.gml", EventType.Step, 2),
new MslEvent("gml_Object_o_pass_skill_imortall_Other_17.gml", EventType.Other, 17),
new MslEvent("gml_Object_o_pass_skill_imortall_Other_13.gml", EventType.Other, 13),
new MslEvent("gml_Object_o_pass_skill_imortall_PreCreate_0.gml", EventType.PreCreate, 0)
                    );
                    Msl.AddObject(
                        name: "o_pass_skill_kingdead", 
                        spriteName: "s_angel_of_death", 
                        parentName: "o_skill_passive", 
                        isVisible: true, 
                        isPersistent: false, 
                        isAwake: true,
                        collisionShapeFlags: CollisionShapeFlags.Circle
                    ).ApplyEvent(ModFiles, 
                        new MslEvent("gml_Object_o_pass_skill_kingdead_Create_0.gml", EventType.Create, 0),
new MslEvent("gml_Object_o_pass_skill_kingdead_Step_2.gml", EventType.Step, 2),
new MslEvent("gml_Object_o_pass_skill_kingdead_Other_17.gml", EventType.Other, 17),
new MslEvent("gml_Object_o_pass_skill_kingdead_Other_13.gml", EventType.Other, 13)
                    );
                    Msl.AddObject(
                        name: "o_allAttack_Attitude", 
                        spriteName: "s_bw_attitude_attack", 
                        parentName: "o_Attitude", 
                        isVisible: true, 
                        isPersistent: false, 
                        isAwake: true,
                        collisionShapeFlags: CollisionShapeFlags.Circle
                    ).ApplyEvent(ModFiles, 
                        new MslEvent("gml_Object_o_allAttack_Attitude_Create_0.gml", EventType.Create, 0),
new MslEvent("gml_Object_o_allAttack_Attitude_Mouse_7.gml", EventType.Mouse, 7),
new MslEvent("gml_Object_o_allAttack_Attitude_Other_10.gml", EventType.Other, 10),
new MslEvent("gml_Object_o_allAttack_Attitude_Other_12.gml", EventType.Other, 12),
new MslEvent("gml_Object_o_allAttack_Attitude_PreCreate_0.gml", EventType.PreCreate, 0)
                    );
                    Msl.AddObject(
                        name: "o_allDeffence_Attitude", 
                        spriteName: "s_bw_attitude_follow", 
                        parentName: "o_Attitude", 
                        isVisible: true, 
                        isPersistent: false, 
                        isAwake: true,
                        collisionShapeFlags: CollisionShapeFlags.Circle
                    ).ApplyEvent(ModFiles, 
                        new MslEvent("gml_Object_o_allDeffence_Attitude_Create_0.gml", EventType.Create, 0),
new MslEvent("gml_Object_o_allDeffence_Attitude_Mouse_7.gml", EventType.Mouse, 7),
new MslEvent("gml_Object_o_allDeffence_Attitude_Other_10.gml", EventType.Other, 10),
new MslEvent("gml_Object_o_allDeffence_Attitude_Other_12.gml", EventType.Other, 12),
new MslEvent("gml_Object_o_allDeffence_Attitude_PreCreate_0.gml", EventType.PreCreate, 0)
                    );

                    Msl.AddObject(
                        name: "o_disclaimer03", 
                        spriteName: "", 
                        parentName: "", 
                        isVisible: true, 
                        isPersistent: false, 
                        isAwake: true,
                        collisionShapeFlags: CollisionShapeFlags.Circle
                    ).ApplyEvent(ModFiles, 
                        new MslEvent("gml_Object_o_disclaimer03_Draw_0.gml", EventType.Draw, 0)
                    );
                    Msl.AddObject(
                        name: "o_BwMark", 
                        spriteName: "s_bwdis", 
                        parentName: "", 
                        isVisible: true, 
                        isPersistent: false, 
                        isAwake: false,
                        collisionShapeFlags: CollisionShapeFlags.Circle
                    ).ApplyEvent(ModFiles, 
                        new MslEvent("gml_Object_o_BwMark_Create_0.gml", EventType.Create, 0),
new MslEvent("gml_Object_o_BwMark_Other_5.gml", EventType.Other, 5)
                    );

        Msl.AddObject(
            name: "o_skill_bw_resurrection", 
            spriteName: "s_recurct", 
            parentName: "o_skill", 
            isVisible: true, 
            isPersistent: false, 
            isAwake: true,
            collisionShapeFlags: CollisionShapeFlags.Circle
        ).ApplyEvent(ModFiles, 
            new MslEvent("gml_Object_o_skill_bw_resurrection_Create_0.gml", EventType.Create, 0),
            new MslEvent("gml_Object_o_skill_bw_resurrection_Step_2.gml", EventType.Step, 2),
            new MslEvent("gml_Object_o_skill_bw_resurrection_Other_17.gml", EventType.Other, 17),
            new MslEvent("gml_Object_o_skill_bw_resurrection_Other_14.gml", EventType.Other, 14),
            new MslEvent("gml_Object_o_skill_bw_resurrection_Other_15.gml", EventType.Other, 15),
            new MslEvent("gml_Object_o_skill_bw_resurrection_Other_13.gml", EventType.Other, 13)
        );

        o_skill_bw_resurrection_ico.ApplyEvent(ModFiles, 
            new MslEvent("gml_Object_o_skill_bw_resurrection_ico_Create_0.gml", EventType.Create, 0),
            new MslEvent("gml_Object_o_skill_bw_resurrection_ico_Step_2.gml", EventType.Step, 2),
            new MslEvent("gml_Object_o_skill_bw_resurrection_ico_Other_13.gml", EventType.Other, 13)
        );

        Msl.AddObject(
            name: "o_bw_resurrection_birth", 
            spriteName: "s_makefeast_birth", 
            parentName: "o_spelllbirth", 
            isVisible: true, 
            isPersistent: false, 
            isAwake: true,
            collisionShapeFlags: CollisionShapeFlags.Circle
        ).ApplyEvent(ModFiles, 
            new MslEvent("gml_Object_o_bw_resurrection_birth_Create_0.gml", EventType.Create, 0),
            new MslEvent("gml_Object_o_bw_resurrection_birth_Other_7.gml", EventType.Other, 7),
            new MslEvent("gml_Object_o_bw_resurrection_birth_Other_10.gml", EventType.Other, 10),
            new MslEvent("gml_Object_o_bw_resurrection_birth_Draw_0.gml", EventType.Draw, 0)
        );

        Msl.AddObject(
            name: "o_bw_resurrection", 
            spriteName: "s_resurection", 
            parentName: "o_magic_pillar", 
            isVisible: true, 
            isPersistent: false, 
            isAwake: true,
            collisionShapeFlags: CollisionShapeFlags.Circle
        ).ApplyEvent(ModFiles, 
            new MslEvent("gml_Object_o_bw_resurrection_Create_0.gml", EventType.Create, 0),
            new MslEvent("gml_Object_o_bw_resurrection_Destroy_0.gml", EventType.Destroy, 0),
            new MslEvent("gml_Object_o_bw_resurrection_Alarm_0.gml", EventType.Alarm, 0),
            new MslEvent("gml_Object_o_bw_resurrection_Alarm_10.gml", EventType.Alarm, 10),
            new MslEvent("gml_Object_o_bw_resurrection_Other_7.gml", EventType.Other, 7),
            new MslEvent("gml_Object_o_bw_resurrection_Draw_0.gml", EventType.Draw, 0)
        );

        Msl.AddObject(
            name: "o_skill_bw_wraithsummon", 
            spriteName: "s_wraithbind", 
            parentName: "o_skill", 
            isVisible: true, 
            isPersistent: false, 
            isAwake: true,
            collisionShapeFlags: CollisionShapeFlags.Circle
        ).ApplyEvent(ModFiles, 
            new MslEvent("gml_Object_o_skill_bw_wraithsummon_Create_0.gml", EventType.Create, 0),
            new MslEvent("gml_Object_o_skill_bw_wraithsummon_Other_14.gml", EventType.Other, 14),
            new MslEvent("gml_Object_o_skill_bw_wraithsummon_Other_17.gml", EventType.Other, 17),
            new MslEvent("gml_Object_o_skill_bw_wraithsummon_Other_13.gml", EventType.Other, 13),
            new MslEvent("gml_Object_o_skill_bw_wraithsummon_Other_15.gml", EventType.Other, 15)
        );

        o_skill_bw_wraithsummon_ico.ApplyEvent(ModFiles, 
            new MslEvent("gml_Object_o_skill_bw_wraithsummon_ico_Create_0.gml", EventType.Create, 0),
            new MslEvent("gml_Object_o_skill_bw_wraithsummon_ico_Step_2.gml", EventType.Step, 2),
            new MslEvent("gml_Object_o_skill_bw_wraithsummon_ico_Other_4.gml", EventType.Other, 4),
            new MslEvent("gml_Object_o_skill_bw_wraithsummon_ico_Other_5.gml", EventType.Other, 5)
        );

        Msl.AddObject(
            name: "o_bw_wraith_summoning", 
            spriteName: "s_wraithsummon_cast", 
            parentName: "o_spelllbirth", 
            isVisible: true, 
            isPersistent: false, 
            isAwake: true,
            collisionShapeFlags: CollisionShapeFlags.Circle
        ).ApplyEvent(ModFiles, 
            new MslEvent("gml_Object_o_bw_wraith_summoning_Create_0.gml", EventType.Create, 0),
            new MslEvent("gml_Object_o_bw_wraith_summoning_Destroy_0.gml", EventType.Destroy, 0),
            new MslEvent("gml_Object_o_bw_wraith_summoning_Other_10.gml", EventType.Other, 10),
            new MslEvent("gml_Object_o_bw_wraith_summoning_Other_7.gml", EventType.Other, 7)
        );

        Msl.AddObject(
            name: "o_bw_curse", 
            spriteName: "s_pcurse", 
            parentName: "o_skill", 
            isVisible: true, 
            isPersistent: false, 
            isAwake: true,
            collisionShapeFlags: CollisionShapeFlags.Circle
        ).ApplyEvent(ModFiles, 
            new MslEvent("gml_Object_o_bw_curse_Create_0.gml", EventType.Create, 0),
            new MslEvent("gml_Object_o_bw_curse_Other_17.gml", EventType.Other, 17),
            new MslEvent("gml_Object_o_bw_curse_Other_13.gml", EventType.Other, 13)
        );

        o_bw_curse_ico.ApplyEvent(ModFiles, 
            new MslEvent("gml_Object_o_bw_curse_ico_Create_0.gml", EventType.Create, 0)
        );

        Msl.AddObject(
            name: "o_bw_cursebirth", 
            spriteName: "s_curse_cast", 
            parentName: "o_spelllbirth", 
            isVisible: true, 
            isPersistent: false, 
            isAwake: true,
            collisionShapeFlags: CollisionShapeFlags.Circle
        ).ApplyEvent(ModFiles, 
            new MslEvent("gml_Object_o_bw_cursebirth_Create_0.gml", EventType.Create, 0)
        );

        Msl.AddObject(
            name: "o_bw_inscurse", 
            spriteName: "s_teal_curse", 
            parentName: "o_magic_pillar", 
            isVisible: true, 
            isPersistent: false, 
            isAwake: true,
            collisionShapeFlags: CollisionShapeFlags.Circle
        ).ApplyEvent(ModFiles, 
            new MslEvent("gml_Object_o_bw_inscurse_Create_0.gml", EventType.Create, 0),
            new MslEvent("gml_Object_o_bw_inscurse_Other_7.gml", EventType.Other, 7),
            new MslEvent("gml_Object_o_bw_inscurse_Draw_0.gml", EventType.Draw, 0)
        );

                    Msl.AddObject(
                        name: "o_bw_darkbolt", 
                        spriteName: "s_darkbalz", 
                        parentName: "o_skill", 
                        isVisible: true, 
                        isPersistent: false, 
                        isAwake: true,
                        collisionShapeFlags: CollisionShapeFlags.Circle
                    ).ApplyEvent(ModFiles, 
                        new MslEvent("gml_Object_o_bw_darkbolt_Create_0.gml", EventType.Create, 0),
new MslEvent("gml_Object_o_bw_darkbolt_Other_17.gml", EventType.Other, 17),
new MslEvent("gml_Object_o_bw_darkbolt_Other_13.gml", EventType.Other, 13)
                    );

        o_bw_darkbolt_ico.ApplyEvent(ModFiles, 
            new MslEvent("gml_Object_o_bw_darkbolt_ico_Create_0.gml", EventType.Create, 0)
        );

                    Msl.AddObject(
                        name: "o_bw_ballbirth", 
                        spriteName: "s_spell_darkball_birth", 
                        parentName: "o_spelllbirth", 
                        isVisible: true, 
                        isPersistent: false, 
                        isAwake: true,
                        collisionShapeFlags: CollisionShapeFlags.Circle
                    ).ApplyEvent(ModFiles, 
                        new MslEvent("gml_Object_o_bw_ballbirth_Create_0.gml", EventType.Create, 0),
new MslEvent("gml_Object_o_bw_ballbirth_Other_17.gml", EventType.Other, 17),
new MslEvent("gml_Object_o_bw_ballbirth_Other_10.gml", EventType.Other, 10)
                    );
                    Msl.AddObject(
                        name: "o_bw_dark_bless", 
                        spriteName: "s_blusss", 
                        parentName: "o_skill", 
                        isVisible: true, 
                        isPersistent: false, 
                        isAwake: true,
                        collisionShapeFlags: CollisionShapeFlags.Circle
                    ).ApplyEvent(ModFiles, 
                        new MslEvent("gml_Object_o_bw_dark_bless_Create_0.gml", EventType.Create, 0),
new MslEvent("gml_Object_o_bw_dark_bless_Other_17.gml", EventType.Other, 17),
new MslEvent("gml_Object_o_bw_dark_bless_Other_13.gml", EventType.Other, 13)
                    );

        o_bw_dark_bless_ico.ApplyEvent(ModFiles, 
            new MslEvent("gml_Object_o_bw_dark_bless_ico_Create_0.gml", EventType.Create, 0),
            new MslEvent("gml_Object_o_bw_dark_bless_ico_Step_2.gml", EventType.Step, 2)
        );

                    Msl.AddObject(
                        name: "o_bw_blessing_birth", 
                        spriteName: "s_darkbless_birth", 
                        parentName: "o_spelllbirth", 
                        isVisible: true, 
                        isPersistent: false, 
                        isAwake: true,
                        collisionShapeFlags: CollisionShapeFlags.Circle
                    ).ApplyEvent(ModFiles, 
                        new MslEvent("gml_Object_o_bw_blessing_birth_Create_0.gml", EventType.Create, 0)
                    );
                    Msl.AddObject(
                        name: "o_bw_darkbless", 
                        spriteName: "s_darkblessing", 
                        parentName: "o_magic_pillar", 
                        isVisible: true, 
                        isPersistent: false, 
                        isAwake: true,
                        collisionShapeFlags: CollisionShapeFlags.Circle
                    ).ApplyEvent(ModFiles, 
                        new MslEvent("gml_Object_o_bw_darkbless_Create_0.gml", EventType.Create, 0),
new MslEvent("gml_Object_o_bw_darkbless_Other_7.gml", EventType.Other, 7),
new MslEvent("gml_Object_o_bw_darkbless_Draw_0.gml", EventType.Draw, 0)
                    );
                    Msl.AddObject(
                        name: "o_skill_bw_touch", 
                        spriteName: "s_dtouch", 
                        parentName: "o_skill", 
                        isVisible: true, 
                        isPersistent: false, 
                        isAwake: true,
                        collisionShapeFlags: CollisionShapeFlags.Circle
                    ).ApplyEvent(ModFiles, 
                        new MslEvent("gml_Object_o_skill_bw_touch_Create_0.gml", EventType.Create, 0),
new MslEvent("gml_Object_o_skill_bw_touch_Other_17.gml", EventType.Other, 17),
new MslEvent("gml_Object_o_skill_bw_touch_Other_13.gml", EventType.Other, 13)
                    );

        o_skill_bw_touch_ico.ApplyEvent(ModFiles, 
            new MslEvent("gml_Object_o_skill_bw_touch_ico_Create_0.gml", EventType.Create, 0),
            new MslEvent("gml_Object_o_skill_bw_touch_ico_Step_2.gml", EventType.Step, 2)
        );

                    Msl.AddObject(
                        name: "o_bw_touch", 
                        spriteName: "", 
                        parentName: "", 
                        isVisible: true, 
                        isPersistent: false, 
                        isAwake: true,
                        collisionShapeFlags: CollisionShapeFlags.Circle
                    ).ApplyEvent(ModFiles, 
                        new MslEvent("gml_Object_o_bw_touch_Create_0.gml", EventType.Create, 0),
new MslEvent("gml_Object_o_bw_touch_Destroy_0.gml", EventType.Destroy, 0),
new MslEvent("gml_Object_o_bw_touch_Alarm_1.gml", EventType.Alarm, 1),
new MslEvent("gml_Object_o_bw_touch_Alarm_0.gml", EventType.Alarm, 0),
new MslEvent("gml_Object_o_bw_touch_Alarm_2.gml", EventType.Alarm, 2),
new MslEvent("gml_Object_o_bw_touch_Alarm_10.gml", EventType.Alarm, 10)
                    );

        Msl.AddObject(
            name: "o_bw_sacrifice", 
            spriteName: "s_db_soul_sacrifice", 
            parentName: "o_class_skills", 
            isVisible: true, 
            isPersistent: false, 
            isAwake: true,
            collisionShapeFlags: CollisionShapeFlags.Circle
        ).ApplyEvent(ModFiles, 
            new MslEvent("gml_Object_o_bw_sacrifice_Create_0.gml", EventType.Create, 0),
            new MslEvent("gml_Object_o_bw_sacrifice_Destroy_0.gml", EventType.Destroy, 0),
            new MslEvent("gml_Object_o_bw_sacrifice_Alarm_2.gml", EventType.Alarm, 2),
            new MslEvent("gml_Object_o_bw_sacrifice_Step_2.gml", EventType.Step, 2),
            new MslEvent("gml_Object_o_bw_sacrifice_Other_13.gml", EventType.Other, 13),
            new MslEvent("gml_Object_o_bw_sacrifice_KeyPress_75.gml", EventType.KeyPress, 75)
        );

                    Msl.AddObject(
                        name: "o_db_painful_curse", 
                        spriteName: "s_buff_cursse", 
                        parentName: "o_magical_debuff", 
                        isVisible: true, 
                        isPersistent: false, 
                        isAwake: true,
                        collisionShapeFlags: CollisionShapeFlags.Circle
                    ).ApplyEvent(ModFiles, 
                        new MslEvent("gml_Object_o_db_painful_curse_Create_0.gml", EventType.Create, 0),
new MslEvent("gml_Object_o_db_painful_curse_Destroy_0.gml", EventType.Destroy, 0),
new MslEvent("gml_Object_o_db_painful_curse_Alarm_2.gml", EventType.Alarm, 2),
new MslEvent("gml_Object_o_db_painful_curse_Alarm_1.gml", EventType.Alarm, 1),
new MslEvent("gml_Object_o_db_painful_curse_Step_0.gml", EventType.Step, 0),
new MslEvent("gml_Object_o_db_painful_curse_Other_15.gml", EventType.Other, 15),
new MslEvent("gml_Object_o_db_painful_curse_Other_10.gml", EventType.Other, 10)
                    );
                    Msl.AddObject(
                        name: "o_darkball2", 
                        spriteName: "s_spell_darlball", 
                        parentName: "o_shell_damage", 
                        isVisible: true, 
                        isPersistent: false, 
                        isAwake: true,
                        collisionShapeFlags: CollisionShapeFlags.Circle
                    ).ApplyEvent(ModFiles, 
                        new MslEvent("gml_Object_o_darkball2_Create_0.gml", EventType.Create, 0),
new MslEvent("gml_Object_o_darkball2_Destroy_0.gml", EventType.Destroy, 0),
new MslEvent("gml_Object_o_darkball2_Other_10.gml", EventType.Other, 10),
new MslEvent("gml_Object_o_darkball2_Other_11.gml", EventType.Other, 11)
                    );

        Msl.AddObject(
            name: "o_b_deathbless", 
            spriteName: "s_buff_death_blesss", 
            parentName: "o_physical_buff", 
            isVisible: true, 
            isPersistent: false, 
            isAwake: true,
            collisionShapeFlags: CollisionShapeFlags.Circle
        ).ApplyEvent(ModFiles, 
            new MslEvent("gml_Object_o_b_deathbless_Create_0.gml", EventType.Create, 0),
            new MslEvent("gml_Object_o_b_deathbless_Alarm_2.gml", EventType.Alarm, 2),
            new MslEvent("gml_Object_o_b_deathbless_Other_10.gml", EventType.Other, 10)
        );

        Msl.AddObject(
            name: "o_bw_zombie", 
            spriteName: "s_zombie01", 
            parentName: "c_zombie", 
            isVisible: true, 
            isPersistent: false, 
            isAwake: true,
            collisionShapeFlags: CollisionShapeFlags.Circle
        ).ApplyEvent(ModFiles, 
            new MslEvent("gml_Object_o_bw_zombie_Create_0.gml", EventType.Create, 0),
            new MslEvent("gml_Object_o_bw_zombie_Destroy_0.gml", EventType.Destroy, 0),
            new MslEvent("gml_Object_o_bw_zombie_PreCreate_0.gml", EventType.PreCreate, 0)
        );

        Msl.AddObject(
            name: "o_archtheurgy_impact", 
            spriteName: "", 
            parentName: "", 
            isVisible: true, 
            isPersistent: false, 
            isAwake: true,
            collisionShapeFlags: CollisionShapeFlags.Circle
        ).ApplyEvent(ModFiles, 
            new MslEvent("gml_Object_o_archtheurgy_impact_Create_0.gml", EventType.Create, 0),
            new MslEvent("gml_Object_o_archtheurgy_impact_Alarm_1.gml", EventType.Alarm, 1)
        );

        Msl.AddObject(
            name: "o_skill_enchantment_bw", 
            spriteName: "sprite1", 
            parentName: "o_weapon_skills", 
            isVisible: true, 
            isPersistent: false, 
            isAwake: true,
            collisionShapeFlags: CollisionShapeFlags.Circle
        ).ApplyEvent(ModFiles,         
            new MslEvent("gml_Object_o_skill_enchantment_bw_Other_20.gml", EventType.Other, 20),
            new MslEvent("gml_Object_o_skill_enchantment_bw_Other_11.gml", EventType.Other, 11)
        );

        Msl.AddObject(
            name: "o_skill_bw_targeting", 
            spriteName: "s_torchishka", 
            parentName: "o_skills_like", 
            isVisible: true, 
            isPersistent: true, 
            isAwake: true,
            collisionShapeFlags: CollisionShapeFlags.Circle
        ).ApplyEvent(ModFiles, 
            new MslEvent("gml_Object_o_skill_bw_targeting_Create_0.gml", EventType.Create, 0),
            new MslEvent("gml_Object_o_skill_bw_targeting_Alarm_1.gml", EventType.Alarm, 1),
            new MslEvent("gml_Object_o_skill_bw_targeting_Step_0.gml", EventType.Step, 0),
            new MslEvent("gml_Object_o_skill_bw_targeting_Other_17.gml", EventType.Other, 17),
            new MslEvent("gml_Object_o_skill_bw_targeting_Other_13.gml", EventType.Other, 13),
            new MslEvent("gml_Object_o_skill_bw_targeting_Other_19.gml", EventType.Other, 19),
            new MslEvent("gml_Object_o_skill_bw_targeting_Other_25.gml", EventType.Other, 25),
            new MslEvent("gml_Object_o_skill_bw_targeting_Draw_0.gml", EventType.Draw, 0)
        );

        Msl.AddObject(
            name: "o_skill_bw_targeting_offense", 
            spriteName: "s_torchishka", 
            parentName: "o_skills_like", 
            isVisible: true, 
            isPersistent: true, 
            isAwake: true,
            collisionShapeFlags: CollisionShapeFlags.Circle
        ).ApplyEvent(ModFiles, 
            new MslEvent("gml_Object_o_skill_bw_targeting_offense_Create_0.gml", EventType.Create, 0),
            new MslEvent("gml_Object_o_skill_bw_targeting_offense_Alarm_1.gml", EventType.Alarm, 1),
            new MslEvent("gml_Object_o_skill_bw_targeting_offense_Step_0.gml", EventType.Step, 0),
            new MslEvent("gml_Object_o_skill_bw_targeting_offense_Other_17.gml", EventType.Other, 17),
            new MslEvent("gml_Object_o_skill_bw_targeting_offense_Other_13.gml", EventType.Other, 13),
            new MslEvent("gml_Object_o_skill_bw_targeting_offense_Other_19.gml", EventType.Other, 19),
            new MslEvent("gml_Object_o_skill_bw_targeting_offense_Other_25.gml", EventType.Other, 25)
        );

        Msl.AddObject(
            name: "o_bw_aoe_range", 
            spriteName: "s_aoe_area", 
            parentName: "", 
            isVisible: true, 
            isPersistent: false, 
            isAwake: true,
            collisionShapeFlags: CollisionShapeFlags.Circle
        ).ApplyEvent(ModFiles, 
            new MslEvent("gml_Object_o_bw_aoe_range_Create_0.gml", EventType.Create, 0),
            new MslEvent("gml_Object_o_bw_aoe_range_Alarm_1.gml", EventType.Alarm, 1),
            new MslEvent("gml_Object_o_bw_aoe_range_Step_0.gml", EventType.Step, 0),
            new MslEvent("gml_Object_o_bw_aoe_range_Draw_0.gml", EventType.Draw, 0)
        );

        Msl.AddObject(
            name: "o_soul_absorption_impact", 
            spriteName: "", 
            parentName: "", 
            isVisible: true, 
            isPersistent: false, 
            isAwake: true,
            collisionShapeFlags: CollisionShapeFlags.Circle
        ).ApplyEvent(ModFiles, 
            new MslEvent("gml_Object_o_soul_absorption_impact_Create_0.gml", EventType.Create, 0),
            new MslEvent("gml_Object_o_soul_absorption_impact_Alarm_1.gml", EventType.Alarm, 1)
        );

        Msl.AddObject(
            name: "o_skill_category_necromancy", 
            spriteName: "", 
            parentName: "o_sklill_category_magic", 
            isVisible: true, 
            isPersistent: false, 
            isAwake: true,
            collisionShapeFlags: CollisionShapeFlags.Circle
        ).ApplyEvent(ModFiles, 
            new MslEvent("gml_Object_o_skill_category_necromancy_Create_0.gml", EventType.Create, 0),
            new MslEvent("gml_Object_o_skill_category_necromancy_Other_24.gml", EventType.Other, 24),
            new MslEvent("gml_Object_o_skill_category_necromancy_PreCreate_0.gml", EventType.PreCreate, 0)
        );

        Msl.LoadGML("gml_GlobalScript_scr_attack")
            .MatchFrom("scr_skill_call_buff(o_db_curse, id)")
            .InsertBelow("scr_skill_call_buff(o_db_painful_curse, id)")
            .Save();  
            
        Msl.LoadGML("gml_GlobalScript_scr_enemy_cast_spell")
            .MatchFrom("scr_skill_call_buff(o_db_curse, id)")
            .InsertBelow("scr_skill_call_buff(o_db_painful_curse, id)")
            .Save();
            
        Msl.LoadGML("gml_GlobalScript_scr_enemy_hit")
            .MatchFrom("scr_skill_call_buff(o_db_curse, id)")
            .InsertBelow("scr_skill_call_buff(o_db_painful_curse, id)")
            .Save();

        Msl.LoadGML("gml_GlobalScript_scr_enemyArcherChangeToMelee")
            .MatchFrom("scr_set_hl()")
            .InsertBelow(@"if (faction_id == ""Servant"")
{
    scr_enemyArcherChangeToMeleeParam(1)
}
else")
            .MatchFrom("unitParamName += \" Melee\"")
            .InsertBelow(@"if argument0 scr_param(unitParamName, 0, 1)
else")
            .Save();

        Msl.LoadGML("gml_GlobalScript_scr_enemyTransitListFill")
            .MatchFrom("grid_y = round((yy div 26))\n}\n}\n}\n}\n}\n}\n}\n}")
            .InsertBelow(@"with (o_enemy)
{
if (!(object_is_ancestor(object_index, o_NPC)))
{
if (ds_list_empty(lock_turn) && HP >= 1)
{
if ((faction_id == ""Pet"" && scr_round_cell(point_distance(x, y, other.x, other.y)) < 208) || (faction_id == ""Servant"" && scr_round_cell(point_distance(x, y, other.x, other.y)) < 208) || (faction_id == ""Fallower"" && scr_round_cell(point_distance(x, y, other.x, other.y)) < 208))
{
scr_mp_clear_tiles(o_unit)
if path_exists(path)
{
mp_grid_path(o_controller.grid, path, x, y, other.x, other.y, true)
ds_list_add(global.agred_enemy_list, [id, path_get_number(path)])
}
else ds_list_add(global.agred_enemy_list, [id, ds_list_size(global.agred_enemy_list)])
scr_selfcell(0, id)
if ds_exists(buffs, 2)
{
for (i = 0; i < ds_list_size(buffs); i++)
{
with (ds_list_find_value(buffs, i))
{
persistent = 1
with (animationInstance)
{
persistent = 1
light.persistent = 1
}
}
}
}
if ds_exists(consum_list, 2)
{
for (i = 0; i < ds_list_size(consum_list); i++)
{
with (ds_list_find_value(consum_list, i))
persistent = 1
}
}
if ds_exists(pass_skill, 2)
{
for (i = 0; i < ds_list_size(pass_skill); i++)
{
with (ds_list_find_value(pass_skill, i))
persistent = 1
}
}
ai_is_on = 0
persistent = 1
with (o_onUnitAnimation)
{
if (owner == other.id)
persistent = 1
}
x = -1000
xx = x
draw_x = x
grid_x = round((xx div 26))
grid_y = round((yy div 26))
}
}
}
}")
            .Save();

        // gml_GlobalScript_scr_get_damage_of_weapon

         Msl.LoadGML("gml_GlobalScript_scr_get_XP")
            .MatchFrom("{")
            .InsertBelow("var _sus = 0\nif (argument_count > 1) _sus = argument[1]")
            .MatchFrom("var XP = math_round((")
            .InsertAbove("if (!_sus){")
            .MatchFrom("scr_atr_incr(\"XP\", XP)")
            .InsertBelow("}else{XP = math_round((((argument0 * o_player.Received_XP) / 100) / 2))\nscr_atr_incr(\"XP\", XP)}")
            .Save();

        Msl.LoadGML("gml_GlobalScript_scr_global_turn_end")
            .MatchFrom("with (collision_circle(x, y, 10, o_cutscene_start_trigger, 0, 0))")
            .InsertAbove(@"with (o_skill_bw_resurrection_ico) event_user(3)
with (o_pass_skill_nmadness) event_user(3)
with (o_pass_skill_unholymind) event_user(3)")
            .Save();

        Msl.LoadGML("gml_GlobalScript_scr_param")
            .MatchFrom("_needChange = argument[1]")
            .InsertBelow("var _zompass = 0\nif (argument_count > 2){\n_zompass = argument[2]}")
            .MatchFrom("faction_id = scr_GetMobParametrString(\"faction\")")
            .InsertAbove("if (_zompass || instance_exists(o_res_buff_creator))\n{\nfaction_id = \"Servant\"\nsubfaction_id = faction_id\n}\nelse{")
            .MatchFrom("subfaction_id = argument[0]")
            .InsertBelow("}")
            .Save();

        Msl.LoadGML("gml_GlobalScript_scr_penalty_player_attack")
            .MatchFrom("instance_exists(o_player)")
            .InsertAbove("if (faction_id != \"Servant\"){")
            .MatchFrom("return 1")
            .InsertBelow("}")
            .Save();

        // gml_GlobalScript_scr_qualityBgDraw

        Msl.LoadGML("gml_GlobalScript_scr_skill_tier_init")
            .MatchFrom("}")
            .InsertAbove(@"
global.necromancy_tier1 = [""Necromancy"", o_skill_death_plague_ico, o_bw_darkbolt_ico, o_bw_curse_ico]
global.necromancy_tier2 = [""Necromancy"", o_skill_bw_resurrection_ico, o_bw_dark_bless_ico, o_pass_skill_nmadness, o_pass_skill_ndarkness]
global.necromancy_tier3 = [""Necromancy"", o_pass_skill_unholymind, o_skill_bw_touch_ico, o_skill_soul_explosion_ico]")
            .Save();

        // gml_GlobalScript_scr_weapon_generation
            
    /*     Msl.LoadAssemblyAsString("gml_Object_o_enemy_Destroy_0")
            .MatchFrom("call.i event_inherited(argc=0)\npopz.v")
            .InsertBelow(@"
pushi.e 0
pop.v.i local._shomar
pushi.e o_enemy
pushenv [1005]

:[1000]
push.v self.buffs
pushi.e o_b_servemaster
conv.i.v
call.i gml_Script_scr_instance_exists_in_list(argc=2)
conv.v.b
bf [1002]

:[1001]
call.i gml_Script_is_visible(argc=0)
conv.v.b
b [1003]

:[1002]
push.e 0

:[1003]
bf [1005]

:[1004]
push.v local._shomar
push.e 1
add.i.v
pop.v.v local._shomar

:[1005]
popenv [1000]")
            .Save(); */

        Msl.LoadGML("gml_Object_o_player_Create_0")
            .MatchFrom("event_inherited()")
            .InsertBelow("wraith_spin = -4")
            .Save();

        Msl.LoadGML("gml_Object_o_dataLoader_Other_10")
            .MatchFrom("global.bodypart = \"random\"")
            .InsertAbove("global.bw_selection = 0\nglobal.bw_call = 0")
            .Save();

        Msl.LoadGML("gml_Object_o_skillmenu_Create_0")
            .MatchFrom("var _metaCategoriesArray = ")
            .ReplaceBy("var _metaCategoriesArray = [[o_skill_category_sword, o_skill_category_axe, o_skill_category_mace, o_skill_category_dagger, o_skill_category_greatsword, o_skill_category_greataxe, o_skill_category_greatmauls, o_skill_category_polearms, o_skill_category_bows, o_skill_category_shields, o_skill_category_staves, o_skill_category_wands], [o_skill_category_basic_skills, o_skill_category_dual_wielding, o_skill_category_survival, o_skill_category_combat, o_skill_category_athletics, o_skill_category_mastery_of_magic, o_skill_category_necromancy, o_skill_category_basic_armor, o_skill_category_alchemy, o_skill_category_sabotage], [o_skill_category_pyromancy, o_skill_category_geomancy, o_skill_category_electromancy, o_skill_category_venomancy, o_skill_category_cryomancy, o_skill_category_astromancy, o_skill_category_chronomancy, o_skill_category_psymancy, o_skill_category_arcanistics]]")
            .Save();

        // table injection
        Msl.LoadGML("gml_GlobalScript_table_weapons_text")
            .Apply(WeaponTextIterator)
            .Save();
            
        Msl.LoadGML("gml_GlobalScript_table_text")
            .Apply(TextIterator)
            .Save();

        Msl.LoadGML("gml_GlobalScript_table_speech")
            .Apply(SpeechIterator)
            .Save();

        Msl.LoadGML("gml_GlobalScript_table_skills_stat")
            .Apply(SkillsStatIterator)
            .Save();

        Msl.LoadGML("gml_GlobalScript_table_skills")
            .Apply(SkillsIterator)
            .Save();
    }
    private static IEnumerable<string> WeaponTextIterator(IEnumerable<string> input)
    {
        string chestpieces = "\";;CHESTPIECES;CHESTPIECES;;;;;CHESTPIECES;CHESTPIECES;;;;\",";
        List<int> indicesChestpieces;
        string rings = "\";;RINGS;RINGS;;;;;RINGS;RINGS;;;;\",";
        List<int> indicesRings;

        // armor_name
        string sinistercrown = "\"sinistercrown;Sinister Crown;Sinister Crown;Sinister Crown;Sinister Crown;Sinister Crown;Sinister Crown;Sinister Crown;Sinister Crown;Sinister Crown;Sinister Crown;Sinister Crown;Sinister Crown;\",";
        string hexermantle = "\"hexermantle;Hexer Mantle;Hexer Mantle;Hexer Mantle;Hexer Mantle;Hexer Mantle;Hexer Mantle;Hexer Mantle;Hexer Mantle;Hexer Mantle;Hexer Mantle;Hexer Mantle;Hexer Mantle;\",";
        string skullmorionring = "\"Skull Morion Ring;Skull Morion Ring;Skull Morion Ring;Skull Morion Ring;Skull Morion Ring;Skull Morion Ring;Skull Morion Ring;Skull Morion Ring;Skull Morion Ring;Skull Morion Ring;Skull Morion Ring;Skull Morion Ring;Skull Morion Ring;\",";
        
        // armor_desc
        string sinistercrownDesc = "\"hexermantle;WIP;WIP;WIP;WIP;WIP;WIP;WIP;WIP;WIP;WIP;WIP;WIP;\",";
        string hexermantleDesc = "\"sinistercrown;WIP;WIP;WIP;WIP;WIP;WIP;WIP;WIP;WIP;WIP;WIP;WIP;\",";
        string skullmorionringDesc = "\"Skull Morion Ring;WIP;WIP;WIP;WIP;WIP;WIP;WIP;WIP;WIP;WIP;WIP;WIP;\",";

        foreach(string item in input)
        {
            if (item.Contains(chestpieces) && item.Contains(rings))
            {
                string newItem = item;
                indicesChestpieces = newItem.AllIndicesOf(chestpieces).ToList();
                newItem = newItem.Insert(indicesChestpieces[1] + chestpieces.Length, sinistercrownDesc + hexermantleDesc);
                newItem = newItem.Insert(indicesChestpieces[0] + chestpieces.Length, sinistercrown + hexermantle);
                
                indicesRings = newItem.AllIndicesOf(rings).ToList();
                newItem = newItem.Insert(indicesRings[1] + rings.Length, skullmorionringDesc);
                newItem = newItem.Insert(indicesRings[0] + rings.Length, skullmorionring);
                yield return newItem;
            }
            else
            {
                yield return item;
            }
        }
    }
    private static IEnumerable<string> TextIterator(IEnumerable<string> input)
    {
        string tier = "\"Necromancy;Оккультизм;Occultism;Occultism;Occultism;Occultism;Occultism;Occultism;Occultism;Occultism;Occultism;Occultism;\", ";
        string rarity = "\"10;магический / магическая / магическое / магические;Unholy;魔法;magischer / magische / magisches / magische;mágico / mágica / mágicos / mágicas;magique / magique / magiques / magiques;oggetto magico - ;mágico;Magiczny / Magiczna / Magiczne / Magiczne;büyülü;マジカル;마법의;\",";
        string hover = "\"Necromancy;Бросьте вызов магическим ограничениям и познайте энтропические тайны, лежащие за гранью жизни и смерти.##~y~Особенности:~/~#~w~Поддержка~/~, ~w~Призыв слуг~/~, ~w~Выживаемость~/~, ~w~Ослабление врагов~/~;Challenge magical bounds and master the chaotic dance between life and death with the artistry of a true warlock.##~y~Main focus:~/~#~w~Support~/~, ~w~Minion Management~/~, ~w~Survivability~/~, ~w~Weakening Effects~/~;Challenge magical bounds and master the chaotic dance between life and death with the artistry of a true warlock.##~y~Main focus:~/~#~w~Support~/~, ~w~Minion Management~/~, ~w~Survivability~/~, ~w~Weakening Effects~/~;Challenge magical bounds and master the chaotic dance between life and death with the artistry of a true warlock.##~y~Main focus:~/~#~w~Support~/~, ~w~Minion Management~/~, ~w~Survivability~/~, ~w~Weakening Effects~/~;Challenge magical bounds and master the chaotic dance between life and death with the artistry of a true warlock.##~y~Main focus:~/~#~w~Support~/~, ~w~Minion Management~/~, ~w~Survivability~/~, ~w~Weakening Effects~/~;Challenge magical bounds and master the chaotic dance between life and death with the artistry of a true warlock.##~y~Main focus:~/~#~w~Support~/~, ~w~Minion Management~/~, ~w~Survivability~/~, ~w~Weakening Effects~/~;Challenge magical bounds and master the chaotic dance between life and death with the artistry of a true warlock.##~y~Main focus:~/~#~w~Support~/~, ~w~Minion Management~/~, ~w~Survivability~/~, ~w~Weakening Effects~/~;Challenge magical bounds and master the chaotic dance between life and death with the artistry of a true warlock.##~y~Main focus:~/~#~w~Support~/~, ~w~Minion Management~/~, ~w~Survivability~/~, ~w~Weakening Effects~/~;Challenge magical bounds and master the chaotic dance between life and death with the artistry of a true warlock.##~y~Main focus:~/~#~w~Support~/~, ~w~Minion Management~/~, ~w~Survivability~/~, ~w~Weakening Effects~/~;Challenge magical bounds and master the chaotic dance between life and death with the artistry of a true warlock.##~y~Main focus:~/~#~w~Support~/~, ~w~Minion Management~/~, ~w~Survivability~/~, ~w~Weakening Effects~/~;Challenge magical bounds and master the chaotic dance between life and death with the artistry of a true warlock.##~y~Main focus:~/~#~w~Support~/~, ~w~Minion Management~/~, ~w~Survivability~/~, ~w~Weakening Effects~/~;\",";
        
        foreach(string item in input)
        {
            if (item.Contains("Tier_name_end"))
            {
                string newItem = item;
                newItem = newItem.Insert(newItem.IndexOf("\";Tier_name_end"), tier);
                newItem = newItem.Insert(newItem.IndexOf("\";rarity_end"), rarity);
                newItem = newItem.Insert(newItem.IndexOf("\";skilltree_hover_end"), hover);
                yield return newItem;
            }
            else
            {
                yield return item;
            }
        }
    }
    private static IEnumerable<string> SpeechIterator(IEnumerable<string> input)
    {
        string forbidden = "\";;// FORBIDDEN MAGIC;// FORBIDDEN MAGIC;;;;;;// FORBIDDEN MAGIC;;;;\",";

        string MCWraithStart = "\"MC_Wraith_Binding;MC_Wraith_Binding;MC_Wraith_Binding;MC_Wraith_Binding;MC_Wraith_Binding;MC_Wraith_Binding;MC_Wraith_Binding;MC_Wraith_Binding;MC_Wraith_Binding;MC_Wraith_Binding;MC_Wraith_Binding;MC_Wraith_Binding;MC_Wraith_Binding;MC_Wraith_Binding;MC_Wraith_Binding;\",";
        string speechMCWraith = "\";Korrug Namar!;Lagua ra metha ...?!;廓卢戈'纳玛尔！;Korrug Namar!;¡Korrug Namar!;Korrug Namar !;Korrug Namar!;Korrug Namar!;Korrug Namar!;Korrug Namar!;コールグ・ナマール！;Korrug Namar!;Korrug Namar!;Korrug Namar!;\",";
        string MCWraithEnd = "\"MC_Wraith_Binding_end;MC_Wraith_Binding_end;MC_Wraith_Binding_end;MC_Wraith_Binding_end;MC_Wraith_Binding_end;MC_Wraith_Binding_end;MC_Wraith_Binding_end;MC_Wraith_Binding_end;MC_Wraith_Binding_end;MC_Wraith_Binding_end;MC_Wraith_Binding_end;MC_Wraith_Binding_end;MC_Wraith_Binding_end;MC_Wraith_Binding_end;MC_Wraith_Binding_end;\",";
        
        string WraithSart = "\"Wraith_Binding;Wraith_Binding;Wraith_Binding;Wraith_Binding;Wraith_Binding;Wraith_Binding;Wraith_Binding;Wraith_Binding;Wraith_Binding;Wraith_Binding;Wraith_Binding;Wraith_Binding;Wraith_Binding;Wraith_Binding;Wraith_Binding;\",";
        string speechWraith = "\";Korrug Namar!;Lagura mithensa!;廓卢戈'纳玛尔！;Korrug Namar!;¡Korrug Namar!;Korrug Namar !;Korrug Namar!;Korrug Namar!;Korrug Namar!;Korrug Namar!;コールグ・ナマール！;Korrug Namar!;Korrug Namar!;Korrug Namar!;\",";
        string WraithEnd = "\"Wraith_Binding_end;Wraith_Binding_end;Wraith_Binding_end;Wraith_Binding_end;Wraith_Binding_end;Wraith_Binding_end;Wraith_Binding_end;Wraith_Binding_end;Wraith_Binding_end;Wraith_Binding_end;Wraith_Binding_end;Wraith_Binding_end;Wraith_Binding_end;Wraith_Binding_end;Wraith_Binding_end;\",";
        
        string LostSoulsStart = "\"Lostsouls;Lostsouls;Lostsouls;Lostsouls;Lostsouls;Lostsouls;Lostsouls;Lostsouls;Lostsouls;Lostsouls;Lostsouls;Lostsouls;Lostsouls;Lostsouls;Lostsouls;\",";
        string speechLostSouls = "\";Lagura Lamera !;Lagura Lamera !;Lagura Lamera !;Lagura Lamera !;Lagura Lamera !;Lagura Lamera !;Lagura Lamera !;Lagura Lamera !;Lagura Lamera !;Lagura Lamera !;Lagura Lamera !;Lagura Lamera !;Lagura Lamera !;Lagura Lamera !;\",";
        string LostSoulsEnd = "\"Lostsouls_end;Lostsouls_end;Lostsouls_end;Lostsouls_end;Lostsouls_end;Lostsouls_end;Lostsouls_end;Lostsouls_end;Lostsouls_end;Lostsouls_end;Lostsouls_end;Lostsouls_end;Lostsouls_end;Lostsouls_end;Lostsouls_end;\",";
        
        string MCLostSoulsStart = "\"MC_Lostsouls;MC_Lostsouls;MC_Lostsouls;MC_Lostsouls;MC_Lostsouls;MC_Lostsouls;MC_Lostsouls;MC_Lostsouls;MC_Lostsouls;MC_Lostsouls;MC_Lostsouls;MC_Lostsouls;MC_Lostsouls;MC_Lostsouls;MC_Lostsouls;\",";
        string speechMCLostSouls = "\";Lagurera Mara ... ?!;Lagurera Mara ... ?!;Lagurera Mara ... ?!;Lagurera Mara ... ?!;Lagurera Mara ... ?!;Lagurera Mara ... ?!;Lagurera Mara ... ?!;Lagurera Mara ... ?!;Lagurera Mara ... ?!;Lagurera Mara ... ?!;Lagurera Mara ... ?!;Lagurera Mara ... ?!;Lagurera Mara ... ?!;Lagurera Mara ... ?!;\",";
        string MCLostSoulsEnd = "\"MC_Lostsouls_end;MC_Lostsouls_end;MC_Lostsouls_end;MC_Lostsouls_end;MC_Lostsouls_end;MC_Lostsouls_end;MC_Lostsouls_end;MC_Lostsouls_end;MC_Lostsouls_end;MC_Lostsouls_end;MC_Lostsouls_end;MC_Lostsouls_end;MC_Lostsouls_end;MC_Lostsouls_end;MC_Lostsouls_end;\",";

        string MCbwTouchStart = "\"MC_Bw_Touch;MC_Bw_Touch;MC_Bw_Touch;MC_Bw_Touch;MC_Bw_Touch;MC_Bw_Touch;MC_Bw_Touch;MC_Bw_Touch;MC_Bw_Touch;MC_Bw_Touch;MC_Bw_Touch;MC_Bw_Touch;MC_Bw_Touch;MC_Bw_Touch;MC_Bw_Touch;\",";
        string speechMCbwTouch = "\";Korrug Namar!;Kogrug Nema ...?!;廓卢戈'纳玛尔！;Korrug Namar!;¡Korrug Namar!;Korrug Namar !;Korrug Namar!;Korrug Namar!;Korrug Namar!;Korrug Namar!;コールグ・ナマール！;Korrug Namar!;Korrug Namar!;Korrug Namar!;\",";
        string MCbwTouchEnd = "\"MC_Bw_Touch_end;MC_Bw_Touch_end;MC_Bw_Touch_end;MC_Bw_Touch_end;MC_Bw_Touch_end;MC_Bw_Touch_end;MC_Bw_Touch_end;MC_Bw_Touch_end;MC_Bw_Touch_end;MC_Bw_Touch_end;MC_Bw_Touch_end;MC_Bw_Touch_end;MC_Bw_Touch_end;MC_Bw_Touch_end;MC_Bw_Touch_end;\",";

        string bwTouchStart = "\"Bw_Touch;Bw_Touch;Bw_Touch;Bw_Touch;Bw_Touch;Bw_Touch;Bw_Touch;Bw_Touch;Bw_Touch;Bw_Touch;Bw_Touch;Bw_Touch;Bw_Touch;Bw_Touch;Bw_Touch;\",";
        string speechbwTouch = "\";Korrug Namar!;Korrug Namar!;廓卢戈'纳玛尔！;Korrug Namar!;¡Korrug Namar!;Korrug Namar !;Korrug Namar!;Korrug Namar!;Korrug Namar!;Korrug Namar!;コールグ・ナマール！;Korrug Namar!;Korrug Namar!;Korrug Namar!;\",";
        string bwTouchEnd = "\"Bw_Touch_end;Bw_Touch_end;Bw_Touch_end;Bw_Touch_end;Bw_Touch_end;Bw_Touch_end;Bw_Touch_end;Bw_Touch_end;Bw_Touch_end;Bw_Touch_end;Bw_Touch_end;Bw_Touch_end;Bw_Touch_end;Bw_Touch_end;Bw_Touch_end;\",";
        
        string bwBlessStart = "\"Bw_Bless;Bw_Bless;Bw_Bless;Bw_Bless;Bw_Bless;Bw_Bless;Bw_Bless;Bw_Bless;Bw_Bless;Bw_Bless;Bw_Bless;Bw_Bless;Bw_Bless;Bw_Bless;Bw_Bless;\",";
        string speechbwBless = "\";Yagrak Atot!;Yagrak Atot!;亚格拉克'阿托特！;Yagrak Atot!;¡Yagrak Atot!;Yagrak Atot !;Yagrak Atot!;Yagrak Atot!;Yagrak Atot!;Yagrak Atot!;ヤグラク・アトット！;Yagrak Atot!;Yagrak Atot!;Yagrak Atot!;\",";
        string bwBlessEnd = "\"Bw_Bless_end;Bw_Bless_end;Bw_Bless_end;Bw_Bless_end;Bw_Bless_end;Bw_Bless_end;Bw_Bless_end;Bw_Bless_end;Bw_Bless_end;Bw_Bless_end;Bw_Bless_end;Bw_Bless_end;Bw_Bless_end;Bw_Bless_end;Bw_Bless_end;\",";

        string MCbwBlessStart = "\"MC_Bw_Bless;MC_Bw_Bless;MC_Bw_Bless;MC_Bw_Bless;MC_Bw_Bless;MC_Bw_Bless;MC_Bw_Bless;MC_Bw_Bless;MC_Bw_Bless;MC_Bw_Bless;MC_Bw_Bless;MC_Bw_Bless;MC_Bw_Bless;MC_Bw_Bless;MC_Bw_Bless;\",";
        string speechMCbwBless = "\";Yack Ato... ?!;Yack Ato... ?!;Yack Ato... ?!;Yack Ato... ?!;Yack Ato... ?!;Yack Ato... ?!;Yack Ato... ?!;Yack Ato... ?!;Yack Ato... ?!;Yack Ato... ?!;Yack Ato... ?!;Yack Ato... ?!;Yack Ato... ?!;Yack Ato... ?!;\",";
        string MCbwBlessEnd = "\"MC_Bw_Bless_end;MC_Bw_Bless_end;MC_Bw_Bless_end;MC_Bw_Bless_end;MC_Bw_Bless_end;MC_Bw_Bless_end;MC_Bw_Bless_end;MC_Bw_Bless_end;MC_Bw_Bless_end;MC_Bw_Bless_end;MC_Bw_Bless_end;MC_Bw_Bless_end;MC_Bw_Bless_end;MC_Bw_Bless_end;MC_Bw_Bless_end;\",";

        string DeathPlagueStart = "\"Death_Plague;Death_Plague;Death_Plague;Death_Plague;Death_Plague;Death_Plague;Death_Plague;Death_Plague;Death_Plague;Death_Plague;Death_Plague;Death_Plague;Death_Plague;Death_Plague;Death_Plague;\",";
        string speechDeathPlague = "\";En'thero !;En'thero !;En'thero !;En'thero !;En'thero !;En'thero !;En'thero !;En'thero !;En'thero !;En'thero !;En'thero !;En'thero !;En'thero !;En'thero !;\",";
        string DeathPlagueEnd = "\"Death_Plague_end;Death_Plague_end;Death_Plague_end;Death_Plague_end;Death_Plague_end;Death_Plague_end;Death_Plague_end;Death_Plague_end;Death_Plague_end;Death_Plague_end;Death_Plague_end;Death_Plague_end;Death_Plague_end;Death_Plague_end;Death_Plague_end;\",";

        string MCDeathPlagueStart = "\"MC_Death_Plague;MC_Death_Plague;MC_Death_Plague;MC_Death_Plague;MC_Death_Plague;MC_Death_Plague;MC_Death_Plague;MC_Death_Plague;MC_Death_Plague;MC_Death_Plague;MC_Death_Plague;MC_Death_Plague;MC_Death_Plague;MC_Death_Plague;MC_Death_Plague;\",";
        string speechMCDeathPlague = "\";En'tera;En'tera;En'tera;En'tera;En'tera;En'tera;En'tera;En'tera;En'tera;En'tera;En'tera;En'tera;En'tera;En'tera;\",";
        string MCDeathPlagueEnd = "\"MC_Death_Plague_end;MC_Death_Plague_end;MC_Death_Plague_end;MC_Death_Plague_end;MC_Death_Plague_end;MC_Death_Plague_end;MC_Death_Plague_end;MC_Death_Plague_end;MC_Death_Plague_end;MC_Death_Plague_end;MC_Death_Plague_end;MC_Death_Plague_end;MC_Death_Plague_end;MC_Death_Plague_end;MC_Death_Plague_end;\",";

        string BwBoltStart = "\"Bw_Bolt;Bw_Bolt;Bw_Bolt;Bw_Bolt;Bw_Bolt;Bw_Bolt;Bw_Bolt;Bw_Bolt;Bw_Bolt;Bw_Bolt;Bw_Bolt;Bw_Bolt;Bw_Bolt;Bw_Bolt;Bw_Bolt;\",";
        string speechBwBolt = "\";In Nag Zur!;In Nag Zur...;因纳戈祖尔……;In Nag Zur...;In Nag Zur...;In Nag Zur !;In Nag Zur...;In Nag Zur...;In Nag Zur...;In Nag Zur...;イン・ナグ・ズール…;In Nag Zur...;In Nag Zur...;In Nag Zur...;\",";
        string BwBoltEnd = "\"Bw_Bolt_end;Bw_Bolt_end;Bw_Bolt_end;Bw_Bolt_end;Bw_Bolt_end;Bw_Bolt_end;Bw_Bolt_end;Bw_Bolt_end;Bw_Bolt_end;Bw_Bolt_end;Bw_Bolt_end;Bw_Bolt_end;Bw_Bolt_end;Bw_Bolt_end;Bw_Bolt_end;\",";

        string MCBwBoltStart = "\"MC_Bw_Bolt;MC_Bw_Bolt;MC_Bw_Bolt;MC_Bw_Bolt;MC_Bw_Bolt;MC_Bw_Bolt;MC_Bw_Bolt;MC_Bw_Bolt;MC_Bw_Bolt;MC_Bw_Bolt;MC_Bw_Bolt;MC_Bw_Bolt;MC_Bw_Bolt;MC_Bw_Bolt;MC_Bw_Bolt;\",";
        string speechMCBwBolt = "\";in Nag zu ...?;in Nag zu ...?;in Nag zu ...?;in Nag zu ...?;in Nag zu ...?;in Nag zu ...?;in Nag zu ...?;in Nag zu ...?;in Nag zu ...?;in Nag zu ...?;in Nag zu ...?;in Nag zu ...?;in Nag zu ...?;in Nag zu ...?;\",";
        string MCBwBoltEnd = "\"MC_Bw_Bolt_end;MC_Bw_Bolt_end;MC_Bw_Bolt_end;MC_Bw_Bolt_end;MC_Bw_Bolt_end;MC_Bw_Bolt_end;MC_Bw_Bolt_end;MC_Bw_Bolt_end;MC_Bw_Bolt_end;MC_Bw_Bolt_end;MC_Bw_Bolt_end;MC_Bw_Bolt_end;MC_Bw_Bolt_end;MC_Bw_Bolt_end;MC_Bw_Bolt_end;\",";

        string PcurseStart = "\"Pcurse;Pcurse;Pcurse;Pcurse;Pcurse;Pcurse;Pcurse;Pcurse;Pcurse;Pcurse;Pcurse;Pcurse;Pcurse;Pcurse;Pcurse;\",";
        string speechPcurse = "\";Shaggrath Azud...;Shaggrath Azud!;沙格拉斯'阿祖得！;Shaggrath Azud!;¡Shaggrath Azud!;Shaggrath Azud...;Shaggrath Azud!;Shaggrath Azud!;Shaggrath Azud!;Shaggrath Azud!;シャグラト・アズード！;Shaggrath Azud!;Shaggrath Azud!;Shaggrath Azud!;\",";
        string PcurseEnd = "\"Pcurse_end;Pcurse_end;Pcurse_end;Pcurse_end;Pcurse_end;Pcurse_end;Pcurse_end;Pcurse_end;Pcurse_end;Pcurse_end;Pcurse_end;Pcurse_end;Pcurse_end;Pcurse_end;Pcurse_end;\",";

        string MCPcurseStart = "\"MC_Pcurse;MC_Pcurse;MC_Pcurse;MC_Pcurse;MC_Pcurse;MC_Pcurse;MC_Pcurse;MC_Pcurse;MC_Pcurse;MC_Pcurse;MC_Pcurse;MC_Pcurse;MC_Pcurse;MC_Pcurse;MC_Pcurse;\",";
        string speechMCPcurse = "\";Shagerath erm ...?;Shagerath erm ...?;Shagerath erm ...?;Shagerath erm ...?;Shagerath erm ...?;Shagerath erm ...?;Shagerath erm ...?;Shagerath erm ...?;Shagerath erm ...?;Shagerath erm ...?;Shagerath erm ...?;Shagerath erm ...?;Shagerath erm ...?;Shagerath erm ...?;\",";
        string MCPcurseEnd = "\"MC_Pcurse_end;MC_Pcurse_end;MC_Pcurse_end;MC_Pcurse_end;MC_Pcurse_end;MC_Pcurse_end;MC_Pcurse_end;MC_Pcurse_end;MC_Pcurse_end;MC_Pcurse_end;MC_Pcurse_end;MC_Pcurse_end;MC_Pcurse_end;MC_Pcurse_end;MC_Pcurse_end;\",";

        string BwResurrectionStart = "\"Bw_Resurrection;Bw_Resurrection;Bw_Resurrection;Bw_Resurrection;Bw_Resurrection;Bw_Resurrection;Bw_Resurrection;Bw_Resurrection;Bw_Resurrection;Bw_Resurrection;Bw_Resurrection;Bw_Resurrection;Bw_Resurrection;Bw_Resurrection;Bw_Resurrection;\",";
        string speechBwResurrection = "\";Lagur! Lagur! Lagur!;Lagur! Lagur! Lagur!;拉古尔！拉古尔！拉古尔！;Lagur! Lagur! Lagur!;¡Lagur! ¡Lagur! ¡Lagur!;Lagur ! Lagur ! Lagur !;Lagur! Lagur! Lagur!;Lagur! Lagur! Lagur!;Lagur! Lagur! Lagur!;Lagur! Lagur! Lagur!;ラグール！ ラグール！ ラグール！;Lagur! Lagur! Lagur!;Lagur! Lagur! Lagur!;Lagur! Lagur! Lagur!;\",";
        string BwResurrectionEnd = "\"Bw_Resurrection_end;Bw_Resurrection_end;Bw_Resurrection_end;Bw_Resurrection_end;Bw_Resurrection_end;Bw_Resurrection_end;Bw_Resurrection_end;Bw_Resurrection_end;Bw_Resurrection_end;Bw_Resurrection_end;Bw_Resurrection_end;Bw_Resurrection_end;Bw_Resurrection_end;Bw_Resurrection_end;Bw_Resurrection_end;\",";

        string MCBwResurrectionStart = "\"MC_Bw_Resurrection;MC_Bw_Resurrection;MC_Bw_Resurrection;MC_Bw_Resurrection;MC_Bw_Resurrection;MC_Bw_Resurrection;MC_Bw_Resurrection;MC_Bw_Resurrection;MC_Bw_Resurrection;MC_Bw_Resurrection;MC_Bw_Resurrection;MC_Bw_Resurrection;MC_Bw_Resurrection;MC_Bw_Resurrection;MC_Bw_Resurrection;\",";
        string speechMCBwResurrection = "\";Lagu Lagu La ... ?!;Lagu Lagu La ... ?!;Lagu Lagu La ... ?!;Lagu Lagu La ... ?!;Lagu Lagu La ... ?!;Lagu Lagu La ... ?!;Lagu Lagu La ... ?!;Lagu Lagu La ... ?!;Lagu Lagu La ... ?!;Lagu Lagu La ... ?!;Lagu Lagu La ... ?!;Lagu Lagu La ... ?!;Lagu Lagu La ... ?!;Lagu Lagu La ... ?!;\",";
        string MCBwResurrectionEnd = "\"MC_Bw_Resurrection_end;MC_Bw_Resurrection_end;MC_Bw_Resurrection_end;MC_Bw_Resurrection_end;MC_Bw_Resurrection_end;MC_Bw_Resurrection_end;MC_Bw_Resurrection_end;MC_Bw_Resurrection_end;MC_Bw_Resurrection_end;MC_Bw_Resurrection_end;MC_Bw_Resurrection_end;MC_Bw_Resurrection_end;MC_Bw_Resurrection_end;MC_Bw_Resurrection_end;MC_Bw_Resurrection_end;\",";
        
        string speech = MCWraithStart + speechMCWraith + MCWraithEnd + 
            WraithSart + speechWraith + WraithEnd + 
            LostSoulsStart + speechLostSouls + LostSoulsEnd + 
            MCLostSoulsStart + speechMCLostSouls + MCLostSoulsEnd +
            MCbwTouchStart + speechMCbwTouch + MCbwTouchEnd +
            bwTouchStart + speechbwTouch + bwTouchEnd +
            bwBlessStart + speechbwBless + bwBlessEnd +
            MCbwBlessStart + speechMCbwBless + MCbwBlessEnd +
            DeathPlagueStart + speechDeathPlague + DeathPlagueEnd +
            MCDeathPlagueStart + speechMCDeathPlague + MCDeathPlagueEnd +
            BwBoltStart + speechBwBolt + BwBoltEnd +
            MCBwBoltStart + speechMCBwBolt + MCBwBoltEnd + 
            PcurseStart + speechPcurse + PcurseEnd +
            MCPcurseStart + speechMCPcurse + MCPcurseEnd +
            BwResurrectionStart + speechBwResurrection + BwResurrectionEnd +
            MCBwResurrectionStart + speechMCBwResurrection + MCBwResurrectionEnd;
        
        foreach(string item in input)
        {
            if (item.Contains(forbidden))
            {
                string newItem = item.Insert(item.IndexOf(forbidden) + forbidden.Length, speech);
                yield return newItem;
            }
            else
            {
                yield return item;
            }
        }
    }
    private static IEnumerable<string> SkillsStatIterator(IEnumerable<string> input)
    {
        string undead = "\"// UNDEAD;;;;;;;;;;;;;;;;;;;;;;;;;;\",";
        string skillsStat = "\"Bw_Bless;o_bw_blessing_birth;Target Object;vis;14;26;0;0;0;0;0;normal;spell;0;;necromancy;0;1;;2;x;;;;;1;\"," +
        "\"Death_Plague;o_absorption_soul;Target Object;7;5;13;0;0;0;0;0;normal;spell;0;s_essence_leech_;necromancy;0;1;;4;x;;;;;1;\"," +
        "\"Wraith_Binding;o_bw_wraith_summoning;Target Point;6;9;30;0;0;0;0;0;normal;spell;0;s_wraithsummon_;necromancy;0;1;;66;x;;;;1;1;\"," +
        "\"Lostsouls;o_Lostsouls;No Target;6;44;90;0;0;11;11;0;normal;spell;0;;necromancy;0;1;;44;x;;;;1;1;\"," +
        "\"Bw_Bolt;o_bw_ballbirth;Target Point;6;3;13;12;0;0;0;0;normal;spell;1;;necromancy;0;1;;6;66;;;;;1;\"," +
        "\"Bw_Resurrection;o_bw_resurrection_birth;Target Object;6;26;33;0;0;0;0;0;normal;spell;0;;necromancy;0;1;;33;x;;;;1;1;\"," +
        "\"Pcurse;o_bw_cursebirth;Target Object;5;9;18;0;0;0;0;0;normal;spell;2;;necromancy;0;1;;9;x;;;;;1;\"," +
        "\"Bw_Touch;o_bw_touch;Target Object;6;13;26;0;0;0;0;0;normal;spell;0;;necromancy;0;1;;17;33;;;;;1;\",";
        foreach(string item in input)
        {
            if (item.Contains(undead))
            {
                string newItem = item.Insert(item.IndexOf(undead) + undead.Length, skillsStat);
                yield return newItem;
            }
            else
            {
                yield return item;
            }
        }
    }
    private static IEnumerable<string> SkillsIterator(IEnumerable<string> input)
    {
        string skills = "\"Soul_Explosion;Жертвоприношение души;Mastery of Binding;Mastery of Binding;Mastery of Binding;Mastery of Binding;Mastery of Binding;Mastery of Binding;Mastery of Binding;Mastery of Binding;Mastery of Binding;Mastery of Binding;\"," +
        "\"imortall;Бессмертие;Immortality;Immortality;Immortality;Immortality;Immortality;Immortality;Immortality;Immortality;Immortality;Immortality;\"," +
        "\"kingdead;Архитеургия;Archtheurgy;Archtheurgy;Archtheurgy;Archtheurgy;Archtheurgy;Archtheurgy;Archtheurgy;Archtheurgy;Archtheurgy;Archtheurgy;\"," +
        "\"Lostsouls;Великий ритуал воскрешения;Triple Hand Reunion;Greater Ritual of Resurrection;Greater Ritual of Resurrection;Greater Ritual of Resurrection;Greater Ritual of Resurrection;Greater Ritual of Resurrection;Greater Ritual of Resurrection;Greater Ritual of Resurrection;Greater Ritual of Resurrection;Greater Ritual of Resurrection;\"," +
        "\"Death_Plague;Поглощение души;Essence Leech;Essence Leech;Essence Leech;Essence Leech;Essence Leech;Essence Leech;Essence Leech;Essence Leech;Essence Leech;Essence Leech;\"," + 
        "\"nmadness;Расцветающее безумие;Blooming Madness;Blooming Madness;Blooming Madness;Blooming Madness;Blooming Madness;Blooming Madness;Blooming Madness;Blooming Madness;Blooming Madness;Blooming Madness;\"," +
        "\"unholymind;Жатва хаоса;Presence of Darkness;Presence of Darkness;Presence of Darkness;Presence of Darkness;Presence of Darkness;Presence of Darkness;Presence of Darkness;Presence of Darkness;Presence of Darkness;Presence of Darkness;\"," + 
        "\"ndarkness;Абсолютная тьма;Sealed Mind;Sealed Mind;Sealed Mind;Sealed Mind;Sealed Mind;Sealed Mind;Sealed Mind;Sealed Mind;Sealed Mind;Sealed Mind;\"," +
        "\"Pcurse;Мучительное проклятие;Withering Curse;Withering Curse;Withering Curse;Withering Curse;Withering Curse;Withering Curse;Withering Curse;Withering Curse;Withering Curse;Withering Curse;\"," +
        "\"Bw_Bless;Дары Смерти;Death's Blessing;Death's Blessing;Death's Blessing;Death's Blessing;Death's Blessing;Death's Blessing;Death's Blessing;Death's Blessing;Death's Blessing;Death's Blessing;\"," +
        "\"Bw_Bolt;Осквернение;Desecration;Desecration;Desecration;Desecration;Desecration;Desecration;Desecration;Desecration;Desecration;Desecration;\"," +
        "\"Bw_Resurrection;Воскрешение;Resurrection;低等起死还魂;Kleines Ritual der Auferstehung;Lesser Ritual of Resurrection;Lesser Ritual of Resurrection;Rituale di Resurrezione Inferiore;Lesser Ritual of Resurrection;Lesser Ritual of Resurrection;Lesser Ritual of Resurrection;復活の簡易儀式;소규모 부활 의식;\"," +
        "\"Bw_Touch;Касание смерти;Death Touch;Death Touch;Death Touch;Death Touch;Death Touch;Death Touch;Death Touch;Death Touch;Death Touch;Death Touch;\"," +
        "\"Wraith_Binding;Призыв умертвия;Wraith Summoning;Wraith Summoning;Wraith Summoning;Wraith Summoning;Wraith Summoning;Wraith Summoning;Wraith Summoning;Wraith Summoning;Wraith Summoning;Wraith Summoning;\",";

        string undead = "\";;///// UNDEAD;///// UNDEAD;;;;;///// UNDEAD;///// UNDEAD;;;;\",";
        string skillsDesc = @"""Soul_Explosion;
        Накладывает на союзную нежить эффект ~r~\""Жертвоприношение души\""~/~, который можно активировать вручную.##Эффект автоматически применяется на цели с менее чем ~r~33%~/~ запаса здоровья.##При активации эффекта, цель взрывается, нанося ~ur~нечестивый урон~/~ по всем соседним клеткам, равный оставшемуся у неё запасу здоровья, после чего накладывает на заклинателя ~p~\""Тëмный договор\""~/~ на ~w~12~/~ ходов:##~lg~+3~/~ к урону оружия ~ur~нечестивостью~/~#~lg~+3~/~к урону оружия ~p~арканой~/~#~lg~+7.5%~/~ к похищению жизни##Отвязывание нежити (кроме ~w~умертвий~/~) находящейся под эффектом ~r~\""Жертвоприношения души\""~/~ накладывает на заклинателя эффект ~lg~\""Исключительная душа\""~/~ на ~w~8~/~ ходов, позволяющий на время действия избежать штрафов от ~r~\""Одержимости\""~/~.##Каждая активация требует ~bl~10%~/~ запаса энергии.;
        Unbinding allies doesn't take a turn and replenishes ~bl~Energy~/~ equal to ~w~10%~/~ of your Magic Power.##Increases the ~w~level~/~ of summoning abilities by ~lg~1~/~.;
        Unbinding allies doesn't take a turn and replenishes ~bl~Energy~/~ equal to ~w~10%~/~ of your Magic Power.##Increases the ~w~level~/~ of summoning abilities by ~lg~1~/~.;
        Unbinding allies doesn't take a turn and replenishes ~bl~Energy~/~ equal to ~w~10%~/~ of your Magic Power.##Increases the ~w~level~/~ of summoning abilities by ~lg~1~/~.;
        Unbinding allies doesn't take a turn and replenishes ~bl~Energy~/~ equal to ~w~10%~/~ of your Magic Power.##Increases the ~w~level~/~ of summoning abilities by ~lg~1~/~.;
        Unbinding allies doesn't take a turn and replenishes ~bl~Energy~/~ equal to ~w~10%~/~ of your Magic Power.##Increases the ~w~level~/~ of summoning abilities by ~lg~1~/~.;
        Unbinding allies doesn't take a turn and replenishes ~bl~Energy~/~ equal to ~w~10%~/~ of your Magic Power.##Increases the ~w~level~/~ of summoning abilities by ~lg~1~/~.;
        Unbinding allies doesn't take a turn and replenishes ~bl~Energy~/~ equal to ~w~10%~/~ of your Magic Power.##Increases the ~w~level~/~ of summoning abilities by ~lg~1~/~.;
        Unbinding allies doesn't take a turn and replenishes ~bl~Energy~/~ equal to ~w~10%~/~ of your Magic Power.##Increases the ~w~level~/~ of summoning abilities by ~lg~1~/~.;
        Unbinding allies doesn't take a turn and replenishes ~bl~Energy~/~ equal to ~w~10%~/~ of your Magic Power.##Increases the ~w~level~/~ of summoning abilities by ~lg~1~/~.;
        Unbinding allies doesn't take a turn and replenishes ~bl~Energy~/~ equal to ~w~10%~/~ of your Magic Power.##Increases the ~w~level~/~ of summoning abilities by ~lg~1~/~.;
        "",
        ""imortall;
        Позволяет избегать смертельных ударов, пока ~r~порог здоровья~/~ и ~lg~мораль~/~ выше ~lg~50%~/~.##Когда ~r~здоровье~/~ опускается до ~w~2~/~, происходит следующее:##~r~-10%~/~ к морали#~r~+2%~/~ к усталости#Восстанавливает ~lg~33%~/~ запаса здоровья и ~bl~33%~/~ энергии##Персонаж больше не может ~r~умереть~/~ от жажды и голода.;
        Prevents dying from lethal hits as long as ~r~Max Health~/~ and ~lg~Morale~/~ are both higher than ~lg~50%~/~.##When ~r~Health~/~ drops below 2, replenishes ~lg~33%~/~ of ~r~Max Health~/~ and ~bl~Max Energy~/~, and applies:##~r~-10% Morale~/~#~r~+2% Fatigue~/~##Prevents ~r~death~/~ from starvation or dehydration.;
        Prevents dying from lethal hits as long as ~r~Max Health~/~ and ~lg~Morale~/~ are both higher than ~lg~50%~/~.##When ~r~Health~/~ drops below 2, replenishes ~lg~33%~/~ of ~r~Max Health~/~ and ~bl~Max Energy~/~, and applies:##~r~-10% Morale~/~#~r~+2% Fatigue~/~##Prevents ~r~death~/~ from starvation or dehydration.;
        Prevents dying from lethal hits as long as ~r~Max Health~/~ and ~lg~Morale~/~ are both higher than ~lg~50%~/~.##When ~r~Health~/~ drops below 2, replenishes ~lg~33%~/~ of ~r~Max Health~/~ and ~bl~Max Energy~/~, and applies:##~r~-10% Morale~/~#~r~+2% Fatigue~/~##Prevents ~r~death~/~ from starvation or dehydration.;
        Prevents dying from lethal hits as long as ~r~Max Health~/~ and ~lg~Morale~/~ are both higher than ~lg~50%~/~.##When ~r~Health~/~ drops below 2, replenishes ~lg~33%~/~ of ~r~Max Health~/~ and ~bl~Max Energy~/~, and applies:##~r~-10% Morale~/~#~r~+2% Fatigue~/~##Prevents ~r~death~/~ from starvation or dehydration.;
        Prevents dying from lethal hits as long as ~r~Max Health~/~ and ~lg~Morale~/~ are both higher than ~lg~50%~/~.##When ~r~Health~/~ drops below 2, replenishes ~lg~33%~/~ of ~r~Max Health~/~ and ~bl~Max Energy~/~, and applies:##~r~-10% Morale~/~#~r~+2% Fatigue~/~##Prevents ~r~death~/~ from starvation or dehydration.;
        Prevents dying from lethal hits as long as ~r~Max Health~/~ and ~lg~Morale~/~ are both higher than ~lg~50%~/~.##When ~r~Health~/~ drops below 2, replenishes ~lg~33%~/~ of ~r~Max Health~/~ and ~bl~Max Energy~/~, and applies:##~r~-10% Morale~/~#~r~+2% Fatigue~/~##Prevents ~r~death~/~ from starvation or dehydration.;
        Prevents dying from lethal hits as long as ~r~Max Health~/~ and ~lg~Morale~/~ are both higher than ~lg~50%~/~.##When ~r~Health~/~ drops below 2, replenishes ~lg~33%~/~ of ~r~Max Health~/~ and ~bl~Max Energy~/~, and applies:##~r~-10% Morale~/~#~r~+2% Fatigue~/~##Prevents ~r~death~/~ from starvation or dehydration.;
        Prevents dying from lethal hits as long as ~r~Max Health~/~ and ~lg~Morale~/~ are both higher than ~lg~50%~/~.##When ~r~Health~/~ drops below 2, replenishes ~lg~33%~/~ of ~r~Max Health~/~ and ~bl~Max Energy~/~, and applies:##~r~-10% Morale~/~#~r~+2% Fatigue~/~##Prevents ~r~death~/~ from starvation or dehydration.;
        Prevents dying from lethal hits as long as ~r~Max Health~/~ and ~lg~Morale~/~ are both higher than ~lg~50%~/~.##When ~r~Health~/~ drops below 2, replenishes ~lg~33%~/~ of ~r~Max Health~/~ and ~bl~Max Energy~/~, and applies:##~r~-10% Morale~/~#~r~+2% Fatigue~/~##Prevents ~r~death~/~ from starvation or dehydration.;
        Prevents dying from lethal hits as long as ~r~Max Health~/~ and ~lg~Morale~/~ are both higher than ~lg~50%~/~.##When ~r~Health~/~ drops below 2, replenishes ~lg~33%~/~ of ~r~Max Health~/~ and ~bl~Max Energy~/~, and applies:##~r~-10% Morale~/~#~r~+2% Fatigue~/~##Prevents ~r~death~/~ from starvation or dehydration.;
        "",
        ""kingdead;
        Произнесение ~w~заклинаний~/~ наносит ~ur~/*Unholy_Damage*/ нечестивого урона~/~ (урон равен ~lg~5%~/~ от ~w~силы магии~/~) всем врагам в поле зрения.##~w~Воскрешение нежити~/~, ~w~призыв умертвий~/~, ~w~поглощение душ~/~ или ~w~получение~/~ ~lg~\""Дара Смерти\""~/~ имеет ~lg~33%~/~ шанс активировать эффект ~lg~\""Вознесение\""~/~ на ~w~6~/~ ходов:##~lg~+33%~/~ к сопр. нечестивому урону#~lg~+99%~/~ к силе чудес#Конвертирует ~ur~нечестивый урон~/~ в ~ly~священный~/~.;
        Casting ~w~Spells~/~ deal ~ur~/*Unholy_Damage*/ Unholy Damage~/~ to all enemies within vision (based on ~lg~3.33%~/~ of ~w~Magic Power~/~).##~w~Raising the dead~/~, ~w~summoning wraiths~/~, ~w~Stealing Essence~/~ or ~w~receiving~/~ ~lg~\""Death's Blessing\""~/~ has ~lg~33%~/~ chance to activate ~lg~\""Ascension\""~/~ for ~w~6~/~ turns, granting:##~lg~+33%~/~ Unholy Resistance#~lg~+66%~/~ Miracle Potency#Converts ~ur~Unholy Damage~/~ into ~ly~Sacred Damage~/~.;
        Casting ~w~Spells~/~ deal ~ur~/*Unholy_Damage*/ Unholy Damage~/~ to all enemies within vision (based on ~lg~3.33%~/~ of ~w~Magic Power~/~).##~w~Raising the dead~/~, ~w~summoning wraiths~/~, ~w~Stealing Essence~/~ or ~w~receiving~/~ ~lg~\""Death's Blessing\""~/~ has ~lg~33%~/~ chance to activate ~lg~\""Ascension\""~/~ for ~w~6~/~ turns, granting:##~lg~+33%~/~ Unholy Resistance#~lg~+66%~/~ Miracle Potency#Converts ~ur~Unholy Damage~/~ into ~ly~Sacred Damage~/~.;
        Casting ~w~Spells~/~ deal ~ur~/*Unholy_Damage*/ Unholy Damage~/~ to all enemies within vision (based on ~lg~3.33%~/~ of ~w~Magic Power~/~).##~w~Raising the dead~/~, ~w~summoning wraiths~/~, ~w~Stealing Essence~/~ or ~w~receiving~/~ ~lg~\""Death's Blessing\""~/~ has ~lg~33%~/~ chance to activate ~lg~\""Ascension\""~/~ for ~w~6~/~ turns, granting:##~lg~+33%~/~ Unholy Resistance#~lg~+66%~/~ Miracle Potency#Converts ~ur~Unholy Damage~/~ into ~ly~Sacred Damage~/~.;
        Casting ~w~Spells~/~ deal ~ur~/*Unholy_Damage*/ Unholy Damage~/~ to all enemies within vision (based on ~lg~3.33%~/~ of ~w~Magic Power~/~).##~w~Raising the dead~/~, ~w~summoning wraiths~/~, ~w~Stealing Essence~/~ or ~w~receiving~/~ ~lg~\""Death's Blessing\""~/~ has ~lg~33%~/~ chance to activate ~lg~\""Ascension\""~/~ for ~w~6~/~ turns, granting:##~lg~+33%~/~ Unholy Resistance#~lg~+66%~/~ Miracle Potency#Converts ~ur~Unholy Damage~/~ into ~ly~Sacred Damage~/~.;
        Casting ~w~Spells~/~ deal ~ur~/*Unholy_Damage*/ Unholy Damage~/~ to all enemies within vision (based on ~lg~3.33%~/~ of ~w~Magic Power~/~).##~w~Raising the dead~/~, ~w~summoning wraiths~/~, ~w~Stealing Essence~/~ or ~w~receiving~/~ ~lg~\""Death's Blessing\""~/~ has ~lg~33%~/~ chance to activate ~lg~\""Ascension\""~/~ for ~w~6~/~ turns, granting:##~lg~+33%~/~ Unholy Resistance#~lg~+66%~/~ Miracle Potency#Converts ~ur~Unholy Damage~/~ into ~ly~Sacred Damage~/~.;
        Casting ~w~Spells~/~ deal ~ur~/*Unholy_Damage*/ Unholy Damage~/~ to all enemies within vision (based on ~lg~3.33%~/~ of ~w~Magic Power~/~).##~w~Raising the dead~/~, ~w~summoning wraiths~/~, ~w~Stealing Essence~/~ or ~w~receiving~/~ ~lg~\""Death's Blessing\""~/~ has ~lg~33%~/~ chance to activate ~lg~\""Ascension\""~/~ for ~w~6~/~ turns, granting:##~lg~+33%~/~ Unholy Resistance#~lg~+66%~/~ Miracle Potency#Converts ~ur~Unholy Damage~/~ into ~ly~Sacred Damage~/~.;
        Casting ~w~Spells~/~ deal ~ur~/*Unholy_Damage*/ Unholy Damage~/~ to all enemies within vision (based on ~lg~3.33%~/~ of ~w~Magic Power~/~).##~w~Raising the dead~/~, ~w~summoning wraiths~/~, ~w~Stealing Essence~/~ or ~w~receiving~/~ ~lg~\""Death's Blessing\""~/~ has ~lg~33%~/~ chance to activate ~lg~\""Ascension\""~/~ for ~w~6~/~ turns, granting:##~lg~+33%~/~ Unholy Resistance#~lg~+66%~/~ Miracle Potency#Converts ~ur~Unholy Damage~/~ into ~ly~Sacred Damage~/~.;
        Casting ~w~Spells~/~ deal ~ur~/*Unholy_Damage*/ Unholy Damage~/~ to all enemies within vision (based on ~lg~3.33%~/~ of ~w~Magic Power~/~).##~w~Raising the dead~/~, ~w~summoning wraiths~/~, ~w~Stealing Essence~/~ or ~w~receiving~/~ ~lg~\""Death's Blessing\""~/~ has ~lg~33%~/~ chance to activate ~lg~\""Ascension\""~/~ for ~w~6~/~ turns, granting:##~lg~+33%~/~ Unholy Resistance#~lg~+66%~/~ Miracle Potency#Converts ~ur~Unholy Damage~/~ into ~ly~Sacred Damage~/~.;
        Casting ~w~Spells~/~ deal ~ur~/*Unholy_Damage*/ Unholy Damage~/~ to all enemies within vision (based on ~lg~3.33%~/~ of ~w~Magic Power~/~).##~w~Raising the dead~/~, ~w~summoning wraiths~/~, ~w~Stealing Essence~/~ or ~w~receiving~/~ ~lg~\""Death's Blessing\""~/~ has ~lg~33%~/~ chance to activate ~lg~\""Ascension\""~/~ for ~w~6~/~ turns, granting:##~lg~+33%~/~ Unholy Resistance#~lg~+66%~/~ Miracle Potency#Converts ~ur~Unholy Damage~/~ into ~ly~Sacred Damage~/~.;
        Casting ~w~Spells~/~ deal ~ur~/*Unholy_Damage*/ Unholy Damage~/~ to all enemies within vision (based on ~lg~3.33%~/~ of ~w~Magic Power~/~).##~w~Raising the dead~/~, ~w~summoning wraiths~/~, ~w~Stealing Essence~/~ or ~w~receiving~/~ ~lg~\""Death's Blessing\""~/~ has ~lg~33%~/~ chance to activate ~lg~\""Ascension\""~/~ for ~w~6~/~ turns, granting:##~lg~+33%~/~ Unholy Resistance#~lg~+66%~/~ Miracle Potency#Converts ~ur~Unholy Damage~/~ into ~ly~Sacred Damage~/~.;
        "",";
        string a =@"
        ""Lostsouls;
        Воскрешает до ~w~3~/~ трупов в радиусе ~w~6~/~ клеток, восстанавливая поднятой нежити ~lg~33%~/~ запаса здоровья и ~bl~33~/~ запаса энергии.##Призывает ~w~Умертвие~/~ за каждый недостающий труп в радиусе действия. Сила ~w~Умертвии~/~ зависит от степени ~lg~\""Поглощëнной души\""~/~ заклинателя.##Накладывает на заклинателя эффект ~lg~\""Исключительная душа\""Z""~/~ на ~w~5~/~-~w~7~/~ ходов за каждый призыв ~w~Умертвия~/~. Призванные ~w~Умертвия~/~ ~r~возвращаются в загробный мир~/~ по истечению ~lg~\""Исключительной души\""~/~.##Использование этого заклинания ~r~невозможно~/~ под эффектом ~r~\""Одержимости\""~/~ или ~lg~\""Исключительной души\""~/~.;
        Reanimates up to ~w~3~/~ corpses within ~w~6~/~ tiles, restoring them to ~lg~33%~/~ of their ~r~Max Health~/~ and ~lg~33%~/~ ~bl~Max Energy~/~.##Summons a ~w~Wraith~/~ for each missing corpse within the area of effect. The ~w~Wraith's~/~ power depends on the number of ~lg~\""Essence Charge\""~/~ stacks.##Grants ~w~3-6~/~ turns of ~lg~\""Disorder\""~/~ for each instance of ~w~Summoning~/~. ~w~Wraiths~/~ ~r~die~/~ once ~lg~\""Disorder\""~/~ expires.##This spell cannot be cast while under the effects of ~r~\""Obsession\""~/~ or ~lg~\""Disorder\""~/~.;
        Reanimates up to ~w~3~/~ corpses within ~w~6~/~ tiles, restoring them to ~lg~33%~/~ of their ~r~Max Health~/~ and ~lg~33%~/~ ~bl~Max Energy~/~.##Summons a ~w~Wraith~/~ for each missing corpse within the area of effect. The ~w~Wraith's~/~ power depends on the number of ~lg~\""Essence Charge\""~/~ stacks.##Grants ~w~3-6~/~ turns of ~lg~\""Disorder\""~/~ for each instance of ~w~Summoning~/~. ~w~Wraiths~/~ ~r~die~/~ once ~lg~\""Disorder\""~/~ expires.##This spell cannot be cast while under the effects of ~r~\""Obsession\""~/~ or ~lg~\""Disorder\""~/~.;
        Reanimates up to ~w~3~/~ corpses within ~w~6~/~ tiles, restoring them to ~lg~33%~/~ of their ~r~Max Health~/~ and ~lg~33%~/~ ~bl~Max Energy~/~.##Summons a ~w~Wraith~/~ for each missing corpse within the area of effect. The ~w~Wraith's~/~ power depends on the number of ~lg~\""Essence Charge\""~/~ stacks.##Grants ~w~3-6~/~ turns of ~lg~\""Disorder\""~/~ for each instance of ~w~Summoning~/~. ~w~Wraiths~/~ ~r~die~/~ once ~lg~\""Disorder\""~/~ expires.##This spell cannot be cast while under the effects of ~r~\""Obsession\""~/~ or ~lg~\""Disorder\""~/~.;
        Reanimates up to ~w~3~/~ corpses within ~w~6~/~ tiles, restoring them to ~lg~33%~/~ of their ~r~Max Health~/~ and ~lg~33%~/~ ~bl~Max Energy~/~.##Summons a ~w~Wraith~/~ for each missing corpse within the area of effect. The ~w~Wraith's~/~ power depends on the number of ~lg~\""Essence Charge\""~/~ stacks.##Grants ~w~3-6~/~ turns of ~lg~\""Disorder\""~/~ for each instance of ~w~Summoning~/~. ~w~Wraiths~/~ ~r~die~/~ once ~lg~\""Disorder\""~/~ expires.##This spell cannot be cast while under the effects of ~r~\""Obsession\""~/~ or ~lg~\""Disorder\""~/~.;
        Reanimates up to ~w~3~/~ corpses within ~w~6~/~ tiles, restoring them to ~lg~33%~/~ of their ~r~Max Health~/~ and ~lg~33%~/~ ~bl~Max Energy~/~.##Summons a ~w~Wraith~/~ for each missing corpse within the area of effect. The ~w~Wraith's~/~ power depends on the number of ~lg~\""Essence Charge\""~/~ stacks.##Grants ~w~3-6~/~ turns of ~lg~\""Disorder\""~/~ for each instance of ~w~Summoning~/~. ~w~Wraiths~/~ ~r~die~/~ once ~lg~\""Disorder\""~/~ expires.##This spell cannot be cast while under the effects of ~r~\""Obsession\""~/~ or ~lg~\""Disorder\""~/~.;
        Reanimates up to ~w~3~/~ corpses within ~w~6~/~ tiles, restoring them to ~lg~33%~/~ of their ~r~Max Health~/~ and ~lg~33%~/~ ~bl~Max Energy~/~.##Summons a ~w~Wraith~/~ for each missing corpse within the area of effect. The ~w~Wraith's~/~ power depends on the number of ~lg~\""Essence Charge\""~/~ stacks.##Grants ~w~3-6~/~ turns of ~lg~\""Disorder\""~/~ for each instance of ~w~Summoning~/~. ~w~Wraiths~/~ ~r~die~/~ once ~lg~\""Disorder\""~/~ expires.##This spell cannot be cast while under the effects of ~r~\""Obsession\""~/~ or ~lg~\""Disorder\""~/~.;
        Reanimates up to ~w~3~/~ corpses within ~w~6~/~ tiles, restoring them to ~lg~33%~/~ of their ~r~Max Health~/~ and ~lg~33%~/~ ~bl~Max Energy~/~.##Summons a ~w~Wraith~/~ for each missing corpse within the area of effect. The ~w~Wraith's~/~ power depends on the number of ~lg~\""Essence Charge\""~/~ stacks.##Grants ~w~3-6~/~ turns of ~lg~\""Disorder\""~/~ for each instance of ~w~Summoning~/~. ~w~Wraiths~/~ ~r~die~/~ once ~lg~\""Disorder\""~/~ expires.##This spell cannot be cast while under the effects of ~r~\""Obsession\""~/~ or ~lg~\""Disorder\""~/~.;
        Reanimates up to ~w~3~/~ corpses within ~w~6~/~ tiles, restoring them to ~lg~33%~/~ of their ~r~Max Health~/~ and ~lg~33%~/~ ~bl~Max Energy~/~.##Summons a ~w~Wraith~/~ for each missing corpse within the area of effect. The ~w~Wraith's~/~ power depends on the number of ~lg~\""Essence Charge\""~/~ stacks.##Grants ~w~3-6~/~ turns of ~lg~\""Disorder\""~/~ for each instance of ~w~Summoning~/~. ~w~Wraiths~/~ ~r~die~/~ once ~lg~\""Disorder\""~/~ expires.##This spell cannot be cast while under the effects of ~r~\""Obsession\""~/~ or ~lg~\""Disorder\""~/~.;
        Reanimates up to ~w~3~/~ corpses within ~w~6~/~ tiles, restoring them to ~lg~33%~/~ of their ~r~Max Health~/~ and ~lg~33%~/~ ~bl~Max Energy~/~.##Summons a ~w~Wraith~/~ for each missing corpse within the area of effect. The ~w~Wraith's~/~ power depends on the number of ~lg~\""Essence Charge\""~/~ stacks.##Grants ~w~3-6~/~ turns of ~lg~\""Disorder\""~/~ for each instance of ~w~Summoning~/~. ~w~Wraiths~/~ ~r~die~/~ once ~lg~\""Disorder\""~/~ expires.##This spell cannot be cast while under the effects of ~r~\""Obsession\""~/~ or ~lg~\""Disorder\""~/~.;
        Reanimates up to ~w~3~/~ corpses within ~w~6~/~ tiles, restoring them to ~lg~33%~/~ of their ~r~Max Health~/~ and ~lg~33%~/~ ~bl~Max Energy~/~.##Summons a ~w~Wraith~/~ for each missing corpse within the area of effect. The ~w~Wraith's~/~ power depends on the number of ~lg~\""Essence Charge\""~/~ stacks.##Grants ~w~3-6~/~ turns of ~lg~\""Disorder\""~/~ for each instance of ~w~Summoning~/~. ~w~Wraiths~/~ ~r~die~/~ once ~lg~\""Disorder\""~/~ expires.##This spell cannot be cast while under the effects of ~r~\""Obsession\""~/~ or ~lg~\""Disorder\""~/~.;
        "",
        ""Death_Plague;
        Убивает случайную союзную нежить или уничтожает один из ближайших трупов.##Приоритет выбора целей: ~w~Трупы~/~ > ~w~Умертвия~/~ > ~w~Нежить~/~.##Активирует эффект ~lg~\""Поглощëнная душа\""~/~ на ~w~30~/~ ходов:##~lg~+13%~/~ к силе магии#~lg~-9%~/~ к затратам на заклинания#~lg~-9%~/~ к времени восст. способностей#~lg~-9%~/~ к получаемому урону#~lg~+66%~/~ к сопр. усталости (этот эффект уменьшается с ростом степени эффекта)##Использование ~w~Заклинаний~/~ уменьшает степень эффекта на ~r~1~/~.##Повторное использование этого заклинания увеличивает степень эффекта (вплоть до ~w~IV~/~) и обновляет его длительность.;
        Devours a targeted corpse or steals ~r~13%~/~ Max Health and ~bl~13%~/~ Max Energy from an Undead ally, transferring half of them to the caster.##Activates ~lg~\""Essence Charge\""~/~ for ~w~30~/~ turns:##~lg~+5%~/~ Weapon Damage#~lg~+10%~/~ Magic Power#~lg~-6%~/~ Abilities Energy Cost#~lg~+8~/~ Max Energy#~lg~+66%~/~ Fatigue Resistance (this effect decreases based on the stacks)##~w~III~/~ and ~w~IV~/~ stacks of the effect: slight chance of causing ~r~\""Obsession\""~/~.##Using ~w~Spells~/~ reduce the number of stacks by ~r~1~/~.##The repeated use of the spell grants an extra stack of the effect (up to ~w~IV~/~) and refreshes its duration.;
        Devours a targeted corpse or steals ~r~13%~/~ Max Health and ~bl~13%~/~ Max Energy from an Undead ally, transferring half of them to the caster.##Activates ~lg~\""Essence Charge\""~/~ for ~w~30~/~ turns:##~lg~+5%~/~ Weapon Damage#~lg~+10%~/~ Magic Power#~lg~-6%~/~ Abilities Energy Cost#~lg~+8~/~ Max Energy#~lg~+66%~/~ Fatigue Resistance (this effect decreases based on the stacks)##~w~III~/~ and ~w~IV~/~ stacks of the effect: slight chance of causing ~r~\""Obsession\""~/~.##Using ~w~Spells~/~ reduce the number of stacks by ~r~1~/~.##The repeated use of the spell grants an extra stack of the effect (up to ~w~IV~/~) and refreshes its duration.;
        Devours a targeted corpse or steals ~r~13%~/~ Max Health and ~bl~13%~/~ Max Energy from an Undead ally, transferring half of them to the caster.##Activates ~lg~\""Essence Charge\""~/~ for ~w~30~/~ turns:##~lg~+5%~/~ Weapon Damage#~lg~+10%~/~ Magic Power#~lg~-6%~/~ Abilities Energy Cost#~lg~+8~/~ Max Energy#~lg~+66%~/~ Fatigue Resistance (this effect decreases based on the stacks)##~w~III~/~ and ~w~IV~/~ stacks of the effect: slight chance of causing ~r~\""Obsession\""~/~.##Using ~w~Spells~/~ reduce the number of stacks by ~r~1~/~.##The repeated use of the spell grants an extra stack of the effect (up to ~w~IV~/~) and refreshes its duration.;
        Devours a targeted corpse or steals ~r~13%~/~ Max Health and ~bl~13%~/~ Max Energy from an Undead ally, transferring half of them to the caster.##Activates ~lg~\""Essence Charge\""~/~ for ~w~30~/~ turns:##~lg~+5%~/~ Weapon Damage#~lg~+10%~/~ Magic Power#~lg~-6%~/~ Abilities Energy Cost#~lg~+8~/~ Max Energy#~lg~+66%~/~ Fatigue Resistance (this effect decreases based on the stacks)##~w~III~/~ and ~w~IV~/~ stacks of the effect: slight chance of causing ~r~\""Obsession\""~/~.##Using ~w~Spells~/~ reduce the number of stacks by ~r~1~/~.##The repeated use of the spell grants an extra stack of the effect (up to ~w~IV~/~) and refreshes its duration.;
        Devours a targeted corpse or steals ~r~13%~/~ Max Health and ~bl~13%~/~ Max Energy from an Undead ally, transferring half of them to the caster.##Activates ~lg~\""Essence Charge\""~/~ for ~w~30~/~ turns:##~lg~+5%~/~ Weapon Damage#~lg~+10%~/~ Magic Power#~lg~-6%~/~ Abilities Energy Cost#~lg~+8~/~ Max Energy#~lg~+66%~/~ Fatigue Resistance (this effect decreases based on the stacks)##~w~III~/~ and ~w~IV~/~ stacks of the effect: slight chance of causing ~r~\""Obsession\""~/~.##Using ~w~Spells~/~ reduce the number of stacks by ~r~1~/~.##The repeated use of the spell grants an extra stack of the effect (up to ~w~IV~/~) and refreshes its duration.;
        Devours a targeted corpse or steals ~r~13%~/~ Max Health and ~bl~13%~/~ Max Energy from an Undead ally, transferring half of them to the caster.##Activates ~lg~\""Essence Charge\""~/~ for ~w~30~/~ turns:##~lg~+5%~/~ Weapon Damage#~lg~+10%~/~ Magic Power#~lg~-6%~/~ Abilities Energy Cost#~lg~+8~/~ Max Energy#~lg~+66%~/~ Fatigue Resistance (this effect decreases based on the stacks)##~w~III~/~ and ~w~IV~/~ stacks of the effect: slight chance of causing ~r~\""Obsession\""~/~.##Using ~w~Spells~/~ reduce the number of stacks by ~r~1~/~.##The repeated use of the spell grants an extra stack of the effect (up to ~w~IV~/~) and refreshes its duration.;
        Devours a targeted corpse or steals ~r~13%~/~ Max Health and ~bl~13%~/~ Max Energy from an Undead ally, transferring half of them to the caster.##Activates ~lg~\""Essence Charge\""~/~ for ~w~30~/~ turns:##~lg~+5%~/~ Weapon Damage#~lg~+10%~/~ Magic Power#~lg~-6%~/~ Abilities Energy Cost#~lg~+8~/~ Max Energy#~lg~+66%~/~ Fatigue Resistance (this effect decreases based on the stacks)##~w~III~/~ and ~w~IV~/~ stacks of the effect: slight chance of causing ~r~\""Obsession\""~/~.##Using ~w~Spells~/~ reduce the number of stacks by ~r~1~/~.##The repeated use of the spell grants an extra stack of the effect (up to ~w~IV~/~) and refreshes its duration.;
        Devours a targeted corpse or steals ~r~13%~/~ Max Health and ~bl~13%~/~ Max Energy from an Undead ally, transferring half of them to the caster.##Activates ~lg~\""Essence Charge\""~/~ for ~w~30~/~ turns:##~lg~+5%~/~ Weapon Damage#~lg~+10%~/~ Magic Power#~lg~-6%~/~ Abilities Energy Cost#~lg~+8~/~ Max Energy#~lg~+66%~/~ Fatigue Resistance (this effect decreases based on the stacks)##~w~III~/~ and ~w~IV~/~ stacks of the effect: slight chance of causing ~r~\""Obsession\""~/~.##Using ~w~Spells~/~ reduce the number of stacks by ~r~1~/~.##The repeated use of the spell grants an extra stack of the effect (up to ~w~IV~/~) and refreshes its duration.;
        Devours a targeted corpse or steals ~r~13%~/~ Max Health and ~bl~13%~/~ Max Energy from an Undead ally, transferring half of them to the caster.##Activates ~lg~\""Essence Charge\""~/~ for ~w~30~/~ turns:##~lg~+5%~/~ Weapon Damage#~lg~+10%~/~ Magic Power#~lg~-6%~/~ Abilities Energy Cost#~lg~+8~/~ Max Energy#~lg~+66%~/~ Fatigue Resistance (this effect decreases based on the stacks)##~w~III~/~ and ~w~IV~/~ stacks of the effect: slight chance of causing ~r~\""Obsession\""~/~.##Using ~w~Spells~/~ reduce the number of stacks by ~r~1~/~.##The repeated use of the spell grants an extra stack of the effect (up to ~w~IV~/~) and refreshes its duration.;
        Devours a targeted corpse or steals ~r~13%~/~ Max Health and ~bl~13%~/~ Max Energy from an Undead ally, transferring half of them to the caster.##Activates ~lg~\""Essence Charge\""~/~ for ~w~30~/~ turns:##~lg~+5%~/~ Weapon Damage#~lg~+10%~/~ Magic Power#~lg~-6%~/~ Abilities Energy Cost#~lg~+8~/~ Max Energy#~lg~+66%~/~ Fatigue Resistance (this effect decreases based on the stacks)##~w~III~/~ and ~w~IV~/~ stacks of the effect: slight chance of causing ~r~\""Obsession\""~/~.##Using ~w~Spells~/~ reduce the number of stacks by ~r~1~/~.##The repeated use of the spell grants an extra stack of the effect (up to ~w~IV~/~) and refreshes its duration.;
        "",
        ""nmadness;
        Медленно восполняет ~lg~мораль~/~.##Даëт ~g~+33%~/~ к сопр. нечестивому урону и ~g~+25%~/~ к сопр. боли.##~r~Препятствует~/~ получению ~ly~\""Благословения\""~/~.;
        Successfully raising the dead allows you to ~y~learn~/~ their ~w~active abilities~/~ (for as long as they are available via skill menu).##Increases ~y~Experience Gain~/~ of Undead kills by ~lg~50%~/~.;
        Successfully raising the dead allows you to ~y~learn~/~ their ~w~active abilities~/~ (for as long as they are available via skill menu).##Increases ~y~Experience Gain~/~ of Undead kills by ~lg~50%~/~.;
        Successfully raising the dead allows you to ~y~learn~/~ their ~w~active abilities~/~ (for as long as they are available via skill menu).##Increases ~y~Experience Gain~/~ of Undead kills by ~lg~50%~/~.;
        Successfully raising the dead allows you to ~y~learn~/~ their ~w~active abilities~/~ (for as long as they are available via skill menu).##Increases ~y~Experience Gain~/~ of Undead kills by ~lg~50%~/~.;
        Successfully raising the dead allows you to ~y~learn~/~ their ~w~active abilities~/~ (for as long as they are available via skill menu).##Increases ~y~Experience Gain~/~ of Undead kills by ~lg~50%~/~.;
        Successfully raising the dead allows you to ~y~learn~/~ their ~w~active abilities~/~ (for as long as they are available via skill menu).##Increases ~y~Experience Gain~/~ of Undead kills by ~lg~50%~/~.;
        Successfully raising the dead allows you to ~y~learn~/~ their ~w~active abilities~/~ (for as long as they are available via skill menu).##Increases ~y~Experience Gain~/~ of Undead kills by ~lg~50%~/~.;
        Successfully raising the dead allows you to ~y~learn~/~ their ~w~active abilities~/~ (for as long as they are available via skill menu).##Increases ~y~Experience Gain~/~ of Undead kills by ~lg~50%~/~.;
        Successfully raising the dead allows you to ~y~learn~/~ their ~w~active abilities~/~ (for as long as they are available via skill menu).##Increases ~y~Experience Gain~/~ of Undead kills by ~lg~50%~/~.;
        "",
        ""unholymind;
        Произнесение заклинаний ветки даёт всей нежити в поле зрения ~r~-33%~/~ к сопр. нечестивому урону на ~w~3~/~ хода.##Суммируется до ~w~3~/~ раз.##Немного снижает штрафы ~r~\""Одержимости\""~/~.##Смерть врага от рук союзной нежити в поле зрения даёт ~lg~50%~/~ ~y~опыта~/~.;
        Each turn, decreases max Unholy Resistance of Undeads and Proselytes by ~r~7%~/~ within ~w~7~/~ tiles, which persists for ~w~9~/~ turns.##This effect stacks up to ~w~9~/~ times.##If affecting by ~r~\""Obsession\""~/~, the effect triggers twice per turn.;
        Casting this ability tree's spells apply all Undeads within vision with ~r~-33%~/~ Unholy Resistance for ~w~3~/~ turns (up to ~w~3~/~ times).##Partially decreases penalties of ~r~\""Obsession\""~/~.##Witnessing the death of an enemy grants ~lg~50%~/~ of their ~y~XP~/~.;
        Casting this ability tree's spells apply all Undeads within vision with ~r~-33%~/~ Unholy Resistance for ~w~3~/~ turns (up to ~w~3~/~ times).##Partially decreases penalties of ~r~\""Obsession\""~/~.##Witnessing the death of an enemy grants ~lg~50%~/~ of their ~y~XP~/~.;
        Casting this ability tree's spells apply all Undeads within vision with ~r~-33%~/~ Unholy Resistance for ~w~3~/~ turns (up to ~w~3~/~ times).##Partially decreases penalties of ~r~\""Obsession\""~/~.##Witnessing the death of an enemy grants ~lg~50%~/~ of their ~y~XP~/~.;
        Casting this ability tree's spells apply all Undeads within vision with ~r~-33%~/~ Unholy Resistance for ~w~3~/~ turns (up to ~w~3~/~ times).##Partially decreases penalties of ~r~\""Obsession\""~/~.##Witnessing the death of an enemy grants ~lg~50%~/~ of their ~y~XP~/~.;
        Casting this ability tree's spells apply all Undeads within vision with ~r~-33%~/~ Unholy Resistance for ~w~3~/~ turns (up to ~w~3~/~ times).##Partially decreases penalties of ~r~\""Obsession\""~/~.##Witnessing the death of an enemy grants ~lg~50%~/~ of their ~y~XP~/~.;
        Casting this ability tree's spells apply all Undeads within vision with ~r~-33%~/~ Unholy Resistance for ~w~3~/~ turns (up to ~w~3~/~ times).##Partially decreases penalties of ~r~\""Obsession\""~/~.##Witnessing the death of an enemy grants ~lg~50%~/~ of their ~y~XP~/~.;
        Casting this ability tree's spells apply all Undeads within vision with ~r~-33%~/~ Unholy Resistance for ~w~3~/~ turns (up to ~w~3~/~ times).##Partially decreases penalties of ~r~\""Obsession\""~/~.##Witnessing the death of an enemy grants ~lg~50%~/~ of their ~y~XP~/~.;
        Casting this ability tree's spells apply all Undeads within vision with ~r~-33%~/~ Unholy Resistance for ~w~3~/~ turns (up to ~w~3~/~ times).##Partially decreases penalties of ~r~\""Obsession\""~/~.##Witnessing the death of an enemy grants ~lg~50%~/~ of their ~y~XP~/~.;
        Casting this ability tree's spells apply all Undeads within vision with ~r~-33%~/~ Unholy Resistance for ~w~3~/~ turns (up to ~w~3~/~ times).##Partially decreases penalties of ~r~\""Obsession\""~/~.##Witnessing the death of an enemy grants ~lg~50%~/~ of their ~y~XP~/~.;"",
        ""ndarkness;
        ~lg~Уполовинивает~/~ потери рассудка от умений ~w~Оккультизма~/~.##Отвязывание нежити не тратит ход и восполняет количество ~bl~энергии~/~ равное ~lg~5%~/~ от ~w~силы магии~/~.##Увеличивает максимальное число воскрешëнной нежити на ~lg~1~/~.;
        Halves sanity loss of ~w~Occultism~/~ abilities and partially decreases penalties of ~r~\""Obsession\""~/~.##Grants ~lg~33%~/~ Unholy Resistance.;
        Halves sanity loss of ~w~Occultism~/~ abilities and partially decreases penalties of ~r~\""Obsession\""~/~.##Grants ~lg~33%~/~ Unholy Resistance.;
        Halves sanity loss of ~w~Occultism~/~ abilities and partially decreases penalties of ~r~\""Obsession\""~/~.##Grants ~lg~33%~/~ Unholy Resistance.;
        Halves sanity loss of ~w~Occultism~/~ abilities and partially decreases penalties of ~r~\""Obsession\""~/~.##Grants ~lg~33%~/~ Unholy Resistance.;
        Halves sanity loss of ~w~Occultism~/~ abilities and partially decreases penalties of ~r~\""Obsession\""~/~.##Grants ~lg~33%~/~ Unholy Resistance.;
        Halves sanity loss of ~w~Occultism~/~ abilities and partially decreases penalties of ~r~\""Obsession\""~/~.##Grants ~lg~33%~/~ Unholy Resistance.;
        Halves sanity loss of ~w~Occultism~/~ abilities and partially decreases penalties of ~r~\""Obsession\""~/~.##Grants ~lg~33%~/~ Unholy Resistance.;
        Halves sanity loss of ~w~Occultism~/~ abilities and partially decreases penalties of ~r~\""Obsession\""~/~.##Grants ~lg~33%~/~ Unholy Resistance.;
        Halves sanity loss of ~w~Occultism~/~ abilities and partially decreases penalties of ~r~\""Obsession\""~/~.##Grants ~lg~33%~/~ Unholy Resistance.;
        Halves sanity loss of ~w~Occultism~/~ abilities and partially decreases penalties of ~r~\""Obsession\""~/~.##Grants ~lg~33%~/~ Unholy Resistance.;
        "",
        ""Pcurse;
        Накладывает на цель эффект ~r~\""Мучительное проклятие\""~/~ на ~w~13~/~ ходов:##~r~+0.5%~/~ к изменению боли#~r~-4%~/~ к урону оружия#~r~-5%~/~ к силе магии#~r~-5%~/~ к запасу здоровья#~r~+4%~/~ к получаемому урону##~w~IV~/~ степень: каждый ход ухудшает состояние случайной части тела на ~r~1%~/~##Каждый ход увеличивает степень эффекта (вплоть до ~w~IV~/~). Обычные удары, выстрелы и применение способностей уменьшают степень на ~lg~2~/~.;
        Applies the target with ~r~\""Withering Curse\""~/~ for ~w~13~/~ turns:##~r~-9%~/~ Fortitude#~r~-9%~/~ Magic Resistance#~r~-7%~/~ Nature Resistance#~r~-6%~/~ Max Health#~r~+4%~/~ Damage Taken##Each turn worsens the Condition of a random body part by ~r~0.5%~/~ per each stack.##Hitting the target by ~lg~\""Desecration\""~/~ or the the repeated use of the spell against the same target applies an extra stack of the effect (up to ~w~III~/~).;
        Applies the target with ~r~\""Withering Curse\""~/~ for ~w~13~/~ turns:##~r~-9%~/~ Fortitude#~r~-9%~/~ Magic Resistance#~r~-7%~/~ Nature Resistance#~r~-6%~/~ Max Health#~r~+4%~/~ Damage Taken##Each turn worsens the Condition of a random body part by ~r~0.5%~/~ per each stack.##Hitting the target by ~lg~\""Desecration\""~/~ or the the repeated use of the spell against the same target applies an extra stack of the effect (up to ~w~III~/~).;
        Applies the target with ~r~\""Withering Curse\""~/~ for ~w~13~/~ turns:##~r~-9%~/~ Fortitude#~r~-9%~/~ Magic Resistance#~r~-7%~/~ Nature Resistance#~r~-6%~/~ Max Health#~r~+4%~/~ Damage Taken##Each turn worsens the Condition of a random body part by ~r~0.5%~/~ per each stack.##Hitting the target by ~lg~\""Desecration\""~/~ or the the repeated use of the spell against the same target applies an extra stack of the effect (up to ~w~III~/~).;
        Applies the target with ~r~\""Withering Curse\""~/~ for ~w~13~/~ turns:##~r~-9%~/~ Fortitude#~r~-9%~/~ Magic Resistance#~r~-7%~/~ Nature Resistance#~r~-6%~/~ Max Health#~r~+4%~/~ Damage Taken##Each turn worsens the Condition of a random body part by ~r~0.5%~/~ per each stack.##Hitting the target by ~lg~\""Desecration\""~/~ or the the repeated use of the spell against the same target applies an extra stack of the effect (up to ~w~III~/~).;
        Applies the target with ~r~\""Withering Curse\""~/~ for ~w~13~/~ turns:##~r~-9%~/~ Fortitude#~r~-9%~/~ Magic Resistance#~r~-7%~/~ Nature Resistance#~r~-6%~/~ Max Health#~r~+4%~/~ Damage Taken##Each turn worsens the Condition of a random body part by ~r~0.5%~/~ per each stack.##Hitting the target by ~lg~\""Desecration\""~/~ or the the repeated use of the spell against the same target applies an extra stack of the effect (up to ~w~III~/~).;
        Applies the target with ~r~\""Withering Curse\""~/~ for ~w~13~/~ turns:##~r~-9%~/~ Fortitude#~r~-9%~/~ Magic Resistance#~r~-7%~/~ Nature Resistance#~r~-6%~/~ Max Health#~r~+4%~/~ Damage Taken##Each turn worsens the Condition of a random body part by ~r~0.5%~/~ per each stack.##Hitting the target by ~lg~\""Desecration\""~/~ or the the repeated use of the spell against the same target applies an extra stack of the effect (up to ~w~III~/~).;
        Applies the target with ~r~\""Withering Curse\""~/~ for ~w~13~/~ turns:##~r~-9%~/~ Fortitude#~r~-9%~/~ Magic Resistance#~r~-7%~/~ Nature Resistance#~r~-6%~/~ Max Health#~r~+4%~/~ Damage Taken##Each turn worsens the Condition of a random body part by ~r~0.5%~/~ per each stack.##Hitting the target by ~lg~\""Desecration\""~/~ or the the repeated use of the spell against the same target applies an extra stack of the effect (up to ~w~III~/~).;
        Applies the target with ~r~\""Withering Curse\""~/~ for ~w~13~/~ turns:##~r~-9%~/~ Fortitude#~r~-9%~/~ Magic Resistance#~r~-7%~/~ Nature Resistance#~r~-6%~/~ Max Health#~r~+4%~/~ Damage Taken##Each turn worsens the Condition of a random body part by ~r~0.5%~/~ per each stack.##Hitting the target by ~lg~\""Desecration\""~/~ or the the repeated use of the spell against the same target applies an extra stack of the effect (up to ~w~III~/~).;
        Applies the target with ~r~\""Withering Curse\""~/~ for ~w~13~/~ turns:##~r~-9%~/~ Fortitude#~r~-9%~/~ Magic Resistance#~r~-7%~/~ Nature Resistance#~r~-6%~/~ Max Health#~r~+4%~/~ Damage Taken##Each turn worsens the Condition of a random body part by ~r~0.5%~/~ per each stack.##Hitting the target by ~lg~\""Desecration\""~/~ or the the repeated use of the spell against the same target applies an extra stack of the effect (up to ~w~III~/~).;
        Applies the target with ~r~\""Withering Curse\""~/~ for ~w~13~/~ turns:##~r~-9%~/~ Fortitude#~r~-9%~/~ Magic Resistance#~r~-7%~/~ Nature Resistance#~r~-6%~/~ Max Health#~r~+4%~/~ Damage Taken##Each turn worsens the Condition of a random body part by ~r~0.5%~/~ per each stack.##Hitting the target by ~lg~\""Desecration\""~/~ or the the repeated use of the spell against the same target applies an extra stack of the effect (up to ~w~III~/~).;
        "",
        ""Bw_Bless;
        Восполняет цели ~lg~/*H_P*/%~/~ запаса здоровья и восстанавливает ~lg~ 33%~/~ состояния частей тела от количества восполненного здоровья.##Лечение на ~lg~50%~/~ эффективнее для союзной Нежити.##Накладывает на цель эффект ~lg~\""Дар Смерти\""~/~ на ~w~13~/~ ходов:##~lg~+9%~/~ к похищению жизни#~lg~+9%~/~ к похищению энергии#~lg~+13%~/~ к отражению урона;
        Replenishes ~lg~/*H_P*/%~/~ Max Health to the target and improves the condition of bodyparts by ~lg~33%~/~ of the amount of health replenished.##This effect is ~lg~50%~/~ more effective on allied Undeads.##grants the target ~lg~\""Death's Blessing\""~/~ for ~w~13~/~ turns:##~lg~+9%~/~ Life Drain#~lg~+9%~/~ Energy Drain#~lg~+13%~/~ Damage Reflection;
        Replenishes ~lg~/*H_P*/%~/~ Max Health to the target and improves the condition of bodyparts by ~lg~33%~/~ of the amount of health replenished.##This effect is ~lg~50%~/~ more effective on allied Undeads.##grants the target ~lg~\""Death's Blessing\""~/~ for ~w~13~/~ turns:##~lg~+9%~/~ Life Drain#~lg~+9%~/~ Energy Drain#~lg~+13%~/~ Damage Reflection;
        Replenishes ~lg~/*H_P*/%~/~ Max Health to the target and improves the condition of bodyparts by ~lg~33%~/~ of the amount of health replenished.##This effect is ~lg~50%~/~ more effective on allied Undeads.##grants the target ~lg~\""Death's Blessing\""~/~ for ~w~13~/~ turns:##~lg~+9%~/~ Life Drain#~lg~+9%~/~ Energy Drain#~lg~+13%~/~ Damage Reflection;
        Replenishes ~lg~/*H_P*/%~/~ Max Health to the target and improves the condition of bodyparts by ~lg~33%~/~ of the amount of health replenished.##This effect is ~lg~50%~/~ more effective on allied Undeads.##grants the target ~lg~\""Death's Blessing\""~/~ for ~w~13~/~ turns:##~lg~+9%~/~ Life Drain#~lg~+9%~/~ Energy Drain#~lg~+13%~/~ Damage Reflection;
        Replenishes ~lg~/*H_P*/%~/~ Max Health to the target and improves the condition of bodyparts by ~lg~33%~/~ of the amount of health replenished.##This effect is ~lg~50%~/~ more effective on allied Undeads.##grants the target ~lg~\""Death's Blessing\""~/~ for ~w~13~/~ turns:##~lg~+9%~/~ Life Drain#~lg~+9%~/~ Energy Drain#~lg~+13%~/~ Damage Reflection;
        Replenishes ~lg~/*H_P*/%~/~ Max Health to the target and improves the condition of bodyparts by ~lg~33%~/~ of the amount of health replenished.##This effect is ~lg~50%~/~ more effective on allied Undeads.##grants the target ~lg~\""Death's Blessing\""~/~ for ~w~13~/~ turns:##~lg~+9%~/~ Life Drain#~lg~+9%~/~ Energy Drain#~lg~+13%~/~ Damage Reflection;
        Replenishes ~lg~/*H_P*/%~/~ Max Health to the target and improves the condition of bodyparts by ~lg~33%~/~ of the amount of health replenished.##This effect is ~lg~50%~/~ more effective on allied Undeads.##grants the target ~lg~\""Death's Blessing\""~/~ for ~w~13~/~ turns:##~lg~+9%~/~ Life Drain#~lg~+9%~/~ Energy Drain#~lg~+13%~/~ Damage Reflection;
        Replenishes ~lg~/*H_P*/%~/~ Max Health to the target and improves the condition of bodyparts by ~lg~33%~/~ of the amount of health replenished.##This effect is ~lg~50%~/~ more effective on allied Undeads.##grants the target ~lg~\""Death's Blessing\""~/~ for ~w~13~/~ turns:##~lg~+9%~/~ Life Drain#~lg~+9%~/~ Energy Drain#~lg~+13%~/~ Damage Reflection;
        Replenishes ~lg~/*H_P*/%~/~ Max Health to the target and improves the condition of bodyparts by ~lg~33%~/~ of the amount of health replenished.##This effect is ~lg~50%~/~ more effective on allied Undeads.##grants the target ~lg~\""Death's Blessing\""~/~ for ~w~13~/~ turns:##~lg~+9%~/~ Life Drain#~lg~+9%~/~ Energy Drain#~lg~+13%~/~ Damage Reflection;
        Replenishes ~lg~/*H_P*/%~/~ Max Health to the target and improves the condition of bodyparts by ~lg~33%~/~ of the amount of health replenished.##This effect is ~lg~50%~/~ more effective on allied Undeads.##grants the target ~lg~\""Death's Blessing\""~/~ for ~w~13~/~ turns:##~lg~+9%~/~ Life Drain#~lg~+9%~/~ Energy Drain#~lg~+13%~/~ Damage Reflection;
        "",
        ""Bw_Bolt;
        Выпускает сгусток тёмной энергии, с ~w~/*Hit_Chance*/%~/~ точностью нанося ~ur~/*Unholy_Damage*/ нечестивого урона~/~.##Если заклинание попадает в цель, выжигает ей равное нанесённому урону количество энергии и восполняет столько же энергии заклинателю.##Даëт ~ur~/*Unholy_Damage2*/ нечестивого урона~/~ на ~w~12~/~ ходов.##Эффект не суммируется.;
        Shoots a bolt of dark energy, dealing ~ur~/*Unholy_Damage*/ Unholy Damage~/~ with ~w~/*Hit_Chance*/%~/~ Accuracy.##If the spell hits the target, burns its Energy for the amount of damage dealt and replenishes the same amount of Energy to the caster.##Grants ~ur~/*Unholy_Damage2*/ Unholy Damage~/~ for ~w~12~/~ turns.##This effect doesn't stack.;
        Shoots a bolt of dark energy, dealing ~ur~/*Unholy_Damage*/ Unholy Damage~/~ with ~w~/*Hit_Chance*/%~/~ Accuracy.##If the spell hits the target, burns its Energy for the amount of damage dealt and replenishes the same amount of Energy to the caster.##Grants ~ur~/*Unholy_Damage2*/ Unholy Damage~/~ for ~w~12~/~ turns.##This effect doesn't stack.;
        Shoots a bolt of dark energy, dealing ~ur~/*Unholy_Damage*/ Unholy Damage~/~ with ~w~/*Hit_Chance*/%~/~ Accuracy.##If the spell hits the target, burns its Energy for the amount of damage dealt and replenishes the same amount of Energy to the caster.##Grants ~ur~/*Unholy_Damage2*/ Unholy Damage~/~ for ~w~12~/~ turns.##This effect doesn't stack.;
        Shoots a bolt of dark energy, dealing ~ur~/*Unholy_Damage*/ Unholy Damage~/~ with ~w~/*Hit_Chance*/%~/~ Accuracy.##If the spell hits the target, burns its Energy for the amount of damage dealt and replenishes the same amount of Energy to the caster.##Grants ~ur~/*Unholy_Damage2*/ Unholy Damage~/~ for ~w~12~/~ turns.##This effect doesn't stack.;
        Shoots a bolt of dark energy, dealing ~ur~/*Unholy_Damage*/ Unholy Damage~/~ with ~w~/*Hit_Chance*/%~/~ Accuracy.##If the spell hits the target, burns its Energy for the amount of damage dealt and replenishes the same amount of Energy to the caster.##Grants ~ur~/*Unholy_Damage2*/ Unholy Damage~/~ for ~w~12~/~ turns.##This effect doesn't stack.;
        Shoots a bolt of dark energy, dealing ~ur~/*Unholy_Damage*/ Unholy Damage~/~ with ~w~/*Hit_Chance*/%~/~ Accuracy.##If the spell hits the target, burns its Energy for the amount of damage dealt and replenishes the same amount of Energy to the caster.##Grants ~ur~/*Unholy_Damage2*/ Unholy Damage~/~ for ~w~12~/~ turns.##This effect doesn't stack.;
        Shoots a bolt of dark energy, dealing ~ur~/*Unholy_Damage*/ Unholy Damage~/~ with ~w~/*Hit_Chance*/%~/~ Accuracy.##If the spell hits the target, burns its Energy for the amount of damage dealt and replenishes the same amount of Energy to the caster.##Grants ~ur~/*Unholy_Damage2*/ Unholy Damage~/~ for ~w~12~/~ turns.##This effect doesn't stack.;
        Shoots a bolt of dark energy, dealing ~ur~/*Unholy_Damage*/ Unholy Damage~/~ with ~w~/*Hit_Chance*/%~/~ Accuracy.##If the spell hits the target, burns its Energy for the amount of damage dealt and replenishes the same amount of Energy to the caster.##Grants ~ur~/*Unholy_Damage2*/ Unholy Damage~/~ for ~w~12~/~ turns.##This effect doesn't stack.;
        Shoots a bolt of dark energy, dealing ~ur~/*Unholy_Damage*/ Unholy Damage~/~ with ~w~/*Hit_Chance*/%~/~ Accuracy.##If the spell hits the target, burns its Energy for the amount of damage dealt and replenishes the same amount of Energy to the caster.##Grants ~ur~/*Unholy_Damage2*/ Unholy Damage~/~ for ~w~12~/~ turns.##This effect doesn't stack.;
        Shoots a bolt of dark energy, dealing ~ur~/*Unholy_Damage*/ Unholy Damage~/~ with ~w~/*Hit_Chance*/%~/~ Accuracy.##If the spell hits the target, burns its Energy for the amount of damage dealt and replenishes the same amount of Energy to the caster.##Grants ~ur~/*Unholy_Damage2*/ Unholy Damage~/~ for ~w~12~/~ turns.##This effect doesn't stack.;
        "",
        ""Bw_Resurrection;
        Воскрешает выбранный труп, восполняя поднятой нежити ~lg~66%~/~ запаса здоровья и ~bl~66%~/~ запаса энергии. Прочность брони воскрешаемой нежити равна ~w~0%~/~.##Медленно понижает ~lg~рассудок~/~ до ~r~60%~/~.##Риск ~r~\""Одержимости\""~/~: ~ur~Высокий~/~##Призыв нежити свыше доступного максимума моментально вызывает ~r~\""Одержимость\""~/~ и постоянно продлевает её.##Использование этого заклинания ~r~невозможно~/~ под эффектом ~r~\""Одержимости\""~/~.;
        Reanimates a targeted corpse, replenishing it ~lg~66%~/~ Max Health and ~bl~66%~/~ Max Energy and sets Armor Durability to ~w~0%~/~.##Increases ~lg~morale~/~ (up to ~w~75%~/~).#Slowly decreases ~lg~Sanity~/~ but no less than ~r~60%~/~.##Risk of ~r~\""Obsession\""~/~: ~ur~High~/~#Summoning more than one Undead instantly causes ~r~\""Obsession\""~/~.##~r~Can't~/~ summon Undeads higher than level ~w~/*LEVL*/~/~.##~r~Prevents~/~ from receiving ~ly~\""Blessing\""~/~.##This spell cannot be cast while under the effect of ~r~\""Obsession\""~/~.;
        Reanimates a targeted corpse, replenishing it ~lg~66%~/~ Max Health and ~bl~66%~/~ Max Energy and sets Armor Durability to ~w~0%~/~.##Increases ~lg~morale~/~ (up to ~w~75%~/~).#Slowly decreases ~lg~Sanity~/~ but no less than ~r~60%~/~.##Risk of ~r~\""Obsession\""~/~: ~ur~High~/~#Summoning more than one Undead instantly causes ~r~\""Obsession\""~/~.##~r~Can't~/~ summon Undeads higher than level ~w~/*LEVL*/~/~.##~r~Prevents~/~ from receiving ~ly~\""Blessing\""~/~.##This spell cannot be cast while under the effect of ~r~\""Obsession\""~/~.;
        Reanimates a targeted corpse, replenishing it ~lg~66%~/~ Max Health and ~bl~66%~/~ Max Energy and sets Armor Durability to ~w~0%~/~.##Increases ~lg~morale~/~ (up to ~w~75%~/~).#Slowly decreases ~lg~Sanity~/~ but no less than ~r~60%~/~.##Risk of ~r~\""Obsession\""~/~: ~ur~High~/~#Summoning more than one Undead instantly causes ~r~\""Obsession\""~/~.##~r~Can't~/~ summon Undeads higher than level ~w~/*LEVL*/~/~.##~r~Prevents~/~ from receiving ~ly~\""Blessing\""~/~.##This spell cannot be cast while under the effect of ~r~\""Obsession\""~/~.;
        Reanimates a targeted corpse, replenishing it ~lg~66%~/~ Max Health and ~bl~66%~/~ Max Energy and sets Armor Durability to ~w~0%~/~.##Increases ~lg~morale~/~ (up to ~w~75%~/~).#Slowly decreases ~lg~Sanity~/~ but no less than ~r~60%~/~.##Risk of ~r~\""Obsession\""~/~: ~ur~High~/~#Summoning more than one Undead instantly causes ~r~\""Obsession\""~/~.##~r~Can't~/~ summon Undeads higher than level ~w~/*LEVL*/~/~.##~r~Prevents~/~ from receiving ~ly~\""Blessing\""~/~.##This spell cannot be cast while under the effect of ~r~\""Obsession\""~/~.;
        Reanimates a targeted corpse, replenishing it ~lg~66%~/~ Max Health and ~bl~66%~/~ Max Energy and sets Armor Durability to ~w~0%~/~.##Increases ~lg~morale~/~ (up to ~w~75%~/~).#Slowly decreases ~lg~Sanity~/~ but no less than ~r~60%~/~.##Risk of ~r~\""Obsession\""~/~: ~ur~High~/~#Summoning more than one Undead instantly causes ~r~\""Obsession\""~/~.##~r~Can't~/~ summon Undeads higher than level ~w~/*LEVL*/~/~.##~r~Prevents~/~ from receiving ~ly~\""Blessing\""~/~.##This spell cannot be cast while under the effect of ~r~\""Obsession\""~/~.;
        Reanimates a targeted corpse, replenishing it ~lg~66%~/~ Max Health and ~bl~66%~/~ Max Energy and sets Armor Durability to ~w~0%~/~.##Increases ~lg~morale~/~ (up to ~w~75%~/~).#Slowly decreases ~lg~Sanity~/~ but no less than ~r~60%~/~.##Risk of ~r~\""Obsession\""~/~: ~ur~High~/~#Summoning more than one Undead instantly causes ~r~\""Obsession\""~/~.##~r~Can't~/~ summon Undeads higher than level ~w~/*LEVL*/~/~.##~r~Prevents~/~ from receiving ~ly~\""Blessing\""~/~.##This spell cannot be cast while under the effect of ~r~\""Obsession\""~/~.;
        Reanimates a targeted corpse, replenishing it ~lg~66%~/~ Max Health and ~bl~66%~/~ Max Energy and sets Armor Durability to ~w~0%~/~.##Increases ~lg~morale~/~ (up to ~w~75%~/~).#Slowly decreases ~lg~Sanity~/~ but no less than ~r~60%~/~.##Risk of ~r~\""Obsession\""~/~: ~ur~High~/~#Summoning more than one Undead instantly causes ~r~\""Obsession\""~/~.##~r~Can't~/~ summon Undeads higher than level ~w~/*LEVL*/~/~.##~r~Prevents~/~ from receiving ~ly~\""Blessing\""~/~.##This spell cannot be cast while under the effect of ~r~\""Obsession\""~/~.;
        Reanimates a targeted corpse, replenishing it ~lg~66%~/~ Max Health and ~bl~66%~/~ Max Energy and sets Armor Durability to ~w~0%~/~.##Increases ~lg~morale~/~ (up to ~w~75%~/~).#Slowly decreases ~lg~Sanity~/~ but no less than ~r~60%~/~.##Risk of ~r~\""Obsession\""~/~: ~ur~High~/~#Summoning more than one Undead instantly causes ~r~\""Obsession\""~/~.##~r~Can't~/~ summon Undeads higher than level ~w~/*LEVL*/~/~.##~r~Prevents~/~ from receiving ~ly~\""Blessing\""~/~.##This spell cannot be cast while under the effect of ~r~\""Obsession\""~/~.;
        Reanimates a targeted corpse, replenishing it ~lg~66%~/~ Max Health and ~bl~66%~/~ Max Energy and sets Armor Durability to ~w~0%~/~.##Increases ~lg~morale~/~ (up to ~w~75%~/~).#Slowly decreases ~lg~Sanity~/~ but no less than ~r~60%~/~.##Risk of ~r~\""Obsession\""~/~: ~ur~High~/~#Summoning more than one Undead instantly causes ~r~\""Obsession\""~/~.##~r~Can't~/~ summon Undeads higher than level ~w~/*LEVL*/~/~.##~r~Prevents~/~ from receiving ~ly~\""Blessing\""~/~.##This spell cannot be cast while under the effect of ~r~\""Obsession\""~/~.;
        Reanimates a targeted corpse, replenishing it ~lg~66%~/~ Max Health and ~bl~66%~/~ Max Energy and sets Armor Durability to ~w~0%~/~.##Increases ~lg~morale~/~ (up to ~w~75%~/~).#Slowly decreases ~lg~Sanity~/~ but no less than ~r~60%~/~.##Risk of ~r~\""Obsession\""~/~: ~ur~High~/~#Summoning more than one Undead instantly causes ~r~\""Obsession\""~/~.##~r~Can't~/~ summon Undeads higher than level ~w~/*LEVL*/~/~.##~r~Prevents~/~ from receiving ~ly~\""Blessing\""~/~.##This spell cannot be cast while under the effect of ~r~\""Obsession\""~/~.;
        "",
        ""Bw_Touch;
        Наносит ~ur~/*Unholy_Damage*/ нечестивого урона~/~.##Восполняет всей союзной нежити в зоне видимости количество здоровья равное ~lg~66%~/~ от нанесённого заклинанием урона.;
        Deals ~ur~/*Unholy_Damage*/ Unholy Damage~/~ wtih ~lg~/*I_C*/%~/~ Immobilization Chance.##Replenishes Health to all allies within Vision for ~lg~66%~/~ of the damage dealt by the spell.;
        Deals ~ur~/*Unholy_Damage*/ Unholy Damage~/~ wtih ~lg~/*I_C*/%~/~ Immobilization Chance.##Replenishes Health to all allies within Vision for ~lg~66%~/~ of the damage dealt by the spell.;
        Deals ~ur~/*Unholy_Damage*/ Unholy Damage~/~ wtih ~lg~/*I_C*/%~/~ Immobilization Chance.##Replenishes Health to all allies within Vision for ~lg~66%~/~ of the damage dealt by the spell.;
        Deals ~ur~/*Unholy_Damage*/ Unholy Damage~/~ wtih ~lg~/*I_C*/%~/~ Immobilization Chance.##Replenishes Health to all allies within Vision for ~lg~66%~/~ of the damage dealt by the spell.;
        Deals ~ur~/*Unholy_Damage*/ Unholy Damage~/~ wtih ~lg~/*I_C*/%~/~ Immobilization Chance.##Replenishes Health to all allies within Vision for ~lg~66%~/~ of the damage dealt by the spell.;
        Deals ~ur~/*Unholy_Damage*/ Unholy Damage~/~ wtih ~lg~/*I_C*/%~/~ Immobilization Chance.##Replenishes Health to all allies within Vision for ~lg~66%~/~ of the damage dealt by the spell.;
        Deals ~ur~/*Unholy_Damage*/ Unholy Damage~/~ wtih ~lg~/*I_C*/%~/~ Immobilization Chance.##Replenishes Health to all allies within Vision for ~lg~66%~/~ of the damage dealt by the spell.;
        Deals ~ur~/*Unholy_Damage*/ Unholy Damage~/~ wtih ~lg~/*I_C*/%~/~ Immobilization Chance.##Replenishes Health to all allies within Vision for ~lg~66%~/~ of the damage dealt by the spell.;
        Deals ~ur~/*Unholy_Damage*/ Unholy Damage~/~ wtih ~lg~/*I_C*/%~/~ Immobilization Chance.##Replenishes Health to all allies within Vision for ~lg~66%~/~ of the damage dealt by the spell.;
        Deals ~ur~/*Unholy_Damage*/ Unholy Damage~/~ wtih ~lg~/*I_C*/%~/~ Immobilization Chance.##Replenishes Health to all allies within Vision for ~lg~66%~/~ of the damage dealt by the spell.;
        "",
        ""Wraith_Binding;
        Призывает ~w~Умертвие~/~ на выбранной клетке. Сила ~w~Умертвия~/~ зависит от степени ~lg~\""Поглощëнной души\""~/~ заклинателя.##Произнесение этого заклинания сбрасывает эффект ~lg~\""Поглощëнной души\""~/~.##Если при произнесении в руках нет оружия: даёт этому заклинанию ~lg~-50%~/~ к времени восст. и ~lg~уполовинивает~/~ шанс неудачи.##Риск ~r~\""Одержимости\""~/~: ~r~Неимоверно высокий~/~##Использование этого заклинания ~r~невозможно~/~ под эффектом ~r~\""Одержимости\""~/~.;
        Summons a ~w~Wraith~/~ on the targeted tile. The ~w~Wraith's~/~ power depends on the number of ~lg~\""Essence Charge\""~/~ stacks.##Using the ability removes ~lg~\""Essence Charge\""~/~.##If there was no weapon equipped: grants the skill ~lg~-50%~/~ Cooldown Duration and ~lg~Halves~/~ Miscast Chance.##Risk of ~r~\""Obsession\""~/~: ~r~Extremely High~/~#Summoning more than one Wraith instantly causes ~r~\""Obsession\""~/~.##~r~Can't~/~ summon Wraiths higher than level ~w~/*LEVL*/~/~.##This spell cannot be cast while under the effect of ~r~\""Obsession\""~/~.;
        Summons a ~w~Wraith~/~ on the targeted tile. The ~w~Wraith's~/~ power depends on the number of ~lg~\""Essence Charge\""~/~ stacks.##Using the ability removes ~lg~\""Essence Charge\""~/~.##If there was no weapon equipped: grants the skill ~lg~-50%~/~ Cooldown Duration and ~lg~Halves~/~ Miscast Chance.##Risk of ~r~\""Obsession\""~/~: ~r~Extremely High~/~#Summoning more than one Wraith instantly causes ~r~\""Obsession\""~/~.##~r~Can't~/~ summon Wraiths higher than level ~w~/*LEVL*/~/~.##This spell cannot be cast while under the effect of ~r~\""Obsession\""~/~.;
        Summons a ~w~Wraith~/~ on the targeted tile. The ~w~Wraith's~/~ power depends on the number of ~lg~\""Essence Charge\""~/~ stacks.##Using the ability removes ~lg~\""Essence Charge\""~/~.##If there was no weapon equipped: grants the skill ~lg~-50%~/~ Cooldown Duration and ~lg~Halves~/~ Miscast Chance.##Risk of ~r~\""Obsession\""~/~: ~r~Extremely High~/~#Summoning more than one Wraith instantly causes ~r~\""Obsession\""~/~.##~r~Can't~/~ summon Wraiths higher than level ~w~/*LEVL*/~/~.##This spell cannot be cast while under the effect of ~r~\""Obsession\""~/~.;
        Summons a ~w~Wraith~/~ on the targeted tile. The ~w~Wraith's~/~ power depends on the number of ~lg~\""Essence Charge\""~/~ stacks.##Using the ability removes ~lg~\""Essence Charge\""~/~.##If there was no weapon equipped: grants the skill ~lg~-50%~/~ Cooldown Duration and ~lg~Halves~/~ Miscast Chance.##Risk of ~r~\""Obsession\""~/~: ~r~Extremely High~/~#Summoning more than one Wraith instantly causes ~r~\""Obsession\""~/~.##~r~Can't~/~ summon Wraiths higher than level ~w~/*LEVL*/~/~.##This spell cannot be cast while under the effect of ~r~\""Obsession\""~/~.;
        Summons a ~w~Wraith~/~ on the targeted tile. The ~w~Wraith's~/~ power depends on the number of ~lg~\""Essence Charge\""~/~ stacks.##Using the ability removes ~lg~\""Essence Charge\""~/~.##If there was no weapon equipped: grants the skill ~lg~-50%~/~ Cooldown Duration and ~lg~Halves~/~ Miscast Chance.##Risk of ~r~\""Obsession\""~/~: ~r~Extremely High~/~#Summoning more than one Wraith instantly causes ~r~\""Obsession\""~/~.##~r~Can't~/~ summon Wraiths higher than level ~w~/*LEVL*/~/~.##This spell cannot be cast while under the effect of ~r~\""Obsession\""~/~.;
        Summons a ~w~Wraith~/~ on the targeted tile. The ~w~Wraith's~/~ power depends on the number of ~lg~\""Essence Charge\""~/~ stacks.##Using the ability removes ~lg~\""Essence Charge\""~/~.##If there was no weapon equipped: grants the skill ~lg~-50%~/~ Cooldown Duration and ~lg~Halves~/~ Miscast Chance.##Risk of ~r~\""Obsession\""~/~: ~r~Extremely High~/~#Summoning more than one Wraith instantly causes ~r~\""Obsession\""~/~.##~r~Can't~/~ summon Wraiths higher than level ~w~/*LEVL*/~/~.##This spell cannot be cast while under the effect of ~r~\""Obsession\""~/~.;
        Summons a ~w~Wraith~/~ on the targeted tile. The ~w~Wraith's~/~ power depends on the number of ~lg~\""Essence Charge\""~/~ stacks.##Using the ability removes ~lg~\""Essence Charge\""~/~.##If there was no weapon equipped: grants the skill ~lg~-50%~/~ Cooldown Duration and ~lg~Halves~/~ Miscast Chance.##Risk of ~r~\""Obsession\""~/~: ~r~Extremely High~/~#Summoning more than one Wraith instantly causes ~r~\""Obsession\""~/~.##~r~Can't~/~ summon Wraiths higher than level ~w~/*LEVL*/~/~.##This spell cannot be cast while under the effect of ~r~\""Obsession\""~/~.;
        Summons a ~w~Wraith~/~ on the targeted tile. The ~w~Wraith's~/~ power depends on the number of ~lg~\""Essence Charge\""~/~ stacks.##Using the ability removes ~lg~\""Essence Charge\""~/~.##If there was no weapon equipped: grants the skill ~lg~-50%~/~ Cooldown Duration and ~lg~Halves~/~ Miscast Chance.##Risk of ~r~\""Obsession\""~/~: ~r~Extremely High~/~#Summoning more than one Wraith instantly causes ~r~\""Obsession\""~/~.##~r~Can't~/~ summon Wraiths higher than level ~w~/*LEVL*/~/~.##This spell cannot be cast while under the effect of ~r~\""Obsession\""~/~.;
        Summons a ~w~Wraith~/~ on the targeted tile. The ~w~Wraith's~/~ power depends on the number of ~lg~\""Essence Charge\""~/~ stacks.##Using the ability removes ~lg~\""Essence Charge\""~/~.##If there was no weapon equipped: grants the skill ~lg~-50%~/~ Cooldown Duration and ~lg~Halves~/~ Miscast Chance.##Risk of ~r~\""Obsession\""~/~: ~r~Extremely High~/~#Summoning more than one Wraith instantly causes ~r~\""Obsession\""~/~.##~r~Can't~/~ summon Wraiths higher than level ~w~/*LEVL*/~/~.##This spell cannot be cast while under the effect of ~r~\""Obsession\""~/~.;
        Summons a ~w~Wraith~/~ on the targeted tile. The ~w~Wraith's~/~ power depends on the number of ~lg~\""Essence Charge\""~/~ stacks.##Using the ability removes ~lg~\""Essence Charge\""~/~.##If there was no weapon equipped: grants the skill ~lg~-50%~/~ Cooldown Duration and ~lg~Halves~/~ Miscast Chance.##Risk of ~r~\""Obsession\""~/~: ~r~Extremely High~/~#Summoning more than one Wraith instantly causes ~r~\""Obsession\""~/~.##~r~Can't~/~ summon Wraiths higher than level ~w~/*LEVL*/~/~.##This spell cannot be cast while under the effect of ~r~\""Obsession\""~/~.;
        "",";
  
        foreach(string item in input)
        {
            if (item.Contains("\";skill_name_end") && item.Contains(undead))
            {
                string newItem = item;
                newItem = newItem.Insert(newItem.IndexOf("\";skill_name_end"), skills);
                newItem = newItem.Insert(newItem.IndexOf(undead) + undead.Length, skillsDesc.Replace('\n', ' '));
                yield return newItem;
            }
            else
            {
                yield return item;
            }
        }
    }
}
