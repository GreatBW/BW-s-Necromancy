event_inherited()
with (o_inv_slot)
{
    if (owner.object_index != o_trade_inventory && is_weapon && scr_dsMapFindValue(data, "identified", 0) && (!(scr_dsMapFindValue(data, "is_cursed", 1))) && scr_dsMapFindValue(data, "quality", -4) != (6 << 0) && scr_dsMapFindValue(data, "quality", -4) != (10 << 0) && scr_dsMapFindValue(data, "quality", -4) != (2 << 0) && scr_dsMapFindValue(data, "quality", -4) != (3 << 0))
        image_alpha = 1
    else
        image_alpha = 0.25
    can_pick = 0
}
