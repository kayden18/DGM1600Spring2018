using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour {

	public string UserName;

	void Start () {
		switch (UserName)
		{
			case "Password":
				print("Password is correct.");
				//do work
				break;

			case "LevelUp":
				print("You win. Next Level");
				//do work
				break;
			
			case "BlackPanther":
				print("Made over 2 million this weekend.");
				break;
			
			default:
				print("Why don't you tell me which movie you want to see.");
				//do work
				break;
		}	
	}
}
//switches like every other function have to be inside of a function
//switches are like if statements but don't check for true or false