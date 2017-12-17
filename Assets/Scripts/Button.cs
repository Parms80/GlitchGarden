using UnityEngine;
using System.Collections;

public class Button : MonoBehaviour {

	public static GameObject selectedDefender;
	public GameObject defenderPrefab;
	private Button[] buttonArray;

	void Start () {
		GetComponent<SpriteRenderer>().color = Color.black;
		buttonArray = GameObject.FindObjectsOfType<Button> ();
	}
	
	void Update () {
	}

	void OnMouseDown() {
		deselectAllOtherDefenders ();
		selectThisDefender ();
	}

	void deselectAllOtherDefenders() {
		foreach (Button thisButton in buttonArray) {
			thisButton.GetComponent<SpriteRenderer>().color = Color.black;
		}
	}

	void selectThisDefender() {
		GetComponent<SpriteRenderer> ().color = Color.white;
		selectedDefender = defenderPrefab;
	}
}
