event_inherited()
var _amogus = 1
if (instance_exists(o_pass_skill_ndarkness) && o_pass_skill_ndarkness.is_open)
    _amogus++
if (global.language == 1)
{
    if (_amogus == 1)
        info = "- Максимальное количество призываемой нежити: 1"
}
else if (global.language == 3)
{
    if (_amogus == 1)
        info = "- 召唤亡灵的最大数量：1"
}
else if (_amogus == 1)
    info = "- Max number of summoned Undeads: 1"
