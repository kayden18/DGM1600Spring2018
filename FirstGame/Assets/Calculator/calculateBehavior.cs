using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class calculateBehavior : MonoBehaviour 
{
	public InputField InputOne;
	public InputField InputTwo;
	public Text SolutionText;
	public Calculation Calculation;

	public void RunCalculation()
	{
		SolutionText.text = Calculation.Calculate(InputOne.text, InputTwo.text).ToString();
	}
}