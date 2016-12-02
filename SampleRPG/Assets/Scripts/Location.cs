using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Location : Interactable {
	public string[] dialogue;
	public string name; 

	public override void Interact()
	{
		Debug.Log("Interacting with Location.");
	}

}
