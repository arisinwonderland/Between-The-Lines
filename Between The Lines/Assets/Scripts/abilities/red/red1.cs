using UnityEngine;
using System.Collections;

public class red1 : MonoBehaviour {

    public GameObject red1orb;

    public float red1cd;
    public bool oncd;
    public float red1timer;

    public int buttonid;

    KeyCode button;
    // Use this for initialization
    void Start () {
        red1cd = 3;


        if(buttonid == 0)
        {
            button = KeyCode.Alpha1;
        }else if(buttonid == 1)
        {
            button = KeyCode.Alpha2;
        }
        else if(buttonid == 2)
        {
            button = KeyCode.Alpha3;
        }
	}
	
	// Update is called once per frame
	void Update () {

        //shoot
        if (Input.GetKeyDown(button))
        {
            if (!oncd)
            {
                shoot(new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z), gameObject.transform.rotation);
                red1timer = red1cd;
                oncd = true;
            }
        }

        //Cooldown Timer
        if (oncd)
        {
            red1timer -= Time.deltaTime;
            if (red1timer <= 0)
            {
                oncd = false;
                red1timer = 0;
            }
        }
    }



        void shoot(Vector3 pos, Quaternion angle)
        {
            Instantiate(red1orb, pos, angle);
        }
}
