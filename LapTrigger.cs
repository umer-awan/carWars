using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LapTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "car1")
        {
            Positioning_System.Lap1 += 1000000000;

        }
        if (other.tag == "car2")
        {

            Positioning_System.Lap1 += 1000000000;
        }
        if (other.tag == "car3")
        {

            Positioning_System.Lap1 += 1000000000;
        }
        if (other.tag == "car4")
        {

            Positioning_System.Lap1 += 1000000000;
        }
    }
}
