using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.XR.Interaction.Toolkit;

public class Rotate : MonoBehaviour
{
    public static event Action<string, int> Rotated = delegate { };

    private bool coroutineAllowed;

    private int numberShown;
    private void Start()
    {
        coroutineAllowed = true;
        numberShown = 1;
    {
        
    }
}

    private void OnTriggerEnter(Collider other)
    {
        //if (coroutineAllowed)
       // {
          //  StartCoroutine("RotateWheelCoroutine");
       // }

    }

    public void RotateWheel()
    {
        StartCoroutine("RotateWheelCoroutine");
    }

    private IEnumerator RotateWheelCoroutine()
    {
        coroutineAllowed = false;

        for (int i = 0; i <= 11; i++)
        {
            transform.Rotate(22.5f, 0f, 0f);
            yield return new WaitForSeconds(0.01f);

        }

        coroutineAllowed = true;

        numberShown += 1;

        if (numberShown > 15)
        {
            numberShown = 0;
        }

        Rotated(name, numberShown);
    }
}