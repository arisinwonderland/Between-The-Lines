using UnityEngine;
using System.Collections;

public class blue6shard : MonoBehaviour {

	public int damage;
	public float despawn;
	public float moveTime;
	public bool abilityred;
	public GameObject player;
	public GameObject sphere;
	public GameObject shard;
	public player playerscript;
	bool abilityEnded;
	Vector3 playerPos;

	// Use this for initialization
	void Start () {
		player = GameObject.Find("Player");
		playerscript = player.GetComponent<player>();
	}

	// Update is called once per frame
	void Update () {
		if (!abilityEnded) {
			despawn -= Time.deltaTime;

			if (despawn <= 0) {
				sphere.GetComponent<SphereCollider> ().enabled = false;
				sphere.GetComponent<MeshRenderer> ().enabled = false;
			}
		} else {
			gameObject.transform.position = Vector3.MoveTowards(transform.position, playerPos, Mathf.Abs(Vector3.Distance(playerPos,transform.position)) * Time.deltaTime / moveTime);

			despawn -= Time.deltaTime;

			if (despawn <= .25) {
				playerscript.rooted = false;
			}

			if (despawn <= 0) {
				Destroy(gameObject);
			}
		}
	}

	public void EndAbility(bool wasActivated) {
		if (wasActivated) {
			abilityEnded = true;
			playerscript.rooted = true;
			despawn = moveTime;
			playerPos = player.transform.position;
			shard.GetComponent<BoxCollider> ().enabled = true;
			Debug.Log ("A");
		} else {
			sphere.GetComponent<SphereCollider> ().enabled = true;
			sphere.GetComponent<MeshRenderer> ().enabled = true;
			sphere.GetComponent<AbilityStats>().damage = 10;
			despawn = 0.25F;
			Destroy (gameObject, 0.25F);
		}
	}
}
