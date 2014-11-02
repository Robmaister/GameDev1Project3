Shader "Custom/InteractionShader" {
	Properties {
		_Color ("Base Color", Color) = (1, 1, 1, 1)
		_MainTex ("Base (RGB)", 2D) = "white" {}
	}
	SubShader {
		Tags { "RenderType"="Opaque" }
		LOD 200
		
		CGPROGRAM
		#pragma surface surf Lambert

		
		sampler2D _MainTex;
		float4 _Color;

		struct Input {
			float2 uv_MainTex;
			float4 uv_Color;
		};

		void surf (Input IN, inout SurfaceOutput o) {
			half4 c = tex2D (_MainTex, IN.uv_MainTex);
			o.Albedo = c.rgb * _Color.rgb * (0.5 * sin(_Time.x * 100) + 1);
			o.Alpha = c.a * _Color.a;
		}
		ENDCG
	} 
	FallBack "Diffuse"
}
