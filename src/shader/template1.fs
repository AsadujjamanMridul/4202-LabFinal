#version 330 core
out vec4 FragColor;

in vec3 ourColor;
in vec2 TexCoord;

// texture samplers
uniform sampler2D texture1;
uniform sampler2D texture2;
uniform sampler2D texture3;

// Sent via a uniform variable to the shader
uniform vec3 customColor;

// Defined in shader
vec3 definedColor = vec3(1.0, 0.0, 0.0);


void main()
{
	// TEXTURE
	
	// 1 texture
	// FragColor = texture(texture1, TexCoord);

	// 2 textures
	// FragColor = mix(texture(texture1, TexCoord), texture(texture2, TexCoord), 0.2);
	
	// 3 textures
	FragColor = mix(texture(texture1, TexCoord), texture(texture2, TexCoord), texture(texture3, TexCoord));
	

	// COLOR
	// FragColor = vec4(ourColor, 1.0f);
	// FragColor = vec4(customColor, 1.0f);
	// FragColor = vec4(definedColor, 1.0f);
}