using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseHover : MonoBehaviour {

    public Vector3 GrowBy;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnMouseOver()
    {
        // scale up the object by our GrowBy variable
        transform.localScale += GrowBy * Time.deltaTime;
    }
}
