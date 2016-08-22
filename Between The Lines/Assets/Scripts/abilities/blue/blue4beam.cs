using UnityEngine;
using System.Collections;

public class blue4beam : MonoBehaviour {


    public int damage;
    public bool abilityred;
    public GameObject player;
    public player playerscript;
    public float despawn;

    // Use this for initialization
    void Start () {
        damage = 15;
        despawn = .25f;

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
