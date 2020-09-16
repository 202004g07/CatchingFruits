using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BGM_Controlle : MonoBehaviour
{
    AudioSource aud;
    public AudioClip TitleClip;
    public AudioClip GameClip;
    public AudioClip GameOverClip;

    bool isTitle = true;
    bool isGame = true;
    bool isGameOver = true;
    private void Awake()
    {
        aud = GetComponent<AudioSource>();
    }
    private void Update()
    {
        if (PlayerPrefs.GetInt("SceneFlag") == 0 && isTitle)
        {
            isTitle = !isTitle;
            aud.Stop();
            aud.PlayOneShot(TitleClip);
            aud.loop = true;
        }
        if (PlayerPrefs.GetInt("SceneFlag") == 1 && isGame)
        {
            isGame = !isGame;
            aud.Stop();
            aud.PlayOneShot(GameClip);
            aud.loop = true;
        }
        if (PlayerPrefs.GetInt("SceneFlag") == 2 && isGameOver)
        {
            isGameOver = !isGameOver;
            aud.Stop();
            aud.PlayOneShot(GameOverClip);
            aud.loop = true;
        }
    }
    public void InitBGMFlag()
    {
        isGame = true;
        isTitle = true;
        isGameOver = true;
    }
}
