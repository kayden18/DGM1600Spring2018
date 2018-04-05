using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour {

	public PowerUp PowerUpTrigger;

	private void OnTriggerEnter(Collider obj)
	{
		MovePattern newPattern = obj.GetComponent<MoveCharacter>().MovePattern = PowerUpTransfer.Transfer();
	}
}
