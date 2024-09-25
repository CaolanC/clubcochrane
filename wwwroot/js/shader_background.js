async function loadShaderFile(url) {
    const response = await fetch(url);
    return await response.text();
}

function createShader(gl, type, source) {
    const shader = gl.createShader(type);
    gl.shaderSource(shader, source);
    gl.compileShader(shader);

    if (!gl.getShaderParameter(shader, gl.COMPILE_STATUS)) {
        console.error('Shader compile error:', gl.getShaderInfoLog(shader));
        gl.deleteShader();
        return null;
    }
    return shader;
}

async function initWebGL() {
    const container = document.body;
    // const container = body;
    // const container = document.getElementsByClassName('shader-body')[0];
    const canvas = document.createElement('canvas');
    container.appendChild(canvas);

    const gl = canvas.getContext('webgl');
    if (!gl) {
        console.error('WebGL not supported');
        return;
    }

    canvas.width = container.offsetWidth;
    canvas.height = container.offsetHeight;

    const vertexShaderSource = await loadShaderFile('/js/shaders/container-vertex.glsl');
    const fragmentShaderSource = await loadShaderFile('/js/shaders/container-fragment.glsl');

    const vertexShader = createShader(gl, gl.VERTEX_SHADER, vertexShaderSource);
    const fragmentShader = createShader(gl, gl.FRAGMENT_SHADER, fragmentShaderSource);

    const program = gl.createProgram();
    gl.attachShader(program, vertexShader);
    gl.attachShader(program, fragmentShader);
    gl.linkProgram(program);

    if (!gl.getProgramParameter(program, gl.LINK_STATUS)) {
        console.error('Program link error:', gl.getProgramInfoLog(program));
        return;
    }

    // Get uniform locations
    const timeUniformLocation = gl.getUniformLocation(program, "time");
    const resolutionUniformLocation = gl.getUniformLocation(program, "resolution");

    // Define the position data for the quad that will cover the canvas
    const positionBuffer = gl.createBuffer();
    gl.bindBuffer(gl.ARRAY_BUFFER, positionBuffer);
    const positions = [
        -1, -1,
         1, -1,
        -1,  1,
         1, -1,
         1,  1,
        -1,  1
    ];
    gl.bufferData(gl.ARRAY_BUFFER, new Float32Array(positions), gl.STATIC_DRAW);

    // Set the WebGL viewport
    gl.viewport(0, 0, canvas.width, canvas.height);

    // Function to render the scene
    function render(time) {
        // Use the WebGL program
        gl.useProgram(program);

        // Set the resolution and time uniforms
        gl.uniform2f(resolutionUniformLocation, canvas.width, canvas.height);
        gl.uniform1f(timeUniformLocation, time * 0.001); // Time in seconds

        // Bind the position buffer and enable the position attribute
        const positionAttributeLocation = gl.getAttribLocation(program, "position");
        gl.enableVertexAttribArray(positionAttributeLocation);
        gl.bindBuffer(gl.ARRAY_BUFFER, positionBuffer);
        gl.vertexAttribPointer(positionAttributeLocation, 2, gl.FLOAT, false, 0, 0);

        // Clear the canvas and draw the background quad
        gl.clear(gl.COLOR_BUFFER_BIT);
        gl.drawArrays(gl.TRIANGLES, 0, 6);

        // Request the next frame
        requestAnimationFrame(render);
    }

    requestAnimationFrame(render);
}

// window.onload = initWebGL;

