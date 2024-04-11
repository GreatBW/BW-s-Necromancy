if instance_exists(owner)
    ds_map_replace(text_map, "U_D", (owner.Magic_Power * 0.06))
if is_open
    ds_map_replace(data, "Unholy_Resistance", 33)
event_inherited()
