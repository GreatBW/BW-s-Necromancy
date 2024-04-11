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
