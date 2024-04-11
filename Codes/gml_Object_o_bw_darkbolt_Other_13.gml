if (instance_exists(o_pass_skill_unholymind) && o_pass_skill_unholymind.is_open)
{
    with (o_Dead_March)
        scr_temp_effect_update(object_index, id, "Unholy_Resistance", -33, 3, 3)
}
event_inherited()
