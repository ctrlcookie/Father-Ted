using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoMission : MonoBehaviour
{
    public bool MD; //Mission Done
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (Input.GetKey(KeyCode.Mouse0))
            {
                MD = true;
            }
        }
    }
}
