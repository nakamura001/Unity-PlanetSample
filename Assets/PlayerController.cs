using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerController : MonoBehaviour {
	public GameObject Player;
	Transform parentTrans;
	Transform playerTrans;
	const float rotScale = 50f;

	void Start() {
		parentTrans = GetComponent<Transform> ();
		playerTrans = Player.GetComponent<Transform> ();
	}

	void Update () {
		var x = CrossPlatformInputManager.GetAxis("Horizontal");
		var y = CrossPlatformInputManager.GetAxis("Vertical");
		var yRot = x * Time.deltaTime * rotScale;
		var xRot = y * Time.deltaTime * rotScale;
		var currentPos = Player.transform.position;
		parentTrans.RotateAround(parentTrans.position, playerTrans.right, xRot);
		Player.transform.RotateAround (parentTrans.position, playerTrans.up, yRot);
	}
}
