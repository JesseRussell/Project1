using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		float fBaseSpeedx = Input.GetAxis ("X Axis");
		float fBaseSpeedy = Input.GetAxis ("Y Axis");
		float fBaseSpeedz = Input.GetAxis ("Z Axis");
		
		Vector3 v3BaseSpeed = new Vector3 (fBaseSpeedx, fBaseSpeedy, fBaseSpeedz);

		Vector3 v3BaseRotate = new Vector3 (0.0f, 0.0f, 0.0f);

		Camera Cam = GetComponent<Camera> ();

		if (Input.GetKeyDown (KeyCode.R)) {
		
			v3BaseRotate.x += 10.0f;

		}

		if (Input.GetKeyDown (KeyCode.T)) {
			
			v3BaseRotate.x -= 10.0f;
			
		}

		if (Input.GetKeyDown (KeyCode.Y)) {
			
			v3BaseRotate.y += 10.0f;
			
		}

		if (Input.GetKeyDown (KeyCode.U)) {
			
			v3BaseRotate.y -= 10.0f;
			
		}

		if (Input.GetKeyDown (KeyCode.I)) {
			
			v3BaseRotate.z += 10.0f;
			
		}

		if (Input.GetKeyDown (KeyCode.O)) {
			
			v3BaseRotate.z -= 10.0f;
			
		}
	
		Cam.transform.Rotate (v3BaseRotate);
		Cam.transform.Translate (v3BaseSpeed);

		v3BaseRotate.Set (0.0f, 0.0f, 0.0f);

	}
}
