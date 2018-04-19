using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playParticls : MonoBehaviour {

	public ParticleSystem ParticleSystem;

	private void OnTriggerEnter(Collider other)
	{
		ParticleSystem.Emit(100);
	}
}
