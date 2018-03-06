using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuntcionsWithReturns : MonoBehaviour {

	public int Health;

	public int AddHealth(int value)
	{
		print("Hey there!");
		//move character
		//play animation
		return Health += value;
	}

	public void OnMouseDown()
	{
		Health = AddHealth(10);
		Players.Add(NewPlayer("Bob"));
	}

	public List<string> Players;
	public List<string> NewPlayers()
	{
		return new List<string>();
	}

	public string NewPlayer(string name)
	{
		return name;
	}

}
