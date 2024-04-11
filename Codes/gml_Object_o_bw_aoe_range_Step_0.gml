if instance_exists(o_ancientTroll_dead)
{
    if place_meeting(x, y, o_ancientTroll_dead)
        is_change = 0
}
if is_change
{
    if (scr_pat_prototype(x, y, 0, 0) && (!(scr_ds_grid_get(o_controller.posgrid, (x div 26), (y div 26)))))
        instance_destroy()
    if visible_check
    {
        if (!is_visible())
            instance_destroy()
    }
    is_change = 0
}
visible = true
grid_x = (x div 26)
grid_y = (y div 26)
if (!instance_exists(o_aoe_range))
    instance_destroy()
