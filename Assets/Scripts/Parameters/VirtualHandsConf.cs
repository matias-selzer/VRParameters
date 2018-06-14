﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VirtualHandsConf : ParameterConfigurator {

	public override void configure(string value){

		int val = 10;
		string output = "";
		if(int.TryParse (value,out val)){
			if (val == 0) {
				output = "No";
			} else if (val == 1) {
				output = "Yes-Unrealistic";
			}
			else if (val == 2) {
				output = "Yes-Realistic";
			}
		}

		Debug.Log (name+": " + value+" - "+output);
	}


}