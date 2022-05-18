using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UITeddyCounter : MonoBehaviour
{
    public static int scoreValue;
    Text score;

    void Start()
    {
        scoreValue = 16;
        score = GetComponent<Text>();
    }

    void Update()
    {
        score.text = "Teddies Left: " + scoreValue;
    }
}
