using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getaxis : MonoBehaviour {

    public float moveCoefficient = 11f;

    public bool isGrounded = true;  // is it touching the ground?

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        // create a float var and set it equal to
        // the horizontal axis...
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        // use our moveX and Z floats to move the object left/right forward/backward
        transform.Translate(Vector3.right * moveX * moveCoefficient * Time.deltaTime);
        transform.Translate(Vector3.forward * moveZ * moveCoefficient * Time.deltaTime);

        // jump!
        // only jump if its currently on the ground
        if(isGrounded == true) {
            // when keycode.space is true, add force
            if(Input.GetKeyDown(KeyCode.Space) == true) {
                GetComponent<Rigidbody>().AddForce(Vector3.up * 500f);
                // after we initiate the jump, it is no longer
                // grounded, so set that flag to false
                isGrounded = false;
            }
        }

        // just checking things out...
        Debug.Log(Input.GetKey(KeyCode.Space));
	}

    private void OnCollisionEnter(Collision collision)
    {
        isGrounded = true;
    }
}
