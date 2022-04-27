using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickuper : MonoBehaviour
{
    public bool grab;
    public bool retrac;


    private void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Targetable")
        {
            grab = true;

        }

        if (col.name == "Player")
        {
            retrac = true;
        }
    }

    private void OnTriggerExit(Collider col)
    {
        if (col.tag == "Targetable")
        {
            grab = false;
        }

    }


}
