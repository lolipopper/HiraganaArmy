using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatBehaviour : MonoBehaviour {

	// Use this for initialization
	void Start () {
		InvokeRepeating("ChangePosition", 0, 2);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void ChangePosition() {
		Vector3 curPosition = transform.position;
		curPosition.x -= 0.5F;
		transform.position = curPosition;
	}
}
