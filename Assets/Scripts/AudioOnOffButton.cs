using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioOnOffButton : MonoBehaviour
{
    private SpriteRenderer rend;
    public Sprite AudioOn;
    public Sprite AudioOff;
    public AudioSource MenuSFX;
    public bool isMusicOn;
    public Image SpriteImage;

    public void Start()
    {
        rend = GetComponent<SpriteRenderer>();
        isMusicOn = true;
    }

    public void OnButtonPress()
    {
        if (isMusicOn)
        {
            TurnOffMusic();
        }
        else
        {
            TurnOnMusic();
        }
    }
    public void TurnOnMusic()
    {
        MenuSFX.Play();
        isMusicOn = true;
        //rend.sprite = AudioOff;
        SpriteImage.sprite = AudioOff;

    }
    public void TurnOffMusic()
    {
        MenuSFX.Stop();
        isMusicOn = false;
        //rend.sprite = AudioOn;
        SpriteImage.sprite = AudioOn;
    }


}
