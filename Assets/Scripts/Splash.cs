using UnityEngine;
using System.Collections;

public class Splash : MonoBehaviour {

	private float timeOut;
	private GameObject levelManager;

	// Use this for initialization
	void Start () {
		levelManager = GameObject.Find ("Level Manager");
		timeOut = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
	
		if (Time.time - timeOut > 2) {
//			levelManager.LoadLevel ("Start Menu");
		}
	}
}
