using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DBReaderService : MonoBehaviour {

	//public string url="http://192.168.11.8:3000/environment";
	private string url="https://blooming-springs-30536.herokuapp.com/environment";
	private string response="";
	private DBReader dbr;

	public IEnumerator LoadRow()
	{
		WWW www = new WWW(url);
		yield return www;
		dbr.getResponse(www.text);
	}

	public void getDBRow(DBReader db){
		dbr = db;
		StartCoroutine (LoadRow ());
	}



}
