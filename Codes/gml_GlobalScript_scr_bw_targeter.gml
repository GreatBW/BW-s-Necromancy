function scr_bw_targeter() //gml_Script_scr_bw_targeter
{
    var _cur = s_cursor_skill
    if (target_group != -4)
    {
        _cur = 1675
        with (o_skill_tile_indicator)
            visible = false
        with (o_corpse)
        {
            var _col = collision_point(mouse_x, mouse_y, id, 0, 0)
            if _col
            {
                if instance_exists(_col)
                {
                    if _col.visible
                    {
                        _cur = s_cursor_skill
                        other.target_group = o_corpse
                    }
                }
            }
        }
        with (o_enemy)
        {
            _col = collision_point(mouse_x, mouse_y, id, 0, 0)
            if _col
            {
                if instance_exists(_col)
                {
                    if _col.visible
                    {
                        if scr_instance_exists_in_list(o_b_servemaster)
                        {
                            _cur = s_cursor_skill
                            other.target_group = o_enemy
                        }
                        else
                        {
                            other.target_group = o_corpse
                            _cur = 1675
                        }
                    }
                }
            }
        }
    }
    if (_cur == 1675 && global.UI_is_on)
        scr_draw_text_transformed_shadow(((mouse_x + 13) + 5), (mouse_y + 13), ds_list_find_value(global.other_hover, 46), 0.5, 0.5, 0, 16777215)
    return _cur;
}

