using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightColorConf : ParameterConfigurator {

	public Color white, yellowSun, red, green, blue;

	public override void configure(string value){

		int val = 10;
		string output = "";
		if(int.TryParse (value,out val)){
			if (val == 0) {
				output = "White";
				changeLightColor (Color.white);
			} else if (val == 1) {
				output = "Yellow (Sun Realistic)";
				changeLightColor (yellowSun);
			} else if (val == 2) {
				output = "Red";
				changeLightColor (red);
			} else if (val == 3) {
				changeLightColor (blue);
				output = "Blue";
			} else if (val == 4) {
				output = "Green";
				changeLightColor (green);
			}
		}
		Debug.Log (name+": " + value+" - "+output);
	}

	public void changeLightColor(Color c){
		GameObject[] lights = GameObject.FindGameObjectsWithTag ("Light");
		for (int i = 0; i < lights.Length; i++) {
			lights [i].GetComponent<Light> ().color=c;
		}
		GameObject.FindGameObjectWithTag ("Flashlight").GetComponent<Light> ().color=c;
		float intensity = RenderSettings.ambientLight.r;
		Color ambientColor = new Color (c.r * intensity, c.g * intensity, c.b * intensity);
		RenderSettings.ambientLight = ambientColor;
	}
}
