﻿using UnityEngine;
using System.Collections;

public class Defender : MonoBehaviour {

	public int starCost = 100;
	private StarDisplay starDisplay;

	void Start () {
		starDisplay = GameObject.FindObjectOfType<StarDisplay> ();
		Debug.Log ("Defender: starDisplay = " + starDisplay);
	}

	// Only being used as a tag for now
	public void AddStars (int amount) {
		starDisplay.AddStars (amount);
	}

	public void UseStars (int amount) {
		starDisplay.UseStars (amount);
	}
}
