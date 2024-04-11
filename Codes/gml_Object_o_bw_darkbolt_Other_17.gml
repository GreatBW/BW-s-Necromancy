if instance_exists(owner)
{
    ds_map_replace(data, "Hit_Chance", (75 + (1.5 * owner.PRC)))
    ds_map_replace(data, "Unholy_Damage", math_round((9 * (owner.Magic_Power * 0.01))))
    ds_map_replace(data, "Unholy_Damage2", math_round(((9 * (owner.Magic_Power * 0.01)) / 4)))
}
event_inherited()
