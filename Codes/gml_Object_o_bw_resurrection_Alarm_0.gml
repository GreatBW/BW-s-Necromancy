if (target == noone)
    return instance_destroy();
if (instance_exists(owner) && instance_exists(target))
{
    if is_player(owner)
    {
        if (!is_special)
        {
            with (o_player)
                scr_audio_play_at(snd_archon_laugh_kill_1)
        }
        target = instance_nearest(x, y, o_corpse)
        unit_sprite = target.enemy_default_sprite
        unit_object = target.enemy_object_index
    }
    else
    {
        unit_object = target.enemy_object_index
        unit_sprite = target.enemy_default_sprite
    }
}
else
    instance_destroy()
