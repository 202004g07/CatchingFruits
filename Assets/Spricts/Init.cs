using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Init : MonoBehaviour
{
    //public UnityEvent OnGameEnable;
    //public UnityEvent OnGameDisable;

    public void ReLoad()
    {
        // 現在のScene名を取得する
        Scene loadScene = SceneManager.GetActiveScene();
        // Sceneの読み直し
        SceneManager.LoadScene(loadScene.name);
        //Debug.Log("Load");
        //OnGameDisable?.Invoke();
        //Debug.Log("Disable");
        //OnGameEnable?.Invoke();
        //Debug.Log("Enable");
        //GameScene.SetActive(true);
        //GameUI.SetActive(true);
    }
}
