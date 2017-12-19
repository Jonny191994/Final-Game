using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basic3DPlus : MonoBehaviour {

	public GameObject Mover;
	public int movementAnt = 10;


	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("left")) {
			Debug.Log ("Left pressed down");
			Mover.transform.position += new Vector3 (-movementAnt, 0, 0);
		} else {
			Debug.Log ("false");
		}
		if (Input.GetKeyDown ("right")) {
			Debug.Log ("true");
			Mover.transform.position += new Vector3 (movementAnt, 0, 0);
		}
		if (Input.GetKeyDown ("up")) {
			Debug.Log ("true");
			Mover.transform.position += new Vector3 (0, 0, movementAnt);
		}
		if (Input.GetKeyDown ("down")) {
			Debug.Log ("true");
			Mover.transform.position += new Vector3 (0, 0, -movementAnt);
		}
	}

}
