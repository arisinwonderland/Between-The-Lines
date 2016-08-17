using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class player : MonoBehaviour {

	public bool grounded = false;
	public bool isjumping = false;
	public bool midJump = false;
	public bool carryingObject = false;
    public float jumptimer = 0;

    public float gravity = 3f;

	public int moveSpeed = 5;

    public float antiGrav = 10;
    public bool stopped;
    public float Timer;
    public GameObject feets;

    public GameObject gamecontroller;
    public aspects aspects;
    public bool red;

    public GameObject GameManager;
    public gamemanager gamemanager;
    string current;

    public int hp;
    public int redmana;
    public int bluemana;

    // Use this for initialization
    void Start () {

        Timer = 0;

        gamecontroller = GameObject.Find("GameController");
        aspects = gamecontroller.GetComponent<aspects>();

        GameManager = GameObject.Find("gamemanager");
        gamemanager = GameManager.GetComponent<gamemanager>();

        //Stats
        hp = 100;
        redmana = 50;
        bluemana = 50;

        for (int num = 0; num <= 2; num++)
        {
            if(num == 0)
            {
                current = gamemanager.selectedability1;
            }
            else if(num == 1)
            {
                current = gamemanager.selectedability2;
            }
            else if(num == 2)
            {
                current = gamemanager.selectedability3;
            }
         


            if (current == "firebolt")  
            {
                gameObject.GetComponentInChildren<red1>().enabled = true;

                gameObject.GetComponentInChildren<red1>().buttonid = num;

            }
            else if (current == "surgeofflame")
            {
                gameObject.GetComponentInChildren<red2>().enabled = true;

                gameObject.GetComponentInChildren<red1>().buttonid = num;

            }
            else if (current == "flamedash")
            {
                gameObject.GetComponentInChildren<red3>().enabled = true;

                gameObject.GetComponentInChildren<red1>().buttonid = num;

            }
            else
            {

            }

        }
    }   


    


    
    // Update is called once per frame
    void Update () {

        //Get state
        red = aspects.red;

        //Grounded stuff
        if (grounded)
        {
            jumptimer = 0;
            midJump = false;
            isjumping = false;
            gravity = 4f;
            jumptimer = 0;
            antiGrav = 10;
        }

        //Movement
        if (Input.GetKey (KeyCode.A)) {
			move (Vector3.left);
		} else if (Input.GetKey (KeyCode.D)) {
			move (Vector3.right);
		} else if (Input.GetKey (KeyCode.W)) {
			move (Vector3.forward);
		} else if (Input.GetKey (KeyCode.S)) {
			move (Vector3.back);
		}

        //Jumping
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



    }

    void OnCollisionEnter(Collision other) {
        
        if (other.gameObject.CompareTag("Floor"))
        {
            grounded = true;
            isjumping = false;
			midJump = false;
            transform.position = new Vector3(this.transform.position.x, other.transform.position.y + 2, this.transform.position.z);
        }

        else if (other.gameObject.CompareTag("redfloor"))
        {
            grounded = true;
			isjumping = false;
			midJump = false;
            transform.position = new Vector3(this.transform.position.x, other.transform.position.y + 2, this.transform.position.z);
        }
        else if (other.gameObject.CompareTag("redblock"))
        {
            grounded = true;
			isjumping = false;
			midJump = false;
            transform.position = new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z);
        }
        else if (other.gameObject.CompareTag("blueblock"))
        {
            grounded = true;
			isjumping = false;
			midJump = false;
            transform.position = new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z);
        }
        else if (other.gameObject.CompareTag("bluefloor"))
        {
            grounded = true;
			isjumping = false;
			midJump = false;
            transform.position = new Vector3(this.transform.position.x, other.transform.position.y + 2, this.transform.position.z);
        } else grounded = false;

    }

    void OnCollisionStay(Collision other)
    {
        if (other.gameObject.CompareTag("Floor"))
        {
            grounded = true;
            isjumping = false;
            midJump = false;
            transform.position = new Vector3(this.transform.position.x, other.transform.position.y + 2, this.transform.position.z);
        }

        else if (other.gameObject.CompareTag("redfloor"))
        {
            grounded = true;
            isjumping = false;
            midJump = false;
            transform.position = new Vector3(this.transform.position.x, other.transform.position.y + 2, this.transform.position.z);
        }
        else if (other.gameObject.CompareTag("redblock"))
        {
            grounded = true;
            isjumping = false;
            midJump = false;
            transform.position = new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z);
        }
        else if (other.gameObject.CompareTag("blueblock"))
        {
            grounded = true;
            isjumping = false;
            midJump = false;

            transform.position = new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z);
        }
        else if (other.gameObject.CompareTag("bluefloor"))
        {
            grounded = true;
            isjumping = false;
            midJump = false;
            transform.position = new Vector3(this.transform.position.x, other.transform.position.y + 2, this.transform.position.z);
        }
        else grounded = false;

    }

    void OnCollisionExit(Collision other)
    {
        if (other.gameObject.CompareTag("Floor"))
        {
            grounded = false;
        }
        else if (other.gameObject.CompareTag("redfloor"))
        {
            grounded = false;
        }
        else if (other.gameObject.CompareTag("bluefloor"))
        {
            grounded = false;
        }
        else if (other.gameObject.CompareTag("blueblock"))
        {
            grounded = false;
        }
        else if (other.gameObject.CompareTag("redblock"))
        {
            grounded = false;
        }
    }

    public static void IgnoreLayerCollision(int layer1, int layer2, bool ignore = true)
    {
            

    }

    void move(Vector3 direction) {
		if (grounded) {
			transform.Translate (direction * moveSpeed * Time.deltaTime);
		} else {
			transform.Translate (direction * moveSpeed * Time.deltaTime);
            transform.Translate(direction * moveSpeed * Time.deltaTime / 4);
        }
	}
}
