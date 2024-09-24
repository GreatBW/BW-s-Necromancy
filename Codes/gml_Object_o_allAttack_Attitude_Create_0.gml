event_inherited()
if (global.language == 1)
    name = "Приказ - в атаку!"
else if (global.language == 3)
    name = "友军 - 进攻！"
else
    name = "Allies - Attack!"
if (global.language == 1)
    desc = "Приказывает всем союзникам атаковать ближайших противников."
else if (global.language == 3)
    desc = "命令所有盟友攻击附近的敌人。"
else
    desc = "Commands all of the allies to attack nearby enemies."
hoverOffsetY = -12
conditions = 0
info = 0
