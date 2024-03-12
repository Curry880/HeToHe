using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SEManager : MonoBehaviour
{
    public AudioClip soundCorrect;
    public AudioClip soundWrong;
    AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    public void CorrectSE()
    {
        audioSource.PlayOneShot(soundCorrect);
    }

    public void WrongSE()
    {
        audioSource.PlayOneShot(soundWrong);
    }
}
