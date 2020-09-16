using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;

public class BasketController : MonoBehaviour
{
    public GameObject UI_Manager;
    void Update()
    {
        //if (Time.timeScale == 0)
        //{
        //    return;
        //}
        if (EventSystem.current.IsPointerOverGameObject())
        {
            // Debug.Log("Mouse Over UI");
            return;
        }
        //if (Input.GetMouseButtonDown(0))
        //{
        //    Debug.Log("GameSceneMouseClick");
        //}
        if (Input.GetMouseButtonDown((int)MouseButton.LeftMouse))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out RaycastHit hit, Mathf.Infinity))
            {
                //Debug.Log(hit.point);

                float x_Pos = Mathf.RoundToInt(hit.point.x);
                float z_Pos = Mathf.RoundToInt(hit.point.z);

                transform.position = new Vector3(x_Pos, 0, z_Pos);
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Fruits")) UI_Manager.GetComponent<UIManager>().GetApple();
        if (other.CompareTag("Bomb")) UI_Manager.GetComponent<UIManager>().GetBomb();
    }

}
