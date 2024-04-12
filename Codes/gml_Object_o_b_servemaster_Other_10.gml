var _lvl = target.LVL
adjacent_enemies = 0
var R = 1
with (o_enemy)
{
    if (!(scr_instance_exists_in_list(o_b_servemaster, buffs)))
    {
        if (id != other.target && HP > 0 && scr_tile_distance(id, other.target) <= R)
            other.adjacent_enemies = 1
    }
}
if object_is_ancestor(target.object_index, o_Specter)
{
}
else if (target.max_hp >= 700)
    ds_map_replace(data, "max_hp", -500)
else if (target.max_hp >= 600)
    ds_map_replace(data, "max_hp", -450)
else if (target.max_hp >= 500)
    ds_map_replace(data, "max_hp", -300)
else if (target.max_hp >= 450)
    ds_map_replace(data, "max_hp", -300)
else if (target.max_hp >= 400)
    ds_map_replace(data, "max_hp", -250)
else if (target.max_hp >= 350)
    ds_map_replace(data, "max_hp", -250)
else if (target.max_hp >= 300)
    ds_map_replace(data, "max_hp", -200)
else if (target.max_hp >= 200)
    ds_map_replace(data, "max_hp", -75)
else if (target.max_hp >= 150)
    ds_map_replace(data, "max_hp", -25)
else if (target.max_hp >= 125)
    ds_map_replace(data, "max_hp", -15)
else if (target.max_hp >= 100)
    ds_map_replace(data, "max_hp", 15)
else if (target.max_hp >= 75)
    ds_map_replace(data, "max_hp", 25)
else if (target.max_hp <= 65)
    ds_map_replace(data, "max_hp", 30)
else if (target.max_hp <= 50)
    ds_map_replace(data, "max_hp", 35)
