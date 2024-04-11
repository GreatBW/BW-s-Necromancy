event_inherited()
if is_open
{
    var _moral = scr_atr("Morale")
    if (!instance_exists(o_mortal_blocker))
    {
        with (o_player)
        {
            if (HP < 2 && max_hp >= (0.5 * max_hp) && _moral >= 50)
            {
                instance_create(x, y, o_mortal_blocker)
                scr_restore_hp(id, (0.33 * max_hp), scr_id_get_name(other.id))
                scr_restore_mp(id, (0.33 * max_mp), scr_id_get_name(other.id))
                scr_psychic_change("Morale", -10)
                scr_fatigue_change(2)
            }
        }
    }
}
