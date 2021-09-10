using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script : MonoBehaviour
{
    public GameObject gameObject1;
    public GameObject gameObject2;
    

    void Start()
    {
        if(gameObject1 == true)
        {
            gameObject2.transform.Rotate(3, 5, 7);
            Debug.Log("The object is rotating");
        }    
    }
    void OnDisable()
    {
        Debug.Log("The Object is Disable");
    }

}
