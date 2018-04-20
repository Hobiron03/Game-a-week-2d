using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpringController : MonoBehaviour {

    public GameObject springDefault;
    public GameObject springRight;
    public GameObject springLeft;

    public enum SPEING_DIR
    {
        DEFAULT,
        RIGHT,
        LEFT,
    }

    private SPEING_DIR springDir = SPEING_DIR.DEFAULT;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		switch(springDir)
        {
            case SPEING_DIR.DEFAULT:
                springDefault.SetActive(true);
                break;
        }
	}
}
