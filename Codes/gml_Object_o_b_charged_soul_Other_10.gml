if (stage == 3)
{
    if scr_chance_value(3)
        scr_effect_create(o_db_takeover, choose(2, 3))
}
if (stage == 4)
{
    if scr_chance_value(5)
        scr_effect_create(o_db_takeover, choose(2, 3, 4))
}
