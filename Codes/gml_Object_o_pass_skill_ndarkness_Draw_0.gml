event_inherited()
var _x = o_player.x
var _y = o_player.y
if (o_skill_death_plague.is_activate && instance_exists(o_player) && instance_exists(o_pass_skill_ndarkness) && o_pass_skill_ndarkness.is_open)
    draw_sprite_ext(s_tile_indicator, image_index, _x, _y, (image_xscale * 3), (image_yscale * 3), 0, c_white, 0.6)
