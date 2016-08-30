using UnityEngine;
using System.Collections;

public class red7blast : MonoBehaviour {

    public bool abilityred;
    public float despawn;
    public GameObject player;
    public player playerscript;
    public GameObject explosion;
    public GameObject blast;
    bool task1done;

    // Use this for initialization
    void Start()
    {
        task1done = false;


        despawn = 0;

        player = GameObject.Find("Player");
        playerscript = player.GetComponent<player>();

    }

    // Update is called once per frame
    void Update()
    {

        despawn += Time.deltaTime;

        if(despawn < .25f)
        {
            if (!task1done)
            {
                transform.Translate(Vector3.forward * 25 * Time.deltaTime);
            }
        }

        if (despawn >= .25f)
        {
            if (!task1done)
            {
                task1done = true;
                task1();
            }
        }
       
        if(despawn >= 1)
        {
            
            Destroy(gameObject);
        }

    }

    void task1()
    {
        blast.GetComponent<SpriteRenderer>().enabled = false;
        gameObject.GetComponent<BoxCollider>().enabled = false;
        explosion.GetComponentInChildren<SpriteRenderer>().enabled = true;
        explosion.GetComponentInChildren<BoxCollider>().enabled = true;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            if (abilityred == other.gameObject.GetComponent<enemy>().EnemyRed)
            {
                task1done = true;
                task1();
            }
        }
    }
}
