using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsOffscreen : MonoBehaviour {

    // Detects manually if obj is being seen by the main camera
    Collider objCollider;
    Camera cam;
    Plane[] planes;

    public GameObject ThingToSpawn;

    void Start()
    {
        cam = Camera.main;
        objCollider = GetComponent<Collider>();
    }

    void Update()
    {

        // create planes that represent the sides of the camera view projected into space
        planes = GeometryUtility.CalculateFrustumPlanes(cam);

        // determine if this game object is within those planes
        if (GeometryUtility.TestPlanesAABB(planes, objCollider.bounds))
        {
            Debug.Log("I am visible");
        }
        else
        {
            Debug.Log("I am invisible");
            Instantiate(ThingToSpawn, transform.position, Quaternion.identity);
        }
    }
}
