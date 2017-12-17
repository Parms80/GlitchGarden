using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour {

	public float speed, damage;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (Vector3.right * speed * Time.deltaTime);
	}

	public void OnTriggerEnter2D(Collider2D otherCollider) {

		GameObject otherObject = otherCollider.gameObject;			
		Health health = otherObject.GetComponent<Health>();
		Attacker attacker = otherObject.GetComponent<Attacker>();

		if (health && attacker) {
			health.deductHealth (damage);
			Destroy (gameObject);
		}
	}
}
