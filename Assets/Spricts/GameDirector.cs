using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    public Text Score;
    public Text Timer;
    public Text GO_Score;
    public Text Hp;

    public GameObject Basket;
    public GameObject GameUI;
    public GameObject HardCoreUI;
    public GameObject GameOver;
    public GameObject SubCamera;
    public GameObject Init;

    public float time = 30f;
    int point = 0;
    public int ApplePoint = 100;
    public int BombPoint = 2;
    int GoldenApplePoint = 1000;
    float hardCore = 1;

    bool GenerateGoldenApple = true;
    int rndTime;
    ItemGenerator itemGenerator;
    private void Awake()
    {
        itemGenerator = GameObject.Find("ItemGenerator").GetComponent<ItemGenerator>();
        rndTime = Random.Range(1, (int)time - 1);
    }
    private void Start()
    {
        PlayerPrefs.SetInt("SceneFlag", 1);
        if (PlayerPrefs.GetInt("DifficultyFlag") == 1)
        {
            Debug.Log("HardCoreMode");
            ApplePoint *= 2;
            GoldenApplePoint *= 2;
            hardCore = 1.3f;
        }
    }
    void Update()
    {
        if (Time.timeScale == 0) return;

        if (time > 0)
        {
            time -= Time.deltaTime;

            if (time >= 23) itemGenerator.SetParameter(1, 1.8f, 10 * hardCore);
            else if (time >= 12) itemGenerator.SetParameter(0.8f, 2.4f, 14.4f * hardCore);
            else if (time >= 5) itemGenerator.SetParameter(0.5f, 3.3f, 10 * hardCore);
            else itemGenerator.SetParameter(0.7f, 2.4f, 10.5f * hardCore);

            if (rndTime <= time && time < rndTime + 1 && GenerateGoldenApple)
            {
                GenerateGoldenApple = !GenerateGoldenApple;
                itemGenerator.GenerateGoldenApple();
            }


            Timer.text = $"TIME: {time:F1}";
            Score.text = $"Score: {point}";
            return;
        }
        ToGameOverScene();

        if (Input.GetKeyDown(KeyCode.Space)) Init.GetComponent<Init>().ReLoad();
    }
    public void GetApple() => point += ApplePoint;
    public void GetBomb() => point /= BombPoint;
    public void GetGoldenApple() => point += GoldenApplePoint;
    public void ToGameOverScene()
    {
        GO_Score.text = Score.text;

        HardCoreUI.SetActive(false);
        GameUI.SetActive(false);
        GameOver.SetActive(true);
        SubCamera.SetActive(true);
        Basket.GetComponent<BasketController>().enabled = false;
    }
}
