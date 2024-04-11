event_inherited()
var _isPlayer = is_player(target)
var _san = scr_atr("Sanity")
var _san_left = (100 - _san)
var _decrease = 0
if (instance_exists(o_pass_skill_ndarkness) && o_pass_skill_ndarkness.is_open)
    _decrease = 1
with (target)
{
    if _decrease
    {
        ds_map_clear(other.data)
        ds_map_add(other.data, "Magic_Power", (-15 - (_san_left / 2)))
        ds_map_add(other.data, "Miscast_Chance", (_san_left / 2))
        ds_map_add(other.data, "Spells_Energy_Cost", (5 + (_san_left / 2)))
        scr_atr_calc(id)
    }
    else
    {
        ds_map_clear(other.data)
        ds_map_add(other.data, "Magic_Power", (-25 - (_san_left / 2)))
        ds_map_add(other.data, "Miscast_Chance", (5 + (_san_left / 2)))
        ds_map_add(other.data, "Spells_Energy_Cost", (10 + (_san_left / 2)))
        scr_atr_calc(id)
    }
    if _isPlayer
        other.snd_loop = audio_play_sound(snd_bad_trip_loop, 5, true)
}
if _isPlayer
{
    with (instance_create_depth(-50, -50, 0, o_vignette_effect))
    {
        owner = other.id
        image_blend = merge_color(c_teal, c_black, 0.8)
    }
}
if instance_exists(target)
{
    var _value = 0
    if (_san > 50)
    {
        if (global.language == 1)
            _value = choose("Убирайтесь из моей головы!", "Голова разрывается...", " Нести... смерть...", "Если так продолжится... я погибну...", "Я на грани смерти...!", " Не дать тьме поглотить себя...", "Заткнитесь! Просто заткнитесь...")
        else
            _value = choose("Get out of my head!", "My head's about to burst...", "Bring... death...", "If this continues ... I will die...", "I'm on the verge of death...!", "Don't let the darkness swallow you ...", "Shut up! Just Shut up ...")
    }
    else if (global.language == 1)
        _value = choose("Смерть тебе к лицу!", " Ох, мир смертных... давно минувшие дни...", "Ты смеешь сопротивляться мне?...", "Этот сосуд мой!", " Ты станешь пустой оболочкой... скоро...", "Ха-ха-ха!", "Убить их всех...", "Поддайся... время уйти на покой...", " Сопротивление бесполезно...")
    else
        _value = choose("You are as good as dead!", "Ah mortal world ... It's been a while...", "You dare oppose me ? ...", "This vessel is mine!", "You'll be an empty husk... soon... soon", "Ha ha ha", "Kill them all ...", "Give up ... It's time to sleep ...", "Resistance is no use...")
    with (target)
        scr_voice_text(_value, -4, 16777215, 0, -39, 0)
}
