event_inherited()
if (faction_id == "Servant")
{
    with (instance_create(x, y, corpse_type))
    {
        if (!(object_is_ancestor(object_index, c_burning_crit_death)))
        {
            _sprite = other.corpse_sprite
            if (_sprite == -4)
            {
                _sprite = asset_get_index(string((sprite_get_name(other.default_sprite) + "_dead")))
                if (!sprite_exists(_sprite))
                    _sprite = asset_get_index(string((sprite_get_name(other.default_sprite) + "_corpse")))
            }
            rotten_sprite = asset_get_index(string((sprite_get_name(other.default_sprite) + "_dead_rotten")))
            if sprite_exists(rotten_sprite)
            {
                sprite_index = rotten_sprite
                can_resurrect = 0
            }
            is_rotten = 1
            sub_name = other.name
            image_index = other.corpse_image_index
            inside_particles = other.inside_particles
            drawdir = other.drawdir
            blood_ext = other.blood_ext
            blood_spr = other.blood_spr
            blood_part_ext = other.blood_part_ext
            blood_part_spr = other.blood_part_spr
            enemy_object_index = other.object_index
            enemy_default_sprite = other.default_sprite
        }
        size = other.size
        typeID = other.typeID
        Rotten_Meat_Scale = other.Rotten_Meat_Scale
        Fried_Meat_Scale = other.Fried_Meat_Scale
        Pelt_Durability = other.Pelt_Durability
        if (object_is_ancestor(object_index, o_corpse) || object_index == o_corpse)
        {
            ds_list_copy(loot_list_meat, other.loot_list_meat)
            ds_list_copy(loot_list_add, other.loot_list_add)
        }
        hide_type = other.hide_type
        image_xscale = other.image_xscale
        if (other.death_sound != -4 && scr_is_ground(x, y) != -1)
            scr_audio_play_at(other.death_sound)
        if (other.emo_death_sound != -4)
            scr_audio_play_at(other.emo_death_sound)
        other.corpse = id
        faction = other.faction
        last_attacker = other.last_attacker
        is_shoot = other.is_shoot
        unitParamName = other.unitParamName
    }
}
