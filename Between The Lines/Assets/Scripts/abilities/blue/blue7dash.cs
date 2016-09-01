using UnityEngine;
using System.Collections;

public class blue7dash : MonoBehaviour {

    public GameObject player;
    public bool abilityred;
    public int damage;
	public float despawn;

	Vector3 lastPos;
	Vector3 initialPos;
	SpriteRenderer playerSprite;
	BoxCollider playerCollider;
	player playerScript;
	bool abilityEnded;
	bool moving;
	bool dashStopped;


	// Use this for initialization
	void Start () {
        despawn = .2f;
		player = GameObject.Find("Player");
		playerSprite = player.GetComponentInChildren<SpriteRenderer> ();
		playerCollider = player.GetComponent<BoxCollider> ();
		playerScript = player.GetComponent<player> ();
		initialPos = player.transform.position;
		moving = true;
    }
	
	// Update is called once per frame
	void Update () {
		if (!abilityEnded) {
			if (!dashStopped) {
				lastPos = player.transform.localPosition;
				player.transform.Translate (Vector3.forward * Time.deltaTime * 50);
				gameObject.transform.Translate (Vector3.forward * Time.deltaTime * 50);

				despawn -= Time.deltaTime;

				if (despawn <= 0 || (!moving)) {
					player.transform.localPosition = lastPos;
					gameObject.GetComponentInChildren<ParticleSystem> ().Stop ();
					dashStopped = true;
				}
			}
		} else {
			player.transform.position = Vector3.MoveTowards(player.transform.position, initialPos, Time.deltaTime * 50);
			gameObject.transform.position = player.transform.position;

			if (player.transform.position == initialPos) {
				playerSprite.enabled = true;
				playerCollider.enabled = true;
				playerScript.rooted = false;
				Destroy (gameObject);
			}
		}
    }
	void OnTriggerEnter(Collider c) {
		if (c.CompareTag ("Wall") || c.CompareTag ("redwall")) {
			moving = false;
		}
	}

	public void EndAbility(bool wasActivated) {
		
		if (dashStopped && wasActivated) {
			abilityEnded = true;
			playerScript.rooted = true;
			playerSprite.enabled = false;
			playerCollider.enabled = false;
			gameObject.GetComponentInChildren<MeshRenderer> ().enabled = true;
		} else if (!wasActivated) {
			Destroy (gameObject);
		}
	}
}
