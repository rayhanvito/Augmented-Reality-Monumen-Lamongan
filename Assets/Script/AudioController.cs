using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    public static AudioController instance;
    private void Awake()
    {
        if (instance != null)
            Destroy(gameObject);
        else
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
    }

    [Header("Audio Source")]
    public AudioSource musicBacksound;
    public AudioSource soundEffect;

    [Header("Sound Effect")]
    public AudioClip backsound;
    public AudioClip buttonOpen;
    public AudioClip buttonClose;



    private void Start()
    {
        musicBacksound.clip = backsound;
        musicBacksound.Play();

    }

    public void PlaySFX(AudioClip clip)
    {
        soundEffect.PlayOneShot(clip);
    }



}
