using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Button : MonoBehaviour {

	public static GameObject selectedDefender;
	public GameObject defenderPrefab;
	private Button[] buttonArray;
	private Text costText;

	void Start () {
		GetComponent<SpriteRenderer>().color = Color.black;
		buttonArray = GameObject.FindObjectsOfType<Button> ();
//		Component defender = defenderPrefab.GetComponent<Defender>;
		costText = GetComponentInChildren<Text>();
		if (!costText) {
			Debug.LogWarning (name + " has no cost");
		}
		costText.text = defenderPrefab.GetComponent<Defender>().starCost.ToString();
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
