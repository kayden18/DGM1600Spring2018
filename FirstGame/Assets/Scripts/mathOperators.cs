using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mathOperators : MonoBehaviour
{

    public int A = 10;
    public int B = 10;
    public int C = 10;
    public int Score = 0;
    public int PowerUp = 10;
    void Start()
    {
        C = A + B;
        C += A + B;
        C -= A - B;

        if (A + B == C)
        {
            print(C);
        }
        if (C - A == B)
        {
            print(B);
        }
        if (A * B == C)
        {
            print(C);
        }
        if (A / B == C)
        {
            print(C);
        }
        if (A <= 0)
        {
            A++;
        }
        if (A >= 10)
        {
            A--;
        }
    }
    void OnTriggerEnter()
    {
        Score += PowerUp;
    }
}
//math operators will perform math inside of functions according to the symbols
// ++ means add 1, -- means minus 1