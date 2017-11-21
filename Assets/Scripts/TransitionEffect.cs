using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TransitionEffect : MonoBehaviour {

	public float fadeInTime;

	private Image fadePanel;
	private Color currentColour = Color.black;

	void Start () {
		fadePanel = GetComponent<Image> ();
//		fadePanel.CrossFadeAlpha(0.0f, 2.0f, false);

	}

	void Update () {
		if (Time.timeSinceLevelLoad < fadeInTime) {
			float alphaStep = Time.deltaTime / fadeInTime;
			currentColour.a -= alphaStep;
			fadePanel.color = currentColour;
		} else {
			gameObject.SetActive (false);
		}
	}
}
