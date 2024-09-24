event_inherited()
with (o_b_servemaster)
{
    if (check != 3)
        check = 1
}
with (o_player)
    audio_play_sound(scr_random_snd_list(hey_sound), 2, false)
with (object_index)
    is_activate = 0
if instance_exists(o_player)
{
    var _value = ""
    if (global.language == 1)
        _value = choose("Ближе!", "Отставить драку... за мной!", "Ты... ко мне", "Забудьте...", "Двигайтесь!", "Следовать за мной!")
    else if (global.language == 3)
        _value = choose("靠近点", "别反抗...跟上！", "你...过来", "算了...", "走！", "跟我来")
    else
        _value = choose("Get closer", "Stop fighting ... Follow!", "You... come here", "Forget it ...", "Move!", "Follow my lead")
    with (o_player)
        scr_voice_text(_value, -4, 16777215, 0, -39, 0)
}
