using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableDisable : MonoBehaviour {

    public GameObject Light1;
    public GameObject Light2;

    float LastTimeChecked = 0f;
    public float Interval = 3f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Time.time > LastTimeChecked + Interval)
        {

            // and update the LastTimeChecked so this works again
            LastTimeChecked = Time.time;

            // if light 1 is already active
            if(Light1.active == true) {
                // make it not active
                Light1.SetActive(false);
            } else {
                // or if it was not already active, make it active
                Light1.SetActive(true);
            }
            if (Light2.active == true)
            {
                // make it not active
                Light2.SetActive(false);
            }
            else
            {
                // or if it was not already active, make it active
                Light2.SetActive(true);
            }

        }
    }
}
