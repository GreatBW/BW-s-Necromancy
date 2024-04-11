if (instance_exists(o_skill_soul_explosion_ico) && o_skill_soul_explosion_ico.is_open)
    can_learn = 1
else
    can_learn = 0
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
    var _spr = s_necromancer06_aura
    if (_sus == 2 && (!pause))
    {
        if instance_exists(o_player)
        {
            pause = 1
            with (o_player)
            {
                other.anime = scr_onUnitAnimationCreate(_spr, _spr, 8029, -1)
                with (other.anime)
                    scr_set_lt()
            }
        }
    }
    if (_sus != 2 && (!instance_exists(o_confirm_panel)))
    {
        scr_onUnitAnimationDestroy(anime)
        pause = 0
    }
}
