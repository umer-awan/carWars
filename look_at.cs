using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class look_at : MonoBehaviour
{
    public GameObject camera;
    void Start()
    {
        
    }


    void Update()
    {
        this.transform.LookAt(camera.transform);
    }
}
