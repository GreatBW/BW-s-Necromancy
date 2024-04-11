alarm[7] = 1
var _moral = scr_atr("Morale")
if is_open
{
    if instance_exists(o_player)
    {
        with (o_player)
        {
            if (max_hp >= (0.5 * max_hp) && _moral >= 50)
                global.playerNoDeathMode = 1
            else
                global.playerNoDeathMode = 0
        }
    }
}
else
    global.playerNoDeathMode = 0
