using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour {

	public GameObject player;

		void OnCollisionEnter2D(Collision2D col)
		{
			if (col.gameObject.tag == "Death")
			{
				SceneManager.LoadScene("Flight sim");
			}
		}
	}
