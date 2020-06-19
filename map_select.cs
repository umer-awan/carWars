using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class map_select : MonoBehaviour
{
    public static int map;    
    void Start()
    {
        map= 0;
    }

    
    void Update()
    {
        
    }
    public void Forest() 
    {
        map = 1;

    }
    public void Circuit() 
    {

        map = 2;
    }
    public void Desart()
    {

        map = 3;
    }
}
