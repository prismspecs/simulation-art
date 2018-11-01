using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// NOTICE we have to use some additional functionality
using UnityEngine.SceneManagement;

// ALSO you must add both scene to the "build settings"
// you do this by going to File->Build Settings
// and then drag the relevant scenes into "Scenes in Build"


public class ChangeScene : MonoBehaviour {

    private void OnMouseDown()
    {
        // if you are going to reference the scene by name
        // make sure you are precise!
        SceneManager.LoadScene("Scene2");
    }
}
