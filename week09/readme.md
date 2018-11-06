# week09

## Announcements

## Tuesday

+ Show Project 2: World Building

+ Discuss
	+ [Ian Cheng's Emissaries](https://www.youtube.com/watch?v=TO6Luilc4Bo)
		+ How does something like Live Simulation fit into a trajectory of art history?
		+ In what ways does this differ from painting? In what ways does it differ from Video Art?
		+ Is it important that it happens live, as opposed to rendering and saving a file of an instance of the simulation?

	+ [Humans of Simulated New York](https://spaceandtim.es/projects/hosny/)
	+ The Founder

+ NavMesh demo from [Brackeys](https://www.youtube.com/watch?v=CHV1ymlw-P8)
	+ Create an Empty Gameobject "Level"
		+ As children to this object, create "Ground" which is the walkable surface, I suggest a Cube rather than Plane
		+ ...and another Empty Gameobject "Walls" that contain a number of obstacles
	+ Create a Cylinder and name it "Player", place it exactly on top of your ground
	+ Create an Empty Gameobject "NavMesh" and reset to 0,0,0
		+ Add the NavMeshSurface script to this and click "bake"
	+ Because the player is considered an obstacle at first, create a layer for the Player that the NavMesh can ignore
		+ Select Player and in the Inspector, create a new layer called "Player"
		+ On the NavMesh, disable the layer on the Include Layers portion of the script
		+ Re-bake the NavMesh
	+ Note that in the NavMesh, you can either generate the walkable areas by colliders or renderers
	+ Under NavMesh, click Agent Type->Open Agent Settings
		+ Click the plus sign to create a new agent type
		+ Adjust the values, play around, take note of step and slope settings, as well as size
	+ Let's assume we don't want our walls to be walkable
		+ Select Walls and add NavMeshModifier script
		+ Enable "Ignore From Build" and re-bake NavMesh to see the effect (the walls are no longer considered obstacles)
		+ Disable "Ignore From Build" and instead enable "Override Area"
		+ Change the Area Type to "Not Walkable" and re-bake NavMesh
	+ Now we can begin moving the player
		+ Watch [how Camera Ray Casting works](https://youtu.be/CHV1ymlw-P8?t=337)
	+ Click the Player Gameobject
		+ Add NavMeshAgent to Player Gameobject
		+ Create a PlayerController.cs script and add it to Player (code below)

PlayerController.cs
```C#
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
```

## Thursday



## Unity Tutorial(s) for this week

+ [Unity NavMesh Tutorial - Basics](https://www.youtube.com/watch?v=CHV1ymlw-P8)
+ [Unity NavMesh Tutorial - Making it Dynamic](https://www.youtube.com/watch?v=FkLJ45Pt-mY)

## Homework

+ Project 2 due Tuesday 11/6
