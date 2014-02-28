using UnityEngine;
using System.Collections;

public class CameraControl : MonoBehaviour {

	public Transform target;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		//transform.Rotate(Vector3.up);
		//transform.Translate(Vector3.forward * 0.01f);
		if (Input.GetKey (KeyCode.W)) {
			transform.Rotate(Vector3.left*.5f);

			}
		if (Input.GetKey (KeyCode.A)) {
			transform.Rotate(Vector3.down*.5f);
		}
		if (Input.GetKey (KeyCode.S)) {
			transform.Rotate(Vector3.right*.5f);
		}
		if (Input.GetKey (KeyCode.D)) {
			transform.Rotate(Vector3.up*.5f);
		}
		if (Input.GetKey ("space")){
			rigidbody.AddForce(target.forward * 0.2f);
		}
		if (Input.GetKey (KeyCode.LeftArrow)) {
			transform.Rotate(new Vector3(0,0,.5f));
		}
		if (Input.GetKey (KeyCode.RightArrow)) {
			transform.Rotate(new Vector3(0,0,-.5f));
		}
		
		if (Input.GetKey (KeyCode.F)) {
			rigidbody.angularDrag=.6f;
			rigidbody.drag=.6f;
		}else{
			rigidbody.drag=0;
			rigidbody.angularDrag=0;
		}
	}


}
