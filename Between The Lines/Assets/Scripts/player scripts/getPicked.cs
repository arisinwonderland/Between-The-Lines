using UnityEngine;
using System.Collections;

public class getPicked : MonoBehaviour {

	player playerScript;

	public GameObject obj;
    public GameObject camera;
    public bool picked;
    public bool good;
    public float Timer;

	// Use this for initialization
	void Start () {
        Timer = 0;
		playerScript = GameObject.Find ("Player").GetComponent<player>();
        obj = GameObject.Find("Hands");
        good = false;
	}


	void OnTriggerStay(Collider other)
	{
		if (other.gameObject.CompareTag("Hands")){
			if (Input.GetKeyDown(KeyCode.E) && picked == false && good && !playerScript.carryingObject)
            {
                picked = true;
                good = false;
				playerScript.carryingObject = true;
                Timer = 0;
            }


		}

        if (this.CompareTag("redblock"))
        {
            if (other.gameObject.CompareTag("redfield"))
            {
                picked = false;
                playerScript.carryingObject = false;
            }
        }

        if (this.CompareTag("blueblock"))
        {
            if (other.gameObject.CompareTag("bluefield"))
            {
                picked = false;
                playerScript.carryingObject = false;
            }
        }
    }


	// Update is called once per frame
	void Update () {
        Timer += Time.deltaTime;
		if (picked && good){
            transform.position = obj.transform.position;
            transform.eulerAngles = new Vector3(0, 0, 0);

                if (Input.GetKeyDown(KeyCode.E) && picked == true )
                {
                    picked = false;
					good = false;
					playerScript.carryingObject = false;
                    Timer = 0;
                }

        }
        if (Timer > 0.6)
        {
            good = true;
        }
	}

}