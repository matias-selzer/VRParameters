using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VirtualAvatarConf : ParameterConfigurator {

	public override void configure(string value){

		int val = 10;
		string output = "";
		if(int.TryParse (value,out val)){
			if (val == 0) {
				output = "No";
				deactivateAvatar ();
			} else if (val == 1) {
				output = "Yes-Static";
			}
		}

		Debug.Log (name+": " + value+" - "+output);
	}

	public void deactivateAvatar(){
		GameObject[] avatars = GameObject.FindGameObjectsWithTag ("Avatar");
		for (int i = 0; i < avatars.Length; i++) {
			avatars [i].SetActive(false);
		}
	}
}