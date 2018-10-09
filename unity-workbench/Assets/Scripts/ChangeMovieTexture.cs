using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// THIS IS NEW!!!
using UnityEngine.Video;


public class ChangeMovieTexture : MonoBehaviour {

    public VideoClip clip1;
    public VideoClip clip2;

    private void OnMouseDown()
    {
        GetComponent<VideoPlayer>().clip = clip1;
    }

    private void OnMouseUp()
    {
        GetComponent<VideoPlayer>().clip = clip2;
    }
}
