if (!instance_exists(owner))
{
}
else
{
    var _sus = 0
    if (instance_exists(o_inv_right_hand) && instance_exists(o_inv_left_hand))
    {
        with (o_inv_right_hand)
        {
            if (!instance_exists(children))
                _sus++
        }
        with (o_inv_left_hand)
        {
            if (!instance_exists(children))
                _sus++
        }
    }
    if is_range
        base_range = owner.range
    if is_enemy_skill
        base_range = scr_get_value_Dmap(skill, "Range")
    var bonus = Bonus_Range
    var _cd_reduct = Cooldown_Reduction
    if ((!(object_is_ancestor(object_index, o_skill_ico))) && (!(object_is_ancestor(object_index, o_skills_like))))
    {
        bonus = (owner_skill.Special_Bonus_Range + ((owner_skill.Bonus_Range + owner.Bonus_Range) * can_scale_range))
        _cd_reduct = owner_skill.Cooldown_Reduction
    }
    else
        bonus = (Special_Bonus_Range + ((Bonus_Range + owner.Bonus_Range) * can_scale_range))
    if (class == "spell")
        MPcost = math_round(((scr_get_value_Dmap(skill, "MP") * (owner.Spells_Energy_Cost / 100)) * MPcostBonus))
    else
        MPcost = math_round(((scr_get_value_Dmap(skill, "MP") * (owner.Skills_Energy_Cost / 100)) * MPcostBonus))
    var _maxCD = scr_get_value_Dmap(skill, "max_KD")
    range = math_round((base_range + bonus))
    maxKD = math_round(((_maxCD * (owner.Cooldown_Reduction - _cd_reduct)) / 100))
    var _category = scr_get_value_Dmap(skill, "Category")
    if (_category != 0)
    {
        if scr_stance_training(owner.id)
        {
            if (ds_list_find_index(_category, "Maneuver") >= 0 || ds_list_find_index(_category, "Stance") >= 0)
            {
                MPcost = math_round((MPcost * 0.8))
                maxKD = math_round((maxKD * 0.8))
            }
        }
        if (ds_list_find_index(_category, "Charge") >= 0 && scr_passive_skill_is_open(o_pass_skill_sprint_training, owner.id))
            MPcost = math_round((MPcost * 0.5))
    }
    if (maxKD <= 0)
        maxKD = 1
    if (_maxCD == 0)
        maxKD = 0
    var _power = 1
    if (class == "spell")
    {
        _power = (owner.Magic_Power / 100)
        if (MPcost > 0)
        {
            var _skill_is_open = scr_passive_skill_is_open(o_pass_skill_precise_movements, owner)
            var _skill_count = 0
            if _skill_is_open
            {
                with (o_skill_ico)
                {
                    if (is_open && branch == other.branch)
                        _skill_count++
                }
            }
            var _wet_fmb = 0
            if (branch == "electromancy")
            {
                var _wet = scr_instance_exists_in_list(o_db_wet, owner.buffs)
                with (_wet)
                {
                    if (stage > 1)
                        _wet_fmb = (-10 + (10 * stage))
                }
            }
            if (owner_skill != self && instance_exists(owner_skill))
                FMB = owner_skill.FMB
            with (owner)
            {
                if (_sus == 2)
                    other.Miscast_Chance = clamp(((((Miscast_Chance + other.FMB) + _wet_fmb) + ((_skill_is_open * -1.5) * _skill_count)) / 2), 0, 100)
                else
                    other.Miscast_Chance = clamp((((Miscast_Chance + other.FMB) + _wet_fmb) + ((_skill_is_open * -1.5) * _skill_count)), 0, 100)
                other.Backfire_Damage = math_round(((Backfire_Damage * other.MPcost) / 100))
            }
        }
        if (Miscast_Chance >= 0)
        {
            var _damage_type = scr_skill_get_backfire_damage_type(branch)
            var _color_type = scr_hoversGetDamageAttributeColor(_damage_type)
            var num = ds_list_find_index(mid_text, ds_map_find_value(global.attribute, "Miscast_Chance"))
            if (num >= 0)
                ds_list_replace(mid_text, (num + 1), scr_hoversGetAttributeString("Miscast_Chance", Miscast_Chance, 0))
            else
                ds_list_add(mid_text, ds_map_find_value(global.attribute, "Miscast_Chance"), scr_hoversGetAttributeString("Miscast_Chance", Miscast_Chance, 0), make_colour_rgb(158, 27, 49))
            num = ds_list_find_index(mid_text, ds_map_find_value(global.attribute, "Backfire_Damage"))
            if (num >= 0)
                ds_list_replace(mid_text, (num + 1), scr_hoversGetAttributeString("Backfire_Damage", Backfire_Damage, 0, 0))
            else
                ds_list_add(mid_text, ds_map_find_value(global.attribute, "Backfire_Damage"), scr_hoversGetAttributeString("Backfire_Damage", Backfire_Damage, 0, 0), _color_type)
        }
        if (!is_player(owner))
            var _ap = owner.bArmor_Piercing
        else
        {
            with (owner)
                _ap = (-15 + (1.5 * PRC))
        }
        if (bArmor_Piercing != "x")
        {
            bArmor_Piercing = string_to_real(bArmor_Piercing)
            Armor_Piercing = max(0, (bArmor_Piercing + _ap))
            num = ds_list_find_index(mid_text, ds_map_find_value(global.attribute, "Armor_Piercing"))
            if (num >= 0)
                ds_list_replace(mid_text, (num + 1), scr_hoversGetAttributeString("Armor_Piercing", Armor_Piercing, 0))
            else
                ds_list_add(mid_text, ds_map_find_value(global.attribute, "Armor_Piercing"), scr_hoversGetAttributeString("Armor_Piercing", Armor_Piercing, 0), 16777215)
        }
    }
    MPcostBonus = 1
    if (_sus == 2)
        maxKD = math_round((maxKD * 0.5))
    if (instance_exists(o_skill_soul_explosion_ico) && o_skill_soul_explosion_ico.is_open)
    {
        if instance_exists(owner)
            ds_map_replace(data, "LEVL", (owner.LVL + 4))
    }
    else if instance_exists(owner)
        ds_map_replace(data, "LEVL", (owner.LVL + 3))
}
