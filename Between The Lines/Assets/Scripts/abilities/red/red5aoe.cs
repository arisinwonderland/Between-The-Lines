using UnityEngine;
using System.Collections;

public class red5aoe : MonoBehaviour {

    public bool abilityred;
    public int damage;
    public float despawn;
    public GameObject player;
    public player playerscript;

    // Use this for initialization
    void Start () {

        damage = 15;
        despawn = .5f;

        player = GameObject.Find("Player");
        playerscript = player.GetComponent<player>();

        playerscript.rooted = true;
    }
	
	// Update is called once per frame
	void Update () {

        despawn -= Time.deltaTime;
        if (despawn <= 0)
        {
            playerscript.rooted = false;
            Destroy(gameObject);

        }

    }
}
