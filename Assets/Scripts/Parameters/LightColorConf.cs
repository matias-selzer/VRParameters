using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightColorConf : ParameterConfigurator {

	public override void configure(string value){

		int val = 10;
		string output = "";
		if(int.TryParse (value,out val)){
			if (val == 0)
				output = "White";
			else if (val == 1)
				output = "Yellow (Sun Realistic)";
			else if (val == 2)
				output = "Red";
			else if (val == 3)
				output = "Blue";
			else if (val == 4)
				output = "Green";
		}

		Debug.Log (name+": " + value+" - "+output);

	}
}
