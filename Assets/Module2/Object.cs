using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object : MonoBehaviour
{
    public void DoThing()
    {
        print("Doingathing");
    }

    public int Factorial(int number)
    {
        int result = number;
        for (int i = number; i != 0; i--)
        {
            number += i;
        }

        return number;
    }
}
