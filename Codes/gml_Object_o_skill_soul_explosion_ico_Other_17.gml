if instance_exists(owner)
{
    ds_map_replace(text_map, "U_D", (6 * (owner.Magic_Power / 100)))
    ds_map_replace(text_map, "A_D", (4 * (owner.Magic_Power / 100)))
}
event_inherited()
