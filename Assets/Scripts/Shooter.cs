using UnityEngine;
using System.Collections;

public class Shooter : MonoBehaviour {

	public GameObject projectile;
	private GameObject projectileParent;
	private Animator animator;
	private Spawner myLaneSpawner;

	void Start() {
		animator = GameObject.FindObjectOfType<Animator> ();

		CreateParent();
		SetMyLaneSpawner();
		print (myLaneSpawner);
	}

	void Update() {
		if (IsAttackerAheadInLane ()) {
			animator.SetBool ("isAttacking", true);
		} else {
			animator.SetBool ("isAttacking", false);
		}
	}

	void CreateParent() {
		projectileParent = GameObject.Find ("Projectiles");
		if (!projectileParent) {
			projectileParent = new GameObject ("Projectiles");
		}
	}

	void SetMyLaneSpawner() {
		Spawner[] spawners = FindObjectsOfType<Spawner> ();
		foreach (Spawner thisSpawner in spawners) {
			if (thisSpawner.transform.position.y == gameObject.transform.position.y) {
				myLaneSpawner = thisSpawner;
				return;
			}
		}

		Debug.LogError (name + " can't find spawner in lane");
	}

	bool IsAttackerAheadInLane() {

		if (myLaneSpawner.transform.childCount <= 0) {
			return false;
		}

		foreach (Transform thisAttacker in myLaneSpawner.transform) {
			if (thisAttacker.position.x > this.transform.position.x) {
				return true;
			}
		}

		return false;
	}

	private void Fire() {
		Transform gun = transform.Find ("Gun");
		if (gun) {
			GameObject newProjectile = Instantiate (projectile);
			newProjectile.transform.parent = projectileParent.transform;
			newProjectile.transform.position = gun.transform.position;
		}
	}
}
