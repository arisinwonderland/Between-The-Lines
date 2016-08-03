using UnityEngine;
using System.Collections;

public class mouseScreen : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetAxis("Mouse Y") < 0 )
        {
            //Code for action on mouse moving left
            transform.Rotate(new Vector3(3, 0, 0));
        }
        if (Input.GetAxis("Mouse Y") > 0)
        {
            //Code for action on mouse moving right
            transform.Rotate(new Vector3(-3, 0, 0));
        }


        gameObject.transform.eulerAngles = new Vector3(gameObject.transform.eulerAngles.x, gameObject.transform.eulerAngles.y, 0);
       

    }
}
