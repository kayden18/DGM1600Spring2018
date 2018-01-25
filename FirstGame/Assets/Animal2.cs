using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Animal2 : MonoBehaviour {

	public string Name;
	public int foodCount;
	void OnMouseDown()
	{
		print("I have a " + Name);
		print("It has " + foodCount + " amount of food.");
	}
}
