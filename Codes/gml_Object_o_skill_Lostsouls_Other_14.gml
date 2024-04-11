event_inherited()
if instance_exists(o_player)
{
    _cou = 0
    if instance_exists(o_enemy)
    {
        with (o_enemy)
        {
            if (subfaction_id == "Servant")
                _cou++
        }
    }
    _amogus = 0
    if (instance_exists(o_pass_skill_magic_lore) && o_pass_skill_magic_lore.is_open)
        _amogus++
    if (instance_exists(o_pass_skill_kingdead) && o_pass_skill_kingdead.is_open)
        _amogus++
    if instance_exists(o_inv_bone_cradle)
        _amogus++
    if (_cou >= (1 + _amogus))
        is_ready = 0
}
