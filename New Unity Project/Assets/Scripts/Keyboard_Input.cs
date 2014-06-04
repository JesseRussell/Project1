using UnityEngine;
using System.Collections;

public class Keyboard_Input : MonoBehaviour {

	public Camera TopCamera;
	public Camera RightCamera;
	public Camera LeftCamera;
	public Camera FrontCamera;
	public Camera BackCamera;
	public Camera CurrentCamera;

	public Vector3 MovementVector;
	public Vector3 RotationVector;

	public Vector3 TopCamPos;
	public Vector3 RightCamPos;
	public Vector3 LeftCamPos;
	public Vector3 FrontCamPos;
	public Vector3 BackCamPos;

	public Quaternion TopCamRot;
	public Quaternion RightCamRot;
	public Quaternion LeftCamRot;
	public Quaternion FrontCamRot;
	public Quaternion BackCamRot;

	// Use this for initialization
	void Start () {

		TopCamera.enabled = true;
		RightCamera.enabled = false;
		LeftCamera.enabled = false;
		FrontCamera.enabled = false;
		BackCamera.enabled = false;

		CurrentCamera = TopCamera;

		MovementVector.Set (0.0f, 0.0f, 0.0f);
		RotationVector.Set (0.0f, 0.0f, 0.0f);

		TopCamPos = TopCamera.transform.position;
		RightCamPos = RightCamera.transform.position;
		LeftCamPos = LeftCamera.transform.position;
		FrontCamPos = FrontCamera.transform.position;
		BackCamPos = BackCamera.transform.position;

		TopCamRot = TopCamera.transform.rotation;
		RightCamRot = RightCamera.transform.rotation;
		LeftCamRot = LeftCamera.transform.rotation;
		FrontCamRot = FrontCamera.transform.rotation;
		BackCamRot = BackCamera.transform.rotation;
	
	}
	
	// Update is called once per frame
	void Update () {

		//Check to see if the cameras have be switched
		if(Input.GetKeyDown (KeyCode.Alpha1)){

			TopCamera.enabled = true;
			RightCamera.enabled = false;
			LeftCamera.enabled = false;
			FrontCamera.enabled = false;
			BackCamera.enabled = false;
			CurrentCamera = TopCamera;

		}

		if(Input.GetKeyDown (KeyCode.Alpha2)){

			TopCamera.enabled = false;
			RightCamera.enabled = true;
			LeftCamera.enabled = false;
			FrontCamera.enabled = false;
			BackCamera.enabled = false;
			CurrentCamera = RightCamera;
			
		}

		if(Input.GetKeyDown (KeyCode.Alpha3)){

			TopCamera.enabled = false;
			RightCamera.enabled = false;
			LeftCamera.enabled = true;
			FrontCamera.enabled = false;
			BackCamera.enabled = false;
			CurrentCamera = LeftCamera;
			
		}

		if(Input.GetKeyDown (KeyCode.Alpha4)){
			
			TopCamera.enabled = false;
			RightCamera.enabled = false;
			LeftCamera.enabled = false;
			FrontCamera.enabled = true;
			BackCamera.enabled = false;
			CurrentCamera = FrontCamera;
			
		}

		if(Input.GetKeyDown (KeyCode.Alpha5)){
			
			TopCamera.enabled = false;
			RightCamera.enabled = false;
			LeftCamera.enabled = false;
			FrontCamera.enabled = false;
			BackCamera.enabled = true;
			CurrentCamera = BackCamera;
			
		}

		// Check to see if the camera has been moved or rotated and apply effects appropriately

		MovementVector.x = Input.GetAxis ("X Axis") * 1.3f;
		MovementVector.y = Input.GetAxis ("Y Axis") * 1.3f;
		MovementVector.z = Input.GetAxis ("Z Axis") * 1.3f;

		CurrentCamera.transform.Translate (MovementVector);

		if(Input.GetKey (KeyCode.Comma)){
		
			RotationVector.x += 100;
		
		}

		if(Input.GetKey (KeyCode.Period)){
			
			RotationVector.x -= 100;
				
		}

		if(Input.GetKey (KeyCode.K)){
			
			RotationVector.z += 100;
				
		}
		
		if(Input.GetKey (KeyCode.L)){
			
			RotationVector.z -= 100;
				
		}

		if(Input.GetKey (KeyCode.I)){
			
			RotationVector.y += 100;
				
		}
		
		if(Input.GetKey (KeyCode.O)){
			
			RotationVector.y -= 100;
				
		}

		CurrentCamera.transform.RotateAround (Vector3.zero, RotationVector, 1.0f);

		RotationVector.Set (0.0f, 0.0f, 0.0f);

		if (Input.GetKeyDown (KeyCode.R)) {
		
			if(CurrentCamera == TopCamera){

				CurrentCamera.transform.position = TopCamPos;
				CurrentCamera.transform.rotation = TopCamRot;
			
			}
			else if(CurrentCamera == RightCamera){
				
				CurrentCamera.transform.position = RightCamPos;
				CurrentCamera.transform.rotation = RightCamRot;
				
			}
			else if(CurrentCamera == LeftCamera){
				
				CurrentCamera.transform.position = LeftCamPos;
				CurrentCamera.transform.rotation = LeftCamRot;
				
			}
			else if(CurrentCamera == FrontCamera){
				
				CurrentCamera.transform.position = FrontCamPos;
				CurrentCamera.transform.rotation = FrontCamRot;

			}
			else if(CurrentCamera == BackCamera){
				
				CurrentCamera.transform.position = BackCamPos;
				CurrentCamera.transform.rotation = BackCamRot;
				
			}

		}

		// End Camera Code

		// Check to see if the escape key is pressed this frame
		if (Input.GetKeyDown (KeyCode.Escape)) {
		
			Application.Quit();
		
		}

	}
}
