using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class check_point : MonoBehaviour
{
    public GameObject car1;
    public int car1lap;
    public int car1wave;



    public GameObject car2;
    public int car2lap;
    public int car2wave;


    public GameObject car3;
    public int car3lap;
    public int car3wave;



    public GameObject car4;
    public int car4lap;
    public int car4wave;



    public GameObject wavepoint1;
    public GameObject wavepoint2;
    public GameObject wavepoint3;
    public GameObject wavepoint4;


    public Text car1pos;
    public Text car2pos;
    public Text car3pos;
    public Text car4pos;

    [HideInInspector]
    public bool alpha1;
    [HideInInspector]
    public bool alpha2;
    [HideInInspector]
    public bool alpha3;
    [HideInInspector]
    public bool alpha4;
    [HideInInspector]
    public bool beta1;
    [HideInInspector]
    public bool beta2;
    [HideInInspector]
    public bool beta3;
    [HideInInspector]
    public bool beta4;
    [HideInInspector]
    public bool charlie1;
    [HideInInspector]
    public bool charlie2;
    [HideInInspector]
    public bool charlie3;
    [HideInInspector]
    public bool charlie4;
    [HideInInspector]
    public bool delta1;
    [HideInInspector]
    public bool delta2;
    [HideInInspector]
    public bool delta3;
    [HideInInspector]
    public bool delta4;



    void Start()
    {


    }
    void Update()
    {
        //between wavepoints
        if (alpha1 && (alpha2||alpha2||alpha3||alpha4))
        {
            if (alpha2) 
            {
            if(Vector3.Distance(car1.transform.position,wavepoint2.transform.position)> Vector3.Distance(car2.transform.position, wavepoint2.transform.position)) 
                {
                
                }
            }
            if (alpha3)
            {
                if (Vector3.Distance(car1.transform.position, wavepoint2.transform.position) > Vector3.Distance(car3.transform.position, wavepoint2.transform.position))
                {

                }
            }
            if (alpha4)
            {
                if (Vector3.Distance(car1.transform.position, wavepoint2.transform.position) > Vector3.Distance(car4.transform.position, wavepoint2.transform.position))
                {

                }
            }
            if (alpha1 && alpha2)
            {
             
            


            }
            if (alpha2 && alpha4)
            {
               
            }
            if (alpha3 && alpha4)
            {

            }
            if (alpha2 && alpha4)
            {

            }
            if (alpha2 && alpha3 && alpha4)
            {

            }
            if (alpha1 && alpha2 && alpha3)
            {

            }
            if (alpha1 && alpha3 && alpha4)
            {

            }
            if (alpha1 && alpha2 && alpha3 && alpha4)
            {

            }
        }
      




        //first
        if (car1lap > car2lap && car1lap > car3lap && car1lap > car4lap)
        {
            car1pos.text = "First";

        }

        if (car2lap > car1lap && car2lap > car3lap && car2lap > car4lap)
        {

            car2pos.text = "First";
        }

        if (car3lap > car2lap && car3lap > car1lap && car3lap > car4lap)
        {
            car3pos.text = "First";

        }

        if (car4lap > car2lap && car4lap > car3lap && car4lap > car1lap)
        {

            car4pos.text = "First";
        }
        if (car1wave > car2wave && car1wave > car3wave && car1wave > car4wave)
        {

            car1pos.text = "First";
        }
        if (car2wave > car1wave && car2wave > car3wave && car2wave > car4wave)
        {

            car2pos.text = "First";
        }
        if (car3wave > car2wave && car3wave > car1wave && car3wave > car4wave)
        {

            car3pos.text = "First";
        }
        if (car4wave > car2wave && car4wave > car3wave && car4wave > car1wave)
        {

            car4pos.text = "First";
        }


        //last

        if (car1lap < car2lap && car1lap < car3lap && car1lap < car4lap)
        {

            car1pos.text = "last";
        }

        if (car2lap < car1lap && car2lap < car3lap && car2lap < car4lap)
        {

            car2pos.text = "last";
        }

        if (car3lap < car2lap && car3lap < car1lap && car3lap < car4lap)
        {

            car3pos.text = "last";
        }

        if (car4lap < car2lap && car4lap < car3lap && car4lap < car1lap)
        {

            car4pos.text = "last";
        }
        if (car1wave < car2wave && car1wave < car3wave && car1wave < car4wave)
        {

            car1pos.text = "last";
        }
        if (car2wave < car1wave && car2wave < car3wave && car2wave < car4wave)
        {
            car2pos.text = "last";

        }
        if (car3wave < car2wave && car3wave < car1wave && car3wave < car4wave)
        {

            car3pos.text = "last";
        }
        if (car4wave < car2wave && car4wave < car3wave && car4wave < car1wave)
        {
            car4pos.text = "last";

        }

        //second
        if ((car1wave < car2wave || car1wave < car3wave || car1wave < car4wave ) && (car1wave > car3wave || car1wave > car2wave) && (car1wave > car4wave || car1wave > car2wave)) 
        {
            car1pos.text = "second";
        }
        if ((car2wave < car1wave || car2wave < car3wave || car2wave < car4wave) && (car2wave > car3wave || car2wave > car1wave) && (car2wave > car4wave || car2wave > car1wave))
        {
            car2pos.text = "second";
        }
        if ((car3wave < car2wave || car3wave < car1wave || car3wave < car4wave) && (car3wave > car1wave || car3wave > car2wave) && (car3wave > car4wave || car3wave > car2wave))
        {
            car3pos.text = "second";
        }
        if ((car4wave < car2wave || car4wave < car3wave || car4wave < car1wave) && (car4wave > car3wave || car4wave > car2wave) && (car4wave > car1wave || car4wave > car2wave))
        {
            car4pos.text = "second";
        }

        //third
        if ((car1wave > car2wave || car1wave > car3wave || car1wave > car4wave) && (car1wave < car3wave || car1wave < car2wave) && (car1wave < car4wave || car1wave < car2wave))
        {
            car1pos.text = "third";
        }
        if ((car2wave > car1wave || car2wave > car3wave || car2wave > car4wave) && (car2wave < car3wave || car2wave < car1wave) && (car2wave < car4wave || car2wave < car1wave))
        {
            car2pos.text = "third";
        }
        if ((car3wave > car2wave || car3wave > car1wave || car3wave > car4wave) && (car3wave < car1wave || car3wave < car2wave) && (car3wave < car4wave || car3wave < car2wave))
        {
            car3pos.text = "third";
        }
        if ((car4wave > car2wave || car4wave > car3wave || car4wave > car1wave) && (car4wave < car3wave || car4wave < car2wave) && (car4wave < car1wave || car4wave < car2wave))
        {
            car4pos.text = "third";
        }


    }


}
