event_inherited()
var _amogus = 0
if instance_exists(o_enemy)
{
    with (o_enemy)
    {
        if (HP < (0.5 * max_hp))
        {
            if scr_instance_exists_in_list(o_b_servemaster, buffs)
                _amogus++
        }
    }
}
if instance_exists(o_player)
{
    if scr_instance_exists_in_list(o_b_exceptional, o_player.buffs)
        _amogus = 0
}
if (_amogus == 0)
    is_ready = 0
