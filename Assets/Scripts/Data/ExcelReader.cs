using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExcelReader: DataReader  {

	private ArrayList data;
	private string[] parametersNames;
	private ParametersManager pm;

	public ExcelReader(ParametersManager p){
		pm = p;
		data = new ArrayList ();
		readFile ();
	}

	public void readFile(){
		TextAsset datos = Resources.Load<TextAsset> ("g5Data");
		string[] lines = datos.text.Split (new char[]{ '\n'});

		parametersNames = lines [0].Split (new char[]{ ';' });

		for (int i = 1; i < lines.Length - 1; i++) {
			data.Add(lines[i].Split(new char[]{';'}));
		}
	}

	public void showRandom(){
		int r = Random.Range (0, data.Count);
		string[] chosen = data [r]as string[];
		for (int i = 0; i < parametersNames.Length; i++) {
			Debug.Log (parametersNames [i]);
			Debug.Log (chosen [i] + "\n");
		}
	}

	public override void getRandomSample(){
		Dictionary<string,string> row = new Dictionary<string,string> ();
		int r = Random.Range (0, data.Count);
		string[] values = data [r]as string[];
		for (int i = 0; i < parametersNames.Length; i++) {
			row.Add (parametersNames [i], values [i]);
		}
		pm.getResponse (row);
	}


}
