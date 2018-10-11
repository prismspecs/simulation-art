using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    // what shall I follow?
    public Transform Target;
    // since doing transform.position = Target.position
    // will place the camera inside the third person,
    // we need to offset our view
    public Vector3 Offset;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        // set the camera pos equal to the target pos, and offset it
        transform.position = Target.position + Offset;
	}
}
