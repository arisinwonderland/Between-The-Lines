using UnityEngine;
using System.Collections;

public class blue1cone : MonoBehaviour {

    public int damage;

    public GameObject player;

    public float despawn;

	// Use this for initialization
	void Start () {
        damage = 15;
        despawn = 1;
        player = GameObject.Find("player");
    }
	
	// Update is called once per frame
	void Update () {


        despawn -= Time.deltaTime;
        if (despawn <= 0)
        {
            Destroy(gameObject);
        }

    }
}
