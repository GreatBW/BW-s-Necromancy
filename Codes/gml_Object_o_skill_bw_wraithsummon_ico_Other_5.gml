if is_open
{
    var _sus = 0
    if (instance_exists(o_inv_right_hand) && instance_exists(o_inv_left_hand))
    {
        with (o_inv_right_hand)
        {
            if (!instance_exists(children))
                _sus++
        }
        with (o_inv_left_hand)
        {
            if (!instance_exists(children))
                _sus++
        }
    }
    if (_sus == 2)
        pause = 0
}
