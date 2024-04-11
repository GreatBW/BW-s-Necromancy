if instance_exists(o_player)
{
    var _value = "It worked! I've created life from death!"
    with (o_player)
        scr_voice_text(_value, -4, 16777215, 0, -39, 0)
    global.bw_FR = 1
    instance_destroy()
}
