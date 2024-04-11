if is_open
{
    ds_map_replace(data, "Nature_Resistance", 25)
    ds_map_replace(data, "Health_Restoration", 12)
    ds_map_replace(data, "Healing_Received", -24)
}
else
{
    ds_map_replace(data, "Nature_Resistance", 0)
    ds_map_replace(data, "Health_Restoration", 0)
    ds_map_replace(data, "Healing_Received", 0)
}
event_inherited()
