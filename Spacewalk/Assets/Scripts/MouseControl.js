#pragma strict

var horizontalSpeed : float;
var verticalSpeed : float;

function Start () {
	horizontalSpeed = 2;
	verticalSpeed = 2;
}
 
function FixedUpdate (){
    // Get the mouse delta. This is not in the range -1...1
 
    var y : float = - horizontalSpeed * Input.GetAxis ("Mouse X");
    var x : float = - verticalSpeed * Input.GetAxis ("Mouse Y");
 
//    transform.Translate (x, 0, y);
	transform.Rotate (x, 0, y);
//	rigidbody.AddForce(x, 0, y);
//	var localForce : Vector3 = camera.TransformDirection(new Vector3(x, 0, y));
//	localForce.y = 0;
//	rigidbody.AddForce(localForce);
}