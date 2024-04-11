event_inherited()
var _san = scr_atr("Sanity")
var _san_left = (100 - _san)
with (target)
{
    ds_map_clear(other.data)
    ds_map_add(other.data, "Magic_Power", (-40 - (_san_left / 2)))
    ds_map_add(other.data, "Miscast_Chance", (10 + _san_left))
    scr_atr_calc(id)
}
