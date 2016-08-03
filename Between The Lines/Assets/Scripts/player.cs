using UnityEngine;
using System.Collections;

public class player : MonoBehaviour {

	public bool grounded = false;
    public bool isjumping = false;
    public float jumptimer = 0;
    public bool midJump = false;

    public float gravity = 3f;

	public int moveSpeed = 5;

    public float antiGrav = 10;


    // Use this for initialization
    void Start () {
		
	}
    


    
    // Update is called once per frame
    void Update () {
        if (grounded)
        {
            jumptimer = 0;
            midJump = false;
            isjumping = false;
            gravity = 4f;
            jumptimer = 0;
            antiGrav = 10;
        }
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
		if (Input.GetKeyDown (KeyCode.Space) && !isjumping) {
			if(grounded == true)
            {
                grounded = false;
                isjumping = true;
            }
		}

        if(isjumping == true)
        {

            antiGrav = 10;




            if (!midJump)
            {
                transform.Translate(Vector3.up * antiGrav * Time.deltaTime);
            }
            else gravity = 4f;
            jumptimer += Time.deltaTime;
            if(jumptimer >= .25 && jumptimer <= .55 && midJump == false)
            {
                
                midJump = true;
            }

        }
<<<<<<< HEAD
=======


>>>>>>> sean
        if (!grounded)
        {
            transform.Translate(Vector3.down * gravity * Time.deltaTime);
        }






    }

<<<<<<< HEAD
	void OnTriggerEnter(Collider other) {
		if (other.gameObject.CompareTag ("Floor")) {
			grounded = true;
            isjumping = false;
		}
        if (other.gameObject.CompareTag("redfloor"))
        {
            grounded = true;
            isjumping = false;
        }
        if (other.gameObject.CompareTag("bluefloor"))
        {
            grounded = true;
            isjumping = false;
        }
    }
=======
	

>>>>>>> sean


	void move(Vector3 direction) {
		if (grounded) {
			transform.Translate (direction * moveSpeed * Time.deltaTime);
		} else {
			transform.Translate (direction * moveSpeed * Time.deltaTime);
            transform.Translate(direction * moveSpeed * Time.deltaTime / 4);
        }
	}
}
