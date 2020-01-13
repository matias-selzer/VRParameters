using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ParametersManager : MonoBehaviour {

	private ParameterConfigurator[] paraChildren;
	private DataReader reader;

	// Use this for initialization
	void Start () {
		initialize ();
		establishConfiguration ();
	}

	void Update(){
		if (Input.GetKeyDown (KeyCode.R)) {
			SceneManager.LoadScene (SceneManager.GetActiveScene().name);
		}
        
	}

	public void initialize(){
		reader = new ExcelReader (this);
		//reader = new DBReader (this);
		paraChildren = GetComponents<ParameterConfigurator> ();

	}
	
	public void establishConfiguration(){
		//Dictionary<string,string> sample= reader.getRandomSample ();
		reader.getRandomSample ();
	}

	public void getResponse(Dictionary<string,string> sample){
		for (int i = 0; i < paraChildren.Length; i++) {
			ParameterConfigurator param = paraChildren [i] as ParameterConfigurator;
			param.configure (sample [param.name]);
		}
	}


}
