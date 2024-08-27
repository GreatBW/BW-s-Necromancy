event_inherited()
if ((!instance_exists(o_undead_fixer)) && faction_id != "Servant")
{
    scr_loot(o_loot_cgrimoir2, x, y, 100)
    if scr_chance_value(33)
        scr_loot(o_loot_cgrimoir, x, y, 100)
    with (scr_weapon_loot("hexermantle", x, y, 10, 6))
    {
        scr_inv_atr_set("Duration", irandom_range(10, 50))
    }
}
