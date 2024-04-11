event_inherited()
with (target)
{
    other.frontAnimation = scr_onUnitAnimationCreate(s_soulsacrifice_rune_front_start, 1286, 1289, -1)
    other.backAnimation = scr_onUnitAnimationCreate(s_soulsacrifice_rune_back_start, 1295, 1297, 1)
    other.loop_sound = scr_audio_play_at_loop(1315)
}
with (frontAnimation)
    scr_set_lt()
