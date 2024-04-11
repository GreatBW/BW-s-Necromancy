event_inherited()
if instance_exists(o_player)
{
    if (o_player.MP < (o_player.max_mp * 0.1))
        return instance_destroy();
}
