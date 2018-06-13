using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DBReaderService : MonoBehaviour {

	public string url="http://192.168.11.8:3000/environment";
	private string response="";
	private DBReader dbr;

	public IEnumerator LoadRow()
	{
		WWW www = new WWW(url);
		yield return www;
		//Debug.Log (www.text);
		dbr.getResponse(www.text);
	}

	public void getDBRow(DBReader db){
		dbr = db;
		StartCoroutine (LoadRow ());
	}



}
