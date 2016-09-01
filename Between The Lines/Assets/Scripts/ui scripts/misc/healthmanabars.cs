using UnityEngine;
using System.Collections;

public class healthmanabars : MonoBehaviour {
	
	public GameObject entity;
	public player playerScript;
	public enemy enemyScript;
	public int barNum;

	// Use this for initialization
	void Start () {
		if (barNum <= 2) {
			entity = GameObject.Find ("Player");
			playerScript = entity.GetComponent<player> ();
		} else {
			entity = this.transform.parent.parent.gameObject;
			enemyScript = entity.GetComponent<enemy> ();
		}
	}
	
	// Update is called once per frame
	void Update () {
		switch (barNum) { 
		case 0:
			transform.localScale = new Vector3 (playerScript.hp * 0.006F, 1F, 1F);
			break;
		case 1:
			transform.localScale = new Vector3 (playerScript.redmana * 0.006F, 1F, 1F);
			break;
		case 2:
			transform.localScale = new Vector3 (playerScript.bluemana * 0.006F, 1F, 1F);
			break;
		case 3: 
			transform.localScale = new Vector3 (enemyScript.hp / 50F * 13F, 1F, 1F);
			transform.localPosition = new Vector3 (0.65F-(0.65F * enemyScript.hp / 50F), 0, 0);
			break;
		}
	}
}
