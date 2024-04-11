if (alarm[0] < 0)
{
    var unit = ((image_index / image_number) * image_index) > 3
    draw_sprite_ext(unit_sprite, 0, x, y, image_xscale, image_yscale, image_angle, image_blend, unit)
    if global.GFX
    {
        __shader_set(12)
        shader_set_uniform_f(u1, c1, c2, c3)
    }
    draw_sprite_ext(unit_sprite, 0, x, y, image_xscale, image_yscale, image_angle, image_blend, (((6 * sign(unit)) / (image_index + 1)) - unit))
    __shader_reset()
    draw_self()
    draw_sprite_ext(s_light, 0, x, y, (2 * sin((image_index / 3))), (2 * sin((image_index / 3))), 0, c_green, 0.25)
}
