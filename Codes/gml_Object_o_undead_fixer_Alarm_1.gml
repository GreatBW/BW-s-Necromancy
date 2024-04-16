if (!instance_exists(owner))
{
}
with (owner)
{
    if scr_instance_exists_in_list(o_b_servemaster, buffs)
    {
        is_neutral = 1
        HP = 0
        corpse_type = o_empty
        emo_death_sound = 242
    }
}
