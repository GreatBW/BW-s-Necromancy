if instance_exists(owner)
{
    if is_player(owner)
    {
        if (instance_exists(o_pass_skill_ndarkness) && o_pass_skill_ndarkness.is_open)
            scr_psychic_change("Sanity", -0.1)
        else
            scr_psychic_change("Sanity", -0.2)
        if scr_instance_exists_in_list(o_b_angel_charm, owner.buffs)
            scr_temp_effect_update(object_index, owner, "Sacred_Damage", math_round(((9 * (owner.Magic_Power * 0.01)) / 4)), 12, 1)
        else
            scr_temp_effect_update(object_index, owner, "Unholy_Damage", math_round(((9 * (owner.Magic_Power * 0.01)) / 4)), 12, 1)
        scr_allturn()
    }
}
