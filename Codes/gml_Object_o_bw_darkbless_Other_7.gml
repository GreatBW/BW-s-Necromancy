if (instance_exists(target) && instance_exists(owner))
{
    var _crit = (is_crit ? max(1, (owner.Miracle_Power / 100)) : 1)
    var _sussy_baka = (4 + ((owner.Magic_Power * 0.05) * _crit))
    var _amog = (_sussy_baka / 3)
    if scr_instance_exists_in_list(o_b_servemaster, target.buffs)
    {
        _sussy_baka *= 1.5
        _amog *= 1.5
    }
    with (target)
    {
        var key = ds_map_find_first(Body_Parts_map)
        repeat ds_map_size(Body_Parts_map)
        {
            scr_injuryChange(id, key, _amog)
            key = ds_map_find_next(Body_Parts_map, key)
        }
    }
    scr_restore_hp(target, ((_sussy_baka / 100) * target.max_hp), scr_id_get_name(id))
    scr_effect_create(o_b_deathbless, turns, target, owner)
}
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
