using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpMapPiece : MonoBehaviour
{
    public void PickUp(int index)
    {
        MapScript.instance.AcquireMapPiece(index);
    }
}
