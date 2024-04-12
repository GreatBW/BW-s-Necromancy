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
                    Msl.AddObject(
                        name: "o_skill_death_plague_ico", 
                        spriteName: "s_soul_abs", 
                        parentName: "o_skill_ico", 
                        isVisible: true, 
                        isPersistent: false, 
                        isAwake: false,
                        collisionShapeFlags: CollisionShapeFlags.Circle
                    ).ApplyEvent(ModFiles, 
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
                    Msl.AddObject(
                        name: "o_skill_soul_explosion_ico", 
                        spriteName: "s_soulzac", 
                        parentName: "o_skill_passive", 
                        isVisible: true, 
                        isPersistent: false, 
                        isAwake: true,
                        collisionShapeFlags: CollisionShapeFlags.Circle
                    ).ApplyEvent(ModFiles, 
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
                    Msl.AddObject(
                        name: "o_skill_Lostsouls_ico", 
                        spriteName: "s_disasterundead", 
                        parentName: "o_skill_ico", 
                        isVisible: true, 
                        isPersistent: false, 
                        isAwake: true,
                        collisionShapeFlags: CollisionShapeFlags.Circle
                    ).ApplyEvent(ModFiles, 
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

        Msl.AddObject(
            name: "o_skill_bw_resurrection_ico", 
            spriteName: "s_recurct", 
            parentName: "o_skill_ico", 
            isVisible: true, 
            isPersistent: false, 
            isAwake: true,
            collisionShapeFlags: CollisionShapeFlags.Circle
        ).ApplyEvent(ModFiles, 
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

        Msl.AddObject(
            name: "o_skill_bw_wraithsummon_ico", 
            spriteName: "s_wraithbind", 
            parentName: "o_skill_ico", 
            isVisible: true, 
            isPersistent: false, 
            isAwake: true,
            collisionShapeFlags: CollisionShapeFlags.Circle
        ).ApplyEvent(ModFiles, 
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

                    Msl.AddObject(
                        name: "o_bw_curse_ico", 
                        spriteName: "s_pcurse", 
                        parentName: "o_skill_ico", 
                        isVisible: true, 
                        isPersistent: false, 
                        isAwake: true,
                        collisionShapeFlags: CollisionShapeFlags.Circle
                    ).ApplyEvent(ModFiles, 
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
                    Msl.AddObject(
                        name: "o_bw_darkbolt_ico", 
                        spriteName: "s_darkbalz", 
                        parentName: "o_skill_ico", 
                        isVisible: true, 
                        isPersistent: false, 
                        isAwake: true,
                        collisionShapeFlags: CollisionShapeFlags.Circle
                    ).ApplyEvent(ModFiles, 
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
                    Msl.AddObject(
                        name: "o_bw_dark_bless_ico", 
                        spriteName: "s_blusss", 
                        parentName: "o_skill_ico", 
                        isVisible: true, 
                        isPersistent: false, 
                        isAwake: true,
                        collisionShapeFlags: CollisionShapeFlags.Circle
                    ).ApplyEvent(ModFiles, 
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
                    Msl.AddObject(
                        name: "o_skill_bw_touch_ico", 
                        spriteName: "s_dtouch", 
                        parentName: "o_skill_ico", 
                        isVisible: true, 
                        isPersistent: false, 
                        isAwake: true,
                        collisionShapeFlags: CollisionShapeFlags.Circle
                    ).ApplyEvent(ModFiles, 
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

        Msl.LoadGML("gml_GlobalScript_scr_attack")
            .MatchFrom("scr_skill_call_buff(o_db_curse, id)")
            .InsertBelow("scr_skill_call_buff(o_db_painful_curse, id)")
            .Save();  
            
        Msl.LoadGML("gml_GlobalScript_scr_param")
            .MatchFrom("_needChange = argument[1]")
            .InsertBelow("var _zompass = 0\nif (argument_count > 2){\n_zompass = argument[2]}")
            .MatchFrom("faction_id = scr_GetMobParametrString(\"faction\")")
            .InsertAbove("if (_zompass || instance_exists(o_res_buff_creator))\n{\nfaction_id = \"Servant\"\nsubfaction_id = faction_id\n}\nelse{")
            .MatchFrom("subfaction_id = argument[0]")
            .InsertBelow("}")
            .Save();

        Msl.LoadGML("gml_GlobalScript_scr_enemy_cast_spell")
            .MatchFrom("scr_skill_call_buff(o_db_curse, id)")
            .InsertBelow("scr_skill_call_buff(o_db_painful_curse, id)")
            .Save();
            
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

        Msl.LoadGML("gml_GlobalScript_scr_skill_tier_init")
            .MatchFrom("}")
            .InsertAbove(@"
global.necromancy_tier1 = [""Necromancy"", o_skill_death_plague_ico, o_bw_darkbolt_ico, o_bw_curse_ico]
global.necromancy_tier2 = [""Necromancy"", o_skill_bw_resurrection_ico, o_bw_dark_bless_ico, o_pass_skill_nmadness, o_pass_skill_ndarkness]
global.necromancy_tier3 = [""Necromancy"", o_pass_skill_unholymind, o_skill_bw_touch_ico, o_skill_soul_explosion_ico]")
            .Save();

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
}
