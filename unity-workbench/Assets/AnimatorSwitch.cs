using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorSwitch : MonoBehaviour {

    public Animator myAnimator;

    void Start()
    {
        myAnimator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            myAnimator.SetTrigger("start moving");
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            myAnimator.SetTrigger("start growing");
        }
    }
}
