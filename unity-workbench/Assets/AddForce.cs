using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForce : MonoBehaviour {

    public float Interval = 3f;

    private float LastTimer = 0f;

    public float Force;
    

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
        if(Time.time > LastTimer + Interval) {

            GetComponent<Rigidbody>().AddForce(Vector3.up * Force);

            LastTimer = Time.time;

            Debug.Log("Jumped at " + Time.time);
        }
	}
}
