using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenResolution : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Screen.SetResolution(12, 12, false);
		Resolution[] resolutions = Screen.resolutions;

		Debug.Log(resolutions.Length.ToString());
		foreach(Resolution res in resolutions)
		{
			Debug.Log(res.width.ToString() + " x " + res.height.ToString());
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
