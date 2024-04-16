if instance_exists(o_player)
{
    with (instance_create(o_player.x, (o_player.y - 12), o_gui_animation))
    {
        sprite_index = s_darkritual_startcast
        charges = 1
        image_speed = 1
        draw_with_alpha = 0
    }
}
var _is_undead = 0
if instance_exists(o_corpse)
{
    with (o_corpse)
    {
        if in_range
            _is_undead++
    }
}
if _is_undead
{
    with (instance_find(instance_nearest(o_player.x, o_player.y, o_corpse), 0))
    {
        if in_range
        {
            with (instance_create(x, y, o_bw_resurrection))
            {
                owner = o_player
                target = -1
                is_special = 1
                u_charge = 3
            }
        }
    }
}
if (_is_undead < 3)
{
    instance_create(x, y, o_res_buff_creator)
    repeat (3 - _is_undead)
    {
        var side = scr_tile_around_target(o_player, 4)
        if is_array(side)
        {
            var point_x = (o_player.x + side[0])
            var point_y = (o_player.y + side[1])
        }
        else
        {
            point_x = o_player.x
            point_y = o_player.y
        }
        var _unit = 2000
        with (o_player)
        {
            with (scr_instance_exists_in_list(o_b_charged_soul))
            {
                switch stage
                {
                    case 1:
                        _unit = choose(o_ghost_squire, o_ghost_monk)
                        break
                    case 2:
                        _unit = choose(o_ghost_cleric, o_ghost_sergeant)
                        break
                    case 3:
                        _unit = choose(o_ghost_seer, o_ghost_knight)
                        break
                    case 4:
                        _unit = choose(o_ghost_templar, o_ghost_commander)
                        break
                }

            }
        }
        var xx = point_x
        var yy = point_y
        scr_guiAnimation_ext((xx + 13), (yy + 13), s_wraithsummon_hit, 1, image_speed, 0, 16777215, 0)
        scr_audio_play_at(snd_skill_wraith_summoning_hit)
        with (scr_enemy_create(xx, yy, _unit, 0))
        {
            HP = max_hp
            MP = max_mp
        }
    }
}
scr_effect_create(o_b_exceptional, choose(3, 4, 5, 6))
scr_effect_create(o_b_exceptional, choose(3, 4, 5, 6))
scr_effect_create(o_b_exceptional, choose(3, 4, 5, 6))
repeat (3)
{
    with (o_pass_skill_kingdead)
        event_user(3)
}
scr_fatigue_change(2)
if (instance_exists(o_pass_skill_ndarkness) && o_pass_skill_ndarkness.is_open)
    scr_psychic_change("Sanity", -3)
else
    scr_psychic_change("Sanity", -6)
with (o_player)
    scr_audio_play_at(1404)
with (o_b_charged_soul)
    instance_destroy()
