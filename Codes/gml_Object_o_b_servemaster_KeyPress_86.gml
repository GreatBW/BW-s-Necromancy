if instance_exists(target)
{
    var _unit = id
    if (instance_exists(o_exploreMenu) && visible)
    {
        instance_destroy(o_exploreMenu)
        scr_use_consum_skill(id, o_skill_bw_targeting, 0)
        with (o_skill_bw_targeting)
            unit_bw = _unit
    }
}
