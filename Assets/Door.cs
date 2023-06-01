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

    private void Start()
    {
        if (Progression.instance.IsPlankBroken())
        {
            foreach(Plank plank in planks)
            {
                Destroy(plank.gameObject);
            }

            planks.Clear();
            Unlock();
        }
    }

    public void onBreakPlank(Plank plank)
    {
        planks.Remove(plank);

        if (planks.Count == 0)
        {
            Unlock();
        }
    }

    private void Unlock()
    {
        isUnlocked = true;
        CrowbarUI.SetActive(false);
    }

    public void OpenDoor()
    {
        if (isUnlocked)
        {
            Progression.instance.BreakPlank();
            SceneManager.LoadScene(sceneToLoad);
            Destroy(CrowbarUI);
        }
    }
}
