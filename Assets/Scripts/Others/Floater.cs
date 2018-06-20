using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floater : MonoBehaviour {
	// User Inputs
	float degreesPerSecond = 15.0f;
	float amplitude = 0.5f;
	float frequency = 1f;
	private int rotX,rotY,rotZ;
	private float initialY;
	public bool activate;

	// Position Storage Variables
	Vector3 posOffset = new Vector3 ();
	Vector3 tempPos = new Vector3 ();

	// Use this for initialization
	void Start () {
		// Store the starting position & rotation of the object
		posOffset = transform.position;
		frequency = Random.Range (0.5f, 1.5f);
		amplitude = Random.Range (0.2f, 0.5f);
		degreesPerSecond = Random.Range (5.0f, 20.0f);
		rotX = Random.Range (0, 2);
		rotY = Random.Range (0, 2);
		rotZ = Random.Range (0, 2);
		initialY = transform.position.y;
		//activate = Random.Range (0, 10) < 2;
		activate = false;
	}

	// Update is called once per frame
	void Update () {
		if (activate) {
			// Spin object around Y-Axis
			transform.Rotate (new Vector3 (rotX * Time.deltaTime * degreesPerSecond, rotY * Time.deltaTime * degreesPerSecond, rotZ * Time.deltaTime * degreesPerSecond), Space.World);

			// Float up/down with a Sin()
			tempPos = posOffset;
			tempPos.y += Mathf.Sin (Time.fixedTime * Mathf.PI * frequency) * amplitude;
			tempPos.y += initialY;

			transform.position = tempPos;
		}
	}

	public void setActivation(){
		if (Random.Range (0, 10) < 2) {
			activate = true;
		}
	}


}
