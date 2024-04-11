if scr_instance_exists_in_list(o_db_painful_curse, target.buffs)
{
    with (o_db_painful_curse)
    {
        if (target == other.target)
        {
            duration += ceil((other.f_duration * (1 - (other.target.Fortitude / 100))))
            stage += 1
        }
    }
}
else
    scr_effect_create(o_db_painful_curse, f_duration, target, owner)
event_inherited()
if instance_exists(owner)
{
    if is_player(owner)
    {
        if (instance_exists(o_pass_skill_ndarkness) && o_pass_skill_ndarkness.is_open)
            scr_psychic_change("Sanity", -0.1)
        else
            scr_psychic_change("Sanity", -0.2)
        scr_allturn()
    }
}
