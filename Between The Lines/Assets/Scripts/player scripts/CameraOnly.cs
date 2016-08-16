using UnityEngine;
using System.Collections;

public class CameraOnly : MonoBehaviour
{

    float x;
    float y;

    float looklimit;

    public GameObject feets;
    public GameObject player;

    // Use this for initialization
    void Start()
    {
        transform.eulerAngles = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {


        x = transform.eulerAngles.x;
        y = transform.eulerAngles.y;

        if (x < 310 && x > 180)
        {
            looklimit = 0;
            if (x > 210)
            {
                transform.eulerAngles = new Vector3(x + 1, 0, 0);
                x = transform.eulerAngles.x;
            }
            else if (x < 210)
            {
                transform.eulerAngles = new Vector3(x - 1, 0, 0);
                x = transform.eulerAngles.x;
            }


        }
        else
        {
            looklimit = 1;
        }


        player.transform.eulerAngles = new Vector3(0, y + 1, 0);

        transform.eulerAngles = new Vector3(x - Input.GetAxis("Mouse Y") * looklimit, 0, 0);
        //feets.transform.eulerAngles = new Vector3(0, y + 1, 0);
        //feets.transform.position = new Vector3(transform.position.x, transform.position.y - 1, transform.position.z)    ;
        //x - Input.GetAxis("Mouse Y") * looklimit 
    }
}
