if instance_exists(target)
{
    var _unit = target.id
    if (instance_exists(o_exploreMenu) && visible)
    {
        instance_destroy(o_exploreMenu)
        scr_use_consum_skill(id, o_skill_bw_targeting_offense, 0)
        with (o_skill_bw_targeting_offense)
            unit_bw = _unit
    }
}
