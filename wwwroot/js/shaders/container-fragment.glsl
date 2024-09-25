precision mediump float;
uniform float time;
uniform vec2 resolution;

void main() {
    vec2 uv = gl_FragCoord.xy / resolution.xy;

    // Generate a vec3 (3-component vector) for RGB colors
    vec3 color = 0.5 + 0.5 * cos(time + uv.xyx * vec3(1.0, 2.0, 3.0));

    // Output the color as a vec4 (RGBA) with full opacity
    if (gl_FragCoord.y < 100.0) {
        gl_FragColor = vec4(color, 1.0);
    }
}
