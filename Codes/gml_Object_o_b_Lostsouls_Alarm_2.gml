with (target)
{
    ds_map_clear(other.data)
    ds_map_add(other.data, "Damage_Received", -10)
    scr_atr_calc(id)
}
if instance_exists(o_player)
    instance_create(o_player.x, o_player.y, o_Lostsouls)
instance_destroy()
