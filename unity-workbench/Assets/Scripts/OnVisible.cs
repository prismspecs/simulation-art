using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnVisible : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnBecameVisible()
    {
        Debug.Log("peekaboo");
    }
}
