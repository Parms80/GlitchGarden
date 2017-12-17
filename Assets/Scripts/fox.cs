using UnityEngine;
using System.Collections;

[RequireComponent (typeof (Attacker))]
public class fox : Attacker {
	private Animator anim;
	private Attacker attacker;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
		attacker = GetComponent<Attacker>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnTriggerEnter2D(Collider2D otherCollider) {

		GameObject otherObject = otherCollider.gameObject;

		if (!otherObject.GetComponent<Defender> ()) {
			return;
		}

		if (otherObject.GetComponent<Stone> ()) {
			anim.SetTrigger ("jump trigger");
		} else {
			anim.SetBool ("isAttacking", true);
			attacker.Attack (otherObject);
		}
	}
}
