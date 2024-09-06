event_inherited()
if (global.language == 1)
    name = "Приказ - следовать!"
else if (global.language == 3)
    name = "友军 - 跟随！"
else
    name = "Allies - Follow!"
if (global.language == 1)
    desc = "Приказывает всем союзникам избегать драк и следовать за персонажем."
else if (global.language == 3)
    desc = "命令所有盟友避免战斗并跟随角色。"
else
    desc = "Commands all of the allies to avoid fights and follow character."
hoverOffsetY = -12
conditions = 0
info = 0
