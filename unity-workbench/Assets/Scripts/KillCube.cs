using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillCube : MonoBehaviour {

	void Start () {
		
	}
	
	void Update () {
        // have i fallen below 0 on y axis
        if(transform.position.y < 0) {
            // remove the cube that this script is attached to
            // Destroy(this) would destroy the script itself
            Destroy(this.gameObject);
        }
	}
}
