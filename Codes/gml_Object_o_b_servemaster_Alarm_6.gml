var _targ = target
if instance_exists(target)
{
    if (target.faction_id != "Servant" && (!executed))
    {
        with (instance_create(target.x, target.y, o_undead_fixer))
        {
            owner = _targ
            unit_object = _targ.object_index
            p_hp = _targ.HP
            p_mp = _targ.MP
            p_x = scr_round_cell(_targ.x)
            p_y = scr_round_cell(_targ.y)
        }
        executed = 1
    }
}
