event_inherited()
if ((!instance_exists(o_undead_fixer)) && faction_id != "Servant")
{
    scr_loot(o_loot_cgrimoir2, x, y, 100)
    if scr_chance_value(33)
        scr_loot(o_loot_cgrimoir, x, y, 100)
}
