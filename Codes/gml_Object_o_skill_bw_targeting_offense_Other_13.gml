var _targ = scr_tile_get_instance(mouse_x, mouse_y, 0, 0)
var _unit = unit_bw
if (instance_exists(_targ) && instance_exists(_unit))
{
    if (_targ != _unit)
    {
        with (o_b_servemaster)
        {
            if (target == _unit)
            {
                selected_target = _targ
                check = 0
            }
        }
        with (o_enemy)
        {
            if (id == _unit)
            {
                is_damage_taken = 1
                last_attacker = _targ
            }
        }
    }
}
with (o_floor_target)
    alarm[2] = 1
event_user(15)
