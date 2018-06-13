using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AntialiasingConf : ParameterConfigurator {



	public override void configure(string value){

		int val = 0;

		if(int.TryParse (value,out val)){
			if (val == 1)
				val = 2;
			else if (val == 2)
				val = 4;
			else if (val == 3)
				val = 8;
		}

		QualitySettings.antiAliasing = val;

		Debug.Log ("Antialiasing: " + value+" - "+"Value:"+val+"x MultiSampling");

	}
}