if instance_exists(owner)
{
    var _caster = owner
    var _count = 0
    with (o_enemy)
    {
        if (faction_id == "Servant")
        {
            _count++
            if (visible && scr_tile_distance(id, _caster) < _caster.VSN)
            {
                with (scr_guiAnimation_ext(x, y, 1277, 1, 1, 0, 16777215, 0))
                {
                    scr_audio_play_at(1299)
                    depth = (other.depth - 1)
                    scr_set_lt()
                }
                scr_restore_hp(id, other.steal, scr_id_get_name(other.id))
            }
        }
    }
}
instance_destroy()
