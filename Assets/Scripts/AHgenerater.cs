using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AHgenerater : MonoBehaviour {

    public GameObject bear;
    public GameObject boy;
    public GameObject monster1;

    public int ahNum = 3;
    float interval = 0.0f;

    List<GameObject> prefabList = new List<GameObject>();
	// Use this for initialization
	void Start ()
    {
        prefabList.Add(bear);
        prefabList.Add(boy);
        prefabList.Add(monster1);

        InstantiateAnimalOrHuman();
    }
	
	// Update is called once per frame
	void Update ()
    {
        interval += Time.deltaTime;
        if(interval > 1.0f)
        {
            InstantiateAnimalOrHuman();
            interval = 0f;
        }
	}

    void InstantiateAnimalOrHuman()
    {
        int prefabIndex = Random.Range(0, ahNum);
        var fallObject =  Instantiate(prefabList[prefabIndex], transform.position, Quaternion.identity) as GameObject;
        fallObject.transform.Rotate (new Vector3(0,0,Random.Range(0, 360)));
    }
}
