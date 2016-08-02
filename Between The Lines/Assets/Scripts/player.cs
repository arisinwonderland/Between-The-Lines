using UnityEngine;
using System.Collections;

public class player : MonoBehaviour {

	public bool grounded = false;
	public int moveSpeed = 10;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.A)) {
			move (Vector3.left);
		} else if (Input.GetKey (KeyCode.D)) {
			move (Vector3.right);
		} else if (Input.GetKey (KeyCode.W)) {
			move (Vector3.up);
		} else if (Input.GetKey (KeyCode.S)) {
			move (Vector3.down);
		}
		if (Input.GetKey (KeyCode.Space)) {
			
		}
	}

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.CompareTag ("Floor")) {
			grounded = true;
		}
	}

	void OnTriggerExit(Collider other) {
		if (other.gameObject.CompareTag ("Floor")) {
			grounded = false;
		}
	}

	void move(Vector3 direction) {
		if (grounded) {
			transform.Translate (direction * moveSpeed * Time.deltaTime);
		} else {
			transform.Translate (direction * moveSpeed * Time.deltaTime / 2);
		}
	}
}
