﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour {

	//Drag in the Bullet Emitter from the Component Inspector.
	public GameObject Bullet_Emitter;

	//Drag in the Bullet Prefab from the Component Inspector.
	public GameObject Bullet;

	//Enter the Speed of the Bullet from the Component Inspector.
	public float Bullet_Forward_Force;


	// Use this for initialization
	void Start ()
	{

	}

	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKeyDown("space"))
		{
			//The Bullet instantiation happens here.
			GameObject Temporary_Bullet_Handler;
			Temporary_Bullet_Handler = Instantiate(Bullet,Bullet_Emitter.transform.position,Bullet_Emitter.transform.rotation) as GameObject;

			//Fixed a rotating axis bug
			//Temporary_Bullet_Handler.transform.Rotate(Vector3.left * 90);

			//Get rigidbody from the instantiated object
			Rigidbody Temporary_RigidBody;
			Temporary_RigidBody = Temporary_Bullet_Handler.GetComponent<Rigidbody>();


	    	//Tell the bullet to be "pushed" forward by an amount set by Bullet_Forward_Force.
			Temporary_RigidBody.velocity =GetComponent<PlanePilot>().speed * transform.forward * Time.deltaTime;
			Temporary_RigidBody.AddForce(transform.forward * Bullet_Forward_Force);

			Debug.Log(Temporary_RigidBody.velocity);
			//Basic Clean Up, set the Bullets to self destruct after 5 Seconds, 
			Destroy(Temporary_Bullet_Handler, 5.0f);
		}
	}
}