if instance_exists(target)
{
    var dir = point_direction(x, y, target.x, target.y)
    with (instance_create(target.x, target.y, o_spellimpact))
    {
        sprite_index = s_weapondamage_unholy
        image_speed = 1
        scr_audio_play_at(choose(snd_arcane_bolt_impact_1, snd_arcane_bolt_impact_2, snd_arcane_bolt_impact_3, snd_arcane_bolt_impact_4))
        scr_set_lt()
    }
    repeat (4 + irandom(5))
    {
        repeat random(3)
        {
            var dir2 = random_range(30, -30)
            var spd2 = random(12)
            with (instance_create((target.x + random_range(5, -5)), (target.y + random_range(5, -5)), o_firecarry))
            {
                speed = (5 + random(8))
                direction = (dir + dir2)
            }
        }
    }
}
