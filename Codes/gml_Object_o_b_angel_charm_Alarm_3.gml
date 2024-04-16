if instance_exists(target)
{
    var _buffUnholy_Damage = 0
    with (target)
        _buffUnholy_Damage = scr_buff_param("Unholy_Damage")
    var _amogus = 0
    with (o_inv_right_hand)
    {
        if (!instance_exists(children))
            _amogus++
    }
    with (o_inv_left_hand)
    {
        if (!instance_exists(children))
            _amogus++
    }
    if ((_amogus == 2))
    {
        ds_map_replace(data, "Unholy_Damage", 0)
        ds_map_replace(data, "Sacred_Damage", 0)
    }
    else
    {
        ds_map_replace(data, "Unholy_Damage", (-((target.Unholy_Damage - _buffUnholy_Damage))))
        ds_map_replace(data, "Sacred_Damage", (target.Unholy_Damage - _buffUnholy_Damage))
    }
}
