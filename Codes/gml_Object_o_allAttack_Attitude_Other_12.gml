event_inherited()
with (o_b_servemaster)
{
    if (check != 3)
        check = 0
}
with (o_player)
    audio_play_sound(scr_random_snd_list(hey_sound), 2, false)
with (object_index)
    is_activate = 0
if instance_exists(o_player)
{
    var _value = ""
    if (global.language == 1)
        _value = choose("В атаку!", "В бой!", "Убить их всех!", "Да начнётся бойня!")
    else
        _value = choose("Attack!", "Fight them!", "Kill them all!", "Let the battle begin")
    with (o_player)
        scr_voice_text(_value, -4, 16777215, 0, -39, 0)
}
