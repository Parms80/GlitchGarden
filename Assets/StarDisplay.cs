using UnityEngine;
using UnityEngine.UI;
using System.Collections;

[RequireComponent (typeof(Text))]
public class StarDisplay : MonoBehaviour {

	private Text starsText;
	private int numStars;

	// Use this for initialization
	void Start () {
		starsText = GetComponent<Text> ();
		numStars = 0;
	}

	public void AddStars (int amount) {
		print (amount + " stars added to display");
		numStars += amount;
		UpdateDisplay ();
	}

	public void UseStars (int amount) {
		numStars -= amount;
		UpdateDisplay ();
	}

	private void UpdateDisplay() {
		starsText.text = numStars.ToString ();
	}
}
