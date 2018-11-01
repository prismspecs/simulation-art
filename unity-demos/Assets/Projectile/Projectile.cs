using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {

    public GameObject projectile;

	// Update is called once per frame
	void Update () {
        // if left mouse button is pressed
        if (Input.GetMouseButtonDown(0)) {
            // spawn an object but also save a reference to that object
            // as a GameObject type and name it 'go'
            GameObject go = Instantiate(projectile, transform.position, Quaternion.identity);

            // tell go GameObject to addforce to rigidbody, relative to
            // player's transform.forward
            go.GetComponent<Rigidbody>().GetComponent<Rigidbody>().AddForce(transform.forward * 500);
        }

    }
}
