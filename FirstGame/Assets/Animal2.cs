using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Animal2 : MonoBehaviour {
//strings and ints are variables which is called during functions
	public string Name; //string is a string of letters, numbers, and characters 
	public int foodCount; //int is a whole number 
	void OnMouseDown()
	{
		print("I have a " + Name);//strings can be called and combined with other strings through functions
		print("It has " + foodCount + " amount of food.");//ints can also be called and combined with strings and other ints through functions
	}
}
