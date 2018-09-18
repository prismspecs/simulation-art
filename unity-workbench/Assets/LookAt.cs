using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour {

    // The target marker
    public Transform target;

    // Speed in units per sec
    public float speed;

    public bool repel;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        // calculate how fast this should happen
        float step = speed * Time.deltaTime;

        transform.LookAt(target);

        if(repel) {
            transform.Rotate(0, 180, 0);
        }
       
        transform.Translate(Vector3.forward * step);
    }
}
