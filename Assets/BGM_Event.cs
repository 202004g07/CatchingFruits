using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGM_Event : MonoBehaviour
{
    AudioSource aud;
    public AudioClip TitleClip;
    public AudioClip GameClip;
    public AudioClip GameOverClip;
    private void Awake()
    {
        aud = GetComponent<AudioSource>();
    }
    public void PlayTitleBGM()
    {
        aud.PlayOneShot(TitleClip);
    }
    public void PlyaGameBGM()
    {
        aud.PlayOneShot(GameClip);
    }
    public void PlayGameOverBGM()
    {
        aud.PlayOneShot(GameOverClip);
    }
}
