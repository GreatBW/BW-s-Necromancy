event_inherited()
xx = 0
button = "4"
skill = "Bw_Bolt"
scr_skill_atr(8)
can_learn = 1
if (global.language == 1)
    info = "Связанные атрибуты: Сила магии, Восприятие"
else
    info = "Modified by: Magic Power, Perception"
ignore_interact = 1
filter = gml_Script_scr_barrier_filter
is_missile = 1
