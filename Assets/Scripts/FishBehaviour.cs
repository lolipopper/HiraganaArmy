using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishBehaviour : MonoBehaviour {

	bool selected = false;

	bool go;
	Coroutine walkRoutine;

	// Use this for initialization
	void Start () {
		walkRoutine = StartCoroutine(ChangePosition());
	}
	
	// Update is called once per frame
	void Update () {
		if (selected && Input.GetKey (KeyCode.Space)) {
			doAction ();
		}

		if (go) {
			Vector3 curPosition = transform.position;
			curPosition.x += 0.035F;
			transform.position = curPosition;
		}
	}

	void OnMouseDown () {
		selected = true;
	}

	void doAction() {
		print ("ACTION!");
	}

	IEnumerator ChangePosition() {
		while (true) {
			go = true;
			yield return new WaitForSeconds (2);
			go = false;
			yield return new WaitForSeconds (2);
		}

	}

	void OnCollisionEnter2D(Collision2D other){
		if (other.gameObject.tag.Equals ("Fish")) {
			print ("Coll");
			StopCoroutine (walkRoutine);
			go = false;
		}
	}

	void OnCollisionExit2D(Collision2D other){
		print ("Exit");
	}
}
