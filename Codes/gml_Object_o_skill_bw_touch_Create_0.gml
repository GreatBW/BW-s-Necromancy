event_inherited()
skill = "Bw_Touch"
if (global.language == 1)
    info = "Связанные атрибуты: Сила магии"
else if (global.language == 3)
    info = "影响因素：法力"
else
    info = "Modified by: Magic Power"
scr_skill_atr()
can_learn = 1
ignore_interact = 1
target_group = o_enemy
startcast_sprite_tag = "s_deathtouch_"
