using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life_DeadCell : MonoBehaviour
{

    public int NeighborCount;
    public GameObject AliveCell;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        CheckNeighbors();
    }

    // called from global system
    public void SimUpdate()
    {

        // we want to check against the results of the last "frame" of the simulation
        // so update neighbor count after

        CheckNeighbors();

        if (NeighborCount == 2 || NeighborCount == 3)
        {
            Destroy(this.gameObject);
            Instantiate(AliveCell, transform.position, Quaternion.identity);
        }
    }

    private void CheckNeighbors()
    {
        // how many neighbors?
        Collider[] hitColliders = Physics.OverlapBox(gameObject.transform.position, transform.localScale, Quaternion.identity);
        NeighborCount = hitColliders.Length - 1;
        //Debug.Log(hitColliders.Length);
    }
}