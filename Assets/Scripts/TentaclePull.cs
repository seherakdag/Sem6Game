using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TentaclePull : MonoBehaviour
{
    public float secondsBeforeGo;

    void Start()
    {
        if (!Progression.instance.IsTentacleMoved())
        {
            StartCoroutine(CoroutineGo());
        }
    }

    private IEnumerator CoroutineGo()
    {
        yield return new WaitForSeconds(secondsBeforeGo);
        GetComponent<Animator>().SetTrigger("Go");
        GetComponent<AudioSource>().Play();
        Progression.instance.MoveTentacle();
    }
}
