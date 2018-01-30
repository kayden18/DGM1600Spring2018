using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyRing : MonoBehaviour {

	public bool doorLock = true;
	void OnMouseDown()
	{
		if(doorLock == false){
			print("Door is locked.");
		}
		if(doorLock == true)
		{
			print("Door is unlocked");
		}
	}
}
