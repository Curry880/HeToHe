using UnityEngine;

public class SEManager : MonoBehaviour
{
    [SerializeField]
    private AudioClip soundCorrect;
    [SerializeField]
    private AudioClip soundWrong;
    [SerializeField]
    private AudioClip countDown;

    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    public void PlayCorrectSE()
    {
        audioSource.PlayOneShot(soundCorrect);
    }

    public void PlayWrongSE()
    {
        audioSource.PlayOneShot(soundWrong);
    }

    public void PlayCountDownSE()
    {
        audioSource.PlayOneShot(countDown);
    }
}
