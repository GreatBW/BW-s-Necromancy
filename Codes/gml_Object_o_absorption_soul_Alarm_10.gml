with (owner)
{
    with (scr_guiAnimation(11070, 1, 1, 0))
        scr_set_lt(sprite_index)
    scr_audio_play_at(65)
    if visible
    {
        with (o_player)
            turn_available = 0
    }
}
