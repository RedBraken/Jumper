using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCollect : MonoBehaviour
{
	public Text countText;

	private int count;

	void Start()
	{
		count = 0;
		SetCount ();
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.CompareTag ("Coin")) 
		{
			print ("You collected an item!!");
			Destroy (other.gameObject);
			count += 1;
			SetCount ();
		}
	}
	void SetCount()
	{
		countText.text = "Coins : " + count.ToString ();
	}
}