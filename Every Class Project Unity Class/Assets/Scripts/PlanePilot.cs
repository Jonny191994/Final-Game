using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanePilot : MonoBehaviour {

	public float speed = 30.0f;

	public float CamzPos = 1.0f;

	public float bias = 0.84f;

	public AudioSource Explosion;


	// Use this for initialization
	void Start () {
		Explosion = GetComponent<AudioSource> ();

		Debug.Log ("plane Pilot script added to: " + gameObject);
	}

	// Update is called once per frame
	void FixedUpdate () {
		//camera intial position
		Vector3 moveCamTo = transform.position - transform.forward * CamzPos + Vector3.up * 2f;

		Camera.main.transform.position = Camera.main.transform.position * bias + 
															moveCamTo * (1.0f - bias);
		Camera.main.transform.LookAt (transform.position + transform.forward * 5f); 

		transform.position += transform.forward * Time.deltaTime * speed;

		speed -= transform.forward.y * Time.deltaTime * 50.0f;

		// keeps a min and max spd
		speed = Mathf.Clamp (speed, 10f, 45f);


		transform.Rotate (Input.GetAxis ("Vertical"), 0.0f, -Input.GetAxis ("Horizontal"));
	
		float terrainHeightWhereWeAre = Terrain.activeTerrain.SampleHeight (transform.position);

		if (terrainHeightWhereWeAre > transform.position.y) {
			transform.position = new Vector3 (transform.position.x,
											  terrainHeightWhereWeAre,
											  transform.position.z);
												Explosion.Play ();
												Destroy(gameObject);


		}
	}
}
