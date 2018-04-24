using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudController : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.Translate(0.008f, 0, 0);
        if (transform.position.x > 9.7f)
        {
            transform.position = new Vector3(-3.35f,-2.16f,0);
        }
	}
}
