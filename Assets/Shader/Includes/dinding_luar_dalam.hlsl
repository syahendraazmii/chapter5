#include <Packages/com.blendernodesgraph.core/Editor/Includes/Importers.hlsl>

void dinding_luar_dalam_float(float3 _POS, float3 _PVS, float3 _PWS, float3 _NOS, float3 _NVS, float3 _NWS, float3 _NTS, float3 _TWS, float3 _BTWS, float3 _UV, float3 _SP, float3 _VVS, float3 _VWS, float2 name, Texture2D image_51568, Texture2D image_51574, Texture2D image_51570, Texture2D image_51572, out float4 Color, out float3 Normal, out float Smoothness, out float4 Emission, out float AmbientOcculusion, out float Metallic, out float4 Specular)
{
	
	float4 _ImageTexture_51574 = node_image_texture(image_51574, name, 0);
	float4 _ImageTexture_51570 = node_image_texture(image_51570, name, 0);
	float4 _NormalMap_51564; node_normal_map(_ImageTexture_51570, 1, _NormalMap_51564);
	float4 _ImageTexture_51572 = node_image_texture(image_51572, name, 0);
	float4 _ImageTexture_51568 = node_image_texture(image_51568, name, 0);

	Color = _ImageTexture_51574;
	Normal = _NormalMap_51564;
	Smoothness = _ImageTexture_51572;
	Emission = float4(0.0, 0.0, 0.0, 0.0);
	AmbientOcculusion = 0.0;
	Metallic = 0.0;
	Specular = _ImageTexture_51568;
}