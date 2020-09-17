using UnityEngine;

public class ItemSoundEffect : MonoBehaviour
{
    public AudioClip se;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && PlayerPrefs.GetInt("SceneFlag") == 1)
        {
            AudioSource.PlayClipAtPoint(se, transform.position);
        }
    }

}
