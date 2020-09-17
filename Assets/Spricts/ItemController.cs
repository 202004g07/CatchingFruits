using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemController : MonoBehaviour
{
    public float FallSpeed;

    void Update()
    {
        transform.Translate(0, -FallSpeed * Time.deltaTime, 0);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("BG")) Destroy(gameObject);
        if (other.CompareTag("Player")) Destroy(gameObject);
    }
}
