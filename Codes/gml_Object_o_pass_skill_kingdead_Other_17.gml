if instance_exists(owner)
{
    var _sus = owner.Unholy_Damage
    ds_map_replace(text_map, "Unholy_Damage", math_round((0.033 * owner.Magic_Power)))
}
event_inherited()
