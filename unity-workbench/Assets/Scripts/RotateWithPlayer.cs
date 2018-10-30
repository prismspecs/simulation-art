using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateWithPlayer : MonoBehaviour {

    public Transform Player;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //transform.Rotate(0, 0, Player.rotation.y);
        transform.localRotation = Quaternion.Euler(0, 0, Player.rotation.y * 360);

        Debug.Log(Player.rotation.y);

    }
}
