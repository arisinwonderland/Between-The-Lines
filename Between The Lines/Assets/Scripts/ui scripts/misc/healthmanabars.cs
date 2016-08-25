using UnityEngine;
using System.Collections;

public class healthmanabars : MonoBehaviour {
	
	public GameObject player;
	public player playerScript;
	public int barNum;

	// Use this for initialization
	void Start () {
		player = GameObject.Find("Player");
		playerScript = player.GetComponent<player>();
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
		}
	}
}
