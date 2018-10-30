using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorSwitch : MonoBehaviour {

    // create a reference to the animator component
    public Animator myAnimator;

    void Start()
    {
        // link to the animator component
        myAnimator = GetComponent<Animator>();
    }

    void Update()
    {
        // if W key is pressed
        if (Input.GetKeyDown(KeyCode.W))
        {
            // send a trigger to the animator "start moving"
            myAnimator.SetTrigger("start moving");
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            // send a trigger to the animator
            myAnimator.SetTrigger("start growing");
        }
    }
}
