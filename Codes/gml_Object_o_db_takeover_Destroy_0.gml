event_inherited()
if snd_loop
{
    audio_sound_gain(snd_loop, 0, 1500)
    with (instance_create(x, y, o_audio_stopper))
        snd = other.snd_loop
}
