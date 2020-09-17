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
        aud.loop = true;
    }
    private void Update()
    {
        if (PlayerPrefs.GetInt("SceneFlag") == 0 && isTitle)
        {
            isTitle = !isTitle;
            aud.Stop();
            aud.clip = TitleClip;
            aud.Play();
        }
        if (PlayerPrefs.GetInt("SceneFlag") == 1 && isGame)
        {
            isGame = !isGame;
            aud.Stop();
            aud.clip = GameClip;
            aud.Play();
        }
        if (PlayerPrefs.GetInt("SceneFlag") == 2 && isGameOver)
        {
            isGameOver = !isGameOver;
            aud.Stop();
            aud.clip = GameOverClip;
            aud.Play();
        }
    }
    public void InitBGMFlag()
    {
        isGame = true;
        isTitle = true;
        isGameOver = true;
    }
    public void OnTitleBGM()
    {
        aud.Stop();
        aud.clip = TitleClip;
        aud.Play();
    }
    public void OnGameBGM()
    {
        aud.Stop();
        aud.clip = GameClip;
        aud.Play();
    }
    public void OnGameOverBGM()
    {
        aud.Stop();
        aud.clip = GameOverClip;
        aud.Play();
    }
}
