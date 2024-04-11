var _levul = 0
if instance_exists(o_player)
{
    _levul = (o_player.LVL + 3)
    if (instance_exists(o_skill_soul_explosion_ico) && o_skill_soul_explosion_ico.is_open)
        _levul += 1
    if (target.LVL > _levul)
        target.HP = 0
    else
    {
        var _targ = target
        if ((global.bw_call && (!(object_is_ancestor(target.object_index, o_Dead_March))) && (!(object_is_ancestor(target.object_index, o_Specter)))) || (global.bw_call && object_is_ancestor(target.object_index, c_ghoul)))
        {
            with (instance_create(target.x, target.y, o_undead_fixer))
            {
                owner = _targ
                unit_object = _targ.object_index
                p_hp = _targ.HP
                p_mp = _targ.MP
                p_x = scr_round_cell(_targ.x)
                p_y = scr_round_cell(_targ.y)
            }
            global.bw_call = 0
        }
    }
}
with (target)
{
    if object_is_ancestor(self, o_Bandit)
    {
        idle_undead_speech = "idleUndead"
        movement_voice_tag = "moveUndead"
        suspicious_voice_tag = "alarmUndead"
        hostile_voice_tag = "hostileUndead"
        attack_voice_tag = "attackUndead"
        skill_voice_tag = ""
        dead_voice_tag = "deathUndead"
        injury_voice_tag = "injuryUndead"
    }
    var _lvl = LVL
    if (max_hp >= 500)
    {
        ds_map_clear(other.data)
        if object_is_ancestor(object_index, o_proselyte)
        {
            ds_map_add(other.data, "Healing_Received", -33)
            ds_map_add(other.data, "Health_Restoration", -5)
            ds_map_add(other.data, "Lifesteal", -7)
        }
        ds_map_add(other.data, "Pain_Resistance", 200)
        ds_map_add(other.data, "Bleeding_Resistance", 200)
        ds_map_add(other.data, "Hit_Chance", (((-0.7 * _lvl) * 0.6) - 8))
        ds_map_add(other.data, "Weapon_Damage", (((1.1 * _lvl) * 0.95) + 5))
        ds_map_add(other.data, "FMB", ((0.9 * _lvl) + 8))
        ds_map_add(other.data, "EVS", (((-1 * _lvl) * 0.7) - 10))
        ds_map_add(other.data, "CTA", (((-1 * _lvl) * 0.58) - 6))
        ds_map_add(other.data, "Pain_Change", -100)
        scr_atr_calc(id)
    }
    else if (max_hp >= 250)
    {
        ds_map_clear(other.data)
        if object_is_ancestor(object_index, o_proselyte)
        {
            ds_map_add(other.data, "Healing_Received", -33)
            ds_map_add(other.data, "Health_Restoration", -5)
            ds_map_add(other.data, "Lifesteal", -7)
        }
        ds_map_add(other.data, "Pain_Resistance", 200)
        ds_map_add(other.data, "Bleeding_Resistance", 200)
        ds_map_add(other.data, "Hit_Chance", (((-0.7 * _lvl) * 0.6) - 12))
        ds_map_add(other.data, "Weapon_Damage", (((1.1 * _lvl) * 0.95) + 10))
        ds_map_add(other.data, "FMB", ((0.9 * _lvl) + 16))
        ds_map_add(other.data, "EVS", (((-1 * _lvl) * 0.7) - 20))
        ds_map_add(other.data, "CTA", (((-1 * _lvl) * 0.58) - 18))
        ds_map_add(other.data, "Pain_Change", -100)
        scr_atr_calc(id)
    }
    else if (max_hp >= 150)
    {
        ds_map_clear(other.data)
        if object_is_ancestor(object_index, o_proselyte)
        {
            ds_map_add(other.data, "Healing_Received", -33)
            ds_map_add(other.data, "Health_Restoration", -5)
            ds_map_add(other.data, "Lifesteal", -7)
        }
        ds_map_add(other.data, "Pain_Resistance", 200)
        ds_map_add(other.data, "Bleeding_Resistance", 200)
        ds_map_add(other.data, "Hit_Chance", (((-0.7 * _lvl) * 0.6) - 5))
        ds_map_add(other.data, "Weapon_Damage", (((1.1 * _lvl) * 0.95) + 10))
        ds_map_add(other.data, "FMB", ((0.9 * _lvl) + 10))
        ds_map_add(other.data, "EVS", (((-1 * _lvl) * 0.7) - 10))
        ds_map_add(other.data, "CTA", (((-1 * _lvl) * 0.58) - 8))
        ds_map_add(other.data, "Pain_Change", -100)
        scr_atr_calc(id)
    }
    else if object_is_ancestor(object_index, o_Specter)
    {
        ds_map_clear(other.data)
        ds_map_add(other.data, "Pain_Resistance", 200)
        ds_map_add(other.data, "Bleeding_Resistance", 200)
        ds_map_add(other.data, "Hit_Chance", (((-0.7 * _lvl) * 0.6) - 3))
        ds_map_add(other.data, "FMB", ((0.9 * _lvl) + 2))
        ds_map_add(other.data, "EVS", (((-1 * _lvl) * 0.7) - 2))
        ds_map_add(other.data, "CTA", (((-1 * _lvl) * 0.58) - 3))
        ds_map_add(other.data, "Pain_Change", -100)
        scr_atr_calc(id)
    }
    else
    {
        ds_map_clear(other.data)
        if object_is_ancestor(object_index, o_proselyte)
        {
            ds_map_add(other.data, "Healing_Received", -33)
            ds_map_add(other.data, "Health_Restoration", -5)
            ds_map_add(other.data, "Lifesteal", -7)
        }
        ds_map_add(other.data, "Pain_Resistance", 200)
        ds_map_add(other.data, "Bleeding_Resistance", 200)
        ds_map_add(other.data, "Hit_Chance", (((-0.7 * _lvl) * 0.6) - 3))
        ds_map_add(other.data, "Weapon_Damage", (((1.1 * _lvl) * 0.95) + 5))
        ds_map_add(other.data, "FMB", ((0.9 * _lvl) + 4))
        ds_map_add(other.data, "EVS", (((-1 * _lvl) * 0.7) - 8))
        ds_map_add(other.data, "CTA", (((-1 * _lvl) * 0.58) - 6))
        ds_map_add(other.data, "Pain_Change", -100)
        scr_atr_calc(id)
    }
}
