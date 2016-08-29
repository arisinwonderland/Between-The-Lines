using UnityEngine;
using System.Collections;

public class red7blast : MonoBehaviour {

    public bool abilityred;
    public float despawn;
    public GameObject player;
    public player playerscript;
    public GameObject blast;
    public GameObject explosion;
    // Use this for initialization
    void Start()
    {

        despawn = 1f;

        player = GameObject.Find("Player");
        playerscript = player.GetComponent<player>();

    }

    // Update is called once per frame
    void Update()
    {

        despawn -= Time.deltaTime;

        if(despawn > .75f)
        {
            transform.Translate(Vector3.forward * 25 * Time.deltaTime);
        }

        if (despawn <= .75f)
        {
            blast.GetComponent<SpriteRenderer>().enabled = false;
            explosion.GetComponentInChildren<SpriteRenderer>().enabled = true;
            explosion.GetComponentInChildren<BoxCollider>().enabled = true;
        }
        if(despawn <= .5f)
        {
            explosion.GetComponentInChildren<SpriteRenderer>().enabled = false;
            explosion.GetComponentInChildren<BoxCollider>().enabled = false;
        }
        if(despawn <= 0)
        {
            Destroy(gameObject);
        }

    }
}
