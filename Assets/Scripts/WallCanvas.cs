using UnityEngine;
using UnityEngine.UI;

public class WallCanvas : MonoBehaviour
{
    public Image[] mapPieceImages; // Array of UI images representing map pieces on the wall

    private void Start()
    {
        // Subscribe to the onMapPieceAcquired event in the MapPieceManager script
        MapScript.instance.onMapPieceAcquired.AddListener(UpdateMapPiecesOnWall);
        UpdateMapPiecesOnWall();
    }

    private void UpdateMapPiecesOnWall()
    {
        for (int i = 0; i < mapPieceImages.Length; i++)
        {
            if (mapPieceImages[i] != null)
            {
                bool isAcquired = MapScript.instance.IsMapPieceAcquired(i);

                // Update the visibility or appearance of the map piece image on the wall based on its acquired status
                mapPieceImages[i].gameObject.SetActive(isAcquired);
            }
         
        }
    }
}