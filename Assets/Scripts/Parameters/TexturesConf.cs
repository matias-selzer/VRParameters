using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TexturesConf : ParameterConfigurator {



	public override void configure(string value){

		int val = 10;
		string output = "";
		if(int.TryParse (value,out val)){
			if (val == -1)
				output = "unrealistic";
			else if (val == 0)
				output = "no textures";
			else if (val == 1)
				output = "realistic";
		}

		Debug.Log (name+": " + value+" - "+output);

	}
}
