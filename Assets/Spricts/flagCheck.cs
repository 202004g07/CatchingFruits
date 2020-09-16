using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flagCheck : MonoBehaviour
{

    void Update()
    {
        Debug.Log(PlayerPrefs.GetInt("SceneFlag"));
    }
}
