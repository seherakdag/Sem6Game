using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndingSequence : MonoBehaviour
{
    public Animator octopusAnimator;
    public float secondsBeforeShake;
    public AudioClip[] audioClipsShake;
    public AudioSource audioSourceShake;
    public AudioClip[] audioClipsOctopus;
    public AudioSource audioSourceOctopus;

    public void PlayEndingSequence()
    {
        StartCoroutine(CoroutineEndingSequence());
    }

    private IEnumerator CoroutineEndingSequence()
    {
        PlayAudioClips(audioClipsOctopus, audioSourceOctopus);
        octopusAnimator.SetTrigger("Go");
        yield return new WaitForSeconds(secondsBeforeShake);
        PlayAudioClips(audioClipsShake, audioSourceShake);
    }

    private void PlayAudioClips(AudioClip[] audioClips, AudioSource audioSource)
    {
        if (audioSource == null) 
        {
            return;
        }

        for(int i = 0; i < audioClips.Length; i++)
        {
            audioSource.PlayOneShot(audioClips[i]);
        }
    }
}
