if instance_exists(o_player)
{
    instance_create(x, y, o_res_buff_creator)
    with (scr_enemy_create(p_x, p_y, unit_object, 0))
    {
        HP = other.p_hp
        MP = other.p_mp
        scr_agred(100)
        scr_enemy_registration()
    }
    instance_destroy()
}
else
    instance_destroy()
