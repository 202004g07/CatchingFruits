using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class SoundEffectController : MonoBehaviour
{
    public AudioClip getFruits;
    public AudioClip getBomb;
    AudioSource aud;
    private void Start()
    {
        aud = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Fruits")) aud.PlayOneShot(getFruits);
        //if (other.CompareTag("Bomb")) aud.PlayOneShot(getBomb);
    }


}
