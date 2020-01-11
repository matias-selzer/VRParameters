using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StereopsisConf : ParameterConfigurator {



	public override void configure(string value){

		int val = 10;
		bool activate=false;
		if(int.TryParse (value,out val)){
			if (val == 0)
				activate = false;
			else if (val == 1)
				activate = true;
		}

        //real activate or deactivate stereopsis
        if (!activate)
        {
            Camera m_Camera = Camera.main;
            m_Camera.transform.localScale = Vector3.zero;
        }


        Debug.Log ("Stereopsis: " + value+" - "+"Activate:"+activate);
	}
}
