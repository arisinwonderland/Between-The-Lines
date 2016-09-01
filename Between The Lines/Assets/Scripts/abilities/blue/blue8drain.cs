using UnityEngine;
using System.Collections;

public class blue8drain : MonoBehaviour {

	public GameObject player;
	player playerScript;

	GameObject currentEnemy;
	enemy enemyScript;

	public int damage;
	public bool abilityred;
	public bool active;
	public float despawn;

	public bool draining;
	float damageDealt;
	float damageDrained;
	int currentDamage;
	int currentDrain;


	// Use this for initialization
	void Start () {
		player = GameObject.Find("Player");
		playerScript = player.GetComponent<player> ();
	}

	// Update is called once per frame
	void Update () {
		if (active) {
			if (!draining) {
				gameObject.transform.Translate (Vector3.forward * 20 * Time.deltaTime);

				despawn -= Time.deltaTime;

				if (despawn <= 0) {
					Destroy (gameObject);
				}

			} else {
				gameObject.transform.position = currentEnemy.transform.position + new Vector3 (-0.01F, 0, 0);
				damageDealt += Time.deltaTime * damage;
				damageDrained += Time.deltaTime * damage * 0.75F;
				currentDamage = Mathf.FloorToInt (damageDealt);
				currentDrain = Mathf.FloorToInt (damageDealt);
				if (currentDamage > 0) {
					if (enemyScript.hp >= currentDamage) {
						enemyScript.hp -= currentDamage;
					} else {
						enemyScript.hp = 0;
					}
					damageDealt -= currentDamage;
				}
				if (currentDrain > 0) {
					if (playerScript.hp + currentDrain < 100) {
						playerScript.hp += currentDrain;
					} else {
						playerScript.hp = 100;
					}
					damageDrained -= currentDrain;
				}
				if (enemyScript.hp == 0) {
					active = false;
					gameObject.GetComponentInChildren<MeshRenderer> ().enabled = false;
					playerScript.rooted = false;
					playerScript.hp += Mathf.CeilToInt (damageDrained);
				}
			}
		}
	}

	public void startDrain(GameObject enemy) {
		if (!draining) {
			draining = true;
			currentEnemy = enemy;
			enemyScript = currentEnemy.GetComponent<enemy> ();
			playerScript.rooted = true;
			gameObject.GetComponentInChildren<SphereCollider> ().enabled = false;
		}
	}

	public void EndAbility(bool wasActivated) {
		if (draining) {
			playerScript.rooted = false;
		}
		Destroy (gameObject);
	}
}
