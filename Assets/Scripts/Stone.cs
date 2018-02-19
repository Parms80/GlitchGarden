using UnityEngine;
using System.Collections;

public class Stone : MonoBehaviour {

	private Animator anim;

	void Start () {
		anim = GetComponent<Animator>();
	}

	// Only being used as a tag for now
	void OnTriggerStay2D(Collider2D otherCollider) {

		GameObject otherObject = otherCollider.gameObject;

		if (otherObject.GetComponent<Projectile> ()) {
			return;
		}

		anim.SetTrigger ("underAttackTrigger");
	}
}
