event_inherited()
with (target)
{
    ds_map_clear(other.data)
    ds_map_add(other.data, "Unholy_Resistance", 33)
    ds_map_add(other.data, "Miracle_Power", 66)
    ds_map_add(other.data, "Sacred_Damage", 0)
    ds_map_add(other.data, "Unholy_Damage", 0)
    scr_atr_calc(id)
}
with (o_player)
{
    scr_guiAnimation(s_charming)
    scr_audio_play_at(snd_altar_buff)
}
