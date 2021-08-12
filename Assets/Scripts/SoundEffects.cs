using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundEffects : MonoBehaviour
{
    public AudioClip[] soundList;
    public AudioSource musicSource;
    public Toggle music, SFX;

    bool isMusicON, isSFXON;
    // Start is called before the first frame update
    void Start()
    {
        isMusicON = true;
        isSFXON = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (music.isOn)
        {
            isMusicON = true;
            musicSource.mute = false;
            musicSource.playOnAwake = true;
        }
        else
        {
            isMusicON = false;
            musicSource.mute = true;
        }

        if (SFX.isOn)
        {
            isSFXON = true;
            GetComponent<AudioSource>().mute = false;
        }
        else
        {
            isSFXON = false;
            GetComponent<AudioSource>().mute = true;
        }
    }

    public void ButtonClick()
    {
        GetComponent<AudioSource>().PlayOneShot(soundList[0]);
    }
    
}
