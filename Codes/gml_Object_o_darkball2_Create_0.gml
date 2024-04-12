event_inherited()
scr_light_off()
scr_set_lt()
image_speed = 0.5
speed = 10
scr_audio_play_at(choose(1457, 1458))
scr_audio_play_at(1459)
scr_damage_init()
owner = o_player
if scr_instance_exists_in_list(o_b_angel_charm, owner.buffs)
    Sacred_Damage = 9
else
    Unholy_Damage = 9
can_reflect = 1
