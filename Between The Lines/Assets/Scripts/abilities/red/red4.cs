using UnityEngine;
using System.Collections;

public class red4 : MonoBehaviour {

    public GameObject red4pillar;

    public float red4cd;
    public bool oncd;
    public float red4timer;

    public int buttonid;

    KeyCode button;

    public GameObject gamecontroller;
    public aspects aspects;
    public bool red;

    // Use this for initialization
    void Start () {
        
           red4cd = 5;

        aspects = gamecontroller.GetComponent<aspects>();

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


    void Update()
    {
        red = aspects.red;
        //shoot
        if (red)
        {
            if (Input.GetKeyDown(button))
            {
                if (!oncd)
                {
                    shoot(new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z), gameObject.transform.rotation);
                    red4timer = red4cd;
                    oncd = true;
                }
            }
        }
        //Cooldown Timer
        if (oncd)
        {
            red4timer -= Time.deltaTime;
            if (red4timer <= 0)
            {
                oncd = false;
                red4timer = 0;
            }
        }
    }

    void shoot(Vector3 pos, Quaternion angle)
    {
        Instantiate(red4pillar, pos + Vector3.forward, angle);
    }
}
