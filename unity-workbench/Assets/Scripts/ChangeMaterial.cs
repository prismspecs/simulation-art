using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMaterial : MonoBehaviour {

    // reference some materials
    public Material mat1, mat2;

    void Start () {
        // start with a random material assigned
        int rando = Random.Range(0, 2);

        if(rando == 0) {
            GetComponent<Renderer>().material = mat1;
        } else {
            GetComponent<Renderer>().material = mat2;
        }
	}
	
	void Update () {
		
	}

    // change materials on mouse down and up
    private void OnMouseDown()
    {
        GetComponent<Renderer>().material = mat1;
    }

    private void OnMouseUp()
    {
        GetComponent<Renderer>().material = mat2;
    }


}
