using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgmManager : MonoBehaviour
{
    public AudioClip peaceMusic;
    public AudioClip bossMusic;

    public AudioClip bossSFX;

    public AudioSource audioSource;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = peaceMusic;
        audioSource.loop = true;
        audioSource.Play();
    }

    public void BossEncounter()
    {
        StartCoroutine(BossMusicSequence());
    }

    IEnumerator BossMusicSequence()
    {
        yield return null;
        audioSource.Stop();
        audioSource.clip = bossMusic;
        audioSource.loop = true;
        audioSource.Play();
    }

    public void GrassDie()
    {
        audioSource.Stop();
        audioSource.clip = bossSFX;
        audioSource.loop = true;
        audioSource.Play();
    }
}
