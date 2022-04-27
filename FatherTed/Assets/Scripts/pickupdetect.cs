using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickupdetect : MonoBehaviour
{
    public bool close;
    public bool on = true;
    public bool grabbing = false;

    public float Timer = 0.0f;
    public float time = 2; //wait time

    private void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Targetable" && on)
        {
            Debug.Log("triggerentering");
            close = true;
            on = false;

        }

    }

    private void OnTriggerExit(Collider col)
    {
        if (col.tag == "Targetable")
        {
            close = false;
            on = true;
        }
    }

    public void Update()
    {
        grabbing = GameObject.Find("Pickuper").GetComponent<pickuper>().grab;

        if (grabbing)
        {
            close = false;
        }
        //Timers();
    }

    /* void Timers()
     {
         Timer += Time.deltaTime;

         if (Timer > time && !on)
         {
             Timer = Timer - time;
             close = false;
             Debug.Log("TimerPickuPDetect");

         }
     }*/
}