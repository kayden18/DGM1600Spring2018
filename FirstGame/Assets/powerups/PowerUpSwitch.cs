using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpSwitch : MonoBehaviour {

	public PowerUpBase MyPowerUp;

	void Start () {
		switch(MyPowerUp.PowerLevel){
			case 100:
			print("You picked up more ammo.");
			break;
			case 1000:
			print("Special Ammo Pack Recieved");
			break;
		}	
	}
}
