using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basic3D : MonoBehaviour {

	public GameObject Mover;
	Vector3 movementright;
	Vector3 moveleft;
	Vector3 moveforward;
	Vector3 moveback;


	// Use this for initialization
	void Start () {
		movementright = new Vector3 (1, 0, 0);
		moveleft = new Vector3 (-1, 0, 0);
		moveforward = new Vector3 (0, 0, 1);
		moveback = new Vector3 (0, 0, -1);
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.D)) {
			Debug.Log ("true");
			Mover.transform.position += movementright;
		} else {
			Debug.Log ("false");
		}
		if (Input.GetKeyDown (KeyCode.A)) {
			Debug.Log ("true");
			Mover.transform.position += moveleft;
		}
		if (Input.GetKeyDown (KeyCode.W)) {
			Debug.Log ("true");
			Mover.transform.position += moveforward;
		}
		if (Input.GetKeyDown (KeyCode.S)) {
			Debug.Log ("true");
			Mover.transform.position += moveback;
		}
	}

}
