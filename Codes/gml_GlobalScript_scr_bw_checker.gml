function scr_bw_checker(argument0) //gml_Script_scr_bw_checker
{
    if (!__is_undefined(argument0))
    {
        if (argument0.faction_id == "Servant")
            instance_create(x, y, o_res_buff_creator)
    }
}

