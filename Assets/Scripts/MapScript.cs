
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class MapScript : MonoBehaviour
{
    public static MapScript instance; 
    public UnityEvent onMapPieceAcquired;
    private bool[] acquiredMapPieces;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
            return;
        }

        acquiredMapPieces = new bool[4]
           {
                false, false, false, false
           };

        DontDestroyOnLoad(gameObject);
    }

    public void AcquireMapPiece(int mapPieceIndex)
    {
        acquiredMapPieces[mapPieceIndex] = true;
        onMapPieceAcquired.Invoke();
    }

    public bool IsMapPieceAcquired(int mapPieceIndex)
    {
        return acquiredMapPieces[mapPieceIndex];
    }
}