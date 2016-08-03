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
        if (grounded == false && isjumping == false)
        {
            transform.Translate(Vector3.down*Time.deltaTime*4);
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
			if(grounded == true)
            {
                grounded = false;
                isjumping = true;
            }
		}
        if(isjumping == true)
        {
            transform.Translate(Vector3.up*10*Time.deltaTime);
            jumptimer += Time.deltaTime;
            if(jumptimer >= .25)
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
