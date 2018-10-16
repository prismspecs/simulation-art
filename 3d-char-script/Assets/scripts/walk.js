#pragma strict

// ground plane
var groundPlane : Plane;

// The target marker.
var target: Transform;

// Speed in units per sec.
var WalkingSpeed: float = 2;
var RotationSpeed : float = .25;

// particle system to show up on click
var ClickEffect : GameObject;

function Update() {
	// get distance between objects current position and the target position
    var distance = Vector3.Distance (target.transform.position, transform.position);
    
    if(distance > .01) {
    	// we are still not at the target, do walking animation
    	GetComponent.<Animation>()["walk"].speed = (WalkingSpeed / 2);	// set speed of animation
    	GetComponent.<Animation>().CrossFade("walk");	// actually play the animation
    } else {
    	GetComponent.<Animation>()["idle"].speed = 1;	// set speed of animation
    	GetComponent.<Animation>().CrossFade("idle");	// actually play the animation
    }
    //Debug.Log(distance);
    
	// The step size is equal to speed times frame time.
	var step = WalkingSpeed * Time.deltaTime;
	
	// Move our position a step closer to the target.
	transform.position = Vector3.MoveTowards(transform.position, target.position, step);
	
	// Also rotate towards the point
	var targetDir = target.position - transform.position;
    var newDir = Vector3.RotateTowards(transform.forward, targetDir, RotationSpeed, 0.0);
    // Move our position a step closer to the target.
    transform.rotation = Quaternion.LookRotation(newDir);
    
    Debug.DrawRay(transform.position, newDir, Color.red);	// draw something showing direction (for debug)
    
    // on click, set new target position
	if (Input.GetMouseButtonDown (0)) {
		var ray = Camera.main.ScreenPointToRay (Input.mousePosition);
		var hit : RaycastHit;
	    if (Physics.Raycast (ray, hit)) {
		    // update target position based on raycast hit point
		    target.position = hit.point;
			target.position.y = 1;	// always set height to 1 so character doesnt try and swim thru plane...
			
			var clone : GameObject = Instantiate(ClickEffect,target.position,target.rotation);
			Destroy(clone,1);
		} 
	}
}

function OnMouseDown() {
	// mouse clicked, update target position
	
	Debug.Log("!");
 
}