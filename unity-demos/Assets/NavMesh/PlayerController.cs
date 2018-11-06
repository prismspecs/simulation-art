using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;   // note this!

public class PlayerController : MonoBehaviour {

    // reference the camera
    public Camera cam;

    // reference to our player with the agent script attached
    public NavMeshAgent agent;

	void Update () {
        // right click
        if(Input.GetMouseButtonDown(1)) {
            // create a ray that fires from camera and intersects with
            // GameObjects
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);

            RaycastHit hit; // we will store data about what the ray hits here

            // check if our ray hit anything at all first...
            // and if it did, execute some more code and store the raycast hit
            // data to the "hit" variable we created
            if(Physics.Raycast(ray, out hit) == true) {

                // ok, so we hit something and we have data about where the ray hit
                // so move the agent
                agent.SetDestination(hit.point);
            }
        }
	}
}
