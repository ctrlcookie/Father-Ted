using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoMission : MonoBehaviour
{
    public int MD; //missions done
    public GameObject currentMission;
    public GameObject currentLight;

    public Slider slider;

    public GameObject[] missionEntry;
    public GameObject[] lightList;

    public void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("MissionPoint"))
        {
            if (Input.GetKey(KeyCode.Mouse0) || Input.GetKey(KeyCode.E))
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
        currentLight = lightList[MD];

        currentMission.GetComponent<Animator>().SetBool("shouldopen", true);
        currentLight.GetComponent<Light>().color = Color.cyan;

    }

    public void OnTriggerExit(Collider other)
    {
        Debug.Log("TRIGGEREXITING" + other.name);

        if (other.CompareTag("MissionExit"))//&& MD != 0
        {
            missionEntry[MD - 1].GetComponent<Animator>().SetBool("missioncomplete", true);
            //add noise for it closing
            lightList[MD - 1].GetComponent<Light>().color = Color.green;
        }
    }

}
