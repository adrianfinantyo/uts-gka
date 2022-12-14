Shader "Custom/Full Texture Shader For Backdrop" {
	Properties {
		_Color ("Color", Color) = (1,1,1,1)
		_MainTex ("Albedo (RGB)", 2D) = "white" {}
		_Glossiness ("Smoothness", Range(0,1)) = 0.5
		_Metallic ("Metallic", Range(0,1)) = 0.0
        [KeywordEnum(X, Y, Z)] _Faces ("Faces", Float) = 0
	}
	SubShader {
		Tags { "RenderType"="Opaque" }
		LOD 200
		
		CGPROGRAM
        #pragma shader_feature _FACES_X _FACES_Y _FACES_Z
		#pragma surface surf Standard fullforwardshadows vertex:vert
		#pragma target 3.0

		sampler2D _MainTex;

		struct Input {
			float2 cubeUV;
		};

		half _Glossiness;
		half _Metallic;
		fixed4 _Color;
		uniform float _xSize;
		uniform float _ySize;
		uniform float _zSize;

        void vert (inout appdata_full v, out Input o) {
			UNITY_INITIALIZE_OUTPUT(Input, o);
            #if defined(_FACES_X)
				v.color.y /= 10;
				v.color.z /= 4;
				o.cubeUV = v.color.yz * 255;
			#elif defined(_FACES_Y)
				v.color.x /= 18;
				v.color.z /= 4;
				o.cubeUV = v.color.xz * 255;
			#elif defined(_FACES_Z)
				v.color.x /= 18;
				v.color.y /= 10;
				o.cubeUV = v.color.xy * 255;
			#endif
		}

		void surf (Input IN, inout SurfaceOutputStandard o) {
			fixed4 c = tex2D(_MainTex, IN.cubeUV) * _Color;
			o.Albedo = c.rgb;
			o.Metallic = _Metallic;
			o.Smoothness = _Glossiness;
			o.Alpha = c.a;
		}
		ENDCG
	} 
	FallBack "Diffuse"
}