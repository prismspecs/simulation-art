using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomGrow : MonoBehaviour {

    Vector3 MyGrowth;

    // Use this for initialization
    void Start () {
        // create three floating point variables here
        // give them the names x y and z
        // give them a random value between -2 and 2
        float x = Random.Range(-.2f, .2f);
        float y = Random.Range(-.2f, .2f);
        float z = Random.Range(-.2f, .2f);

        // put those values in our MyMovement Vector3
        MyGrowth = new Vector3(x, y, z);
    }
	
	// Update is called once per frame
	void Update () {
        transform.localScale += MyGrowth * Time.deltaTime;
	}
}
