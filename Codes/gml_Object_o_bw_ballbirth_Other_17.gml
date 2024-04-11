if (instance_exists(point) && instance_exists(owner) && (!is_execute))
    point = scr_shoot_target_miss(point, owner, (75 + (1.5 * owner.PRC)), 0)
event_inherited()
