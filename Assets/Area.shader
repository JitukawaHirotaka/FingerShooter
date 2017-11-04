Shader "Custom/Area" {
	Properties {
		_InsideColor("InsideColor", Color) = (1,1,1,1)
		_OutsideColor("OutsideColor", Color) = (1,1,1,1)
	}
	SubShader {
		Tags { "RenderType"="Opaque" }
		LOD 200
		
		CGPROGRAM
		#pragma surface surf Standard fullforwardshadows

		#pragma target 3.0

		struct Input {
			float2 uv_MainTex;
		};

		fixed4 _InsideColor;
		fixed4 _OutsideColor;

		UNITY_INSTANCING_CBUFFER_START(Props)
		UNITY_INSTANCING_CBUFFER_END

		void surf (Input IN, inout SurfaceOutputStandard o) {
			fixed4 color = _InsideColor;
			o.Albedo = color.rgb;
			o.Alpha = color.a;
		}
		ENDCG
	}
	FallBack "Diffuse"
}
