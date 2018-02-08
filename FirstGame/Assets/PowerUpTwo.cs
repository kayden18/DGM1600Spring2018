using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class PowerUpTwo : ScriptableObject
{
    public int PowerLevel = 10;
	public Player CurrentPlayer;

    public void RunPowerUp()
    {
		CurrentPlayer.Score += PowerLevel;
        //adds value
        Debug.Log(PowerLevel);
    }
}
//methods are how something is done. it's another word for function