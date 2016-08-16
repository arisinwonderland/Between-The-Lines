using UnityEngine;
using System.Collections;

public class blue2 : MonoBehaviour {

    public float blue2cd;
    public bool oncd;
    public float blue2timer;

    public GameObject player;

    // Use this for initialization
    void Start () {

        blue2cd = 1f;
        player = GameObject.Find("Player");

	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            if (!oncd)
            {
                blue2timer = blue2cd;
                oncd = true;
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
