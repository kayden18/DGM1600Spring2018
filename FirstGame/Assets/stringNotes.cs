using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class stringNotes : MonoBehaviour {
//strings and ints are variables which is called during functions
	public string Name; //string is a string of letters, numbers, and characters 
	public int foodCount; //int is a whole number 
	void OnMouseDown()
	{
		print("I have a " + Name);//strings can be called and combined with other strings through functions
		print("It has " + foodCount + " amount of food.");//ints can also be called and combined with strings and other ints through functions

		if (Name == "Dog")
		{
			print("I'm loyal");
		}
		if(Name == "Cat")
		{
			print("Leave me alone.");
		}
		if(4 + 5 != 10)
		{
			print("No duh.");
		}
		if(foodCount < 0){
			print("I need more food");
		}
		if(foodCount > 0)
		{
			print("Yay food");
		}
		if(Name != "Fish")
		{
			print("Blub");
		}
	}
}
//if statements check for true or false outcomes
//if statements are not called but can do work
//if statements don't always return something
//if statements can be used with a bool to turn on true or false for functions and variables.