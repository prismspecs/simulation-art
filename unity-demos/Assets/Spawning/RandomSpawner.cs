using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour {

    // what do we want to spawn?
    public GameObject spawnee;

    public float Interval = 3f;

    private float LastTimeChecked = 0f;

	// Use this for initialization
	void Start () {

       
	}
	
	// Update is called once per frame
	void Update () {

        // is the current time greater than the last
        // time we checked plus the interval? in other words,
        // has enough time passed to spawn a new game object?
        if (Time.time > LastTimeChecked + Interval)
        {

            // if so... create a new object
            Instantiate(spawnee, transform.position, Random.rotation);

            // and update the LastTimeChecked so this works again
            LastTimeChecked = Time.time;

            // update the position of the spawner object
            float x = Random.Range(-5f, 5f);
            float z = Random.Range(-5f, 5f);

            // load these into a vector3 so we can 
            // use it in transform
            Vector3 myPos = new Vector3(x, 5, z);

            // set the transform position property to this new vector3
            transform.position = myPos;

        }
    }
}
