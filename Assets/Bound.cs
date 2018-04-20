using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bound : MonoBehaviour {

    public GameObject childSpring1;
    public GameObject childSpring2;
    public GameObject springs;

    public AudioClip audioClip;

    Animator animator1;
    Animator animator2;

    Rigidbody2D shotBody;

    SpringController springController;
    // Use this for initialization
    void Start()
    {
        animator1 = childSpring1.GetComponent<Animator>();
        animator2 = childSpring2.GetComponent<Animator>();

        springController = springs.GetComponent<SpringController>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        animator1.SetTrigger("Bound");
        animator2.SetTrigger("Bound");

        AudioSource.PlayClipAtPoint(audioClip, transform.position);

        shotBody = collision.gameObject.GetComponent<Rigidbody2D>();

        if (springs.GetComponent<SpringController>().springDir == springController.Right() )
        {
                
            shotBody.AddForce(new Vector2(100.0f, 300.0f));
        }
        else if (springs.GetComponent<SpringController>().springDir == springController.Left())
        {
            shotBody.AddForce(new Vector2(-100.0f, 300.0f));
        }
        
    }
}
