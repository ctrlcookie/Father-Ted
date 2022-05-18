using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeddyCounter : MonoBehaviour
{
    public float tC; //Teddy Counter
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Targetable"))
        {
            tC += 1;
            UITeddyCounter.scoreValue -= 1;
        }
    }
}
