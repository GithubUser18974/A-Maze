using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour 
{
	//Create a reference to the KeyPoofPrefab and Door
	public GameObject KeyPoofPrefab;
	public bool CollectedKey;
	public GameObject door;

	void Update(){
		//Not required, but for fun why not try adding a Key Floating Animation here :)
		transform.Translate(0, 0.05f * Mathf.Sin(Time.time * 2f), 0, Space.World);
	}

	public void OnKeyClicked(){
		// Instatiate the KeyPoof Prefab where this key is located
		// Make sure the poof animates vertically
		Instantiate(KeyPoofPrefab, transform.position, Quaternion.identity);
		// Call the Unlock() method on the Door
		door.GetComponent<Door>().Unlock();
		// Set the Key Collected Variable to true
		CollectedKey = true;
		// Destroy the key. Check the Unity documentation on how to use Destroy
		Destroy(gameObject);
	}
}
