using UnityEngine;
using System.Collections;

public class CameraControl : MonoBehaviour {

	public Transform target;
	public float fuel;

	public float pushForce; 
	float turnValUp;
	float turnValDown;
	float turnValLeft;
	float turnValRight;
	float turnValRotLeft;
	float turnValRotRight;
	float stabilize;

	float turnValMax;
	float turnValMin; 
	float turnValIncrement; 
	float turnValDrag;

	float pushForceMax;
	float pushForceIncrement;

	float pushForceAddDrag;

	//spiderman
//	bool derp=true;
//
//	public Transform cam;

	// Use this for initialization
	void Start () {
		pushForce = 0.0f;
		turnValUp = 0.0f;
		turnValDown = 0.0f;
		turnValLeft = 0.0f;
		turnValRight = 0.0f;
		turnValRotLeft = 0.0f;
		turnValRotRight = 0.0f;
		stabilize = 0.0f;
		turnValMax = 0.5f;
		turnValMin = 0.01f;
		turnValIncrement = 0.01f; 
		turnValDrag = 0.005f;
		pushForceMax = 0.2f;
		pushForceIncrement = 0.01f;
		pushForceAddDrag = 0.0f;
	}

	void Update() {
		//Debug.Log ("" + rigidbody.angularDrag);
		//for spiderman
//		if (Input.GetKey (KeyCode.K)){
//			derp=!derp;
//		}
//
//		if(derp){
//			transform.rotation=Quaternion.Slerp(transform.rotation, cam.rotation, Time.deltaTime);
//		}

	}

	// Update is called once per frame
	void FixedUpdate () {
		//if (derp) {
						//do all transforms based on keyboard input
						transform.Rotate (Vector3.left * turnValUp);
						transform.Rotate (Vector3.down * turnValLeft);
						transform.Rotate (Vector3.right * turnValDown);
						transform.Rotate (Vector3.up * turnValRight);
						transform.Rotate (new Vector3 (0, 0, turnValRotLeft));
						transform.Rotate (new Vector3 (0, 0, -turnValRotRight));
				
						//key input
						if (Input.GetKey (KeyCode.W)) {
								// accelerate
								if (turnValUp < turnValMax) {
										turnValUp += turnValIncrement;
								} else {
										turnValUp = turnValMax;	
								}
						} else { //slow down
								if (turnValUp > turnValMin) {
										turnValUp -= turnValDrag;
								} else {
										turnValUp = 0.0f;
								}
						}
				
						if (Input.GetKey (KeyCode.A)) {
								if (turnValLeft < turnValMax) {
										turnValLeft += turnValIncrement;
								} else {
										turnValLeft = turnValMax;	
								}
						} else {
								if (turnValLeft > turnValMin) {
										turnValLeft -= turnValDrag;
								} else {
										turnValLeft = 0.0f;
								}	
						}
				
						if (Input.GetKey (KeyCode.S)) {
								if (turnValDown < turnValMax) {
										turnValDown += turnValIncrement;
								} else {
										turnValDown = turnValMax;	
								}
						} else {
								if (turnValDown > turnValMin) {
										turnValDown -= turnValDrag;
								} else {
										turnValDown = 0.0f;
								}			
						}
				
						if (Input.GetKey (KeyCode.D)) {
								if (turnValRight < turnValMax) {
										turnValRight += turnValIncrement;
								} else {
										turnValRight = turnValMax;	
								}
						} else {
								if (turnValRight > turnValMin) {
										turnValRight -= turnValDrag;
								} else {
										turnValRight = 0.0f;
								}				
						}

						if (Input.GetKey (KeyCode.Q)) {
								if (turnValRotLeft < turnValMax) {
										turnValRotLeft += turnValIncrement;
								} else {
										turnValRotLeft = turnValMax;	
								}
						} else {
								if (turnValRotLeft > turnValMin) {
										turnValRotLeft -= turnValDrag;
								} else {
										turnValRotLeft = 0.0f;
								}			
						}
		
						if (Input.GetKey (KeyCode.E)) {
								if (turnValRotRight < turnValMax) {
										turnValRotRight += turnValIncrement;
								} else {
										turnValRotRight = turnValMax;	
								}
						} else {
								if (turnValRotRight > turnValMin) {
										turnValRotRight -= turnValDrag;
								} else {
										turnValRotRight = 0.0f;
								}		
						}

						//thrust
						if (Input.GetKey ("space")) {
								if (fuel > 0) {					
										pushForce = 0.2f;
										pushForceAddDrag = pushForce / 2.0f;
										rigidbody.AddForce (target.forward * pushForce);  //originally  0.2
//				if (pushForce < pushForceMax) {
//					pushForce += pushForceIncrement;
//				} else {
//					pushForce = pushForceMax;
//				}
										fuel -= 0.01f;
								} else {
										pushForce = 0.0f;
										//Debug.Log ("" + pushForce);
								}
						} else {
								pushForce = 0.0f;
								pushForceAddDrag = pushForce / 2.0f;
						}

						//stabilizer
						if (Input.GetKey (KeyCode.F)) {
								stabilize = 0.7f;
								//rigidbody.angularDrag = 0.6f;
								//rigidbody.drag = 0.6f;
								fuel -= 0.05f; 
						} else {
								stabilize = 0.0f;
								//rigidbody.drag = 0.0f;
								//rigidbody.angularDrag = 0.0f;
						}
			
						if (fuel < 0) {
								fuel = 0; 
						}

						float averageTurn = (turnValUp + turnValDown + turnValLeft + turnValRight + turnValRotLeft + turnValRotRight) / 1; //used before fake force cancellation
						rigidbody.angularDrag = averageTurn + stabilize + pushForceAddDrag;
						//Debug.Log (pushForce);
						rigidbody.drag = stabilize;


				//}
	}


}
