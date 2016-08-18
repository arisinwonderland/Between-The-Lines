using UnityEngine;
using System.Collections;

public class blue2 : MonoBehaviour {

    public float blue2cd;
    public bool oncd;
    public float blue2timer;

    public GameObject player;

    public int buttonid;
    KeyCode button;

    public GameObject gamecontroller;
    public aspects aspects;
    public bool red;
    // Use this for initialization
    void Start () {
        aspects = gamecontroller.GetComponent<aspects>();
        blue2cd = 1f;
        player = GameObject.Find("Player");


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
        if (!red)
        {
            if (Input.GetKeyDown(button))
            {
                if (!oncd)
                {
                    blue2timer = blue2cd;
                    oncd = true;
                }
            }
        }

        //Cooldown Timer
        if (oncd)
        {
            player.transform.Translate(Vector3.up * 10 * Time.deltaTime);
            blue2timer -= Time.deltaTime;
            if (blue2timer <= 0)
            {
                oncd = false;
                blue2timer = 0;
            }
        }

    }
}
