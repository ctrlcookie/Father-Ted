using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissionsComplete : MonoBehaviour
{
    [SerializeField] DoMission DM1;
    [SerializeField] DoMission DM2;
    public int MT; //Missions Total

    void Update()
    {
        if (DM1.MD = true)
        {
            MT += 1;
        }
        
        if (DM2.MD = true)
        {
            MT += 1;
        }
    }
}
