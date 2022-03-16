using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Equations_C : MonoBehaviour
{
    //Basis vectors

    private void Update()
    {
        transform.Rotate(transform.InverseTransformDirection(Vector3.right));
        transform.RotateAround(transform.up, Time.deltaTime);

        print(transform.up);
    }
}