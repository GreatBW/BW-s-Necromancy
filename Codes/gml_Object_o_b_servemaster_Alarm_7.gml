with (target)
{
    is_neutral = 1
    loot_script = -4
    if (object_is_ancestor(object_index, o_animals) || object_is_ancestor(object_index, o_Carnivore) || object_is_ancestor(object_index, o_Herbivore) || object_is_ancestor(object_index, o_deer_w) || object_is_ancestor(object_index, o_saiga_w))
        loot_corpse = o_empty
}
if (check == 1)
    sprite_index = s_rec_resf
else if (check == 0)
    sprite_index = s_rec_resa
else if (check == 2)
    sprite_index = s_rec_rese
else if (check == 3)
    sprite_index = s_rec_resep
if instance_exists(o_player)
    alarm[6] = 1
