if (interact_id == noone)
    interact_id = instance_position(global.guiMouseX, global.guiMouseY, o_inv_slot)
var _success = 0
with (interact_id)
{
    if (image_alpha == 1)
    {
        if (scr_dsMapFindValue(data, "quality", -4) != (6 << 0))
            scr_rerrol_item_simple((5 << 0))
        var dur = scr_dsMapFindValue(data, "Duration", -4)
        var max_dur = scr_dsMapFindValue(data, "MaxDuration", -4)
        ds_map_replace(data, "Duration", max(1, (dur - (max_dur * random_range(0.15, 0.5)))))
        _success = 1
    }
}
if _success
{
    if instance_exists(o_player)
    {
        with (o_player)
            scr_audio_play_at(710)
    }
    with (parent)
        sh_diss = 200
    event_user(0)
    with (parent)
        instance_destroy()
    instance_destroy()
    event_user(15)
    scr_allturn()
    with (o_bw_curse_ico)
    {
        scr_set_kd(skill, "KD", 1440)
        with (child_skill)
            scr_set_kd(skill, "KD", 1440)
    }
}
interact_id = -4
