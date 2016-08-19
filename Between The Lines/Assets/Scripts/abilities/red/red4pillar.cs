using UnityEngine;
using System.Collections;

public class red4pillar : MonoBehaviour {

    public int damage;
    public float despawn;
    public GameObject player;
    public player playerscript;

    // Use this for initialization
    void Start () {

        damage = 20;
        despawn = 1.5f;

        player = GameObject.Find("Player");
        playerscript = player.GetComponent<player>();

        playerscript.rooted = true;
    }
	
	// Update is called once per frame
	void Update () {
        despawn -= Time.deltaTime;

        if(despawn <= 1)
        {
            playerscript.rooted = false;
        }

        if (despawn <= 0)
        {
            Destroy(gameObject);
        }
    }
}
