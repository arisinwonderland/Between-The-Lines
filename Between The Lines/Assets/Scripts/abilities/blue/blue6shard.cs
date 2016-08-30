using UnityEngine;
using System.Collections;

public class blue6shard : MonoBehaviour {

	public int damage = 15;
	public bool abilityred;
	public GameObject player;
	public player playerscript;
	public float despawn = 1;

	// Use this for initialization
	void Start () {
		player = GameObject.Find("Player");
		playerscript = player.GetComponent<player>();

		playerscript.rooted = true;
	}

	// Update is called once per frame
	void Update () {

		despawn -= Time.deltaTime;

		if (despawn <= .25)
		{
			playerscript.rooted = false;
		}


		if (despawn <= 0)
		{
			Destroy(gameObject);
		}

	}

	public void EndAbility() {
		Destroy (gameObject);
	}
}
