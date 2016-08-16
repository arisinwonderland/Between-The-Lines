using UnityEngine;
using System.Collections;

public class red2 : MonoBehaviour {

    public GameObject red2aoe;

    public float red2cd;
    public bool oncd;
    public float red2timer;

    // Use this for initialization
    void Start () {
        red2cd = 5  ;
	}
	
	// Update is called once per frame
	void Update () {

        //shoot
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            if (!oncd)
            {
                shoot(new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z));
                red2timer = red2cd;
                oncd = true;
            }
        }

        //Cooldown Timer
        if (oncd)
        {
            red2timer -= Time.deltaTime;
            if (red2timer <= 0)
            {
                oncd = false;
                red2timer = 0;
            }
        }
    }

    void shoot(Vector3 pos)
    {
        Instantiate(red2aoe, pos, Quaternion.identity);
    }
}
