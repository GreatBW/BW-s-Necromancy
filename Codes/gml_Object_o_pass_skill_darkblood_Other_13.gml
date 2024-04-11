event_inherited()
if is_open
{
    with (o_b_bless)
    {
        if (target == o_player)
            instance_destroy()
    }
    if (scr_atr("Immunity") > 65)
        scr_immunity_change(-0.01)
    with (owner)
    {
        if is_player()
        {
            var _udmg = 0.02
            with (o_db_bleed_parent)
            {
                if is_player(target)
                    _udmg += 0.015
            }
            with (o_b_darkenchant)
            {
                if is_player(target)
                    _udmg += (duration * 0.0025)
            }
            if instance_exists(o_enemy)
            {
                with (o_enemy)
                {
                    if (state == "attack")
                    {
                        if (!(scr_instance_exists_in_list(o_b_servemaster, buffs)))
                        {
                            if (scr_tile_distance(o_player, id) == 1)
                            {
                                if (object_is_ancestor(object_index, o_enemy) && (!(object_is_ancestor(object_index, o_NPC))))
                                {
                                    if ((0.5 * max_hp) < HP)
                                    {
                                        scr_simple_damage(id, (_udmg * HP))
                                        var key = ds_map_find_first(Body_Parts_map)
                                        repeat ds_map_size(Body_Parts_map)
                                        {
                                            scr_injuryChange(o_player.id, key, (_udmg * 100))
                                            key = ds_map_find_next(Body_Parts_map, key)
                                        }
                                        var _susy = (_udmg + 0.02)
                                        o_player.HP += (_susy * o_player.max_hp)
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
