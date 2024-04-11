if (image_index > luft && (!is_created))
{
    var target = scr_tile_get_instance(x, y, 0, 0)
    if (!target)
    {
    }
    else if (object_is_ancestor(target.object_index, o_enemy) || object_is_ancestor(target.object_index, o_player))
    {
        var can_work = 1
        var i = 0
        while (i < array_length(target_execute_array))
        {
            if (target == target_execute_array[i])
            {
                can_work = 0
                break
            }
            else
            {
                i++
                continue
            }
        }
        if can_work
        {
            with (object_index)
                target_execute_array[array_length(target_execute_array)] = target
            event_user(1)
        }
    }
    is_created = 1
}
