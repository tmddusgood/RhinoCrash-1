﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ComboScore : MonoBehaviour
{
    Text t;

    // Start is called before the first frame update
    void Start()
    {
        t = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        //To show how long does it take
        t.text = "Score : " + PlayerController.score;
    }
}
