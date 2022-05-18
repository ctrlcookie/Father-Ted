using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoMission : MonoBehaviour
{
    public int MD; //missions done
    public GameObject currentMission;
    public Slider slider;

    public GameObject[] missionEntry;


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

        currentMission = missionEntry[MD];
        currentMission.GetComponent<Animator>().SetBool("shouldopen", true);


    }

    public void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("MissionExit") && MD != 0)
        {
            missionEntry[MD - 1].GetComponent<Animator>().SetBool("missioncomplete", true);

        }
    }
}
