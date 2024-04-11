if (unit_object == 1991 || unit_object == 844 || unit_object == 4184 || unit_object == 1508 || unit_object == 6992 || unit_object == 467 || unit_object == 1883 || unit_object == 130 || unit_object == 703 || unit_object == 127 || unit_object == 1645 || unit_object == 3211 || unit_object == 465 || unit_object == 6495 || unit_object == 812)
    return instance_destroy();
if (unit_object == 239 || unit_object == 247 || unit_object == 2378 || unit_object == 1081 || unit_object == 707)
    unit_object = 7065
if is_crit
    restore_percent = 1
else if (instance_exists(o_pass_skill_lingering_incantations) && o_pass_skill_lingering_incantations.is_open)
    restore_percent += 0.165
if (is_special && (!is_crit))
    restore_percent /= 2
global.bw_call = 1
instance_create(x, y, o_res_buff_creator)
with (scr_enemy_create(x, y, unit_object, 0))
{
    if instance_exists(other.target)
    {
        unitParamName = other.target.unitParamName
        if string_count("Melee", unitParamName)
            scr_param(unitParamName, 0, 1)
    }
    HP = (other.restore_percent * max_hp)
    MP = (other.restore_percent * max_mp)
    head_sprite = asset_get_index(string((sprite_get_name(sprite_index) + "_head")))
    can_drop_loot = 0
    ArmorDurability = 0
}
with (o_pass_skill_kingdead)
    event_user(3)
if (!is_special)
{
    var _resist = 0
    var _resist2 = 0
    if instance_exists(o_player)
    {
        with (o_player)
        {
            _resist = Unholy_Resistance
            _resist2 = Magic_Resistance
        }
    }
    if (instance_exists(o_player) && (!(scr_instance_exists_in_list(o_b_exceptional, o_player.buffs))))
    {
        var _fort = 33
        if is_fumble
            _fort *= 2
        if is_crit
            _fort = 0
        _fort -= (_resist + _resist2)
        if _fort
        {
            if scr_chance_value(_fort)
                scr_effect_create(o_db_takeover, irandom_range(9, 19))
        }
    }
}
with (target)
    instance_destroy()
instance_destroy()
