using UnityEngine;
using System.Collections;

public class bow : MonoBehaviour {

    public GameObject arrow;

    public float bowcd;
    public bool oncd;
    public float bowtimer;

	// Use this for initialization
	void Start () {
        bowcd = 1;
	}
	
	// Update is called once per frame
	void Update () {

        //Bow shoot
        if (Input.GetKeyDown(KeyCode.Mouse0)){ 
            if (!oncd)
            {
                shoot(new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z), gameObject.transform.rotation);
                bowtimer = bowcd;
                oncd = true;
            }
        }

        //Cooldown Timer
        if (oncd)
        {
            bowtimer -= Time.deltaTime;
            if (bowtimer <= 0)
            {
                oncd = false;
                bowtimer = 0;
            }
        }


    }

    void shoot(Vector3 pos, Quaternion angle)
    {
        Instantiate(arrow, pos, angle);
    }

}
