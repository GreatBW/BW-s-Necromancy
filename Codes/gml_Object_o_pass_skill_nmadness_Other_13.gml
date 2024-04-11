event_inherited()
if is_open
{
    var _skill_array = -4
    with (o_enemy)
    {
        if scr_instance_exists_in_list(o_b_servemaster)
        {
            if (object_index == o_bandit_rioter)
                _skill_array = ["Necromancy", 4325]
            if (object_index == o_bandit_trasher)
                _skill_array = ["Necromancy", 4296, 4339]
            if (object_index == o_bandit_trasher_axe)
                _skill_array = ["Necromancy", 4296, 4349]
            if (object_index == o_bandit_trasher_sword)
                _skill_array = ["Necromancy", 4296, 4230]
            if (object_index == o_bandit_poacher)
                _skill_array = ["Necromancy", 4213]
            if (object_index == o_bandit_henchman_axe)
                _skill_array = ["Necromancy", 4175, 4239, 4299]
            if (object_index == o_bandit_sidekick_mace)
                _skill_array = ["Necromancy", 4183, 4239, 4299]
            if (object_index == o_bandit_mancatcher)
                _skill_array = ["Necromancy", 4299, 4324, 4281]
            if (object_index == o_bandit_renegade)
                _skill_array = ["Necromancy", 4325, 4324]
            if (object_index == o_bandit_renegade_sword)
                _skill_array = ["Necromancy", 4230, 4281]
            if (object_index == o_bandit_renegade_axe)
                _skill_array = ["Necromancy", 4351, 4349]
            if (object_index == o_bandit_renegade_mace)
                _skill_array = ["Necromancy", 4340, 4339]
            if (object_index == o_bandit_crook)
                _skill_array = ["Necromancy", 4195, 4194, 4299, 4281]
            if (object_index == o_bandit_rogue_mage)
                _skill_array = ["Necromancy", 1196, 4264, 80]
            if (object_index == o_bandit_outlaw)
                _skill_array = ["Necromancy", 4213, 4215]
            if (object_index == o_bandit_marauder_axe)
                _skill_array = ["Necromancy", 4350, 4349, 4351]
            if (object_index == o_bandit_marauder_sword)
                _skill_array = ["Necromancy", 4296, 4230, 4229]
            if (object_index == o_bandit_marauder_mace)
                _skill_array = ["Necromancy", 4340, 4339, 4341]
            if (object_index == o_bandit_soldier_sword)
                _skill_array = ["Necromancy", 4239, 4299, 4240, 4168]
            if (object_index == o_bandit_soldier_axe)
                _skill_array = ["Necromancy", 4239, 4299, 4175, 4176]
            if (object_index == o_bandit_soldier_mace)
                _skill_array = ["Necromancy", 4239, 4299, 4186, 4183]
            if (object_index == o_bandit_cutthroat)
                _skill_array = ["Necromancy", 4195, 4194, 4299, 4281, 4197, 4300]
            if (object_index == o_bandit_arbalester)
                _skill_array = ["Necromancy", 4213, 4216]
            if (object_index == o_bandit_halberdier)
                _skill_array = ["Necromancy", 4324, 4326, 4328, 508]
            if (object_index == o_bandit_conjurer)
                _skill_array = ["Necromancy", 4264, 4265, 4269, 4267, 4272]
            if (object_index == o_bandit_geomancer)
                _skill_array = ["Necromancy", 4247, 4251, 4206, 4252, 4248]
            if (object_index == o_bandit_electromancer)
                _skill_array = ["Necromancy", 623, 80, 763, 967, 1449]
            if (object_index == o_bandit_sergeant_hammer)
                _skill_array = ["Necromancy", 4339, 4340, 4341, 4342, 4296]
            if (object_index == o_bandit_sergeant_sword)
                _skill_array = ["Necromancy", 4168, 4166, 4169, 4298, 2852]
            if (object_index == o_bandit_sergeant_axe)
                _skill_array = ["Necromancy", 4349, 4350, 4351, 4352]
            if (object_index == o_bandit_sergeant_gsword)
                _skill_array = ["Necromancy", 4230, 4229, 4281, 4231, 4232]
            if (object_index == o_bandit_sergeant_mace)
                _skill_array = ["Necromancy", 4188, 4187, 2852, 508]
            if (object_index == o_bandit_longbowman)
                _skill_array = ["Necromancy", 4213, 4219, 4215, 4216]
            if (object_index == o_bandit_duelist)
                _skill_array = ["Necromancy", 4195, 4168, 4196, 4198, 4281, 4299]
            if (object_index == o_bandit_gmdeserter_polearm)
                _skill_array = ["Necromancy", 4325, 4324, 453, 4281, 508, 4298, 4326, 4328]
            if (object_index == o_bandit_gmdeserter_gaxe)
                _skill_array = ["Necromancy", 453, 4281, 508, 4298, 4349, 4350, 4351, 4352]
            if (object_index == o_bandit_gmdeserter_ghammer)
                _skill_array = ["Necromancy", 453, 4281, 508, 4298, 4339, 4340, 4342, 4341]
            if (object_index == o_bandit_magehunter)
                _skill_array = ["Necromancy", 4168, 2036, 1684, 4298, 4301]
            if (object_index == o_bandit_heavyarbalester)
                _skill_array = ["Necromancy", 4213, 4281, 4216]
            if (object_index == o_bandit_banneret)
                _skill_array = ["Necromancy", 4325, 4324, 4055]
            if (object_index == o_bandit_kingpin)
                _skill_array = ["Necromancy", 4296, 4186, 4183]
            if (object_index == o_bandit_freak)
                _skill_array = ["Necromancy", 4195, 4311, 4298, 4196]
            if (object_index == o_bandit_warlock)
                _skill_array = ["Necromancy", 4205, 4264, 1196, 4267, 80, 763]
            if (object_index == o_bandit_bonebreaker_axe)
                _skill_array = ["Necromancy", 453, 4350, 4349, 4351, 4296]
            if (object_index == o_bandit_bonebreaker_mace)
                _skill_array = ["Necromancy", 453, 4340, 4339, 4341, 4296]
            if (object_index == o_bandit_huntmaster)
                _skill_array = ["Necromancy", 4220, 4213, 4219, 4216]
            if (object_index == o_bandit_ringleader_shield)
                _skill_array = ["Necromancy", 4239, 4240, 4168, 4241, 2852, 4288]
            if (object_index == o_bandit_ringleader_2hsword)
                _skill_array = ["Necromancy", 4230, 4229, 4281, 4231, 4232, 508, 4233]
            if (object_index == o_bandit_paymaster)
                _skill_array = ["Necromancy", 4230, 4229, 4281, 4232, 4287, 4300]
            if (object_index == o_bandit_raubritter_2hsword)
                _skill_array = ["Necromancy", 4229, 4230, 4233, 4232, 4287, 1344, 4281, 453]
            if (object_index == o_bandit_raubritter_2hmace)
                _skill_array = ["Necromancy", 4340, 4339, 4341, 4287, 1344, 4281, 453]
            if (object_index == o_bandit_raubritter_flail)
                _skill_array = ["Necromancy", 4239, 4240, 4183, 4188, 4186, 4287, 1344, 4281, 453]
            if (object_index == o_skeleton_axeman || object_index == o_skeleton_maceman || object_index == o_skeleton_swordsman)
                _skill_array = ["Necromancy", 4239]
            if (object_index == o_skeleton_spearman)
                _skill_array = ["Necromancy", 4325]
            if (object_index == o_skeleton_bowman || object_index == o_skeleton_ranger || object_index == o_skeleton_crossbowman)
                _skill_array = ["Necromancy", 4213]
            if (object_index == o_ghoul_medium || object_index == o_ghoul_large)
                _skill_array = ["Necromancy", 4311]
            if (object_index == o_skeleton_footman)
                _skill_array = ["Necromancy", 4166, 4239]
            if (object_index == o_skeleton_militiaman)
                _skill_array = ["Necromancy", 4175, 4239]
            if (object_index == o_skeleton_defender)
                _skill_array = ["Necromancy", 4239, 4241, 4240, 4186]
            if (object_index == o_skeleton_guard)
                _skill_array = ["Necromancy", 4324, 4325, 4327]
            if (object_index == o_ghast)
                _skill_array = ["Necromancy", 7059, 7055]
            if (object_index == o_ghast_accursed || object_index == o_ghast_elder)
                _skill_array = ["Necromancy", 7059, 7055, 7027]
            if (object_index == o_skeleton_soldier)
                _skill_array = ["Necromancy", 4166, 4239, 4240, 4239, 4242]
            if (object_index == o_skeleton_warrior)
                _skill_array = ["Necromancy", 4175, 4239, 4240, 4239, 4242]
            if (object_index == o_skeleton_halberdier)
                _skill_array = ["Necromancy", 508, 4328, 4325, 4327]
            if (object_index == o_skeleton_knightAxe)
                _skill_array = ["Necromancy", 4349, 4350, 4287, 1344]
            if (object_index == o_skeleton_knightSword)
                _skill_array = ["Necromancy", 4233, 4232, 4287, 1344]
            if (object_index == o_skeleton_knightHammer)
                _skill_array = ["Necromancy", 4339, 4340, 4287, 1344]
            if (object_index == o_necromancer_boss)
                _skill_array = ["Necromancy", 4195]
            if (object_index == o_necromancer_boss_staff)
                _skill_array = ["Necromancy", 4205]
            if (object_index == o_necromancer_ritualist)
                _skill_array = ["Necromancy", 4205, 7033]
            if (object_index == o_necromancer_wraithbinder)
                _skill_array = ["Necromancy", 7045, 7030]
            if (object_index == o_revenant)
                _skill_array = ["Necromancy", 7034, 7033]
            if (object_index == o_skeleton_guardianSpear)
                _skill_array = ["Necromancy", 4324, 4325, 4326, 4328, 4288]
            if (object_index == o_skeleton_guardianSword)
                _skill_array = ["Necromancy", 4166, 4240, 4241, 4242, 4288]
            if (object_index == o_skeleton_guardianMace)
                _skill_array = ["Necromancy", 4240, 4242, 4183, 4187, 4186]
            if (object_index == o_skeleton_guardianAxe)
                _skill_array = ["Necromancy", 4350, 4349, 4351, 4288]
            if (object_index == o_proselyte_champion)
                _skill_array = ["Necromancy", 4311, 4296]
            if (object_index == o_proselyte_impaler)
                _skill_array = ["Necromancy", 4325, 4298]
            if (object_index == o_proselyte_outcast)
                _skill_array = ["Necromancy", 4300, 4299]
            if (object_index == o_proselyte_gifted_axe)
                _skill_array = ["Necromancy", 4350, 4349, 4351]
            if (object_index == o_proselyte_gifted_mace)
                _skill_array = ["Necromancy", 4340, 4339, 4341]
            if (object_index == o_proselyte_abomination)
                _skill_array = ["Necromancy", 4287]
            if (object_index == o_proselyte_matriarch)
                _skill_array = ["Necromancy", 4196, 4314]
            if (object_index == o_proselyte_murkstalker)
                _skill_array = ["Necromancy", 4281]
            if (object_index == o_proselyte_wormbearer)
                _skill_array = ["Necromancy", 4301]
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
