using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Agent : MonoBehaviour {

    public Collider Feeler; // what is used to check for surrounding agents

    public int NeighborCount;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    // called from global system
    public void SimUpdate() {

        // we want to check against the results of the last "frame" of the simulation
        // so update neighbor count after

        if(NeighborCount <= 2) {
            Destroy(this.gameObject);
        }

        
    }

    private void CheckNeighbors() {
        // how many neighbors?
        Collider[] hitColliders = Physics.OverlapBox(gameObject.transform.position, transform.localScale, Quaternion.identity);
        NeighborCount = hitColliders.Length - 1;
        //Debug.Log(hitColliders.Length);
    }
}