using UnityEngine;
using System.Collections;

public class Attacker : MonoBehaviour {

	private float currentSpeed;
	private GameObject currentTarget;
	private Animator animator;

	void Start () {
		animator = GetComponent<Animator>();
	}
	
	void Update () {
		transform.Translate (Vector3.left * currentSpeed * Time.deltaTime);
		if (!currentTarget) {
			animator.SetBool ("isAttacking", false);
		}
	}

	void OnTriggerEnter2D() {
	}

	public void SetSpeed (float speed) {
		currentSpeed = speed;
	}

	public void StrikeCurrentTarget (float damage) {
		Debug.Log (name + " doing " + damage + " damage");
		if (currentTarget) {
			Health healthComponent = currentTarget.GetComponent<Health> ();
			if (healthComponent) {
				healthComponent.deductHealth (damage);
			}
		}
	}

	public void Attack (GameObject obj) {
		currentTarget = obj;
	}
}
