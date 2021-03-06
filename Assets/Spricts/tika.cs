﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tika : MonoBehaviour
{
    Text text;

    public float speed = 1.0f;
    private float time;
    void Start()
    {
        text = gameObject.GetComponent<Text>();
    }
    void Update()
    {
        text.color = SetAlphaColor(text.color);
    }
    Color SetAlphaColor(Color color)
    {
        time += Time.deltaTime * speed;
        color.a = Mathf.Sin(time) * 0.5f + 0.5f;

        return color;
    }
}
