
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Progression : MonoBehaviour
{
    public static Progression instance; 
    public UnityEvent onMapPieceAcquired;
    private bool[] acquiredMapPieces;
    private bool isPlankBroken;
    private bool isTentacleMoved;

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

    public void BreakPlank()
    {
        isPlankBroken = true;
    }

    public bool IsPlankBroken()
    {
        return isPlankBroken;
    }

    public void MoveTentacle()
    {
        isTentacleMoved = true;
    }

    public bool IsTentacleMoved()
    {
        return isTentacleMoved;
    }
}