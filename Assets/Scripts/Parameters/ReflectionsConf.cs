using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReflectionsConf : ParameterConfigurator {

	public override void configure(string value){

		int val = 10;
		string output = "";
		if(int.TryParse (value,out val)){
			if (val == 0) {
				output = "No";
				deactivateReflections ();
			} else if (val == 1) {
				output = "Yes";
				activateReflections ();
			}
		}

		Debug.Log (name+": " + value+" - "+output);
	}

	public void activateReflections(){
		MeshRenderer[] objects = GameObject.FindObjectsOfType<MeshRenderer> ();
		foreach(MeshRenderer m in objects){
			m.material.DisableKeyword("_SPECULARHIGHLIGHTS_OFF");
			m.material.SetFloat("_SpecularHighlights",1f);
		}
	}

	public void deactivateReflections(){
		MeshRenderer[] objects = GameObject.FindObjectsOfType<MeshRenderer> ();
		foreach(MeshRenderer m in objects){
			m.material.EnableKeyword("_SPECULARHIGHLIGHTS_OFF");
			m.material.SetFloat("_SpecularHighlights",0f);
		}
	}
}

