using UnityEngine;
using System.Collections;

public class ThrusterParticleControl : MonoBehaviour {

	public ParticleSystem turnLeft;
	public ParticleSystem turnRight;
	public ParticleSystem rotLeft;
	public ParticleSystem rotRight;
	float _localFuel;
	GameObject _capsule; 

	// Use this for initialization
	void Start () {
		_capsule = GameObject.Find ("Capsule");  
	}
	
	// Update is called once per frame
	void Update () {
		_localFuel = _capsule.GetComponent<CameraControl>().fuel;
		if (_localFuel > 0) {
//			if (Input.GetKey ("space")) {
//				turnLeft.particleSystem.enableEmission = true; 
//				turnRight.particleSystem.enableEmission = true;
//			} else {
//				//turnLeft.particleSystem.enableEmission = false; 
//				//turnRight.particleSystem.enableEmission = false;
//			}

			if (Input.GetKey (KeyCode.Q)) {
				rotLeft.particleSystem.enableEmission = true;
			} else {
				rotLeft.particleSystem.enableEmission = false;
			}

			if (Input.GetKey (KeyCode.E)) {			
				rotRight.particleSystem.enableEmission = true;
			} else {			
				rotRight.particleSystem.enableEmission = false;
			}
						
			if ((Input.GetKey (KeyCode.A)) || (Input.GetKey ("space"))) {
				turnLeft.particleSystem.enableEmission = true;
			} else {
				turnLeft.particleSystem.enableEmission = false;
			}

			if ((Input.GetKey (KeyCode.D)) || (Input.GetKey ("space"))) {
				turnRight.particleSystem.enableEmission = true;						
			} else {								
				turnRight.particleSystem.enableEmission = false;
			}
			if (Input.GetKey (KeyCode.F)) {			
				turnLeft.particleSystem.enableEmission = true; 
				turnRight.particleSystem.enableEmission = true;
				rotLeft.particleSystem.enableEmission = true;
				rotRight.particleSystem.enableEmission = true; 			
			}

			} else {
				turnLeft.particleSystem.enableEmission = false; 
				turnRight.particleSystem.enableEmission = false;
				rotLeft.particleSystem.enableEmission = false;
				rotRight.particleSystem.enableEmission = false;
			}
	}
}
