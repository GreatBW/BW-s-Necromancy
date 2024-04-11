if (instance_exists(o_player) && scr_instance_exists_in_list(o_b_angel_charm, o_player.buffs))
    Sacred_Damage = min(target.HP, (target.max_hp * 0.2))
else
    Unholy_Damage = min(target.HP, (target.max_hp * 0.2))
for (var _i = -1; _i <= 1; _i++)
{
    for (var j = -1; j <= 1; j++)
    {
        var _x = (target.x + (26 * _i))
        var _y = (target.y + (26 * j))
        var _target = scr_tile_get_instance(_x, _y, 0, 0)
        if _target
            scr_skill_damage(_target)
    }
}
with (target)
{
    with (scr_guiAnimation(1282, 1, 1, 0))
    {
        scr_audio_play_at(1314)
        scr_set_lt()
        depth = ((-y) + 10)
    }
    instance_create(x, y, o_explosion_hole)
}
scr_allturn()
scr_effect_create(o_b_darkenchant, o_ropewell_exit)
event_inherited()
instance_destroy(target)
