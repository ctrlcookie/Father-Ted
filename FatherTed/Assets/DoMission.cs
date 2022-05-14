using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoMission : MonoBehaviour
{
    public float MD;
    public Slider slider;
    public void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("MissionPoint"))
        {
            if (Input.GetKey(KeyCode.Mouse0))
            {
                MD += 1;
                other.gameObject.SetActive(false);
            }
        }
    }

     void Update()
    {
        slider.value = MD;
    }
}
