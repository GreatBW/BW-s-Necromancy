event_inherited()
scr_param("Zombie Sword Guard")
isLootDropped = 0
corpse_type = o_empty
head_sprite = asset_get_index(string((sprite_get_name(sprite_index) + "_head")))
scr_create_skill_map("Strangling_Grasp")
scr_create_skill_passive(o_enemy_pass_zombie)
scr_create_skill_passive(o_enemy_pass_putrid_stench)
