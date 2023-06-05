using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndingSequence : MonoBehaviour
{
    public Animator octopusAnimator;
    public float secondsBeforeShake;
    public float secondsBeforeOctopusAnimation;
    public float secondsBeforeChangingScene;
    public string sceneToLoad;
    public AudioClip[] audioClipsShake;
    public AudioSource audioSourceShake;
    public AudioClip[] audioClipsOctopus;
    public AudioSource audioSourceOctopus;
    public GameObject[] gameObjectsToDisable;
    public AudioClip[] audioClipsActivation;
    public AudioSource audioSourceActivation;

    public void PlayEndingSequence()
    {
        StartCoroutine(CoroutineEndingSequence());
        StartCoroutine(CoroutineChangeScene());
    }

    private IEnumerator CoroutineEndingSequence()
    {
        for (int i = 0; i < gameObjectsToDisable.Length; i++)
        {
            gameObjectsToDisable[i].SetActive(false);
        }

        PlayAudioClips(audioClipsActivation, audioSourceActivation);
        yield return new WaitForSeconds(secondsBeforeOctopusAnimation);
        PlayAudioClips(audioClipsOctopus, audioSourceOctopus); 
        octopusAnimator.SetTrigger("Go");
        yield return new WaitForSeconds(secondsBeforeShake);
        PlayAudioClips(audioClipsShake, audioSourceShake);
        
    }

    private IEnumerator CoroutineChangeScene()
    {
        yield return new WaitForSeconds(secondsBeforeChangingScene);
        SceneManager.LoadScene(sceneToLoad);
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
