event_inherited()
global.bw_selection = 0
with (owner)
{
    if is_player()
    {
        if (instance_exists(o_pass_skill_ndarkness) && o_pass_skill_ndarkness.is_open)
            scr_psychic_change("Sanity", -0.2)
        else
            scr_psychic_change("Sanity", -0.4)
        scr_allturn()
    }
}
