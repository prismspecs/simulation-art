using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playsound : MonoBehaviour {

    public AudioSource myAudio;

    // you can also play straight up sound files individually
    // (these get emitted from the audio source still!)
    public AudioClip clip1;
    public AudioClip clip2;

    void Update()
    {
        //myAudio.pitch = Random.Range(0f,1f);

        // check for keyboard inputs
        if (Input.GetKeyDown(KeyCode.F))
        {
            // either play the audio clip that is already attached
            // to the audio source, or play an arbitrary clip
            //myAudio.Play();
            myAudio.PlayOneShot(clip1);
        }

        if (Input.GetKeyDown(KeyCode.G))
        {
            //myAudio.Play();
            myAudio.PlayOneShot(clip2);
        }
    }
}