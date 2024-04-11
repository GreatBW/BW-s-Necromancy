if instance_exists(owner)
{
    ds_map_replace(data, "I_C", (36 + (owner.Magic_Power * 0.3)))
    ds_map_replace(data, "I_H", (36 + (owner.Magic_Power * 0.3)))
    ds_map_replace(data, "Unholy_Damage", ((13 * owner.Magic_Power) * 0.01))
}
event_inherited()
