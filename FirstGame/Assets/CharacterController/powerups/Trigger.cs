using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Trigger : MonoBehaviour {

	public PowerUp PowerUp;
    private MoveCharacter prevMoveCharacter;
    private MovePattern prevMovePattern;
    private float TimeToRestore = 2;

	private void OnTriggerEnter(Collider obj)
	{
        prevMoveCharacter = obj.GetComponent<MoveCharacter>();
        prevMovePattern = prevMoveCharacter.MovePattern;

        obj.GetComponent<MoveCharacter>().MovePattern = PowerUp.MovePattern;

        Invoke("RestoreMovePattern", TimeToRestore);

		gameObject.SetActive(false);
		}
    void RestoreMovePattern()
    {
        prevMoveCharacter.MovePattern = prevMovePattern;
	}
}
