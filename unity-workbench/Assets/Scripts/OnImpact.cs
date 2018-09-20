using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnImpact : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Physics.IgnoreLayerCollision(9, 10);

    }

    // Update is called once per frame
    void Update () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        // if i collide with the Plane, jump
        if (collision.gameObject.layer == 10)
        {
            GetComponent<Rigidbody>().AddForce(Vector3.up * 400f);
        } else {
            // in all other circumstances, destroy my gameObject
            Destroy(this.gameObject);
        }
    }
}
