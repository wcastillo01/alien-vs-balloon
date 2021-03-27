using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundFX : MonoBehaviour
{
    private AudioSource audioSource;

    public AudioClip pop;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void PopSound()
    {
        audioSource.clip = pop;
        audioSource.Play();
    }
}
