using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelsQualityConf : ParameterConfigurator {


	public override void configure(string value){

		int val = 10;
		string output = "";
		if(int.TryParse (value,out val)){
			if (val == 1) {
				output = "Low Poly";
				hideHighPolyObjects ();
			} else if (val == 2) {
				output = "High Poly";
				hideLowPolyObjects ();
			}
		}

		Debug.Log (name+": " + value+" - "+output);

	}

	public void hideLowPolyObjects(){
		GameObject[] lights = GameObject.FindGameObjectsWithTag ("LowPoly");
		foreach (GameObject go in lights) {
			go.SetActive (false);
		}
	}

	public void hideHighPolyObjects(){
		GameObject[] lights = GameObject.FindGameObjectsWithTag ("HighPoly");
		foreach (GameObject go in lights) {
			go.SetActive (false);
		}
	}
}
