using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReflectionsConf : ParameterConfigurator {

	public override void configure(string value){

		int val = 10;
		string output = "";
		if(int.TryParse (value,out val)){
			if (val == 0)
				output = "No";
			else if (val == 1)
				output = "Yes";
		}

		Debug.Log (name+": " + value+" - "+output);

		//turn on
		//shapes.GetComponent().material.DisableKeyword("_SPECULARHIGHLIGHTS_OFF");
		//shapes.GetComponent().material.SetFloat("_SpecularHighlights",1f);

		//turn off
		//shapes.GetComponent().material.EnableKeyword("_SPECULARHIGHLIGHTS_OFF");
		//shapes.GetComponent().material.SetFloat("_SpecularHighlights",0f);

		//ver tambien
		//thisRenderer.material.EnableKeyword("_GLOSSYREFLECTIONS_OFF");

	}
}

