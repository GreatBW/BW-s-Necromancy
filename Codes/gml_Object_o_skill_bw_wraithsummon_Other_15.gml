if (!instance_exists(owner))
{
}
if (!is_fumble)
{
    if (class == "spell")
    {
        if (pointed == "Target Object" || pointed == "Target Ally")
        {
            if is_crit
                scr_actionsLog("castSpellTargetMiracle", [scr_id_get_name(owner), ((scr_actionsLogGetSymbol("openQuote") + name) + scr_actionsLogGetSymbol("closeQuote")), scr_id_get_name(target)])
            else
                scr_actionsLog("castSpellTarget", [scr_id_get_name(owner), ((scr_actionsLogGetSymbol("openQuote") + name) + scr_actionsLogGetSymbol("closeQuote")), scr_id_get_name(target)])
        }
        else if is_crit
            scr_actionsLog("castSpellMiracle", [scr_id_get_name(owner), ((scr_actionsLogGetSymbol("openQuote") + name) + scr_actionsLogGetSymbol("closeQuote"))])
        else
            scr_actionsLog("castSpell", [scr_id_get_name(owner), ((scr_actionsLogGetSymbol("openQuote") + name) + scr_actionsLogGetSymbol("closeQuote"))])
    }
    else if (pointed == "Target Object" || pointed == "Target Ally")
        scr_actionsLog("useSkillTarget", [scr_id_get_name(owner), ((scr_actionsLogGetSymbol("openQuote") + name) + scr_actionsLogGetSymbol("closeQuote")), scr_id_get_name(target)])
    else
        scr_actionsLog("useSkill", [scr_id_get_name(owner), ((scr_actionsLogGetSymbol("openQuote") + name) + scr_actionsLogGetSymbol("closeQuote"))])
}
else if instance_exists(o_bw_wraith_summoning)
{
    with (o_bw_wraith_summoning)
        is_fumble = 1
}
is_fumble = 0
is_crit = 0
target = -4
