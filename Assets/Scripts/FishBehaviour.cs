using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishBehaviour : MonoBehaviour {

	bool selected = false;

	// Use this for initialization
	void Start () {
		InvokeRepeating("ChangePosition", 0, 2);
	}
	
	// Update is called once per frame
	void Update () {
		if (selected && Input.GetKey (KeyCode.Space)) {
			doAction ();
		}
	}

	void OnMouseDown () {
		selected = true;
	}

	void doAction() {
		Debug.Log ("ACTION!");
	}

	void ChangePosition() {
		Vector3 curPosition = transform.position;
		curPosition.x += 0.5F;
		transform.position = curPosition;
	}
}
