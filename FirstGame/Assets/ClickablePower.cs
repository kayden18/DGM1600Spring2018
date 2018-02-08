using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickablePower : MonoBehaviour {

	public PowerUpTwo myPowerUp;
	private void OnMouseDown()
	{
	//do work
	myPowerUp.RunPowerUp();	
	}
}
