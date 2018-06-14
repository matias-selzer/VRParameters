using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadRotationConf : ParameterConfigurator {

	public override void configure(string value){
		int val = 10;
		string output = "";
		if(int.TryParse (value,out val)){
			if (val == 1) {
				output = "Joystick";
			} else if (val == 2) {
				output = "HeadMovements";
			}
		}
		Debug.Log (name+": " + value+" - "+output);
	}
		
}