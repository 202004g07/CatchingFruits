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
            aud.PlayOneShot(TitleClip);
        }
        if (PlayerPrefs.GetInt("SceneFlag") == 1 && isGame)
        {
            isGame = !isGame;
            aud.PlayOneShot(GameClip);
        }
        if (PlayerPrefs.GetInt("SceneFlag") == 2 && isGameOver)
        {
            isGameOver = !isGameOver;
            aud.PlayOneShot(GameOverClip);
        }
    }
    public void InitBGMFlag()
    {
        isGame = true;
        isTitle = true;
        isGameOver = true;
    }
}
