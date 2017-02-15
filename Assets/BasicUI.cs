using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class BasicUI:MonoBehaviour{
	void OnGUI(){
		if(GUI.Button(new Rect(10,10,40,20),"Test"))
			Debug.Log("Test button");
	}
}