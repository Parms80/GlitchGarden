using UnityEngine;
using System.Collections;

[RequireComponent (typeof (Attacker))]
public class lizard : Attacker {
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

		anim.SetBool ("isAttacking", true);
		attacker.Attack (otherObject);
	}
}
