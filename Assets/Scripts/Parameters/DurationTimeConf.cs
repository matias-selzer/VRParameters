using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DurationTimeConf : ParameterConfigurator {



	public override void configure(string value){

		int val = 10;
		if(int.TryParse (value,out val)){
			if (val == 1)
				val = 30;
			else if (val == 2)
				val = 45;
			else if (val == 3)
				val = 60;
			else if (val == 4)
				val = 90;
			else if (val == 5)
				val = 120;
		}

		Debug.Log (name+": " + value+" - "+val+" seconds");
	}
}

