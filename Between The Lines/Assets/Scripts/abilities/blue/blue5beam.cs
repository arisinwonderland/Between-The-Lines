using UnityEngine;
using System.Collections;

public class blue5beam : MonoBehaviour {

    public int damage;

    public GameObject player;
    public player playerscript;
    public float despawn;

    // Use this for initialization
    void Start () {
        damage = 15;
        despawn = 3f;
       
        player = GameObject.Find("Player");
        playerscript = player.GetComponent<player>();

        playerscript.rooted = true;
    }
	
	// Update is called once per frame
	void Update () {

        transform.Rotate(300 * Time.deltaTime, 0, 0);

        despawn -= Time.deltaTime;
        if (despawn <= 0)
        {
            playerscript.rooted = false;
            Destroy(gameObject);
        }
    }
}

