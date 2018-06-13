using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TexturesConf : ParameterConfigurator {

	public Material simple;
	public Material[] unrealistics;

	public override void configure(string value){
		int val = 10;
		string output = "";
		if(int.TryParse (value,out val)){
			if (val == -1) {
				output = "unrealistic";
				configureUnrealisticTextures ();
			} else if (val == 0) {
				output = "no textures";
				configureNoTextures ();
			} else if (val == 1) {
				output = "realistic";
				//configureRealisticTextures ();
			}
		}

		Debug.Log (name+": " + value+" - "+output);

	}

	public void configureUnrealisticTextures(){
		MeshRenderer[] objects = GameObject.FindObjectsOfType<MeshRenderer> ();
		foreach(MeshRenderer m in objects){
			Material mat=unrealistics[Random.Range(0,unrealistics.Length)];
			m.material = mat;
			foreach (Material mate in m.materials) {
				mate.mainTexture = mat.mainTexture;
			}
		}
	}
		
	public void configureNoTextures(){
		MeshRenderer[] objects = GameObject.FindObjectsOfType<MeshRenderer> ();
		foreach(MeshRenderer m in objects){
			m.material = simple;
			foreach (Material mate in m.materials) {
				mate.mainTexture = simple.mainTexture;
				mate.color=new Color (Random.Range (0, 100)/100.0f, Random.Range (0, 100)/100.0f, Random.Range (0, 100)/100.0f);
			}
			m.material.color = new Color (Random.Range (0, 100)/100.0f, Random.Range (0, 100)/100.0f, Random.Range (0, 100)/100.0f);
		}
	}
}
