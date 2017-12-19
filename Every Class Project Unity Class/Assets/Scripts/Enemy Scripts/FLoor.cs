using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FLoor : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float terrainHeightWhereWeAre = Terrain.activeTerrain.SampleHeight (transform.position);

		if (terrainHeightWhereWeAre > transform.position.y) {
			transform.position = new Vector3 (transform.position.x,
				terrainHeightWhereWeAre,
				transform.position.z);
		}
	}
}
