using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyboxConf : ParameterConfigurator {

	public Material day;
	public Material sunset;
	public Material night;
	public Material unrealistic;

	public override void configure(string value){

		int val = 10;
		string output = "";
		if(int.TryParse (value,out val)){
			if (val == 0) {
				output = "Day";
				activateSkybox (day);
			} else if (val == 1) {
				output = "Sunset";
				activateSkybox (sunset);
			}else if (val == 2) {
				output = "Night";
				activateSkybox (night);
			}else if (val == -1) {
				output = "Unrealistic";
				activateSkybox (unrealistic);
			}
		}
		Debug.Log (name+": " + value+" - "+output);
	}

	public void activateSkybox(Material mat){
		RenderSettings.skybox = mat;
	}

}