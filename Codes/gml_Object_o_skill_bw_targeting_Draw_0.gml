if is_activate
{
    var _x = scr_round_cell(mouse_x)
    var _y = scr_round_cell(mouse_y)
    draw_sprite_ext(s_tile_indicator, scr_pat_prototype(_x, _y, 0, 0), (_x + 13), (_y + 13), 1, 1, 0, c_white, 0.6)
}
