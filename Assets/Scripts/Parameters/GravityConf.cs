using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityConf : ParameterConfigurator {

	public override void configure(string value){

		int val = 10;
		string output = "";
		if(int.TryParse (value,out val)){
			if (val == 0) {
				output = "No";
				deactivateGravity ();
			} else if (val == 1) {
				output = "Yes";
			}
		}
		Debug.Log (name+": " + value+" - "+output);
	}

	public void deactivateGravity(){
		Floater[] floaters = GameObject.FindObjectsOfType<Floater> ();
		foreach (Floater f in floaters) {
			f.setActivation ();
		}
	}


}