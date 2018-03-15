using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Division : Calculation 
{
	public override float FinishCalculation()
	{
		return aNum / bNum;
	}
}
