using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class basicAI : MonoBehaviour {

	public NavMeshAgent Agent;
	public Transform Player;

	void Start()
	{
		Agent = GetComponent<NavMeshAgent>();
	}
	void Update()
	{
		Agent.destination = Player.position;
	}
}
