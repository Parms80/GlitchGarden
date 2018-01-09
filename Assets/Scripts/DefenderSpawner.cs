using UnityEngine;
using System.Collections;

public class DefenderSpawner : MonoBehaviour {

	public Camera myCamera;
	private GameObject parent;
	private StarDisplay starDisplay;

	void Start () {
		parent = GameObject.Find ("Defenders");
		starDisplay = GameObject.FindObjectOfType<StarDisplay>();
		Debug.Log ("DefenderSpawner: starDisplay = " + starDisplay);
		if (!parent) {
			parent = new GameObject ("Projectiles");
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown() {
		AddDefenderToGrid ();
	}

	void AddDefenderToGrid() {
		Vector2 rawPos = CalculateWorldPointOfMouseClick ();
		Vector2 roundedPos = SnapToGrid (rawPos);
		GameObject defender = Button.selectedDefender;

		int starCost = defender.GetComponent<Defender>().starCost;
		if (starDisplay.UseStars (starCost) == StarDisplay.Status.SUCCESS) {
			Quaternion zeroRot = Quaternion.identity;
			GameObject newDefender = Instantiate (defender, roundedPos, zeroRot) as GameObject;
			newDefender.transform.parent = parent.transform;
		} else {
			Debug.Log ("Insufficient stars to spawn");
		}
	}

	Vector2 CalculateWorldPointOfMouseClick() {
		Vector3 worldPoint = myCamera.ScreenToWorldPoint (Input.mousePosition);
		return new Vector2 (worldPoint.x, worldPoint.y);
	}

	Vector2 SnapToGrid (Vector2 rawWorldPos) {
		float newX = Mathf.RoundToInt (rawWorldPos.x);
		float newY = Mathf.RoundToInt (rawWorldPos.y);
		return new Vector2 (newX, newY);
	}
}
