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

    int iRandomNum = 0;
    Vector2 randomR1 = new Vector2(200.0f, 530.0f);
    Vector2 randomR2 = new Vector2(200.0f, 700.0f);
    Vector2 randomR3 = new Vector2(200.0f, 660.0f);

    Vector2 randomL1 = new Vector2(-200.0f, 430.0f);
    Vector2 randomL2 = new Vector2(-200.0f, 600.0f);
    Vector2 randomL3 = new Vector2(-200.0f, 660.0f);

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


    private void OnTriggerEnter2D(Collider2D collision)
    {
        animator1.SetTrigger("Bound");
        animator2.SetTrigger("Bound");

        AudioSource.PlayClipAtPoint(audioClip, transform.position);

        shotBody = collision.gameObject.GetComponent<Rigidbody2D>();

        iRandomNum = Random.Range(1, 11);
        if (springs.GetComponent<SpringController>().springDir == springController.Right())
        {
            if (1 <= iRandomNum && iRandomNum <= 4)
            {
                shotBody.AddForce(randomR1);
            }
            else if (5 <= iRandomNum && iRandomNum <= 8)
            {
        
                shotBody.AddForce(randomR2);
            }
            else
            {
              
                shotBody.AddForce(randomR3);
            }


        }
        else if (springs.GetComponent<SpringController>().springDir == springController.Left())
        {
            if (1 <= iRandomNum && iRandomNum <= 5)
            {
                
                shotBody.AddForce(randomL1);
            }
            else if (6 <= iRandomNum && iRandomNum <= 9)
            {
                
                shotBody.AddForce(randomL2);
            }
            else
            {
               
                shotBody.AddForce(randomL3);
            }
        }
    }

    IEnumerator ColliderOn(GameObject fallObject)
    {
        yield return new WaitForSeconds(0.3f);

        fallObject.GetComponent<BoxCollider2D>().enabled = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        collision.gameObject.GetComponent<BoxCollider2D>().enabled = false;

        StartCoroutine("ColliderOn", collision.gameObject);
    }

    
}
