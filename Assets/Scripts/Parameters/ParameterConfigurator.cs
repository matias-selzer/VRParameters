using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ParameterConfigurator : MonoBehaviour {

	public string name;


	public abstract void configure (string value);
}
