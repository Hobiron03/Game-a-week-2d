using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpringManager : MonoBehaviour {

    public GameObject childSpring1;
    public GameObject childSpring2;

    Animator animator1;
    Animator animator2;
    // Use this for initialization
    void Start ()
    {
        animator1 = childSpring1.GetComponent<Animator>();
        animator2 = childSpring2.GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        animator1.SetTrigger("Bound");
        animator2.SetTrigger("Bound");
    }
}
