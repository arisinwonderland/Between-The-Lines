using UnityEngine;
using System.Collections;

public class mouseCamera : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
       
    }

    void FixedUpdate()
    {
        if (Input.GetAxis("Mouse X") < 0)
        {
            //Code for action on mouse moving left
            transform.Rotate(new Vector3(0, -6, 0));
        }
        if (Input.GetAxis("Mouse X") > 0)
        {
            //Code for action on mouse moving right
            transform.Rotate(new Vector3(0, 6, 0));
        }
    }
}
