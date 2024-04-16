event_inherited()
if instance_exists(o_player)
{
    if (scr_instance_exists_in_list(o_db_takeover, o_player.buffs) || scr_instance_exists_in_list(o_b_exceptional, o_player.buffs))
        is_ready = 0
}
