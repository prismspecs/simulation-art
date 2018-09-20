using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour {

    Vector3 MyMovement;

    // Use this for initialization
    void Start () {
   
        // create three floating point variables here
        // give them the names x y and z
        // give them a random value between -2 and 2
        float x = Random.Range(-2, 2);
        float y = Random.Range(-2, 2);
        float z = Random.Range(-2, 2);

        // put those values in our MyMovement Vector3
        MyMovement = new Vector3(x,y,z);
	}
	
	// Update is called once per frame
	void Update () {
        // increase the position of this object by
        // MyMovement per second
        transform.position += MyMovement * Time.deltaTime;
	}
}
