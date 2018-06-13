using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelsQualityConf : ParameterConfigurator {


	public override void configure(string value){

		int val = 10;
		string output = "";
		if(int.TryParse (value,out val)){
			if (val == 1)
				output = "Low Poly";
			else if (val == 2)
				output = "High Poly";
		}

		Debug.Log (name+": " + value+" - "+output);

	}
}
