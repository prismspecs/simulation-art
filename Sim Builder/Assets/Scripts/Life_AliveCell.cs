using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life_AliveCell : MonoBehaviour {

    public int NeighborCount;
    public GameObject DeadCell;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        CheckNeighbors();
    }

    // called from global system
    public void SimUpdate() {

        // we want to check against the results of the last "frame" of the simulation
        // so update neighbor count after

        CheckNeighbors();

        if(NeighborCount < 2) {
            Destroy(this.gameObject);
            Instantiate(DeadCell, transform.position, Quaternion.identity);
        }

        if (NeighborCount > 3)
        {
            Destroy(this.gameObject);
            Instantiate(DeadCell, transform.position, Quaternion.identity);
        }
    }

    private void CheckNeighbors() {
        // how many neighbors?
        Collider[] hitColliders = Physics.OverlapBox(gameObject.transform.position, transform.localScale, Quaternion.identity);

        //NeighborCount = 0;

        //for (int i = 0; i < hitColliders.Length; i++)
        //{
        //    if (hitColliders[i].name == "Life_Alive(Clone)") {
        //        NeighborCount++;
        //    }
        //}

        NeighborCount = hitColliders.Length - 1;
        //Debug.Log(hitColliders.Length);
    }
}