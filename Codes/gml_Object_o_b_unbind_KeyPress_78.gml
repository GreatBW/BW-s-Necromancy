if visible
{
    if instance_exists(o_player)
    {
        if (instance_exists(o_pass_skill_ndarkness) && o_pass_skill_ndarkness.is_open)
        {
            with (o_player)
                scr_restore_mp(id, (0.05 * Magic_Power), "Absolute Darkness")
        }
        else
            scr_allturn()
    }
    if ((!(object_is_ancestor(target.object_index, o_Specter))) && scr_instance_exists_in_list(o_bw_sacrifice, target.buffs))
    {
        if scr_instance_exists_in_list(o_b_exceptional, o_player.buffs)
            duration += 8
        else
            scr_effect_create(o_b_exceptional, o_Sea_shoreline22)
    }
    with (target)
        instance_destroy()
}
