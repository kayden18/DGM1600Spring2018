using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class operators1 : MonoBehaviour {

	public int A;
	public int B;
	public string Password;
	public string userName;

	void Start () {
		if (Password == "Captin")
		{
			print("Welcome back Sir.");
		}
		if(A > B)
		{
			print("A is greater than B.");
		}
		if (A < B)
		{
			print("A is less than B.");
		}
		if (A != B)
		{
			print("A doesn't equal B");
		}
		if (A == B)
		{
			print("A equals B");
		}
		if (userName == "Gamer123" && Password == "Captin")
		{
			print("Welcome back Gamer123");
		}
	}
}
//operators are used to compare information for if statements allowing if statements to compare more then one problem in the same time