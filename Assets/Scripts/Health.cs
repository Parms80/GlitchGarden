using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour {

	public float health = 100.0f;

	// Use this for initialization
	void Start () {
	}

	public void deductHealth (float amount) {
		health -= amount;
		if (health <= 0) {
			DestroyObject ();
		}
	}

	public void DestroyObject() {
		Destroy (gameObject);
	}
}
