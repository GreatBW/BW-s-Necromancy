if ((!instance_exists(owner)) || (!instance_exists(target)))
    return;
event_inherited()
if (deal_damage > 0)
{
    var _name = scr_id_get_name(id)
    if instance_exists(target)
    {
        if object_is_ancestor(target.object_index, o_unit)
        {
            with (target)
                scr_restore_mp(id, (-other.deal_damage), _name)
            with (owner)
                scr_restore_mp(id, other.deal_damage, _name)
        }
        with (o_db_painful_curse)
        {
            if (target == other.target)
                stage += 1
        }
    }
}
event_user(1)
