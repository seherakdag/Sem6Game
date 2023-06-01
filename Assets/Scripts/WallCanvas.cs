using UnityEngine;
using UnityEngine.UI;

public class WallCanvas : MonoBehaviour
{
    public Image[] mapPieceImages; 

    private void Start()
    {
        Progression.instance.onMapPieceAcquired.AddListener(UpdateMapPiecesOnWall);
        UpdateMapPiecesOnWall();
    }

    private void UpdateMapPiecesOnWall()
    {
        for (int i = 0; i < mapPieceImages.Length; i++)
        {
            if (mapPieceImages[i] != null)
            {
                bool isAcquired = Progression.instance.IsMapPieceAcquired(i);
                mapPieceImages[i].gameObject.SetActive(isAcquired);
            }
         
        }
    }
}