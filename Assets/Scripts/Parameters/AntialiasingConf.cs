using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class AntialiasingConf : ParameterConfigurator {



	public override void configure(string value){

		int val = 0;

		if(int.TryParse (value,out val)){
			if (val == 1)
				val = 2;
			else if (val == 2)
				val = 4;
			else if (val == 3)
				val = 8;
		}

        // val = 16;

        //asumamos que esto funciona 
        //SOLO USAR 4 O NADA
        QualitySettings.antiAliasing = val;

        //esto pasarlo a un ResolutionConf
        //estudiar bien el tema de la resolución
        Debug.Log("h init "+XRSettings.eyeTextureHeight);
        Debug.Log("w init " + XRSettings.eyeTextureWidth);
       // XRSettings.eyeTextureResolutionScale = 2f;
        Debug.Log("h final " + XRSettings.eyeTextureHeight);
        Debug.Log("w final " + XRSettings.eyeTextureWidth);

        Debug.Log ("Antialiasing: " + value+" - "+"Value:"+val+"x MultiSampling");

	}
}