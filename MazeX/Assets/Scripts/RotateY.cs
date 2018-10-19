using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateY : MonoBehaviour {

    public float vSpeed = 15.0f;
    void Update () {

        this.gameObject.transform.Rotate(transform.forward);
	}
}
