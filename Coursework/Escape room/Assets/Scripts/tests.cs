﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tests : MonoBehaviour
{
    public static string correctCode = "1213";
    public static string playerCode = "";
    public static int totalDigits = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(playerCode);
        if (totalDigits == 4)
        {
            if (playerCode == correctCode)
            {
                Debug.Log("Correct");
                playerCode = "";
                totalDigits = 0;


            }
            else
            {
                Debug.Log("Incorrect");
                playerCode = "";
                totalDigits = 0;
            }
        }
    }
}
