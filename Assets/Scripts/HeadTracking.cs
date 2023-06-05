using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadTracking : MonoBehaviour
{
    public Transform head;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (head == null)
        {
            return;
        }

        transform.LookAt(head);
        transform.forward = -transform.forward;
    }
}
