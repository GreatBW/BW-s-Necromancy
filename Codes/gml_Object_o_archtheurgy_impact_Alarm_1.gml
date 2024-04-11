target = scr_tile_get_instance(x, y, 0, 0)
if (instance_exists(owner) && instance_exists(target))
{
    damage2 = 3.33
    bArmor_Piercing = 100
    if scr_instance_exists_in_list(o_b_angel_charm, o_player.buffs)
        Sacred_Damage = damage2
    else
        Unholy_Damage = damage2
    if scr_instance_exists_in_list(o_b_angel_charm, owner.buffs)
    {
        with (target)
            scr_guiAnimation_ext(x, y, 1493)
    }
    else
    {
        with (target)
            scr_guiAnimation_ext(x, y, 11398)
    }
    scr_skill_damage(target)
}
instance_destroy()
