with (target)
{
    ds_map_clear(other.data)
    ds_map_add(other.data, "Unholy_Resistance", irandom_range(-25, -50))
    scr_atr_calc(id)
}
