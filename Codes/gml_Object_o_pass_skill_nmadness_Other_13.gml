event_inherited()
if is_open
{
    var _skill_array = -4
    with (o_enemy)
    {
        if scr_instance_exists_in_list(o_b_servemaster)
        {
            if (object_index == o_bandit_rioter)
                _skill_array = ["Necromancy", o_skill_piercing_lunge_ico]
            if (object_index == o_bandit_trasher)
                _skill_array = ["Necromancy", o_skill_power_kick_ico, o_skill_mighty_swing_ico]
            if (object_index == o_bandit_trasher_axe)
                _skill_array = ["Necromancy", o_skill_power_kick_ico, o_skill_wide_cut_ico]
            if (object_index == o_bandit_trasher_sword)
                _skill_array = ["Necromancy", o_skill_power_kick_ico, o_skill_feint_swing_ico]
            if (object_index == o_bandit_poacher)
                _skill_array = ["Necromancy", o_skill_taking_aim_ico]
            if (object_index == o_bandit_henchman_axe)
                _skill_array = ["Necromancy", o_skill_cut_through_ico, o_skill_raise_shield_ico, o_skill_dash_ico]
            if (object_index == o_bandit_sidekick_mace)
                _skill_array = ["Necromancy", o_skill_onslaught_ico, o_skill_raise_shield_ico, o_skill_dash_ico]
            if (object_index == o_bandit_mancatcher)
                _skill_array = ["Necromancy", o_skill_dash_ico, o_skill_nail_down_ico, o_skill_seize_the_initiative_ico]
            if (object_index == o_bandit_renegade)
                _skill_array = ["Necromancy", o_skill_piercing_lunge_ico, o_skill_nail_down_ico]
            if (object_index == o_bandit_renegade_sword)
                _skill_array = ["Necromancy", o_skill_feint_swing_ico, o_skill_seize_the_initiative_ico]
            if (object_index == o_bandit_renegade_axe)
                _skill_array = ["Necromancy", o_skill_reign_in_blood_ico, o_skill_wide_cut_ico]
            if (object_index == o_bandit_renegade_mace)
                _skill_array = ["Necromancy", o_skill_unstoppable_force_ico, o_skill_mighty_swing_ico]
            if (object_index == o_bandit_crook)
                _skill_array = ["Necromancy", o_skill_double_jab_ico, o_skill_deadly_trick_ico, o_skill_dash_ico, o_skill_seize_the_initiative_ico]
            if (object_index == o_bandit_rogue_mage)
                _skill_array = ["Necromancy", o_skill_seal_of_power_ico, o_skill_fire_barrage_ico, o_skill_discharge_ico]
            if (object_index == o_bandit_outlaw)
                _skill_array = ["Necromancy", o_skill_taking_aim_ico, o_skill_long_range_shot_ico]
            if (object_index == o_bandit_marauder_axe)
                _skill_array = ["Necromancy", o_skill_dismember_ico, o_skill_wide_cut_ico, o_skill_reign_in_blood_ico]
            if (object_index == o_bandit_marauder_sword)
                _skill_array = ["Necromancy", o_skill_power_kick_ico, o_skill_feint_swing_ico, o_skill_heroic_charge_ico]
            if (object_index == o_bandit_marauder_mace)
                _skill_array = ["Necromancy", o_skill_unstoppable_force_ico, o_skill_mighty_swing_ico, o_skill_skull_crusher_ico]
            if (object_index == o_bandit_soldier_sword)
                _skill_array = ["Necromancy", o_skill_raise_shield_ico, o_skill_dash_ico, o_skill_ram_ico, o_skill_advance_ico]
            if (object_index == o_bandit_soldier_axe)
                _skill_array = ["Necromancy", o_skill_raise_shield_ico, o_skill_dash_ico, o_skill_cut_through_ico, o_skill_crippling_lunge_ico]
            if (object_index == o_bandit_soldier_mace)
                _skill_array = ["Necromancy", o_skill_raise_shield_ico, o_skill_dash_ico, o_skill_armor_break_ico, o_skill_onslaught_ico]
            if (object_index == o_bandit_cutthroat)
                _skill_array = ["Necromancy", o_skill_double_jab_ico, o_skill_deadly_trick_ico, o_skill_dash_ico, o_skill_seize_the_initiative_ico, o_skill_painful_stabs_ico, o_skill_elusiveness_ico]
            if (object_index == o_bandit_arbalester)
                _skill_array = ["Necromancy", o_skill_taking_aim_ico, o_skill_suppression_ico]
            if (object_index == o_bandit_halberdier)
                _skill_array = ["Necromancy", o_skill_nail_down_ico, o_skill_regroup_ico, o_skill_pikemans_stance_ico, o_skill_active_defence_ico]
            if (object_index == o_bandit_conjurer)
                _skill_array = ["Necromancy", o_skill_fire_barrage_ico, o_skill_flame_wave_ico, o_skill_flame_ring_ico, o_skill_magma_rain_ico, o_skill_melting_ray_ico]
            if (object_index == o_bandit_geomancer)
                _skill_array = ["Necromancy", o_skill_runic_boulder_ico, o_skill_stone_spikes_ico, o_skill_step_aside_ico, o_skill_boulder_toss_ico, o_skill_stone_armor_ico]
            if (object_index == o_bandit_electromancer)
                _skill_array = ["Necromancy", o_skill_tempest_ico, o_skill_discharge_ico, o_skill_chain_lightning_ico, o_skill_short_circuit_ico, o_skill_impulse_ico]
            if (object_index == o_bandit_sergeant_hammer)
                _skill_array = ["Necromancy", o_skill_mighty_swing_ico, o_skill_unstoppable_force_ico, o_skill_skull_crusher_ico, o_skill_mayhem_ico, o_skill_power_kick_ico]
            if (object_index == o_bandit_sergeant_sword)
                _skill_array = ["Necromancy", o_skill_advance_ico, o_skill_cleave_ico, o_skill_fencer_stance_ico, o_skill_sudden_strike_ico, o_skill_brace_for_impact_ico]
            if (object_index == o_bandit_sergeant_axe)
                _skill_array = ["Necromancy", o_skill_wide_cut_ico, o_skill_dismember_ico, o_skill_reign_in_blood_ico, o_skill_rampage_ico]
            if (object_index == o_bandit_sergeant_gsword)
                _skill_array = ["Necromancy", o_skill_feint_swing_ico, o_skill_heroic_charge_ico, o_skill_seize_the_initiative_ico, o_skill_steel_feast_ico, o_skill_riposte_ico]
            if (object_index == o_bandit_sergeant_mace)
                _skill_array = ["Necromancy", o_skill_knockout_ico, o_skill_hammer_and_anvil_ico, o_skill_brace_for_impact_ico, o_skill_active_defence_ico]
            if (object_index == o_bandit_longbowman)
                _skill_array = ["Necromancy", o_skill_taking_aim_ico, o_skill_headshot_ico, o_skill_long_range_shot_ico, o_skill_suppression_ico]
            if (object_index == o_bandit_duelist)
                _skill_array = ["Necromancy", o_skill_double_jab_ico, o_skill_advance_ico, o_skill_gaping_wound_ico, o_skill_coup_de_grace_ico, o_skill_seize_the_initiative_ico, o_skill_dash_ico]
            if (object_index == o_bandit_gmdeserter_polearm)
                _skill_array = ["Necromancy", o_skill_piercing_lunge_ico, o_skill_nail_down_ico, o_skill_battering_ram_ico, o_skill_seize_the_initiative_ico, o_skill_active_defence_ico, o_skill_sudden_strike_ico, o_skill_regroup_ico, o_skill_pikemans_stance_ico]
            if (object_index == o_bandit_gmdeserter_gaxe)
                _skill_array = ["Necromancy", o_skill_battering_ram_ico, o_skill_seize_the_initiative_ico, o_skill_active_defence_ico, o_skill_sudden_strike_ico, o_skill_wide_cut_ico, o_skill_dismember_ico, o_skill_reign_in_blood_ico, o_skill_rampage_ico]
            if (object_index == o_bandit_gmdeserter_ghammer)
                _skill_array = ["Necromancy", o_skill_battering_ram_ico, o_skill_seize_the_initiative_ico, o_skill_active_defence_ico, o_skill_sudden_strike_ico, o_skill_mighty_swing_ico, o_skill_unstoppable_force_ico, o_skill_mayhem_ico, o_skill_skull_crusher_ico]
            if (object_index == o_bandit_magehunter)
                _skill_array = ["Necromancy", o_skill_advance_ico, o_skill_seal_of_shackles_ico, o_skill_seal_of_reflection_ico, o_skill_sudden_strike_ico, o_skill_adrenaline_rush_ico]
            if (object_index == o_bandit_heavyarbalester)
                _skill_array = ["Necromancy", o_skill_taking_aim_ico, o_skill_seize_the_initiative_ico, o_skill_suppression_ico]
            if (object_index == o_bandit_banneret)
                _skill_array = ["Necromancy", o_skill_piercing_lunge_ico, o_skill_nail_down_ico, o_skill_pikemans_stance]
            if (object_index == o_bandit_kingpin)
                _skill_array = ["Necromancy", o_skill_power_kick_ico, o_skill_armor_break_ico, o_skill_onslaught_ico]
            if (object_index == o_bandit_freak)
                _skill_array = ["Necromancy", o_skill_double_jab_ico, o_skill_series_of_strikes_ico, o_skill_sudden_strike_ico, o_skill_gaping_wound_ico]
            if (object_index == o_bandit_warlock)
                _skill_array = ["Necromancy", o_skill_hail_of_blows_ico, o_skill_fire_barrage_ico, o_skill_seal_of_power_ico, o_skill_magma_rain_ico, o_skill_discharge_ico, o_skill_chain_lightning_ico]
            if (object_index == o_bandit_bonebreaker_axe)
                _skill_array = ["Necromancy", o_skill_battering_ram_ico, o_skill_dismember_ico, o_skill_wide_cut_ico, o_skill_reign_in_blood_ico, o_skill_power_kick_ico]
            if (object_index == o_bandit_bonebreaker_mace)
                _skill_array = ["Necromancy", o_skill_battering_ram_ico, o_skill_unstoppable_force_ico, o_skill_mighty_swing_ico, o_skill_skull_crusher_ico, o_skill_power_kick_ico]
            if (object_index == o_bandit_huntmaster)
                _skill_array = ["Necromancy", o_skill_hunters_mark_ico, o_skill_taking_aim_ico, o_skill_headshot_ico, o_skill_suppression_ico]
            if (object_index == o_bandit_ringleader_shield)
                _skill_array = ["Necromancy", o_skill_raise_shield_ico, o_skill_ram_ico, o_skill_advance_ico, o_skill_defensive_stance_ico, o_skill_brace_for_impact_ico, o_skill_against_the_odds_ico]
            if (object_index == o_bandit_ringleader_2hsword)
                _skill_array = ["Necromancy", o_skill_feint_swing_ico, o_skill_heroic_charge_ico, o_skill_seize_the_initiative_ico, o_skill_steel_feast_ico, o_skill_riposte_ico, o_skill_active_defence_ico, o_skill_arc_cleave_ico]
            if (object_index == o_bandit_paymaster)
                _skill_array = ["Necromancy", o_skill_feint_swing_ico, o_skill_heroic_charge_ico, o_skill_seize_the_initiative_ico, o_skill_riposte_ico, o_skill_thirst_for_battle_ico, o_skill_elusiveness_ico]
            if (object_index == o_bandit_raubritter_2hsword)
                _skill_array = ["Necromancy", o_skill_heroic_charge_ico, o_skill_feint_swing_ico, o_skill_arc_cleave_ico, o_skill_riposte_ico, o_skill_thirst_for_battle_ico, o_skill_unyielding_defence_ico, o_skill_seize_the_initiative_ico, o_skill_battering_ram_ico]
            if (object_index == o_bandit_raubritter_2hmace)
                _skill_array = ["Necromancy", o_skill_unstoppable_force_ico, o_skill_mighty_swing_ico, o_skill_skull_crusher_ico, o_skill_thirst_for_battle_ico, o_skill_unyielding_defence_ico, o_skill_seize_the_initiative_ico, o_skill_battering_ram_ico]
            if (object_index == o_bandit_raubritter_flail)
                _skill_array = ["Necromancy", o_skill_raise_shield_ico, o_skill_ram_ico, o_skill_onslaught_ico, o_skill_knockout_ico, o_skill_armor_break_ico, o_skill_thirst_for_battle_ico, o_skill_unyielding_defence_ico, o_skill_seize_the_initiative_ico, o_skill_battering_ram_ico]
            if (object_index == o_skeleton_axeman || object_index == o_skeleton_maceman || object_index == o_skeleton_swordsman)
                _skill_array = ["Necromancy", o_skill_raise_shield_ico]
            if (object_index == o_skeleton_spearman)
                _skill_array = ["Necromancy", o_skill_piercing_lunge_ico]
            if (object_index == o_skeleton_bowman || object_index == o_skeleton_ranger || object_index == o_skeleton_crossbowman)
                _skill_array = ["Necromancy", o_skill_taking_aim_ico]
            if (object_index == o_ghoul_medium || object_index == o_ghoul_large)
                _skill_array = ["Necromancy", o_skill_series_of_strikes_ico]
            if (object_index == o_skeleton_footman)
                _skill_array = ["Necromancy", o_skill_cleave_ico, o_skill_raise_shield_ico]
            if (object_index == o_skeleton_militiaman)
                _skill_array = ["Necromancy", o_skill_cut_through_ico, o_skill_raise_shield_ico]
            if (object_index == o_skeleton_defender)
                _skill_array = ["Necromancy", o_skill_raise_shield_ico, o_skill_defensive_stance_ico, o_skill_ram_ico, o_skill_armor_break_ico]
            if (object_index == o_skeleton_guard)
                _skill_array = ["Necromancy", o_skill_nail_down_ico, o_skill_piercing_lunge_ico, o_skill_intransigence_ico]
            if (object_index == o_ghast)
                _skill_array = ["Necromancy", o_skill_bw_touch_ico, o_bw_dark_bless_ico]
            if (object_index == o_ghast_accursed || object_index == o_ghast_elder)
                _skill_array = ["Necromancy", o_skill_bw_touch_ico, o_bw_dark_bless_ico, o_skill_soul_explosion_ico]
            if (object_index == o_skeleton_soldier)
                _skill_array = ["Necromancy", o_skill_cleave_ico, o_skill_raise_shield_ico, o_skill_ram_ico, o_skill_raise_shield_ico, o_skill_breakthrough_ico]
            if (object_index == o_skeleton_warrior)
                _skill_array = ["Necromancy", o_skill_cut_through_ico, o_skill_raise_shield_ico, o_skill_ram_ico, o_skill_raise_shield_ico, o_skill_breakthrough_ico]
            if (object_index == o_skeleton_halberdier)
                _skill_array = ["Necromancy", o_skill_active_defence_ico, o_skill_pikemans_stance_ico, o_skill_piercing_lunge_ico, o_skill_intransigence_ico]
            if (object_index == o_skeleton_knightAxe)
                _skill_array = ["Necromancy", o_skill_wide_cut_ico, o_skill_dismember_ico, o_skill_thirst_for_battle_ico, o_skill_unyielding_defence_ico]
            if (object_index == o_skeleton_knightSword)
                _skill_array = ["Necromancy", o_skill_arc_cleave_ico, o_skill_riposte_ico, o_skill_thirst_for_battle_ico, o_skill_unyielding_defence_ico]
            if (object_index == o_skeleton_knightHammer)
                _skill_array = ["Necromancy", o_skill_mighty_swing_ico, o_skill_unstoppable_force_ico, o_skill_thirst_for_battle_ico, o_skill_unyielding_defence_ico]
            if (object_index == o_necromancer_boss)
                _skill_array = ["Necromancy", o_skill_double_jab_ico]
            if (object_index == o_necromancer_boss_staff)
                _skill_array = ["Necromancy", o_skill_hail_of_blows_ico]
            if (object_index == o_necromancer_ritualist)
                _skill_array = ["Necromancy", o_skill_hail_of_blows_ico, o_pass_skill_imortall]
            if (object_index == o_necromancer_wraithbinder)
                _skill_array = ["Necromancy", o_skill_bw_wraithsummon_ico, o_skill_Lostsouls_ico]
            if (object_index == o_revenant)
                _skill_array = ["Necromancy", o_pass_skill_kingdead, o_pass_skill_imortall]
            if (object_index == o_skeleton_guardianSpear)
                _skill_array = ["Necromancy", o_skill_nail_down_ico, o_skill_piercing_lunge_ico, o_skill_regroup_ico, o_skill_pikemans_stance_ico, o_skill_against_the_odds_ico]
            if (object_index == o_skeleton_guardianSword)
                _skill_array = ["Necromancy", o_skill_cleave_ico, o_skill_ram_ico, o_skill_defensive_stance_ico, o_skill_breakthrough_ico, o_skill_against_the_odds_ico]
            if (object_index == o_skeleton_guardianMace)
                _skill_array = ["Necromancy", o_skill_ram_ico, o_skill_breakthrough_ico, o_skill_onslaught_ico, o_skill_hammer_and_anvil_ico, o_skill_armor_break_ico]
            if (object_index == o_skeleton_guardianAxe)
                _skill_array = ["Necromancy", o_skill_dismember_ico, o_skill_wide_cut_ico, o_skill_reign_in_blood_ico, o_skill_against_the_odds_ico]
            if (object_index == o_proselyte_champion)
                _skill_array = ["Necromancy", o_skill_series_of_strikes_ico, o_skill_power_kick_ico]
            if (object_index == o_proselyte_impaler)
                _skill_array = ["Necromancy", o_skill_piercing_lunge_ico, o_skill_sudden_strike_ico]
            if (object_index == o_proselyte_outcast)
                _skill_array = ["Necromancy", o_skill_elusiveness_ico, o_skill_dash_ico]
            if (object_index == o_proselyte_gifted_axe)
                _skill_array = ["Necromancy", o_skill_dismember_ico, o_skill_wide_cut_ico, o_skill_reign_in_blood_ico]
            if (object_index == o_proselyte_gifted_mace)
                _skill_array = ["Necromancy", o_skill_unstoppable_force_ico, o_skill_mighty_swing_ico, o_skill_skull_crusher_ico]
            if (object_index == o_proselyte_abomination)
                _skill_array = ["Necromancy", o_skill_thirst_for_battle_ico]
            if (object_index == o_proselyte_matriarch)
                _skill_array = ["Necromancy", o_skill_gaping_wound_ico, o_skill_deflect_ico]
            if (object_index == o_proselyte_murkstalker)
                _skill_array = ["Necromancy", o_skill_seize_the_initiative_ico]
            if (object_index == o_proselyte_wormbearer)
                _skill_array = ["Necromancy", o_skill_adrenaline_rush_ico]
        }
    }
    var is_skill_lock = scr_skill_branch_can_study(_skill_array)
    if is_skill_lock
    {
        scr_skill_branch_study(_skill_array)
        with (o_tutorial_controller)
        {
            if (state == 19)
                state++
        }
    }
}
