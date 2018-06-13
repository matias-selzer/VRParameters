using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DBReader : DataReader {

	private ParametersManager pm;

	public DBReader(ParametersManager p){
		pm = p;
	}

	public override void  getRandomSample(){
		GameObject.Find("DBReaderService").GetComponent<DBReaderService>().getDBRow(this);

	}

	public void getResponse(string response){
		Dictionary<string,string> row = new Dictionary<string,string> ();

		response=response.Replace("\"","");
		response=response.Replace("{","");
		response=response.Replace("}","");
		string[] attr = response.Split (new char[]{',' });
		for (int i = 0; i < attr.Length; i++) {
			row.Add (attr [i].Split (new char[]{ ':' }) [0], attr [i].Split (new char[]{ ':' }) [1]);
		}
		pm.getResponse (row);
	}
		
}
