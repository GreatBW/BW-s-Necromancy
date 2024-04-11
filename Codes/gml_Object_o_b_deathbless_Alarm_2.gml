event_inherited()
with (target)
{
    if is_player()
    {
        with (o_pass_skill_kingdead)
            event_user(3)
    }
    ds_map_clear(other.data)
    ds_map_add(other.data, "Lifesteal", 9)
    ds_map_add(other.data, "Manasteal", 9)
    ds_map_add(other.data, "Damage_Returned", 13)
}
