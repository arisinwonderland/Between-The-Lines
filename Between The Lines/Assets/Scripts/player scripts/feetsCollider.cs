using UnityEngine;
using System.Collections;

public class feetsCollider : MonoBehaviour {

    public GameObject player;
    public player PlayerScript;
    public float timer;

    // Use player for initialization
    void Start() {
        player = GameObject.Find("Player");
        PlayerScript = player.GetComponent<player>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}


    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Floor") || other.gameObject.CompareTag("redfloor") || other.gameObject.CompareTag("bluefloor"))
        {
            PlayerScript.grounded = true;
            PlayerScript.isjumping = false;
            PlayerScript.midJump = false;
            //player.transform.position = new Vector3(player.transform.position.x, other.transform.position.y + 2, player.transform.position.z);
            PlayerScript.gravity = false;

        }

    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Floor") || other.gameObject.CompareTag("redfloor") || other.gameObject.CompareTag("bluefloor"))
        {
            PlayerScript.grounded = true;
            PlayerScript.isjumping = false;
            PlayerScript.midJump = false;
            //player.transform.position = new Vector3(player.transform.position.x, other.transform.position.y + 2, player.transform.position.z);
            PlayerScript.gravity = false;
            if (PlayerScript.holdingWall)
            {
                PlayerScript.holdingWall = false;
                PlayerScript.wallGrabReady = false;
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        
        if (other.gameObject.CompareTag("Floor"))
        {
            PlayerScript.grounded = false;
            PlayerScript.gravity = true;
        }
        else if (other.gameObject.CompareTag("redfloor"))
        {
            PlayerScript.grounded = false;
            PlayerScript.gravity = true;
        }
        else if (other.gameObject.CompareTag("bluefloor"))
        {
            PlayerScript.grounded = false;
            PlayerScript.gravity = true;
        }
    }



}
