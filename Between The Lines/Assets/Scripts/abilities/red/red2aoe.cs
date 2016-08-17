using UnityEngine;
using System.Collections;

public class red2aoe : MonoBehaviour {

    public int damage;
    public float despawn;

    // Use this for initialization
    void Start () {

        damage = 20;
        despawn = .5f;

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
