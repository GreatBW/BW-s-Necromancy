if (!is_created)
{
    is_created = 1
    target = scr_tile_get_instance(x, y, 0, 0)
    Psionic_Damage = 2
    if is_crit
        Psionic_Damage *= max(1, (owner.Miracle_Power / 100))
    event_inherited()
    with (target)
        scr_guiAnimation_ext(x, y, 1355)
    if scr_effect_create(o_skill_aura_incense, o_Sea_shoreline22, target, target)
    {
        with (owner)
        {
            _rage = scr_instance_exists_in_list(o_b_rage)
            if _rage
            {
                with (_rage)
                    duration++
            }
            else
                scr_effect_create(o_skill_category_survival, o_loot_tongs, id, id, 0, 1)
        }
    }
    if is_player(owner)
    {
        with (o_pass_skill_intimidation)
        {
            target = other.target
            event_user(3)
        }
    }
}
instance_destroy()
