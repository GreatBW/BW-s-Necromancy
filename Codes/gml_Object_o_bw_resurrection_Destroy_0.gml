event_inherited()
var _ucharge = u_charge
var _is_undead = 0
if instance_exists(o_corpse)
{
    with (o_corpse)
    {
        if in_range
            _is_undead++
    }
}
if _is_undead
{
    if (is_special && u_charge >= 2)
    {
        with (instance_find(instance_nearest(o_player.x, o_player.y, o_corpse), 0))
        {
            if in_range
            {
                with (instance_create(x, y, o_bw_resurrection))
                {
                    owner = 3226
                    target = -1
                    is_special = 1
                    u_charge = (_ucharge - 1)
                }
            }
        }
    }
}
