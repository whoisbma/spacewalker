using UnityEngine;
using System.Collections;

public class UITemp : MonoBehaviour {

	public float oxygen;
	float _localFuel;
	GameObject _capsule; 


	// Use this for initialization
	void Start () {
		_capsule = GameObject.Find ("Capsule");  
		//_localFuel = GameObject.Find ("Capsule").GetComponent<CameraControl> ().fuel;
	}
	
	// Update is called once per frame
	void Update () {
		_localFuel = _capsule.GetComponent<CameraControl>().fuel;
		float angularDrag = GameObject.Find ("Capsule").rigidbody.angularDrag;
		float rotX = GameObject.Find ("Capsule").rigidbody.angularVelocity.x;
		float rotY = GameObject.Find ("Capsule").rigidbody.angularVelocity.y;
		float rotZ = GameObject.Find ("Capsule").rigidbody.angularVelocity.z;
		float velX = GameObject.Find ("Capsule").rigidbody.velocity.x;
		float velY = GameObject.Find ("Capsule").rigidbody.velocity.y;
		float velZ = GameObject.Find ("Capsule").rigidbody.velocity.z;

		GetComponent<TextMesh> ().text = "FUEL = " + _localFuel;
		GetComponent<TextMesh> ().text += "\nOXYGEN = " + oxygen + "%";
		GetComponent<TextMesh> ().text += "\nAngular Drag = " + angularDrag;
		GetComponent<TextMesh> ().text += "\nx rotation = " + rotX;
		GetComponent<TextMesh> ().text += "\ny rotation = " + rotY;
		GetComponent<TextMesh> ().text += "\nz rotation = " + rotZ;
		GetComponent<TextMesh> ().text += "\nx velocity = " + velX;
		GetComponent<TextMesh> ().text += "\ny velocity = " + velY;
		GetComponent<TextMesh> ().text += "\nz velocity = " + velZ;

		oxygen -= .001f;
	}
}
