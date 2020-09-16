using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pause : MonoBehaviour
{
    [SerializeField]
    GameObject PausePanel;
    [SerializeField]
    Text test;

    bool isActive = true;
    void Start()
    {
        PausePanel.SetActive(!isActive);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P) && PlayerPrefs.GetInt("SceneFlag") == 1)
        {
            if (Time.timeScale == 1)
            {
                Time.timeScale = 0;
                PausePanel.SetActive(isActive);
            }
            else
            {
                Time.timeScale = 1;
                PausePanel.SetActive(!isActive);
            }
        }
    }
    public void testButton()
    {
        test.text += "t/";
    }
    public void OnResumeButtonClick()
    {
        Time.timeScale = 1;
        PausePanel.SetActive(!isActive);
    }
}
