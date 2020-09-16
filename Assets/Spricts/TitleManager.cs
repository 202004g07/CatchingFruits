using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleManager : MonoBehaviour
{
    public float Power = 0;
    public GameObject Apple;
    public GameObject Title;
    public GameObject TitleUI;

    public GameObject GameUI;
    public GameObject GameScene;
    // Start is called before the first frame update
    void Start()
    {
        Apple.GetComponent<Rigidbody>().AddForce(new Vector3(-Power, 0, 0));
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Title.SetActive(false);
            TitleUI.SetActive(false);
            GameUI.SetActive(true);
            GameScene.SetActive(true);

            // PlayerPrefs.SetInt("TitleFlag", 1);
        }
    }
}
