var LVL = 2
var damage = 0
if scr_instance_exists_in_list(o_b_angel_charm, o_player.buffs)
    Sacred_Damage = 13
else
    Unholy_Damage = 13
damage = scr_skill_damage()
steal = (damage * 0.66)
alarm[1] = 30
