using UnityEngine;
using System.Collections;

public class mouseScreen : MonoBehaviour {
    public Vector3 vecs;
    public GameObject player;
	// Use this for initialization
	void Start () {
        vecs= new Vector3(gameObject.transform.eulerAngles.x, 0, 0);

    }
	
	// Update is called once per frame
	void Update () {
        //&& transform.localEulerAngles.y < 0
        if (Input.GetAxis("Mouse Y") < 0 )
        {
            //Code for action on mouse moving left
            transform.Rotate(new Vector3(3, 0, 0));
        }
        if (Input.GetAxis("Mouse Y") > 0 )
        {
            //Code for action on mouse moving right
            transform.Rotate(new Vector3(-3, 0, 0));
        }

      //  vecs = new Vector3(gameObject.transform.eulerAngles.x, 0, 0);
     //   gameObject.transform.eulerAngles =  vecs;

        transform.position = new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z);
       

    }
}
