using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectManager : MonoBehaviour
{
    public int numObjects;
    public Object[] a;


    private void Update()
    {
        a = GameObject.FindObjectsOfType<Object>();
        foreach (Object o in a)
        {
            
            o.DoThing();
            print(o.Factorial(100));
        }
    }
}
