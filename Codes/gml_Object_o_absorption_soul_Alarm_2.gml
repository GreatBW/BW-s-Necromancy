with (owner)
{
    with (scr_guiAnimation(s_essence_leech_buff, 1, 1, 0))
        scr_set_lt(sprite_index)
    scr_audio_play_at(snd_skill_essence_leech_buff)
}
instance_destroy()
