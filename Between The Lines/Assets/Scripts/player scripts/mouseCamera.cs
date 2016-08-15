using UnityEngine;
using System.Collections;

public class mouseCamera : MonoBehaviour {

    float x;
    float y;

    float looklimit;

    public GameObject feets;
    public GameObject player;

    // Use this for initialization
    void Start () {
        transform.eulerAngles = new Vector3(0, 0, 0);
    }
	
	// Update is called once per frame
	void Update () {
     
    }

    void FixedUpdate()
    {


        x = transform.eulerAngles.x;
        y = transform.eulerAngles.y;

        if(x < 320 && x > 45)
        {
            looklimit = 0;
            if(x > 180)
            {
                transform.eulerAngles = new Vector3(x + 3, 0, 0);
                x = transform.eulerAngles.x;
            }
            else if(x < 180)
            {
                transform.eulerAngles = new Vector3(x - 3, 0, 0);
                x = transform.eulerAngles.x;
            }
           

        }
        else
        {
            looklimit = 1;
        }


        player.transform.eulerAngles = new Vector3(0, y, 0);
        transform.eulerAngles = new Vector3(x - Input.GetAxis("Mouse Y") * looklimit, y + Input.GetAxis("Mouse X"), 0);
        feets.transform.eulerAngles = new Vector3(0, y, 0);
        feets.transform.position = new Vector3(transform.position.x, transform.position.y - 1, transform.position.z)    ;

    }
}
