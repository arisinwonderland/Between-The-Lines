using UnityEngine;
using System.Collections;

public class red3dash : MonoBehaviour {

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
	}
	
	// Update is called once per frame
	void Update () {

		lastPos = player.transform.localPosition;
        player.transform.Translate(Vector3.forward * Time.deltaTime * 50);
        transform.Translate(Vector3.forward * Time.deltaTime * 50);

        despawn -= Time.deltaTime;
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
