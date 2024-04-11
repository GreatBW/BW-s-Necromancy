target = scr_skill_reflection(target)
var _sus = 0
if instance_exists(o_player)
    _sus = (36 + (o_player.Magic_Power * 0.3))
with (owner)
{
    with (other.target)
    {
        with (scr_guiAnimation(1275, 1, 1, 0))
        {
            scr_audio_play_at(1298)
            scr_set_lt(sprite_index)
            depth = (other.depth - 1)
        }
        if scr_chance_value(max((_sus - Knockback_Resistance), 0))
            scr_effect_create(o_db_immob, o_coals_and_embers_birth, id, id)
    }
}
with (owner)
    diss = (-200 - random(50))
alarm[0] = 36
