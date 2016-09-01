using UnityEngine;
using System.Collections;

public class red2aoe : MonoBehaviour {

    public int damage;
    public float despawn;
    public bool abilityred;
    // Use this for initialization
    void Start () {

        damage = 20;
        despawn = .7f;

    }
	
	// Update is called once per frame
	void Update () {

        despawn -= Time.deltaTime;
        if(despawn <= .6f)
        {
            gameObject.GetComponent<BoxCollider>().enabled = true;
        }
        if (despawn <= 0)
        {
            Destroy(gameObject);
        }

    }
}
