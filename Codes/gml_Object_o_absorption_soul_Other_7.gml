if scr_instance_exists_in_list(o_b_charged_soul, o_player.buffs)
{
    with (o_b_charged_soul)
    {
        if is_player(target)
            stage = 3
    }
}
else
    scr_effect_create(o_globalmapFogRender, o_loot_tongs)
scr_fatigue_change(-2)
if (instance_exists(o_pass_skill_kingdead) && o_pass_skill_kingdead.is_open)
{
    with (o_pass_skill_kingdead)
        event_user(3)
}
scr_temp_incr_atr("Healing_Received", 15, o_dialogRender)
scr_temp_incr_atr("Fatigue_Gain", 25, o_dialogRender)
if instance_exists(target)
{
    with (target)
    {
        scr_guiAnimation_ext(x, y, 147)
        scr_guiAnimation_ext(x, y, 148)
        diss = 80
        scr_unitInterractImpact()
        inside_particles = 3485
        scr_audio_play_at(1259)
        scr_audio_play_at(1257)
        instance_create(x, y, o_explosion_hole)
        instance_create(x, y, o_trashy_corpz)
    }
}
if instance_exists(target)
{
    with (target)
    {
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
        repeat choose(1, 2)
        {
            if scr_chance_value(20)
                scr_loot(o_loot_bone, x, y, 100)
        }
        instance_destroy()
    }
}
instance_destroy()
