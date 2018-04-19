using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCharacter : MonoBehaviour {
	
	public Players Player;
	private CharacterController controller;

	void Start()
	{
		controller = GetComponent<CharacterController>();
	}

    void Update() {
        Player.MovePattern.Move(controller, transform);
	}
}