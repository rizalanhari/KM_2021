﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld2 : MonoBehaviour
{
    // Start is called before the first frame update
    public string myText;
    void Start()
    {
        //Debug.Log("Hello World");
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("myText");
    }
    void OnGUI()
    {
        GUILayout.BeginArea(new Rect(10, 10, 200, 200));
        GUILayout.Label(myText);
        GUILayout.EndArea();
    }
}
