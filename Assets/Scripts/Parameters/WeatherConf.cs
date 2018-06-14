using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeatherConf : ParameterConfigurator {

	public GameObject rain;
	public GameObject snow;
	public GameObject dust;
	public GameObject unrealistic;

	public override void configure(string value){

		int val = 10;
		string output = "";
		if(int.TryParse (value,out val)){
			if (val == 0) {
				output = "Clear";
				//activateWeather (rain);
			} else if (val == 1) {
				output = "Rain";
				activateWeather (rain);
			}else if (val == 2) {
				output = "Snow";
				activateWeather (snow);
			}else if (val == 3) {
				output = "Dust";
				activateWeather (dust);
			}else if (val == 4) {
				output = "Fog";
				activateFog ();
			}else if (val == -1) {
				output = "Unrealistic";
				activateWeather (unrealistic);
			}
		}
		Debug.Log (name+": " + value+" - "+output);
	}

	public void activateWeather(GameObject w){
		w.SetActive (true);
	}

	public void activateFog(){
		RenderSettings.fog = true;
	}

}