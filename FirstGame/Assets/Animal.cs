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
//Animal is the name for the class and so is MonoBehaviour. The difference is that Animal is a class inside the MonoBehaviour class. 
//void is a type of function that can be made inside of a class, while Start is a function that can be called by other functions. 
//functions are boxes that are inside of the class which is another box that is inside of MonoBehaviour which is yet another box.
//there can be as many classes as you want and as many functions inside those classes as you want. 