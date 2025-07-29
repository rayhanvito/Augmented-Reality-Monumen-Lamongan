using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Setting : MonoBehaviour
{
    AudioController audioController;

    [SerializeField] Toggle musikBacksound;
    [SerializeField] Toggle soundEffect;

    private void Start()
    {
        audioController = GameObject.FindWithTag("Music").GetComponent<AudioController>();
    }

    public void MuteBacksound()
    {
        if (musikBacksound.isOn)
        {
            audioController.musicBacksound.mute = false;
        }
        else
        {
            audioController.musicBacksound.mute = true;
        }
    }

    public void MuteSoundEffect()
    {
        if (soundEffect.isOn)
        {
            audioController.soundEffect.mute = false;
        }
        else
        {
            audioController.soundEffect.mute = true;
        }
    }
}
