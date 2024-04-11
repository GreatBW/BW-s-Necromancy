with (o_player)
    scr_setside(o_floor_target)
var _cur = 1671
if (pointed == "Target Object" || pointed == "Target Ally")
    _cur = scr_bw_targeter()
with (o_floor_target)
    cursor = _cur
