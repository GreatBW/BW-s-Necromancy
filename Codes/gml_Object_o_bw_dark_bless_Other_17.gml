if instance_exists(owner)
    ds_map_replace(data, "H_P", (4 + (owner.Magic_Power * 0.050000000000000003)))
event_inherited()
