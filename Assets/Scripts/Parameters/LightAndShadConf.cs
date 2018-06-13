using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//debe ejecutarse despues de LightIntensityConf
//la escena debe tener todas las luces activadas, excepto la flashlight

public class LightAndShadConf : ParameterConfigurator {

	private GameObject[] lights;
	private GameObject flashlight;

	public override void configure(string value){

		int val = 10;
		string output = "";
		if(int.TryParse (value,out val)){
			if (val == 0) {
				output = "Ambient Light and No Shading";
				hideSceneLights ();
			} else if (val == 1) {
				output = "Directional Light (Sun) and Realistic Shading";
				hideAmbientLight ();
			}
			else if (val == 2) {
				output = "Spot Light (Flashlight) attached to viewer and Realistic Shading";
				hideSceneLights ();
				hideAmbientLight ();
				activateFlashlight ();
			}
		}
		Debug.Log (name+": " + value+" - "+output);
	}
		

	public void hideAmbientLight(){
		RenderSettings.ambientLight = Color.black;
	}

	public void hideSceneLights(){
		GameObject[] lights = GameObject.FindGameObjectsWithTag ("Light");
		for (int i = 0; i < lights.Length; i++) {
			lights [i].GetComponent<Light> ().enabled = false;
		}
		GameObject.FindGameObjectWithTag ("Flashlight").GetComponent<Light> ().enabled=false;
	}

	public void activateFlashlight(){
		GameObject.FindGameObjectWithTag ("Flashlight").GetComponent<Light> ().enabled = true;
	}
}
