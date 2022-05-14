using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderValue : MonoBehaviour
{
    public int maximum = 5;
    public GameObject player;
    [SerializeField] private DoMission DM;
    public Slider slider;

    public void TheScore()
    {
        float fillAmount = (float) DM.MD / (float)maximum;
    }
}
