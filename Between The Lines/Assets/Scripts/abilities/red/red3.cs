using UnityEngine;
using System.Collections;

public class red3 : MonoBehaviour {

    public GameObject red3dash;

    public GameObject player;

    public float red3cd;
    public bool oncd;
    public float red3timer;

    public int buttonid;

    public float dashtime;

    KeyCode button;

    // Use this for initialization
    void Start () {
        red3cd = 8;

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

        if (Input.GetKeyDown(button))
        {
            if (!oncd)
            {
                shoot(new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z), gameObject.transform.rotation);
                red3timer = red3cd;
                oncd = true;
                dashtime = 0;  
            }
        }

        //Cooldown Timer
        if (oncd)
        {
            red3timer -= Time.deltaTime;
            dashtime += Time.deltaTime;

            //dash
            if (dashtime <= .4f)
            {
                player.transform.Translate(Vector3.forward * Time.deltaTime * 100);
            }
            else if (dashtime > .4f)
            {

            }

            if (red3timer <= 0)
            {
                oncd = false;
                red3timer = 0;
            }
        }

        


    }
    void shoot(Vector3 pos, Quaternion angle)
    {
        Instantiate(red3dash, pos, angle);
    }
}
