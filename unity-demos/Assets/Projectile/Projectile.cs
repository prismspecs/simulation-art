using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {

    public GameObject projectile;

	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0)) {
            GameObject go = Instantiate(projectile, transform.position, Quaternion.identity);

            go.GetComponent<Rigidbody>().GetComponent<Rigidbody>().AddForce(transform.forward * 500);
        }

    }
}
