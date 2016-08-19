using UnityEngine;
using System.Collections;

public class blue2dash : MonoBehaviour {

    public GameObject player;

    public int damage;

    public float despawn;

    // Use this for initialization
    void Start () {
        damage = 5;
        despawn = .2f;
        player = GameObject.Find("Player");
    }
	
	// Update is called once per frame
	void Update () {

        player.transform.Translate(Vector3.up * Time.deltaTime * 50);
        transform.Translate(Vector3.up * Time.deltaTime * 50);

        despawn -= Time.deltaTime;
        if (despawn <= 0)
        {
            Destroy(gameObject);
        }
    }
}

