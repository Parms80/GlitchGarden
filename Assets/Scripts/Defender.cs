﻿using UnityEngine;
using System.Collections;

public class Defender : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void onTriggerEnter2D() {
		Debug.Log (name + " trigger enter");
	}
}
