using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;

public class scoreManager : MonoBehaviour
{
    public GUIText highScore;
    public GUIText gameScore;

    public float scoreCount = 0f;
    public float highScoreCount = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //GetComponent<Canvas>;
        gameScore.text = ("Score: " + scoreCount);
        highScore.text = ("High Score: " + highScoreCount);
    }
}
