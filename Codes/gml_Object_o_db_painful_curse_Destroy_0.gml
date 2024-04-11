event_inherited()
if (instance_exists(target) && instance_exists(o_onUnitAnimation))
{
    with (o_onUnitAnimation)
    {
        if (owner == other.target)
            instance_destroy()
    }
}
