event_inherited()
if (stage < 1)
    stage = 1
stage = min(stage, max_stage)
if (stage != previousStage)
{
    textTransform = 0
    previousStage = stage
}
ds_map_clear(data)
with (target)
{
    if (!(scr_instance_exists_in_list(o_b_servemaster, buffs)))
    {
        ds_map_add(other.data, "Fortitude", (-9 * other.stage))
        ds_map_add(other.data, "Magic_Resistance", (-9 * other.stage))
        ds_map_add(other.data, "Nature_Resistance", (-7 * other.stage))
        ds_map_add(other.data, "max_hp", ((-0.06 * max_hp) * other.stage))
        ds_map_add(other.data, "Damage_Received", (4 * other.stage))
        repeat other.stage
            scr_injuryChange(id, scr_choose_body_part(), -0.5)
        scr_atr_calc(id)
    }
}
