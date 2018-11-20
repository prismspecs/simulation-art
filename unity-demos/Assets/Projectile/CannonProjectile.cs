using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonProjectile : MonoBehaviour {

    // we don't want to fire from the center of the cannon
    // so lets specify a place from which to fire
    public Transform FireFromHere;

    // the projectile object that is spawned
    public GameObject CannonBall;
	
	// Update is called once per frame
	void Update () {

        // let up/down keypresses rotate the cannon
        // inverting this makes intuitive sense (try removing *-1
        // to see what I mean)
        float rotateX = Input.GetAxis("Vertical") * -1;
        Vector3 rot = new Vector3(rotateX, 0f, 0f);
        transform.Rotate(rot);

        if(Input.GetKeyDown(KeyCode.Space)) {
            // if user hits space key..

            // fire!
            GameObject go = Instantiate(CannonBall, FireFromHere.position, Quaternion.identity);

            // add some force
            go.GetComponent<Rigidbody>().AddForce(transform.up * 1500f);
        }
	}

}
