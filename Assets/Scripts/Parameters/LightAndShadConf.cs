using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightAndShadConf : ParameterConfigurator {

	public override void configure(string value){

		int val = 10;
		string output = "";
		if(int.TryParse (value,out val)){
			if (val == 0)
				output = "Ambient Light and No Shading";
			else if (val == 1)
				output = "Directional Light (Sun) and Realistic Shading";
			else if (val == 2)
				output = "Spot Light (Flashlight) attached to viewer and Realistic Shading";
		}

		Debug.Log (name+": " + value+" - "+output);

	}
}
