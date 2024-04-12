event_inherited()
if (global.language == 1)
    info = "Связанные атрибуты: Уровень"
else
    info = "Modified by: Level"
skill = "Bw_Resurrection"
xx = 33
button = "5"
scr_skill_atr()
can_learn = 1
target_group = o_corpse
damage_type = "Unholy_Damage"
class = "spell"
ignore_interact = 1
is_moving = 1
alarm[5] = 5
is_special = 0
filter = gml_Script_scr_barrier_filter
