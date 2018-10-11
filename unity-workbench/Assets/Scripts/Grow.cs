using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grow : MonoBehaviour {

    public Vector3 GrowBy;

    public Vector3 ShrinkBy;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnMouseOver()
    {
        transform.localScale += GrowBy;
        //GetComponent<Renderer>().material.color = Color.red;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Plane"){
            transform.localScale -= ShrinkBy;
        }
    }
}
