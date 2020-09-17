using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitSeting : MonoBehaviour
{
    [SerializeField, NotNull]
    GameObject Title;
    [SerializeField, NotNull]
    GameObject GameScene;
    [SerializeField, NotNull]
    GameObject TitleUI;
    [SerializeField, NotNull]
    GameObject DifficultyUI;
    [SerializeField, NotNull]
    GameObject HardCoreUI;
    [SerializeField, NotNull]
    GameObject GameUI;
    [SerializeField, NotNull]
    GameObject GameOverUI;
    [SerializeField, NotNull]
    GameObject SubCamera;


    bool isActive = true;
    private void Awake()
    {
        Title.SetActive(isActive);
        TitleUI.SetActive(isActive);

        DifficultyUI.SetActive(!isActive);
        HardCoreUI.SetActive(!isActive);

        GameScene.SetActive(!isActive);
        GameUI.SetActive(!isActive);

        GameOverUI.SetActive(!isActive);
        SubCamera.SetActive(!isActive);

        PlayerPrefs.SetInt("DifficultyFlag", 0);
        PlayerPrefs.SetInt("SceneFlag", 0);
    }
}
