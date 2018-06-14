using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlackScreen : MonoBehaviour {

	private bool hide;

	// Use this for initialization
	void Start () {
		Color c = GetComponent<Image> ().color;
		c.a =1;
		GetComponent<Image> ().color = c;
		show ();
	}
	
	// Update is called once per frame
	void Update () {
		if (hide) {
			Color c = GetComponent<Image> ().color;
			c.a -= 0.5f * Time.deltaTime;
			GetComponent<Image> ().color = c;
		}
	}

	public void show(){
		hide = true;
	}
}
