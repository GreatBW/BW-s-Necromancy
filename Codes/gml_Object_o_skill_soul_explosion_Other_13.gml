with (o_enemy)
{
    if (HP < (0.5 * max_hp))
    {
        if scr_instance_exists_in_list(o_b_servemaster, buffs)
        {
            with (scr_effect_create(o_charSelection, o_damage_dealer, id, id))
                is_special = 1
        }
    }
}
if instance_exists(o_player)
    o_player.MP -= 25
with (o_skill_soul_explosion_ico)
{
    scr_set_kd(skill, "KD", 15)
    with (child_skill)
        scr_set_kd(skill, "KD", 15)
}
if (instance_exists(o_pass_skill_ndarkness) && o_pass_skill_ndarkness.is_open)
    scr_psychic_change("Sanity", -0.1)
else
    scr_psychic_change("Sanity", -0.2)
