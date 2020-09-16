using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text Score;
    public Text Timer;
    public Text GO_Score;

    public GameObject Basket;
    public GameObject GameUI;
    public GameObject GameOver;
    public GameObject SubCamera;
    public GameObject Init;

    public float time = 30f;
    int point = 0;
    public int ApplePoint = 100;
    public int BombPoint = 2;

    bool GenerateGoldenApple = true;
    int rndTime;
    ItemGenerator itemGenerator;
    private void Awake()
    {
        itemGenerator = GameObject.Find("ItemGenerator").GetComponent<ItemGenerator>();
        rndTime = Random.Range(1, (int)time + 1);
        Debug.Log(rndTime);
    }
    private void Start()
    {
        PlayerPrefs.SetInt("SceneFlag", 1);
    }
    void Update()
    {
        if (Time.timeScale == 0) return;

        if (time > 0)
        {
            time -= Time.deltaTime;

            if (time >= 23) itemGenerator.SetParameter(1, 1.8f, 10);
            else if (time >= 12) itemGenerator.SetParameter(0.8f, 2.4f, 14.4f);
            else if (time >= 5) itemGenerator.SetParameter(0.5f, 3.3f, 10);
            else itemGenerator.SetParameter(0.7f, 2.4f, 10.5f);

            if (rndTime <= time && time < rndTime + 1 && GenerateGoldenApple)
            {
                Debug.Log("GenerateGoldenApple");
                GenerateGoldenApple = !GenerateGoldenApple;
                itemGenerator.GenerateGoldenApple();
            }

            Timer.text = $"TIME: {time:F1}";
            Score.text = $"Score: {point}";
            return;
        }
        GO_Score.text = Score.text;

        GameUI.SetActive(false);
        GameOver.SetActive(true);
        SubCamera.SetActive(true);
        Basket.GetComponent<BasketController>().enabled = false;

        if (Input.GetKeyDown(KeyCode.Space)) Init.GetComponent<Init>().ReLoad();
    }
    public void GetApple() => point += ApplePoint;
    public void GetBomb() => point /= BombPoint;
    public void GetGoldenApple() => point *= 2;
}
