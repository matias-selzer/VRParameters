using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//debe ejecutarse antes que lightAndShadowConf

public class LightIntensityConf : ParameterConfigurator {

	public override void configure(string value){

		int val = 10;
		string output = "";

		if(int.TryParse (value,out val)){
			if (val == 1) {
				output = "Low";
				configureIntensity (0.4f);
			} else if (val == 2) {
				output = "Medium";
				configureIntensity (0.75f);
			} else if (val == 3) {
				output = "High";
				configureIntensity (1);
			}
		}
		Debug.Log (name+": " + value+" - "+output);
	}

	public void configureIntensity(float intensity){
		GameObject[] lights = GameObject.FindGameObjectsWithTag ("Light");
		for (int i = 0; i < lights.Length; i++) {
			lights [i].GetComponent<Light> ().intensity = intensity;
		}
		GameObject.FindGameObjectWithTag ("Flashlight").GetComponent<Light> ().intensity = intensity*3;
		RenderSettings.ambientLight = new Color (intensity,intensity,intensity);
	}
}
