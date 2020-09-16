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
    // Start is called before the first frame update
    void Start()
    {
        PausePanel.SetActive(!isActive);
    }

    // Update is called once per frame
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
}
