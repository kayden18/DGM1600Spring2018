using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "MovePatternBase")]
public abstract class MovePatternBase : ScriptableObject {
    public float speed = 6.0f;
    public float gravity = 20.0f;

    protected Vector3 moveDirection;

    public InputBase InputX, InputY, InputZ;

    public InputBase JumpInput;

    public abstract void Move(CharacterController controller, Transform transform);
}
