using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AfterLife : MonoBehaviour
{
	public void CredScene()
	{
		SceneManager.LoadScene ("QuitGame");
	}
}