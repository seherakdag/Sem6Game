
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class MapScript : MonoBehaviour
{
    public static MapScript instance; // Singleton instance of the MapPieceManager
    public UnityEvent onMapPieceAcquired; // Event triggered when a new map piece is acquired

    // List to store acquired map pieces
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