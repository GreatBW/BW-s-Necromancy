event_inherited()
scr_set_lt()
with (instance_create_depth(x, y, (depth + 15), o_curse_bg))
    image_blend = c_teal
blend = make_colour_rgb(191, 0, 0)
dx = 13
dy = 13
f_duration = 13
scr_audio_play_at(choose(snd_debuff_weakness_apply_st_1, snd_debuff_weakness_apply_st_2))
scr_damage_init()
