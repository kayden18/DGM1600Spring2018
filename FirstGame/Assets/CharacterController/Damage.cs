﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    public void OnTriggerEnter(Collider col)
    {
        HealthBar.health -= 30f;
    }
}