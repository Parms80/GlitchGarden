using UnityEngine;
using UnityEngine.UI;
using System.Collections;

[RequireComponent (typeof(Text))]
public class StarDisplay : MonoBehaviour {

	public enum Status {SUCCESS, FAILURE};
	public int numStars = 100;
	private Text starsText;

	// Use this for initialization
	void Start () {
		starsText = GetComponent<Text> ();
		UpdateDisplay ();
	}

	public void AddStars (int amount) {
		print (amount + " stars added to display");
		numStars += amount;
		UpdateDisplay ();
	}

	public Status UseStars (int amount) {
		if (numStars >= amount) {
			numStars -= amount;
			UpdateDisplay ();
			print ("SUCCESS");
			return Status.SUCCESS;
		}
		print ("FAILURE");
		return Status.FAILURE;
	}

	private void UpdateDisplay() {
		starsText.text = numStars.ToString ();
	}
}
