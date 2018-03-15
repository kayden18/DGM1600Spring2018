using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Calculation : ScriptableObject 
{
	protected float aNum;
	protected float bNum;

	public string Calculate(string a, string b){

		aNum = float.Parse(a);
		bNum = float.Parse(b);
		return FinishCalculation();
	}
	public abstract string FinishCalculation();
}

//access modifiers private/public/protected
//private only the parent script can see it
//public every script can see it 
//protected can only be seen by the parent script and it child scripts