using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    public List<Plank> planks = new List<Plank>();
    private bool isUnlocked;
    public string sceneToLoad;
    public GameObject CrowbarUI;

    public void onBreakPlank(Plank plank)
    {
        planks.Remove(plank);

        if (planks.Count == 0)
        {
            isUnlocked = true;
        }
    }

    public void OpenDoor()
    {
        if (isUnlocked)
        {
            SceneManager.LoadScene(sceneToLoad);
            Destroy(CrowbarUI);
        }
    }
}
