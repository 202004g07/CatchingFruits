using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleManager : MonoBehaviour
{
    public float Power = 0;
    public GameObject Apple;
    // Start is called before the first frame update
    void Start()
    {
        Apple.GetComponent<Rigidbody>().AddForce(new Vector3(-Power, 0, 0));
    }

    // Update is called once per frame
    void Update()
    {

    }
}
