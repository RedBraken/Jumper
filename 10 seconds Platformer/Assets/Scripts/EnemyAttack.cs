using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyAttack : MonoBehaviour
{
	public GameObject gameOverPrefab;

	void OnCollisionEnter2D(Collision2D other)
	{
		if (other.collider.CompareTag ("Player")) 
		{
			PlayerDeath (other);
		}
	}

	void PlayerDeath(Collision2D pla)
	{
		gameOverPrefab.gameObject.SetActive (true);
		Destroy (pla.gameObject);
		Time.timeScale = 0;
	}

	public void BackToMainMenu()
	{
		Time.timeScale = 1;
		SceneManager.LoadScene (0);
	}
}