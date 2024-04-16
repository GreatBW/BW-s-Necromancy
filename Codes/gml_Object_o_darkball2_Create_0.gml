event_inherited()
scr_light_off()
scr_set_lt()
image_speed = 0.5
speed = 10
scr_audio_play_at(choose(snd_arcane_casting_1, snd_arcane_casting_2))
scr_audio_play_at(snd_arcane_bolt_casting_1)
scr_damage_init()
owner = o_player
if scr_instance_exists_in_list(o_b_angel_charm, owner.buffs)
    Sacred_Damage = 9
else
    Unholy_Damage = 9
can_reflect = 1
