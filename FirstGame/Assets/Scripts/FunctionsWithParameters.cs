using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FunctionsWithParameters : MonoBehaviour {

	public int Health = 20;

	void OnTriggerEnter(Collider other)
	{
		print("Hit something.");
		print(other);

		AddNumbers(14,2);
		PlayerData("Bob");
		AddHealth(25);
	}

	void AddNumbers(int a, int b)
	{
		print(a += b);
	}

	void PlayerData(string Name)
	{
		print("This player is " + Name);
	}

	void AddHealth(int NewHealth)
	{
		Health += NewHealth;
	}
}
