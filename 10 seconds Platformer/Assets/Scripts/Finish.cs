﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.CompareTag("Gator")) 
		{
			SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
			print ("You finished the level!!");
		}
	}
}