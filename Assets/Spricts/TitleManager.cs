using UnityEngine;

public class TitleManager : MonoBehaviour
{
    public float Power = 0;
    public GameObject Apple;
    public GameObject Title;
    public GameObject TitleUI;

    public GameObject DifficultyUI;
    public GameObject HardCoreUI;

    public GameObject GameUI;
    public GameObject GameScene;
    void Start()
    {
        Apple.GetComponent<Rigidbody>().AddForce(new Vector3(-Power, 0, 0));
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            DifficultyUI.SetActive(true);
        }
    }
    public void OnNomalButtonClick()
    {
        ToGameScene();
    }
    public void OnHardCoreButtonClick()
    {
        PlayerPrefs.SetInt("Difficulty", 1);
        HardCoreUI.SetActive(true);
        ToGameScene();
    }
    public void ToGameScene()
    {
        Title.SetActive(false);
        TitleUI.SetActive(false);
        DifficultyUI.SetActive(false);
        GameUI.SetActive(true);
        GameScene.SetActive(true);
    }
}
