using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;

public class scoreManager : MonoBehaviour
{
    public Text highScore;
    public Text gameScore;

    public float scoreCount;
    public float highScoreCount;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameScore.text = ("Score: " + scoreCount);
        highScore.text = ("High Score: " + highScoreCount);
    }
}
