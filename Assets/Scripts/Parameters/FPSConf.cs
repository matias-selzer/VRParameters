using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSConf : ParameterConfigurator {


	public override void configure(string value){

		int fps = 60;
		if(int.TryParse (value,out fps)){
			if (fps == 1)
				fps = 60;
			else if (fps == 2)
				fps = 30;
			else if (fps == 3)
				fps = 15;
			else if (fps == 4)
				fps = 8;
		}
		QualitySettings.vSyncCount = 0; 
		Application.targetFrameRate = fps;

		Debug.Log ("FPS: " + value+" - "+fps+" fps");
	}

}
