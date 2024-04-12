var _san = scr_atr("Sanity")
var _mor = scr_atr("Morale")
var _sus = 60
var _amogusuwu = 75
if is_open
{
    if (_mor < _amogusuwu)
        scr_psychic_change("Morale", 0.3)
    with (o_b_bless)
    {
        if (target == o_player)
            instance_destroy()
    }
    if (_san > _sus)
    {
        if (instance_exists(o_pass_skill_ndarkness) && o_pass_skill_ndarkness.is_open)
            scr_psychic_change("Sanity", -0.005)
        else
            scr_psychic_change("Sanity", -0.01)
    }
}
var _cou = o_confirm_panel
var _cou2 = 0
if instance_exists(o_enemy)
{
    with (o_enemy)
    {
        if (subfaction_id == "Servant" && (!(object_is_ancestor(object_index, o_Specter))))
            _cou++
    }
    with (o_Specter)
    {
        if (subfaction_id == "Servant")
            _cou2++
    }
}
if (_cou > o_damage_dealer || _cou2 > 1)
{
    if instance_exists(o_player)
    {
        if scr_instance_exists_in_list(o_db_takeover, o_player.buffs)
            o_db_takeover.duration += ((_cou + _cou2) + 1)
        else if (instance_exists(o_player) && (!(scr_instance_exists_in_list(o_b_exceptional, o_player.buffs))))
            scr_effect_create(o_db_takeover, ((_cou + _cou2) + 1))
    }
}
