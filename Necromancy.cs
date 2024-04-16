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
        // objects
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

        UndertaleGameObject o_inv_magic_treatise = Msl.AddObject(
            name: "o_inv_cgrimoir", 
            spriteName: "s_inv_cg01", 
            parentName: "o_inv_magic_treatise", 
            isVisible: true, 
            isPersistent: true, 
            isAwake: true,
            collisionShapeFlags: CollisionShapeFlags.Circle
        );

        UndertaleGameObject o_inv_cgrimoir2 = Msl.AddObject(
            name: "o_inv_cgrimoir2", 
            spriteName: "s_inv_cg02", 
            parentName: "o_inv_magic_treatise", 
            isVisible: true, 
            isPersistent: true, 
            isAwake: true,
            collisionShapeFlags: CollisionShapeFlags.Circle
        );

        UndertaleGameObject o_inv_cgrimoir3 = Msl.AddObject(
            name: "o_inv_cgrimoir3", 
            spriteName: "s_inv_cg03", 
            parentName: "o_inv_magic_treatise", 
            isVisible: true, 
            isPersistent: true, 
            isAwake: true,
            collisionShapeFlags: CollisionShapeFlags.Circle
        );

        UndertaleGameObject o_loot_cgrimoir = Msl.AddObject(
            name: "o_loot_cgrimoir", 
            spriteName: "s_loot_cg", 
            parentName: "o_consument_loot", 
            isVisible: true, 
            isPersistent: false, 
            isAwake: true,
            collisionShapeFlags: CollisionShapeFlags.Circle
        );

        UndertaleGameObject o_loot_cgrimoir2 = Msl.AddObject(
            name: "o_loot_cgrimoir2", 
            spriteName: "s_loot_cg", 
            parentName: "o_consument_loot", 
            isVisible: true, 
            isPersistent: false, 
            isAwake: true,
            collisionShapeFlags: CollisionShapeFlags.Circle
        );

        UndertaleGameObject o_loot_cgrimoir3 = Msl.AddObject(
            name: "o_loot_cgrimoir3", 
            spriteName: "s_loot_cg", 
            parentName: "o_consument_loot", 
            isVisible: true, 
            isPersistent: false, 
            isAwake: true,
            collisionShapeFlags: CollisionShapeFlags.Circle
        );

        UndertaleGameObject o_mortal_blocker = Msl.AddObject(
            name: "o_mortal_blocker", 
            spriteName: "", 
            parentName: "", 
            isVisible: false, 
            isPersistent: false, 
            isAwake: true,
            collisionShapeFlags: CollisionShapeFlags.Circle
        );

        UndertaleGameObject o_res_buff_creator = Msl.AddObject(
            name: "o_res_buff_creator", 
            spriteName: "", 
            parentName: "", 
            isVisible: false, 
            isPersistent: true, 
            isAwake: true,
            collisionShapeFlags: CollisionShapeFlags.Circle
        );

        UndertaleGameObject o_soul_absorption_impact = Msl.AddObject(
            name: "o_soul_absorption_impact", 
            spriteName: "", 
            parentName: "", 
            isVisible: true, 
            isPersistent: false, 
            isAwake: true,
            collisionShapeFlags: CollisionShapeFlags.Circle
        );

        UndertaleGameObject o_undead_fixer = Msl.AddObject(
            name: "o_undead_fixer", 
            spriteName: "", 
            parentName: "", 
            isVisible: false, 
            isPersistent: false, 
            isAwake: true,
            collisionShapeFlags: CollisionShapeFlags.Circle
        );

        UndertaleGameObject o_skill_category_necromancy = Msl.AddObject(
            name: "o_skill_category_necromancy", 
            spriteName: "", 
            parentName: "o_sklill_category_magic", 
            isVisible: true, 
            isPersistent: false, 
            isAwake: true,
            collisionShapeFlags: CollisionShapeFlags.Circle
        );

        UndertaleGameObject o_soul_destroyer = Msl.AddObject(
            name: "o_soul_destroyer", 
            spriteName: "", 
            parentName: "", 
            isVisible: false, 
            isPersistent: false, 
            isAwake: true,
            collisionShapeFlags: CollisionShapeFlags.Circle
        );

        UndertaleGameObject o_res_new01 = Msl.AddObject(
            name: "o_res_new01", 
            spriteName: "s_res_new", 
            parentName: "", 
            isVisible: true, 
            isPersistent: false, 
            isAwake: true,
            collisionShapeFlags: CollisionShapeFlags.Circle
        );

        UndertaleGameObject o_trashy_corpz = Msl.AddObject(
            name: "o_trashy_corpz", 
            spriteName: "s_fleshpile_rotten", 
            parentName: "", 
            isVisible: true, 
            isPersistent: false, 
            isAwake: true,
            collisionShapeFlags: CollisionShapeFlags.Circle
        );

        UndertaleGameObject o_Lostsouls = Msl.AddObject(
            name: "o_Lostsouls", 
            spriteName: "", 
            parentName: "", 
            isVisible: true, 
            isPersistent: false, 
            isAwake: true,
            collisionShapeFlags: CollisionShapeFlags.Circle
        );

        UndertaleGameObject o_absorption_soul = Msl.AddObject(
            name: "o_absorption_soul", 
            spriteName: "s_essence_leech_cast", 
            parentName: "o_magic_pillar", 
            isVisible: true, 
            isPersistent: false, 
            isAwake: true,
            collisionShapeFlags: CollisionShapeFlags.Circle
        );

        UndertaleGameObject o_b_servemaster = Msl.AddObject(
            name: "o_b_servemaster", 
            spriteName: "s_zompie_passiveskill", 
            parentName: "o_class_skills", 
            isVisible: true, 
            isPersistent: false, 
            isAwake: true,
            collisionShapeFlags: CollisionShapeFlags.Circle
        );

        UndertaleGameObject o_b_Lostsouls = Msl.AddObject(
            name: "o_b_Lostsouls", 
            spriteName: "", 
            parentName: "o_class_skills", 
            isVisible: false, 
            isPersistent: false, 
            isAwake: true,
            collisionShapeFlags: CollisionShapeFlags.Circle
        );

        UndertaleGameObject o_b_unbind = Msl.AddObject(
            name: "o_b_unbind", 
            spriteName: "s_db_curse_new", 
            parentName: "o_class_skills", 
            isVisible: true, 
            isPersistent: false, 
            isAwake: true,
            collisionShapeFlags: CollisionShapeFlags.Circle
        );

        UndertaleGameObject o_db_punishment = Msl.AddObject(
            name: "o_db_punishment", 
            spriteName: "s_buff_punish", 
            parentName: "o_class_skills", 
            isVisible: true, 
            isPersistent: false, 
            isAwake: true,
            collisionShapeFlags: CollisionShapeFlags.Circle
        );

        UndertaleGameObject o_db_takeover = Msl.AddObject(
            name: "o_db_takeover", 
            spriteName: "s_take_over_effect", 
            parentName: "o_mental_debuff", 
            isVisible: true, 
            isPersistent: false, 
            isAwake: true,
            collisionShapeFlags: CollisionShapeFlags.Circle
        );

        UndertaleGameObject o_b_exceptional = Msl.AddObject(
            name: "o_b_exceptional", 
            spriteName: "s_exception_soulus", 
            parentName: "o_magical_buff", 
            isVisible: true, 
            isPersistent: false, 
            isAwake: true,
            collisionShapeFlags: CollisionShapeFlags.Circle
        );

        UndertaleGameObject o_b_charged_soul = Msl.AddObject(
            name: "o_b_charged_soul", 
            spriteName: "s_charged_z", 
            parentName: "o_buff_stage", 
            isVisible: true, 
            isPersistent: false, 
            isAwake: true,
            collisionShapeFlags: CollisionShapeFlags.Circle
        );

        UndertaleGameObject o_b_angel_charm = Msl.AddObject(
            name: "o_b_angel_charm", 
            spriteName: "s_buff_punish", 
            parentName: "o_magical_buff", 
            isVisible: true, 
            isPersistent: false, 
            isAwake: true,
            collisionShapeFlags: CollisionShapeFlags.Circle
        );

        UndertaleGameObject o_b_darkenchant = Msl.AddObject(
            name: "o_b_darkenchant", 
            spriteName: "s_dark_enchant_effect", 
            parentName: "o_magical_buff", 
            isVisible: true, 
            isPersistent: false, 
            isAwake: true,
            collisionShapeFlags: CollisionShapeFlags.Circle
        );

        UndertaleGameObject o_skill_Lostsouls = Msl.AddObject(
            name: "o_skill_Lostsouls", 
            spriteName: "s_disasterundead", 
            parentName: "o_skill", 
            isVisible: true, 
            isPersistent: false, 
            isAwake: true,
            collisionShapeFlags: CollisionShapeFlags.Circle
        );

        UndertaleGameObject o_skill_death_plague = Msl.AddObject(
            name: "o_skill_death_plague", 
            spriteName: "s_soul_abs", 
            parentName: "o_skill", 
            isVisible: true, 
            isPersistent: false, 
            isAwake: true,
            collisionShapeFlags: CollisionShapeFlags.Circle
        );

        UndertaleGameObject o_skill_soul_explosion = Msl.AddObject(
            name: "o_skill_soul_explosion", 
            spriteName: "s_soulzac", 
            parentName: "o_skill", 
            isVisible: true, 
            isPersistent: false, 
            isAwake: true,
            collisionShapeFlags: CollisionShapeFlags.Circle
        );

        UndertaleGameObject o_pass_skill_nmadness = Msl.AddObject(
            name: "o_pass_skill_nmadness", 
            spriteName: "s_growing_madness", 
            parentName: "o_skill_passive", 
            isVisible: true, 
            isPersistent: false, 
            isAwake: true,
            collisionShapeFlags: CollisionShapeFlags.Circle
        );

        UndertaleGameObject o_pass_skill_ndarkness = Msl.AddObject(
            name: "o_pass_skill_ndarkness", 
            spriteName: "s_crazed_by_magic", 
            parentName: "o_skill_passive", 
            isVisible: true, 
            isPersistent: false, 
            isAwake: true,
            collisionShapeFlags: CollisionShapeFlags.Circle
        );

        UndertaleGameObject o_pass_skill_darkblood = Msl.AddObject(
            name: "o_pass_skill_darkblood", 
            spriteName: "s_grim_blood", 
            parentName: "o_skill_passive", 
            isVisible: true, 
            isPersistent: false, 
            isAwake: true,
            collisionShapeFlags: CollisionShapeFlags.Circle
        );

        UndertaleGameObject o_pass_skill_unholymind = Msl.AddObject(
            name: "o_pass_skill_unholymind", 
            spriteName: "s_reaping_darkness", 
            parentName: "o_skill_passive", 
            isVisible: true, 
            isPersistent: false, 
            isAwake: true,
            collisionShapeFlags: CollisionShapeFlags.Circle
        );

        UndertaleGameObject o_pass_skill_imortall = Msl.AddObject(
            name: "o_pass_skill_imortall", 
            spriteName: "s_imortal_soul", 
            parentName: "o_skill_passive", 
            isVisible: true, 
            isPersistent: false, 
            isAwake: true,
            collisionShapeFlags: CollisionShapeFlags.Circle
        );

        UndertaleGameObject o_pass_skill_kingdead = Msl.AddObject(
            name: "o_pass_skill_kingdead", 
            spriteName: "s_angel_of_death", 
            parentName: "o_skill_passive", 
            isVisible: true, 
            isPersistent: false, 
            isAwake: true,
            collisionShapeFlags: CollisionShapeFlags.Circle
        );

        UndertaleGameObject o_allAttack_Attitude = Msl.AddObject(
            name: "o_allAttack_Attitude", 
            spriteName: "s_bw_attitude_attack", 
            parentName: "o_Attitude", 
            isVisible: true, 
            isPersistent: false, 
            isAwake: true,
            collisionShapeFlags: CollisionShapeFlags.Circle
        );

        UndertaleGameObject o_allDeffence_Attitude = Msl.AddObject(
            name: "o_allDeffence_Attitude", 
            spriteName: "s_bw_attitude_follow", 
            parentName: "o_Attitude", 
            isVisible: true, 
            isPersistent: false, 
            isAwake: true,
            collisionShapeFlags: CollisionShapeFlags.Circle
        );

        UndertaleGameObject o_disclaimer03 = Msl.AddObject(
            name: "o_disclaimer03", 
            spriteName: "", 
            parentName: "", 
            isVisible: true, 
            isPersistent: false, 
            isAwake: true,
            collisionShapeFlags: CollisionShapeFlags.Circle
        );

        UndertaleGameObject o_BwMark = Msl.AddObject(
            name: "o_BwMark", 
            spriteName: "s_bwdis", 
            parentName: "", 
            isVisible: true, 
            isPersistent: false, 
            isAwake: false,
            collisionShapeFlags: CollisionShapeFlags.Circle
        );

        UndertaleGameObject o_skill_bw_resurrection = Msl.AddObject(
            name: "o_skill_bw_resurrection", 
            spriteName: "s_recurct", 
            parentName: "o_skill", 
            isVisible: true, 
            isPersistent: false, 
            isAwake: true,
            collisionShapeFlags: CollisionShapeFlags.Circle
        );

       UndertaleGameObject o_bw_resurrection_birth = Msl.AddObject(
            name: "o_bw_resurrection_birth", 
            spriteName: "s_makefeast_birth", 
            parentName: "o_spelllbirth", 
            isVisible: true, 
            isPersistent: false, 
            isAwake: true,
            collisionShapeFlags: CollisionShapeFlags.Circle
        );

        UndertaleGameObject o_bw_resurrection = Msl.AddObject(
            name: "o_bw_resurrection", 
            spriteName: "s_resurection", 
            parentName: "o_magic_pillar", 
            isVisible: true, 
            isPersistent: false, 
            isAwake: true,
            collisionShapeFlags: CollisionShapeFlags.Circle
        );

        UndertaleGameObject o_skill_bw_wraithsummon = Msl.AddObject(
            name: "o_skill_bw_wraithsummon", 
            spriteName: "s_wraithbind", 
            parentName: "o_skill", 
            isVisible: true, 
            isPersistent: false, 
            isAwake: true,
            collisionShapeFlags: CollisionShapeFlags.Circle
        );

        UndertaleGameObject o_bw_wraith_summoning = Msl.AddObject(
            name: "o_bw_wraith_summoning", 
            spriteName: "s_wraithsummon_cast", 
            parentName: "o_spelllbirth", 
            isVisible: true, 
            isPersistent: false, 
            isAwake: true,
            collisionShapeFlags: CollisionShapeFlags.Circle
        );

        UndertaleGameObject o_bw_curse = Msl.AddObject(
            name: "o_bw_curse", 
            spriteName: "s_pcurse", 
            parentName: "o_skill", 
            isVisible: true, 
            isPersistent: false, 
            isAwake: true,
            collisionShapeFlags: CollisionShapeFlags.Circle
        );

        UndertaleGameObject o_bw_cursebirth = Msl.AddObject(
            name: "o_bw_cursebirth", 
            spriteName: "s_curse_cast", 
            parentName: "o_spelllbirth", 
            isVisible: true, 
            isPersistent: false, 
            isAwake: true,
            collisionShapeFlags: CollisionShapeFlags.Circle
        );

        UndertaleGameObject o_bw_inscurse = Msl.AddObject(
            name: "o_bw_inscurse", 
            spriteName: "s_teal_curse", 
            parentName: "o_magic_pillar", 
            isVisible: true, 
            isPersistent: false, 
            isAwake: true,
            collisionShapeFlags: CollisionShapeFlags.Circle
        );

        UndertaleGameObject o_bw_darkbolt = Msl.AddObject(
            name: "o_bw_darkbolt", 
            spriteName: "s_darkbalz", 
            parentName: "o_skill", 
            isVisible: true, 
            isPersistent: false, 
            isAwake: true,
            collisionShapeFlags: CollisionShapeFlags.Circle
        );

        UndertaleGameObject o_bw_ballbirth = Msl.AddObject(
            name: "o_bw_ballbirth", 
            spriteName: "s_spell_darkball_birth", 
            parentName: "o_spelllbirth", 
            isVisible: true, 
            isPersistent: false, 
            isAwake: true,
            collisionShapeFlags: CollisionShapeFlags.Circle
        );

        UndertaleGameObject o_bw_dark_bless = Msl.AddObject(
            name: "o_bw_dark_bless", 
            spriteName: "s_blusss", 
            parentName: "o_skill", 
            isVisible: true, 
            isPersistent: false, 
            isAwake: true,
            collisionShapeFlags: CollisionShapeFlags.Circle
        );

        UndertaleGameObject o_bw_blessing_birth = Msl.AddObject(
            name: "o_bw_blessing_birth", 
            spriteName: "s_darkbless_birth", 
            parentName: "o_spelllbirth", 
            isVisible: true, 
            isPersistent: false, 
            isAwake: true,
            collisionShapeFlags: CollisionShapeFlags.Circle
        );

        UndertaleGameObject o_bw_darkbless = Msl.AddObject(
            name: "o_bw_darkbless", 
            spriteName: "s_darkblessing", 
            parentName: "o_magic_pillar", 
            isVisible: true, 
            isPersistent: false, 
            isAwake: true,
            collisionShapeFlags: CollisionShapeFlags.Circle
        );

        UndertaleGameObject o_skill_bw_touch = Msl.AddObject(
            name: "o_skill_bw_touch", 
            spriteName: "s_dtouch", 
            parentName: "o_skill", 
            isVisible: true, 
            isPersistent: false, 
            isAwake: true,
            collisionShapeFlags: CollisionShapeFlags.Circle
        );

        UndertaleGameObject o_bw_touch = Msl.AddObject(
            name: "o_bw_touch", 
            spriteName: "", 
            parentName: "", 
            isVisible: true, 
            isPersistent: false, 
            isAwake: true,
            collisionShapeFlags: CollisionShapeFlags.Circle
        );

        UndertaleGameObject o_bw_sacrifice = Msl.AddObject(
            name: "o_bw_sacrifice", 
            spriteName: "s_db_soul_sacrifice", 
            parentName: "o_class_skills", 
            isVisible: true, 
            isPersistent: false, 
            isAwake: true,
            collisionShapeFlags: CollisionShapeFlags.Circle
        );

        UndertaleGameObject o_db_painful_curse = Msl.AddObject(
            name: "o_db_painful_curse", 
            spriteName: "s_buff_cursse", 
            parentName: "o_magical_debuff", 
            isVisible: true, 
            isPersistent: false, 
            isAwake: true,
            collisionShapeFlags: CollisionShapeFlags.Circle
        );

        UndertaleGameObject o_darkball2 = Msl.AddObject(
            name: "o_darkball2", 
            spriteName: "s_spell_darlball", 
            parentName: "o_shell_damage", 
            isVisible: true, 
            isPersistent: false, 
            isAwake: true,
            collisionShapeFlags: CollisionShapeFlags.Circle
        );

        UndertaleGameObject o_b_deathbless = Msl.AddObject(
            name: "o_b_deathbless", 
            spriteName: "s_buff_death_blesss", 
            parentName: "o_physical_buff", 
            isVisible: true, 
            isPersistent: false, 
            isAwake: true,
            collisionShapeFlags: CollisionShapeFlags.Circle
        );

        UndertaleGameObject o_bw_zombie = Msl.AddObject(
            name: "o_bw_zombie", 
            spriteName: "s_zombie01", 
            parentName: "c_zombie", 
            isVisible: true, 
            isPersistent: false, 
            isAwake: true,
            collisionShapeFlags: CollisionShapeFlags.Circle
        );

        UndertaleGameObject o_archtheurgy_impact = Msl.AddObject(
            name: "o_archtheurgy_impact", 
            spriteName: "", 
            parentName: "", 
            isVisible: true, 
            isPersistent: false, 
            isAwake: true,
            collisionShapeFlags: CollisionShapeFlags.Circle
        );

        UndertaleGameObject o_skill_enchantment_bw = Msl.AddObject(
            name: "o_skill_enchantment_bw", 
            spriteName: "sprite1", 
            parentName: "o_weapon_skills", 
            isVisible: true, 
            isPersistent: false, 
            isAwake: true,
            collisionShapeFlags: CollisionShapeFlags.Circle
        );

        UndertaleGameObject o_skill_bw_targeting = Msl.AddObject(
            name: "o_skill_bw_targeting", 
            spriteName: "s_torchishka", 
            parentName: "o_skills_like", 
            isVisible: true, 
            isPersistent: true, 
            isAwake: true,
            collisionShapeFlags: CollisionShapeFlags.Circle
        );

        UndertaleGameObject o_skill_bw_targeting_offense = Msl.AddObject(
            name: "o_skill_bw_targeting_offense", 
            spriteName: "s_torchishka", 
            parentName: "o_skills_like", 
            isVisible: true, 
            isPersistent: true, 
            isAwake: true,
            collisionShapeFlags: CollisionShapeFlags.Circle
        );

        UndertaleGameObject o_bw_aoe_range = Msl.AddObject(
            name: "o_bw_aoe_range", 
            spriteName: "s_aoe_area", 
            parentName: "", 
            isVisible: true, 
            isPersistent: false, 
            isAwake: true,
            collisionShapeFlags: CollisionShapeFlags.Circle
        );
        
        // functions
        Msl.AddFunction(ModFiles.GetCode("gml_GlobalScript_scr_bw_checker.gml"), "scr_bw_checker");
        Msl.AddFunction(ModFiles.GetCode("gml_GlobalScript_scr_bw_targeter.gml"), "scr_bw_targeter");

        // modified objects
        Msl.GetObject("o_attitudes_menu").Sprite = Msl.GetSprite("s_big_att_menu");
        Msl.GetObject("o_b_magic_unholy").Sprite = Msl.GetSprite("s_b_sealofpower_unholy");
        
        // new events in already existing objects        
        Msl.GetObject("o_animals").ApplyEvent(ModFiles,
            new MslEvent("gml_Object_o_animals_Destroy_0.gml", EventType.Destroy, 0)
        );

        Msl.GetObject("o_darkball").ApplyEvent(ModFiles,
            new MslEvent("gml_Object_o_darkball_Destroy_0.gml", EventType.Destroy, 0)
        );

        Msl.GetObject("o_Dead_March").ApplyEvent(ModFiles,
            new MslEvent("gml_Object_o_Dead_March_Destroy_0.gml", EventType.Destroy, 0),
            new MslEvent("gml_Object_o_Dead_March_Draw_0.gml", EventType.Draw, 0)
        );

        Msl.GetObject("o_necromancer_boss").ApplyEvent(ModFiles,
            new MslEvent("gml_Object_o_necromancer_boss_Destroy_0.gml", EventType.Destroy, 0)
        );

        Msl.GetObject("o_necromancer_boss_staff").ApplyEvent(ModFiles,
            new MslEvent("gml_Object_o_necromancer_boss_staff_Destroy_0.gml", EventType.Destroy, 0)
        );

        Msl.GetObject("o_necromancer_ritualist").ApplyEvent(ModFiles,
            new MslEvent("gml_Object_o_necromancer_ritualist_Destroy_0.gml", EventType.Destroy, 0)
        );

        Msl.GetObject("o_Omnivore").ApplyEvent(ModFiles,
            new MslEvent("gml_Object_o_Omnivore_Destroy_0.gml", EventType.Destroy, 0)
        );

        Msl.GetObject("o_proselyte").ApplyEvent(ModFiles,
            new MslEvent("gml_Object_o_proselyte_Draw_0.gml", EventType.Draw, 0)
        );

        // new events of new objects
        o_inv_magic_treatise.ApplyEvent(ModFiles, 
            new MslEvent("gml_Object_o_inv_cgrimoir_Create_0.gml", EventType.Create, 0),
            new MslEvent("gml_Object_o_inv_cgrimoir_Other_10.gml", EventType.Other, 10),
            new MslEvent("gml_Object_o_inv_cgrimoir_Draw_73.gml", EventType.Draw, 73),
            new MslEvent("gml_Object_o_inv_cgrimoir_PreCreate_0.gml", EventType.PreCreate, 0)
        );

        o_inv_cgrimoir2.ApplyEvent(ModFiles, 
            new MslEvent("gml_Object_o_inv_cgrimoir2_Create_0.gml", EventType.Create, 0),
            new MslEvent("gml_Object_o_inv_cgrimoir2_Other_10.gml", EventType.Other, 10),
            new MslEvent("gml_Object_o_inv_cgrimoir2_Draw_73.gml", EventType.Draw, 73),
            new MslEvent("gml_Object_o_inv_cgrimoir2_PreCreate_0.gml", EventType.PreCreate, 0)
        );

        o_inv_cgrimoir3.ApplyEvent(ModFiles, 
            new MslEvent("gml_Object_o_inv_cgrimoir3_Create_0.gml", EventType.Create, 0),
            new MslEvent("gml_Object_o_inv_cgrimoir3_Other_10.gml", EventType.Other, 10),
            new MslEvent("gml_Object_o_inv_cgrimoir3_Draw_73.gml", EventType.Draw, 73),
            new MslEvent("gml_Object_o_inv_cgrimoir3_PreCreate_0.gml", EventType.PreCreate, 0)
        );

        o_loot_cgrimoir.ApplyEvent(ModFiles, 
            new MslEvent("gml_Object_o_loot_cgrimoir_Create_0.gml", EventType.Create, 0),
            new MslEvent("gml_Object_o_loot_cgrimoir_PreCreate_0.gml", EventType.PreCreate, 0)
        );
        
        o_loot_cgrimoir2.ApplyEvent(ModFiles, 
            new MslEvent("gml_Object_o_loot_cgrimoir2_Create_0.gml", EventType.Create, 0),
            new MslEvent("gml_Object_o_loot_cgrimoir2_PreCreate_0.gml", EventType.PreCreate, 0)
        );

        o_loot_cgrimoir3.ApplyEvent(ModFiles, 
            new MslEvent("gml_Object_o_loot_cgrimoir3_Create_0.gml", EventType.Create, 0),
            new MslEvent("gml_Object_o_loot_cgrimoir3_PreCreate_0.gml", EventType.PreCreate, 0)
        );

        o_mortal_blocker.ApplyEvent(ModFiles, 
            new MslEvent("gml_Object_o_mortal_blocker_Create_0.gml", EventType.Create, 0),
            new MslEvent("gml_Object_o_mortal_blocker_Alarm_1.gml", EventType.Alarm, 1),
            new MslEvent("gml_Object_o_mortal_blocker_PreCreate_0.gml", EventType.PreCreate, 0)
        );

        o_res_buff_creator.ApplyEvent(ModFiles, 
            new MslEvent("gml_Object_o_res_buff_creator_Create_0.gml", EventType.Create, 0),
            new MslEvent("gml_Object_o_res_buff_creator_Alarm_1.gml", EventType.Alarm, 1),
            new MslEvent("gml_Object_o_res_buff_creator_Alarm_2.gml", EventType.Alarm, 2),
            new MslEvent("gml_Object_o_res_buff_creator_PreCreate_0.gml", EventType.PreCreate, 0)
        );

        o_undead_fixer.ApplyEvent(ModFiles, 
            new MslEvent("gml_Object_o_undead_fixer_Create_0.gml", EventType.Create, 0),
            new MslEvent("gml_Object_o_undead_fixer_Alarm_1.gml", EventType.Alarm, 1),
            new MslEvent("gml_Object_o_undead_fixer_Alarm_2.gml", EventType.Alarm, 2),
            new MslEvent("gml_Object_o_undead_fixer_PreCreate_0.gml", EventType.PreCreate, 0)
        );

        o_soul_destroyer.ApplyEvent(ModFiles, 
            new MslEvent("gml_Object_o_soul_destroyer_Create_0.gml", EventType.Create, 0),
            new MslEvent("gml_Object_o_soul_destroyer_Alarm_1.gml", EventType.Alarm, 1)
        );

        o_res_new01.ApplyEvent(ModFiles, 
            new MslEvent("gml_Object_o_res_new01_Create_0.gml", EventType.Create, 0),
            new MslEvent("gml_Object_o_res_new01_Other_7.gml", EventType.Other, 7),
            new MslEvent("gml_Object_o_res_new01_Draw_0.gml", EventType.Draw, 0)
        );
                    
        o_trashy_corpz.ApplyEvent(ModFiles, 
            new MslEvent("gml_Object_o_trashy_corpz_Create_0.gml", EventType.Create, 0),
            new MslEvent("gml_Object_o_trashy_corpz_Alarm_0.gml", EventType.Alarm, 0)
        );

        o_Lostsouls.ApplyEvent(ModFiles, 
            new MslEvent("gml_Object_o_Lostsouls_Create_0.gml", EventType.Create, 0),
            new MslEvent("gml_Object_o_Lostsouls_Destroy_0.gml", EventType.Destroy, 0),
            new MslEvent("gml_Object_o_Lostsouls_Alarm_0.gml", EventType.Alarm, 0),
            new MslEvent("gml_Object_o_Lostsouls_Alarm_10.gml", EventType.Alarm, 10),
            new MslEvent("gml_Object_o_Lostsouls_PreCreate_0.gml", EventType.PreCreate, 0)
        );

        o_absorption_soul.ApplyEvent(ModFiles, 
            new MslEvent("gml_Object_o_absorption_soul_Create_0.gml", EventType.Create, 0),
            new MslEvent("gml_Object_o_absorption_soul_Destroy_0.gml", EventType.Destroy, 0),
            new MslEvent("gml_Object_o_absorption_soul_Alarm_0.gml", EventType.Alarm, 0),
            new MslEvent("gml_Object_o_absorption_soul_Alarm_10.gml", EventType.Alarm, 10),
            new MslEvent("gml_Object_o_absorption_soul_Alarm_2.gml", EventType.Alarm, 2),
            new MslEvent("gml_Object_o_absorption_soul_PreCreate_0.gml", EventType.PreCreate, 0)
        );

        o_b_servemaster.ApplyEvent(ModFiles, 
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

        o_b_Lostsouls.ApplyEvent(ModFiles, 
            new MslEvent("gml_Object_o_b_Lostsouls_Create_0.gml", EventType.Create, 0),
            new MslEvent("gml_Object_o_b_Lostsouls_Alarm_2.gml", EventType.Alarm, 2),
            new MslEvent("gml_Object_o_b_Lostsouls_Other_10.gml", EventType.Other, 10)
        );

        o_b_unbind.ApplyEvent(ModFiles, 
            new MslEvent("gml_Object_o_b_unbind_Create_0.gml", EventType.Create, 0),
            new MslEvent("gml_Object_o_b_unbind_Mouse_53.gml", EventType.Mouse, 53),
            new MslEvent("gml_Object_o_b_unbind_Other_10.gml", EventType.Other, 10)
        );

        o_db_punishment.ApplyEvent(ModFiles, 
            new MslEvent("gml_Object_o_db_punishment_Create_0.gml", EventType.Create, 0),
            new MslEvent("gml_Object_o_db_punishment_Alarm_2.gml", EventType.Alarm, 2),
            new MslEvent("gml_Object_o_db_punishment_Other_10.gml", EventType.Other, 10),
            new MslEvent("gml_Object_o_db_punishment_PreCreate_0.gml", EventType.PreCreate, 0)
        );

        o_db_takeover.ApplyEvent(ModFiles, 
            new MslEvent("gml_Object_o_db_takeover_Create_0.gml", EventType.Create, 0),
            new MslEvent("gml_Object_o_db_takeover_Destroy_0.gml", EventType.Destroy, 0),
            new MslEvent("gml_Object_o_db_takeover_Alarm_2.gml", EventType.Alarm, 2),
            new MslEvent("gml_Object_o_db_takeover_Other_10.gml", EventType.Other, 10)
        );

        o_b_exceptional.ApplyEvent(ModFiles, 
            new MslEvent("gml_Object_o_b_exceptional_Create_0.gml", EventType.Create, 0),
            new MslEvent("gml_Object_o_b_exceptional_Destroy_0.gml", EventType.Destroy, 0),
            new MslEvent("gml_Object_o_b_exceptional_Alarm_2.gml", EventType.Alarm, 2),
            new MslEvent("gml_Object_o_b_exceptional_Other_10.gml", EventType.Other, 10),
            new MslEvent("gml_Object_o_b_exceptional_PreCreate_0.gml", EventType.PreCreate, 0)
        );

        o_b_charged_soul.ApplyEvent(ModFiles, 
            new MslEvent("gml_Object_o_b_charged_soul_Create_0.gml", EventType.Create, 0),
new MslEvent("gml_Object_o_b_charged_soul_Alarm_2.gml", EventType.Alarm, 2),
new MslEvent("gml_Object_o_b_charged_soul_Alarm_3.gml", EventType.Alarm, 3),
new MslEvent("gml_Object_o_b_charged_soul_Step_2.gml", EventType.Step, 2),
new MslEvent("gml_Object_o_b_charged_soul_Other_10.gml", EventType.Other, 10),
new MslEvent("gml_Object_o_b_charged_soul_Other_14.gml", EventType.Other, 14),
new MslEvent("gml_Object_o_b_charged_soul_PreCreate_0.gml", EventType.PreCreate, 0)
        );

        o_b_angel_charm.ApplyEvent(ModFiles, 
            new MslEvent("gml_Object_o_b_angel_charm_Create_0.gml", EventType.Create, 0),
new MslEvent("gml_Object_o_b_angel_charm_Alarm_2.gml", EventType.Alarm, 2),
new MslEvent("gml_Object_o_b_angel_charm_Alarm_3.gml", EventType.Alarm, 3),
new MslEvent("gml_Object_o_b_angel_charm_Step_2.gml", EventType.Step, 2),
new MslEvent("gml_Object_o_b_angel_charm_Other_10.gml", EventType.Other, 10)
        );

        o_b_darkenchant.ApplyEvent(ModFiles, 
            new MslEvent("gml_Object_o_b_darkenchant_Create_0.gml", EventType.Create, 0),
            new MslEvent("gml_Object_o_b_darkenchant_Alarm_2.gml", EventType.Alarm, 2),
            new MslEvent("gml_Object_o_b_darkenchant_Alarm_3.gml", EventType.Alarm, 3),
            new MslEvent("gml_Object_o_b_darkenchant_Step_2.gml", EventType.Step, 2),
            new MslEvent("gml_Object_o_b_darkenchant_Other_10.gml", EventType.Other, 10),
            new MslEvent("gml_Object_o_b_darkenchant_PreCreate_0.gml", EventType.PreCreate, 0)
        );

        o_skill_Lostsouls.ApplyEvent(ModFiles, 
            new MslEvent("gml_Object_o_skill_Lostsouls_Create_0.gml", EventType.Create, 0),
            new MslEvent("gml_Object_o_skill_Lostsouls_Other_14.gml", EventType.Other, 14),
            new MslEvent("gml_Object_o_skill_Lostsouls_Other_17.gml", EventType.Other, 17),
            new MslEvent("gml_Object_o_skill_Lostsouls_Other_13.gml", EventType.Other, 13)
        );

        o_skill_death_plague.ApplyEvent(ModFiles, 
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

        o_skill_soul_explosion.ApplyEvent(ModFiles, 
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

        o_pass_skill_nmadness.ApplyEvent(ModFiles, 
            new MslEvent("gml_Object_o_pass_skill_nmadness_Create_0.gml", EventType.Create, 0),
            new MslEvent("gml_Object_o_pass_skill_nmadness_Step_2.gml", EventType.Step, 2),
            new MslEvent("gml_Object_o_pass_skill_nmadness_Other_17.gml", EventType.Other, 17),
            new MslEvent("gml_Object_o_pass_skill_nmadness_Other_13.gml", EventType.Other, 13),
            new MslEvent("gml_Object_o_pass_skill_nmadness_PreCreate_0.gml", EventType.PreCreate, 0)
        );

        o_pass_skill_ndarkness.ApplyEvent(ModFiles, 
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

        o_pass_skill_darkblood.ApplyEvent(ModFiles, 
            new MslEvent("gml_Object_o_pass_skill_darkblood_Create_0.gml", EventType.Create, 0),
            new MslEvent("gml_Object_o_pass_skill_darkblood_Step_2.gml", EventType.Step, 2),
            new MslEvent("gml_Object_o_pass_skill_darkblood_Other_17.gml", EventType.Other, 17),
            new MslEvent("gml_Object_o_pass_skill_darkblood_Other_13.gml", EventType.Other, 13),
            new MslEvent("gml_Object_o_pass_skill_darkblood_PreCreate_0.gml", EventType.PreCreate, 0)
        );

        o_pass_skill_unholymind.ApplyEvent(ModFiles, 
            new MslEvent("gml_Object_o_pass_skill_unholymind_Create_0.gml", EventType.Create, 0),
            new MslEvent("gml_Object_o_pass_skill_unholymind_Step_2.gml", EventType.Step, 2),
            new MslEvent("gml_Object_o_pass_skill_unholymind_Other_13.gml", EventType.Other, 13),
            new MslEvent("gml_Object_o_pass_skill_unholymind_Other_17.gml", EventType.Other, 17),
            new MslEvent("gml_Object_o_pass_skill_unholymind_PreCreate_0.gml", EventType.PreCreate, 0)
        );

        o_pass_skill_imortall.ApplyEvent(ModFiles, 
            new MslEvent("gml_Object_o_pass_skill_imortall_Create_0.gml", EventType.Create, 0),
            new MslEvent("gml_Object_o_pass_skill_imortall_Alarm_7.gml", EventType.Alarm, 7),
            new MslEvent("gml_Object_o_pass_skill_imortall_Step_2.gml", EventType.Step, 2),
            new MslEvent("gml_Object_o_pass_skill_imortall_Other_17.gml", EventType.Other, 17),
            new MslEvent("gml_Object_o_pass_skill_imortall_Other_13.gml", EventType.Other, 13),
            new MslEvent("gml_Object_o_pass_skill_imortall_PreCreate_0.gml", EventType.PreCreate, 0)
        );

        o_pass_skill_kingdead.ApplyEvent(ModFiles, 
            new MslEvent("gml_Object_o_pass_skill_kingdead_Create_0.gml", EventType.Create, 0),
            new MslEvent("gml_Object_o_pass_skill_kingdead_Step_2.gml", EventType.Step, 2),
            new MslEvent("gml_Object_o_pass_skill_kingdead_Other_17.gml", EventType.Other, 17),
            new MslEvent("gml_Object_o_pass_skill_kingdead_Other_13.gml", EventType.Other, 13)
        );

        o_allAttack_Attitude.ApplyEvent(ModFiles, 
            new MslEvent("gml_Object_o_allAttack_Attitude_Create_0.gml", EventType.Create, 0),
            new MslEvent("gml_Object_o_allAttack_Attitude_Mouse_7.gml", EventType.Mouse, 7),
            new MslEvent("gml_Object_o_allAttack_Attitude_Other_10.gml", EventType.Other, 10),
            new MslEvent("gml_Object_o_allAttack_Attitude_Other_12.gml", EventType.Other, 12),
            new MslEvent("gml_Object_o_allAttack_Attitude_PreCreate_0.gml", EventType.PreCreate, 0)
        );

        o_allDeffence_Attitude.ApplyEvent(ModFiles, 
            new MslEvent("gml_Object_o_allDeffence_Attitude_Create_0.gml", EventType.Create, 0),
            new MslEvent("gml_Object_o_allDeffence_Attitude_Mouse_7.gml", EventType.Mouse, 7),
            new MslEvent("gml_Object_o_allDeffence_Attitude_Other_10.gml", EventType.Other, 10),
            new MslEvent("gml_Object_o_allDeffence_Attitude_Other_12.gml", EventType.Other, 12),
            new MslEvent("gml_Object_o_allDeffence_Attitude_PreCreate_0.gml", EventType.PreCreate, 0)
        );

        o_disclaimer03.ApplyEvent(ModFiles, 
            new MslEvent("gml_Object_o_disclaimer03_Draw_0.gml", EventType.Draw, 0)
        );

        o_BwMark.ApplyEvent(ModFiles, 
            new MslEvent("gml_Object_o_BwMark_Create_0.gml", EventType.Create, 0),
            new MslEvent("gml_Object_o_BwMark_Other_5.gml", EventType.Other, 5)
        );

        o_skill_bw_resurrection.ApplyEvent(ModFiles, 
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

        o_bw_resurrection_birth.ApplyEvent(ModFiles, 
            new MslEvent("gml_Object_o_bw_resurrection_birth_Create_0.gml", EventType.Create, 0),
            new MslEvent("gml_Object_o_bw_resurrection_birth_Other_7.gml", EventType.Other, 7),
            new MslEvent("gml_Object_o_bw_resurrection_birth_Other_10.gml", EventType.Other, 10),
            new MslEvent("gml_Object_o_bw_resurrection_birth_Draw_0.gml", EventType.Draw, 0)
        );

        o_bw_resurrection.ApplyEvent(ModFiles, 
            new MslEvent("gml_Object_o_bw_resurrection_Create_0.gml", EventType.Create, 0),
            new MslEvent("gml_Object_o_bw_resurrection_Destroy_0.gml", EventType.Destroy, 0),
            new MslEvent("gml_Object_o_bw_resurrection_Alarm_0.gml", EventType.Alarm, 0),
            new MslEvent("gml_Object_o_bw_resurrection_Alarm_10.gml", EventType.Alarm, 10),
            new MslEvent("gml_Object_o_bw_resurrection_Other_7.gml", EventType.Other, 7),
            new MslEvent("gml_Object_o_bw_resurrection_Draw_0.gml", EventType.Draw, 0)
        );

        o_skill_bw_wraithsummon.ApplyEvent(ModFiles, 
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

        o_bw_wraith_summoning.ApplyEvent(ModFiles, 
            new MslEvent("gml_Object_o_bw_wraith_summoning_Create_0.gml", EventType.Create, 0),
            new MslEvent("gml_Object_o_bw_wraith_summoning_Destroy_0.gml", EventType.Destroy, 0),
            new MslEvent("gml_Object_o_bw_wraith_summoning_Other_10.gml", EventType.Other, 10),
            new MslEvent("gml_Object_o_bw_wraith_summoning_Other_7.gml", EventType.Other, 7)
        );

        o_bw_curse.ApplyEvent(ModFiles, 
            new MslEvent("gml_Object_o_bw_curse_Create_0.gml", EventType.Create, 0),
            new MslEvent("gml_Object_o_bw_curse_Other_17.gml", EventType.Other, 17),
            new MslEvent("gml_Object_o_bw_curse_Other_13.gml", EventType.Other, 13)
        );

        o_bw_curse_ico.ApplyEvent(ModFiles, 
            new MslEvent("gml_Object_o_bw_curse_ico_Create_0.gml", EventType.Create, 0)
        );

        o_bw_cursebirth.ApplyEvent(ModFiles, 
            new MslEvent("gml_Object_o_bw_cursebirth_Create_0.gml", EventType.Create, 0)
        );

        o_bw_inscurse.ApplyEvent(ModFiles, 
            new MslEvent("gml_Object_o_bw_inscurse_Create_0.gml", EventType.Create, 0),
            new MslEvent("gml_Object_o_bw_inscurse_Other_7.gml", EventType.Other, 7),
            new MslEvent("gml_Object_o_bw_inscurse_Draw_0.gml", EventType.Draw, 0)
        );

        o_bw_darkbolt.ApplyEvent(ModFiles, 
            new MslEvent("gml_Object_o_bw_darkbolt_Create_0.gml", EventType.Create, 0),
            new MslEvent("gml_Object_o_bw_darkbolt_Other_17.gml", EventType.Other, 17),
            new MslEvent("gml_Object_o_bw_darkbolt_Other_13.gml", EventType.Other, 13)
        );

        o_bw_darkbolt_ico.ApplyEvent(ModFiles, 
            new MslEvent("gml_Object_o_bw_darkbolt_ico_Create_0.gml", EventType.Create, 0)
        );

        o_bw_ballbirth.ApplyEvent(ModFiles, 
            new MslEvent("gml_Object_o_bw_ballbirth_Create_0.gml", EventType.Create, 0),
            new MslEvent("gml_Object_o_bw_ballbirth_Other_17.gml", EventType.Other, 17),
            new MslEvent("gml_Object_o_bw_ballbirth_Other_10.gml", EventType.Other, 10)
        );

        o_bw_dark_bless.ApplyEvent(ModFiles, 
            new MslEvent("gml_Object_o_bw_dark_bless_Create_0.gml", EventType.Create, 0),
            new MslEvent("gml_Object_o_bw_dark_bless_Other_17.gml", EventType.Other, 17),
            new MslEvent("gml_Object_o_bw_dark_bless_Other_13.gml", EventType.Other, 13)
        );

        o_bw_dark_bless_ico.ApplyEvent(ModFiles, 
            new MslEvent("gml_Object_o_bw_dark_bless_ico_Create_0.gml", EventType.Create, 0),
            new MslEvent("gml_Object_o_bw_dark_bless_ico_Step_2.gml", EventType.Step, 2)
        );

        o_bw_blessing_birth.ApplyEvent(ModFiles, 
            new MslEvent("gml_Object_o_bw_blessing_birth_Create_0.gml", EventType.Create, 0)
        );

        o_bw_darkbless.ApplyEvent(ModFiles, 
            new MslEvent("gml_Object_o_bw_darkbless_Create_0.gml", EventType.Create, 0),
            new MslEvent("gml_Object_o_bw_darkbless_Other_7.gml", EventType.Other, 7),
            new MslEvent("gml_Object_o_bw_darkbless_Draw_0.gml", EventType.Draw, 0)
        );

        o_skill_bw_touch.ApplyEvent(ModFiles, 
            new MslEvent("gml_Object_o_skill_bw_touch_Create_0.gml", EventType.Create, 0),
            new MslEvent("gml_Object_o_skill_bw_touch_Other_17.gml", EventType.Other, 17),
            new MslEvent("gml_Object_o_skill_bw_touch_Other_13.gml", EventType.Other, 13)
        );

        o_skill_bw_touch_ico.ApplyEvent(ModFiles, 
            new MslEvent("gml_Object_o_skill_bw_touch_ico_Create_0.gml", EventType.Create, 0),
            new MslEvent("gml_Object_o_skill_bw_touch_ico_Step_2.gml", EventType.Step, 2)
        );

        o_bw_touch.ApplyEvent(ModFiles, 
            new MslEvent("gml_Object_o_bw_touch_Create_0.gml", EventType.Create, 0),
            new MslEvent("gml_Object_o_bw_touch_Destroy_0.gml", EventType.Destroy, 0),
            new MslEvent("gml_Object_o_bw_touch_Alarm_1.gml", EventType.Alarm, 1),
            new MslEvent("gml_Object_o_bw_touch_Alarm_0.gml", EventType.Alarm, 0),
            new MslEvent("gml_Object_o_bw_touch_Alarm_2.gml", EventType.Alarm, 2),
            new MslEvent("gml_Object_o_bw_touch_Alarm_10.gml", EventType.Alarm, 10)
        );

        o_bw_sacrifice.ApplyEvent(ModFiles, 
            new MslEvent("gml_Object_o_bw_sacrifice_Create_0.gml", EventType.Create, 0),
            new MslEvent("gml_Object_o_bw_sacrifice_Destroy_0.gml", EventType.Destroy, 0),
            new MslEvent("gml_Object_o_bw_sacrifice_Alarm_2.gml", EventType.Alarm, 2),
            new MslEvent("gml_Object_o_bw_sacrifice_Step_2.gml", EventType.Step, 2),
            new MslEvent("gml_Object_o_bw_sacrifice_Other_13.gml", EventType.Other, 13),
            new MslEvent("gml_Object_o_bw_sacrifice_KeyPress_75.gml", EventType.KeyPress, 75)
        );

        o_db_painful_curse.ApplyEvent(ModFiles, 
            new MslEvent("gml_Object_o_db_painful_curse_Create_0.gml", EventType.Create, 0),
            new MslEvent("gml_Object_o_db_painful_curse_Destroy_0.gml", EventType.Destroy, 0),
            new MslEvent("gml_Object_o_db_painful_curse_Alarm_2.gml", EventType.Alarm, 2),
            new MslEvent("gml_Object_o_db_painful_curse_Alarm_1.gml", EventType.Alarm, 1),
            new MslEvent("gml_Object_o_db_painful_curse_Step_0.gml", EventType.Step, 0),
            new MslEvent("gml_Object_o_db_painful_curse_Other_15.gml", EventType.Other, 15),
            new MslEvent("gml_Object_o_db_painful_curse_Other_10.gml", EventType.Other, 10)
        );

        o_darkball2.ApplyEvent(ModFiles, 
            new MslEvent("gml_Object_o_darkball2_Create_0.gml", EventType.Create, 0),
            new MslEvent("gml_Object_o_darkball2_Destroy_0.gml", EventType.Destroy, 0),
            new MslEvent("gml_Object_o_darkball2_Other_10.gml", EventType.Other, 10),
            new MslEvent("gml_Object_o_darkball2_Other_11.gml", EventType.Other, 11)
        );

        o_b_deathbless.ApplyEvent(ModFiles, 
            new MslEvent("gml_Object_o_b_deathbless_Create_0.gml", EventType.Create, 0),
            new MslEvent("gml_Object_o_b_deathbless_Alarm_2.gml", EventType.Alarm, 2),
            new MslEvent("gml_Object_o_b_deathbless_Other_10.gml", EventType.Other, 10)
        );

        o_bw_zombie.ApplyEvent(ModFiles, 
            new MslEvent("gml_Object_o_bw_zombie_Create_0.gml", EventType.Create, 0),
            new MslEvent("gml_Object_o_bw_zombie_Destroy_0.gml", EventType.Destroy, 0),
            new MslEvent("gml_Object_o_bw_zombie_PreCreate_0.gml", EventType.PreCreate, 0)
        );

        o_archtheurgy_impact.ApplyEvent(ModFiles, 
            new MslEvent("gml_Object_o_archtheurgy_impact_Create_0.gml", EventType.Create, 0),
            new MslEvent("gml_Object_o_archtheurgy_impact_Alarm_1.gml", EventType.Alarm, 1)
        );

        o_skill_enchantment_bw.ApplyEvent(ModFiles,         
            new MslEvent("gml_Object_o_skill_enchantment_bw_Other_20.gml", EventType.Other, 20),
            new MslEvent("gml_Object_o_skill_enchantment_bw_Other_11.gml", EventType.Other, 11)
        );

        o_skill_bw_targeting.ApplyEvent(ModFiles, 
            new MslEvent("gml_Object_o_skill_bw_targeting_Create_0.gml", EventType.Create, 0),
            new MslEvent("gml_Object_o_skill_bw_targeting_Alarm_1.gml", EventType.Alarm, 1),
            new MslEvent("gml_Object_o_skill_bw_targeting_Step_0.gml", EventType.Step, 0),
            new MslEvent("gml_Object_o_skill_bw_targeting_Other_17.gml", EventType.Other, 17),
            new MslEvent("gml_Object_o_skill_bw_targeting_Other_13.gml", EventType.Other, 13),
            new MslEvent("gml_Object_o_skill_bw_targeting_Other_19.gml", EventType.Other, 19),
            new MslEvent("gml_Object_o_skill_bw_targeting_Other_25.gml", EventType.Other, 25),
            new MslEvent("gml_Object_o_skill_bw_targeting_Draw_0.gml", EventType.Draw, 0)
        );

        o_skill_bw_targeting_offense.ApplyEvent(ModFiles, 
            new MslEvent("gml_Object_o_skill_bw_targeting_offense_Create_0.gml", EventType.Create, 0),
            new MslEvent("gml_Object_o_skill_bw_targeting_offense_Alarm_1.gml", EventType.Alarm, 1),
            new MslEvent("gml_Object_o_skill_bw_targeting_offense_Step_0.gml", EventType.Step, 0),
            new MslEvent("gml_Object_o_skill_bw_targeting_offense_Other_17.gml", EventType.Other, 17),
            new MslEvent("gml_Object_o_skill_bw_targeting_offense_Other_13.gml", EventType.Other, 13),
            new MslEvent("gml_Object_o_skill_bw_targeting_offense_Other_19.gml", EventType.Other, 19),
            new MslEvent("gml_Object_o_skill_bw_targeting_offense_Other_25.gml", EventType.Other, 25)
        );

        o_bw_aoe_range.ApplyEvent(ModFiles, 
            new MslEvent("gml_Object_o_bw_aoe_range_Create_0.gml", EventType.Create, 0),
            new MslEvent("gml_Object_o_bw_aoe_range_Alarm_1.gml", EventType.Alarm, 1),
            new MslEvent("gml_Object_o_bw_aoe_range_Step_0.gml", EventType.Step, 0),
            new MslEvent("gml_Object_o_bw_aoe_range_Draw_0.gml", EventType.Draw, 0)
        );

        o_soul_absorption_impact.ApplyEvent(ModFiles, 
            new MslEvent("gml_Object_o_soul_absorption_impact_Create_0.gml", EventType.Create, 0),
            new MslEvent("gml_Object_o_soul_absorption_impact_Alarm_1.gml", EventType.Alarm, 1)
        );

        o_skill_category_necromancy.ApplyEvent(ModFiles, 
            new MslEvent("gml_Object_o_skill_category_necromancy_Create_0.gml", EventType.Create, 0),
            new MslEvent("gml_Object_o_skill_category_necromancy_Other_24.gml", EventType.Other, 24),
            new MslEvent("gml_Object_o_skill_category_necromancy_PreCreate_0.gml", EventType.PreCreate, 0)
        );

        // script 
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

        Msl.LoadGML("gml_GlobalScript_scr_get_damage_of_weapon")
            .MatchFrom("var _dmg = 0")
            .InsertBelow(@"var _sus = 0
if (instance_exists(o_inv_right_hand) && instance_exists(o_inv_left_hand))
{
with (o_inv_right_hand)
{
if instance_exists(children)
{
_sus++
with (children)
{
if equipped
_dmg += scr_dsMapFindValue(data, ""DMG"", 0)
}
}
}
with (o_inv_left_hand)
{
if instance_exists(children)
{
_sus++
with (children)
{
if equipped
_dmg += scr_dsMapFindValue(data, ""DMG"", 0)
}
}
}
}")
            .MatchFromUntil("with (children)", "}")
            .Remove()
            .MatchFrom("return _dmg;")
            .InsertAbove("if ((_sus == 2) && (!_isTwoHand)) {_dmg *= 0.5}")
            .Save();

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

        Msl.LoadGML("gml_GlobalScript_scr_qualityBgDraw")
            .MatchFrom("_colorTexture = make_color_rgb(34, 32, 35)\nbreak")
            .InsertBelow(@"case (10 << 0):
_colorBG = make_color_rgb(65, 44, 44)
_colorTexture = make_color_rgb(102, 48, 48)
break")
            .Save();

        Msl.LoadGML("gml_GlobalScript_scr_skill_tier_init")
            .MatchFrom("}")
            .InsertAbove(@"
global.necromancy_tier1 = [""Necromancy"", o_skill_death_plague_ico, o_bw_darkbolt_ico, o_bw_curse_ico]
global.necromancy_tier2 = [""Necromancy"", o_skill_bw_resurrection_ico, o_bw_dark_bless_ico, o_pass_skill_nmadness, o_pass_skill_ndarkness]
global.necromancy_tier3 = [""Necromancy"", o_pass_skill_unholymind, o_skill_bw_touch_ico, o_skill_soul_explosion_ico]")
            .Save();

        Msl.LoadGML("gml_GlobalScript_scr_weapon_generation")
            .MatchFrom("Treasure = (7 << 0)")
            .InsertBelow("Unholy = (10 << 0)")
            .MatchFrom("ds_map_add(tech, string(Treasure), make_colour")
            .InsertBelow("ds_map_add(tech, string(Unholy), make_colour_rgb(236, 77, 73))")
            .Save();
            
        // events
        Msl.LoadGML("gml_Object_c_roadAltar_Other_10")
            .MatchFrom("scr_psychic_change(\"Morale\", 5)")
            .InsertAbove("if (instance_exists(o_skill_bw_resurrection_ico) && (!o_skill_bw_resurrection_ico.is_open)){")
            .MatchFrom("scr_effect_create(o_b_bless, o_skill_lion_charge_ico)")
            .InsertBelow("}")
            .Save();

        Msl.LoadGML("gml_Object_o_attitudes_menu_Create_0")
            .MatchFrom("var _attitudesArray = [")
            .ReplaceBy("var _attitudesArray = [o_allDeffence_Attitude, o_allAttack_Attitude, o_Meditative_Attitude, o_Aggressive_Attitude, o_shout, o_crossbow_charging]")
            .Save();

        Msl.LoadGML("gml_Object_o_b_dark_blessing_Alarm_2")
            .MatchAll()
            .InsertBelow(@"var _dur = duration
if instance_exists(o_player)
{
if is_player(target)
{
if scr_instance_exists_in_list(o_b_deathbless, o_player.buffs)
{
with (o_b_deathbless)
{
if (target == o_player)
duration += _dur
}
instance_destroy()
}
else
{
scr_effect_create(o_b_deathbless, _dur)
instance_destroy()
}
}
}")
            .Save();

        Msl.LoadGML("gml_Object_o_b_magic_unholy_Alarm_2")
            .MatchFrom("scr_guiAnimation_ext(x, y, 787)")
            .ReplaceBy(@"{
with (scr_guiAnimation_ext(x, y, 787))
image_blend = c_teal
}")
            .Save();

        Msl.LoadGML("gml_Object_o_b_magic_unholy_Other_15")
            .MatchFrom("ds_map_replace\nds_map_replace\nds_map_replace")
            .ReplaceBy(@"ds_map_replace(data, ""Magic_Power"", 15)
ds_map_replace(data, ""Unholy_Damage"", (0.125 * scr_get_damage_of_weapon(is_player(target), target)))
ds_map_replace(data, ""Damage_Received"", -5)
ds_map_replace(data, ""Cooldown_Reduction"", -5)")
            .Save();

        Msl.LoadGML("gml_Object_o_Bandit_Draw_0")
            .MatchFrom("image_index = 0")
            .InsertBelow(@"if (faction_id == ""Servant"")
{
if (object_index == o_bandit_paymaster)
sprite_index = s_bandit_paymaster_z
if (object_index == o_bandit_heavyarbalester)
sprite_index = s_bandit_heavyarbalester_z
if (object_index == o_bandit_gmdeserter_gaxe)
sprite_index = s_bandit_gmdeserter_gaxe_z
if (object_index == o_bandit_raubritter_2hsword)
sprite_index = s_bandit_raubritter_2hsword_z
if (object_index == o_bandit_gmdeserter_ghammer)
sprite_index = s_bandit_gmdeserter_ghammer_z
if (object_index == o_bandit_banneret)
sprite_index = s_bandit_banneret_z
if (object_index == o_bandit_raubritter_2hmace)
sprite_index = s_bandit_raubritter_2hmace_z
if (object_index == o_bandit_gmdeserter_polearm)
sprite_index = s_bandit_gmdeserter_polearm_z
if (object_index == o_bandit_geomancer)
sprite_index = s_bandit_geomancer_z
if (object_index == o_bandit_goon_cleaver)
sprite_index = s_bandit_goon_cleaver_z
if (object_index == o_bandit_goon_club)
sprite_index = s_bandit_goon_club_z
if (object_index == o_bandit_thug_club)
sprite_index = s_bandit_thug_club_z
if (object_index == o_bandit_trasher)
sprite_index = s_bandit_trasher_z
if (object_index == o_bandit_trasher_axe)
sprite_index = s_bandit_trasher_axe_z
if (object_index == o_bandit_trasher_sword)
sprite_index = s_bandit_trasher_sword_z
if (object_index == o_bandit_rioter)
sprite_index = s_bandit_rioter_z
if (object_index == o_bandit_renegade)
sprite_index = s_bandit_renegade_z
if (object_index == o_bandit_renegade_sword)
sprite_index = s_bandit_renegade_sword_z
if (object_index == o_bandit_renegade_axe)
sprite_index = s_bandit_renegade_axe_z
if (object_index == o_bandit_renegade_mace)
sprite_index = s_bandit_renegade_mace_z
if (object_index == o_bandit_poacher)
sprite_index = s_bandit_poacher_z
if (object_index == o_bandit_henchman_axe)
sprite_index = s_bandit_henchman_axe_z
if (object_index == o_bandit_sidekick_mace)
sprite_index = s_bandit_sidekick_mace_z
if (object_index == o_bandit_outlaw)
sprite_index = s_bandit_outlaw_z
if (object_index == o_bandit_rogue_mage)
sprite_index = s_bandit_rogue_mage_z
if (object_index == o_bandit_mancatcher)
sprite_index = s_bandit_mancatcher_z
if (object_index == o_bandit_crook)
sprite_index = s_bandit_crook_z
if (object_index == o_bandit_marauder_axe)
sprite_index = s_bandit_marauder_axe_z
if (object_index == o_bandit_marauder_sword)
sprite_index = s_bandit_marauder_sword_z
if (object_index == o_bandit_marauder_mace)
sprite_index = s_bandit_marauder_mace_z
if (object_index == o_bandit_soldier_sword)
sprite_index = s_bandit_soldier_sword_z
if (object_index == o_bandit_soldier_axe)
sprite_index = s_bandit_soldier_axe_z
if (object_index == o_bandit_soldier_mace)
sprite_index = s_bandit_soldier_mace_z
if (object_index == o_bandit_sergeant_hammer)
sprite_index = s_bandit_sergeant_hammer_z
if (object_index == o_bandit_sergeant_sword)
sprite_index = s_bandit_sergeant_sword_z
if (object_index == o_bandit_sergeant_axe)
sprite_index = s_bandit_sergeant_axe_z
if (object_index == o_bandit_sergeant_mace)
sprite_index = s_bandit_sergeant_mace_z
if (object_index == o_bandit_sergeant_gsword)
sprite_index = s_bandit_sergeant_gsword_z
if (object_index == o_bandit_arbalester)
sprite_index = s_bandit_arbalester_z
if (object_index == o_bandit_cutthroat)
sprite_index = s_bandit_cutthroat_z
if (object_index == o_bandit_halberdier)
sprite_index = s_bandit_halberdier_z
if (object_index == o_bandit_conjurer)
sprite_index = s_bandit_conjurer_z
if (object_index == o_bandit_freak)
sprite_index = s_bandit_freak_z
if (object_index == o_bandit_warlock)
sprite_index = s_bandit_warlock_z
if (object_index == o_bandit_kingpin)
sprite_index = s_bandit_kingpin_z
if (object_index == o_bandit_bonebreaker_axe)
sprite_index = s_bandit_bonebreaker_axe_z
if (object_index == o_bandit_bonebreaker_mace)
sprite_index = s_bandit_bonebreaker_mace_z
if (object_index == o_bandit_ringleader_2hsword)
sprite_index = s_bandit_ringleader_2hsword_z
if (object_index == o_bandit_ringleader_shield)
sprite_index = s_bandit_ringleader_shield_z
if (object_index == o_bandit_huntmaster)
sprite_index = s_bandit_huntmaster_z
if (object_index == o_bandit_magehunter)
sprite_index = s_bandit_magehunter_z
if (object_index == o_bandit_duelist)
sprite_index = s_bandit_duelist_z
if (object_index == o_bandit_raubritter_flail)
sprite_index = s_bandit_raubritter_flail_z
if (object_index == o_bandit_longbowman)
sprite_index = s_bandit_longbowman_z
if (object_index == o_bandit_electromancer)
sprite_index = s_bandit_electromancer_z
if (object_index == o_bandit_dog01)
sprite_index = s_bandit_dog_z
if (object_index == o_bandit_dog02)
sprite_index = s_bandit_dog_z
if (object_index == o_bandit_dog03)
sprite_index = s_bandit_dog_z
if (object_index == o_bandit_elite_dog)
sprite_index = s_bandit_elite_dog_z
}")
            .Save();

        string invoke_dog = @"event_inherited()
if ((!(scr_instance_exists_in_list(o_b_servemaster, buffs))) && (!instance_exists(o_res_buff_creator)) && (!instance_exists(o_undead_fixer)))
{
    if (!isLoaded)
    {
        var _dogCount = 1
        if scr_chance_value(75)
        {
            repeat _dogCount
            {
                var _xx = (x + (26 * choose(-1, 1)))
                var _yy = (y + (26 * choose(-1, 1)))
                scr_enemy_create(_xx, _yy, o_bandit_elite_dog)
            }
        }
    }
}
";
        Msl.LoadGML("gml_Object_o_bandit_huntmaster_Alarm_4")
            .MatchAll()
            .ReplaceBy(invoke_dog)
            .Save();
            
        Msl.LoadGML("gml_Object_o_bandit_longbowman_Alarm_4")
            .MatchAll()
            .ReplaceBy(invoke_dog)
            .Save();
        
        Msl.LoadGML("gml_Object_o_bandit_mancatcher_Alarm_4")
            .MatchAll()
            .ReplaceBy(@"event_inherited()
if ((!(scr_instance_exists_in_list(o_b_servemaster, buffs))) && (!instance_exists(o_res_buff_creator)) && (!instance_exists(o_undead_fixer)))
{
    if (!isLoaded)
    {
        var _dogCount = irandom_range(1, 2)
        if scr_chance_value(75)
        {
            repeat _dogCount
            {
                var _xx = (x + (26 * choose(-1, 1)))
                var _yy = (y + (26 * choose(-1, 1)))
                scr_enemy_create(_xx, _yy, choose(o_bandit_dog01, o_bandit_dog02, o_bandit_dog03))
            }
        }
    }
}")
            .Save();

        Msl.LoadGML("gml_Object_o_corpse_Create_0")
            .MatchFrom("event_inherited()")
            .InsertBelow("in_range = 0\nin_range2 = 0")
            .Save();

        Msl.LoadGML("gml_Object_o_corpse_Step_0")
            .MatchAll()
            .InsertBelow(@"if instance_exists(o_player)
{
if (scr_round_cell(point_distance(x, y, o_player.x, o_player.y)) < 156)
in_range = 1
else
in_range = 0
}
if instance_exists(o_player)
{
if (scr_round_cell(point_distance(x, y, o_player.x, o_player.y)) < 182)
in_range2 = 1
else
in_range2 = 0
}")
            .Save();

        Msl.LoadGML("gml_Object_o_darkball_Create_0")
            .MatchAll()
            .InsertBelow("is_special = 0")
            .Save();

        Msl.LoadGML("gml_Object_o_dataLoader_Other_10")
            .MatchFrom("global.bodypart = \"random\"")
            .InsertAbove("global.bw_selection = 0\nglobal.bw_call = 0")
            .Save();

        Msl.LoadGML("gml_Object_o_db_hunger3_Other_10")
            .MatchFrom("if (turn_count == 4")
            .ReplaceBy("if (turn_count == 4 && instance_exists(o_pass_skill_imortall) && (!o_pass_skill_imortall.is_open))")
            .Save();

        Msl.LoadGML("gml_Object_o_db_mute_Destroy_0")
            .MatchFrom("event_inherited()")
            .InsertBelow("if (!__is_undefined(shackles))")
            .Save();

        Msl.LoadGML("gml_Object_o_db_net_Create_0")
            .MatchFrom("buff_snd =")
            .InsertBelow("is_special = 0")
            .Save();

        Msl.LoadGML("gml_Object_o_db_net_Destroy_0")
            .MatchFrom("var _dur = childDuration")
            .InsertBelow("if (!is_special){")
            .MatchFrom("ds_map_set(data, \"Duration\", _dur)")
            .InsertBelow("}")
            .Save();

        Msl.LoadGML("gml_Object_o_db_thirst3_Other_10")
            .MatchFrom("if (turn_count =")
            .ReplaceBy("if (turn_count == 2 && instance_exists(o_pass_skill_imortall) && (!o_pass_skill_imortall.is_open))")
            .Save();

        Msl.LoadGML("gml_Object_o_death_touch_Alarm_1")
            .MatchFrom("var _caster = owner")
            .InsertBelow("if (owner.faction_id != \"Servant\"){")
            .MatchFrom("if (visible && scr_tile_distance(id, _caster) < _caster.VSN)")
            .InsertAbove("if (!(scr_instance_exists_in_list(o_b_servemaster, buffs))){")
            .MatchFrom("scr_restore_hp(id, other.steal, scr_id_get_name(other.id))")
            .InsertBelow(@"}
}
}
}
else
{
with (o_Dead_March)
{
if scr_instance_exists_in_list(o_b_servemaster, buffs)
{
if (visible && scr_tile_distance(id, _caster) < _caster.VSN)
{
with (scr_guiAnimation_ext(x, y, 1277, 1, 1, 0, 16777215, 0))
{
scr_audio_play_at(snd_skill_death_touch_mob_regen)
depth = (other.depth - 1)
scr_set_lt()
}
scr_restore_hp(id, other.steal, scr_id_get_name(other.id))
}
}")
            .Save();

        Msl.LoadGML("gml_Object_o_enemy_birth_Other_7")
            .MatchFrom("with (scr_enemy_create(x, ")
            .InsertAbove(@"if is_special
{
instance_create(x, y, o_res_buff_creator)
with (scr_enemy_create(x, y, 7065, is_cheack))
{
owner = other.owner
scr_agred(100)
event_user(5)
if instance_exists(o_controller)
{
ds_grid_set(o_controller.posgrid, grid_x, grid_y, id)
mp_grid_add_cell(o_controller.grid, grid_x, grid_y)
}
gain_xp *= 1
with (o_pass_skill_unholymind)
event_user(3)
}
instance_destroy()
}
else
{")
            .MatchAll()
            .InsertBelow("}")
            .Save();

            
        Msl.LoadAssemblyAsString("gml_Object_o_enemy_Destroy_0")
            .Apply(EnemyDestroyIterator)
            .Save();

        Msl.LoadGML("gml_Object_o_enemy_Mouse_5")
            .MatchFrom("global.skill_test\nscr_create_context_menu(\"Test_Skill\")")
            .ReplaceBy(@"if ((faction_id == ""Pet"") || (faction_id == ""Servant"") || (faction_id == ""Fallower""))
{
scr_create_context_menu(""Atack"", ""Explore"", ""Swap"")
}")
            .Save();
    
        Msl.LoadGML("gml_Object_o_enemy_pass_zombie_Other_22")
            .MatchFrom("variable_instance_exists(id, \"enemyTag\")")
            .ReplaceBy(@"if (variable_instance_exists(id, ""enemyTag"") && scr_instance_exists_in_list(o_b_servemaster, buffs))
{
scr_param((string(enemyTag) + "" NH""), 0, 1)
}
else if variable_instance_exists(id, ""enemyTag"")")
            .Save();

        Msl.LoadGML("gml_Object_o_flesh_explosion_Other_12")
            .MatchAll()
            .Remove()
            .Save();

        string[] destroyEnemies = {
            "gml_Object_o_ghost_cleric_Destroy_0",
            "gml_Object_o_ghost_commander_Destroy_0",
            "gml_Object_o_ghost_Destroy_0",
            "gml_Object_o_ghost_knight_Destroy_0",
            "gml_Object_o_ghost_monk_Destroy_0",
            "gml_Object_o_ghost_seer_Destroy_0",
            "gml_Object_o_ghost_sergeant_Destroy_0",
            "gml_Object_o_ghost_squire_Destroy_0",
            "gml_Object_o_ghost_templar_Destroy_0"
            };

        foreach(string destroyEnemy in destroyEnemies)
        {
            Msl.LoadGML(destroyEnemy)
                .MatchFrom("can_drop_loot")
                .InsertAbove("if (faction_id != \"Servant\"){")
                .MatchAll()
                .InsertBelow("}")
                .Save();
        }

        Msl.LoadGML("gml_Object_o_howl_Alarm_0")
            .MatchFrom("(id != other.owner)")
            .InsertAbove("if (!(scr_instance_exists_in_list(o_b_servemaster, buffs)))\n{")
            .MatchFrom("state = \"npc combat\"")
            .InsertBelow("}")
            .Save();

        // TODO: check this
        Msl.LoadGML("gml_Object_o_inv_slot_Other_17")
            .MatchFrom("var _pretype = string_extract(ds")
            .InsertAbove(@"if (ds_map_find_value(data, ""quality"") == (10 << 0))
{
_name = (((""Darkened"" + _char) + _space) + weap_name)
ds_map_replace(data, ""Name"", _name)
}")
            .MatchFrom("type_text = (((scr_stringTransformFirst(scr_string_g")
            .InsertBelow(@"if (ds_map_find_value(data, ""quality"") == (10 << 0))
{
type_text = (""Unholy "" + _type_text)
}")
            .Save();

        string[] boss_drop = {
            "gml_Object_o_necromancer_boss_Alarm_4",
            "gml_Object_o_necromancer_boss_staff_Alarm_4",
            "gml_Object_o_necromancer_ritualist_Alarm_4",
            "gml_Object_o_necromancer_wraithbinder_Alarm_4",
            "gml_Object_o_revenant_Alarm_4"
        };

        foreach(string boss in boss_drop)
        {
            Msl.LoadGML(boss)
                .MatchAll()
                .InsertAbove("if ((!(scr_instance_exists_in_list(o_b_servemaster, buffs))) && (!instance_exists(o_res_buff_creator)) && (!instance_exists(o_undead_fixer))){")
                .MatchAll()
                .InsertBelow("}")
                .Save();
        }

        Msl.LoadGML("gml_Object_o_necromancer_wraithbinder_Destroy_0")
            .MatchAll()
            .InsertBelow(@"if ((!instance_exists(o_undead_fixer)) && faction_id != ""Servant"")
scr_loot(o_loot_cgrimoir3, x, y, 100)")
            .Save();

        Msl.LoadGML("gml_Object_o_net_throw_Alarm_0")
            .MatchFrom("scr_audio_play_at")
            .InsertBelow(@"var _own = owner
if scr_instance_exists_in_list(o_b_servemaster, owner.buffs)
{
with (o_db_net)
{
if (owner == _own) is_special = 1
}
}")
            .Save();

        Msl.LoadGML("gml_Object_o_pass_skill_spirit_and_body_Other_13")
            .MatchAll()
            .InsertBelow(@"if (!is_enemy_skill)
{
if (instance_exists(o_pass_skill_kingdead) && o_pass_skill_kingdead.is_open)
{
if is_attack_skill
{
}
else if instance_exists(o_player)
{
with (o_unit)
{
if ((!is_player()) && is_visible() && faction_id != ""Servant"")
instance_create(x, y, o_archtheurgy_impact)
}
}
}
if is_attack_skill
{
}
else if (!global.bw_selection)
{
with (o_b_charged_soul)
event_user(4)
}
global.bw_selection = 0
}")
            .Save();

        Msl.LoadGML("gml_Object_o_player_Create_0")
            .MatchFrom("event_inherited()")
            .InsertBelow("wraith_spin = -4")
            .Save();

        Msl.LoadGML("gml_Object_o_proselyte_martyr_dead_Create_0")
            .MatchFrom("corpse_type")
            .ReplaceBy("corpse_type = o_empty")
            .Save();

        Msl.LoadGML("gml_Object_o_ressurection_Other_7")
            .MatchAll()
            .InsertAbove("scr_bw_checker(owner)")
            .Save();

        Msl.LoadGML("gml_Object_o_sign_of_darkness_Other_11")
            .MatchFrom("Unholy_Damage = ")
            .InsertBelow(@"if instance_exists(owner)
{
if (owner.faction_id != ""Servant"")
{")
            .MatchFrom("if (typeID == \"vampire\" || typeID == \"undead\")")
            .InsertAbove("if (!(scr_instance_exists_in_list(o_b_servemaster, buffs))){")
            .MatchFrom("other.Unholy_Damage")
            .InsertBelow(@"}
}
}
else
{
with (target)
{
if scr_instance_exists_in_list(o_b_servemaster, buffs)
{
if (typeID == ""vampire"" || typeID == ""undead"")
{
scr_temp_incr_atr(""FMB"", -33, o_damage_dealer, id, id)
scr_temp_incr_atr(""MP_Restoration"", 33, o_damage_dealer, id, id)
scr_temp_incr_atr(""CRT"", 9, o_damage_dealer, id, id)
}
else
other.Unholy_Damage = 9
}
}
}")
            .Save();

        Msl.LoadGML("gml_Object_o_skeleton_Destroy_0")
            .MatchFrom("event_inherited()")
            .InsertBelow("if ((!instance_exists(o_undead_fixer)) && faction_id != \"Servant\"){")
            .MatchFrom("}")
            .InsertAbove("}")
            .Save();

        Msl.LoadGML("gml_Object_o_skill_enchantment_Other_20")
            .MatchFrom("if (owner.object_index != o_trade_inventory")
            .ReplaceBy("if (owner.object_index != o_trade_inventory && is_weapon && scr_dsMapFindValue(data, \"identified\", 0) && (!(scr_dsMapFindValue(data, \"is_cursed\", 1))) && scr_dsMapFindValue(data, \"quality\", -4) != (6 << 0) && scr_dsMapFindValue(data, \"quality\", -4) != (10 << 0))")
            .Save();

        Msl.LoadGML("gml_Object_o_skillmenu_Create_0")
            .MatchFrom("var _metaCategoriesArray = ")
            .ReplaceBy("var _metaCategoriesArray = [[o_skill_category_sword, o_skill_category_axe, o_skill_category_mace, o_skill_category_dagger, o_skill_category_greatsword, o_skill_category_greataxe, o_skill_category_greatmauls, o_skill_category_polearms, o_skill_category_bows, o_skill_category_shields, o_skill_category_staves, o_skill_category_wands], [o_skill_category_basic_skills, o_skill_category_dual_wielding, o_skill_category_survival, o_skill_category_combat, o_skill_category_athletics, o_skill_category_mastery_of_magic, o_skill_category_necromancy, o_skill_category_basic_armor, o_skill_category_alchemy, o_skill_category_sabotage], [o_skill_category_pyromancy, o_skill_category_geomancy, o_skill_category_electromancy, o_skill_category_venomancy, o_skill_category_cryomancy, o_skill_category_astromancy, o_skill_category_chronomancy, o_skill_category_psymancy, o_skill_category_arcanistics]]")
            .Save();

        Msl.LoadGML("gml_Object_o_small_troll_Other_7")
            .MatchAll()
            .InsertBelow(@"if (state == ""threat"")
{
if (spr == threat_sprite_start)
{
spr = threat_sprite_loop
sprite_index = threat_sprite_loop
}
if is_array(threat_sound_array)
{
audio_stop_sound(threat_sound)
var _can_play = 1
with (object_index)
{
if (id != other.id && visible)
{
if audio_is_playing(threat_sound)
_can_play = 0
}
}
if _can_play
threat_sound = scr_audio_play_at(threat_sound_array[1])
}
}
else
{
scr_enemy_stop_animation()
if audio_is_playing(threat_sound)
audio_stop_sound(threat_sound)
}")
            .Save();

        Msl.LoadGML("gml_Object_o_summon_blood_golem_bith_Other_10")
            .MatchFrom("is_execute = 1")
            .InsertBelow(@"if (owner.faction_id != ""Servant"")
{
}
else
instance_create(x, y, o_res_buff_creator)")
            .Save();

        Msl.LoadGML("gml_Object_o_whitchousecontainer02_Other_10")
            .MatchFrom("scr_inventory_add_item(o_inv_treatise_geo2)")
            .InsertBelow(@"if scr_chance_value(50) {scr_inventory_add_item(o_inv_cgrimoir)}
else if scr_chance_value(75) {scr_inventory_add_item(o_inv_cgrimoir2)}
else {scr_inventory_add_item(o_inv_cgrimoir3)}")
            .Save();

        Msl.LoadGML("gml_Object_o_wraith_summoning_Other_10")
            .MatchFrom("var _spr = s_wraithsummon_hit")
            .InsertBelow(@"if (owner.faction_id == ""Servant"")
instance_create(x, y, o_res_buff_creator)")
            .Save();


        // TODO: add a room
        /* Msl.LoadGML("gml_RoomCC_r_disclaimer2_0_Create")
            .MatchFrom("roomNext")
            .ReplaceBy("roomNext = r_bw_disclaimer")
            .Save(); */

        // table
        List<string>? ai_table = ModLoader.GetTable("gml_GlobalScript_table_animals_ai");
        List<string> new_ai_elements = new() { 
            "Servant;Pet;Fallower;", 
            "3;1;2;", // moose
            "3;3;3;", // saiga
            "3;3;3;", // deer
            "1;1;1;", // bear
            "2;1;1;", // wolf
            "1;1;1;", // gulon
            "1;1;1;", // young troll
            "3;3;3;", // fox
            "3;1;2;", // boar
            "2;1;2;", // bison
            "3;3;3;", // squirrel
            "3;3;3;", // rabbit
            "3;3;3;", // hedgehog
            "3;3;3;", // snake
            "1;1;;", // forest buzzer
            "1;1;1;", // brigand
            "1;;;", // grandMagistrate
            "1;;;", // rotten willow
            "1;1;1;", // undead
            "1;1;1;", // vampire
            "1;1;1;", // carnivore
            "1;1;1;", // omnivore
            "1;1;1;", // dog
            "1;1;1;", // crawler
            "1;1;1;", // harpy
            "Servant;1;1;1;1;1;1;1;1;1;1;1;1;1;1;1;;1;1;1;1;1;1;1;1;1;1;1;;;;",
            "Pet;1;1;1;1;1;1;1;1;1;1;1;1;1;1;1;;1;;;1;1;1;1;1;1;1;1;;;;",
            "Fallower;1;1;1;1;1;1;1;1;1;1;1;1;1;1;1;;1;;;1;1;1;1;1;1;1;1;;;;"
        };
        if (ai_table != null)
        {
            int i;
            for(i = 0; i < ai_table.Count; i++)
            {
                if (ai_table[i].Contains("1;- Combat")) break;
                ai_table[i] = ai_table[i] + new_ai_elements[i];
            }
            ai_table.Insert(i, new_ai_elements[i]);
            i++;
            ai_table.Insert(i, new_ai_elements[i]);
            i++;
            ai_table.Insert(i, new_ai_elements[i]);
            ModLoader.SetTable(ai_table, "gml_GlobalScript_table_animals_ai");
        }

        Msl.LoadGML("gml_GlobalScript_table_armor")
            .Apply(ArmorIterator)
            .Save();

        Msl.LoadGML("gml_GlobalScript_table_Books")
            .Apply(BooksIterator)
            .Save();

        Msl.LoadGML("gml_GlobalScript_table_Modifiers")
            .Apply(ModifiersIterator)
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

        Msl.LoadGML("gml_GlobalScript_table_skills")
            .Apply(SkillsIterator)
            .Save();
    }
    private static IEnumerable<string> EnemyDestroyIterator(IEnumerable<string> input)
    {
        int status = 0;
        int index_player = DataLoader.data.GameObjects.IndexOf(Msl.GetObject("o_player"));
        int index_nmadness = DataLoader.data.GameObjects.IndexOf(Msl.GetObject("o_pass_skill_nmadness"));
        string saved_branch_true = "";
        foreach(string item in input)
        {
            if (status == 0 && item.Contains("call.i event_inherited(argc=0)"))
            {
                status = 1;
                yield return item;
            }
            else if (status == 1 && item.Contains("popz.v"))
            {
                status = 2;
                yield return item;
                yield return @"
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
popenv [1000]";
            }
            else if (status == 2 && item.Contains("bf"))
            {
                status = 3;
                yield return item;
                yield return $@":[1011]
pushi.e {index_player}
conv.i.v
push.v self.id
call.i gml_Script_scr_tile_distance(argc=2)
pushi.e 20
cmp.i.v LTE
bf [1016]

:[1012]
push.v {index_player}.id
call.i string(argc=1)
push.v self.Received_Damage_Priority
call.i ds_map_find_value(argc=2)
conv.v.b
bt [1014]

:[1013]
pushloc.v local._is_player_attacker
conv.v.b
b [1015]

:[1014]
push.e 1

:[1015]
b [1017]

:[1016]
push.e 0

:[1017]
pop.v.b local._vanilla_condition";
            }
            else if (status == 3 && item.Contains($"pushi.e {index_player}"))
            {
                status = 4;
            }
            else if (status == 4 && item.Contains("bt"))
            {
                status = 5;
                saved_branch_true = item;
            }
            else if (status == 5 && item.Contains("pushloc.v local._is_player_attacker"))
            {
                status = 6;
                yield return $@"pushloc.v local._vanilla_condition
conv.v.b
{saved_branch_true}

:[1020]
pushloc.v local._shomar";
            }
            else if (status == 6 && item.Contains("push.v self.gain_xp"))
            {
                status = 7;
                yield return $@"pushloc.v local._vanilla_condition
conv.v.b
bt [1035]

:[1031]
pushi.e {index_nmadness}
conv.i.v
call.i instance_exists(argc=1)
conv.v.b
bf [1033]

:[1032]
push.v {index_nmadness}.is_open
conv.v.b
b [1034]

:[1033]
push.e 0

:[1034]
b [1036]

:[1035]
push.e 1

:[1036]
bf [1038]

:[1037]";
                yield return item;     
            }
            else if (status == 7 && item.Contains($"pushi.e {index_player}"))
            {
                status = 8;
                yield return $@"b [1040]

:[1038]
pushloc.v local._shomar
conv.v.b
bf [1040]

:[1039]
pushi.e 1
conv.i.v
push.v self.gain_xp
call.i gml_Script_scr_get_XP(argc=2)
pop.v.v local.xp
pushloc.v local.xp
push.v self.id
call.i gml_Script_scr_id_get_name(argc=1)
call.i @@NewGMLArray@@(argc=1)
push.s ""death""
conv.s.v
call.i gml_Script_scr_actionsLogXP(argc=3)
popz.v

:[1040]
";
                yield return item;
            }
            // 3, 4 and 5 are removed
            else if (status < 3 || status > 5)
            {
                yield return item;
            }
        }
    }
    private static IEnumerable<string> ArmorIterator(IEnumerable<string> input)
    {
        string helmets = "\"// HELMETS;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;\",";
        string chestpieces = "\"// CHESTPIECES;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;\",";
        string rings = "\"// RINGS;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;\",";
        foreach(string item in input)
        {
            if(item.Contains(helmets))
            {
                string newItem = item;
                newItem = newItem.Insert(newItem.IndexOf(helmets) + helmets.Length, "\"sinistercrown;20;head101;Head;Light;Unique;metal;6000;333;;;;;;;1;;;;;;25;;;10;;;;;;;;;;;;;;;;;;;;;;;;10;;;;;;;;;;;;;;;;;;;;;;;;;;-33;;;;aldor magic;;;;;;;;;;;;;;;;;\",");
                newItem = newItem.Insert(newItem.IndexOf(chestpieces) + chestpieces.Length, "\"hexermantle;15;chest101;Chest;Light;Unique;cloth;2400;120;5;;;;;;;;15;;;;16;;-7;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;5;15;25;;;;;;;;;;;;13;;;;aldor magic;;;;4;;;;;;;;;;;;;\",");
                newItem = newItem.Insert(newItem.IndexOf(rings) + rings.Length, "\"Skull Morion Ring;20;ring101;Ring;Light;Unique;wood;1200;33;;;;;;;;;;;;;;;;;;;;;;;;;;;;6;;;;;;9;;;;;;;;;;;;;;;;;;;16;;;;;;;;;;;;;16;;;;special;;;;;;;;;;;;;;;;;\",");
                yield return newItem;
            }
            else
            {
                yield return item;
            }
        }
    }
    private static IEnumerable<string> BooksIterator(IEnumerable<string> input)
    {
        string bookname = "book_name;\",";
        string bookstart = "book_content;\",";
        string bookmid = "book_mid_text;\",";
        string bookdesc = "book_desc;\",";
        string booktype = "book_type;\",";

        string grimoir1_id = "cgrimoir";

        string grimoir1_name_ru = @"Оккультный трактат I";
        string grimoir1_name_en = @"Occult Treatise I";
        string grimoir1_start_en = @". . . I’ve done it. The rat came back to life, squirming its little body with all the energy of a healthy newborn around the dagger with which I pinned it to the table last night.#I had to redraw the sigil five times but finally, I have done the impossible. I was so close to hurling my grimoire into the fireplace.#I was ready to give up and travel to the Cathedral to throw myself on my knees and beg for forgiveness. But it worked. I have created life from death.##It didn’t live for long, and perhaps that is a mercy. It limped around the table when I removed the dagger, squealing with obvious pain and terror, unable to react to any of the stimuli I prepared.#Finally the sun rose, and in its light the thing curled up and went quiet. Obviously I have a long way to go. I can’t bring her back like this.##Morella, forgive me. I must continue my experiments. I won’t waste more time with rats and frogs. Perhaps their souls are too small or their bodies too weak to properly receive the energies which flow from my sigil and my incantations without being damaged.#Perhaps I merely require practice until I have perfected this ritual. But in either case, I don’t have time to play with these trivial creatures while my love decays in her tomb. I must have a human corpse.##Tonight, the graveyard will yield the subject of my next breakthrough. . .";
        string grimoir1_mid_ru = @"\""Запретный сигил: Раскрытие магии через подобающие ритуалы.\""##~gr~Открывает возможность изучить некоторые оккультные способности:~/~##~lg~Осквернение~/~#~lg~Мучительное проклятие~/~#~lg~Поглощение души~/~##Прочтение этой книги приносит ~y~опыт~/~.";
        string grimoir1_mid_en = @"\""The Forbidden Sigil: Unveiling magic through proper rituals.\""##~gr~Allows you to learn the following Occultism abilities:~/~##~lg~Desecration~/~#~lg~Painful Curse~/~#~lg~Soul Absorption~/~##Reading this book grants some ~y~Experience~/~.";
        string grimoir1_desc_ru = @"Более половины этой пыльной книги наполнено бессмысленными выражениями и рассуждениями.";
        string grimoir1_desc_en = @"More than half of this dusty journal is filled with meaningless expressions and references.";
        string grimoir1_type_ru = @"Автор: Силас, священнослужитель";
        string grimoir1_type_en = @"Written by Silas the priest";

        string grimoir2_id = "cgrimoir2";

        string grimoir2_name_ru = @"Оккультный трактат II";
        string grimoir2_name_en = @"Occult Treatise II";
        string grimoir2_start_en = ". . . His subservience thrills and disgusts me. It is as though his personality decayed with his flesh. He at least remembers what his name was in life and can answer my questions when I speak slowly and loudly and avoid abstraction.## But he will say nothing of his own volition, do nothing except gnaw on things and smack his head against the wall. What a pitiful condition. But he lives again, despite the noose still tied around his neck. And he is intelligent enough to follow commands.##And he is strong, stronger than his putrefying muscles could possibly allow.## When I ordered him to guard me last night as I dug him up a brother, we were set upon by a territorial ghoul, angry that I was raiding its larder.# My new servant seized its arm, ripped it off and proceeded to beat the creature to death with it.#How can he be possessed of such power? My theory is that the energies with which I brought him back to life have not dissipated but suffuse his body still.# Perhaps this means that flesh is not even necessary for reanimation.## I will perform the ritual on a skeleton! . . .";
        string grimoir2_mid_ru = @"\""Устланный пороком путь вспять уже не обернуть.\""##~gr~Открывает возможность изучить некоторые оккультные способности:~/~##~lg~Ритуал воскрешения~/~#~lg~Дары Смерти~/~#~y~Расцветающее безумие~/~#~y~Абсолютная тьма~/~##Прочтение этой книги приносит ~y~опыт~/~.";
        string grimoir2_mid_en = @"\""Danger awaits as madness thrives through your mistakes.\""##~gr~Allows you to learn the following Occultism abilities:~/~##~lg~Ritual of Resurrection~/~#~lg~Death's Blessing~/~#~y~Growing Madness~/~#~y~Absolute Darkness~/~##Reading this book grants some ~y~Experience~/~.";
        string grimoir2_desc_ru = @"Более половины этой пыльной книги наполнено бессмысленными выражениями и рассуждениями.";
        string grimoir2_desc_en = @"More than half of this dusty journal is filled with meaningless expressions and references.";
        string grimoir2_type_ru = @"Автор: Силас, священнослужитель";
        string grimoir2_type_en = @"Written by Silas the priest";

        string grimoir3_id = "cgrimoir3";

        string grimoir3_name_ru = @"Оккультный трактат III";
        string grimoir3_name_en = @"Occult Treatise III";
        string grimoir3_start_en = ". . . My creatures still terrify me but oh, the excitement is molten gold in my veins. The grimoire sings in my hands. My staff twists and churns under my fingers like a dying thing. The moon is a door and I am opening it, and what secrets whisper to me from the other side! Morella, if only you were here to see the fruit of my research!##Morella… I have scarcely had time to think of you these past few weeks. The work has taken on a life of its own, so to speak. I understand I can never bring you back the way you were. At first I grieved at the realisation, defeated. I missed your fair hair and your rosy cheeks and your sparkling eyes. I choked at the thought of returning you to life in the rotting shell of your former self, or untouchable and freezing cold like the wraiths which pour like tears up from the earth when I weep.##But the work continued and my insight grew and the whispers taught me that there is beauty in decay. Decay is life! The mould that grows on our bones is alive and it sings in the voice of the trees, the forest, the stars. All life sings in the voice of death. It is a blessing. I don’t remember the way your voice sounded. But I will give you a new voice. You will sing for me again and the worms will writhe in delight at your song.##And we will have a kingdom of our own, my love. I have made us a court. I have made us an army. They are so many now. At first I could only seize one at a time in my mind’s fist but I have learned to link their souls in a lattice which holds them all together. The lattice is a pattern, a rhythm. Our soldiers stumble from room to room of our palace with this rhythm guiding their steps, as they guard your tomb. It is a dance. It is the rhythm of your song. The lyrics were written in the caverns of our ancestors. They are written between the stars. The song. . .";
        string grimoir3_mid_ru = @"\""И когда планеты встанут в ряд - начнётся твой обряд, и тогда руки твои соткут ткань вознесения, даруя истинное благословение.\""##~gr~Открывает возможность изучить некоторые оккультные способности:~/~##~lg~Касание смерти~/~#~y~Пожинание хаоса~/~#~y~Жертвоприношение души~/~##Прочтение этой книги приносит ~y~опыт~/~.";
        string grimoir3_mid_en = @"\""A celestial choreography unfolds, as the hands intricately weave the fabric of ascension, bestowing upon us a true blessing.\""##~gr~Allows you to learn the following Occultism abilities:~/~##~lg~Death Touch~/~#~y~Grasp of Chaos~/~#~y~Soul Sacrifice~/~##Reading this book grants some ~y~Experience~/~.";
        string grimoir3_desc_ru = @"Более половины этой пыльной книги наполнено бессмысленными выражениями и рассуждениями.";
        string grimoir3_desc_en = @"More than half of this dusty journal is filled with meaningless expressions and references.";
        string grimoir3_type_ru = @"Автор: Силас, священнослужитель";
        string grimoir3_type_en = @"Written by Silas the priest";

        string grimoir1_name = $"{grimoir1_id};{grimoir1_name_ru};" + string.Concat(Enumerable.Repeat($"{grimoir1_name_en};", 13));
        string grimoir2_name = $"{grimoir2_id};{grimoir2_name_ru};" + string.Concat(Enumerable.Repeat($"{grimoir2_name_en};", 13));
        string grimoir3_name = $"{grimoir3_id};{grimoir3_name_ru};" + string.Concat(Enumerable.Repeat($"{grimoir3_name_en};", 13));

        string grimoir1_start = $"{grimoir1_id};" + string.Concat(Enumerable.Repeat($"{grimoir1_start_en};", 14));
        string grimoir2_start = $"{grimoir2_id};" + string.Concat(Enumerable.Repeat($"{grimoir2_start_en};", 14));
        string grimoir3_start = $"{grimoir3_id};" + string.Concat(Enumerable.Repeat($"{grimoir3_start_en};", 14));

        string grimoir1_mid = $"{grimoir1_id};{grimoir1_mid_ru};" + string.Concat(Enumerable.Repeat($"{grimoir1_mid_en};", 13));
        string grimoir2_mid = $"{grimoir2_id};{grimoir2_mid_ru};" + string.Concat(Enumerable.Repeat($"{grimoir2_mid_en};", 13));
        string grimoir3_mid = $"{grimoir3_id};{grimoir3_mid_ru};" + string.Concat(Enumerable.Repeat($"{grimoir3_mid_en};", 13));

        string grimoir1_desc = $"{grimoir1_id};{grimoir1_desc_ru};" + string.Concat(Enumerable.Repeat($"{grimoir1_desc_en};", 13));
        string grimoir2_desc = $"{grimoir2_id};{grimoir2_desc_ru};" + string.Concat(Enumerable.Repeat($"{grimoir2_desc_en};", 13));
        string grimoir3_desc = $"{grimoir3_id};{grimoir3_desc_ru};" + string.Concat(Enumerable.Repeat($"{grimoir3_desc_en};", 13));

        string grimoir1_type = $"{grimoir1_id};{grimoir1_type_ru};" + string.Concat(Enumerable.Repeat($"{grimoir1_type_en};", 13));
        string grimoir2_type = $"{grimoir2_id};{grimoir2_type_ru};" + string.Concat(Enumerable.Repeat($"{grimoir2_type_en};", 13));
        string grimoir3_type = $"{grimoir3_id};{grimoir3_type_ru};" + string.Concat(Enumerable.Repeat($"{grimoir3_type_en};", 13));
        foreach(string item in input)
        {
            if(item.Contains(bookname))
            {
                string newItem = item;
                
                newItem = newItem.Insert(newItem.IndexOf(bookname) + bookname.Length, $"\"{grimoir1_name}\",\"{grimoir2_name}\",\"{grimoir3_name}\",");
                newItem = newItem.Insert(newItem.IndexOf(bookstart) + bookstart.Length, $"\"{grimoir1_start}\",\"{grimoir2_start}\",\"{grimoir3_start}\",");
                newItem = newItem.Insert(newItem.IndexOf(bookmid) + bookmid.Length, $"\"{grimoir1_mid}\",\"{grimoir2_mid}\",\"{grimoir3_mid}\",");
                newItem = newItem.Insert(newItem.IndexOf(bookdesc) + bookdesc.Length, $"\"{grimoir1_desc}\",\"{grimoir2_desc}\",\"{grimoir3_desc}\",");
                newItem = newItem.Insert(newItem.IndexOf(booktype) + booktype.Length, $"\"{grimoir1_type}\",\"{grimoir2_type}\",\"{grimoir3_type}\",");
                yield return newItem;
            }
            else
            {
                yield return item;
            }
        }
    }
    private static IEnumerable<string> ModifiersIterator(IEnumerable<string> input)
    {
        string buff_name = "buff_name;\",";
        string buff_desc = "buff_desc;\",";

        string id_angel_charm = "o_b_angel_charm";
        string name_angel_charm_ru = "Вознесение";
        string name_angel_charm_en = "Ascension";
        string name_angel_charm = $"{id_angel_charm};{name_angel_charm_ru};" + string.Concat(Enumerable.Repeat($"{name_angel_charm_en};", 11));
        string desc_angel_charm_ru = @"";
        string desc_angel_charm_en = @"";
        string desc_angel_charm= $"{id_angel_charm};{desc_angel_charm_ru};" + string.Concat(Enumerable.Repeat($"{desc_angel_charm_en};", 11));

        string id_takeover = "o_db_takeover";
        string name_takeover_ru = "Одержимость";
        string name_takeover_en = "Obsession";
        string name_takeover = $"{id_takeover};{name_takeover_ru};" + string.Concat(Enumerable.Repeat($"{name_takeover_en};", 11));
        string desc_takeover_ru = @"Штрафы меняются каждый ход в зависимости от недостающего ~lg~рассудка~/~.##Может вызвать ~r~Замешательство~/~ или ~r~Ошеломление~/~.##~r~Смерть близка~/~: каждые несколько ходов максимальное здоровье снижается.";
        string desc_takeover_en = @"The penalties change dynamically depending on the missing percentage of ~lg~Sanity~/~.##May Cause ~r~Confusion~/~ or ~r~Daze~/~.##Deals ~ur~1-3 Unholy Damage~/~ if sanity drops below ~r~33%~/~.##~r~Near death~/~: the character's Max Health is reduced every few turns.";
        string desc_takeover = $"{id_takeover};{desc_takeover_ru};" + string.Concat(Enumerable.Repeat($"{desc_takeover_en};", 11));

        string id_unbind = "o_b_unbind";
        string name_unbind_ru = "Отвязать";
        string name_unbind_en = "Unbind";
        string name_unbind = $"{id_unbind};{name_unbind_ru};" + string.Concat(Enumerable.Repeat($"{name_unbind_en};", 11));
        string desc_unbind_ru = @"Нажатие на иконку эффекта или клавиши ~r~N~/~ в этом окне моментально убивает эту нежить. Тратит ход.";
        string desc_unbind_en = @"Clicking on this icon instantly kills this undead and then advances a turn.";
        string desc_unbind = $"{id_unbind};{desc_unbind_ru};" + string.Concat(Enumerable.Repeat($"{desc_unbind_en};", 11));

        string id_darkenchant = "o_b_darkenchant";
        string name_darkenchant_ru = "Тёмный договор";
        string name_darkenchant_en = "Dark Enchantment";
        string name_darkenchant = $"{id_darkenchant};{name_darkenchant_ru};" + string.Concat(Enumerable.Repeat($"{name_darkenchant_en};", 11));
        string desc_darkenchant_ru = @"";
        string desc_darkenchant_en = @"";
        string desc_darkenchant = $"{id_darkenchant};{desc_darkenchant_ru};" + string.Concat(Enumerable.Repeat($"{desc_darkenchant_en};", 11));

        string id_punishment = "o_db_punishment";
        string name_punishment_ru = "Punishment";
        string name_punishment_en = "Punishment";
        string name_punishment = $"{id_punishment};{name_punishment_ru};" + string.Concat(Enumerable.Repeat($"{name_punishment_en};", 11));
        string desc_punishment_ru = @"";
        string desc_punishment_en = @"";
        string desc_punishment = $"{id_punishment};{desc_punishment_ru};" + string.Concat(Enumerable.Repeat($"{desc_punishment_en};", 11));

        string id_exceptional = "o_b_exceptional";
        string name_exceptional_ru = "Исключительная душа";
        string name_exceptional_en = "Disorder";
        string name_exceptional = $"{id_exceptional};{name_exceptional_ru};" + string.Concat(Enumerable.Repeat($"{name_exceptional_en};", 11));
        string desc_exceptional_ru = @"Аннулирует штрафы от эффекта ~r~\""Одержимости\""~/~ и препятствует его получению.##Когда эффект заканчивает: ~r~возвращает в загробный мир~/~ всех союзных умертвий.";
        string desc_exceptional_en = @"Negates penalties of ~r~Obsession~/~.##Prevents from receiving ~r~Obsession~/~.##When effect expires: ~r~unbinds~/~ all allied wraiths.";
        string desc_exceptional = $"{id_exceptional};{desc_exceptional_ru};" + string.Concat(Enumerable.Repeat($"{desc_exceptional_en};", 11));

        string id_bw_sacrifice = "o_bw_sacrifice";
        string name_bw_sacrifice_ru = "Soul Sacrifice";
        string name_bw_sacrifice_en = "Soul Sacrifice";
        string name_bw_sacrifice = $"{id_bw_sacrifice};{name_bw_sacrifice_ru};" + string.Concat(Enumerable.Repeat($"{name_bw_sacrifice_en};", 11));
        string desc_bw_sacrifice_ru = @"Pressing ~r~K~/~ activates the effect and then advances a turn.##Activation consumes ~bl~10%~/~ of Max Energy.;Pressing ~r~K~/~ activates the effect and then advances a turn.##Activation consumes ~bl~10%~/~ of Max Energy.";
        string desc_bw_sacrifice_en = @"Pressing ~r~K~/~ activates the effect and then advances a turn.##Activation consumes ~bl~10%~/~ of Max Energy.;Pressing ~r~K~/~ activates the effect and then advances a turn.##Activation consumes ~bl~10%~/~ of Max Energy.";
        string desc_bw_sacrifice = $"{id_bw_sacrifice};{desc_bw_sacrifice_ru};" + string.Concat(Enumerable.Repeat($"{desc_bw_sacrifice_en};", 11));

        string id_servemaster = "o_b_servemaster";
        string name_servemaster_ru = "Оживление";
        string name_servemaster_en = "Revivify";
        string name_servemaster = $"{id_servemaster};{name_servemaster_ru};" + string.Concat(Enumerable.Repeat($"{name_servemaster_en};", 11));
        string desc_servemaster_ru = @"Считается ~r~нежитью~/~: привод в город является ~r~преступлением~/~.##Способно ~lg~следовать~/~ за вами по всей карте.##Нажатие по иконке ~y~левой кнопкой мыши~/~ переключает режим поведения юнита между ~lg~Следованием~/~ и ~r~Агрессией~/~.#Нажатие по иконке ~y~правой кнопкой мыши~/~ переключает режим поведения юнита между ~lg~Простоем~/~ и ~p~Автономией~/~.##Нажатие клавиши ~y~C~/~ позволяет задать точку для перемещения подконтрольной нежити.#Нажатие клавиши ~y~V~/~ позволяет задать цель для атаки подконтрольной нежити.";
        string desc_servemaster_en = @"Considered as an ~r~Undead~/~: bringing it inside settlements is ~r~Crime~/~.##Capable of ~lg~Following~/~ you everywhere on the map.##~y~Left clicking~/~ this icon switches ~r~Aggressive~/~ and ~lg~Follow~/~ mode.#~y~Right clicking~/~ this icon switches ~lg~Idle~/~ and ~p~Autonomous~/~ mode.##Pressing ~y~V~/~ allows for selectable positioning.";
        string desc_servemaster = $"{id_servemaster};{desc_servemaster_ru};" + string.Concat(Enumerable.Repeat($"{desc_servemaster_en};", 11));

        string id_charged_soul = "o_b_charged_soul";
        string name_charged_soul_ru = "Поглощённая душа";
        string name_charged_soul_en = "Charged Soul";
        string name_charged_soul = $"{id_charged_soul};{name_charged_soul_ru};" + string.Concat(Enumerable.Repeat($"{name_charged_soul_en};", 11));
        string desc_charged_soul_ru = @"Использование ~w~Заклинаний~/~ уменьшает степень эффекта на ~r~1~/~.##Повторное произнесение ~lg~Поглощения души~/~ увеличивает степень эффекта (вплоть до ~sy~IV~/~) и обновляет его длительность.";
        string desc_charged_soul_en = @"Using ~w~Spells~/~ reduce the number of stacks by ~r~1~/~.##The repeated use of ~lg~Soul Absorption~/~ grants an extra stack of the effect (up to ~w~IV~/~) and refreshes its duration.";
        string desc_charged_soul = $"{id_charged_soul};{desc_charged_soul_ru};" + string.Concat(Enumerable.Repeat($"{desc_charged_soul_en};", 11));

        string id_deathbless = "o_b_deathbless";
        string name_deathbless_ru = "Дар Смерти";
        string name_deathbless_en = "Death's Blessing";
        string name_deathbless = $"{id_deathbless};{name_deathbless_ru};" + string.Concat(Enumerable.Repeat($"{name_deathbless_en};", 11));
        string desc_deathbless_ru = @"";
        string desc_deathbless_en = @"";
        string desc_deathbless = $"{id_deathbless};{desc_deathbless_ru};" + string.Concat(Enumerable.Repeat($"{desc_deathbless_en};", 11));

        string id_painful_curse = "o_db_painful_curse";
        string name_painful_curse_ru = "Мучительное проклятие";
        string name_painful_curse_en = "Withering Curse";
        string name_painful_curse = $"{id_painful_curse};{name_painful_curse_ru};" + string.Concat(Enumerable.Repeat($"{name_painful_curse_en};", 11));
        string desc_painful_curse_ru = @"";
        string desc_painful_curse_en = @"";
        string desc_painful_curse = $"{id_painful_curse};{desc_painful_curse_ru};" + string.Concat(Enumerable.Repeat($"{desc_painful_curse_en};", 11));

        string name = $"\"{name_angel_charm}\",\"{name_takeover}\",\"{name_unbind}\",\"{name_darkenchant}\",\"{name_punishment}\",\"{name_exceptional}\",\"{name_bw_sacrifice}\",\"{name_servemaster}\",\"{name_charged_soul}\",\"{name_deathbless}\",\"{name_painful_curse}\",";
        string desc = $"\"{desc_angel_charm}\",\"{desc_takeover}\",\"{desc_unbind}\",\"{desc_darkenchant}\",\"{desc_punishment}\",\"{desc_exceptional}\",\"{desc_bw_sacrifice}\",\"{desc_servemaster}\",\"{desc_charged_soul}\",\"{desc_deathbless}\",\"{desc_painful_curse}\",";
        
        foreach(string item in input)
        {
            if (item.Contains(buff_name))
            {
                string newItem = item;
                newItem = newItem.Insert(newItem.IndexOf(buff_name) + buff_name.Length, name);
                newItem = newItem.Insert(newItem.IndexOf(buff_desc) + buff_desc.Length, desc);
                yield return newItem;
            }
            else
            {
                yield return item;
            }
        }
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

        string sealofpower_en = "#~ur~Occultism:~/~ ~lg~+15%~/~ Magic Power, ~lg~+12.5%~/~ Weapon Damage, dealt as Unholy, ~lg~-5%~/~ Damage Taken, ~lg~-5%~/~ Cooldown Durations";

        string undead = "\";;///// UNDEAD;///// UNDEAD;;;;;///// UNDEAD;///// UNDEAD;;;;\",";
        string skillsDesc = @"""Soul_Explosion;
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
        Unbinding allies doesn't take a turn and replenishes ~bl~Energy~/~ equal to ~w~10%~/~ of your Magic Power.##Increases the ~w~level~/~ of summoning abilities by ~lg~1~/~.;
        "",
        ""imortall;
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
        Prevents dying from lethal hits as long as ~r~Max Health~/~ and ~lg~Morale~/~ are both higher than ~lg~50%~/~.##When ~r~Health~/~ drops below 2, replenishes ~lg~33%~/~ of ~r~Max Health~/~ and ~bl~Max Energy~/~, and applies:##~r~-10% Morale~/~#~r~+2% Fatigue~/~##Prevents ~r~death~/~ from starvation or dehydration.;
        "",
        ""kingdead;
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
        Casting ~w~Spells~/~ deal ~ur~/*Unholy_Damage*/ Unholy Damage~/~ to all enemies within vision (based on ~lg~3.33%~/~ of ~w~Magic Power~/~).##~w~Raising the dead~/~, ~w~summoning wraiths~/~, ~w~Stealing Essence~/~ or ~w~receiving~/~ ~lg~\""Death's Blessing\""~/~ has ~lg~33%~/~ chance to activate ~lg~\""Ascension\""~/~ for ~w~6~/~ turns, granting:##~lg~+33%~/~ Unholy Resistance#~lg~+66%~/~ Miracle Potency#Converts ~ur~Unholy Damage~/~ into ~ly~Sacred Damage~/~.;
        "",
        ""Lostsouls;
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
        Reanimates up to ~w~3~/~ corpses within ~w~6~/~ tiles, restoring them to ~lg~33%~/~ of their ~r~Max Health~/~ and ~lg~33%~/~ ~bl~Max Energy~/~.##Summons a ~w~Wraith~/~ for each missing corpse within the area of effect. The ~w~Wraith's~/~ power depends on the number of ~lg~\""Essence Charge\""~/~ stacks.##Grants ~w~3-6~/~ turns of ~lg~\""Disorder\""~/~ for each instance of ~w~Summoning~/~. ~w~Wraiths~/~ ~r~die~/~ once ~lg~\""Disorder\""~/~ expires.##This spell cannot be cast while under the effects of ~r~\""Obsession\""~/~ or ~lg~\""Disorder\""~/~.;
        "",
        ""Death_Plague;
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
        Devours a targeted corpse or steals ~r~13%~/~ Max Health and ~bl~13%~/~ Max Energy from an Undead ally, transferring half of them to the caster.##Activates ~lg~\""Essence Charge\""~/~ for ~w~30~/~ turns:##~lg~+5%~/~ Weapon Damage#~lg~+10%~/~ Magic Power#~lg~-6%~/~ Abilities Energy Cost#~lg~+8~/~ Max Energy#~lg~+66%~/~ Fatigue Resistance (this effect decreases based on the stacks)##~w~III~/~ and ~w~IV~/~ stacks of the effect: slight chance of causing ~r~\""Obsession\""~/~.##Using ~w~Spells~/~ reduce the number of stacks by ~r~1~/~.##The repeated use of the spell grants an extra stack of the effect (up to ~w~IV~/~) and refreshes its duration.;
        "",
        ""nmadness;
        Successfully raising the dead allows you to ~y~learn~/~ their ~w~active abilities~/~ (for as long as they are available via skill menu).##Increases ~y~Experience Gain~/~ of Undead kills by ~lg~100%~/~.;
        Successfully raising the dead allows you to ~y~learn~/~ their ~w~active abilities~/~ (for as long as they are available via skill menu).##Increases ~y~Experience Gain~/~ of Undead kills by ~lg~100%~/~.;
        Successfully raising the dead allows you to ~y~learn~/~ their ~w~active abilities~/~ (for as long as they are available via skill menu).##Increases ~y~Experience Gain~/~ of Undead kills by ~lg~100%~/~.;
        Successfully raising the dead allows you to ~y~learn~/~ their ~w~active abilities~/~ (for as long as they are available via skill menu).##Increases ~y~Experience Gain~/~ of Undead kills by ~lg~100%~/~.;
        Successfully raising the dead allows you to ~y~learn~/~ their ~w~active abilities~/~ (for as long as they are available via skill menu).##Increases ~y~Experience Gain~/~ of Undead kills by ~lg~100%~/~.;
        Successfully raising the dead allows you to ~y~learn~/~ their ~w~active abilities~/~ (for as long as they are available via skill menu).##Increases ~y~Experience Gain~/~ of Undead kills by ~lg~100%~/~.;
        Successfully raising the dead allows you to ~y~learn~/~ their ~w~active abilities~/~ (for as long as they are available via skill menu).##Increases ~y~Experience Gain~/~ of Undead kills by ~lg~100%~/~.;
        Successfully raising the dead allows you to ~y~learn~/~ their ~w~active abilities~/~ (for as long as they are available via skill menu).##Increases ~y~Experience Gain~/~ of Undead kills by ~lg~100%~/~.;
        Successfully raising the dead allows you to ~y~learn~/~ their ~w~active abilities~/~ (for as long as they are available via skill menu).##Increases ~y~Experience Gain~/~ of Undead kills by ~lg~100%~/~.;
        Successfully raising the dead allows you to ~y~learn~/~ their ~w~active abilities~/~ (for as long as they are available via skill menu).##Increases ~y~Experience Gain~/~ of Undead kills by ~lg~100%~/~.;
        "",
        ""unholymind;
        Each turn, decreases max Unholy Resistance of Undeads and Proselytes by ~r~7%~/~ within ~w~7~/~ tiles, which persists for ~w~9~/~ turns.##This effect stacks up to ~w~9~/~ times.##If affecting by ~r~\""Obsession\""~/~, the effect triggers twice per turn.;
        Each turn, decreases max Unholy Resistance of Undeads and Proselytes by ~r~7%~/~ within ~w~7~/~ tiles, which persists for ~w~9~/~ turns.##This effect stacks up to ~w~9~/~ times.##If affecting by ~r~\""Obsession\""~/~, the effect triggers twice per turn.;
        Each turn, decreases max Unholy Resistance of Undeads and Proselytes by ~r~7%~/~ within ~w~7~/~ tiles, which persists for ~w~9~/~ turns.##This effect stacks up to ~w~9~/~ times.##If affecting by ~r~\""Obsession\""~/~, the effect triggers twice per turn.;
        Each turn, decreases max Unholy Resistance of Undeads and Proselytes by ~r~7%~/~ within ~w~7~/~ tiles, which persists for ~w~9~/~ turns.##This effect stacks up to ~w~9~/~ times.##If affecting by ~r~\""Obsession\""~/~, the effect triggers twice per turn.;
        Each turn, decreases max Unholy Resistance of Undeads and Proselytes by ~r~7%~/~ within ~w~7~/~ tiles, which persists for ~w~9~/~ turns.##This effect stacks up to ~w~9~/~ times.##If affecting by ~r~\""Obsession\""~/~, the effect triggers twice per turn.;
        Each turn, decreases max Unholy Resistance of Undeads and Proselytes by ~r~7%~/~ within ~w~7~/~ tiles, which persists for ~w~9~/~ turns.##This effect stacks up to ~w~9~/~ times.##If affecting by ~r~\""Obsession\""~/~, the effect triggers twice per turn.;
        Each turn, decreases max Unholy Resistance of Undeads and Proselytes by ~r~7%~/~ within ~w~7~/~ tiles, which persists for ~w~9~/~ turns.##This effect stacks up to ~w~9~/~ times.##If affecting by ~r~\""Obsession\""~/~, the effect triggers twice per turn.;
        Each turn, decreases max Unholy Resistance of Undeads and Proselytes by ~r~7%~/~ within ~w~7~/~ tiles, which persists for ~w~9~/~ turns.##This effect stacks up to ~w~9~/~ times.##If affecting by ~r~\""Obsession\""~/~, the effect triggers twice per turn.;
        Each turn, decreases max Unholy Resistance of Undeads and Proselytes by ~r~7%~/~ within ~w~7~/~ tiles, which persists for ~w~9~/~ turns.##This effect stacks up to ~w~9~/~ times.##If affecting by ~r~\""Obsession\""~/~, the effect triggers twice per turn.;
        Each turn, decreases max Unholy Resistance of Undeads and Proselytes by ~r~7%~/~ within ~w~7~/~ tiles, which persists for ~w~9~/~ turns.##This effect stacks up to ~w~9~/~ times.##If affecting by ~r~\""Obsession\""~/~, the effect triggers twice per turn.;
        Each turn, decreases max Unholy Resistance of Undeads and Proselytes by ~r~7%~/~ within ~w~7~/~ tiles, which persists for ~w~9~/~ turns.##This effect stacks up to ~w~9~/~ times.##If affecting by ~r~\""Obsession\""~/~, the effect triggers twice per turn.;
        "",
        ""ndarkness;
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
        Halves sanity loss of ~w~Occultism~/~ abilities and partially decreases penalties of ~r~\""Obsession\""~/~.##Grants ~lg~33%~/~ Unholy Resistance.;
        "",
        ""Pcurse;
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
        Applies the target with ~r~\""Withering Curse\""~/~ for ~w~13~/~ turns:##~r~-9%~/~ Fortitude#~r~-9%~/~ Magic Resistance#~r~-7%~/~ Nature Resistance#~r~-6%~/~ Max Health#~r~+4%~/~ Damage Taken##Each turn worsens the Condition of a random body part by ~r~0.5%~/~ per each stack.##Hitting the target by ~lg~\""Desecration\""~/~ or the the repeated use of the spell against the same target applies an extra stack of the effect (up to ~w~III~/~).;
        "",
        ""Bw_Bless;
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
        Replenishes ~lg~/*H_P*/%~/~ Max Health to the target and improves the condition of bodyparts by ~lg~33%~/~ of the amount of health replenished.##This effect is ~lg~50%~/~ more effective on allied Undeads.##grants the target ~lg~\""Death's Blessing\""~/~ for ~w~13~/~ turns:##~lg~+9%~/~ Life Drain#~lg~+9%~/~ Energy Drain#~lg~+13%~/~ Damage Reflection;
        "",
        ""Bw_Bolt;
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
        Shoots a bolt of dark energy, dealing ~ur~/*Unholy_Damage*/ Unholy Damage~/~ with ~w~/*Hit_Chance*/%~/~ Accuracy.##If the spell hits the target, burns its Energy for the amount of damage dealt and replenishes the same amount of Energy to the caster.##Grants ~ur~/*Unholy_Damage2*/ Unholy Damage~/~ for ~w~12~/~ turns.##This effect doesn't stack.;
        "",
        ""Bw_Resurrection;
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
        Reanimates a targeted corpse, replenishing it ~lg~66%~/~ Max Health and ~bl~66%~/~ Max Energy and sets Armor Durability to ~w~0%~/~.##Increases ~lg~morale~/~ (up to ~w~75%~/~).#Slowly decreases ~lg~Sanity~/~ but no less than ~r~60%~/~.##Risk of ~r~\""Obsession\""~/~: ~ur~High~/~#Summoning more than one Undead instantly causes ~r~\""Obsession\""~/~.##~r~Can't~/~ summon Undeads higher than level ~w~/*LEVL*/~/~.##~r~Prevents~/~ from receiving ~ly~\""Blessing\""~/~.##This spell cannot be cast while under the effect of ~r~\""Obsession\""~/~.;
        "",
        ""Bw_Touch;
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
        Deals ~ur~/*Unholy_Damage*/ Unholy Damage~/~ wtih ~lg~/*I_C*/%~/~ Immobilization Chance.##Replenishes Health to all allies within Vision for ~lg~66%~/~ of the damage dealt by the spell.;
        "",
        ""Wraith_Binding;
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
        Summons a ~w~Wraith~/~ on the targeted tile. The ~w~Wraith's~/~ power depends on the number of ~lg~\""Essence Charge\""~/~ stacks.##Using the ability removes ~lg~\""Essence Charge\""~/~.##If there was no weapon equipped: grants the skill ~lg~-50%~/~ Cooldown Duration and ~lg~Halves~/~ Miscast Chance.##Risk of ~r~\""Obsession\""~/~: ~r~Extremely High~/~#Summoning more than one Wraith instantly causes ~r~\""Obsession\""~/~.##~r~Can't~/~ summon Wraiths higher than level ~w~/*LEVL*/~/~.##This spell cannot be cast while under the effect of ~r~\""Obsession\""~/~.;
        "",";
  
        foreach(string item in input)
        {
            if (item.Contains("\";skill_name_end") && item.Contains(undead))
            {
                string newItem = item;
                newItem = newItem.Insert(newItem.IndexOf("\";skill_name_end"), skills);
                newItem = newItem.Insert(newItem.IndexOf(undead) + undead.Length, skillsDesc.Replace('\n', ' '));
                newItem = newItem.Insert(newItem.IndexOf(@"##Произнесение заклинаний ~lb~искусства магии"), sealofpower_en);
                newItem = newItem.Insert(newItem.IndexOf(@"##Casting ~lb~Magic Mastery"), sealofpower_en);
                newItem = newItem.Insert(newItem.IndexOf(@"##催动~lb~“驭法”"), sealofpower_en);
                newItem = newItem.Insert(newItem.IndexOf(@"##Das Wirken von ~lb~Zauberkunst~/~"), sealofpower_en);
                // TODO 8 languages are still missing
                yield return newItem;
            }
            else
            {
                yield return item;
            }
        }
    }
}
