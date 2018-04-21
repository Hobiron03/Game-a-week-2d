using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpringController : MonoBehaviour {

    public GameObject springDefault;
    public GameObject springRight;
    public GameObject springLeft;
    public GameObject springOpen;

    Animator animatorD;
    Animator animatorR;
    Animator animatorL;


    public enum SPEING_DIR
    {
        DEFAULT,
        RIGHT,
        LEFT,
        OPEN,
    }

    public SPEING_DIR springDir = SPEING_DIR.DEFAULT;

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
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            PushOpenButton();
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
                springOpen.SetActive(false);
                break;
            case SPEING_DIR.RIGHT:
                springDefault.SetActive(false);
                springRight.SetActive(true);
                springLeft.SetActive(false);
                springOpen.SetActive(false);
                break;
            case SPEING_DIR.LEFT:
                springDefault.SetActive(false);
                springRight.SetActive(false);
                springLeft.SetActive(true);
                springOpen.SetActive(false);
                break;
            case SPEING_DIR.OPEN:
                springDefault.SetActive(false);
                springRight.SetActive(false);
                springLeft.SetActive(false);
                springOpen.SetActive(true);
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

    public void PushOpenButton()
    {
        springDir = SPEING_DIR.OPEN;
    }


    //Bound.cs 用のメソッド
    public SPEING_DIR Right()
    {
        return SPEING_DIR.RIGHT;
    }

    public SPEING_DIR Left()
    {
        return SPEING_DIR.LEFT;
    }

    public SPEING_DIR Dfault()
    {
        return SPEING_DIR.DEFAULT;
    }
}
