using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour {
	//plug-ins will help complete the code and even show you to if you messed up
	// Use this for initialization
	void Start () {
		print("My animal is eating.");
		print("My animal is sleeping.");
		print("I love my cat.");
		print("If I had one!");
	}
	//adds a control to the game
	void OnMouseDown()
	{
		print("Meow");
	}
	// Update is called once per frame
	void Update () {
		
	}
}
