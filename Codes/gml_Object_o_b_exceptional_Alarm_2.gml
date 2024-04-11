with (target)
{
    ds_map_clear(other.data)
    ds_map_add(other.data, "Received_XP", -75)
    ds_map_add(other.data, "Fatigue_Gain", 35)
    scr_atr_calc(id)
}
