using UnityEngine;
using System.Collections;

public class red3dash : MonoBehaviour {


    public GameObject dash;
    public GameObject dashyThing;

    public GameObject player;
    public bool abilityred;
    public int damage;

    public float despawn;

	Vector3 lastPos;
	bool moving;

	// Use this for initialization
	void Start () {
        damage = 5;
        despawn = .2f;
        player = GameObject.Find("Player");
		moving = true;
        dash = GameObject.Find("dash");
        dashyThing = GameObject.Find("dashyThing");
    }
	
	// Update is called once per frame
	void Update () {

		lastPos = player.transform.localPosition;
        player.transform.Translate(Vector3.forward * Time.deltaTime * 50);
        transform.Translate(Vector3.forward * Time.deltaTime * 50);

        despawn -= Time.deltaTime;


        //dash.transform.position = player.transform.position;
        //dash.transform.rotation = player.transform.rotation;
       //dashyThing.transform.position = player.transform.position;
        //dashyThing.transform.rotation = player.transform.rotation;

        if (despawn <= 0 || (!moving))
        {
			player.transform.localPosition = lastPos;
            Destroy(gameObject);
        }
    }
	void OnTriggerEnter(Collider c) {
		if (c.CompareTag ("Wall") || c.CompareTag ("redwall")) {
			moving = false;
		}
	}
}
