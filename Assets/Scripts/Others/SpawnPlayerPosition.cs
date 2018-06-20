using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlayerPosition : MonoBehaviour {

	public Transform[] spawnPoints;

	// Use this for initialization
	void Start () {
		transform.position = spawnPoints [Random.Range (0, spawnPoints.Length)].position;
		transform.Rotate (new Vector3 (0, Random.Range (0, 360), 0));
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
