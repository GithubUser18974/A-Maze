using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour {

	// Use this for initialization
	public GameObject coinrotate;
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		coinrotate.transform.Rotate(0f,1000*Time.deltaTime,0f);
	}
}
