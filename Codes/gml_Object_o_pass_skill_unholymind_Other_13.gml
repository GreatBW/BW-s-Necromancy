event_inherited()
if instance_exists(o_player)
{
    if is_open
    {
        with (o_enemy)
        {
            if (object_is_ancestor(object_index, o_Dead_March) && scr_tile_distance(id, o_player) <= 7 && is_visible() && (!(scr_instance_exists_in_list(o_b_servemaster, buffs))))
            {
                if (instance_exists(o_player) && (!(scr_instance_exists_in_list(o_db_takeover, o_player.buffs))))
                    scr_temp_effect_update(object_index, id, "Unholy_Resistance", ((-bUnholy_Resistance) * 0.07), 9, 9)
                else if (instance_exists(o_player) && scr_instance_exists_in_list(o_db_takeover, o_player.buffs))
                {
                    repeat (2)
                        scr_temp_effect_update(object_index, id, "Unholy_Resistance", ((-bUnholy_Resistance) * 0.07), 9, 9)
                }
            }
        }
    }
}
