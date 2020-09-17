using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HardCore : MonoBehaviour
{
    public GameObject GameDirector;
    public Text hpt;
    public int hp = 3;

    public void OnStageEnter()
    {
        if (PlayerPrefs.GetInt("Difficulty") == 1)
        {
            if (int.Parse(hpt.text) != 0)
            {
                hp--;
                hpt.text = hp.ToString();
                return;
            }
            GameDirector.GetComponent<GameDirector>().ToGameOverScene();
        }
    }
}
