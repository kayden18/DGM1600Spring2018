﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyRing1 : MonoBehaviour {

	public bool doorLock = true;
	public bool windowLock = true;
	void OnMouseDown()
	{
		if(doorLock == false){
			print("Door is locked.");
		}
		if(doorLock == true)
		{
			print("Door is unlocked.");
		}
		if(windowLock == false)
		{
			print("Window is locked.");
		}
		if(windowLock == true)
		{
			print("Window is unlocked.");
		}
	}
}
//else statements require if statements
// = assign value
// == check equality
// != check for unequality