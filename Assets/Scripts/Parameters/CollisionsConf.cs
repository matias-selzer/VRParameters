using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionsConf : ParameterConfigurator {

	public override void configure(string value){

		int val = 10;
		string output = "";
		if(int.TryParse (value,out val)){
			if (val == 0) {
				output = "No";
				deactivateCollisions ();
			} else if (val == 1) {
				output = "Yes";
			}
		}
		Debug.Log (name+": " + value+" - "+output);
	}

	public void deactivateCollisions(){
		GameObject[] colliders = GameObject.FindGameObjectsWithTag ("CollisionRemover");
		foreach (GameObject c in colliders) {
			foreach(Collider col in c.GetComponentsInChildren<Collider>())
				col.enabled = false;
		}
	}



}