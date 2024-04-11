if (!is_execute)
{
    if instance_exists(o_player)
    {
        if instance_exists(point)
        {
            if can_reflect
                point = scr_skill_reflection(point)
            if is_flying
            {
                var xx = x
                var yy = (y - 10)
            }
            else
            {
                xx = point.x
                yy = point.y
            }
            is_execute = 1
            with (instance_create(xx, yy, spell))
            {
                damage = other.damage
                var _pointCenter = scr_findMaskCenter(other.point)
                direction = point_direction(x, y, _pointCenter[0], _pointCenter[1])
                name = other.name
                owner = other.owner
                target = other.point
                is_crit = other.is_crit
                is_special = 1
            }
            with (owner)
                scr_unitInterractImpact(id, other.point)
        }
    }
}
