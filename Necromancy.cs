﻿// Copyright (C)
// See LICENSE file for extended copyright information.
// This file is part of the repository from .

using ModShardLauncher;
using ModShardLauncher.Mods;
using UndertaleModLib.Models;

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
    public override string Description => "Raise the deads and curse enemies. Shall you go insane in the process ?";
    public override string Version => "1.0.2";
    public override string TargetVersion => "0.8.2.10";
    public override void PatchMod()
    {
        // sprites
        Msl.GetSprite("s_bwdis").OriginX = 340;
        Msl.GetSprite("s_bwdis").OriginY = 275;
        Msl.GetSprite("s_nmancy_reworked").OriginX = 0;
        Msl.GetSprite("s_nmancy_reworked").OriginY = 0;
        Msl.GetSprite("s_fleshpile_rotten").OriginX = 68;
        Msl.GetSprite("s_fleshpile_rotten").OriginY = 54;
        Msl.GetSprite("s_bandit_arbalester_z").OriginX = 36;
        Msl.GetSprite("s_bandit_arbalester_z").OriginY = 43;
        Msl.GetSprite("s_bandit_crook_z").OriginX = 36;
        Msl.GetSprite("s_bandit_crook_z").OriginY = 43;
        Msl.GetSprite("s_bandit_cutthroat_z").OriginX = 36;
        Msl.GetSprite("s_bandit_cutthroat_z").OriginY = 43;
        Msl.GetSprite("s_bandit_elite_dog_z").OriginX = 40;
        Msl.GetSprite("s_bandit_elite_dog_z").OriginY = 41;
        Msl.GetSprite("s_bandit_freak_z").OriginX = 36;
        Msl.GetSprite("s_bandit_freak_z").OriginY = 43;
        Msl.GetSprite("s_bandit_goon_cleaver_z").OriginX = 36;
        Msl.GetSprite("s_bandit_goon_cleaver_z").OriginY = 43;
        Msl.GetSprite("s_bandit_goon_club_z").OriginX = 36;
        Msl.GetSprite("s_bandit_goon_club_z").OriginY = 43;
        Msl.GetSprite("s_proselyte_outcast_z").OriginX = 37;
        Msl.GetSprite("s_proselyte_outcast_z").OriginY = 32;
        Msl.GetSprite("s_bandit_halberdier_z").OriginX = 36;
        Msl.GetSprite("s_bandit_halberdier_z").OriginY = 43;
        Msl.GetSprite("s_wolf_undead_dead_rotten").OriginX = 11;
        Msl.GetSprite("s_wolf_undead_dead_rotten").OriginY = 1;
        Msl.GetSprite("s_bandit_henchman_axe_z").OriginX = 36;
        Msl.GetSprite("s_bandit_henchman_axe_z").OriginY = 43;
        Msl.GetSprite("s_bandit_kingpin_z").OriginX = 36;
        Msl.GetSprite("s_bandit_kingpin_z").OriginY = 43;
        Msl.GetSprite("s_dark_lore").OriginX = 12;
        Msl.GetSprite("s_dark_lore").OriginY = 12;
        Msl.GetSprite("s_bandit_mancatcher_z").OriginX = 36;
        Msl.GetSprite("s_bandit_mancatcher_z").OriginY = 43;
        Msl.GetSprite("s_bandit_marauder_axe_z").OriginX = 36;
        Msl.GetSprite("s_bandit_marauder_axe_z").OriginY = 43;
        Msl.GetSprite("s_golun_undead").OriginX = 36;
        Msl.GetSprite("s_golun_undead").OriginY = 35;
        Msl.GetSprite("s_bandit_marauder_mace_z").OriginX = 36;
        Msl.GetSprite("s_bandit_marauder_mace_z").OriginY = 43;
        Msl.GetSprite("s_bandit_marauder_sword_z").OriginX = 36;
        Msl.GetSprite("s_bandit_marauder_sword_z").OriginY = 43;
        Msl.GetSprite("s_bandit_outlaw_z").OriginX = 36;
        Msl.GetSprite("s_bandit_outlaw_z").OriginY = 43;
        Msl.GetSprite("s_bandit_poacher_z").OriginX = 36;
        Msl.GetSprite("s_bandit_poacher_z").OriginY = 43;
        Msl.GetSprite("s_b_winks").OriginX = 12;
        Msl.GetSprite("s_b_winks").OriginY = 12;
        Msl.GetSprite("s_bandit_renegade_axe_z").OriginX = 36;
        Msl.GetSprite("s_bandit_renegade_axe_z").OriginY = 43;
        Msl.GetSprite("s_bandit_renegade_mace_z").OriginX = 36;
        Msl.GetSprite("s_bandit_renegade_mace_z").OriginY = 43;
        Msl.GetSprite("s_bandit_renegade_sword_z").OriginX = 36;
        Msl.GetSprite("s_bandit_renegade_sword_z").OriginY = 43;
        Msl.GetSprite("s_bandit_renegade_z").OriginX = 36;
        Msl.GetSprite("s_bandit_renegade_z").OriginY = 43;
        Msl.GetSprite("s_bandit_rioter_z").OriginX = 36;
        Msl.GetSprite("s_bandit_rioter_z").OriginY = 43;
        Msl.GetSprite("s_bandit_rogue_mage_z").OriginX = 36;
        Msl.GetSprite("s_bandit_rogue_mage_z").OriginY = 43;
        Msl.GetSprite("s_bandit_sidekick_mace_z").OriginX = 36;
        Msl.GetSprite("s_bandit_sidekick_mace_z").OriginY = 43;
        Msl.GetSprite("s_unholy_bles").OriginX = 12;
        Msl.GetSprite("s_unholy_bles").OriginY = 12;
        Msl.GetSprite("s_bandit_soldier_axe_z").OriginX = 36;
        Msl.GetSprite("s_bandit_soldier_axe_z").OriginY = 43;
        Msl.GetSprite("s_bandit_soldier_mace_z").OriginX = 36;
        Msl.GetSprite("s_bandit_soldier_mace_z").OriginY = 43;
        Msl.GetSprite("s_bandit_soldier_sword_z").OriginX = 36;
        Msl.GetSprite("s_bandit_soldier_sword_z").OriginY = 43;
        Msl.GetSprite("s_bandit_thug_club_z").OriginX = 36;
        Msl.GetSprite("s_bandit_thug_club_z").OriginY = 43;
        Msl.GetSprite("s_bandit_trasher_axe_z").OriginX = 36;
        Msl.GetSprite("s_bandit_trasher_axe_z").OriginY = 43;
        Msl.GetSprite("s_bandit_trasher_sword_z").OriginX = 36;
        Msl.GetSprite("s_bandit_trasher_sword_z").OriginY = 43;
        Msl.GetSprite("s_bandit_trasher_z").OriginX = 36;
        Msl.GetSprite("s_bandit_trasher_z").OriginY = 43;
        Msl.GetSprite("s_bandit_warlock_z").OriginX = 36;
        Msl.GetSprite("s_bandit_warlock_z").OriginY = 43;
        Msl.GetSprite("s_darkbolt_icon_off").OriginX = 12;
        Msl.GetSprite("s_darkbolt_icon_off").OriginY = 12;
        Msl.GetSprite("s_necromancer_boss_staff_z").OriginX = 36;
        Msl.GetSprite("s_necromancer_boss_staff_z").OriginY = 43;
        Msl.GetSprite("s_bison_undead_dead_rotten").OriginX = 38;
        Msl.GetSprite("s_bison_undead_dead_rotten").OriginY = 34;

        UndertaleSprite s_charming = Msl.GetSprite("s_charming");
        s_charming.OriginX = 32;
        s_charming.OriginY = 59;
        s_charming.IsSpecialType = true;
        s_charming.GMS2PlaybackSpeedType = AnimSpeedType.FramesPerGameFrame;
        s_charming.GMS2PlaybackSpeed = 0.3f;

        Msl.GetSprite("s_bison_undead").OriginX = 36;
        Msl.GetSprite("s_bison_undead").OriginY = 39;
        Msl.GetSprite("s_proselyte_anmara_z").OriginX = 30;
        Msl.GetSprite("s_proselyte_anmara_z").OriginY = 47;
        Msl.GetSprite("s_bear_undead").OriginX = 36;
        Msl.GetSprite("s_bear_undead").OriginY = 34;
        Msl.GetSprite("s_proselyte_adept_z").OriginX = 27;
        Msl.GetSprite("s_proselyte_adept_z").OriginY = 41;
        Msl.GetSprite("s_proselyte_champion_z").OriginX = 28;
        Msl.GetSprite("s_proselyte_champion_z").OriginY = 41;
        Msl.GetSprite("s_darkness_sign_off").OriginX = 12;
        Msl.GetSprite("s_darkness_sign_off").OriginY = 12;
        Msl.GetSprite("s_golun_undead_dead_rotten").OriginX = 21;
        Msl.GetSprite("s_golun_undead_dead_rotten").OriginY = 18;
        Msl.GetSprite("s_proselyte_flagellant_z").OriginX = 27;
        Msl.GetSprite("s_proselyte_flagellant_z").OriginY = 41;
        Msl.GetSprite("s_proselyte_hierarch_z").OriginX = 28;
        Msl.GetSprite("s_proselyte_hierarch_z").OriginY = 41;
        Msl.GetSprite("s_proselyte_immolated_z").OriginX = 28;
        Msl.GetSprite("s_proselyte_immolated_z").OriginY = 41;
        Msl.GetSprite("s_proselyte_toller_z").OriginX = 27;
        Msl.GetSprite("s_proselyte_toller_z").OriginY = 41;
        Msl.GetSprite("s_proselyte_tormentor_z").OriginX = 28;
        Msl.GetSprite("s_proselyte_tormentor_z").OriginY = 41;
        Msl.GetSprite("s_painful_curse_off").OriginX = 12;
        Msl.GetSprite("s_painful_curse_off").OriginY = 12;
        Msl.GetSprite("s_bandit_dog_z").OriginX = 41;
        Msl.GetSprite("s_bandit_dog_z").OriginY = 24;
        Msl.GetSprite("s_proselyte_apostate_z").OriginX = 27;
        Msl.GetSprite("s_proselyte_apostate_z").OriginY = 47;
        Msl.GetSprite("s_smalltroll_dead_rotten").OriginX = 38;
        Msl.GetSprite("s_smalltroll_dead_rotten").OriginY = 22;
        Msl.GetSprite("s_proselyte_harbinger_z").OriginX = 27;
        Msl.GetSprite("s_proselyte_harbinger_z").OriginY = 38;

        UndertaleSprite s_teal_curse = Msl.GetSprite("s_teal_curse");
        s_teal_curse.OriginX = 20;
        s_teal_curse.OriginY = 61;
        s_teal_curse.IsSpecialType = true;
        s_teal_curse.GMS2PlaybackSpeedType = AnimSpeedType.FramesPerGameFrame;
        s_teal_curse.GMS2PlaybackSpeed = 0.4f;

        Msl.GetSprite("s_boar_undead").OriginX = 31;
        Msl.GetSprite("s_boar_undead").OriginY = 25;
        Msl.GetSprite("s_skill_death_blesss_off").OriginX = 12;
        Msl.GetSprite("s_skill_death_blesss_off").OriginY = 12;
        Msl.GetSprite("s_bear_undead_dead_rotten").OriginX = 26;
        Msl.GetSprite("s_bear_undead_dead_rotten").OriginY = 16;
        Msl.GetSprite("s_teal_ball").OriginX = 17;
        Msl.GetSprite("s_teal_ball").OriginY = 12;
        Msl.GetSprite("s_moose_undead").OriginX = 47;
        Msl.GetSprite("s_moose_undead").OriginY = 55;
        Msl.GetSprite("s_harpy_undead_dead_rotten").OriginX = 26;
        Msl.GetSprite("s_harpy_undead_dead_rotten").OriginY = 20;
        Msl.GetSprite("s_soul_sacri_off").OriginX = 12;
        Msl.GetSprite("s_soul_sacri_off").OriginY = 12;
        Msl.GetSprite("s_touch_of_death_off").OriginX = 12;
        Msl.GetSprite("s_touch_of_death_off").OriginY = 12;
        Msl.GetSprite("s_undying_disaster_off").OriginX = 12;
        Msl.GetSprite("s_undying_disaster_off").OriginY = 12;
        Msl.GetSprite("s_ghoul_large_z").OriginX = 38;
        Msl.GetSprite("s_ghoul_large_z").OriginY = 35;
        Msl.GetSprite("s_ghoul_medium_z").OriginX = 38;
        Msl.GetSprite("s_ghoul_medium_z").OriginY = 35;
        Msl.GetSprite("s_ghoul_small_z").OriginX = 38;
        Msl.GetSprite("s_ghoul_small_z").OriginY = 35;
        Msl.GetSprite("s_crawler_undead").OriginX = 25;
        Msl.GetSprite("s_crawler_undead").OriginY = 22;
        Msl.GetSprite("s_unholy_bles_off").OriginX = 12;
        Msl.GetSprite("s_unholy_bles_off").OriginY = 12;
        Msl.GetSprite("s_harpy_undead").OriginX = 30;
        Msl.GetSprite("s_harpy_undead").OriginY = 36;
        Msl.GetSprite("s_boar_undead_dead_rotten").OriginX = 17;
        Msl.GetSprite("s_boar_undead_dead_rotten").OriginY = 13;
        Msl.GetSprite("s_moose_undead_dead_rotten").OriginX = 38;
        Msl.GetSprite("s_moose_undead_dead_rotten").OriginY = 41;
        Msl.GetSprite("s_necromancer_boss_z").OriginX = 29;
        Msl.GetSprite("s_necromancer_boss_z").OriginY = 35;
        Msl.GetSprite("s_proselyte_anmarak_z").OriginX = 26;
        Msl.GetSprite("s_proselyte_anmarak_z").OriginY = 41;
        Msl.GetSprite("s_proselyte_matriarch_z").OriginX = 26;
        Msl.GetSprite("s_proselyte_matriarch_z").OriginY = 42;
        Msl.GetSprite("s_wolf_undead").OriginX = 29;
        Msl.GetSprite("s_wolf_undead").OriginY = 27;
        Msl.GetSprite("s_bandit_banneret_z").OriginX = 22;
        Msl.GetSprite("s_bandit_banneret_z").OriginY = 41;
        Msl.GetSprite("s_bandit_bonebreaker_axe_z").OriginX = 20;
        Msl.GetSprite("s_bandit_bonebreaker_axe_z").OriginY = 41;
        Msl.GetSprite("s_buff_cursse").OriginX = 12;
        Msl.GetSprite("s_buff_cursse").OriginY = 12;
        Msl.GetSprite("s_unholy_resurrection_off").OriginX = 12;
        Msl.GetSprite("s_unholy_resurrection_off").OriginY = 12;
        Msl.GetSprite("s_bandit_bonebreaker_mace_z").OriginX = 20;
        Msl.GetSprite("s_bandit_bonebreaker_mace_z").OriginY = 41;
        Msl.GetSprite("s_teal_ball_cast").OriginX = 31;
        Msl.GetSprite("s_teal_ball_cast").OriginY = 20;
        Msl.GetSprite("s_bandit_conjurer_z").OriginX = 26;
        Msl.GetSprite("s_bandit_conjurer_z").OriginY = 41;
        Msl.GetSprite("s_loot_cg").OriginX = 0;
        Msl.GetSprite("s_loot_cg").OriginY = 0;
        Msl.GetSprite("s_bandit_duelist_z").OriginX = 26;
        Msl.GetSprite("s_bandit_duelist_z").OriginY = 41;
        Msl.GetSprite("s_bandit_electromancer_z").OriginX = 26;
        Msl.GetSprite("s_bandit_electromancer_z").OriginY = 41;
        Msl.GetSprite("s_bandit_geomancer_z").OriginX = 26;
        Msl.GetSprite("s_bandit_geomancer_z").OriginY = 41;
        Msl.GetSprite("s_bandit_gmdeserter_gaxe_z").OriginX = 26;
        Msl.GetSprite("s_bandit_gmdeserter_gaxe_z").OriginY = 41;
        Msl.GetSprite("s_blusss").OriginX = 12;
        Msl.GetSprite("s_blusss").OriginY = 12;
        Msl.GetSprite("s_bandit_gmdeserter_ghammer_z").OriginX = 26;
        Msl.GetSprite("s_bandit_gmdeserter_ghammer_z").OriginY = 41;
        Msl.GetSprite("s_pcurse").OriginX = 12;
        Msl.GetSprite("s_pcurse").OriginY = 12;
        Msl.GetSprite("s_bandit_gmdeserter_polearm_z").OriginX = 26;
        Msl.GetSprite("s_bandit_gmdeserter_polearm_z").OriginY = 41;
        Msl.GetSprite("s_darkbalz").OriginX = 12;
        Msl.GetSprite("s_darkbalz").OriginY = 12;
        Msl.GetSprite("s_buff_death_blesss").OriginX = 12;
        Msl.GetSprite("s_buff_death_blesss").OriginY = 12;
        Msl.GetSprite("s_dtouch").OriginX = 12;
        Msl.GetSprite("s_dtouch").OriginY = 12;
        Msl.GetSprite("s_bandit_heavyarbalester_z").OriginX = 26;
        Msl.GetSprite("s_bandit_heavyarbalester_z").OriginY = 41;

        UndertaleSprite s_curse_cast = Msl.GetSprite("s_curse_cast");
        s_curse_cast.OriginX = 17;
        s_curse_cast.OriginY = 30;
        s_curse_cast.IsSpecialType = true;
        s_curse_cast.GMS2PlaybackSpeedType = AnimSpeedType.FramesPerGameFrame;
        s_curse_cast.GMS2PlaybackSpeed = 0.4f;

        Msl.GetSprite("s_bandit_huntmaster_z").OriginX = 26;
        Msl.GetSprite("s_bandit_huntmaster_z").OriginY = 41;
        Msl.GetSprite("s_bandit_longbowman_z").OriginX = 26;
        Msl.GetSprite("s_bandit_longbowman_z").OriginY = 41;
        Msl.GetSprite("s_bandit_magehunter_z").OriginX = 26;
        Msl.GetSprite("s_bandit_magehunter_z").OriginY = 41;
        Msl.GetSprite("s_bandit_paymaster_z").OriginX = 26;
        Msl.GetSprite("s_bandit_paymaster_z").OriginY = 41;
        Msl.GetSprite("s_bandit_raubritter_2hmace_z").OriginX = 27;
        Msl.GetSprite("s_bandit_raubritter_2hmace_z").OriginY = 41;
        Msl.GetSprite("s_bandit_raubritter_2hsword_z").OriginX = 22;
        Msl.GetSprite("s_bandit_raubritter_2hsword_z").OriginY = 41;
        Msl.GetSprite("s_disasterundead").OriginX = 12;
        Msl.GetSprite("s_disasterundead").OriginY = 12;
        Msl.GetSprite("s_bandit_raubritter_flail_z").OriginX = 26;
        Msl.GetSprite("s_bandit_raubritter_flail_z").OriginY = 41;
        Msl.GetSprite("s_buff_punish").OriginX = 12;
        Msl.GetSprite("s_buff_punish").OriginY = 12;
        Msl.GetSprite("s_soulzac").OriginX = 12;
        Msl.GetSprite("s_soulzac").OriginY = 12;
        Msl.GetSprite("s_inv_cg01").OriginX = 0;
        Msl.GetSprite("s_inv_cg01").OriginY = 0;
        Msl.GetSprite("s_bandit_ringleader_2hsword_z").OriginX = 26;
        Msl.GetSprite("s_bandit_ringleader_2hsword_z").OriginY = 41;
        Msl.GetSprite("s_bandit_ringleader_shield_z").OriginX = 26;
        Msl.GetSprite("s_bandit_ringleader_shield_z").OriginY = 41;
        Msl.GetSprite("s_bandit_sergeant_axe_z").OriginX = 26;
        Msl.GetSprite("s_bandit_sergeant_axe_z").OriginY = 41;
        Msl.GetSprite("s_bandit_sergeant_gsword_z").OriginX = 26;
        Msl.GetSprite("s_bandit_sergeant_gsword_z").OriginY = 41;
        Msl.GetSprite("s_bandit_sergeant_hammer_z").OriginX = 26;
        Msl.GetSprite("s_bandit_sergeant_hammer_z").OriginY = 41;
        Msl.GetSprite("s_bandit_sergeant_mace_z").OriginX = 26;
        Msl.GetSprite("s_bandit_sergeant_mace_z").OriginY = 41;
        Msl.GetSprite("s_bandit_sergeant_sword_z").OriginX = 26;
        Msl.GetSprite("s_bandit_sergeant_sword_z").OriginY = 41;
        Msl.GetSprite("s_angel_of_death").OriginX = 12;
        Msl.GetSprite("s_angel_of_death").OriginY = 12;
        Msl.GetSprite("s_charged_z").OriginX = 12;
        Msl.GetSprite("s_charged_z").OriginY = 12;
        Msl.GetSprite("s_dark_enchant_effect").OriginX = 12;
        Msl.GetSprite("s_dark_enchant_effect").OriginY = 12;
        Msl.GetSprite("s_proselyte_wormbearer_z").OriginX = 26;
        Msl.GetSprite("s_proselyte_wormbearer_z").OriginY = 40;
        Msl.GetSprite("s_proselyte_gifted_axe_z").OriginX = 26;
        Msl.GetSprite("s_proselyte_gifted_axe_z").OriginY = 41;
        Msl.GetSprite("s_proselyte_gifted_mace_z").OriginX = 26;
        Msl.GetSprite("s_proselyte_gifted_mace_z").OriginY = 41;
        Msl.GetSprite("s_proselyte_impaler_z").OriginX = 26;
        Msl.GetSprite("s_proselyte_impaler_z").OriginY = 42;
        Msl.GetSprite("s_proselyte_murkstalker_z").OriginX = 26;
        Msl.GetSprite("s_proselyte_murkstalker_z").OriginY = 41;
        Msl.GetSprite("s_proselyte_yagram_z").OriginX = 26;
        Msl.GetSprite("s_proselyte_yagram_z").OriginY = 41;
        Msl.GetSprite("s_crazed_by_magic").OriginX = 12;
        Msl.GetSprite("s_crazed_by_magic").OriginY = 12;
        Msl.GetSprite("s_crawler_undead_dead_rotten").OriginX = 23;
        Msl.GetSprite("s_crawler_undead_dead_rotten").OriginY = 27;
        Msl.GetSprite("s_db_curse_new").OriginX = 12;
        Msl.GetSprite("s_db_curse_new").OriginY = 12;
        Msl.GetSprite("s_grim_blood").OriginX = 12;
        Msl.GetSprite("s_grim_blood").OriginY = 12;
        Msl.GetSprite("s_res_new").OriginX = 19;
        Msl.GetSprite("s_res_new").OriginY = 42;
        Msl.GetSprite("s_exception_soulus").OriginX = 12;
        Msl.GetSprite("s_exception_soulus").OriginY = 12;
        Msl.GetSprite("s_rec_resa").OriginX = 12;
        Msl.GetSprite("s_rec_resa").OriginY = 12;
        Msl.GetSprite("s_inv_cg02").OriginX = 0;
        Msl.GetSprite("s_inv_cg02").OriginY = 0;
        Msl.GetSprite("s_rec_resf").OriginX = 12;
        Msl.GetSprite("s_rec_resf").OriginY = 12;
        Msl.GetSprite("s_take_over_effect").OriginX = 12;
        Msl.GetSprite("s_take_over_effect").OriginY = 12;
        Msl.GetSprite("s_proselyte_girrud_z").OriginX = 22;
        Msl.GetSprite("s_proselyte_girrud_z").OriginY = 30;
        Msl.GetSprite("s_proselyte_abomination_z").OriginX = 18;
        Msl.GetSprite("s_proselyte_abomination_z").OriginY = 31;
        Msl.GetSprite("s_growing_madness").OriginX = 12;
        Msl.GetSprite("s_growing_madness").OriginY = 12;
        Msl.GetSprite("s_proselyte_saggul_z").OriginX = 18;
        Msl.GetSprite("s_proselyte_saggul_z").OriginY = 32;
        Msl.GetSprite("s_inv_cg03").OriginX = 0;
        Msl.GetSprite("s_inv_cg03").OriginY = 0;
        Msl.GetSprite("s_imortal_soul").OriginX = 12;
        Msl.GetSprite("s_imortal_soul").OriginY = 12;
        Msl.GetSprite("s_reaping_darkness").OriginX = 12;
        Msl.GetSprite("s_reaping_darkness").OriginY = 12;
        Msl.GetSprite("s_recurct").OriginX = 12;
        Msl.GetSprite("s_recurct").OriginY = 12;
        Msl.GetSprite("s_soul_abs").OriginX = 12;
        Msl.GetSprite("s_soul_abs").OriginY = 12;
        Msl.GetSprite("s_big_att_menu").OriginX = 0;
        Msl.GetSprite("s_big_att_menu").OriginY = 0;
        Msl.GetSprite("s_bw_attitude_attack").OriginX = 12;
        Msl.GetSprite("s_bw_attitude_attack").OriginY = 12;
        Msl.GetSprite("s_bw_attitude_follow").OriginX = 12;
        Msl.GetSprite("s_bw_attitude_follow").OriginY = 12;
        Msl.GetSprite("s_proselyte_brander_z").OriginX = 29;
        Msl.GetSprite("s_proselyte_brander_z").OriginY = 44;
        Msl.GetSprite("s_proselyte_juggernaut_z").OriginX = 26;
        Msl.GetSprite("s_proselyte_juggernaut_z").OriginY = 44;
        Msl.GetSprite("s_wraithbind").OriginX = 12;
        Msl.GetSprite("s_wraithbind").OriginY = 12;
        Msl.GetSprite("s_b_sealofpower_unholy").OriginX = 12;
        Msl.GetSprite("s_b_sealofpower_unholy").OriginY = 12;
        Msl.GetSprite("s_bw_void").OriginX = 12;
        Msl.GetSprite("s_bw_void").OriginY = 12;
        Msl.GetSprite("s_rec_rese").OriginX = 12;
        Msl.GetSprite("s_rec_rese").OriginY = 12;
        Msl.GetSprite("s_rec_resep").OriginX = 12;
        Msl.GetSprite("s_rec_resep").OriginY = 12;
        Msl.GetSprite("s_inv_SkullMorionRing").OriginX = 0;
        Msl.GetSprite("s_inv_SkullMorionRing").OriginY = 0;
        Msl.GetSprite("s_loot_SkullMorionRing").OriginX = 0;
        Msl.GetSprite("s_loot_SkullMorionRing").OriginY = 0;
        Msl.GetSprite("s_inv_hexermantle").OriginX = 0;
        Msl.GetSprite("s_inv_hexermantle").OriginY = 0;
        Msl.GetSprite("s_inv_sinistercrown").OriginX = 0;
        Msl.GetSprite("s_inv_sinistercrown").OriginY = 0;
        Msl.GetSprite("s_char3_hexermantle").OriginX = 0;
        Msl.GetSprite("s_char3_hexermantle").OriginY = 0;
        Msl.GetSprite("s_char3_hexermantle_female").OriginX = 0;
        Msl.GetSprite("s_char3_hexermantle_female").OriginY = 0;
        Msl.GetSprite("s_char_hexermantle").OriginX = 0;
        Msl.GetSprite("s_char_hexermantle").OriginY = 0;
        Msl.GetSprite("s_loot_sinistercrown").OriginX = 0;
        Msl.GetSprite("s_loot_sinistercrown").OriginY = 0;
        Msl.GetSprite("s_corpse_hexermantle").OriginX = 0;
        Msl.GetSprite("s_corpse_hexermantle").OriginY = 0;
        Msl.GetSprite("s_char_hexermantle_female").OriginX = 0;
        Msl.GetSprite("s_char_hexermantle_female").OriginY = 0;
        Msl.GetSprite("s_char3_sinistercrown_Arna").OriginX = 0;
        Msl.GetSprite("s_char3_sinistercrown_Arna").OriginY = 0;
        Msl.GetSprite("s_loot_hexermantle").OriginX = 0;
        Msl.GetSprite("s_loot_hexermantle").OriginY = 0;
        Msl.GetSprite("s_char3_sinistercrown_Dirwin").OriginX = 0;
        Msl.GetSprite("s_char3_sinistercrown_Dirwin").OriginY = 0;
        Msl.GetSprite("s_char3_sinistercrown_Jonna").OriginX = 0;
        Msl.GetSprite("s_char3_sinistercrown_Jonna").OriginY = 0;
        Msl.GetSprite("s_char3_sinistercrown_Jorgrim").OriginX = 0;
        Msl.GetSprite("s_char3_sinistercrown_Jorgrim").OriginY = 0;
        Msl.GetSprite("s_char3_sinistercrown_Velmir").OriginX = 0;
        Msl.GetSprite("s_char3_sinistercrown_Velmir").OriginY = 0;
        Msl.GetSprite("s_char_sinistercrown").OriginX = 0;
        Msl.GetSprite("s_char_sinistercrown").OriginY = 0;
        Msl.GetSprite("s_char_sinistercrown_Arna").OriginX = 0;
        Msl.GetSprite("s_char_sinistercrown_Arna").OriginY = 0;
        Msl.GetSprite("s_char_sinistercrown_Dirwin").OriginX = 0;
        Msl.GetSprite("s_char_sinistercrown_Dirwin").OriginY = 0;
        Msl.GetSprite("s_char_sinistercrown_Jonna").OriginX = 0;
        Msl.GetSprite("s_char_sinistercrown_Jonna").OriginY = 0;
        Msl.GetSprite("s_char_sinistercrown_Velmir").OriginX = 0;
        Msl.GetSprite("s_char_sinistercrown_Velmir").OriginY = 0;

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
            new MslEvent("gml_Object_o_b_servemaster_Mouse_53.gml", EventType.Mouse, 53),
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
            .MatchFrom("gain_xp = scr_GetMobParametr(\"XP\")")
            .ReplaceBy("if (_zompass || instance_exists(o_res_buff_creator))\n{gain_xp = 1}\nelse{gain_xp = scr_GetMobParametr(\"XP\")}")
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

        Msl.LoadGML("gml_Object_o_attitudes_menu_Other_11")
            .MatchFrom("scr_guiLayoutOffsetUpdate")
            .ReplaceBy("scr_guiLayoutOffsetUpdate(id, 512, -82)")
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
            .MatchFrom("scr_guiAnimation_ext(x, y, s_sealofpower_geo)")
            .ReplaceBy(@"{
with (scr_guiAnimation_ext(x, y, s_sealofpower_geo))
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

        Msl.LoadGML("gml_Object_o_b_seals_magic_Alarm_3")
            .MatchFrom("unholy")
            .ReplaceBy("else if ((magic_school == \"necromancy\"))")
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
        
        Msl.LoadGML("gml_Object_o_enemy_birth_Create_0")
            .MatchAll()
            .InsertBelow("is_special = 0")
            .Save();

        Msl.LoadGML("gml_Object_o_enemy_birth_Other_7")
            .MatchFrom("with (scr_enemy_create(x, ")
            .InsertAbove(@"if is_special
{
instance_create(x, y, o_res_buff_creator)
with (scr_enemy_create(x, y, o_bw_zombie, is_cheack))
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
        
        // room
        UndertaleRoom disclaimerRoom = Msl.AddRoom("r_bw_disclaimer", 683, 483);
        UndertaleRoom.Layer layerInstance = disclaimerRoom.AddLayerInstance("NewInstancesLayer");
        disclaimerRoom.AddLayerBackground("NewBackgroundLayer");
        
        UndertaleRoom.GameObject overlay = disclaimerRoom.AddGameObject(layerInstance, "o_init_overlay");
        disclaimerRoom.AddGameObject(layerInstance, "o_BwMark");
        disclaimerRoom.AddGameObject(layerInstance, "o_disclaimer03");

        Msl.AddCustomDisclaimerRoom("r_bw_disclaimer", overlay);

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

        // stat tables
        Msl.LoadGML("gml_GlobalScript_table_armor")
            .Apply(ArmorIterator)
            .Save();

        Msl.LoadGML("gml_GlobalScript_table_skills_stat")
            .Apply(SkillsStatIterator)
            .Save();

        // localization tables
        Necromancy_Localization.BooksPatching();
        Necromancy_Localization.ModifierPatching();
        Necromancy_Localization.WeaponTextsPatching();
        Necromancy_Localization.TextTreesPatching();
        Necromancy_Localization.TextRaritysPatching();
        Necromancy_Localization.SpeechPatching();
        Necromancy_Localization.SkillsPatching();
        Necromancy_Localization.SealOfPowerUpdate();
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
