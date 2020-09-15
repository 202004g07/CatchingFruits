using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemController : MonoBehaviour
{
    public float FallSpeed;
    public GameObject Stage;
    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, -FallSpeed * Time.deltaTime, 0);

        //if (transform.position.y < Stage.transform.position.y)
        //{
        //    Destroy(gameObject);
        //}
    }

    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log(other.name);
        if (other.CompareTag("BG")) Destroy(gameObject);
        if (other.CompareTag("Player")) Destroy(gameObject);
    }

}
