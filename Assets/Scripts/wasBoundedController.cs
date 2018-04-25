using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wasBoundedController : MonoBehaviour {

    public
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    public void TriggerOn()
    {
        Invoke("ColliderOn", 0.1f);
    }

    void ColliderOn()
    {
         gameObject.GetComponent<BoxCollider2D>().enabled = true;
    }
}
