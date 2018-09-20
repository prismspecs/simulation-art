using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Review : MonoBehaviour {

    // create a few variables
    public float myFloat;
    public float myOtherFloat = 1;

    

	// Use this for initialization
    void Start () {


        myFloat = Random.Range(-2f, 2f);

        float sum = myFloat + myOtherFloat;

        Debug.Log(sum);
	}

    // Update is called once per frame
    void Update()
    {

    }
}
