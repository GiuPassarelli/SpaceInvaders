﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lives : MonoBehaviour
{
    public static int numLives = 3;
    Text lives;

    // Start is called before the first frame update
    void Start(){}

    // Update is called once per frame
    void Update()
    {
        gameObject.GetComponent<Text>().text = "Vidas " + numLives;
    }
}
