using System.Collections;
using System.Collections.Generic;
using UnityEditor.U2D;
using UnityEngine;

public class ItemGenerator : MonoBehaviour
{
    public GameObject ApplePrefab;
    public GameObject BombPrefab;

    public float Span = 1.0f;
    public float Ratio = 20;
    public float Speed = 0.03f;

    public void SetParameter(float span, float speed, float ratio)
    {
        Span = span;
        Speed = speed;
        Ratio = ratio;
    }
    float delta = 0;
    void Update()
    {
        delta += Time.deltaTime;

        if (delta > Span)
        {
            delta = 0;

            GameObject item;
            int rnd = Random.Range(1, 101);
            if (rnd <= Ratio)
            {
                item = Instantiate(BombPrefab);
            }
            else
            {
                item = Instantiate(ApplePrefab);
            }
            item.transform.position = RndPos();

            item.GetComponent<ItemController>().FallSpeed = Speed;
        }
    }
    public Vector3 RndPos()
    {
        return new Vector3(Random.Range(-1, 2), 4, Random.Range(-1, 2));
    }
}
