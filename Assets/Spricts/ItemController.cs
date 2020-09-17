using UnityEngine;
using UnityEngine.Events;

public class ItemController : MonoBehaviour
{
    public float FallSpeed;
    GameObject DifficultDirector;
    private void Start()
    {
        DifficultDirector = GameObject.Find("DifficultDirector");
    }
    void Update()
    {
        transform.Translate(0, -FallSpeed * Time.deltaTime, 0);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("BG"))
        {
            Debug.Log("StageEnter");
            DifficultDirector.GetComponent<HardCore>().OnStageEnter();
            Destroy(gameObject);
        }
        if (other.CompareTag("Player")) Destroy(gameObject);
    }

}