with (target)
{
    if (object_index == o_harpy)
        is_flying = 0
    ai_script = gml_Script_scr_enemy_choose_state
    flee_limit = 0
    emo_death_sound = choose(snd_zombie_death_1, snd_zombie_death_2, snd_zombie_death_3)
    VSN = 8
    Poison_Immunity = 1
    isLootDropped = 0
    can_drop_loot = 0
    ArmorDurability = 0
    isMiniboss = 0
    can_speak = 0
    if object_is_ancestor(object_index, o_Bandit)
    {
        ds_list_clear(emo_sound)
        ds_list_add(emo_sound, snd_zombie_emotion_1, snd_zombie_emotion_2, snd_zombie_emotion_3, snd_zombie_emotion_4)
    }
    if is_player()
    {
    }
    else
    {
        scr_set_kd("Dissipation", "KD", scr_get_value_Dmap("Dissipation", "max_KD"))
        scr_set_kd("Wraith_Summoning", "KD", scr_get_value_Dmap("Wraith_Summoning", "max_KD"))
        scr_set_kd("Net_Throw", "KD", scr_get_value_Dmap("Net_Throw", "max_KD"))
        scr_set_kd("Summon_Blood_Golem", "KD", scr_get_value_Dmap("Summon_Blood_Golem", "max_KD"))
        scr_set_kd("Elder_Ritual_of_Resurrection", "KD", scr_get_value_Dmap("Elder_Ritual_of_Resurrection", "max_KD"))
        scr_set_kd("Against_the_Odds", "KD", scr_get_value_Dmap("Against_the_Odds", "max_KD"))
        scr_set_kd("Summon_the_Worm", "KD", scr_get_value_Dmap("Summon_the_Worm", "max_KD"))
        scr_set_kd("Wormrot", "KD", scr_get_value_Dmap("Wormrot", "max_KD"))
        scr_set_kd("Tentacle_Arm", "KD", scr_get_value_Dmap("Tentacle_Arm", "max_KD"))
        scr_set_kd("Dead_or_Alive", "KD", scr_get_value_Dmap("Dead_or_Alive", "max_KD"))
        scr_set_kd("Necrophagy", "KD", scr_get_value_Dmap("Necrophagy", "max_KD"))
        scr_set_kd("Howl", "KD", scr_get_value_Dmap("Howl", "max_KD"))
    }
}
if instance_exists(o_player)
{
    if (check == 3)
    {
        var _shomar = 0
        with (o_enemy)
        {
            if (scr_round_cell(point_distance(x, y, o_player.x, o_player.y)) < 182)
            {
                if (visible & is_visible())
                {
                    if (!(scr_instance_exists_in_list(o_b_servemaster, buffs)))
                        _shomar++
                }
            }
        }
        if _shomar
            target.state = "npc combat"
        else
        {
            with (target)
            {
                state = -4
                if ds_list_empty(lock_turn)
                {
                    with (o_controller)
                        mp_grid_clear_cell(grid, (other.x / 26), (other.y / 26))
                    scr_selfcell(0)
                    var access = 0
                    path = path_add()
                    access = mp_grid_path(o_controller.grid, path, x, y, (((o_player.x div 26) * 26) + 13), (((o_player.y div 26) * 26) + 13), true)
                    scr_selfcell(1)
                    if access
                    {
                        var _x = path_get_point_x(path, step)
                        var _y = path_get_point_y(path, step)
                        if (mp_grid_get_cell(o_controller.grid, (_x / 26), (_y / 26)) == 0)
                        {
                            if (xx != _x || yy != _y)
                            {
                                xx = _x
                                yy = _y
                                is_true = 1
                            }
                        }
                    }
                }
            }
        }
    }
    else
    {
        if (check == 1)
        {
            with (target)
            {
                state = -4
                if ds_list_empty(lock_turn)
                {
                    with (o_controller)
                        mp_grid_clear_cell(grid, (other.x / 26), (other.y / 26))
                    scr_selfcell(0)
                    access = 0
                    path = path_add()
                    access = mp_grid_path(o_controller.grid, path, x, y, (((o_player.x div 26) * 26) + 13), (((o_player.y div 26) * 26) + 13), true)
                    scr_selfcell(1)
                    if access
                    {
                        _x = path_get_point_x(path, step)
                        _y = path_get_point_y(path, step)
                        if (mp_grid_get_cell(o_controller.grid, (_x / 26), (_y / 26)) == 0)
                        {
                            if (xx != _x || yy != _y)
                            {
                                xx = _x
                                yy = _y
                                is_true = 1
                            }
                        }
                    }
                }
            }
        }
        else if (check == 0)
            target.state = "npc combat"
        if (check == 2 && (!adjacent_enemies))
        {
            state = -4
            if (selected_positionX && selected_positionY)
            {
                with (target)
                {
                    if other.selected_target
                        state = "npc combat"
                    else
                        state = -4
                    if ds_list_empty(lock_turn)
                    {
                        with (o_controller)
                            mp_grid_clear_cell(grid, (other.x / 26), (other.y / 26))
                        scr_selfcell(0)
                        access = 0
                        path = path_add()
                        access = mp_grid_path(o_controller.grid, path, x, y, (((other.selected_positionX div 26) * 26) + 13), (((other.selected_positionY div 26) * 26) + 13), true)
                        scr_selfcell(1)
                        if access
                        {
                            _x = path_get_point_x(path, step)
                            _y = path_get_point_y(path, step)
                            if (mp_grid_get_cell(o_controller.grid, (_x / 26), (_y / 26)) == 0)
                            {
                                if (xx != _x || yy != _y)
                                {
                                    xx = _x
                                    yy = _y
                                    is_true = 1
                                }
                            }
                        }
                    }
                }
            }
        }
        else if (check == 2 && adjacent_enemies)
            target.state = "npc combat"
    }
}
if (instance_exists(o_player) && instance_exists(o_NPC))
{
    with (o_NPC)
    {
        if (visible & is_visible())
        {
            if (!(scr_instance_exists_in_list(o_db_crime_wanted, o_player.buffs)))
                scr_npc_disorder()
        }
    }
}
