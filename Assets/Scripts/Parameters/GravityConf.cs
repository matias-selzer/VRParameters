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
			} else if (val == 1) {
				output = "Yes";
				activateGravity ();
			}
		}
		Debug.Log (name+": " + value+" - "+output);
	}

	public void activateGravity(){
		Floater[] floaters = GameObject.FindObjectsOfType<Floater> ();
		foreach (Floater f in floaters) {
				f.enabled = false;
		}
	}
}