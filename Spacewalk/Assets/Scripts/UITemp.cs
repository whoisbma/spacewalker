using UnityEngine;
using System.Collections;

public class UITemp : MonoBehaviour {

	public float oxygen;

	GameObject _capsule; 
	GameObject _mouse; 


	// Use this for initialization
	void Start () {
		_capsule = GameObject.Find ("Capsule");  
		_mouse = GameObject.Find ("MouseController");
	}
	
	// Update is called once per frame
	void Update () {
		float localFuel = _capsule.GetComponent<CameraControl>().fuel;
		float angularDrag = _capsule.rigidbody.angularDrag;
		float drag = _capsule.rigidbody.drag;
//		float rotX = _capsule.rigidbody.angularVelocity.x;
//		float rotY = _capsule.rigidbody.angularVelocity.y;
//		float rotZ = _capsule.rigidbody.angularVelocity.z;
		float velX = _capsule.rigidbody.velocity.x;
		float velY = _capsule.rigidbody.velocity.y;
		float velZ = _capsule.rigidbody.velocity.z;
		float totalVel = (Mathf.Abs (velX)) + (Mathf.Abs (velY)) + (Mathf.Abs (velZ));
		float pushForce = _capsule.GetComponent<CameraControl> ().pushForce;
		float mouseV = _mouse.transform.localPosition.x;
		float mouseH = _mouse.transform.localPosition.y;

		GetComponent<TextMesh> ().text = "FUEL = " + localFuel;
		GetComponent<TextMesh> ().text += "\nOXYGEN = " + oxygen + "%";
		GetComponent<TextMesh> ().text += "\nDrag = " + drag;
		GetComponent<TextMesh> ().text += "\nAngular Drag = " + angularDrag;
		//GetComponent<TextMesh> ().text += "\nx rotation = " + rotX;
		//GetComponent<TextMesh> ().text += "\ny rotation = " + rotY;
		//GetComponent<TextMesh> ().text += "\nz rotation = " + rotZ;
		GetComponent<TextMesh> ().text += "\nTotal Velocity = " + totalVel;
		GetComponent<TextMesh> ().text += "\nPushforce = " + pushForce;
		//GetComponent<TextMesh> ().text += "\nx velocity = " + velX;
		//GetComponent<TextMesh> ().text += "\ny velocity = " + velY;
		//GetComponent<TextMesh> ().text += "\nz velocity = " + velZ;


		GetComponent<TextMesh> ().text += (Input.GetAxis ("Mouse Y"));
		GetComponent<TextMesh> ().text += "\nMouse H = " + mouseH;

		oxygen -= .001f;
	}
}
