if (instance_exists(o_pass_skill_unholymind) && o_pass_skill_unholymind.is_open)
{
    with (o_Dead_March)
        scr_temp_effect_update(object_index, id, "Unholy_Resistance", (-Unholy_Resistance), 2, 1)
}
event_inherited()
