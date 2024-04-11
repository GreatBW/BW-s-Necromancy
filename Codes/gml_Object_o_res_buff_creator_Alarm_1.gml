with (o_enemy)
{
    if (faction_id == "Servant")
    {
        if (!(scr_instance_exists_in_list(o_b_servemaster, buffs)))
            scr_effect_create(o_b_servemaster, o_damage_dealer, id, id)
        if (!(scr_instance_exists_in_list(o_b_unbind, buffs)))
            scr_effect_create(o_b_unbind, o_damage_dealer, id, id)
    }
}
