using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParametersManager : MonoBehaviour {

	private ParameterConfigurator[] paraChildren;
	private DataReader reader;

	// Use this for initialization
	void Start () {
		initialize ();
		establishConfiguration ();
	}

	public void initialize(){
		reader = new ExcelReader ();
		paraChildren = GetComponents<ParameterConfigurator> ();
	}
	
	public void establishConfiguration(){
		Dictionary<string,string> sample= reader.getRandomSample ();
		for (int i = 0; i < paraChildren.Length; i++) {
			ParameterConfigurator param = paraChildren [i] as ParameterConfigurator;
			param.configure (sample [param.name]);
		}
	}
}
