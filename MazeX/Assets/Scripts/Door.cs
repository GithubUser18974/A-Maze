using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour 
{
	// Create a boolean value called "locked" that can be checked in OnDoorClicked() 
	public bool locked = true;
	// Create a boolean value called "opening" that can be checked in Update() 
	public bool opening;
	//Create array for sound and sound source
	public AudioClip[] mySound;
	public AudioSource soundSource;

	void Update(){
		// If the door is opening and it is not fully raised

		if (opening && transform.position.y < 7f){
		soundSource.clip = mySound[0];
			soundSource.Play();
			// Animate the door raising up
			transform.Translate(0, 1.5f * Time.deltaTime, 0);
		}
	}
	public void OnDoorClicked() {
		// If the door is clicked and unlocked
		// Set the "opening" boolean to true
		if (locked==false){
			// Set the "opening" boolean to true
			Debug.Log("open");
			opening = true;
		}

		// (optionally) Else
		// Play a sound to indicate the door is locked
		else{
			Debug.Log ("sound");
		soundSource.clip = mySound[1];
			soundSource.Play();
		}
	}

	public void Unlock(){
		// You'll need to set "locked" to false here
		Debug.Log("enter unlock");
		locked = false;
	}
}
