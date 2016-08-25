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

        else if (other.gameObject.CompareTag("bluefloor"))
        {
            PlayerScript.grounded = true;
            PlayerScript.isjumping = false;
            PlayerScript.midJump = false;
            player.transform.position = new Vector3(player.transform.position.x, other.transform.position.y + 2, player.transform.position.z);
        }

    }

    void OnTriggerStay(Collider other)
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
       
        else if (other.gameObject.CompareTag("bluefloor"))
        {
            PlayerScript.grounded = true;
            PlayerScript.isjumping = false;
            PlayerScript.midJump = false;
            player.transform.position = new Vector3(player.transform.position.x, other.transform.position.y + 2, player.transform.position.z);
        }
        

    }

    void OnTriggerExit(Collider other)
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
     }



}
