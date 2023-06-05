using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpMapPiece : MonoBehaviour
{
    public int indexPiece;
    private void Start()
    {
        if (Progression.instance.IsMapPieceAcquired(indexPiece))
        {
            Destroy(gameObject);
        }
    }

    public void PickUp()
    {
        Progression.instance.AcquireMapPiece(indexPiece);
    }
}
