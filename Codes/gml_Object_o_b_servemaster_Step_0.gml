alarm[7] = 1
if instance_exists(target)
{
    with (target)
    {
        if (!(object_is_ancestor(object_index, o_Dead_March)))
        {
            morale_value = 100
            morale_max = 100
            morale_k = 1
            morale_max_prev = morale_max
        }
        if is_flying
            is_flying = 0
    }
}
