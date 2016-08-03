using UnityEngine;
using System.Collections;

public class player : MonoBehaviour {

	public bool grounded = false;
    public bool isjumping = false;
    public float jumptimer = 0;

	public int moveSpeed = 10;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (grounded == false)
        {
            transform.Translate(Vector3.down / 10);
        }
        if (Input.GetKey (KeyCode.A)) {
			move (Vector3.left);
		} else if (Input.GetKey (KeyCode.D)) {
			move (Vector3.right);
		} else if (Input.GetKey (KeyCode.W)) {
			move (Vector3.forward);
		} else if (Input.GetKey (KeyCode.S)) {
			move (Vector3.back);
		}
		if (Input.GetKey (KeyCode.Space)) {
			if(grounded == true && isjumping == false)
            {
                grounded = false;
                isjumping = true;
            }
		}
        if(isjumping == true)
        {
            move(Vector3.up);
            jumptimer += Time.deltaTime;
            if(jumptimer >= 2)
            {
                jumptimer = 0;
                isjumping = false;
            }
        }
	}

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.CompareTag ("Floor")) {
			grounded = true;
            isjumping = false;
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
