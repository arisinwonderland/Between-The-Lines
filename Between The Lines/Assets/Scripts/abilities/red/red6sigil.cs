using UnityEngine;
using System.Collections;

public class red6sigil : MonoBehaviour {
    public bool abilityred;
    public int damage;
    public float despawn;
    public GameObject player;
    public player playerscript;
    public GameObject red6collider; 

    // Use this for initialization
    void Start()
    {

        damage = 15;
        despawn = 2.5f;

        player = GameObject.Find("Player");
        playerscript = player.GetComponent<player>();

        playerscript.rooted = true;
    }

    // Update is called once per frame
    void Update()
    {

        despawn -= Time.deltaTime;
        //Root
        if(despawn <= 2.25f)
        {
            playerscript.rooted = false;
        }

        //Wait for pillar
        if(despawn <= .5)
        {
            red6collider.GetComponent<SpriteRenderer>().enabled = true;
            red6collider.GetComponent<BoxCollider>().enabled = true;
        }
        //Despawn
        if (despawn <= 0)
        {
           
            Destroy(gameObject);

        }

    }
}
