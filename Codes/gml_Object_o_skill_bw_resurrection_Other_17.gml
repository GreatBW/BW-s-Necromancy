if (instance_exists(o_skill_soul_explosion_ico) && o_skill_soul_explosion_ico.is_open)
{
    if instance_exists(owner)
        ds_map_replace(data, "LEVL", (owner.LVL + 4))
}
else if instance_exists(owner)
    ds_map_replace(data, "LEVL", (owner.LVL + 3))
event_inherited()
