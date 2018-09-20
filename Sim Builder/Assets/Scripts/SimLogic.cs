using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimLogic : MonoBehaviour {

    public float Interval = 1.0f;
    private float LastChecked = 0f;

    public float Density = .4f;
    public int Columns = 20;
    public int Rows = 20;

    public GameObject AliveCell;
    public GameObject DeadCell;

    // Use this for initialization
    void Start () {

        // create a bunch of agents
        for (int x = 0; x < Columns; x++)
        {
            for (int y = 0; y < Rows; y++)
            {
                Vector3 here = new Vector3(x, 0, y);

                if (Random.value > 1 - Density)
                {
                    Instantiate(AliveCell, here, Quaternion.identity);
                } else {
                    Instantiate(DeadCell, here, Quaternion.identity);
                }
            }
        }
	}
	
	// Update is called once per frame
	void Update () {
        if(Time.time > LastChecked + Interval) {
            LastChecked = Time.time;

            GameObject[] gos = GameObject.FindGameObjectsWithTag("Agent");

            foreach (GameObject go in gos) {
                go.BroadcastMessage("SimUpdate");
                Debug.Log("updated");
            }
            //BroadcastMessage("SimUpdate");
        }
	}
}
