event_inherited()
with (target)
{
    if scr_instance_exists_in_list(o_b_angel_charm, buffs)
        ds_map_add(other.data, "Sacred_Damage", 2)
    else
        ds_map_add(other.data, "Unholy_Damage", 2)
    ds_map_add(other.data, "Arcane_Damage", 2)
    scr_atr_calc(id)
}
