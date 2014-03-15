using UnityEngine;
using System.Collections;
public class MouseControl : MonoBehaviour {

	float h;
	float v;

	// Use this for initialization
	void Start () {
		h = 0.0f;
		v = 0.0f;
	}
	
	// Update is called once per frame
	void Update () {
		h += (Input.GetAxis("Mouse X"));
		v += (Input.GetAxis ("Mouse Y"));

		Debug.Log (v);

//		transform.Rotate(-v, h, 0);

		//transform.Rotate(-v, h, 0 * Time.deltaTime);
		if (h > -25 && h < 25 && v < 25 && v > -25 ) {
			transform.localPosition = new Vector3 (h / 20, v / 20, 0);
		}
	}	
}
