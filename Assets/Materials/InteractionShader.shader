Shader "Custom/InteractionShader" {
	Properties {
		_HoverStartTime ("Hover Start Time", Float) = 0
		[MaterialToggle] _IsHover ("Is Hovering", Float) = 0
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
		float _IsHover;
		float _HoverStartTime;

		struct Input {
			float2 uv_MainTex;
			float4 uv_Color;
		};

		void surf (Input IN, inout SurfaceOutput o) {
			half4 c = tex2D (_MainTex, IN.uv_MainTex);
			if (_IsHover > 0)
			{
				float time = (0.75 * sin((_Time.y - _HoverStartTime) * 5) + 2.5);
				o.Albedo = c.rgb * _Color.rgb * time;
			}
			else
				o.Albedo = c.rgb * _Color.rgb;
			o.Alpha = c.a * _Color.a;
		}
		ENDCG
	} 
	FallBack "Diffuse"
}
