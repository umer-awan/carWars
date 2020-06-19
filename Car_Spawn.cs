using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car_Spawn : MonoBehaviour
{
    public GameObject[] car;
    public GameObject spawn_location;
    void Start()
    {
        if (Car_selection.car_selection == 0) 
        {
            car[0].SetActive(true);
        }
        if (Car_selection.car_selection == 1)
        {
            car[1].SetActive(true);
        }
        if (Car_selection.car_selection == 2)
        {
            car[2].SetActive(true);
        }
        if (Car_selection.car_selection == 3)
        {
            car[3].SetActive(true);
        }
        if (Car_selection.car_selection == 4)
        {
            car[4].SetActive(true);
        }
        if (Car_selection.car_selection == 5)
        {
            car[5].SetActive(true);
        }
        if (Car_selection.car_selection == 6)
        {
            car[6].SetActive(true);
        }
        if (Car_selection.car_selection == 7)
        {
            car[7].SetActive(true);
        }

    }


    void Update()
    {
        
    }
}
