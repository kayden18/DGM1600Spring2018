using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForLoop : MonoBehaviour {

	public string[] Keys;

	void Start () {
		for (int i = 0; i < Keys.Length; i++)
		{
			if (Keys[i] == "Add Ammo")
			{
				print(Keys[i]);
			}
		}
	}

	private void Update()
	{
		if(Input.GetKeyDown(KeyCode.Space)){
			Run();
		}
	}
	
	void Run(){
		//do work
	}
}
//for is a key word for forloops
//forloops contain an declaration, ifstatement, and a modifier
//forloops run until the ifstatement is false
//void function can be called by any monobehaviour function