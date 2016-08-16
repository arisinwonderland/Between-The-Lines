using UnityEngine;
using System.Collections;

public class blue1 : MonoBehaviour {

    public GameObject blue1cone;

    public float blue1cd;
    public bool oncd;
    public float blue1timer;

    // Use this for initialization
    void Start () {

        blue1cd = 3;

	}
	
	// Update is called once per frame
	void Update () {

        //shoot
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            if (!oncd)
            {
                shoot(new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z), gameObject.transform.rotation);
                blue1timer = blue1cd;
                oncd = true;
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
