var _decrease = 0
if (instance_exists(o_pass_skill_ndarkness) && o_pass_skill_ndarkness.is_open)
    _decrease = 1
var _san = scr_atr("Sanity")
var _san_left = (100 - _san)
if _decrease
    _san_left *= 0.85
var real_max_hp = target.max_hp
var _decr = 0.01
hp_decr -= (real_max_hp * _decr)
ds_map_replace(data, "max_hp", hp_decr)
if scr_actionsLogVisible(target)
    scr_actionsLog("painDamage", [scr_id_get_name(target)])
var _amount = 0.05
_amount += (duration * 0.01)
if _decrease
    _amount *= 0.75
scr_psychic_change("Sanity", (-0.1 - _amount))
if scr_chance_value((4 + (_san_left * 0.16)))
    scr_effect_create(o_db_confuse, choose(1, 2, 3))
if scr_chance_value((6 + (_san_left * 0.1)))
    scr_effect_create(o_db_daze, choose(1, 2))
if scr_instance_exists_in_list(o_b_exceptional, target.buffs)
{
    ds_map_replace(data, "Magic_Power", 0)
    ds_map_replace(data, "Miscast_Chance", 0)
    ds_map_replace(data, "Spells_Energy_Cost", 0)
}
else if _decrease
{
    ds_map_replace(data, "Magic_Power", (-15 - (_san_left / 2)))
    ds_map_replace(data, "Miscast_Chance", (_san_left / 2))
    ds_map_replace(data, "Spells_Energy_Cost", (5 + (_san_left / 2)))
}
else
{
    ds_map_replace(data, "Magic_Power", (-25 - (_san_left / 2)))
    ds_map_replace(data, "Miscast_Chance", (5 + (_san_left / 2)))
    ds_map_replace(data, "Spells_Energy_Cost", (10 + (_san_left / 2)))
}
if (_san < 33 && instance_exists(target))
{
    Unholy_Damage = choose(1, 1, 1, 2, 2, 3)
    scr_skill_damage(target)
}
