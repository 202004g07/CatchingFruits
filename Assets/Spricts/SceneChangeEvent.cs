using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneChangeEvent : MonoBehaviour
{
    public GameObject TitleUI;
    public GameObject Title;

    public GameObject Game;
    public GameObject GameUI;

    public GameObject GameOver;
    public GameObject SubCamera;

    bool isActive = true;
    public void SetTitleDisable()
    {
        TitleUI.SetActive(!isActive);
        Title.SetActive(!isActive);
    }
    public void SetGameEnable()
    {
        Game.SetActive(isActive);
        GameUI.SetActive(isActive);
    }
    public void SetGameDisable()
    {
        Game.SetActive(!isActive);
        GameUI.SetActive(!isActive);
    }
    public void SetGameOverEnable()
    {
        GameOver.SetActive(isActive);
        SubCamera.SetActive(isActive);
    }
    public void SetGameOverDisable()
    {
        GameOver.SetActive(!isActive);
        SubCamera.SetActive(!isActive);
    }
}
