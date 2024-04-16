owner = o_player
var _hp = 0
var _mp = 0
var _grant = 0
if (instance_exists(owner) && instance_exists(target))
{
    var _power = math_round((owner.Magic_Power * 0.06))
    var _exist = scr_instance_exists_in_list(o_b_angel_charm, owner.buffs)
    with (target)
    {
        if (object_is_ancestor(object_index, o_enemy) && (!scr_instance_exists_in_list(o_b_servemaster)))
        {
            instance_create(x, y, o_soul_absorption_impact)
            _grant = 1
        }
        if (object_is_ancestor(object_index, o_enemy) && scr_instance_exists_in_list(o_b_servemaster))
        {
            _hp = (0.13 * max_hp)
            _mp = (0.13 * max_mp)
            scr_pure_damage(id, _hp)
            scr_restore_mp(id, (-_mp), other.name)
        }
        with (scr_guiAnimation(s_essence_leech_hit, 1, 1, 0))
            scr_set_lt(sprite_index)
        scr_audio_play_at(38)
    }
    with (owner)
    {
        if (_hp && _mp)
        {
            scr_restore_hp(id, (_hp / 2), other.name)
            scr_restore_mp(id, (_mp / 2), other.name)
        }
        with (o_pass_skill_kingdead)
            event_user(3)
        if (!_grant)
        {
            var _essence = scr_instance_exists_in_list(o_b_charged_soul)
            if (!_essence)
            {
                with (scr_effect_create(o_b_charged_soul, o_inv_antitoxin_water, id, id))
                    stage = 1
            }
            else
            {
                with (_essence)
                {
                    alarm[3] = 27
                    duration = max_duration
                    if (stage != max_stage)
                        stage++
                }
            }
        }
    }
    event_inherited()
}
else
    instance_destroy()
if _grant
{
    scr_effect_create(o_b_darkenchant, _power)
    with (o_b_charged_soul)
    {
        alarm[3] = 27
        duration = max_duration
    }
}
if instance_exists(target)
{
    with (target)
    {
        if (object_index == o_corpse)
        {
            scr_guiAnimation_ext(x, y, s_signofdarkness_impact)
            scr_guiAnimation_ext(x, y, s_signofdarkness_impact_lt)
            diss = 80
            scr_unitInterractImpact()
            inside_particles = 3557
            scr_audio_play_at(snd_meat_blood_death_1)
            var luft = 10
            repeat (20)
            {
                with (instance_create(((x + 26) + random_range((-luft), luft)), (y + random_range((-luft), luft)), o_bloodpart))
                    speed = 0
                with (instance_create(((x - 26) + random_range((-luft), luft)), (y + random_range((-luft), luft)), o_bloodpart))
                    speed = 0
                with (instance_create(((x + 26) + random_range((-luft), luft)), ((y + 26) + random_range((-luft), luft)), o_bloodpart))
                    speed = 0
                with (instance_create(((x - 26) + random_range((-luft), luft)), ((y - 26) + random_range((-luft), luft)), o_bloodpart))
                    speed = 0
                with (instance_create(((x - 26) + random_range((-luft), luft)), ((y + 26) + random_range((-luft), luft)), o_bloodpart))
                    speed = 0
                with (instance_create(((x + 26) + random_range((-luft), luft)), ((y - 26) + random_range((-luft), luft)), o_bloodpart))
                    speed = 0
                with (instance_create((x + random_range((-luft), luft)), ((y - 26) + random_range((-luft), luft)), o_bloodpart))
                    speed = 0
                with (instance_create((x + random_range((-luft), luft)), ((y + 26) + random_range((-luft), luft)), o_bloodpart))
                    speed = 0
            }
            instance_destroy()
            instance_create(x, y, o_explosion_hole)
        }
    }
}
with (o_player)
    turn_available = 1
