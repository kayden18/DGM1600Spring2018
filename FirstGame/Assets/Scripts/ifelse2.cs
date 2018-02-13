using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ifelse2 : MonoBehaviour {

	public bool Key;
	public int health = 100;
	public string Password = "ou812";
	void Start () {
		if(Key){
			print("You have the key.");
		}else{
			print("You don't have the key.");
		}
		if(health >= 0){
			print("Can play");
		}else{
			print("You're dead");
		}
		if(Password == "ou812"){
			print("Correct");
		}else{
			print("Try again.");
		}
	}
}
//bool will default to false
//else statements require if statements to work
//else statements run a function if the if statement is false
//if else statements check for two choices only