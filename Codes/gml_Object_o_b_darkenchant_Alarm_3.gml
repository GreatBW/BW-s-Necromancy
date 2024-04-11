var _sus = 0
if instance_exists(o_player)
    _sus = scr_instance_exists_in_list(o_b_angel_charm, o_player.buffs)
if _sus
{
    ds_map_replace(data, "Sacred_Damage", 2)
    ds_map_replace(data, "Unholy_Damage", 0)
}
else
{
    ds_map_replace(data, "Sacred_Damage", 0)
    ds_map_replace(data, "Unholy_Damage", 2)
}
