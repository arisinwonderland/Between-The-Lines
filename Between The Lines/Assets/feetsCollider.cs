using UnityEngine;
using System.Collections;

public class feetsCollider : MonoBehaviour {

    public GameObject player;
    public player PlayerScript;

    // Use player for initialization
    void Start() {
        player = GameObject.Find("Player");
        PlayerScript = player.GetComponent<player>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}


    void OnCollisionEnter(Collision other)
    {

        if (other.gameObject.CompareTag("Floor"))
        {
            PlayerScript.grounded = true;
            PlayerScript.isjumping = false;
            PlayerScript.midJump = false;
            player.transform.position = new Vector3(player.transform.position.x, other.transform.position.y + 2, player.transform.position.z);
        }

        else if (other.gameObject.CompareTag("redfloor"))
        {
            PlayerScript.grounded = true;
            PlayerScript.isjumping = false;
            PlayerScript.midJump = false;
            player.transform.position = new Vector3(player.transform.position.x, other.transform.position.y + 2, player.transform.position.z);
        }
        else if (other.gameObject.CompareTag("redblock"))
        {
            PlayerScript.grounded = true;
            PlayerScript.isjumping = false;
            PlayerScript.midJump = false;
            player.transform.position = new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z);
        }
        else if (other.gameObject.CompareTag("blueblock"))
        {
            PlayerScript.grounded = true;
            PlayerScript.isjumping = false;
            PlayerScript.midJump = false;
            player.transform.position = new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z);
        }
        else if (other.gameObject.CompareTag("bluefloor"))
        {
            PlayerScript.grounded = true;
            PlayerScript.isjumping = false;
            PlayerScript.midJump = false;
            player.transform.position = new Vector3(player.transform.position.x, other.transform.position.y + 2, player.transform.position.z);
        }
        else PlayerScript.grounded = false;

    }

    void OnCollisionStay(Collision other)
    {
        if (other.gameObject.CompareTag("Floor"))
        {
            PlayerScript.grounded = true;
            PlayerScript.isjumping = false;
            PlayerScript.midJump = false;
            player.transform.position = new Vector3(player.transform.position.x, other.transform.position.y + 2, player.transform.position.z);
        }

        else if (other.gameObject.CompareTag("redfloor"))
        {
            PlayerScript.grounded = true;
            PlayerScript.isjumping = false;
            PlayerScript.midJump = false;
            player.transform.position = new Vector3(player.transform.position.x, other.transform.position.y + 2, player.transform.position.z);
        }
        else if (other.gameObject.CompareTag("redblock"))
        {
            PlayerScript.grounded = true;
            PlayerScript.isjumping = false;
            PlayerScript.midJump = false;
            player.transform.position = new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z);
        }
        else if (other.gameObject.CompareTag("blueblock"))
        {
            PlayerScript.grounded = true;
            PlayerScript.isjumping = false;
            PlayerScript.midJump = false;

            player.transform.position = new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z);
        }
        else if (other.gameObject.CompareTag("bluefloor"))
        {
            PlayerScript.grounded = true;
            PlayerScript.isjumping = false;
            PlayerScript.midJump = false;
            player.transform.position = new Vector3(player.transform.position.x, other.transform.position.y + 2, player.transform.position.z);
        }
        else PlayerScript.grounded = false;

    }

    void OnCollisionExit(Collision other)
    {
        if (other.gameObject.CompareTag("Floor"))
        {
            PlayerScript.grounded = false;
        }
        else if (other.gameObject.CompareTag("redfloor"))
        {
            PlayerScript.grounded = false;
        }
        else if (other.gameObject.CompareTag("bluefloor"))
        {
            PlayerScript.grounded = false;
        }
        else if (other.gameObject.CompareTag("blueblock"))
        {
            PlayerScript.grounded = false;
        }
        else if (other.gameObject.CompareTag("redblock"))
        {
            PlayerScript.grounded = false;
        }
    }
}
