using UnityEngine;
using System.Collections;

public class swordslash : MonoBehaviour {

    public int damage;
    public GameObject player;
    public player playerscript;
    public float despawn;
    public sword sword;

    // Use this for initialization
    void Start()
    {
        damage = 10;
        despawn = .15f;

        player = GameObject.Find("Player");
        playerscript = player.GetComponent<player>();
        sword = player.GetComponentInChildren<sword>();

        playerscript.rooted = true;

    }

    // Update is called once per frame
    void Update()
    {

        despawn -= Time.deltaTime;
        if (despawn <= 0)
        {
            playerscript.rooted = false;
            Destroy(gameObject);
        }

    }

    }

