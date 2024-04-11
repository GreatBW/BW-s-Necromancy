var _x = scr_round_cell(mouse_x)
var _y = scr_round_cell(mouse_y)
with (scr_enemy_create(_x, _y, 4449, 0))
{
    HP = max_hp
    MP = max_mp
}
