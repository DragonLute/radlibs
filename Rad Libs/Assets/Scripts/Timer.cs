﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class Timer : MonoBehaviour {
	
	public static float timeLimit;
	public Text timerLabel;

	
	void Awake () 
	{
		timeLimit = 45.0f;
	}
	
	void Update () 
	{
		timeLimit -= Time.deltaTime;
		int roundedTL = (int)(timeLimit + 0.5f);
		if (timeLimit < 0)
			timeLimit = 0;
		
		if (timeLimit < 0)
		{
			//Debug.Log("Time's Up!");
		}
		
		timerLabel.text = Convert.ToString(roundedTL);
	}
}
