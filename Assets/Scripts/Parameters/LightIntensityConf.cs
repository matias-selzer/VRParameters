using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightIntensityConf : ParameterConfigurator {

	public override void configure(string value){

		int val = 10;
		string output = "";
		if(int.TryParse (value,out val)){
			if (val == 1)
				output = "Low";
			else if (val == 2)
				output = "Medium";
			else if (val == 3)
				output = "High";
		}

		Debug.Log (name+": " + value+" - "+output);

	}
}
