using UnityEngine;
using System.Collections;

public class Shooter : MonoBehaviour {

	public GameObject projectile, projectileParent;

	private void Fire() {
		Transform gun = transform.Find ("Gun");
		if (gun) {
			GameObject newProjectile = Instantiate (projectile);
			newProjectile.transform.parent = projectileParent.transform;
			newProjectile.transform.position = gun.transform.position;
		}
	}
}
