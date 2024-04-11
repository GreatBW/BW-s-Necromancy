if is_player(owner)
{
    scr_fatigue_change(1)
    if (instance_exists(o_pass_skill_ndarkness) && o_pass_skill_ndarkness.is_open)
        scr_psychic_change("Sanity", -0.5)
    else
        scr_psychic_change("Sanity", -1)
    scr_allturn()
}
instance_destroy()
