﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreScript_1 : MonoBehaviour {
    public Text showScore;
    public int score = 0;
	// Use this for initialization
	void Start () {

			}

    // Update is called once per frame
    void Update() {
        score++;
        showScore.text = score.ToString();
    }
}
