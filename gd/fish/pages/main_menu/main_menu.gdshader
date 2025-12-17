shader_type canvas_item;

uniform float radius : hint_range(0.0, 1.5) = 1.5;
uniform vec2 center = vec2(0.5, 0.5);

void fragment() {
    vec2 uv = SCREEN_UV;
    vec2 aspect = vec2(SCREEN_PIXEL_SIZE.y / SCREEN_PIXEL_SIZE.x, 1.0);
    vec2 centered_uv = (uv - center) * aspect;
    float dist = length(centered_uv);
    float mask = step(radius, dist);
    COLOR = vec4(1, 1, 1, mask);
}
