using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpringController : MonoBehaviour {

    public GameObject springDefault;
    public GameObject springRight;
    public GameObject springLeft;

    Animator animatorD;
    Animator animatorR;
    Animator animatorL;


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
        //キーボード用の操作
        if (Input.GetKey(KeyCode.RightArrow))
        {
            PushRightButton();
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            PushLeftButton();
        }
        else
        {
            ReleaseButton();
        }




		switch(springDir)
        {
            case SPEING_DIR.DEFAULT:
                springDefault.SetActive(true);
                springRight.SetActive(false);
                springLeft.SetActive(false);
                break;
            case SPEING_DIR.RIGHT:
                springDefault.SetActive(false);
                springRight.SetActive(true);
                springLeft.SetActive(false);
                break;
            case SPEING_DIR.LEFT:
                springDefault.SetActive(false);
                springRight.SetActive(false);
                springLeft.SetActive(true);
                break;
        }
	}

    public void PushRightButton()
    {
        springDir = SPEING_DIR.RIGHT;
    }

    public void PushLeftButton()
    {
        springDir = SPEING_DIR.LEFT;
    }

    public void ReleaseButton()
    {
        springDir = SPEING_DIR.DEFAULT;
    }
}
