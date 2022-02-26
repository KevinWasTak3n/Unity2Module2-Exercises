using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateDestroy : MonoBehaviour
{
    //create variables below 
    public GameObject prefab;
    public float delayDestroy = 0.5f;

    // Update is called once per frame
    void Update()
    {
        //WRITE CODE HERE
        if (Input.GetKey(KeyCode.Mouse0))
            {
            GameObject clone = Instantiate(prefab);
            Destroy(clone, delayDestroy);
            }
        //END OF CODE
    }
}
