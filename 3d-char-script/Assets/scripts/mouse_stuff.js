#pragma strict

// mouse clicked on object
function OnMouseDown() {
	// advance scene
	Application.LoadLevel("game"); 
	Destroy(gameObject);
}

// mouse hovering on object
function OnMouseEnter() {
	// change color to red on hover
	GetComponent.<Renderer>().material.color = Color.red;
}

// mouse not hovering object anymore
function OnMouseExit() {
	// change color to white when not hovered
	GetComponent.<Renderer>().material.color = Color.white;
}