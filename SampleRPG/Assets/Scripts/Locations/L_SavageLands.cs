﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L_SavageLands : Interactable {
	public string[] dialogue;
	public string name; 

	public override void Interact()
	{
		Debug.Log("Interacting with a location: The Savage Lands.");
	}

}
