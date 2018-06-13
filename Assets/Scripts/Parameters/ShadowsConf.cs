using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShadowsConf : ParameterConfigurator {



	public override void configure(string value){
		int val = 10;
		string output = "";
		if(int.TryParse (value,out val)){
			if (val == 0) {
				output = "No";
				setShadowStrengh (0);
			} else if (val == 1) {
				output = "Yes - Low Strengh";
				setShadowStrengh (0.5f);
			} else if (val == 2) {
				output = "Yes - High Strengh";
				setShadowStrengh (1);
			}
		}
		Debug.Log (name+": " + value+" - "+output);
	}

	public void setShadowStrengh(float strengh){
		GameObject[] lights = GameObject.FindGameObjectsWithTag ("Light");
		for (int i = 0; i < lights.Length; i++) {
			lights [i].GetComponent<Light> ().shadowStrength = strengh;
		}
		GameObject.FindGameObjectWithTag ("Flashlight").GetComponent<Light> ().shadowStrength = strengh;
	}
}
