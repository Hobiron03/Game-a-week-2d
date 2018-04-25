using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightCollider : MonoBehaviour {

    AudioSource audioSource;
    public AudioClip audioCorrect;
    public AudioClip audioMiss;
    // Use this for initialization
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Human")
        {
            audioSource.PlayOneShot(audioCorrect);
           // Destroy(collision.gameObject);
        }
        else
        {
            audioSource.PlayOneShot(audioMiss);
            //Destroy(collision.gameObject);
        }
    }
}
