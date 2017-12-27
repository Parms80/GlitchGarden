using UnityEngine;
using System.Collections;

public class Shooter : MonoBehaviour {

	public GameObject projectile;
	private GameObject projectileParent;

	void Start() {
		projectileParent = GameObject.Find ("Projectiles");
		if (!projectileParent) {
			projectileParent = new GameObject ("Projectiles");
		}
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
