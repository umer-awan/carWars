using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testik : MonoBehaviour
{
    
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "car1") 
        {
            Debug.Log("its working");
        }
    }
}
