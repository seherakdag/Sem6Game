using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plank : MonoBehaviour
{
    public ParticleSystem particleSystemBreak;
    public Door door;
    public AudioSource audioSource;

    void OnTriggerEnter(Collider collider)
    { 
    if (collider.tag == "Crowbar")
        {
            door.onBreakPlank(this);
            Destroy(gameObject);

            if (particleSystemBreak)
            {
                particleSystemBreak.Play();
            }

            if (audioSource)
            {
                audioSource.Play();
            }
            
        }
    }
}
