if ((unit_object == o_Hive) || (unit_object == o_hornethive) || (unit_object == o_crawler_hive) || (unit_object == o_crawler_hive02) || (unit_object == o_crawler_hive03) || (unit_object == o_crawlerburrow01) || (unit_object == o_hornethive02) || (unit_object == o_hornethive03) || (unit_object == o_hornethive04) || (unit_object == o_hornethive05_special) || (unit_object == o_harpynest) || (unit_object == o_harpynest_02) || (unit_object == o_harpynest_03) || (unit_object == o_harpynest_04) || (unit_object == o_harpynest_05))
    return instance_destroy();
if (unit_object == o_npc_kromm || unit_object == o_npc_vyn || unit_object == o_npc_merc01 || unit_object == o_npc_merc02 || unit_object == o_npc_merc03)
    unit_object = o_bw_zombie
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
