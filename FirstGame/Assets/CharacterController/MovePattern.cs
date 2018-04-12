using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewPattern")]
public class MovePattern : ScriptableObject {
    public float speed = 6.0F;
    public float jumpSpeed = 8.0F;
    public float gravity = 20.0F;
    private Vector3 moveDirection = Vector3.zero;

    public InputBase Inputx;
    public InputBase Inputy;
    public InputBase Inputz;

    public void Move(CharacterController controller, Transform transform){
    if (controller.isGrounded) {
			moveDirection.Set(InputX.SetFloat(),InputY.SetFloat(),InputZ.SetFloat());
			moveDirection = transform.TransformDirection(moveDirection);
			
			moveDirection *= speed;	
			moveDirection.y = JumpInput.SetFloat();
    }
        moveDirection.y -= gravity * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);
    }
}