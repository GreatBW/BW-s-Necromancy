event_inherited()
skill = "Wraith_Binding"
if (global.language == 1)
    info = "Связанные атрибуты: Уровень"
else if (global.language == 3)
    info = "影响因素：等级"
else
    info = "Modified by: Level"
scr_skill_atr()
can_learn = 1
ignore_interact = 1
filter = gml_Script_scr_barrier_filter
