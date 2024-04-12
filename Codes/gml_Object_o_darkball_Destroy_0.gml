if instance_exists(owner)
{
    if is_player(owner)
    {
        if (instance_exists(o_pass_skill_ndarkness) && o_pass_skill_ndarkness.is_open)
            scr_psychic_change("Sanity", -0.1)
        else
            scr_psychic_change("Sanity", -0.2)
        if (!(scr_instance_exists_in_list(o_b_angel_charm, o_player.buffs)))
            scr_temp_effect_update(object_index, o_player, "Unholy_Damage", (Unholy_Damage / 3), 12, 1)
        else
            scr_temp_effect_update(object_index, o_player, "Sacred_Damage", (Unholy_Damage / 3), 12, 1)
        scr_allturn()
    }
}
