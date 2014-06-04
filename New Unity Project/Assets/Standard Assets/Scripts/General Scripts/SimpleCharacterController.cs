using UnityEngine;
using System.Collections;

public class Player_Script : MonoBehaviour {

	float MovementMultiplier = 1.3f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		float fBaseSpeedz = Input.GetAxis ("Vertical");
		float fBaseSpeedx = Input.GetAxis ("Horizontal");

		Vector3 BaseSpeed = new Vector3 (fBaseSpeedx, 0, fBaseSpeedz);

		CharacterController CharCont = GetComponent<CharacterController> ();

		BaseSpeed *= MovementMultiplier;

		CharCont.SimpleMove (BaseSpeed);

	}
}
