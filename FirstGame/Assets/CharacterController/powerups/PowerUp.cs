﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class PowerUp : ScriptableObject {
    public int PowerLevel;
    public MovePattern MovePattern;
    public PowerUp transfer;
}
