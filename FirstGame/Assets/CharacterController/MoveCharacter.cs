using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCharacter : MonoBehaviour {
	
	private CharacterController controller;

	void Start()
	{
		controller = GetComponent<CharacterController>();
	}

    public void RunController(CharacterController controller, Transform transform){

    }
}
