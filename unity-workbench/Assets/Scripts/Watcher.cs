using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Watcher : MonoBehaviour {

    // select a game object in editor which this object will follow
    public GameObject Target;

    // how fast should it follow?
    public float Speed = 1f;

    public bool Repel = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        // look at the target object (aim forward Z at the object)
        transform.LookAt(Target.transform);

        // if "Repel" mode is activated
        if(Repel == true) {
            // turn around 180 so "forward" is away from the target object
            transform.Rotate(0, 180, 0);
        }

        // move forward
        transform.Translate(Vector3.forward * Speed * Time.deltaTime);
	}
}
