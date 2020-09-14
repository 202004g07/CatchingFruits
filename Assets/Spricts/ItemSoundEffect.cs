using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSoundEffect : MonoBehaviour
{
    public AudioClip se;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            AudioSource.PlayClipAtPoint(se, transform.position);
        }
    }

}
