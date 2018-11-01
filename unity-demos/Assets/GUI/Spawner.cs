using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spawner : MonoBehaviour {

    public GameObject go; // what to spawn
    public int NumberToSpawn = 1;  // how many to spawn at a time

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    // this is a custom function we are making that we can call
    // from the UI handler
    public void SpawnObject() {
        // use a 'for loop' to spawn something multiple times
        // (based on the slider value)
        for (int i = 0; i < NumberToSpawn; i++) {

            // goto semi-random position
            float x = Random.Range(-5f, 5f);
            Vector3 pos = new Vector3(x, 4f, -4f);
            transform.position = pos;

            // spawn an object
            Instantiate(go, transform.position, Quaternion.identity);
        }
    }

    // this will get called whenever the slider value changes
    public void ChangeNumber(Slider slider) {
        // change the number to spawn variable based on slider val
        NumberToSpawn = (int)slider.value;
    }
}
