using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHp : MonoBehaviour {


	public int life = 0;
	public int Score = 0;
	public void OnCollisionEnter(Collision boom)
	{
		//If the object that triggered this collision is tagged "bullet"
		if (boom.gameObject.tag == "Bullet") {
			life += 1;
			Score += 1;
			if (life == 1)
				Destroy (gameObject);

		}	
	}
}