using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeMechanic : MonoBehaviour
{
	public float Timer = 11;
	public Text timeText;
	public GameObject gameOver;

	void Update()
	{
		Timer -= Time.deltaTime;
		timeText.text = "Time left : " + Timer.ToString ("f1");
		if (Timer <= 0) 
		{
			gameOver.gameObject.SetActive (true);
			Time.timeScale = 0;
		}
	}
}