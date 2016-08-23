using UnityEngine;
using System.Collections;

public class red3dash : MonoBehaviour {

    public GameObject player;
    public bool abilityred;
    public int damage;
    public player playerscript;
    public float despawn;

	// Use this for initialization
	void Start () {
        damage = 5;
        despawn = .5f;
        player = GameObject.Find("Player");
        playerscript = player.GetComponent<player>();
        playerscript.rooted = true;
	}
	
	// Update is called once per frame
	void Update () {

        player.transform.Translate(Vector3.forward * Time.deltaTime * 25);
        transform.Translate(Vector3.forward * Time.deltaTime * 25);

        despawn -= Time.deltaTime;
        if (despawn <= 0)
        {
            playerscript.rooted = false;
            Destroy(gameObject);
        }
    }
}
