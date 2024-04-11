if (!is_execute)
{
    var _crit = is_crit
    if instance_exists(owner)
    {
        scr_skill_summon_get_tile()
        xx = point_x
        yy = point_y
        is_execute = 1
        var _unit = 2000
        var _spr = s_wraithsummon_hit
        with (owner)
        {
            with (scr_instance_exists_in_list(o_b_charged_soul))
            {
                if _crit
                    stage++
                switch stage
                {
                    case 1:
                        _unit = choose(723, 5068)
                        break
                    case 2:
                        _unit = choose(558, 755)
                        break
                    case 3:
                        _unit = choose(2002, 2001)
                        break
                    case 4:
                        _unit = choose(1067, 3573)
                        break
                }

                if (!_crit)
                    instance_destroy()
            }
        }
        scr_guiAnimation_ext((xx + 13), (yy + 13), 10932, 1, image_speed, 0, 16777215, 0)
        scr_audio_play_at(1712)
        instance_create(x, y, o_res_buff_creator)
        with (scr_enemy_create((xx + 13), (yy + 13), _unit, 0))
        {
            creating_unit = _unit
            sprite_index = _spr
            image_speed = 1
            is_cheack = 0
            owner = other.owner
            gain_xp *= 0.1
            can_drop_loot = 0
        }
        var _resist = 0
        var _resist2 = 0
        if instance_exists(o_player)
        {
            with (o_player)
            {
                _resist = Unholy_Resistance
                _resist2 = Magic_Resistance
            }
        }
        if (instance_exists(o_player) && (!(scr_instance_exists_in_list(o_b_exceptional, o_player.buffs))))
        {
            var _fort = 44
            if is_fumble
                _fort *= 2
            if is_crit
                _fort = 0
            _fort -= (_resist + _resist2)
            if _fort
            {
                if scr_chance_value(_fort)
                    scr_effect_create(o_db_takeover, irandom_range(6, 25))
            }
        }
        with (o_pass_skill_kingdead)
            event_user(3)
    }
}
