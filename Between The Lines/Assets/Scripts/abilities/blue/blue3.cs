using UnityEngine;
using System.Collections;

public class blue3 : MonoBehaviour {

    public GameObject blue3orb;

    public float blue3cd;
    public bool oncd;
    public float blue3timer;

    // Use this for initialization
    void Start () {

        blue3cd = 10f;

    }
	    
	// Update is called once per frame
	void Update () {

        //shoot
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            if (!oncd)
            {
                shoot(new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z), gameObject.transform.rotation);
                blue3timer = blue3cd;
                oncd = true;
            }
        }

        //Cooldown Timer
        if (oncd)
        {
            blue3timer -= Time.deltaTime;
            if (blue3timer <= 0)
            {
                oncd = false;
                blue3timer = 0;
            }
        }
    }

    void shoot(Vector3 pos, Quaternion angle)
    {
        Instantiate(blue3orb, pos, angle);
    }
}
