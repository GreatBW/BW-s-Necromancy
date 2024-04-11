event_inherited()
if (attack_text != "block" && attack_text != "dodge")
{
    if (!instance_exists(o_soul_destroyer))
        instance_create(x, y, o_soul_destroyer)
}
