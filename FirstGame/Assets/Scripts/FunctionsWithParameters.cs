using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FunctionsWithParameters : MonoBehaviour {

	public int Health = 20;
	public int Ammo = 0;
	public int Food = 100;
	public int Armor = 30;
	

	void OnTriggerEnter(Collider other)
	{
		print("Hit something.");
		print(other);

		AddNumbers(14,2);
		PlayerData("Bob");
		AddHealth(25);
		SubHealth(15);
		AddWeapon("Bow");
		AddAmmo(15);
		IncreaseFoodMeter(10);
		DecreaseFoodMeter(5);
		AddArmor(25);
		ArmorDamage(10);
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
	void SubHealth(int NewHealth)
	{
		Health -= NewHealth;
	}
	void AddWeapon(string weapon)
	{
		print(weapon + " added");
	}
	void AddAmmo(int Newammo)
	{
		Ammo += Newammo;
	}
	void IncreaseFoodMeter(int FoodMeter)
	{
		Food += FoodMeter;
	}
	void DecreaseFoodMeter(int FoodMeter)
	{
		Food -= FoodMeter;
	}
	void AddArmor(int ArmorRating)
	{
		Armor += ArmorRating;
	}
	void ArmorDamage(int ArmorRating)
	{
		Armor -= ArmorRating;
	}
}
