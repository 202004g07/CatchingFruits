using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text Score;
    public Text Timer;

    public GameObject Basket;

    public GameObject GameOver;
    public Text GO_Score;

    public GameObject Init;

    public GameObject SubCamera;

    public float time = 30f;
    int point = 0;
    public int ApplePoint = 100;
    public int BombPoint = 2;
    void Update()
    {
        if (time > 0)
        {
            time -= Time.deltaTime;
            Timer.text = time.ToString("F1");
            Score.text = $"Score: {point}";
            return;
        }
        GO_Score.text = Score.text;
        GameOver.SetActive(true);
        SubCamera.SetActive(true);
        Basket.GetComponent<BasketController>().enabled = false;

        if (Input.GetKeyDown(KeyCode.Space)) Init.GetComponent<Init>().ReLoad();
    }
    public void GetApple() => point += ApplePoint;
    public void GetBomb() => point /= BombPoint;
}
