var _x = scr_round_cell(mouse_x)
var _y = scr_round_cell(mouse_y)
var _targ = scr_tile_get_instance(_x, _y, 0, 0)
var _unit = unit_bw
with (o_b_servemaster)
{
    if (id == _unit)
    {
        check = 2
        selected_positionX = _x
        selected_positionY = _y
        selected_target = -4
    }
}
with (o_floor_target)
    alarm[2] = 1
event_user(15)
