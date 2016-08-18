using UnityEngine;
using System.Collections;

public class blue1 : MonoBehaviour {

    public GameObject blue1cone;

    public float blue1cd;
    public bool oncd;
    public float blue1timer;

    public int buttonid;
    KeyCode button;

    public GameObject gamecontroller;
    public aspects aspects;
    public bool red;
    // Use this for initialization
    void Start () {
        aspects = gamecontroller.GetComponent<aspects>();
        blue1cd = 3;

        if (buttonid == 0)
        {
            button = KeyCode.Alpha1;
        }
        else if (buttonid == 1)
        {
            button = KeyCode.Alpha2;
        }
        else if (buttonid == 2)
        {
            button = KeyCode.Alpha3;
        }

    }
	
	// Update is called once per frame
	void Update () {
        red = aspects.red;
        //shoot
        if (!red)
        {
            if (Input.GetKeyDown(button))
            {
                if (!oncd)
                {
                    shoot(new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z), gameObject.transform.rotation);
                    blue1timer = blue1cd;
                    oncd = true;
                }
            }
        }

        //Cooldown Timer
        if (oncd)
        {
            blue1timer -= Time.deltaTime;
            if (blue1timer <= 0)
            {
                oncd = false;
                blue1timer = 0;
            }
        }

    }

    void shoot(Vector3 pos, Quaternion angle)
    {
        Instantiate(blue1cone, pos, angle);
    }
}
